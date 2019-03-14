Public Class FO_PRUEBA

    Public VM_ID_BASE_DE_DATOS As Integer = 0

#Region "Carga de la forma"

    Private Sub FO_PRUEBA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '==VARIABLES DE LA FORMA========================================================================================================================================================
#Region "Variables de la forma"

        '==INPUTS DE LA FORMA==========================
        Dim VM_TB_LI_BUSCAR As String = ""

        '==COMBOS DE LA FORMA==========================
        Dim VM_COMBOS_FILTRO As New ArrayList From {"ESTATUS_PRELIQUIDACION", "UNIDAD_OPERATIVA"} 'COMBOS PARA FILTRAR LA LISTA

        'VARIABLES
        Dim VM_CB_LI_ESTATUS_PRELIQUIDACION As Integer = -1

        '==LISTADO PRINCIPAL==========================
        Dim VM_LISTADO_ACTIVO As Integer = 1 '1 ACTIVO -- 0 INACTIVO
        'BASE DE DATOS
        Dim VM_TABLA_LISTADO As String = "PRELIQUIDACION"
        Dim VM_PARAMETROS_LISTADO As New ArrayList From {"BUSCAR", "K_ESTATUS_PRELIQUIDACION"}
        Dim VM_VALORES_LISTADO As New ArrayList From {VM_TB_LI_BUSCAR, VM_CB_LI_ESTATUS_PRELIQUIDACION}
        'FORMATO TABLA
        Dim VM_CAMPOS As New ArrayList From {"K_PRELIQUIDACION", "D_PUNTO_VENTA", "D_ESTATUS_PRELIQUIDACION", "D_OPERADOR", "D_UNIDAD_OPERATIVA"}
        Dim VM_TITULOS As New ArrayList From {"#PRE", "Punto de venta", "Estatus", "Operador", "Unidad operativa"}
        '1 | ID -- 2 | DESCRIPCION -- 3 | ESTATUS -- 4 | GENERAL -- 5 | SIGLAS
        Dim VM_TIPOS As New ArrayList From {1, 2, 3, 4, 4}

#End Region

        '==PROCESOS Y FUNCIONES========================================================================================================================================================

        'INICIALIZADORES DE LA FORMA
        Codigo_FRM.PG_FRM_INIT(VM_ID_BASE_DE_DATOS, Me)

        'PROCESO QUE INICIALIZA LOS COMBOS PARA FILTRAR
        LIQ19_Codigo.PG_CREAR_COMBOS_FILTROS(Me, VM_ID_BASE_DE_DATOS, VM_COMBOS_FILTRO)

        'PROCESO PARA CREAR EL LISTADO PRINCIPAL DE LA FORMA.
        If VM_LISTADO_ACTIVO = 1 Then
            'BUSCAR(-1) 'BUSCAR TODOS
        End If

    End Sub

#End Region

#Region "Procesos"

    'PROCESO PARA BUSQUEDA || -1 | TODOS -- 1 | UN REGISTRO
    'Public Sub BUSCAR(PP_CANTIDAD As Integer)
    '    Dim VP_DATOS As DataTable = Movimiento.OBTENER(VM_TABLA_LISTADO, VM_PARAMETROS_LISTADO, VM_VALORES_LISTADO, PP_CANTIDAD)
    '    Listado.NUEVO(VP_DATOS, LI_LISTADO, VM_CAMPOS, VM_TITULOS, VM_TIPOS)
    'End Sub

    'RELOJ
    Private Sub TI_RELOJ_Tick(sender As Object, e As EventArgs) Handles TI_RELOJ.Tick
        Codigo_FRM.PG_TI_TICK(LB_RELOJ)
    End Sub

    'BOTON DE BUSQUEDA
    Private Sub BT_LI_BUSCAR_Click(sender As Object, e As EventArgs)
        'BUSCAR(-1)
    End Sub



    'MANDAR A IMPRIMIR LISTADO A EXCEL.
    Private Sub BT_EXPORTAR_EXCEL_Click(sender As Object, e As EventArgs) Handles BT_EXPORTAR_EXCEL.Click
        Codigo_ABC.PG_BT_EXPORTAR_EXCEL_CLICK(LI_LISTADO)
    End Sub

#End Region


End Class
