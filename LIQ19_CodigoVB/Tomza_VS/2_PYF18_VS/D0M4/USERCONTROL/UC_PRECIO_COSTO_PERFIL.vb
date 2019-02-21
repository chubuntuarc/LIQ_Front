Public Class UC_PRECIO_COSTO_PERFIL
#Region "VARIABLES Y CONSTANTES MODULARES"

    Public VM_NOMBRE_TABLA As String
    Public VM_IN_MODO_OPERACION As Integer = 0
    Public VM_ID_BASE_DE_DATOS As Integer = 0

#End Region

#Region "FUNCIONES_FM"

    Public Function FM_SQL_LISTADO() As String
        Dim VP_PARAMETROS As String = ""
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_LI_BUSCAR, True)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_ZONA_UO, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TIEMPO_YYYY, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_LI_TIEMPO_MES, False)
        Return VP_PARAMETROS
    End Function

    Public Function FM_FI_SQL(ByRef PP_NUEVO As Boolean)
        Dim VP_PARAMETROS = ""
        PP_NUEVO = True
        If TB_K_PRECIO_COSTO_PERFIL.Text <> "" Then
            Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_K_PRECIO_COSTO_PERFIL, False)
            PP_NUEVO = False
        End If

        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_O_PRECIO_COSTO_PERFIL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CH_L_PRECIO_COSTO_PERFIL, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_UNIDAD_OPERATIVA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_TIEMPO_YYYY, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, CB_MES, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_PV_PRECIO_VENTA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MC, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_FLETE, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_CA, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_APG, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_MP_INB, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_FG, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_SMD, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_SMP, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_SMRU, False)
        Codigo_CTRL.PG_CO_PARAMETRO(VP_PARAMETROS, TB_SMPT, False)

        Return VP_PARAMETROS

    End Function

    Public Function FM_DESC_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "D_PRECIO_COSTO_PERFIL")
        Return VP_ID
    End Function

    Public Function FM_ID_SELECCIONADO(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW As Integer) As String
        Dim VP_ID As String = ""
        VP_ID = Codigo_LI.FG_LI_CELL_READ(PP_LISTADO, PP_ROW, "K_PRECIO_COSTO_PERFIL")
        Return VP_ID
    End Function

    Public Function FM_SAVE_VALIDATE(ByRef PP_MENSAJE_VALIDACION As String) As Boolean
        Dim VP_VALIDACION As Boolean

        Codigo_FI.PG_FI_FIELDS_VALIDATE(GB_FICHA, VP_VALIDACION, PP_MENSAJE_VALIDACION)

        Codigo_CTRL.PG_TB_INTEGER_VALIDATE(PP_MENSAJE_VALIDACION, TB_O_PRECIO_COSTO_PERFIL)


        VP_VALIDACION = (PP_MENSAJE_VALIDACION = "")

        Return VP_VALIDACION
    End Function

#End Region

#Region "SUB_PM_INIT"

    Public Sub PM_FO_SHOW(ByRef PP_NOMBRE_TABLA As String, ByVal PP_ID_BASE_DE_DATOS As String)
        VM_NOMBRE_TABLA = PP_NOMBRE_TABLA
        VM_ID_BASE_DE_DATOS = PP_ID_BASE_DE_DATOS
        'Me.Show()
    End Sub

    Public Sub PM_CB_INIT()
        Codigo_FI.PG_FI_CONTROL_DATA_SETUP(VM_ID_BASE_DE_DATOS, Me)
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_TIEMPO_MES, "MES")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_ZONA_UO, "ZONA_UO")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_TIEMPO_YYYY, "TIEMPO_YYYY")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_LI_UNIDAD_OPERATIVA, "UNIDAD_OPERATIVA")

        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_UNIDAD_OPERATIVA, "")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_TIEMPO_YYYY, "")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_MES, "")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_USUARIO_ALTA, "USUARIO")
        Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS,Me, CB_USUARIO_CAMBIO, "USUARIO")

    End Sub

    Public Sub PM_LI_INIT()
        PM_LI_FORMAT(LI_LISTADO)
    End Sub

    Private Sub PM_FO_INIT(ByRef PP_FORMA As Object)
        Me.PM_FO_SHOW("PRECIO_COSTO_PERFIL", "6")
        Codigo_FRM.PG_FRM_INIT(VM_ID_BASE_DE_DATOS, PP_FORMA)

    End Sub

#End Region

#Region "SUBS_PM"

    ''' <summary>
    ''' 'FUNCION QUE CARGARA LA PARTE DE LA FICHA
    ''' </summary>
    Public Sub PM_FI_LOAD(ByVal PP_ID As String)
        Codigo_FI.FG_FI_LOAD_X_ID(VM_ID_BASE_DE_DATOS,  Me, PP_ID)
        CB_UNIDAD_OPERATIVA.Select()
    End Sub

    Public Sub PM_FI_CARGAR(ByVal PP_ROW As DataRow)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_K_PRECIO_COSTO_PERFIL, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_UNIDAD_OPERATIVA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_TIEMPO_YYYY, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_MES, PP_ROW)
        '-------------------------------------------------------
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_PC_PRECIO_COMPRA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_PV_PRECIO_VENTA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_MC, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_FLETE, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_CA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_APG, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_MP_INB, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_FG, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_SMD, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_SMP, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_SMRU, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_SMPT, PP_ROW)
        '-------------------------------------------------------
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_O_PRECIO_COSTO_PERFIL, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CH_L_PRECIO_COSTO_PERFIL, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_USUARIO_ALTA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", CB_USUARIO_CAMBIO, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_F_ALTA, PP_ROW)
        Codigo_CTRL.PG_CO_DATA_LOAD("", TB_F_CAMBIO, PP_ROW)

        Codigo_FI.PG_FI_CONTROL_DATA_LOAD(Me, PP_ROW)

        Dim VP_PADRE As Object = Me.Parent

        VP_PADRE.PP_K_PRECIO_COSTO_PERFIL = TB_K_PRECIO_COSTO_PERFIL.Text
        VP_PADRE.PP_UNIDAD_OPERATIVA = Codigo_CB.FG_CB_ITEM_VALUE(CB_UNIDAD_OPERATIVA)
        VP_PADRE.PP_YYYY = Codigo_CB.FG_CB_ITEM_VALUE(CB_TIEMPO_YYYY)
        VP_PADRE.PP_MES = Codigo_CB.FG_CB_ITEM_VALUE(CB_MES)





        'FO_WIZARD.PP_K_PRECIO_COSTO_PERFIL = TB_K_PRECIO_COSTO_PERFIL.Text
        'FO_WIZARD.PP_UNIDAD_OPERATIVA = Codigo_CB.FG_CB_ITEM_VALUE(CB_UNIDAD_OPERATIVA)
        'FO_WIZARD.PP_YYYY = Codigo_CB.FG_CB_ITEM_VALUE(CB_TIEMPO_YYYY)
        'FO_WIZARD.PP_MES = Codigo_CB.FG_CB_ITEM_VALUE(CB_MES)

    End Sub

    Private Sub PM_LI_FORMAT(ByRef PP_LI_LISTADO As DataGridView)
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 16)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, 
        '            ANCHO_CELDA, ALINEACION, SOLO_LECTURA, Visible, FROZEN, FORMAT
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_PRECIO_COSTO_PERFIL", "ID", GetType(Integer), 80, 1, 1, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_ZONA_UO", "ZONA", GetType(String), 80, 1, 1, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_UNIDAD_OPERATIVA", "UNIDAD OPERATIVA", GetType(String), 80, 1, 1, 1, 1, 0)

        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_YYYY", "AÑO", GetType(Integer), 80, 2, 1, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_MES", "MES", GetType(Integer), 80, 2, 1, 1, 1, 0)

        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PV_PRECIO_VENTA", "PRECIO VENTA", GetType(Decimal), 80, 3, 1, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PC_PRECIO_COMPRA", "PRECIO COMPRA", GetType(Decimal), 80, 3, 1, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "MC", "MC", GetType(Decimal), 80, 3, 1, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "FLETE", "FLETE", GetType(Decimal), 80, 3, 1, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "CA", "CA", GetType(Decimal), 80, 3, 1, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "APG", "APG", GetType(Decimal), 80, 3, 1, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "MP_INB", "MP_INB", GetType(Decimal), 80, 3, 1, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "FG", "FG", GetType(Decimal), 80, 3, 1, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "SMD", "SMD", GetType(Decimal), 80, 3, 1, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "SMP", "SMP", GetType(Decimal), 80, 3, 1, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "SMRU", "SMRU", GetType(Decimal), 80, 3, 1, 1, 0, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "SMPT", "SMPT", GetType(Decimal), 80, 3, 1, 1, 0, 1)

        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "O_PRECIO_COSTO_PERFIL", "Orden ", GetType(Integer), 100, 2, 0, 0, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "L_PRECIO_COSTO_PERFIL", "Activo", GetType(Integer), 100, 2, 0, 0, 0, 0)
        Codigo_FRM.PG_FRM_LI_FORMAT_CONTROL_LOAD(PP_LI_LISTADO, 100, 2, 0, 0, 0, 0)

    End Sub

    Public Sub PM_LI_ROW_WRITE(ByRef PP_LISTADO As DataGridView, ByRef PP_ROW_DATA As DataRow)
        Dim VP_COLUMNA As Integer = 0
        Dim VP_ROW As Integer
        VP_ROW = Codigo_LI.FG_LI_MAX_ROW(PP_LISTADO)
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_PRECIO_COSTO_PERFIL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_ZONA_UO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_UNIDAD_OPERATIVA")

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "K_YYYY")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "D_MES")

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "PV_PRECIO_VENTA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "PC_PRECIO_COMPRA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "MC")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "FLETE")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "CA")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "APG")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "MP_INB")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "FG")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "SMD")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "SMP")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "SMRU")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "SMPT")

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "O_PRECIO_COSTO_PERFIL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA, "L_PRECIO_COSTO_PERFIL")

        Codigo_FRM.PG_FRM_LI_DATA_CONTROL_LOAD(PP_LISTADO, VP_ROW, VP_COLUMNA, PP_ROW_DATA)
        Codigo_LI.PG_LI_ROW_EDIT(PP_LISTADO, VP_ROW, False)
    End Sub

    Public Sub PM_BT_BUSCAR_CLICK(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView)
        Codigo_ABC.PG_BT_BUSCAR_CLICK(VM_ID_BASE_DE_DATOS, PP_FORMA, PP_LISTADO)
    End Sub

    Private Sub PM_BT_AGREGAR_CLICK(ByRef PP_FORMA As Object)
        Codigo_ABC.PG_BT_AGREGAR_CLICK(PP_FORMA)
    End Sub

    Private Sub PM_BT_CANCELAR_CLICK(ByRef PP_FORMA As Object)
        Codigo_ABC.PG_BT_CANCELAR_CLICK(PP_FORMA)
    End Sub

    Private Sub PM_BT_SALIR_CLICK(ByRef PP_FORMA As Object)
        Codigo_ABC.PG_BT_SALIR_CLICK(PP_FORMA)
    End Sub

    Private Sub PM_BT_EDITAR_CLICK(ByRef PP_FORMA As Object, ByVal PP_LISTADO As DataGridView)
        Codigo_ABC.PG_BT_EDITAR_CLICK(PP_FORMA, PP_LISTADO)
    End Sub

    Public Sub PM_BT_GUARDAR_CLICK(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)

         Codigo_ABC.PG_BT_GUARDAR_CLICK(VM_ID_BASE_DE_DATOS,PP_FORMA, PP_LISTADO)
    End Sub

    Public Sub PM_BT_ELIMINAR_CLICK(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
        Codigo_ABC.PG_BT_ELIMINAR_CLICK(VM_ID_BASE_DE_DATOS,PP_FORMA, PP_LISTADO)
    End Sub

    Private Sub PM_TI_TICK(ByRef PP_LABEL As Label)
        Codigo_FRM.PG_TI_TICK(PP_LABEL)
    End Sub

    Private Sub PM_BT_LISTADO_CLICK(ByRef PP_FORMA As Object)
        Codigo_ABC.PG_BT_LISTADO_CLICK(PP_FORMA)
    End Sub

    Private Sub PM_BT_EXPORTAR_EXCEL_CLICK(ByRef PP_LISTADO As DataGridView)
        Codigo_ABC.PG_BT_EXPORTAR_EXCEL_CLICK(PP_LISTADO)
    End Sub

    Public Sub PM_LI_SAVE(ByRef PP_FORMA As Object, ByRef PP_LISTADO As DataGridView)
        PM_BT_BUSCAR_CLICK(PP_FORMA, PP_LISTADO)
    End Sub

    Public Sub PM_MODO_AUXILIAR()

    End Sub

#End Region

#Region "EVENTOS"

    Private Sub BT_AGREGAR_Click(sender As Object, e As EventArgs) Handles BT_AGREGAR.Click
        PM_BT_AGREGAR_CLICK(Me)
    End Sub

    Private Sub BT_BUSCAR_Click(sender As Object, e As EventArgs) Handles BT_LI_BUSCAR.Click
        PM_BT_BUSCAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub Catalogo_T1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PM_FO_INIT(Me)
    End Sub

    Private Sub BT_CANCELAR_Click(sender As Object, e As EventArgs) Handles BT_CANCELAR.Click
        PM_BT_CANCELAR_CLICK(Me)
    End Sub

    Private Sub BT_SALIR_Click(sender As Object, e As EventArgs) 
        PM_BT_SALIR_CLICK(Me)
    End Sub

    Private Sub BT_GUARDAR_Click(sender As Object, e As EventArgs) Handles BT_GUARDAR.Click

        PM_BT_GUARDAR_CLICK(Me, LI_LISTADO)

    End Sub

    Private Sub BT_EDITAR_Click(sender As Object, e As EventArgs) Handles BT_EDITAR.Click
        PM_BT_EDITAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub BT_ELIMINAR_Click(sender As Object, e As EventArgs) Handles BT_ELIMINAR.Click
        PM_BT_ELIMINAR_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub LI_LISTADO_DoubleClick(sender As Object, e As EventArgs) Handles LI_LISTADO.DoubleClick
        Codigo_LI.PG_LI_DOUBLE_CLICK(Me, LI_LISTADO)
    End Sub

    Private Sub TI_RELOJ_Tick(sender As Object, e As EventArgs) Handles TI_RELOJ.Tick
        PM_TI_TICK(LB_RELOJ)
    End Sub

    Private Sub BT_LISTADO_Click(sender As Object, e As EventArgs) Handles BT_LISTADO.Click
        PM_BT_LISTADO_CLICK(Me)
    End Sub

    Private Sub BT_EXPORTAR_EXCEL_Click(sender As Object, e As EventArgs) Handles BT_EXPORTAR_EXCEL.Click
        PM_BT_EXPORTAR_EXCEL_CLICK(LI_LISTADO)
    End Sub


#End Region
End Class
