Imports System.Globalization
Imports System.Threading

Public Class FO_PRUEBA

#Region "Base"

    '==INPUTS DE LA FORMA==========================

    Public Shared VM_TB_LI_BUSCAR As String = ""

    '==COMBOS DE LA FORMA==========================

    'COMBOS PARA FILTRAR LA LISTA
    Public Shared VM_COMBOS_FILTRO As New ArrayList From {"ESTATUS_PRELIQUIDACION", "UNIDAD_OPERATIVA"}
    'VARIABLES
    Public Shared VM_CB_LI_ESTATUS_PRELIQUIDACION As Integer = -1

    '==LISTADO PRINCIPAL==========================

    Public Shared VM_LISTADO_ACTIVO As Integer = 1 '1 ACTIVO -- 0 INACTIVO
    'BASE DE DATOS
    Public Shared VM_TABLA_LISTADO As String = "PRELIQUIDACION"
    Public Shared VM_PARAMETROS_LISTADO As New ArrayList From {"BUSCAR", "K_ESTATUS_PRELIQUIDACION"}
    Public Shared VM_VALORES_LISTADO As New ArrayList From {VM_TB_LI_BUSCAR, VM_CB_LI_ESTATUS_PRELIQUIDACION}
    'FORMATO TABLA
    Public Shared VM_CAMPOS As New ArrayList From {"K_PRELIQUIDACION", "D_PUNTO_VENTA", "D_ESTATUS_PRELIQUIDACION", "D_OPERADOR", "D_UNIDAD_OPERATIVA"}
    Public Shared VM_TITULOS As New ArrayList From {"#PRE", "Punto de venta", "Estatus", "Operador", "Unidad operativa"}
    '1 | ID -- 2 | DESCRIPCION -- 3 | ESTATUS -- 4 | GENERAL -- 5 | SIGLAS
    Public Shared VM_TIPOS As New ArrayList From {1, 2, 3, 4, 4}

    '==VARIABLES DE LA FORMA-======================

    Public VM_ID_BASE_DE_DATOS As Integer = 0

#End Region

#Region "Carga de la forma"

    Private Sub FO_PRUEBA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'INICIALIZADORES DE LA FORMA
        Codigo_FRM.PG_FRM_INIT(VM_ID_BASE_DE_DATOS, Me)

        'PROCESO QUE INICIALIZA LOS COMBOS PARA FILTRAR
        COMBOS(VM_COMBOS_FILTRO)

        'PROCESO PARA CREAR EL LISTADO PRINCIPAL DE LA FORMA.
        If VM_LISTADO_ACTIVO = 1 Then
            BUSCAR(-1) 'BUSCAR TODOS
        End If

    End Sub

#End Region

#Region "Procesos"

    'PROCESO PARA BUSQUEDA || -1 | TODOS -- 1 | UN REGISTRO
    Public Sub BUSCAR(PP_CANTIDAD As Integer)
        Dim VP_DATOS As DataTable = Movimiento.OBTENER(VM_TABLA_LISTADO, VM_PARAMETROS_LISTADO, VM_VALORES_LISTADO, PP_CANTIDAD)
        Listado.NUEVO(VP_DATOS, LI_LISTADO, VM_CAMPOS, VM_TITULOS, VM_TIPOS)
    End Sub

    'RELOJ
    Private Sub TI_RELOJ_Tick(sender As Object, e As EventArgs) Handles TI_RELOJ.Tick
        Codigo_FRM.PG_TI_TICK(LB_RELOJ)
    End Sub

    'BOTON DE BUSQUEDA
    Private Sub BT_LI_BUSCAR_Click(sender As Object, e As EventArgs) Handles BT_LI_BUSCAR.Click
        BUSCAR(-1)
    End Sub

    'PROCESO PARA INICIALIZAR COMBOS
    Public Sub COMBOS(PP_COMBOS As ArrayList)
        Codigo_FI.PG_FI_CONTROL_DATA_SETUP(VM_ID_BASE_DE_DATOS, Me)
        Dim VP_CONTADOR = 210
        For VP_INDICE As Integer = 0 To PP_COMBOS.Count - 1

            Dim VP_NOMBRE_COMBO = PP_COMBOS(VP_INDICE)

            Dim curCulture As CultureInfo = Thread.CurrentThread.CurrentCulture
            Dim tInfo As TextInfo = curCulture.TextInfo()

            Dim VP_CONVERSION_TEXTO = tInfo.ToTitleCase(tInfo.ToLower(VP_NOMBRE_COMBO)).ToString() 'CONVIERTE EL TEXTO
            Dim VP_POSICION As Integer = VP_CONVERSION_TEXTO.IndexOf("_")

            Dim VP_ETIQUETA = ""
            If VP_POSICION > 0 Then
                VP_ETIQUETA = VP_CONVERSION_TEXTO.Substring(0, VP_POSICION)
            Else
                VP_ETIQUETA = VP_CONVERSION_TEXTO
            End If

            'CREAR EL COMBOBOX
            Dim COMBO As ComboBox = New ComboBox
            COMBO.Name = "CB_LI_" + VP_NOMBRE_COMBO
            COMBO.Width = 100
            COMBO.Location = New Point(VP_CONTADOR, 32)
            COMBO.BringToFront()
            Me.GB_FILTROS.Controls.Add(COMBO)

            Codigo_CB.PG_CB_LOAD_X_ORDEN(VM_ID_BASE_DE_DATOS, Me, COMBO, PP_COMBOS(VP_INDICE))

            'CREAR LA ETIQUETA
            Dim VP_LABEL As Label = New Label
            VP_LABEL.Name = "LB_LI_" + VP_ETIQUETA
            VP_LABEL.Location = New Point(VP_CONTADOR, 18)
            VP_LABEL.Text = VP_ETIQUETA
            VP_LABEL.BringToFront()
            Me.GB_FILTROS.Controls.Add(VP_LABEL)

            VP_CONTADOR += 110
        Next

    End Sub

    'MANDAR A IMPRIMIR LISTADO A EXCEL.
    Private Sub BT_EXPORTAR_EXCEL_Click(sender As Object, e As EventArgs) Handles BT_EXPORTAR_EXCEL.Click
        Codigo_ABC.PG_BT_EXPORTAR_EXCEL_CLICK(LI_LISTADO)
    End Sub

#End Region


End Class
