Imports System.IO
Imports System.Text

Public Class Codigo_Mensaje

#Region "SUBS"



    Public Shared Sub PG_MENSAJE_DEBUG(ByVal PP_MENSAJE As String, PP_L_APLICAR_BITACORA As Boolean)
        If LIQ19_Constantes.CG_SYS_DEBUG Then
            Dim VP_CAPTION As String = Codigo_FRM.FG_TITULO_VENTANA(0, "Debug")
            Dim VP_BOTON As MessageBoxButtons = MessageBoxButtons.OK
            Dim VP_IONO As MessageBoxIcon = MessageBoxIcon.Warning

            If PP_L_APLICAR_BITACORA Then
                Call PG_BITACORA_WRITE(PP_MENSAJE)
            End If

            MessageBox.Show(PP_MENSAJE, VP_CAPTION, VP_BOTON, VP_IONO)
        End If
    End Sub

    Public Shared Sub PG_MENSAJE_AVISO(ByVal PP_MENSAJE As String, Optional PP_L_BITACORA As Boolean = True)

        Dim VP_CAPTION As String = Codigo_FRM.FG_TITULO_VENTANA(0, "Aviso")
        Dim VP_BOTON As MessageBoxButtons = MessageBoxButtons.OK
        Dim VP_IONO As MessageBoxIcon = MessageBoxIcon.Warning

        If PP_L_BITACORA Then
            Call PG_BITACORA_WRITE(PP_MENSAJE)
        End If

        MessageBox.Show(PP_MENSAJE, VP_CAPTION, VP_BOTON, VP_IONO)

    End Sub

    Public Shared Sub PG_MENSAJE_INFORMACION(ByVal PP_MENSAJE As String)

        Dim VP_CAPTION As String = Codigo_FRM.FG_TITULO_VENTANA(0, "Información")
        Dim VP_BOTON As MessageBoxButtons = MessageBoxButtons.OK
        Dim VP_ICONO As MessageBoxIcon = MessageBoxIcon.Information
        PG_BITACORA_WRITE(PP_MENSAJE)
        MessageBox.Show(PP_MENSAJE, VP_CAPTION, VP_BOTON, VP_ICONO)
    End Sub

    Public Shared Sub PG_MENSAJE_ERROR_VS(ByVal PP_NOMBRE_RUTINA As String)
        Try

            Dim VP_CAPTION As String = Codigo_FRM.FG_TITULO_VENTANA(0, "Mensaje de Sistema")
            Dim VP_BOTON As MessageBoxButtons = MessageBoxButtons.OK
            Dim VP_ICONO As MessageBoxIcon = MessageBoxIcon.Error
            Dim VP_MENSAJE As String
            VP_MENSAJE = "Error de ejecución." + Environment.NewLine + Environment.NewLine
            VP_MENSAJE = VP_MENSAJE + "(a) Rutina: " + PP_NOMBRE_RUTINA + Environment.NewLine
            VP_MENSAJE = VP_MENSAJE + "(b) Error : " + ErrorToString() + Environment.NewLine + Environment.NewLine
            VP_MENSAJE = VP_MENSAJE + "Notifique a Sistemas."
            PG_BITACORA_WRITE(VP_MENSAJE)
            If PP_NOMBRE_RUTINA <> "FG_MG_MENSAJE_GET" Then
                MessageBox.Show(VP_MENSAJE, VP_CAPTION, VP_BOTON, VP_ICONO)
            End If
        Catch ex As Exception
            PG_MENSAJE_ERROR_VS("PG_MENSAJE_ERROR_VS")
        End Try
    End Sub

    Public Shared Sub PG_MENSAJE_GUARDAR_VALIDAR(PP_MENSAJE_VALIDACION As String)
        Dim VP_MENSAJE As String = ""
        VP_MENSAJE = "No es posible <Guardar> la información." + Environment.NewLine + Environment.NewLine + PP_MENSAJE_VALIDACION + Environment.NewLine + Environment.NewLine + "Por favor verifique."
        Codigo_Mensaje.PG_MENSAJE_INFORMACION(VP_MENSAJE)
        PG_BITACORA_WRITE(VP_MENSAJE)
    End Sub

    Public Shared Sub aPG_BITACORA_WRITE(ByVal PP_MENSAJE As String)
        Dim VP_RUTA As String = ""

        VP_RUTA = Application.StartupPath

        VP_RUTA = LIQ19_Constantes.CG_SYS_RUTA_0_LOG + "\"

        Dim VP_NOMBRE_ARCHIVO As String
        Dim VP_DIRECCION_ARCHIVO As String

        VP_NOMBRE_ARCHIVO = "SYS_LOG_" + LIQ19_Constantes.CG_SYS_NOMBRE
        VP_NOMBRE_ARCHIVO = VP_NOMBRE_ARCHIVO + "_" + Format(Now().Year, "0000") + Format(Now().Month, "00") + Format(Now().Day, "00")
        VP_NOMBRE_ARCHIVO = VP_NOMBRE_ARCHIVO + "_" + LIQ19_Constantes.CG_VERSION_EXE

        VP_DIRECCION_ARCHIVO = VP_RUTA + "\" + VP_NOMBRE_ARCHIVO + ".txt"

        Try
            If Not File.Exists(VP_DIRECCION_ARCHIVO) Then
                Dim VP_FILESTREAM As FileStream = File.Create(VP_DIRECCION_ARCHIVO)
                Dim VP_CABECERA_BITACORA As String = ""
                VP_CABECERA_BITACORA = "------------------------------------------------------------------------------------------------------------"
                VP_CABECERA_BITACORA += vbCrLf + "---------------------------- Bitácora del Sistema [" + Application.ProductName + "] Versión [" + Application.ProductVersion + "] ----------------------------"
                VP_CABECERA_BITACORA += vbCrLf + "---------------------------------- Creado: " + DateTime.Now().ToLongDateString() + " ----------------------------------"
                VP_CABECERA_BITACORA += vbCrLf + "------------------------------------------------------------------------------------------------------------"
                VP_CABECERA_BITACORA += vbCrLf + vbCrLf
                Dim VP_INFORMACION_A_ESCRIBIR As Byte() = New UTF8Encoding(True).GetBytes(VP_CABECERA_BITACORA)
                VP_FILESTREAM.Write(VP_INFORMACION_A_ESCRIBIR, 0, VP_INFORMACION_A_ESCRIBIR.Length)
                VP_FILESTREAM.Close()
            End If

            Dim VP_STREAMREADER As New StreamWriter(VP_DIRECCION_ARCHIVO, True)

            Dim VP_LINEA_BITACORA As String = ""
            VP_LINEA_BITACORA += vbCrLf + "-- ======================================================================================================= -"
            VP_LINEA_BITACORA += vbCrLf + "-- " + Now().ToString() + "  -Usuario: " + VG_USUARIO + "  -Mensaje: " + PP_MENSAJE
            VP_STREAMREADER.WriteLine(VP_LINEA_BITACORA)
            VP_STREAMREADER.Close()
        Catch ex As Exception
            PG_MENSAJE_ERROR_VS("PG_BITACORA_WRITE")
        End Try
    End Sub

    Public Shared Sub PG_BITACORA_WRITE(ByVal PP_MENSAJE As String)
        Dim VP_RUTA As String = ""

        VP_RUTA = Application.StartupPath

        VP_RUTA = LIQ19_Constantes.CG_SYS_RUTA_0_LOG + "\"

        Dim VP_NOMBRE_ARCHIVO As String
        Dim VP_DIRECCION_ARCHIVO As String

        VP_NOMBRE_ARCHIVO = "SYS_LOG_" + LIQ19_Constantes.CG_SYS_SIGLAS
        VP_NOMBRE_ARCHIVO = VP_NOMBRE_ARCHIVO + "_" + Format(Now().Year, "0000") + Format(Now().Month, "00") + Format(Now().Day, "00")
        VP_NOMBRE_ARCHIVO = VP_NOMBRE_ARCHIVO + "_" + LIQ19_Constantes.CG_VERSION_EXE

        VP_DIRECCION_ARCHIVO = VP_RUTA + "\" + VP_NOMBRE_ARCHIVO + ".txt"

        If Directory.Exists(VP_RUTA) Then
            If Not File.Exists(VP_DIRECCION_ARCHIVO) Then
                Dim VP_FILESTREAM As FileStream = File.Create(VP_DIRECCION_ARCHIVO)
                Dim VP_CABECERA_BITACORA As String = ""
                VP_CABECERA_BITACORA = "------------------------------------------------------------------------------------------------------------"
                VP_CABECERA_BITACORA += vbCrLf + "---------------------------- Bitácora del Sistema [" + Application.ProductName + "] Versión [" + Application.ProductVersion + "] ----------------------------"
                VP_CABECERA_BITACORA += vbCrLf + "---------------------------------- Creado: " + DateTime.Now().ToLongDateString() + " ----------------------------------"
                VP_CABECERA_BITACORA += vbCrLf + "------------------------------------------------------------------------------------------------------------"
                VP_CABECERA_BITACORA += vbCrLf + vbCrLf
                Dim VP_INFORMACION_A_ESCRIBIR As Byte() = New UTF8Encoding(True).GetBytes(VP_CABECERA_BITACORA)
                VP_FILESTREAM.Write(VP_INFORMACION_A_ESCRIBIR, 0, VP_INFORMACION_A_ESCRIBIR.Length)
                VP_FILESTREAM.Close()
            End If

            Dim VP_STREAMREADER As New StreamWriter(VP_DIRECCION_ARCHIVO, True)

            Dim VP_LINEA_BITACORA As String = ""
            VP_LINEA_BITACORA += vbCrLf + "-- ======================================================================================================= -"
            VP_LINEA_BITACORA += vbCrLf + "-- " + Now().ToString() + "  -Usuario: " + VG_USUARIO + "  -Mensaje: " + PP_MENSAJE
            VP_STREAMREADER.WriteLine(VP_LINEA_BITACORA)
            VP_STREAMREADER.Close()
        Else
            MsgBox("La ruta [ " + VP_RUTA + " ] para la <Bitácora/Log> no existe.")
        End If

    End Sub

#End Region

#Region "FUNCIONES"

    Public Shared Function FG_MENSAJE_CONFIRMACION(ByVal PP_MENSAJE As String) As Boolean

        Dim VP_CAPTION As String = Codigo_FRM.FG_TITULO_VENTANA(0, "Confirmación")
        Dim VP_BOTON As MessageBoxButtons = MessageBoxButtons.YesNo
        Dim VP_ICONO As MessageBoxIcon = MessageBoxIcon.Question
        Dim VP_RESULTADO As Boolean

        Select Case MessageBox.Show(PP_MENSAJE, VP_CAPTION, VP_BOTON, VP_ICONO)
            Case MsgBoxResult.Yes
                VP_RESULTADO = True
            Case MsgBoxResult.No
                VP_RESULTADO = False
        End Select

        Return VP_RESULTADO
    End Function

    Public Shared Function FG_MENSAJE_GUARDAR(ByVal PP_NUEVO As Boolean) As Boolean
        Dim VP_MENSAJE As String = ""
        If PP_NUEVO Then
            VP_MENSAJE = "¿Desea <Guardar/Crear> los cambios?"
        Else
            VP_MENSAJE = "¿Desea <Guardar/Actualizar> los cambios?"
        End If
        Dim VP_RESULTADO As Boolean
        VP_RESULTADO = FG_MENSAJE_CONFIRMACION(VP_MENSAJE)
        Return VP_RESULTADO
    End Function

    Public Shared Function FG_MENSAJE_ELIMINAR(ByVal PP_ID As String, ByVal PP_OBJETO As String) As Boolean
        Dim VP_MENSAJE As String
        VP_MENSAJE = "¿Desea <Eliminar> el registro [ " + PP_OBJETO.FG_STRING_FORMAT(4) + " #" + PP_ID + " ]?" + Environment.NewLine + Environment.NewLine + "Importante: Esta acción no se podrá deshacer."
        Dim VP_RESULTADO As Boolean
        VP_RESULTADO = FG_MENSAJE_CONFIRMACION(VP_MENSAJE)
        Return VP_RESULTADO
    End Function

    Public Shared Function FG_MENSAJE_ELIMINAR(ByVal PP_ID As Integer, ByVal PP_OBJETO As String) As Boolean
        Dim VP_MENSAJE As String
        VP_MENSAJE = "¿Desea <Eliminar> el registro [ " + PP_OBJETO.FG_STRING_FORMAT(4) + " #" + PP_ID.ToString() + " ]?" + Environment.NewLine + Environment.NewLine + "Importante: Esta acción no se podrá deshacer."
        Dim VP_RESULTADO As Boolean
        VP_RESULTADO = FG_MENSAJE_CONFIRMACION(VP_MENSAJE)
        Return VP_RESULTADO
    End Function

    ''' <summary>
    ''' yes = 1, no= 2, cancel= 3
    ''' </summary>
    Public Shared Function FG_MENSAJE_DECISION(ByVal PP_MENSAJE As String)

        Dim VP_CAPTION As String = Codigo_FRM.FG_TITULO_VENTANA(0, "Decisión")
        Dim VP_BOTON As MessageBoxButtons = MessageBoxButtons.YesNoCancel
        Dim VP_ICONO As MessageBoxIcon = MessageBoxIcon.Question
        Dim VP_DECISION As Integer

        Select Case MessageBox.Show(PP_MENSAJE.FG_STRING_FORMAT(4), VP_CAPTION, VP_BOTON, MessageBoxIcon.Question)
            Case MsgBoxResult.Yes
                VP_DECISION = 1
            Case MsgBoxResult.Cancel
                VP_DECISION = 3
            Case MsgBoxResult.No
                VP_DECISION = 2
        End Select

        Return VP_DECISION
    End Function

    'AX // SE UTILIZA EN FLUJO_FIRMA_X_K_USUARIO
    Public Shared Function FG_MENSAJE_DECISION_SINO(ByVal PP_MENSAJE As String)

        Dim VP_CAPTION As String = Codigo_FRM.FG_TITULO_VENTANA(0, "Decisión")
        Dim VP_BOTON As MessageBoxButtons = MessageBoxButtons.YesNo
        Dim VP_ICONO As MessageBoxIcon = MessageBoxIcon.Question
        Dim VP_DECISION As Integer

        Select Case MessageBox.Show(PP_MENSAJE, VP_CAPTION, VP_BOTON, MessageBoxIcon.Question)
            Case MsgBoxResult.Yes
                VP_DECISION = 1
            Case MsgBoxResult.No
                VP_DECISION = 2
        End Select

        Return VP_DECISION

    End Function

    Public Shared Function FG_MENSAJE_ERROR_VS(ByVal PP_NOMBRE_RUTINA As String) As Boolean
        Try

            Dim VP_CAPTION As String = Codigo_FRM.FG_TITULO_VENTANA(0, "Mensaje de Sistema")
            Dim VP_BOTON As MessageBoxButtons = MessageBoxButtons.YesNo
            Dim VP_ICONO As MessageBoxIcon = MessageBoxIcon.Error
            Dim VP_MENSAJE As String

            VP_MENSAJE = "Error de ejecución." + Environment.NewLine + Environment.NewLine
            VP_MENSAJE = VP_MENSAJE + "(a) Rutina: " + PP_NOMBRE_RUTINA + Environment.NewLine
            VP_MENSAJE = VP_MENSAJE + "(b) Error : " + ErrorToString() + Environment.NewLine + Environment.NewLine
            VP_MENSAJE = VP_MENSAJE + "¿Desea Reejecutar la Operación?"

            Dim VP_RESULTADO As Boolean

            Select Case MessageBox.Show(VP_MENSAJE, VP_CAPTION, VP_BOTON, VP_ICONO, MessageBoxDefaultButton.Button2)
                Case MsgBoxResult.Yes
                    VP_RESULTADO = True
                Case MsgBoxResult.No
                    VP_RESULTADO = False
            End Select

            PG_BITACORA_WRITE(VP_MENSAJE)

            Return VP_RESULTADO

        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Function FG_MENSAJE_ERROR_SP(ByVal PP_NOMBRE_RUTINA As String, ByVal PP_STORED_PROCEDURE As String, ByVal PP_PARAMETROS As String) As Boolean
        Try

            Dim VP_CAPTION As String = Codigo_FRM.FG_TITULO_VENTANA(0, "Mensaje de Sistema")
            Dim VP_BOTON As MessageBoxButtons = MessageBoxButtons.YesNo
            Dim VP_ICONO As MessageBoxIcon = MessageBoxIcon.Error
            Dim VP_MENSAJE As String
            VP_MENSAJE = "Error de ejecución." + Environment.NewLine + Environment.NewLine
            VP_MENSAJE = VP_MENSAJE + "(a) Rutina: " + PP_NOMBRE_RUTINA + Environment.NewLine
            VP_MENSAJE = VP_MENSAJE + "(b) Stored Procedure: " + PP_STORED_PROCEDURE + Environment.NewLine
            VP_MENSAJE = VP_MENSAJE + "(c) Parámetros: " + PP_PARAMETROS + Environment.NewLine
            VP_MENSAJE = VP_MENSAJE + "(d) Error : " + ErrorToString() + Environment.NewLine + Environment.NewLine
            VP_MENSAJE = VP_MENSAJE + "¿Desea Reejecutar la Operación?"

            Dim VP_RESULTADO As Boolean

            Select Case MessageBox.Show(VP_MENSAJE, VP_CAPTION, VP_BOTON, VP_ICONO, MessageBoxDefaultButton.Button2)
                Case MsgBoxResult.Yes
                    VP_RESULTADO = True
                Case MsgBoxResult.No
                    VP_RESULTADO = False
            End Select
            PG_BITACORA_WRITE(VP_MENSAJE)
            Return VP_RESULTADO

        Catch ex As Exception
            Return False
        End Try
    End Function

#End Region

End Class

