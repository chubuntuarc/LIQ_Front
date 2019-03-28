Public Class Codigo_TOMZA


    Public Shared Sub PG_CB_ZONA_UO_x_AccesoLoad(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_CB_COMBO As ComboBox, ByVal PP_L_CON_TODOS As Integer, ByVal PP_K_USUARIO As Integer)
        ', ByVal PP_L_CON_RAZON_SOCIAL As Integer)
        ', ByVal PP_CB_ZONA_UO As ComboBox, ByVal PP_CB_RAZON_SOCIAL As ComboBox, ByVal PP_K_USUARIO As Integer)
        Try
            Dim VP_PARAMETROS As String

            Dim PP_L_CON_RAZON_SOCIAL As Integer = 0

            VP_PARAMETROS = PP_L_CON_TODOS.ToString + ", " + PP_L_CON_RAZON_SOCIAL.ToString

            Codigo_CB.PG_CB_LOAD_X_ORDEN(PP_BD_Index, PP_FORMA, PP_CB_COMBO, "[PG_CB_ZONA_UO_x_AccesoLoad]", VP_PARAMETROS, PP_K_USUARIO)
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_CB_UNIDAD_OPERATIVA__x_AccesoLoad")
        End Try
    End Sub

    Public Shared Sub PG_CB_RAZON_SOCIAL_x_AccesoLoad(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_CB_COMBO As ComboBox, ByVal PP_L_CON_TODOS As Integer, ByVal PP_K_USUARIO As Integer)
        ', ByVal PP_L_CON_RAZON_SOCIAL As Integer)
        ', ByVal PP_CB_ZONA_UO As ComboBox, ByVal PP_CB_RAZON_SOCIAL As ComboBox, ByVal PP_K_USUARIO As Integer)
        Try
            Dim VP_PARAMETROS, VP_K_TIPO_RAZON_SOCIAL As String

            VP_K_TIPO_RAZON_SOCIAL = "-1"

            Dim PP_L_CON_RAZON_SOCIAL As Integer = 0

            VP_PARAMETROS = PP_L_CON_TODOS.ToString + ", " + PP_L_CON_RAZON_SOCIAL.ToString + ", " + VP_K_TIPO_RAZON_SOCIAL

            Codigo_CB.PG_CB_LOAD_X_ORDEN(PP_BD_Index, PP_FORMA, PP_CB_COMBO, "[PG_CB_RAZON_SOCIAL_x_AccesoLoad]", VP_PARAMETROS, PP_K_USUARIO)
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_CB_UNIDAD_OPERATIVA__x_AccesoLoad")
        End Try
    End Sub


    Public Shared Sub PG_CB_UNIDAD_OPERATIVA_x_AccesoLoad(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_CB_COMBO As ComboBox, ByVal PP_L_CON_TODOS As Integer, ByVal PP_K_USUARIO As Integer)
        ', ByVal PP_L_CON_RAZON_SOCIAL As Integer)
        ', ByVal PP_CB_ZONA_UO As ComboBox, ByVal PP_CB_RAZON_SOCIAL As ComboBox, ByVal PP_K_USUARIO As Integer)
        Try
            Dim VP_PARAMETROS, VP_K_ZONA, VP_K_RAZON_SOCIAL As String

            VP_K_ZONA = -1
            VP_K_RAZON_SOCIAL = -1

            'VP_K_ZONA = FG_CB_ITEM_VALUE(PP_CB_ZONA_UO)
            'VP_K_RAZON_SOCIAL = FG_CB_ITEM_VALUE(PP_CB_RAZON_SOCIAL)

            Dim PP_L_CON_RAZON_SOCIAL As Integer = 0

            VP_PARAMETROS = PP_L_CON_TODOS.ToString + ", " + PP_L_CON_RAZON_SOCIAL.ToString + ", " + VP_K_ZONA + ", " + VP_K_RAZON_SOCIAL

            Codigo_CB.PG_CB_LOAD_X_ORDEN(PP_BD_Index, PP_FORMA, PP_CB_COMBO, "[PG_CB_UNIDAD_OPERATIVA_x_AccesoLoad]", VP_PARAMETROS, PP_K_USUARIO)
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_CB_UNIDAD_OPERATIVA__x_AccesoLoad")
        End Try
    End Sub


    Public Shared Sub PG_CB_ZONA_UO_Load(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_CB_COMBO As ComboBox, ByVal PP_K_USUARIO As Integer)
        Try
            Dim VP_PARAMETROS As String
            VP_PARAMETROS = (0).ToString
            Codigo_CB.PG_CB_LOAD_X_ORDEN(PP_BD_Index, PP_FORMA, PP_CB_COMBO, "[PG_CB_ZONA_UO_Load]", VP_PARAMETROS, PP_K_USUARIO)
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_CB_ZONA_UO_Load")
        End Try
    End Sub

    Public Shared Sub PG_CB_ZONA_UO_TODOS_Load(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_CB_COMBO As ComboBox, ByVal PP_K_USUARIO As Integer)
        Try
            Dim VP_PARAMETROS As String
            VP_PARAMETROS = (1).ToString
            Codigo_CB.PG_CB_LOAD_X_ORDEN(PP_BD_Index, PP_FORMA, PP_CB_COMBO, "[PG_CB_ZONA_UO_Load]", VP_PARAMETROS, PP_K_USUARIO)
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_CB_ZONA_UO_Load")
        End Try
    End Sub

    Public Shared Sub PG_CB_UNIDAD_OPERATIVA_Load(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_CB_COMBO As ComboBox, ByVal PP_L_CON_TODOS As Integer, ByVal PP_L_CON_RAZON_SOCIAL As Integer, ByVal PP_CB_ZONA_UO As ComboBox, ByVal PP_CB_RAZON_SOCIAL As ComboBox, ByVal PP_K_USUARIO As Integer)
        Try
            Dim VP_PARAMETROS, VP_ZONA_VALUE, VP_RS_VALUE As String

            VP_ZONA_VALUE = Codigo_CB.FG_CB_ITEM_VALUE(PP_CB_ZONA_UO)
            VP_RS_VALUE = Codigo_CB.FG_CB_ITEM_VALUE(PP_CB_RAZON_SOCIAL)

            VP_PARAMETROS = PP_L_CON_TODOS.ToString + ", " + PP_L_CON_RAZON_SOCIAL.ToString + ", " + VP_ZONA_VALUE + ", " + VP_RS_VALUE

            Codigo_CB.PG_CB_LOAD_X_ORDEN(PP_BD_Index, PP_FORMA, PP_CB_COMBO, "[PG_CB_UNIDAD_OPERATIVA_Load]", VP_PARAMETROS, PP_K_USUARIO)
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_CB_UNIDAD_OPERATIVA_Load")
        End Try
    End Sub



    Public Shared Sub PG_CB_RAZON_SOCIAL_Load(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_CB_COMBO As ComboBox, ByVal PP_L_CON_TODOS As Integer, ByVal PP_CB_ESTATUS As ComboBox, ByVal PP_CB_TIPO As ComboBox, ByVal PP_K_USUARIO As Integer) ', ByVal PP_CB_REGION As ComboBox)
        Try
            Dim VP_PARAMETROS, VP_ESTATUS_VALUE, VP_TIPO_VALUE, VP_REGION_VALUE As String
            VP_ESTATUS_VALUE = Codigo_CB.FG_CB_ITEM_VALUE(PP_CB_ESTATUS)
            VP_TIPO_VALUE = Codigo_CB.FG_CB_ITEM_VALUE(PP_CB_TIPO)
            VP_REGION_VALUE = "-1" ' FG_CB_ITEM_VALUE(PP_CB_REGION)
            VP_PARAMETROS = PP_L_CON_TODOS.ToString + ", " + VP_ESTATUS_VALUE + ", " + VP_TIPO_VALUE + ", " + VP_REGION_VALUE
            Codigo_CB.PG_CB_LOAD_X_ORDEN(PP_BD_Index, PP_FORMA, PP_CB_COMBO, "[PG_CB_RAZON_SOCIAL_Load]", VP_PARAMETROS, PP_K_USUARIO)
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_CB_RAZON_SOCIAL_Load")
        End Try
    End Sub

    Public Shared Sub PG_CB_RAZON_SOCIAL_GASERAS_Load(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_CB_COMBO As ComboBox, ByVal PP_L_CON_TODOS As Integer, ByVal PP_CB_ESTATUS As ComboBox, ByVal PP_K_USUARIO As Integer) ', ByVal PP_CB_REGION As ComboBox)
        Try
            Dim VP_PARAMETROS, VP_ESTATUS_VALUE, VP_TIPO_VALUE, VP_REGION_VALUE As String

            VP_ESTATUS_VALUE = Codigo_CB.FG_CB_ITEM_VALUE(PP_CB_ESTATUS)
            VP_TIPO_VALUE = "1" ' RAZÓN SOCIAL TIPO 1 = GASERAS
            VP_REGION_VALUE = "-1" 'FG_CB_ITEM_VALUE(PP_CB_REGION)

            VP_PARAMETROS = PP_L_CON_TODOS.ToString + ", " + VP_ESTATUS_VALUE + ", " + VP_TIPO_VALUE + ", " + VP_REGION_VALUE
            Codigo_CB.PG_CB_LOAD_X_ORDEN(PP_BD_Index, PP_FORMA, PP_CB_COMBO, "[PG_CB_RAZON_SOCIAL_Load]", VP_PARAMETROS, PP_K_USUARIO)
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_CB_RAZON_SOCIAL_GASERAS_Load")
        End Try
    End Sub


    Public Shared Sub PG_CB_CUENTA_BANCO_Load(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_CB_COMBO As ComboBox, ByVal PP_L_CON_TODOS As Integer, ByVal PP_CB_RAZON_SOCIAL As ComboBox, ByVal PP_CB_UNIDAD_OPERATIVA As ComboBox, ByVal PP_CB_BANCO As ComboBox,
                                          ByVal PP_CB_MONEDA As ComboBox, ByVal PP_CB_ESTATUS As ComboBox, ByVal PP_CB_TIPO As ComboBox, ByVal PP_CB_ESTADO As ComboBox, ByVal PP_K_USUARIO As Integer)
        Try
            Dim VP_PARAMETROS, VP_RS_VALUE, VP_UNIDAD_OPERATIVA, VP_BANCO_VALUE, VP_MONEDA_VALUE, VP_ESTATUS_VALUE, VP_TIPO_VALUE, VP_ESTADO_VALUE As String
            VP_RS_VALUE = Codigo_CB.FG_CB_ITEM_VALUE(PP_CB_RAZON_SOCIAL)
            VP_UNIDAD_OPERATIVA = Codigo_CB.FG_CB_ITEM_VALUE(PP_CB_UNIDAD_OPERATIVA)
            VP_BANCO_VALUE = Codigo_CB.FG_CB_ITEM_VALUE(PP_CB_BANCO)
            VP_MONEDA_VALUE = Codigo_CB.FG_CB_ITEM_VALUE(PP_CB_MONEDA)
            VP_ESTATUS_VALUE = Codigo_CB.FG_CB_ITEM_VALUE(PP_CB_ESTATUS)
            VP_TIPO_VALUE = Codigo_CB.FG_CB_ITEM_VALUE(PP_CB_TIPO)
            VP_ESTADO_VALUE = Codigo_CB.FG_CB_ITEM_VALUE(PP_CB_ESTADO)
            VP_PARAMETROS = PP_L_CON_TODOS.ToString + ", " + VP_RS_VALUE + ", " + VP_UNIDAD_OPERATIVA + ", " + VP_BANCO_VALUE + ", " + VP_MONEDA_VALUE + ", " + VP_ESTATUS_VALUE + ", " + VP_TIPO_VALUE + ", " + VP_ESTADO_VALUE
            Codigo_CB.PG_CB_LOAD_X_ORDEN(PP_BD_Index, PP_FORMA, PP_CB_COMBO, "[PG_CB_CUENTA_BANCO_Load]", VP_PARAMETROS, PP_K_USUARIO)
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_CB_CUENTA_BANCO_Load")
        End Try
    End Sub


    Public Shared Sub PG_CB_CUENTA_BANCO_Load_X_ORGANIZACION(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_CB_COMBO As ComboBox, ByVal PP_L_CON_TODOS As Integer,
                                              ByVal PP_CB_RAZON_SOCIAL As ComboBox, ByVal PP_CB_UNIDAD_OPERATIVA As ComboBox, ByVal PP_K_USUARIO As Integer)
        PG_CB_CUENTA_BANCO_Load(PP_BD_Index, PP_FORMA, PP_CB_COMBO, PP_L_CON_TODOS, PP_CB_RAZON_SOCIAL,
                                PP_CB_UNIDAD_OPERATIVA, New ComboBox, New ComboBox, New ComboBox, New ComboBox, New ComboBox, PP_K_USUARIO)
    End Sub


    Public Shared Sub PG_CB_RUBRO_PRESUPUESTO_Load(ByVal PP_BD_Index As Integer, ByRef PP_FORMA As Object, ByRef PP_CB_COMBO As ComboBox, ByVal PP_L_CON_TODOS As Integer, ByVal PP_K_USUARIO As Integer)
        Try
            Dim VP_PARAMETROS As String
            VP_PARAMETROS = PP_L_CON_TODOS.ToString
            Codigo_CB.PG_CB_LOAD_X_ORDEN(PP_BD_Index, PP_FORMA, PP_CB_COMBO, "[PG_CB_RUBRO_PRESUPUESTO_Load]", VP_PARAMETROS, PP_K_USUARIO)
        Catch ex As ArgumentException
            Codigo_Mensaje.PG_MENSAJE_ERROR_VS("PG_CB_RUBRO_PRESUPUESTO_Load")
        End Try
    End Sub



    Public Shared Sub PG_LI_COLUMN_Add_S_UnidadOperativa(ByRef PP_LISTADO As DataGridView)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, ANCHO_CELDA, ALINEACION[1.Izq, 2.Cen, 3.Der], 
        '            SOLO_LECTURA[0, 1], VISIBLE[0, 1], FROZEN[0, 1], FORMATO MONEDA[0, (1, 2)],PP_COLOR_FONT [1=RED], PP_COLOR_BACKGROUND [1=RED],
        '            PP_BOLD[0,1] 

        Codigo_LI.PG_LI_COLUMN_ADD(PP_LISTADO, "S_UNIDAD_OPERATIVA", "Unidad Operativa", GetType(String), 80, 2, 0, 1, 1, 0, Color.Orange, Color.White, 1)

    End Sub


    Public Shared Sub PG_LI_COLUMN_Add_S_ZonaRazonUnidad(ByRef PP_LI_LISTADO As DataGridView)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, ANCHO_CELDA, ALINEACION[1.Izq, 2.Cen, 3.Der], 
        '            SOLO_LECTURA[0, 1], VISIBLE[0, 1], FROZEN[0, 1], FORMATO MONEDA[0, (1, 2)],PP_COLOR_FONT [1=RED], PP_COLOR_BACKGROUND [1=RED],
        '            PP_BOLD[0,1] 

        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_ZONA_UO", "Zona", GetType(String), 80, 2, 0, 1, 1, 0, Color.Black, Color.White, 1)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "S_RAZON_SOCIAL", "R. Social", GetType(String), 80, 2, 0, 1, 1, 0, Color.Black, Color.White, 1)
        Codigo_TOMZA.PG_LI_COLUMN_Add_S_UnidadOperativa(PP_LI_LISTADO)

    End Sub


    Public Shared Sub PG_LI_ROW_Write_S_ZonaRazonUnidad(ByRef PP_LISTADO As DataGridView, ByVal PP_ROW As Integer, ByRef PP_COLUMNA As Integer, ByVal PP_ROW_DATA As DataRow)

        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, PP_ROW, PP_COLUMNA, PP_ROW_DATA, "S_ZONA_UO")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, PP_ROW, PP_COLUMNA, PP_ROW_DATA, "S_RAZON_SOCIAL")
        Codigo_LI.PG_LI_CELL_WRITE_SECUENCIAL(PP_LISTADO, PP_ROW, PP_COLUMNA, PP_ROW_DATA, "S_UNIDAD_OPERATIVA")

    End Sub

End Class
