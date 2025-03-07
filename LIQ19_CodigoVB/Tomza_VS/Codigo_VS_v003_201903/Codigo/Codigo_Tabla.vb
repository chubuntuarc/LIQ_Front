﻿Public Class Codigo_Tabla

    Public Shared Function FG_TABLA_TEMPORAL() As DataTable
        Dim VP_PARAMETROS_SUCURSAL As New DataTable("VP_PARAMETROS_SUCURSAL")


        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "K_PARAMETRO_SUCURSAL_D0M4", GetType(Integer))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "D_PARAMETRO_SUCURSAL_D0M4", GetType(String))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "K_UNIDAD_OPERATIVA", GetType(Integer))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "D_UNIDAD_OPERATIVA", GetType(String))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "K_YYYY", GetType(Integer))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "K_MM", GetType(Integer))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "D_MES", GetType(String))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "P2016_DTO_DESCUENTO_X_KG", GetType(Decimal))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "DESCUENTO_CONTADO", GetType(Decimal))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "DESCUENTO_CREDITO", GetType(Decimal))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "P2023_PCN", GetType(Decimal))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "P1003_VENTA_KG_CONTADO", GetType(Decimal))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "P1004_VENTA_KG_CREDITO", GetType(Decimal))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "P1012_CARTERA_CYC_INICIAL", GetType(Decimal))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "P1013_CARTERA_CYC_FINAL", GetType(Decimal))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "COBRANZA_HOLGURA", GetType(Decimal))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "PERFIL_VENTA_CONTADO_1_LUNES", GetType(Decimal))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "PERFIL_VENTA_CONTADO_2_MARTES", GetType(Decimal))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "PERFIL_VENTA_CONTADO_3_MIERCOLES", GetType(Decimal))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "PERFIL_VENTA_CONTADO_4_JUEVES", GetType(Decimal))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "PERFIL_VENTA_CONTADO_5_VIERNES", GetType(Decimal))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "PERFIL_VENTA_CONTADO_6_SABADO", GetType(Decimal))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "PERFIL_VENTA_CONTADO_7_DOMINGO", GetType(Decimal))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "PERFIL_VENTA_CREDITO_1_LUNES", GetType(Decimal))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "PERFIL_VENTA_CREDITO_2_MARTES", GetType(Decimal))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "PERFIL_VENTA_CREDITO_3_MIERCOLES", GetType(Decimal))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "PERFIL_VENTA_CREDITO_4_JUEVES", GetType(Decimal))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "PERFIL_VENTA_CREDITO_5_VIERNES", GetType(Decimal))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "PERFIL_VENTA_CREDITO_6_SABADO", GetType(Decimal))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "PERFIL_VENTA_CREDITO_7_DOMINGO", GetType(Decimal))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "PERFIL_COBRANZA_1_LUNES", GetType(Decimal))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "PERFIL_COBRANZA_2_MARTES", GetType(Decimal))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "PERFIL_COBRANZA_3_MIERCOLES", GetType(Decimal))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "PERFIL_COBRANZA_4_JUEVES", GetType(Decimal))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "PERFIL_COBRANZA_5_VIERNES", GetType(Decimal))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "PERFIL_COBRANZA_6_SABADO", GetType(Decimal))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "PERFIL_COBRANZA_7_DOMINGO", GetType(Decimal))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "K_USUARIO_ALTA", GetType(Integer))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "F_ALTA", GetType(String))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "K_USUARIO_CAMBIO", GetType(Integer))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "D_USUARIO_CAMBIO", GetType(String))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "F_CAMBIO", GetType(String))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "L_BORRADO", GetType(Integer))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "K_USUARIO_BAJA", GetType(Integer))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "F_BAJA", GetType(String))
        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "D_ZONA", GetType(String))

        PG_ADD_COLUMN(VP_PARAMETROS_SUCURSAL, "Modificado", GetType(Integer))

        Return VP_PARAMETROS_SUCURSAL

    End Function

    Public Shared Sub PG_ADD_COLUMN(ByRef PP_TABLA As DataTable, ByVal PP_NOMBRE As String, ByVal PP_TIPO As Type)

        Dim VP_COLUMNA As New DataColumn With {
        .ColumnName = PP_NOMBRE,
        .DataType = PP_TIPO
        }

        PP_TABLA.Columns.Add(VP_COLUMNA)
    End Sub

    Public Shared Function FG_TABLA_RESULTADOS() As DataTable
        Dim VP_TABLA As New DataTable

        PG_ADD_COLUMN(VP_TABLA, "CLAVE", GetType(Integer))
        PG_ADD_COLUMN(VP_TABLA, "EXITO", GetType(String))
        PG_ADD_COLUMN(VP_TABLA, "MENSAJE", GetType(String))


        Return VP_TABLA

    End Function


    Private Shared Sub PG_LI_FORMAT_TEMP(ByRef PP_LI_LISTADO As DataGridView)
        PP_LI_LISTADO.AllowUserToAddRows = False
        Codigo_LI.PG_LI_FORMAT_SETUP(PP_LI_LISTADO, 8, 16)
        'PARAMETROS: NOMBRE_DATAGRIDVIEW, NOMBRE_COLUMNA, HEADER_TEXT, TIPO_DATO, 
        '            ANCHO_CELDA, ALINEACION, SOLO_LECTURA, Visible, FROZEN, FORMAT
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_PARAMETRO_SUCURSAL_D0M4", "ID", GetType(Integer), 80, 1, 1, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_PARAMETRO_SUCURSAL_D0M4", "DESCRIPCION", GetType(Integer), 80, 1, 1, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "K_UNIDAD_OPERATIVA", "ID UNIDAD OPERATIVA", GetType(String), 80, 1, 1, 0, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_UNIDAD_OPERATIVA", "UNIDAD OPERATIVA", GetType(String), 80, 1, 1, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD_F_yyyy(PP_LI_LISTADO, "K_YYYY", "AÑO")
        Codigo_LI.PG_LI_COLUMN_ADD_F_mes(PP_LI_LISTADO, "K_MM", "MES")
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "D_MES", "MES", GetType(Integer), 80, 1, 1, 1, 1, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "P2016_DTO_DESCUENTO_X_KG", "DESCUENTO X KG", GetType(Decimal), 100, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DESCUENTO_CONTADO", "DESCUENTO DE CONTADO", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "DESCUENTO_CREDITO", "DESCUENTO DE CREDITO", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "P2023_PCN", "PCN", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "P1003_VENTA_KG_CONTADO", "VENTA KG CONTADO", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "P1004_VENTA_KG_CREDITO", "VENTA KG CREDITO", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "P1012_CARTERA_CYC_INICIAL", "CARTERA CYC INICIAL", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "P1013_CARTERA_CYC_FINAL", "CARTERA CYC FINAL", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "COBRANZA_HOLGURA", "COBRANZA HOLGURA", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_VENTA_CONTADO_1_LUNES", "VENTA CONTADO LUNES", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_VENTA_CONTADO_2_MARTES", "VENTA CONTADO MARTES", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_VENTA_CONTADO_3_MIERCOLES", "VENTA CONTADO MIERCOLES", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_VENTA_CONTADO_4_JUEVES", "VENTA CONTADO JUEVES", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_VENTA_CONTADO_5_VIERNES", "VENTA CONTADO VIERNES", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_VENTA_CONTADO_6_SABADO", "VENTA CONTADO SABADO", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_VENTA_CONTADO_7_DOMINGO", "VENTA CONTADO DOMINGO", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_VENTA_CREDITO_1_LUNES", "VENTA CREDITO LUNES", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_VENTA_CREDITO_2_MARTES", "VENTA CREDITO MARTES", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_VENTA_CREDITO_3_MIERCOLES", "VENTA CREDITO MIERCOLES", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_VENTA_CREDITO_4_JUEVES", "VENTA CREDITO JUEVES", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_VENTA_CREDITO_5_VIERNES", "VENTA CREDITO VIERNES", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_VENTA_CREDITO_6_SABADO", "VENTA CREDITO SABADO", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_VENTA_CREDITO_7_DOMINGO", "VENTA CREDITO DOMINGO", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_COBRANZA_1_LUNES", "COBRANZA LUNES", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_COBRANZA_2_MARTES", "COBRANZA MARTES", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_COBRANZA_3_MIERCOLES", "COBRANZA MIERCOLES", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_COBRANZA_4_JUEVES", "COBRANZA JUEVES", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_COBRANZA_5_VIERNES", "COBRANZA VIERNES", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_COBRANZA_6_SABADO", "COBRANZA SABADO", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "PERFIL_COBRANZA_7_DOMINGO", "COBRANZA DOMINGO", GetType(Decimal), 89, 1, 1, 1, 0, 0)
        Codigo_FRM.PG_FRM_LI_FORMAT_CONTROL_LOAD(PP_LI_LISTADO, 100, 2, 0, 0, 0, 0)
        Codigo_LI.PG_LI_COLUMN_ADD(PP_LI_LISTADO, "Modificado", "Modificado", GetType(Integer), 90, 3, 1, 1, 0, 0)
    End Sub

    Public Shared Sub PG_ROW_CLONE(ByVal PP_ROW As DataGridViewRow, ByRef PP_OTRO_ROW As DataGridViewRow)
        For Each VP_CELL As DataGridViewCell In PP_ROW.Cells
            PP_OTRO_ROW.Cells(VP_CELL.ColumnIndex).Value = PP_ROW.Cells(VP_CELL.ColumnIndex).Value
        Next
    End Sub

End Class
