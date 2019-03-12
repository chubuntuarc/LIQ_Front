Imports System.Windows.Forms.DataVisualization.Charting
Imports Microsoft.Office.Interop.Excel

Public Class Codigo_ABC
#Region "EVENTOS_BOTONES"
    Public Shared Sub PG_BT_ELIMINAR_CLICK(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView, Optional ByVal PP_SP As String = "")
        Dim VP_ID As String
        Dim VP_NOM As String
        Try
            If Codigo_LI.FG_LI_ROW_SELECTED(PP_LISTADO) Then
                Dim VP_ROW As Integer
                VP_ROW = Codigo_LI.FG_LI_ROW_CURRENT(PP_LISTADO)
                VP_ID = PP_FORMA.FM_ID_SELECCIONADO(PP_LISTADO, VP_ROW)
                VP_NOM = PP_FORMA.FM_DESC_SELECCIONADO(PP_LISTADO, VP_ROW)

                Dim VP_DECISION As Boolean
                VP_DECISION = Codigo_Mensaje.FG_MENSAJE_ELIMINAR(VP_ID, VP_NOM)

                If VP_DECISION Then
                    Dim VP_PARAMETROS As String
                    VP_PARAMETROS = VP_ID
                    Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
                    Dim VP_SP As String
                    If PP_SP = "" Then
                        VP_SP = Codigo_SQL.FG_SP_LIST(PP_FORMA)
                    Else
                        VP_SP = PP_SP
                    End If

                    VP_SP = Codigo_SQL.FG_SP_Delete(PP_FORMA)
                    Dim VP_EXITO As Boolean = False
                    VP_EXITO = Codigo_SQL.FG_SQL_EJECUTAR_OPERACION(PP_FORMA, PP_BD_Index, VP_SP, VP_PARAMETROS)

                    Codigo_LI.PG_LI_RESET(PP_BD_Index, PP_FORMA, PP_LISTADO, VP_EXITO)
                End If
            End If
        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_BT_ELIMINAR_CLICK")
        End Try
    End Sub

    Public Shared Sub PG_BT_BUSCAR_CLICK(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView, Optional ByVal PP_SP As String = "")
        PP_FORMA.Cursor = Cursors.WaitCursor
        Try
            Dim VP_PARAMETROS As String
            VP_PARAMETROS = PP_FORMA.FM_SQL_LISTADO()

            Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
            Dim VP_STORED_PROCEDURE As String

            If PP_SP = "" Then
                VP_STORED_PROCEDURE = Codigo_SQL.FG_SP_LIST(PP_FORMA)
            Else
                VP_STORED_PROCEDURE = PP_SP
            End If

            Dim VP_TABLA As Data.DataTable
            VP_TABLA = Codigo_SQL.FG_SP_EXECUTE_DATATABLE(PP_BD_Index, VP_STORED_PROCEDURE, VP_PARAMETROS)
            If VP_TABLA.Rows.Count > 500 Then
                If Codigo_Mensaje.FG_MENSAJE_CONFIRMACION("La busqueda arrojó mas de 500 registros." + vbCrLf + "¿Desea mostrarlos?") Then
                    Codigo_LI.PG_LI_LOAD(PP_FORMA, PP_LISTADO, VP_TABLA)
                End If
            Else
                Codigo_LI.PG_LI_LOAD(PP_FORMA, PP_LISTADO, VP_TABLA)
            End If
            Dim VP_REGISTROS As String
            VP_REGISTROS = VP_TABLA.Rows.Count().ToString()
            PP_FORMA.LB_RESULTADO.Text = "Resultado de la operación: " + VP_REGISTROS + " registros." + Environment.NewLine + PP_FORMA.LB_RESULTADO.Text
        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_BT_BUSCAR_CLICK")
        End Try
        PP_FORMA.Cursor = Cursors.Default
    End Sub

    Public Shared Sub PG_BT_GUARDAR_CLICK(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView, Optional ByVal PP_SP As String = "")
        Try
            Dim VP_MENSAJE_VALIDACION As String = ""
            Dim VP_VALIDACION As Boolean

            VP_VALIDACION = PP_FORMA.FM_SAVE_VALIDATE(VP_MENSAJE_VALIDACION)
            If VP_VALIDACION = False Then
                Codigo_Mensaje.PG_MENSAJE_GUARDAR_VALIDAR(VP_MENSAJE_VALIDACION)
            Else
                Dim VP_NUEVO As Boolean

                Dim VP_PARAMETROS As String
                VP_PARAMETROS = PP_FORMA.FM_FI_SQL(VP_NUEVO)

                Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)

                Dim VP_SP As String

                If VP_NUEVO Then
                    VP_SP = Codigo_SQL.FG_SP_Insert(PP_FORMA)
                Else
                    VP_SP = Codigo_SQL.FG_SP_Update(PP_FORMA)

                End If

                If PP_SP <> "" Then
                    VP_SP = PP_SP
                End If


                Dim VP_DECISION As Boolean
                VP_DECISION = Codigo_Mensaje.FG_MENSAJE_GUARDAR(VP_NUEVO)

                Dim VP_EXITO As Boolean = False
                If VP_DECISION Then
                    VP_EXITO = Codigo_SQL.FG_SQL_EJECUTAR_OPERACION(PP_FORMA, PP_BD_Index, VP_SP, VP_PARAMETROS)
                End If
                Codigo_LI.PG_LI_RESET(PP_BD_Index, PP_FORMA, PP_LISTADO, VP_EXITO)
            End If


        Catch ex As Exception

            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_BT_GUARDAR_CLICK")
        End Try


    End Sub

    Public Shared Sub PG_BT_GUARDAR_ESPECIAL_CLICK(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByVal PP_SP As String)
        Try
            Dim VP_MENSAJE_VALIDACION As String = ""
            Dim VP_VALIDACION As Boolean

            VP_VALIDACION = PP_FORMA.FM_SAVE_VALIDATE(VP_MENSAJE_VALIDACION)

            If VP_VALIDACION = False Then
                Codigo_Mensaje.PG_MENSAJE_GUARDAR_VALIDAR(VP_MENSAJE_VALIDACION)
            Else
                Dim VP_NUEVO As Boolean

                Dim VP_PARAMETROS As String
                VP_PARAMETROS = PP_FORMA.FM_FI_SQL(VP_NUEVO)

                Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)

                Dim VP_EXITO As Boolean = False
                VP_EXITO = Codigo_SQL.FG_SQL_EJECUTAR_OPERACION(PP_FORMA, PP_BD_Index, PP_SP, VP_PARAMETROS)

            End If

        Catch ex As Exception

            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_BT_GUARDAR_ESPECIAL_CLICK")
        End Try


    End Sub

    Public Shared Sub PG_BT_EJECUTAR_ACCION_TABLA_CLICK(ByVal PP_BD_Index As Integer, ByVal PP_FORMA As Object, ByVal PP_SP As String, ByVal PP_PARAMETROS As String, ByRef PP_DATATABLE As Data.DataTable)
        Try

            Dim VP_PARAMETROS As String = PP_PARAMETROS
            Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
            PP_DATATABLE = Codigo_SQL.FG_SP_EXECUTE_DATATABLE(PP_BD_Index, PP_SP, VP_PARAMETROS)

        Catch ex As Exception

            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_BT_EJECUTAR_ACCION_TABLA_CLICK")
        End Try

    End Sub

    Public Shared Sub PG_BT_EJECUTAR_ACCION_CLICK(ByVal PP_BD_Index As Integer, ByVal PP_FORMA As Object, ByVal PP_SP As String, ByVal PP_PARAMETROS As String, ByRef PP_CLAVE As Integer, ByRef PP_MENSAJE As String)
        Try

            Dim VP_PARAMETROS As String = PP_PARAMETROS
            Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)

            Dim VP_EXITO As Boolean

            VP_EXITO = Codigo_SQL.FG_SQL_EJECUTAR_ACCION_int(PP_BD_Index, PP_SP, VP_PARAMETROS, PP_CLAVE, PP_MENSAJE)

        Catch ex As Exception

            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_BT_EJECUTAR_ACCION_CLICK")
        End Try

    End Sub

    Public Shared Sub PG_BT_INICIAR_SESION_CLICK(ByRef PP_FORMA As Object, ByRef PP_BD_Index As Integer)

        Try
            Dim VP_MENSAJE_VALIDACION As String = ""
            Dim VP_VALIDACION As Boolean

            VP_VALIDACION = PP_FORMA.FM_SAVE_VALIDATE(VP_MENSAJE_VALIDACION)

            If VP_VALIDACION = False Then
                Codigo_Mensaje.PG_MENSAJE_INFORMACION("No es posible acceder al sistema." + Environment.NewLine + Environment.NewLine + VP_MENSAJE_VALIDACION + Environment.NewLine + Environment.NewLine + "Por favor verifique.")
            Else

                Dim VP_PARAMETROS As String = ""

                VP_PARAMETROS = FG_PARAMETROS_SQL(PP_FORMA)

                Dim VP_SP As String
                VP_SP = Codigo_SQL.FG_SP_LOG()

                Codigo_SQL.FG_CONNECTION_GET(PP_BD_Index)

                If VG_DESARROLLO = 1 Then
                    VP_SP = Codigo_SQL.FG_SP_LOG_DESARROLLO()
                    Dim VP_PASSWORD_DESARROLLO As String = ""
                    VP_PASSWORD_DESARROLLO = InputBox("INGRESE PASSWORD DE DESARROLLO", "SE REQUIERE PASSWORD", "1")
                    Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, VP_PASSWORD_DESARROLLO, True)
                End If

                Dim VP_EXITO As Boolean

                VP_EXITO = Codigo_SQL.FG_SQL_EJECUTAR_ACCION_int(PP_BD_Index, VP_SP, VP_PARAMETROS)


                If VP_EXITO Then
                    Dim VP_BOARD As New FO_BOARD2()
                    VP_BOARD.PM_FO_SHOW(PP_BD_Index)
                    PP_FORMA.Close()
                    VG_CULTURE_INFO = Codigo_SQL.FG_CULTURE_INFO_GET(PP_BD_Index)
                End If

            End If
        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_BT_INICIAR_SESION_CLICK")
        End Try
    End Sub

    Public Shared Sub PG_BT_EDITAR_CLICK(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
        Dim VP_ID As String
        Try

            If Codigo_LI.FG_LI_ROW_SELECTED(PP_LISTADO) Then
                If PP_FORMA.VM_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP1_Listado Then 'este if es por si esta en la lista y quiere cargar la ficha y editarla
                    Dim VP_ROW As Integer = Codigo_LI.FG_LI_ROW_CURRENT(PP_LISTADO)

                    VP_ID = PP_FORMA.FM_ID_SELECCIONADO(PP_LISTADO, VP_ROW)

                    PP_FORMA.PM_FI_LOAD(VP_ID)

                End If
                If PP_FORMA.VM_IN_MODO_OPERACION <> MOP_Modo_Operacion.MOP3_Edicion Then
                    PP_FORMA.VM_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP3_Edicion
                    Codigo_FRM.PG_FRM_CONFIG(PP_FORMA)
                End If
            End If
        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_BT_EDITAR_CLICK")
        End Try
    End Sub

    Public Shared Sub PG_BT_CLONAR_CLICK(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
        Dim VP_ID As String
        Try
            If Codigo_LI.FG_LI_ROW_SELECTED(PP_LISTADO) Then 'este if es por si esta en la lista y quiere cargar la ficha y editarla
                Dim VP_ROW As Integer = Codigo_LI.FG_LI_ROW_CURRENT(PP_LISTADO)
                VP_ID = PP_FORMA.FM_ID_SELECCIONADO(PP_LISTADO, VP_ROW)
                PP_FORMA.VM_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP4_Clon
                PP_FORMA.PM_FI_LOAD(VP_ID)
                Codigo_FRM.PG_FRM_CONFIG(PP_FORMA)
                PP_FORMA.VM_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP3_Edicion
            End If
        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_BT_EDITAR_CLICK")
        End Try
    End Sub

    Public Shared Sub PG_BT_AGREGAR_CLICK(ByRef PP_FORMA As Object)
        Try
            PP_FORMA.VM_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP3_Edicion
            Codigo_FRM.PG_FRM_CONFIG(PP_FORMA)
            PP_FORMA.PM_FI_LOAD("")
        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_BT_AGREGAR_CLICK")
        End Try
    End Sub

    Public Shared Sub PG_BT_CANCELAR_CLICK(ByRef PP_FORMA As Object)
        On Error Resume Next
        PP_FORMA.VM_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP1_Listado
        Codigo_FI.PG_FI_CONTROL_CLEAR(PP_FORMA.GB_FICHA)
        Codigo_FRM.PG_FRM_CONFIG(PP_FORMA)
        On Error GoTo 0
    End Sub

    Public Shared Sub PG_BT_LISTADO_CLICK(ByRef PP_FORMA As Object)
        On Error Resume Next
        PP_FORMA.VM_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP1_Listado
        Codigo_FI.PG_FI_CONTROL_CLEAR(PP_FORMA.GB_FICHA)
        Codigo_FRM.PG_FRM_CONFIG(PP_FORMA)
        On Error GoTo 0
    End Sub

    Public Shared Sub PG_BT_SALIR_CLICK(ByRef PP_FORMA As Object)
        On Error Resume Next
        PP_FORMA.TI_RELOJ.Stop()
        'Codigo_FRM.PG_FRM_INIT(VM_BD_Index, PP_FORMA)
        Codigo_FI.PG_FI_CONTROL_CLEAR(PP_FORMA.GB_FICHA)
        'If FO_BOARD.IsHandleCreated Then
        '    FO_BOARD.MENU_LOAD(FO_BOARD)
        'End If

        'PP_FORMA.Close()
        Dim VP_TABPAGE As TabPage = PP_FORMA.Parent
        Dim VP_TABCONTROL As TabControlEx = VP_TABPAGE.Parent
        VP_TABCONTROL.TabPages.Remove(VP_TABPAGE)
        On Error GoTo 0
    End Sub

    Public Shared Sub PG_BT_EXPORTAR_EXCEL_CLICK(ByRef PP_LISTADO As DataGridView)
        Try
            PG_PORTAPAPELES_COPIAR(PP_LISTADO)
            Dim xlexcel As Application
            Dim xlWorkBook As Workbook
            Dim xlWorkSheet As Worksheet
            Dim misValue As Object = Reflection.Missing.Value
            xlexcel = New Application With {
                .Visible = True
            }
            xlWorkBook = xlexcel.Workbooks.Add(misValue)
            xlWorkSheet = CType(xlWorkBook.Worksheets(1), Worksheet)
            Dim CR As Range
            CR = CType(xlWorkSheet.Cells(1, 1), Range)
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, True)

            Dim VP_INICIO As Integer
            VP_INICIO = PP_LISTADO.Columns.GetColumnCount(DataGridViewElementStates.Visible)

            Dim letra As String
            letra = FG_COLUMN_NAME_GET(VP_INICIO)

            Dim VP_FIN As String
            VP_FIN = letra + CR.Rows.Count.ToString()

            xlWorkSheet.Range("A1", VP_FIN).EntireColumn.AutoFit()
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("")
        End Try
    End Sub

    Public Shared Sub PG_BT_ACEPTAR_CLICK(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView, Optional ByVal PP_SP As String = "")
        Try
            Dim VP_MENSAJE_VALIDACION As String = ""
            Dim VP_VALIDACION As Boolean

            VP_VALIDACION = PP_FORMA.FM_SAVE_VALIDATE(VP_MENSAJE_VALIDACION)

            If VP_VALIDACION = False Then
                Codigo_Mensaje.PG_MENSAJE_GUARDAR_VALIDAR(VP_MENSAJE_VALIDACION)
            Else
                Dim VP_NUEVO As Boolean

                Dim VP_PARAMETROS As String
                VP_PARAMETROS = PP_FORMA.FM_FI_SQL(VP_NUEVO)

                Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)

                Dim VP_SP As String

                If VP_NUEVO Then
                    VP_SP = Codigo_SQL.FG_SP_VERSION(PP_FORMA)
                Else
                    VP_SP = Codigo_SQL.FG_SP_Update(PP_FORMA)
                End If

                If PP_SP <> "" Then
                    VP_SP = PP_SP
                End If

                Dim VP_EXITO As Boolean = False
                VP_EXITO = Codigo_SQL.FG_SQL_EJECUTAR_ACCION_obj(PP_FORMA, PP_BD_Index, VP_SP, VP_PARAMETROS)
                If VP_EXITO Then
                    PP_FORMA.PM_LI_SAVE(PP_BD_Index, PP_FORMA, PP_LISTADO)
                    Codigo_LI.PG_LI_RESET(PP_BD_Index, PP_FORMA, PP_LISTADO, VP_EXITO)
                    PP_FORMA.VM_ID_VERSION = ""
                    PP_FORMA.CB_TIPO_VERSION_PYC.SELECTEDINDEX = 1
                End If
            End If
        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_BT_ACEPTAR_CLICK")
        End Try
    End Sub

    Public Shared Sub PG_BT_ANADIR_CLICK(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
        Try
            Dim VP_PARAMETROS As String
            VP_PARAMETROS = PP_FORMA.FM_FI_SQL_PYC()

            Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)

            Dim VP_SP As String
            VP_SP = Codigo_SQL.FG_SP_Insert_Update(PP_FORMA)

            Dim VP_EXITO As Boolean = False
            VP_EXITO = Codigo_SQL.FG_SQL_EJECUTAR_OPERACION(PP_FORMA, PP_BD_Index, VP_SP, VP_PARAMETROS)

            PP_FORMA.VM_IN_MODO_OPERACION = MOP_Modo_Operacion.MOP1_Listado
            Codigo_FRM.PG_FRM_CONFIG(PP_FORMA)
            Codigo_LI.PG_LI_RESET(PP_BD_Index, PP_FORMA, PP_LISTADO, VP_EXITO)

        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_BT_ANADIR_CLICK")
        End Try
    End Sub

    Public Shared Sub PG_BT_ACTUALIZAR_CLICK(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
        Try
            Dim VP_PARAMETROS As String = ""

            VP_PARAMETROS = PP_FORMA.FM_UP_VERSION_SQL()

            Dim VP_SP As String
            VP_SP = Codigo_SQL.FG_SP_Update_VER(PP_FORMA)

            Dim VP_EXITO As Boolean = False
            VP_EXITO = Codigo_SQL.FG_SQL_EJECUTAR_ACCION_obj(PP_FORMA, PP_BD_Index, PP_LISTADO, VP_SP, VP_PARAMETROS)

            PP_FORMA.PM_BT_BUSCAR_CLICK(PP_FORMA, PP_LISTADO)
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_BT_ACTUALIZAR_CLICK")
        End Try
    End Sub

    Public Shared Sub PG_BT_NUEVO_CLICK(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView)
        Dim VP_ID As String
        Try

            Dim VP_NO_VACIO As Boolean = False
            If VER_MOSTRAR(PP_FORMA, PP_LISTADO, 4) Then
                Dim VP_ROW As Integer = Codigo_LI.FG_LI_ROW_CURRENT(PP_LISTADO)

                VP_ID = PP_FORMA.FM_ID_SELECCIONADO(PP_LISTADO, VP_ROW)

                PP_FORMA.PM_FI_LOAD(VP_ID)

            End If
        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_BT_NUEVO_CLICK")
        End Try

    End Sub

    'Public Shared Sub PG_BT_BUSCAR_MASIVO_CLICK(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
    '    PP_FORMA.Cursor = Cursors.WaitCursor

    '    'Descomentar el if para comprobar el grid contrario.
    '    'Dim VP_GRUPO_VACIO As Boolean
    '    '  VP_GRUPO_VACIO = Codigo_LI.FG_LI_NOT_EMPTY(PP_FORMA.LI_LISTADO_GRUPO)

    '    Dim VP_TABLA As New Data.DataTable

    '    ' If VP_GRUPO_VACIO Then

    '    Dim VP_PARAMETROS As String
    '    VP_PARAMETROS = PP_FORMA.FM_SQL_LISTADO_MASIVO()

    '    Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)

    '    Dim VP_STORED_PROCEDURE As String
    '    VP_STORED_PROCEDURE = Codigo_SQL.FG_SQL_LIST_MASIVO(PP_FORMA)


    '    VP_TABLA = Codigo_SQL.FG_SP_EXECUTE_DATATABLE(PP_FORMA.VM_BD_Index, VP_STORED_PROCEDURE, VP_PARAMETROS)

    '    Codigo_LI.PG_LI_LOAD(PP_FORMA, PP_LISTADO, VP_TABLA)

    '    '   End If

    '    PP_FORMA.Cursor = Cursors.Default
    '    Dim VP_REGISTROS As String
    '    VP_REGISTROS = VP_TABLA.Rows.Count().ToString()
    '    PP_FORMA.LB_RESULTADO.Text = "Resultado de la operacion: " + VP_REGISTROS + " registros."
    'End Sub

    Public Shared Sub PG_BT_BUSCAR_MASIVO_CLICK(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
        Try
            PP_FORMA.Cursor = Cursors.WaitCursor

            Dim VP_PARAMETROS As String
            VP_PARAMETROS = PP_FORMA.FM_SQL_LISTADO()

            Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)

            Dim VP_STORED_PROCEDURE As String
            VP_STORED_PROCEDURE = Codigo_SQL.FG_SP_LIST_MASIVO(PP_FORMA)

            Dim VP_TABLA As Data.DataTable
            VP_TABLA = Codigo_SQL.FG_SP_EXECUTE_DATATABLE(PP_BD_Index, VP_STORED_PROCEDURE, VP_PARAMETROS)

            Codigo_LI.PG_LI_LOAD(PP_FORMA, PP_LISTADO, VP_TABLA)

            PP_FORMA.Cursor = Cursors.Default
            Dim VP_REGISTROS As String
            VP_REGISTROS = VP_TABLA.Rows.Count().ToString()
            PP_FORMA.LB_RESULTADO.Text = "Resultado de la operación: " + VP_REGISTROS + " registros." + Environment.NewLine + PP_FORMA.LB_RESULTADO.Text
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_BT_BUSCAR_MASIVO_CLICK")
        End Try

    End Sub

    Public Shared Sub PG_BT_LI_BUSCAR(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView, Optional ByVal PP_SP As String = "")
        Try
            PP_FORMA.Cursor = Cursors.WaitCursor

            Dim VP_PARAMETROS As String
            VP_PARAMETROS = FG_PARAMETROS_SQL(PP_FORMA)



            Dim VP_STORED_PROCEDURE As String
            VP_STORED_PROCEDURE = Codigo_SQL.FG_SP_LIST_USUARIOS_GRUPO(PP_FORMA)

            If PP_SP <> "" Then
                VP_STORED_PROCEDURE = PP_SP
            End If

            PG_DATOS_SQL(PP_BD_Index, PP_FORMA, PP_LISTADO, VP_STORED_PROCEDURE, VP_PARAMETROS)

        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_BT_LI_BUSCAR")
        End Try
    End Sub

    Public Shared Sub PG_CB_GRUPO_SELECTIONCHANGEDCOMMINTTED(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
        Try
            PP_FORMA.Cursor = Cursors.WaitCursor

            Dim VP_PARAMETROS As String
            VP_PARAMETROS = FG_PARAMETROS_SQL(PP_FORMA)

            Dim VP_STORED_PROCEDURE As String
            VP_STORED_PROCEDURE = Codigo_SQL.FG_SP_LIST_USUARIOS_GRUPO(PP_FORMA)

            PG_DATOS_SQL(PP_BD_Index, PP_FORMA, PP_LISTADO, VP_STORED_PROCEDURE, VP_PARAMETROS)

            VP_PARAMETROS = ""

            VP_PARAMETROS = PP_FORMA.FM_GRUPO_SELECCIONADO_CORREOS(PP_LISTADO)

            PP_FORMA.TB_CORREO.Text = VP_PARAMETROS
        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_CB_GRUPO_SELECTIONCHANGEDCOMMINTTED")
        End Try
    End Sub

    Public Shared Sub PG_LI_LISTADO_GRUPO_CELLDOUBLECLICK(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
        Dim VP_PARAMETROS As String = "1,"
        Try
            If Codigo_LI.FG_LI_ROW_SELECTED(PP_LISTADO) Then
                Dim VP_ROW As Integer = Codigo_LI.FG_LI_ROW_CURRENT(PP_LISTADO)

                VP_PARAMETROS = VP_PARAMETROS + PP_FORMA.FM_ID_SELECCIONADO(PP_LISTADO, VP_ROW)

                VP_PARAMETROS = VP_PARAMETROS + ",0, 0," + PP_FORMA.FM_SQL_LISTADO()
                Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)

                Dim VP_STORED_PROCEDURE As String
                VP_STORED_PROCEDURE = Codigo_SQL.FG_SP_Insert(PP_FORMA)

                Dim VP_EXITO As Boolean
                VP_EXITO = Codigo_SQL.FG_SQL_EJECUTAR_OPERACION(PP_FORMA, PP_BD_Index, VP_STORED_PROCEDURE, VP_PARAMETROS)
                PP_FORMA.PM_BT_BUSCAR_CLICK(PP_FORMA, PP_FORMA.LI_LISTADO)
                PP_FORMA.PM_BT_BUSCAR_MASIVO_CLICK(PP_FORMA, PP_FORMA.LI_LISTADO_GRUPO)
            End If
        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_BT_EDITAR_CLICK")
        End Try
    End Sub

    Public Shared Sub PG_LI_LISTADO_CELLDOUBLECLICK(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
        Dim VP_PARAMETROS As String = ""
        Try

            If Codigo_LI.FG_LI_ROW_SELECTED(PP_LISTADO) Then
                Dim VP_ROW As Integer = Codigo_LI.FG_LI_ROW_CURRENT(PP_LISTADO)

                VP_PARAMETROS = PP_FORMA.FM_ID_SELECCIONADO_BORRAR(PP_LISTADO, VP_ROW)

                Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)

                Dim VP_STORED_PROCEDURE As String
                VP_STORED_PROCEDURE = Codigo_SQL.FG_SP_Delete(PP_FORMA)

                Dim VP_EXITO As Boolean
                VP_EXITO = Codigo_SQL.FG_SQL_EJECUTAR_OPERACION(PP_FORMA, PP_BD_Index, VP_STORED_PROCEDURE, VP_PARAMETROS)

                If VP_EXITO Then
                    PP_FORMA.PM_BT_BUSCAR_CLICK(PP_FORMA, PP_FORMA.LI_LISTADO)
                    PP_FORMA.PM_BT_BUSCAR_MASIVO_CLICK(PP_FORMA, PP_FORMA.LI_LISTADO_GRUPO)

                End If

            End If
        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_BT_EDITAR_CLICK")
        End Try
    End Sub

    Public Shared Sub PG_BT_ELIMINAR_MASIVO_CLICK(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)

        Dim VP_PARAMETROS As String = ""
        Dim VP_TABLA As Data.DataTable
        Dim VP_MENSAJE As String = ""
        Try

            VP_PARAMETROS = PP_FORMA.FM_ID_SELECCIONADO(PP_LISTADO, PP_FORMA.VM_ID_ROW)

            Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)

            Dim VP_SP As String
            VP_SP = Codigo_SQL.FG_SP_Delete(PP_FORMA)

            Dim VP_EXITO As Boolean = False
            VP_TABLA = Codigo_SQL.FG_SP_EXECUTE_DATATABLE(PP_BD_Index, VP_SP, VP_PARAMETROS)

            VP_MENSAJE = Codigo_LI.FG_LI_CELL_READ(VP_TABLA, 0, "MENSAJE")

            If VP_MENSAJE <> "" Then
                PP_FORMA.LB_RESULTADO.Text = "Resultado de la operación: " + VP_MENSAJE + Environment.NewLine + PP_FORMA.LB_RESULTADO.Text

            End If

        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_BT_ELIMINAR_MASIVO_CLICK")
        End Try
    End Sub

    Public Shared Sub PG_BT_GUARDAR_MASIVO_CLICK(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
        Try

            Dim VP_NUEVO As Boolean
            Dim VP_TABLA As Data.DataTable
            Dim VP_MENSAJE As String = ""

            Dim VP_PARAMETROS As String
            VP_PARAMETROS = PP_FORMA.FM_FI_SQL(VP_NUEVO)

            Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)

            Dim VP_SP As String

            If VP_NUEVO Then
                VP_SP = Codigo_SQL.FG_SP_Insert(PP_FORMA)
            Else
                VP_SP = Codigo_SQL.FG_SP_Update(PP_FORMA)

            End If

            Dim VP_EXITO As Boolean = False
            VP_TABLA = Codigo_SQL.FG_SP_EXECUTE_DATATABLE(PP_BD_Index, VP_SP, VP_PARAMETROS)

            VP_MENSAJE = Codigo_LI.FG_LI_CELL_READ(VP_TABLA, 0, "MENSAJE")

            If VP_MENSAJE <> "" Then
                PP_FORMA.LB_RESULTADO.Text = "Resultado de la operación: " + VP_MENSAJE + Environment.NewLine + PP_FORMA.LB_RESULTADO.Text

            End If

        Catch ex As Exception

            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_BT_GUARDAR_MASIVO_CLICK")
        End Try


    End Sub

#End Region

#Region "SUBS"

    Public Shared Sub PG_PORTAPAPELES_COPIAR(PP_LISTADO)
        Try
            PP_LISTADO.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
            PP_LISTADO.MultiSelect = True
            PP_LISTADO.SelectAll()
            Dim dataObj As DataObject = PP_LISTADO.GetClipboardContent
            If (Not (dataObj) Is Nothing) Then
                Clipboard.SetDataObject(dataObj)
            End If
        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_PORTAPAPELES_COPIAR")
        End Try
    End Sub

    Public Shared Sub PG_DATOS_SQL(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView, ByVal PP_STORED_PROCEDURE As String, ByVal PP_PARAMETROS As String)
        Try
            Dim VP_TABLA As New Data.DataTable
            VP_TABLA = Codigo_SQL.FG_SP_EXECUTE_DATATABLE(PP_BD_Index, PP_STORED_PROCEDURE, PP_PARAMETROS)

            Codigo_LI.PG_LI_LOAD(PP_FORMA, PP_LISTADO, VP_TABLA)

            PP_FORMA.Cursor = Cursors.Default
            Dim VP_REGISTROS As String
            VP_REGISTROS = VP_TABLA.Rows.Count().ToString()
            PP_FORMA.LB_RESULTADO.Text = "Resultado de la operación: " + VP_REGISTROS + " registros." + Environment.NewLine + PP_FORMA.LB_RESULTADO.Text
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_DATOS_SQL")
        End Try
    End Sub

    Public Shared Sub PG_SERIES_ADD(ByRef PP_CHART As System.Windows.Forms.DataVisualization.Charting.Chart, ByRef VP_TABLA As Data.DataTable)
        Try
            PP_CHART.Series.Clear()
            For Each VP_ROW As DataRow In VP_TABLA.Rows
                PP_CHART.Series.Add(VP_ROW(0))
            Next
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_SERIES_ADD")
        End Try
    End Sub

    Public Shared Sub PG_SERIES_ADD(ByRef PP_CHART As System.Windows.Forms.DataVisualization.Charting.Chart, ByRef PP_TABLA As Data.DataTable, ByVal PP_COLUMNA_1 As Integer)
        Try
            PP_CHART.Series.Clear()
            Dim VP_SERIE_1 As String = Right(PP_TABLA.Columns(PP_COLUMNA_1).ColumnName, PP_TABLA.Columns(PP_COLUMNA_1).ColumnName.Length - 3)
            PP_CHART.Series.Add(VP_SERIE_1)
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_SERIES_ADD")
        End Try
    End Sub

    Public Shared Sub PG_SERIES_ADD_NAME(ByRef PP_CHART As System.Windows.Forms.DataVisualization.Charting.Chart, ByRef PP_TABLA As Data.DataTable, ByVal PP_COLUMNA_1 As Integer)
        Try
            If PP_TABLA.Rows.Count() > 0 Then
                PP_CHART.Series.Clear()
                Dim VP_ROW As DataRow = PP_TABLA.Rows(0)
                Dim VP_SERIE_1 As String = VP_ROW(0)
                PP_CHART.Series.Add(VP_SERIE_1)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub PG_SERIES_ADD(ByRef PP_CHART As System.Windows.Forms.DataVisualization.Charting.Chart, ByRef PP_TABLA As Data.DataTable, ByVal PP_COLUMNA_1 As Integer, ByVal PP_COLUMNA_2 As Integer)
        Try
            PP_CHART.Series.Clear()
            Dim VP_SERIE_1 As String = Right(PP_TABLA.Columns(PP_COLUMNA_1).ColumnName, PP_TABLA.Columns(PP_COLUMNA_1).ColumnName.Length - 3)
            PP_CHART.Series.Add(VP_SERIE_1)
            If PP_COLUMNA_2 <> 0 Then
                Dim VP_SERIE_2 As String = Right(PP_TABLA.Columns(PP_COLUMNA_2).ColumnName, PP_TABLA.Columns(PP_COLUMNA_2).ColumnName.Length - 3)
                PP_CHART.Series.Add(VP_SERIE_2)
            End If
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_SERIES_ADD")
        End Try
    End Sub

    Public Shared Sub PG_CLEAN_AND_TYPE(ByRef PP_CHART As System.Windows.Forms.DataVisualization.Charting.Chart, ByRef PP_TIPO_GRAFICO As String)
        Try
            Dim VP_CantidadSerie As Integer = PP_CHART.Series.Count()
            Dim VP_ContadorSerie As Integer = 0

            While VP_CantidadSerie <> VP_ContadorSerie
                PP_CHART.Series(VP_ContadorSerie).Points.Clear()
                Select Case PP_TIPO_GRAFICO
                    Case ""
                        PP_CHART.Series(VP_ContadorSerie).ChartType = DataVisualization.Charting.SeriesChartType.Column
                    Case "Área"
                        PP_CHART.Series(VP_ContadorSerie).ChartType = DataVisualization.Charting.SeriesChartType.SplineArea
                    Case "SLíneas"
                        PP_CHART.Series(VP_ContadorSerie).ChartType = DataVisualization.Charting.SeriesChartType.Spline
                    Case "Columna"
                        PP_CHART.Series(VP_ContadorSerie).ChartType = DataVisualization.Charting.SeriesChartType.Column
                    Case "Líneas"
                        PP_CHART.Series(VP_ContadorSerie).ChartType = DataVisualization.Charting.SeriesChartType.FastLine
                    Case "Barras"
                        PP_CHART.Series(VP_ContadorSerie).ChartType = DataVisualization.Charting.SeriesChartType.Bar
                    Case "Puntos"
                        PP_CHART.Series(VP_ContadorSerie).ChartType = DataVisualization.Charting.SeriesChartType.Bubble
                    Case "Área Apilada"
                        PP_CHART.Series(VP_ContadorSerie).ChartType = DataVisualization.Charting.SeriesChartType.StackedArea
                    Case "Pay"
                        PP_CHART.Series(VP_ContadorSerie).ChartType = DataVisualization.Charting.SeriesChartType.Pie
                End Select
                VP_ContadorSerie += 1
            End While
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_CLEAN_AND_TYPE")
        End Try
    End Sub

    Public Shared Sub PG_BT_GRAFICAR_CLICK(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_CHART As System.Windows.Forms.DataVisualization.Charting.Chart, ByRef PP_TIPO_GRAFICO As String, PP_ID As String)
        Try
            PP_FORMA.Cursor = Cursors.WaitCursor
            Dim VP_PARAMETROS As String
            VP_PARAMETROS = PP_ID
            Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
            Dim VP_STORED_PROCEDURE As String
            VP_STORED_PROCEDURE = Codigo_SQL.FG_SP_GRAFICAR_OBJ(PP_FORMA)
            Dim VP_TABLA As Data.DataTable
            VP_TABLA = Codigo_SQL.FG_SP_EXECUTE_DATATABLE(PP_BD_Index, VP_STORED_PROCEDURE, VP_PARAMETROS)
            PG_SERIES_ADD(PP_CHART, VP_TABLA)
            Dim VP_CantidadSerie As Integer = PP_CHART.Series.Count()
            Dim VP_ContadorSerie As Integer = 0
            Dim VP_ContadorColumn As Integer = 1

            PP_CHART.ChartAreas(0).AxisX.Interval = 1
            PG_CLEAN_AND_TYPE(PP_CHART, PP_TIPO_GRAFICO)

            VP_ContadorSerie = 0
            For Each row As DataRow In VP_TABLA.Rows
                For Each VP_COL As DataColumn In VP_TABLA.Columns
                    If VP_ContadorColumn < VP_TABLA.Columns.Count Then
                        Dim VP_NCOLUMNS As String = VP_TABLA.Columns(VP_ContadorColumn).ColumnName
                        PP_CHART.Series(VP_ContadorSerie).Points.AddXY(VP_NCOLUMNS, row(VP_ContadorColumn))
                        VP_ContadorColumn += 1
                    End If
                Next VP_COL
                'VP_ContadorSerie += 1
            Next row
            PP_FORMA.Cursor = Cursors.Default
            Dim VP_RESULTADO As Integer = 0
            VP_RESULTADO = VP_TABLA.Rows.Count()
            PP_FORMA.LB_RESULTADO.Text = "Resultado de la operación: " + VP_RESULTADO.ToString() + " registros." + Environment.NewLine + PP_FORMA.LB_RESULTADO.Text
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_BT_GRAFICAR_CLICK")
        End Try
    End Sub

    Public Shared Sub PG_BT_GRAFICAR_CLICK(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_CHART As System.Windows.Forms.DataVisualization.Charting.Chart, ByRef PP_TIPO_GRAFICO As String, PP_ID As String, PP_SP As String)
        Try
            PP_FORMA.Cursor = Cursors.WaitCursor
            Dim VP_PARAMETROS As String
            VP_PARAMETROS = PP_ID
            Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
            Dim VP_STORED_PROCEDURE As String
            VP_STORED_PROCEDURE = PP_SP
            Dim VP_TABLA As Data.DataTable
            VP_TABLA = Codigo_SQL.FG_SP_EXECUTE_DATATABLE(PP_BD_Index, VP_STORED_PROCEDURE, VP_PARAMETROS)
            PG_SERIES_ADD(PP_CHART, VP_TABLA)
            Dim VP_CantidadSerie As Integer = PP_CHART.Series.Count()
            Dim VP_ContadorSerie As Integer = 0
            Dim VP_ContadorColumn As Integer = 1

            PP_CHART.ChartAreas(0).AxisX.Interval = 1
            PG_CLEAN_AND_TYPE(PP_CHART, PP_TIPO_GRAFICO)
            VP_ContadorSerie = 0

            For Each row As DataRow In VP_TABLA.Rows
                VP_ContadorColumn = 1
                For Each VP_COL As DataColumn In VP_TABLA.Columns
                    If VP_ContadorColumn < VP_TABLA.Columns.Count Then
                        Dim VP_NCOLUMNS As String = VP_TABLA.Columns(VP_ContadorColumn).ColumnName
                        PP_CHART.Series(VP_ContadorSerie).Points.AddXY(VP_NCOLUMNS, row(VP_ContadorColumn))
                        VP_ContadorColumn += 1
                    End If
                Next VP_COL
                PP_CHART.Series(VP_ContadorSerie).BorderWidth = 2
                VP_ContadorSerie += 1
            Next row
            PP_FORMA.Cursor = Cursors.Default
            Dim VP_RESULTADO As Integer = 0
            VP_RESULTADO = VP_TABLA.Rows.Count()
            PP_FORMA.LB_RESULTADO.Text = "Resultado de la operación: " + VP_RESULTADO.ToString() + " registros." + Environment.NewLine + PP_FORMA.LB_RESULTADO.Text
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("")
        End Try
    End Sub

    Public Shared Sub PG_BT_GRAFICAR_CLICK(ByRef PP_CHART As System.Windows.Forms.DataVisualization.Charting.Chart, ByVal PP_TABLA As Data.DataTable, ByRef PP_TIPO_GRAFICO As SeriesChartType, ByVal PP_COLUMNA_SERIE As Integer, ByVal PP_COLUMNA_1 As Integer, ByVal PP_COLUMNA_2 As Integer)
        'PP_FORMA.Cursor = Cursors.WaitCursor

        PG_SERIES_ADD(PP_CHART, PP_TABLA, PP_COLUMNA_1, PP_COLUMNA_2)
        Dim VP_CantidadSerie As Integer = PP_CHART.Series.Count()
        Dim VP_ContadorSerie As Integer = 0
        ' PP_CHART.IsSoftShadows = True
        PP_CHART.ChartAreas(0).AxisX.Interval = 1
        PP_CHART.ChartAreas(0).AxisY.LineWidth = 0

        PG_CLEAN_AND_TYPE(PP_CHART, PP_TIPO_GRAFICO)

        VP_ContadorSerie = 0

        For Each row As DataRow In PP_TABLA.Rows
            Try
                Dim VP_NCOLUMNS As String = row(PP_COLUMNA_SERIE).ToString()
                PP_CHART.Series(VP_ContadorSerie).Points.AddXY(VP_NCOLUMNS, row(PP_COLUMNA_1))
            Catch ex As Exception

            End Try
            '
        Next row
        PP_CHART.Series(VP_ContadorSerie).BorderWidth = 3
        If PP_COLUMNA_2 <> 0 Then
            VP_ContadorSerie += 1

            For Each row As DataRow In PP_TABLA.Rows
                Try
                    Dim VP_NCOLUMNS As String = row(PP_COLUMNA_SERIE).ToString()
                    PP_CHART.Series(VP_ContadorSerie).Points.AddXY(VP_NCOLUMNS, row(PP_COLUMNA_2))
                Catch ex As Exception

                End Try
                '
            Next row
            PP_CHART.Series(VP_ContadorSerie).BorderWidth = 3

        End If
        ' PP_FORMA.Cursor = Cursors.Default
        'Dim VP_RESULTADO As Integer = 0
        'VP_RESULTADO = VP_TABLA.Rows.Count()
        'PP_FORMA.LB_RESULTADO.Text = "Resultado de la operación: " + VP_RESULTADO.ToString() + " registros." + Environment.NewLine + PP_FORMA.LB_RESULTADO.Text

    End Sub

    Public Shared Sub PG_BT_GRAFICAR_CLICK(ByRef PP_CHART As System.Windows.Forms.DataVisualization.Charting.Chart, ByVal PP_TABLA As Data.DataTable, ByRef PP_TIPO_GRAFICO As SeriesChartType, ByVal PP_COLUMNA_SERIE As Integer, ByVal PP_COLUMNA_1 As Integer)
        'PP_FORMA.Cursor = Cursors.WaitCursor

        PG_SERIES_ADD_NAME(PP_CHART, PP_TABLA, PP_COLUMNA_SERIE)
        Dim VP_CantidadSerie As Integer = PP_CHART.Series.Count()
        Dim VP_ContadorSerie As Integer = 0
        ' PP_CHART.IsSoftShadows = True
        PP_CHART.ChartAreas(0).AxisX.Interval = 1
        PP_CHART.ChartAreas(0).AxisY.LineWidth = 0

        PG_CLEAN_AND_TYPE(PP_CHART, PP_TIPO_GRAFICO)

        VP_ContadorSerie = 0
        Dim VP_ContadorColumn As Integer = 1
        For Each row As DataRow In PP_TABLA.Rows
            Try
                For Each VP_COL As DataColumn In PP_TABLA.Columns
                    If VP_ContadorColumn < PP_TABLA.Columns.Count Then
                        Dim VP_NCOLUMNS As String = PP_TABLA.Columns(VP_ContadorColumn).ColumnName
                        VP_NCOLUMNS = Right(VP_NCOLUMNS, VP_NCOLUMNS.Length - 3)
                        PP_CHART.Series(VP_ContadorSerie).Points.AddXY(VP_NCOLUMNS, row(VP_ContadorColumn))
                        VP_ContadorColumn += 1
                    End If
                Next VP_COL

                'Dim VP_NCOLUMNS As String = row(PP_COLUMNA_SERIE).ToString()
                'PP_CHART.Series(VP_ContadorSerie).Points.AddXY(VP_NCOLUMNS, row(PP_COLUMNA_1))
            Catch ex As Exception

            End Try
            '
        Next row
        PP_CHART.Series(VP_ContadorSerie).BorderWidth = 3

        ' PP_FORMA.Cursor = Cursors.Default
        'Dim VP_RESULTADO As Integer = 0
        'VP_RESULTADO = VP_TABLA.Rows.Count()
        'PP_FORMA.LB_RESULTADO.Text = "Resultado de la operación: " + VP_RESULTADO.ToString() + " registros." + Environment.NewLine + PP_FORMA.LB_RESULTADO.Text

    End Sub

    Private Shared Sub PG_CLEAN_AND_TYPE(ByRef PP_CHART As DataVisualization.Charting.Chart, PP_TIPO_GRAFICA As SeriesChartType)
        Try
            Dim VP_CantidadSerie As Integer = PP_CHART.Series.Count()
            Dim VP_ContadorSerie As Integer = 0

            While VP_CantidadSerie <> VP_ContadorSerie
                PP_CHART.Series(VP_ContadorSerie).Points.Clear()
                PP_CHART.Series(VP_ContadorSerie).ChartType = PP_TIPO_GRAFICA
                VP_ContadorSerie += 1
            End While
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_CLEAN_AND_TYPE")
        End Try

    End Sub

    Public Shared Sub PG_DIBUJAR_GRAFICA(ByRef PP_CHART As System.Windows.Forms.DataVisualization.Charting.Chart, ByVal PP_TABLA As Data.DataTable, ByVal PP_COLUMNA_SERIE As Integer, ByVal PP_COLUMNA_1 As Integer, ByVal PP_COLUMNA_2 As Integer)
        Dim VP_CantidadSerie As Integer = PP_CHART.Series.Count()
        Dim VP_ContadorSerie As Integer = 0
        For Each row As DataRow In PP_TABLA.Rows
            Try
                Dim VP_NCOLUMNS As String = row(PP_COLUMNA_SERIE).ToString()
                PP_CHART.Series(VP_ContadorSerie).Points.AddXY(VP_NCOLUMNS, row(PP_COLUMNA_1))
            Catch ex As Exception

            End Try
            '
        Next row
        VP_ContadorSerie += 1

        For Each row As DataRow In PP_TABLA.Rows
            Try
                Dim VP_NCOLUMNS As String = row(PP_COLUMNA_SERIE).ToString()
                PP_CHART.Series(VP_ContadorSerie).Points.AddXY(VP_NCOLUMNS, row(PP_COLUMNA_2))
            Catch ex As Exception

            End Try
            '
        Next row
    End Sub


    Public Shared Sub PG_LI_SAVE(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
        Try
            PP_FORMA.PM_LI_SAVE(PP_FORMA, PP_LISTADO)
            PP_FORMA.PM_BT_BUSCAR_CLICK(PP_FORMA, PP_LISTADO)
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_LI_SAVE")
        End Try
    End Sub

#End Region

#Region "FUNCIONES"

    Public Shared Function FG_DC_ID_SEARCH(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByVal PP_KEY As String)
        Dim VP_ROW As DataRow = Nothing
        Try
            If PP_KEY <> "" Then
                Dim VP_RESULTADO As Data.DataTable
                Dim VP_SP As String
                VP_SP = Codigo_SQL.FG_SP_Seek(PP_FORMA)

                Dim VP_PARAMETROS As String
                VP_PARAMETROS = PP_KEY
                Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)

                VP_RESULTADO = Codigo_SQL.FG_SP_EXECUTE_DATATABLE(PP_BD_Index, VP_SP, VP_PARAMETROS)


                If VP_RESULTADO.Rows.Count <> 0 Then
                    VP_ROW = VP_RESULTADO.Rows(0)

                End If

            End If


        Catch ex As Exception
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_DC_ID_SEARCH")
        End Try
        Return VP_ROW
    End Function


    Public Shared Function FG_COLUMN_NAME_GET(ByVal columnNumber As Integer) As String
        Dim dividend As Integer = columnNumber
        Dim columnName As String = String.Empty
        Try
            Dim modulo As Integer
            While dividend > 0
                modulo = (dividend - 1) Mod 26
                columnName = Convert.ToChar(65 + modulo).ToString() & columnName
                dividend = CInt(((dividend - modulo) / 26))
            End While
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("FG_COLUMN_NAME_GET")
        End Try
        Return columnName
    End Function

    Public Shared Function FG_PARAMETROS_SQL(ByRef PP_FORMA As Object)
        Dim VP_PARAMETROS As String = ""
        Try
            VP_PARAMETROS = PP_FORMA.FM_SQL_LISTADO()
            Codigo_SQL.PG_SQL_PARAMETROS_CONTROL(VP_PARAMETROS)
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("FG_PARAMETROS_SQL")
        End Try
        Return VP_PARAMETROS
    End Function

    Public Shared Function VER_MOSTRAR(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView, ByVal PP_MODO_OPERACION As Integer) As Boolean
        Try
            If Codigo_LI.FG_LI_ROW_SELECTED(PP_LISTADO) Then
                PP_FORMA.VM_IN_MODO_OPERACION = PP_MODO_OPERACION
                Codigo_FRM.PG_FRM_CONFIG(PP_FORMA)
                Return True

            End If
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("VER_MOSTRAR")
        End Try
        Return False
    End Function

    Public Shared Function FG_DT_CONVIERTE_FECHA_MX_A_US(ByVal PP_FECHA As Date) As String ' Recibe una fecha en formato dd/mm/yyyy
        Dim VL_FECHA_MOSTRAR As String = ""
        Try
            VL_FECHA_MOSTRAR = PP_FECHA.ToString("MM/dd/yyyy") ' Regresa una fecha en formato mm/dd/yyyy
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("FG_DT_CONVIERTE_FECHA_MX_A_US")
        End Try

        Return VL_FECHA_MOSTRAR
    End Function

    Public Shared Function FG_DT_CONVIERTE_FECHA_US_A_MX(ByVal PP_FECHA As Date) As String ' Recibe una fecha en formato mm/dd/yyyy
        Dim VL_FECHA_MOSTRAR As String = ""
        Try
            VL_FECHA_MOSTRAR = PP_FECHA.ToString("dd/MM/yyyy") ' Regresa una fecha en formato dd/mm/yyyy
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("FG_DT_CONVIERTE_FECHA_US_A_MX")
        End Try
        Return VL_FECHA_MOSTRAR
    End Function

    Public Shared Function FG_DT_AGREGA_CEROS_FECHA_US(ByVal PP_FECHA As Date) As String ' Recibe una fecha en formato mm/dd/yyyy
        Dim VL_FECHA_MOSTRAR As String = ""
        Try
            VL_FECHA_MOSTRAR = PP_FECHA.ToString("MM/dd/yyyy") ' Regresa una fecha en formato mm/dd/yyyy con los ceros para los meses o días menores a 10
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("FG_DT_AGREGA_CEROS_FECHA_US")
        End Try
        Return VL_FECHA_MOSTRAR
    End Function

    Public Shared Function FG_DT_CONVIERTE_FECHA_US_A_SQL(ByVal PP_FECHA As Date) As String ' Recibe una fecha en formato mm/dd/yyyy
        Dim VL_FECHA_MOSTRAR As String = ""
        Try
            VL_FECHA_MOSTRAR = PP_FECHA.ToString("yyyy-MM-dd") ' Regresa una fecha en formato yyyy-mm-dd
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("FG_DT_CONVIERTE_FECHA_US_A_SQL")
        End Try
        Return VL_FECHA_MOSTRAR
    End Function
    Public Shared Function FG_DT_CONVIERTE_FECHA_XML_A_SQL(ByVal PP_FECHA As String) As String ' Recibe una fecha en formato mm/dd/yyyy
        Dim VL_FECHA_MOSTRAR As String = ""
        Try
            VL_FECHA_MOSTRAR = PP_FECHA.Substring(0, 10) ' Regresa una fecha en formato yyyy-mm-dd
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("FG_DT_CONVIERTE_FECHA_XML_A_SQL")
        End Try
        Return VL_FECHA_MOSTRAR
    End Function

    Public Shared Function FG_DT_CONVIERTE_FECHA_A_SQL(ByVal PP_FECHA As String) As String ' Recibe una fecha en formato dd/MM/yyyy
        Dim VL_FECHA_MOSTRAR As String = ""
        Try
            Select Case VG_CULTURE_INFO
                Case 0
                    VL_FECHA_MOSTRAR = Convert.ToDateTime(PP_FECHA).ToString("MM-dd-yyyy") ' Regresa una fecha en formato yyyy-mm-dd
                Case 5
                    VL_FECHA_MOSTRAR = Convert.ToDateTime(PP_FECHA).ToString("dd-MM-yyyy") ' Regresa una fecha en formato yyyy-mm-dd
            End Select
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("")
        End Try
        Return VL_FECHA_MOSTRAR
    End Function

#End Region

End Class
