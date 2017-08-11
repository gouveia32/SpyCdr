Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Rendering
Imports DevExpress.XtraExport
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Export
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraBars

Public Class frmPrincipal2
    'Inherits System.Windows.Forms.Form
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    'Inherits DevExpress.XtraBars.Ribbon.RibbonForm


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents imageList1 As System.Windows.Forms.ImageList
    Friend WithEvents labelStatus As DevComponents.DotNetBar.LabelItem
    Private WithEvents barStatus As DevComponents.DotNetBar.Bar
    Friend WithEvents ribbonControl1 As DevComponents.DotNetBar.RibbonControl
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents btnMenuPesquisaCDRs As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnMenuSair As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnMenuResumoDiario As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents menuFileContainer As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents menuFileTwoColumnContainer As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents menuFileItems As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ButtonFile As DevComponents.DotNetBar.Office2007StartButton
    Friend WithEvents ItemContainerPrincipal As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents lblUsuario As DevComponents.DotNetBar.LabelItem
    Friend WithEvents lblMensRegistros As DevComponents.DotNetBar.LabelItem
    Friend WithEvents btnMenuConsultarHistorico As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents AppCommandTheme As DevComponents.DotNetBar.Command
    Friend WithEvents buttonChangeStyle As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonStyleOffice2007Blue As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonStyleOffice2007Black As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonStyleOffice2007Silver As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonStyleCustom As DevComponents.DotNetBar.ColorPickerDropDown
    Friend WithEvents btnMenuGerarHistorico As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonPanel1 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonBar2 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents rbtPesquisaCDRs As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents btnProcessar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar3 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents RibbonPanel2 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonBar4 As DevComponents.DotNetBar.RibbonBar
    Public WithEvents btnDepositar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonTabItemLancamentos As DevComponents.DotNetBar.RibbonTabItem
    Public WithEvents ButtonItemPagar As DevComponents.DotNetBar.ButtonItem
    Public WithEvents ButtonItemTransferir As DevComponents.DotNetBar.ButtonItem
    Public WithEvents ButtonItemReconciliar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonPanel3 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonTabItemProgramacao As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents RibbonPanel7 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonTabItemPesquisa As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents RibbonBar13 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents RibbonBar12 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents RibbonBar11 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents QatCustomizeItem1 As DevComponents.DotNetBar.QatCustomizeItem
    Friend WithEvents btnGravarCriterio As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ItemContainer3 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ButtonItemAgrupamento As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItemEscolherColunas As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ItemContainer5 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents CheckBoxItem2 As DevComponents.DotNetBar.CheckBoxItem
    Friend WithEvents CheckBoxItem3 As DevComponents.DotNetBar.CheckBoxItem
    Friend WithEvents HTML As DevComponents.Editors.ComboItem
    Friend WithEvents XML As DevComponents.Editors.ComboItem
    Friend WithEvents XLX As DevComponents.Editors.ComboItem
    Friend WithEvents XLS As DevComponents.Editors.ComboItem
    Friend WithEvents RTF As DevComponents.Editors.ComboItem
    Friend WithEvents PDF As DevComponents.Editors.ComboItem
    Friend WithEvents MHT As DevComponents.Editors.ComboItem
    Friend WithEvents TXT As DevComponents.Editors.ComboItem
    Friend WithEvents ItemContainer9 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents btnPrimeiraPag As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnPagAnterior As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnProximaPag As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnUltimaPag As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents chkBarra As DevComponents.DotNetBar.CheckBoxItem
    Friend WithEvents ItemContainer10 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents chkPainelLateral As DevComponents.DotNetBar.CheckBoxItem
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents RibbonPanel5 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonPanel4 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonBar1 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents rbtResumoDiario As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents rbtHistorico As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents RibbonBar6 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem7 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar7 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar5 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonPanel6 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents ButtonItemFavoritos As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItemAproximar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItemAfastar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnImprimir As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItemNovaConta As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItemEditarConta As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItemExcluirConta As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Public WithEvents btnNovaCategoria As DevComponents.DotNetBar.ButtonItem
    Public WithEvents btnEditarCat As DevComponents.DotNetBar.ButtonItem
    Public WithEvents btnExcluirCat As DevComponents.DotNetBar.ButtonItem
    Public WithEvents btnClientes As DevComponents.DotNetBar.ButtonItem
    Public WithEvents btnFornecedores As DevComponents.DotNetBar.ButtonItem
    Public WithEvents btnColaboradores As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnNovo As DevComponents.DotNetBar.ButtonItem
    Public WithEvents btnEditar As DevComponents.DotNetBar.ButtonItem
    Public WithEvents btnExcluir As DevComponents.DotNetBar.ButtonItem
    Public WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonPanel8 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents rbtInicio As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents RibbonBar8 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents btnNovidades As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem8 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnLerCriterio As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnLimparCriterios As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents rbLoop As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents btnIniciarPesquisaLoop As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar10 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents btnExportar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ItemContainer1 As DevComponents.DotNetBar.ItemContainer
    Public WithEvents cbExportarTipo As DevComponents.DotNetBar.ComboBoxItem
    Friend WithEvents cbHTML As DevComponents.Editors.ComboItem
    Friend WithEvents cbXLX As DevComponents.Editors.ComboItem
    Friend WithEvents cbXLS As DevComponents.Editors.ComboItem
    Friend WithEvents cbXML As DevComponents.Editors.ComboItem
    Friend WithEvents cbRTF As DevComponents.Editors.ComboItem
    Friend WithEvents cbPDF As DevComponents.Editors.ComboItem
    Friend WithEvents cbMHT As DevComponents.Editors.ComboItem
    Friend WithEvents cbTXT As DevComponents.Editors.ComboItem
    Friend WithEvents ControlContainerItem1 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents rbbOpcoes As DevComponents.DotNetBar.RibbonBar
    Public WithEvents ComboBoxItem1 As DevComponents.DotNetBar.ComboBoxItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem9 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem10 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem11 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem12 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem13 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem14 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem15 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem16 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem17 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem18 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem19 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem20 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem21 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem22 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem23 As DevComponents.Editors.ComboItem
    Friend WithEvents ItemContainer2 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents ItemContainer4 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer6 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents teHoraFim As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents dtpDataFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelItem4 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents ItemContainer8 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ControlContainerItem6 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents ControlContainerItem8 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents ItemContainer7 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents dtpDataInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents teHoraInicio As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents ControlContainerItem4 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents ControlContainerItem3 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents CheckBoxItem1 As DevComponents.DotNetBar.CheckBoxItem
    Friend WithEvents ItemContainer12 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents chkMostrarPainel As DevComponents.DotNetBar.CheckBoxItem
    Friend WithEvents txtApartirDe As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ItemContainer13 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents LabelItem2 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents ControlContainerItem9 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents txtLimite As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents chkLimite As DevComponents.DotNetBar.CheckBoxItem
    Friend WithEvents ControlContainerItem7 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents cbOrdenar As System.Windows.Forms.ComboBox
    Friend WithEvents ControlContainerItem5 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents ControlContainerItem2 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents ControlContainerItem11 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents LabelItem3 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents LabelItem5 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents btnLimparGrade As DevComponents.DotNetBar.ButtonItem
    Public WithEvents pb1 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents Office2007StartButton1 As DevComponents.DotNetBar.Office2007StartButton
    Friend WithEvents ItemContainer11 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer14 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer15 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ButtonItem10 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem11 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem12 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem13 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem14 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem15 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents GalleryContainer1 As DevComponents.DotNetBar.GalleryContainer
    Friend WithEvents labelItem8 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents ButtonItem16 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem17 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem18 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem19 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ItemContainer16 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ButtonItem20 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem21 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem9 As DevComponents.DotNetBar.ButtonItem
    Public WithEvents ButtonItem6 As DevComponents.DotNetBar.ButtonItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal2))
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.barStatus = New DevComponents.DotNetBar.Bar()
        Me.lblMensRegistros = New DevComponents.DotNetBar.LabelItem()
        Me.ItemContainerPrincipal = New DevComponents.DotNetBar.ItemContainer()
        Me.labelStatus = New DevComponents.DotNetBar.LabelItem()
        Me.lblUsuario = New DevComponents.DotNetBar.LabelItem()
        Me.ribbonControl1 = New DevComponents.DotNetBar.RibbonControl()
        Me.RibbonPanel8 = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonBar8 = New DevComponents.DotNetBar.RibbonBar()
        Me.btnNovidades = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonPanel3 = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonBar13 = New DevComponents.DotNetBar.RibbonBar()
        Me.RibbonBar12 = New DevComponents.DotNetBar.RibbonBar()
        Me.RibbonBar11 = New DevComponents.DotNetBar.RibbonBar()
        Me.RibbonPanel7 = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonPanel2 = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonBar4 = New DevComponents.DotNetBar.RibbonBar()
        Me.btnDepositar = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemPagar = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemTransferir = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemReconciliar = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonPanel5 = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonBar7 = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar5 = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonPanel4 = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonBar6 = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem7 = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar1 = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem4 = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonPanel1 = New DevComponents.DotNetBar.RibbonPanel()
        Me.rbbOpcoes = New DevComponents.DotNetBar.RibbonBar()
        Me.ItemContainer12 = New DevComponents.DotNetBar.ItemContainer()
        Me.chkMostrarPainel = New DevComponents.DotNetBar.CheckBoxItem()
        Me.btnLimparGrade = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar10 = New DevComponents.DotNetBar.RibbonBar()
        Me.ItemContainer1 = New DevComponents.DotNetBar.ItemContainer()
        Me.btnExportar = New DevComponents.DotNetBar.ButtonItem()
        Me.cbExportarTipo = New DevComponents.DotNetBar.ComboBoxItem()
        Me.cbHTML = New DevComponents.Editors.ComboItem()
        Me.cbXML = New DevComponents.Editors.ComboItem()
        Me.cbXLX = New DevComponents.Editors.ComboItem()
        Me.cbXLS = New DevComponents.Editors.ComboItem()
        Me.cbRTF = New DevComponents.Editors.ComboItem()
        Me.cbPDF = New DevComponents.Editors.ComboItem()
        Me.cbMHT = New DevComponents.Editors.ComboItem()
        Me.cbTXT = New DevComponents.Editors.ComboItem()
        Me.rbLoop = New DevComponents.DotNetBar.RibbonBar()
        Me.txtApartirDe = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnIniciarPesquisaLoop = New DevComponents.DotNetBar.ButtonItem()
        Me.ItemContainer13 = New DevComponents.DotNetBar.ItemContainer()
        Me.LabelItem2 = New DevComponents.DotNetBar.LabelItem()
        Me.ControlContainerItem9 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.RibbonBar3 = New DevComponents.DotNetBar.RibbonBar()
        Me.btnLimparCriterios = New DevComponents.DotNetBar.ButtonItem()
        Me.btnGravarCriterio = New DevComponents.DotNetBar.ButtonItem()
        Me.btnLerCriterio = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar2 = New DevComponents.DotNetBar.RibbonBar()
        Me.dtpDataInicio = New System.Windows.Forms.DateTimePicker()
        Me.teHoraInicio = New DevExpress.XtraEditors.TimeEdit()
        Me.cbOrdenar = New System.Windows.Forms.ComboBox()
        Me.dtpDataFim = New System.Windows.Forms.DateTimePicker()
        Me.teHoraFim = New DevExpress.XtraEditors.TimeEdit()
        Me.txtLimite = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnProcessar = New DevComponents.DotNetBar.ButtonItem()
        Me.ItemContainer2 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer4 = New DevComponents.DotNetBar.ItemContainer()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.ControlContainerItem5 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.ControlContainerItem2 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.LabelItem3 = New DevComponents.DotNetBar.LabelItem()
        Me.ControlContainerItem11 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.ItemContainer6 = New DevComponents.DotNetBar.ItemContainer()
        Me.LabelItem4 = New DevComponents.DotNetBar.LabelItem()
        Me.ControlContainerItem4 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.ControlContainerItem3 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.LabelItem5 = New DevComponents.DotNetBar.LabelItem()
        Me.chkLimite = New DevComponents.DotNetBar.CheckBoxItem()
        Me.ControlContainerItem7 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.ButtonItem6 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.btnExcluir = New DevComponents.DotNetBar.ButtonItem()
        Me.btnEditar = New DevComponents.DotNetBar.ButtonItem()
        Me.btnNovo = New DevComponents.DotNetBar.ButtonItem()
        Me.btnColaboradores = New DevComponents.DotNetBar.ButtonItem()
        Me.btnFornecedores = New DevComponents.DotNetBar.ButtonItem()
        Me.btnClientes = New DevComponents.DotNetBar.ButtonItem()
        Me.btnExcluirCat = New DevComponents.DotNetBar.ButtonItem()
        Me.btnEditarCat = New DevComponents.DotNetBar.ButtonItem()
        Me.btnNovaCategoria = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemExcluirConta = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemEditarConta = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemNovaConta = New DevComponents.DotNetBar.ButtonItem()
        Me.btnImprimir = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemAfastar = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemAproximar = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemFavoritos = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem8 = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonPanel6 = New DevComponents.DotNetBar.RibbonPanel()
        Me.rbtInicio = New DevComponents.DotNetBar.RibbonTabItem()
        Me.rbtPesquisaCDRs = New DevComponents.DotNetBar.RibbonTabItem()
        Me.rbtResumoDiario = New DevComponents.DotNetBar.RibbonTabItem()
        Me.rbtHistorico = New DevComponents.DotNetBar.RibbonTabItem()
        Me.RibbonTabItemLancamentos = New DevComponents.DotNetBar.RibbonTabItem()
        Me.RibbonTabItemProgramacao = New DevComponents.DotNetBar.RibbonTabItem()
        Me.RibbonTabItemPesquisa = New DevComponents.DotNetBar.RibbonTabItem()
        Me.buttonChangeStyle = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonStyleOffice2007Blue = New DevComponents.DotNetBar.ButtonItem()
        Me.AppCommandTheme = New DevComponents.DotNetBar.Command(Me.components)
        Me.buttonStyleOffice2007Black = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonStyleOffice2007Silver = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonStyleCustom = New DevComponents.DotNetBar.ColorPickerDropDown()
        Me.ButtonFile = New DevComponents.DotNetBar.Office2007StartButton()
        Me.menuFileContainer = New DevComponents.DotNetBar.ItemContainer()
        Me.menuFileTwoColumnContainer = New DevComponents.DotNetBar.ItemContainer()
        Me.menuFileItems = New DevComponents.DotNetBar.ItemContainer()
        Me.btnMenuPesquisaCDRs = New DevComponents.DotNetBar.ButtonItem()
        Me.btnMenuResumoDiario = New DevComponents.DotNetBar.ButtonItem()
        Me.btnMenuConsultarHistorico = New DevComponents.DotNetBar.ButtonItem()
        Me.btnMenuGerarHistorico = New DevComponents.DotNetBar.ButtonItem()
        Me.btnMenuSair = New DevComponents.DotNetBar.ButtonItem()
        Me.Office2007StartButton1 = New DevComponents.DotNetBar.Office2007StartButton()
        Me.ItemContainer11 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer14 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer15 = New DevComponents.DotNetBar.ItemContainer()
        Me.ButtonItem10 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem11 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem12 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem13 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem14 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem15 = New DevComponents.DotNetBar.ButtonItem()
        Me.GalleryContainer1 = New DevComponents.DotNetBar.GalleryContainer()
        Me.labelItem8 = New DevComponents.DotNetBar.LabelItem()
        Me.ButtonItem16 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem17 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem18 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem19 = New DevComponents.DotNetBar.ButtonItem()
        Me.ItemContainer16 = New DevComponents.DotNetBar.ItemContainer()
        Me.ButtonItem20 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem21 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem9 = New DevComponents.DotNetBar.ButtonItem()
        Me.QatCustomizeItem1 = New DevComponents.DotNetBar.QatCustomizeItem()
        Me.ItemContainer7 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer8 = New DevComponents.DotNetBar.ItemContainer()
        Me.ControlContainerItem6 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.ControlContainerItem8 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.HTML = New DevComponents.Editors.ComboItem()
        Me.XML = New DevComponents.Editors.ComboItem()
        Me.XLX = New DevComponents.Editors.ComboItem()
        Me.XLS = New DevComponents.Editors.ComboItem()
        Me.RTF = New DevComponents.Editors.ComboItem()
        Me.PDF = New DevComponents.Editors.ComboItem()
        Me.MHT = New DevComponents.Editors.ComboItem()
        Me.TXT = New DevComponents.Editors.ComboItem()
        Me.ItemContainer9 = New DevComponents.DotNetBar.ItemContainer()
        Me.btnPrimeiraPag = New DevComponents.DotNetBar.ButtonItem()
        Me.btnPagAnterior = New DevComponents.DotNetBar.ButtonItem()
        Me.btnProximaPag = New DevComponents.DotNetBar.ButtonItem()
        Me.btnUltimaPag = New DevComponents.DotNetBar.ButtonItem()
        Me.ItemContainer10 = New DevComponents.DotNetBar.ItemContainer()
        Me.chkBarra = New DevComponents.DotNetBar.CheckBoxItem()
        Me.chkPainelLateral = New DevComponents.DotNetBar.CheckBoxItem()
        Me.ItemContainer3 = New DevComponents.DotNetBar.ItemContainer()
        Me.ButtonItemAgrupamento = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemEscolherColunas = New DevComponents.DotNetBar.ButtonItem()
        Me.ItemContainer5 = New DevComponents.DotNetBar.ItemContainer()
        Me.CheckBoxItem2 = New DevComponents.DotNetBar.CheckBoxItem()
        Me.CheckBoxItem3 = New DevComponents.DotNetBar.CheckBoxItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ControlContainerItem1 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.ComboBoxItem1 = New DevComponents.DotNetBar.ComboBoxItem()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.ComboItem9 = New DevComponents.Editors.ComboItem()
        Me.ComboItem10 = New DevComponents.Editors.ComboItem()
        Me.ComboItem11 = New DevComponents.Editors.ComboItem()
        Me.ComboItem12 = New DevComponents.Editors.ComboItem()
        Me.ComboItem13 = New DevComponents.Editors.ComboItem()
        Me.ComboItem14 = New DevComponents.Editors.ComboItem()
        Me.ComboItem15 = New DevComponents.Editors.ComboItem()
        Me.ComboItem16 = New DevComponents.Editors.ComboItem()
        Me.ComboItem17 = New DevComponents.Editors.ComboItem()
        Me.ComboItem18 = New DevComponents.Editors.ComboItem()
        Me.ComboItem19 = New DevComponents.Editors.ComboItem()
        Me.ComboItem20 = New DevComponents.Editors.ComboItem()
        Me.ComboItem21 = New DevComponents.Editors.ComboItem()
        Me.ComboItem22 = New DevComponents.Editors.ComboItem()
        Me.ComboItem23 = New DevComponents.Editors.ComboItem()
        Me.CheckBoxItem1 = New DevComponents.DotNetBar.CheckBoxItem()
        Me.pb1 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        CType(Me.barStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ribbonControl1.SuspendLayout()
        Me.RibbonPanel8.SuspendLayout()
        Me.RibbonPanel3.SuspendLayout()
        Me.RibbonPanel2.SuspendLayout()
        Me.RibbonPanel5.SuspendLayout()
        Me.RibbonPanel4.SuspendLayout()
        Me.RibbonPanel1.SuspendLayout()
        Me.rbLoop.SuspendLayout()
        Me.RibbonBar2.SuspendLayout()
        CType(Me.teHoraInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teHoraFim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
        Me.imageList1.Images.SetKeyName(0, "")
        Me.imageList1.Images.SetKeyName(1, "")
        Me.imageList1.Images.SetKeyName(2, "")
        Me.imageList1.Images.SetKeyName(3, "")
        Me.imageList1.Images.SetKeyName(4, "")
        Me.imageList1.Images.SetKeyName(5, "")
        Me.imageList1.Images.SetKeyName(6, "")
        Me.imageList1.Images.SetKeyName(7, "")
        Me.imageList1.Images.SetKeyName(8, "")
        Me.imageList1.Images.SetKeyName(9, "")
        Me.imageList1.Images.SetKeyName(10, "")
        Me.imageList1.Images.SetKeyName(11, "")
        Me.imageList1.Images.SetKeyName(12, "")
        Me.imageList1.Images.SetKeyName(13, "")
        Me.imageList1.Images.SetKeyName(14, "")
        Me.imageList1.Images.SetKeyName(15, "")
        Me.imageList1.Images.SetKeyName(16, "")
        Me.imageList1.Images.SetKeyName(17, "")
        Me.imageList1.Images.SetKeyName(18, "")
        Me.imageList1.Images.SetKeyName(19, "")
        Me.imageList1.Images.SetKeyName(20, "")
        Me.imageList1.Images.SetKeyName(21, "")
        Me.imageList1.Images.SetKeyName(22, "")
        Me.imageList1.Images.SetKeyName(23, "")
        '
        'barStatus
        '
        Me.barStatus.AccessibleDescription = "DotNetBar Bar (barStatus)"
        Me.barStatus.AccessibleName = "DotNetBar Bar"
        Me.barStatus.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar
        Me.barStatus.AntiAlias = True
        Me.barStatus.BarType = DevComponents.DotNetBar.eBarType.StatusBar
        Me.barStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barStatus.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.ResizeHandle
        Me.barStatus.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.lblMensRegistros, Me.ItemContainerPrincipal, Me.labelStatus, Me.lblUsuario})
        Me.barStatus.ItemSpacing = 2
        Me.barStatus.Location = New System.Drawing.Point(0, 530)
        Me.barStatus.Name = "barStatus"
        Me.barStatus.Size = New System.Drawing.Size(1063, 27)
        Me.barStatus.Stretch = True
        Me.barStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.barStatus.TabIndex = 9
        Me.barStatus.TabStop = False
        '
        'lblMensRegistros
        '
        Me.lblMensRegistros.Name = "lblMensRegistros"
        '
        'ItemContainerPrincipal
        '
        '
        '
        '
        Me.ItemContainerPrincipal.BackgroundStyle.Class = "Office2007StatusBarBackground2"
        Me.ItemContainerPrincipal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainerPrincipal.Name = "ItemContainerPrincipal"
        '
        'labelStatus
        '
        Me.labelStatus.Name = "labelStatus"
        Me.labelStatus.PaddingLeft = 2
        Me.labelStatus.PaddingRight = 2
        Me.labelStatus.SingleLineColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.labelStatus.Stretch = True
        '
        'lblUsuario
        '
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Text = "                  "
        '
        'ribbonControl1
        '
        Me.ribbonControl1.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.ribbonControl1.BackgroundStyle.Class = ""
        Me.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ribbonControl1.Controls.Add(Me.RibbonPanel8)
        Me.ribbonControl1.Controls.Add(Me.RibbonPanel3)
        Me.ribbonControl1.Controls.Add(Me.RibbonPanel7)
        Me.ribbonControl1.Controls.Add(Me.RibbonPanel2)
        Me.ribbonControl1.Controls.Add(Me.RibbonPanel5)
        Me.ribbonControl1.Controls.Add(Me.RibbonPanel4)
        Me.ribbonControl1.Controls.Add(Me.RibbonPanel1)
        Me.ribbonControl1.Controls.Add(Me.RibbonPanel6)
        Me.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ribbonControl1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.rbtInicio, Me.rbtPesquisaCDRs, Me.rbtResumoDiario, Me.rbtHistorico, Me.RibbonTabItemLancamentos, Me.RibbonTabItemProgramacao, Me.RibbonTabItemPesquisa, Me.buttonChangeStyle})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black
        Me.ribbonControl1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.ribbonControl1.QuickToolbarItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonFile, Me.Office2007StartButton1, Me.ButtonItem9, Me.QatCustomizeItem1})
        Me.ribbonControl1.Size = New System.Drawing.Size(1063, 131)
        Me.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ribbonControl1.SystemText.MaximizeRibbonText = "&Mostrar ícones do menu"
        Me.ribbonControl1.SystemText.MinimizeRibbonText = "Esconder ícones do menu"
        Me.ribbonControl1.SystemText.QatAddItemText = "&Adicionar a Barra de Acesso Rápido"
        Me.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Personalizador da Barra de Acesso Rápido</b>"
        Me.ribbonControl1.SystemText.QatCustomizeText = "&Personalizar a Barra de Acesso Rápido..."
        Me.ribbonControl1.SystemText.QatDialogAddButton = "&Adicionar >>"
        Me.ribbonControl1.SystemText.QatDialogCancelButton = "Cancelar"
        Me.ribbonControl1.SystemText.QatDialogCaption = "Personalizador da Barra de Acesso Rápido"
        Me.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Escolher os comandos de:"
        Me.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Coloca a Barra de Acesso Rápido Abaixo"
        Me.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remover"
        Me.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Coloca a Barra de Acesso Rápido Acima do Menu"
        Me.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Coloca a Barra de Acesso Rápido Abaixo do Menu"
        Me.ribbonControl1.SystemText.QatRemoveItemText = "&Remover da Barra de Acesso Rápido"
        Me.ribbonControl1.TabGroupHeight = 14
        Me.ribbonControl1.TabIndex = 0
        Me.ribbonControl1.Text = "gf"
        Me.ribbonControl1.TitleText = "SpyCdr - Investigador de bilhetes (CDRs)"
        '
        'RibbonPanel8
        '
        Me.RibbonPanel8.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel8.Controls.Add(Me.RibbonBar8)
        Me.RibbonPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel8.Location = New System.Drawing.Point(0, 26)
        Me.RibbonPanel8.Name = "RibbonPanel8"
        Me.RibbonPanel8.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel8.Size = New System.Drawing.Size(1063, 103)
        '
        '
        '
        Me.RibbonPanel8.Style.Class = ""
        Me.RibbonPanel8.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel8.StyleMouseDown.Class = ""
        Me.RibbonPanel8.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel8.StyleMouseOver.Class = ""
        Me.RibbonPanel8.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel8.TabIndex = 16
        '
        'RibbonBar8
        '
        Me.RibbonBar8.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar8.BackgroundMouseOverStyle.Class = ""
        Me.RibbonBar8.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar8.BackgroundStyle.Class = ""
        Me.RibbonBar8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar8.ContainerControlProcessDialogKey = True
        Me.RibbonBar8.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar8.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnNovidades})
        Me.RibbonBar8.Location = New System.Drawing.Point(3, 0)
        Me.RibbonBar8.Name = "RibbonBar8"
        Me.RibbonBar8.Size = New System.Drawing.Size(157, 100)
        Me.RibbonBar8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar8.TabIndex = 2
        Me.RibbonBar8.Text = "Opções"
        '
        '
        '
        Me.RibbonBar8.TitleStyle.Class = ""
        Me.RibbonBar8.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar8.TitleStyleMouseOver.Class = ""
        Me.RibbonBar8.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'btnNovidades
        '
        Me.btnNovidades.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnNovidades.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_04
        Me.btnNovidades.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnNovidades.Name = "btnNovidades"
        Me.btnNovidades.ShowSubItems = False
        Me.btnNovidades.Text = "Novidades"
        '
        'RibbonPanel3
        '
        Me.RibbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel3.Controls.Add(Me.RibbonBar13)
        Me.RibbonPanel3.Controls.Add(Me.RibbonBar12)
        Me.RibbonPanel3.Controls.Add(Me.RibbonBar11)
        Me.RibbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel3.Location = New System.Drawing.Point(0, 26)
        Me.RibbonPanel3.Name = "RibbonPanel3"
        Me.RibbonPanel3.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel3.Size = New System.Drawing.Size(1063, 103)
        '
        '
        '
        Me.RibbonPanel3.Style.Class = ""
        Me.RibbonPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel3.StyleMouseDown.Class = ""
        Me.RibbonPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel3.StyleMouseOver.Class = ""
        Me.RibbonPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel3.TabIndex = 8
        Me.RibbonPanel3.Visible = False
        '
        'RibbonBar13
        '
        Me.RibbonBar13.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar13.BackgroundMouseOverStyle.Class = ""
        Me.RibbonBar13.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar13.BackgroundStyle.Class = ""
        Me.RibbonBar13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar13.ContainerControlProcessDialogKey = True
        Me.RibbonBar13.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar13.Location = New System.Drawing.Point(333, 0)
        Me.RibbonBar13.Name = "RibbonBar13"
        Me.RibbonBar13.Size = New System.Drawing.Size(297, 100)
        Me.RibbonBar13.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar13.TabIndex = 2
        Me.RibbonBar13.Text = "Mostrar"
        '
        '
        '
        Me.RibbonBar13.TitleStyle.Class = ""
        Me.RibbonBar13.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar13.TitleStyleMouseOver.Class = ""
        Me.RibbonBar13.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'RibbonBar12
        '
        Me.RibbonBar12.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar12.BackgroundMouseOverStyle.Class = ""
        Me.RibbonBar12.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar12.BackgroundStyle.Class = ""
        Me.RibbonBar12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar12.ContainerControlProcessDialogKey = True
        Me.RibbonBar12.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar12.Location = New System.Drawing.Point(190, 0)
        Me.RibbonBar12.Name = "RibbonBar12"
        Me.RibbonBar12.Size = New System.Drawing.Size(143, 100)
        Me.RibbonBar12.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar12.TabIndex = 1
        Me.RibbonBar12.Text = "Exibir"
        '
        '
        '
        Me.RibbonBar12.TitleStyle.Class = ""
        Me.RibbonBar12.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar12.TitleStyleMouseOver.Class = ""
        Me.RibbonBar12.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'RibbonBar11
        '
        Me.RibbonBar11.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar11.BackgroundMouseOverStyle.Class = ""
        Me.RibbonBar11.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar11.BackgroundStyle.Class = ""
        Me.RibbonBar11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar11.ContainerControlProcessDialogKey = True
        Me.RibbonBar11.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar11.Location = New System.Drawing.Point(3, 0)
        Me.RibbonBar11.Name = "RibbonBar11"
        Me.RibbonBar11.Size = New System.Drawing.Size(187, 100)
        Me.RibbonBar11.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar11.TabIndex = 0
        Me.RibbonBar11.Text = "Contas a Receber"
        '
        '
        '
        Me.RibbonBar11.TitleStyle.Class = ""
        Me.RibbonBar11.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar11.TitleStyleMouseOver.Class = ""
        Me.RibbonBar11.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'RibbonPanel7
        '
        Me.RibbonPanel7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel7.Location = New System.Drawing.Point(0, 26)
        Me.RibbonPanel7.Name = "RibbonPanel7"
        Me.RibbonPanel7.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel7.Size = New System.Drawing.Size(1063, 103)
        '
        '
        '
        Me.RibbonPanel7.Style.Class = ""
        Me.RibbonPanel7.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel7.StyleMouseDown.Class = ""
        Me.RibbonPanel7.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel7.StyleMouseOver.Class = ""
        Me.RibbonPanel7.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel7.TabIndex = 12
        Me.RibbonPanel7.Visible = False
        '
        'RibbonPanel2
        '
        Me.RibbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel2.Controls.Add(Me.RibbonBar4)
        Me.RibbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel2.Location = New System.Drawing.Point(0, 26)
        Me.RibbonPanel2.Name = "RibbonPanel2"
        Me.RibbonPanel2.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel2.Size = New System.Drawing.Size(1063, 103)
        '
        '
        '
        Me.RibbonPanel2.Style.Class = ""
        Me.RibbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel2.StyleMouseDown.Class = ""
        Me.RibbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel2.StyleMouseOver.Class = ""
        Me.RibbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel2.TabIndex = 7
        Me.RibbonPanel2.Visible = False
        '
        'RibbonBar4
        '
        Me.RibbonBar4.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar4.BackgroundMouseOverStyle.Class = ""
        Me.RibbonBar4.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar4.BackgroundStyle.Class = ""
        Me.RibbonBar4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar4.ContainerControlProcessDialogKey = True
        Me.RibbonBar4.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar4.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnDepositar, Me.ButtonItemPagar, Me.ButtonItemTransferir, Me.ButtonItemReconciliar})
        Me.RibbonBar4.Location = New System.Drawing.Point(3, 0)
        Me.RibbonBar4.Name = "RibbonBar4"
        Me.RibbonBar4.Size = New System.Drawing.Size(245, 100)
        Me.RibbonBar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar4.TabIndex = 0
        Me.RibbonBar4.Text = "Lançamentos"
        '
        '
        '
        Me.RibbonBar4.TitleStyle.Class = ""
        Me.RibbonBar4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar4.TitleStyleMouseOver.Class = ""
        Me.RibbonBar4.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'btnDepositar
        '
        Me.btnDepositar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnDepositar.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_11
        Me.btnDepositar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnDepositar.Name = "btnDepositar"
        Me.btnDepositar.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2)
        Me.btnDepositar.Text = "Depositar"
        Me.btnDepositar.Tooltip = "Depositar <CTRL + D>"
        '
        'ButtonItemPagar
        '
        Me.ButtonItemPagar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemPagar.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_04
        Me.ButtonItemPagar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItemPagar.Name = "ButtonItemPagar"
        Me.ButtonItemPagar.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlP)
        Me.ButtonItemPagar.Text = "Pagar"
        Me.ButtonItemPagar.Tooltip = "Cadastrar novo pagamento <ctrl> P"
        '
        'ButtonItemTransferir
        '
        Me.ButtonItemTransferir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemTransferir.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_14
        Me.ButtonItemTransferir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItemTransferir.Name = "ButtonItemTransferir"
        Me.ButtonItemTransferir.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2)
        Me.ButtonItemTransferir.Text = "Transferir"
        Me.ButtonItemTransferir.Tooltip = "Cadastrar nova caategoria"
        '
        'ButtonItemReconciliar
        '
        Me.ButtonItemReconciliar.BeginGroup = True
        Me.ButtonItemReconciliar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemReconciliar.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_07
        Me.ButtonItemReconciliar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItemReconciliar.Name = "ButtonItemReconciliar"
        Me.ButtonItemReconciliar.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2)
        Me.ButtonItemReconciliar.Text = "Reconciliar"
        '
        'RibbonPanel5
        '
        Me.RibbonPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel5.Controls.Add(Me.RibbonBar7)
        Me.RibbonPanel5.Controls.Add(Me.RibbonBar5)
        Me.RibbonPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel5.Location = New System.Drawing.Point(0, 26)
        Me.RibbonPanel5.Name = "RibbonPanel5"
        Me.RibbonPanel5.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel5.Size = New System.Drawing.Size(1063, 103)
        '
        '
        '
        Me.RibbonPanel5.Style.Class = ""
        Me.RibbonPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel5.StyleMouseDown.Class = ""
        Me.RibbonPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel5.StyleMouseOver.Class = ""
        Me.RibbonPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel5.TabIndex = 14
        Me.RibbonPanel5.Visible = False
        '
        'RibbonBar7
        '
        Me.RibbonBar7.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar7.BackgroundMouseOverStyle.Class = ""
        Me.RibbonBar7.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar7.BackgroundStyle.Class = ""
        Me.RibbonBar7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar7.ContainerControlProcessDialogKey = True
        Me.RibbonBar7.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar7.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem3})
        Me.RibbonBar7.Location = New System.Drawing.Point(73, 0)
        Me.RibbonBar7.Name = "RibbonBar7"
        Me.RibbonBar7.Size = New System.Drawing.Size(262, 100)
        Me.RibbonBar7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar7.TabIndex = 2
        Me.RibbonBar7.Text = "Opções"
        '
        '
        '
        Me.RibbonBar7.TitleStyle.Class = ""
        Me.RibbonBar7.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar7.TitleStyleMouseOver.Class = ""
        Me.RibbonBar7.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem3
        '
        Me.ButtonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem3.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_03
        Me.ButtonItem3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.Text = "Recibos"
        '
        'RibbonBar5
        '
        Me.RibbonBar5.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar5.BackgroundMouseOverStyle.Class = ""
        Me.RibbonBar5.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar5.BackgroundStyle.Class = ""
        Me.RibbonBar5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar5.ContainerControlProcessDialogKey = True
        Me.RibbonBar5.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar5.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem5})
        Me.RibbonBar5.Location = New System.Drawing.Point(3, 0)
        Me.RibbonBar5.Name = "RibbonBar5"
        Me.RibbonBar5.Size = New System.Drawing.Size(70, 100)
        Me.RibbonBar5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar5.TabIndex = 1
        Me.RibbonBar5.Text = "Consulta"
        '
        '
        '
        Me.RibbonBar5.TitleStyle.Class = ""
        Me.RibbonBar5.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar5.TitleStyleMouseOver.Class = ""
        Me.RibbonBar5.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem5
        '
        Me.ButtonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem5.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_68
        Me.ButtonItem5.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem5.Name = "ButtonItem5"
        Me.ButtonItem5.SubItemsExpandWidth = 14
        Me.ButtonItem5.Text = "Histórico"
        Me.ButtonItem5.Tooltip = "Acesso ao histórico das estatísticas pre-processadas. Por ano. mês ou dia."
        '
        'RibbonPanel4
        '
        Me.RibbonPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel4.Controls.Add(Me.RibbonBar6)
        Me.RibbonPanel4.Controls.Add(Me.RibbonBar1)
        Me.RibbonPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel4.Location = New System.Drawing.Point(0, 26)
        Me.RibbonPanel4.Name = "RibbonPanel4"
        Me.RibbonPanel4.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel4.Size = New System.Drawing.Size(1063, 103)
        '
        '
        '
        Me.RibbonPanel4.Style.Class = ""
        Me.RibbonPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel4.StyleMouseDown.Class = ""
        Me.RibbonPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel4.StyleMouseOver.Class = ""
        Me.RibbonPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel4.TabIndex = 13
        Me.RibbonPanel4.Visible = False
        '
        'RibbonBar6
        '
        Me.RibbonBar6.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar6.BackgroundMouseOverStyle.Class = ""
        Me.RibbonBar6.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar6.BackgroundStyle.Class = ""
        Me.RibbonBar6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar6.ContainerControlProcessDialogKey = True
        Me.RibbonBar6.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar6.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem7})
        Me.RibbonBar6.Location = New System.Drawing.Point(67, 0)
        Me.RibbonBar6.Name = "RibbonBar6"
        Me.RibbonBar6.Size = New System.Drawing.Size(262, 100)
        Me.RibbonBar6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar6.TabIndex = 2
        Me.RibbonBar6.Text = "Opções"
        '
        '
        '
        Me.RibbonBar6.TitleStyle.Class = ""
        Me.RibbonBar6.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar6.TitleStyleMouseOver.Class = ""
        Me.RibbonBar6.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem7
        '
        Me.ButtonItem7.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem7.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_03
        Me.ButtonItem7.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem7.Name = "ButtonItem7"
        Me.ButtonItem7.Text = "Recibos"
        '
        'RibbonBar1
        '
        Me.RibbonBar1.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar1.BackgroundMouseOverStyle.Class = ""
        Me.RibbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar1.BackgroundStyle.Class = ""
        Me.RibbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar1.ContainerControlProcessDialogKey = True
        Me.RibbonBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem4})
        Me.RibbonBar1.Location = New System.Drawing.Point(3, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Size = New System.Drawing.Size(64, 100)
        Me.RibbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar1.TabIndex = 1
        Me.RibbonBar1.Text = "Consulta"
        '
        '
        '
        Me.RibbonBar1.TitleStyle.Class = ""
        Me.RibbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar1.TitleStyleMouseOver.Class = ""
        Me.RibbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem4
        '
        Me.ButtonItem4.BeginGroup = True
        Me.ButtonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem4.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_15
        Me.ButtonItem4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem4.Name = "ButtonItem4"
        Me.ButtonItem4.SubItemsExpandWidth = 14
        Me.ButtonItem4.Text = "Resumo Diário"
        Me.ButtonItem4.Tooltip = "Acesso ao resumo diário das estatísticas pre-processadas. Por rota, cliente, núme" & _
            "ro, etc..."
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel1.Controls.Add(Me.rbbOpcoes)
        Me.RibbonPanel1.Controls.Add(Me.RibbonBar10)
        Me.RibbonPanel1.Controls.Add(Me.rbLoop)
        Me.RibbonPanel1.Controls.Add(Me.RibbonBar3)
        Me.RibbonPanel1.Controls.Add(Me.RibbonBar2)
        Me.RibbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel1.Location = New System.Drawing.Point(0, 26)
        Me.RibbonPanel1.Name = "RibbonPanel1"
        Me.RibbonPanel1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel1.Size = New System.Drawing.Size(1063, 103)
        '
        '
        '
        Me.RibbonPanel1.Style.Class = ""
        Me.RibbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel1.StyleMouseDown.Class = ""
        Me.RibbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel1.StyleMouseOver.Class = ""
        Me.RibbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel1.TabIndex = 6
        Me.RibbonPanel1.Visible = False
        '
        'rbbOpcoes
        '
        Me.rbbOpcoes.AutoOverflowEnabled = True
        '
        '
        '
        Me.rbbOpcoes.BackgroundMouseOverStyle.Class = ""
        Me.rbbOpcoes.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbbOpcoes.BackgroundStyle.Class = ""
        Me.rbbOpcoes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbbOpcoes.ContainerControlProcessDialogKey = True
        Me.rbbOpcoes.Dock = System.Windows.Forms.DockStyle.Left
        Me.rbbOpcoes.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer12})
        Me.rbbOpcoes.Location = New System.Drawing.Point(886, 0)
        Me.rbbOpcoes.Name = "rbbOpcoes"
        Me.rbbOpcoes.Size = New System.Drawing.Size(110, 100)
        Me.rbbOpcoes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rbbOpcoes.TabIndex = 4
        Me.rbbOpcoes.Text = "Opções"
        '
        '
        '
        Me.rbbOpcoes.TitleStyle.Class = ""
        Me.rbbOpcoes.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbbOpcoes.TitleStyleMouseOver.Class = ""
        Me.rbbOpcoes.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ItemContainer12
        '
        '
        '
        '
        Me.ItemContainer12.BackgroundStyle.Class = ""
        Me.ItemContainer12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer12.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer12.Name = "ItemContainer12"
        Me.ItemContainer12.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.chkMostrarPainel, Me.btnLimparGrade})
        '
        'chkMostrarPainel
        '
        Me.chkMostrarPainel.Name = "chkMostrarPainel"
        Me.chkMostrarPainel.Text = "Mostrar Painel"
        '
        'btnLimparGrade
        '
        Me.btnLimparGrade.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnLimparGrade.Image = Global.SpyCdr.My.Resources.Resources.eraser
        Me.btnLimparGrade.Name = "btnLimparGrade"
        Me.btnLimparGrade.Text = "Limpar Grade"
        '
        'RibbonBar10
        '
        Me.RibbonBar10.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar10.BackgroundMouseOverStyle.Class = ""
        Me.RibbonBar10.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar10.BackgroundStyle.Class = ""
        Me.RibbonBar10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar10.ContainerControlProcessDialogKey = True
        Me.RibbonBar10.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar10.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer1})
        Me.RibbonBar10.Location = New System.Drawing.Point(745, 0)
        Me.RibbonBar10.Name = "RibbonBar10"
        Me.RibbonBar10.Size = New System.Drawing.Size(141, 100)
        Me.RibbonBar10.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar10.TabIndex = 3
        Me.RibbonBar10.Text = "Exportar"
        '
        '
        '
        Me.RibbonBar10.TitleStyle.Class = ""
        Me.RibbonBar10.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar10.TitleStyleMouseOver.Class = ""
        Me.RibbonBar10.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ItemContainer1
        '
        '
        '
        '
        Me.ItemContainer1.BackgroundStyle.Class = ""
        Me.ItemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer1.Name = "ItemContainer1"
        Me.ItemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnExportar, Me.cbExportarTipo})
        '
        'btnExportar
        '
        Me.btnExportar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnExportar.Image = Global.SpyCdr.My.Resources.Resources.ExportarExcel
        Me.btnExportar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Text = "Exportar para:"
        '
        'cbExportarTipo
        '
        Me.cbExportarTipo.Category = "para:"
        Me.cbExportarTipo.DropDownHeight = 106
        Me.cbExportarTipo.Items.AddRange(New Object() {Me.cbHTML, Me.cbXML, Me.cbXLX, Me.cbXLS, Me.cbRTF, Me.cbPDF, Me.cbMHT, Me.cbTXT})
        Me.cbExportarTipo.Name = "cbExportarTipo"
        Me.cbExportarTipo.Text = "XLX"
        '
        'cbHTML
        '
        Me.cbHTML.Text = "HTML"
        '
        'cbXML
        '
        Me.cbXML.Text = "XML"
        '
        'cbXLX
        '
        Me.cbXLX.Text = "XLX"
        '
        'cbXLS
        '
        Me.cbXLS.Text = "XLS"
        '
        'cbRTF
        '
        Me.cbRTF.Text = "RTF"
        '
        'cbPDF
        '
        Me.cbPDF.Text = "PDF"
        '
        'cbMHT
        '
        Me.cbMHT.Text = "MHT"
        '
        'cbTXT
        '
        Me.cbTXT.Text = "TXT"
        '
        'rbLoop
        '
        Me.rbLoop.AutoOverflowEnabled = True
        '
        '
        '
        Me.rbLoop.BackgroundMouseOverStyle.Class = ""
        Me.rbLoop.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbLoop.BackgroundStyle.Class = ""
        Me.rbLoop.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbLoop.ContainerControlProcessDialogKey = True
        Me.rbLoop.Controls.Add(Me.txtApartirDe)
        Me.rbLoop.Dock = System.Windows.Forms.DockStyle.Left
        Me.rbLoop.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnIniciarPesquisaLoop, Me.ItemContainer13})
        Me.rbLoop.Location = New System.Drawing.Point(557, 0)
        Me.rbLoop.Name = "rbLoop"
        Me.rbLoop.Size = New System.Drawing.Size(188, 100)
        Me.rbLoop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rbLoop.TabIndex = 2
        Me.rbLoop.Text = "Pesquisar Loop"
        '
        '
        '
        Me.rbLoop.TitleStyle.Class = ""
        Me.rbLoop.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbLoop.TitleStyleMouseOver.Class = ""
        Me.rbLoop.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'txtApartirDe
        '
        '
        '
        '
        Me.txtApartirDe.Border.Class = "TextBoxBorder"
        Me.txtApartirDe.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtApartirDe.Location = New System.Drawing.Point(115, 32)
        Me.txtApartirDe.Name = "txtApartirDe"
        Me.txtApartirDe.Size = New System.Drawing.Size(64, 21)
        Me.txtApartirDe.TabIndex = 11
        Me.txtApartirDe.Text = "0"
        Me.txtApartirDe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnIniciarPesquisaLoop
        '
        Me.btnIniciarPesquisaLoop.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnIniciarPesquisaLoop.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_67
        Me.btnIniciarPesquisaLoop.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnIniciarPesquisaLoop.Name = "btnIniciarPesquisaLoop"
        Me.btnIniciarPesquisaLoop.Text = "Procurar"
        '
        'ItemContainer13
        '
        '
        '
        '
        Me.ItemContainer13.BackgroundStyle.Class = ""
        Me.ItemContainer13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer13.Name = "ItemContainer13"
        Me.ItemContainer13.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.LabelItem2, Me.ControlContainerItem9})
        Me.ItemContainer13.Text = "A partir de:"
        Me.ItemContainer13.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle
        '
        'LabelItem2
        '
        Me.LabelItem2.Name = "LabelItem2"
        Me.LabelItem2.Text = "A partir de:"
        '
        'ControlContainerItem9
        '
        Me.ControlContainerItem9.AllowItemResize = False
        Me.ControlContainerItem9.Control = Me.txtApartirDe
        Me.ControlContainerItem9.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem9.Name = "ControlContainerItem9"
        '
        'RibbonBar3
        '
        Me.RibbonBar3.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar3.BackgroundMouseOverStyle.Class = ""
        Me.RibbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar3.BackgroundStyle.Class = ""
        Me.RibbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar3.ContainerControlProcessDialogKey = True
        Me.RibbonBar3.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar3.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnLimparCriterios, Me.btnGravarCriterio, Me.btnLerCriterio})
        Me.RibbonBar3.Location = New System.Drawing.Point(420, 0)
        Me.RibbonBar3.Name = "RibbonBar3"
        Me.RibbonBar3.Size = New System.Drawing.Size(137, 100)
        Me.RibbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar3.TabIndex = 1
        Me.RibbonBar3.Text = "Critérios"
        '
        '
        '
        Me.RibbonBar3.TitleStyle.Class = ""
        Me.RibbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar3.TitleStyleMouseOver.Class = ""
        Me.RibbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'btnLimparCriterios
        '
        Me.btnLimparCriterios.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnLimparCriterios.Image = Global.SpyCdr.My.Resources.Resources.eraser
        Me.btnLimparCriterios.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnLimparCriterios.Name = "btnLimparCriterios"
        Me.btnLimparCriterios.Text = "Limpar"
        '
        'btnGravarCriterio
        '
        Me.btnGravarCriterio.BeginGroup = True
        Me.btnGravarCriterio.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnGravarCriterio.Image = Global.SpyCdr.My.Resources.Resources.Floppy
        Me.btnGravarCriterio.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnGravarCriterio.Name = "btnGravarCriterio"
        Me.btnGravarCriterio.Text = "Gravar"
        '
        'btnLerCriterio
        '
        Me.btnLerCriterio.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnLerCriterio.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_14
        Me.btnLerCriterio.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnLerCriterio.Name = "btnLerCriterio"
        Me.btnLerCriterio.Text = "Ler"
        '
        'RibbonBar2
        '
        Me.RibbonBar2.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar2.BackgroundMouseOverStyle.Class = ""
        Me.RibbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar2.BackgroundStyle.Class = ""
        Me.RibbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar2.ContainerControlProcessDialogKey = True
        Me.RibbonBar2.Controls.Add(Me.dtpDataInicio)
        Me.RibbonBar2.Controls.Add(Me.teHoraInicio)
        Me.RibbonBar2.Controls.Add(Me.cbOrdenar)
        Me.RibbonBar2.Controls.Add(Me.dtpDataFim)
        Me.RibbonBar2.Controls.Add(Me.teHoraFim)
        Me.RibbonBar2.Controls.Add(Me.txtLimite)
        Me.RibbonBar2.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnProcessar, Me.ItemContainer2, Me.ButtonItem6, Me.ButtonItem2, Me.btnExcluir, Me.btnEditar, Me.btnNovo, Me.btnColaboradores, Me.btnFornecedores, Me.btnClientes, Me.btnExcluirCat, Me.btnEditarCat, Me.btnNovaCategoria, Me.ButtonItem1, Me.ButtonItemExcluirConta, Me.ButtonItemEditarConta, Me.ButtonItemNovaConta, Me.btnImprimir, Me.ButtonItemAfastar, Me.ButtonItemAproximar, Me.ButtonItemFavoritos, Me.ButtonItem8})
        Me.RibbonBar2.Location = New System.Drawing.Point(3, 0)
        Me.RibbonBar2.Name = "RibbonBar2"
        Me.RibbonBar2.Size = New System.Drawing.Size(417, 100)
        Me.RibbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar2.TabIndex = 0
        Me.RibbonBar2.Text = "Consultas"
        '
        '
        '
        Me.RibbonBar2.TitleStyle.Class = ""
        Me.RibbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar2.TitleStyleMouseOver.Class = ""
        Me.RibbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'dtpDataInicio
        '
        Me.dtpDataInicio.CustomFormat = "yyyy-MM-dd"
        Me.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDataInicio.Location = New System.Drawing.Point(96, 4)
        Me.dtpDataInicio.Name = "dtpDataInicio"
        Me.dtpDataInicio.Size = New System.Drawing.Size(81, 21)
        Me.dtpDataInicio.TabIndex = 115
        '
        'teHoraInicio
        '
        Me.teHoraInicio.EditValue = New Date(2011, 8, 31, 0, 0, 0, 0)
        Me.teHoraInicio.Location = New System.Drawing.Point(182, 4)
        Me.teHoraInicio.Name = "teHoraInicio"
        Me.teHoraInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.teHoraInicio.Size = New System.Drawing.Size(68, 20)
        Me.teHoraInicio.TabIndex = 114
        '
        'cbOrdenar
        '
        Me.cbOrdenar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbOrdenar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.cbOrdenar.FormattingEnabled = True
        Me.cbOrdenar.Items.AddRange(New Object() {"Sem Ordenação", "ASS_B, ASS_A, DATA", "ASS_A, R_ENT", "ASS_B, R_SAI"})
        Me.cbOrdenar.Location = New System.Drawing.Point(295, 4)
        Me.cbOrdenar.Name = "cbOrdenar"
        Me.cbOrdenar.Size = New System.Drawing.Size(112, 20)
        Me.cbOrdenar.TabIndex = 103
        Me.cbOrdenar.Text = "Sem Ordenação"
        '
        'dtpDataFim
        '
        Me.dtpDataFim.CustomFormat = "yyyy-MM-dd"
        Me.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDataFim.Location = New System.Drawing.Point(96, 27)
        Me.dtpDataFim.Name = "dtpDataFim"
        Me.dtpDataFim.Size = New System.Drawing.Size(81, 21)
        Me.dtpDataFim.TabIndex = 114
        '
        'teHoraFim
        '
        Me.teHoraFim.EditValue = New Date(2011, 8, 31, 23, 59, 59, 0)
        Me.teHoraFim.Location = New System.Drawing.Point(182, 27)
        Me.teHoraFim.Name = "teHoraFim"
        Me.teHoraFim.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.teHoraFim.Size = New System.Drawing.Size(68, 20)
        Me.teHoraFim.TabIndex = 113
        '
        'txtLimite
        '
        '
        '
        '
        Me.txtLimite.Border.Class = "TextBoxBorder"
        Me.txtLimite.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtLimite.Location = New System.Drawing.Point(347, 27)
        Me.txtLimite.Name = "txtLimite"
        Me.txtLimite.Size = New System.Drawing.Size(60, 21)
        Me.txtLimite.TabIndex = 11
        Me.txtLimite.Text = "500"
        Me.txtLimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnProcessar
        '
        Me.btnProcessar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnProcessar.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_19
        Me.btnProcessar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnProcessar.Name = "btnProcessar"
        Me.btnProcessar.Text = "Processar"
        Me.btnProcessar.Tooltip = "Recuperar CDRs no banco de dados conforme critérios selecionados."
        '
        'ItemContainer2
        '
        '
        '
        '
        Me.ItemContainer2.BackgroundStyle.Class = ""
        Me.ItemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer2.BeginGroup = True
        Me.ItemContainer2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer2.Name = "ItemContainer2"
        Me.ItemContainer2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer4, Me.ItemContainer6})
        '
        'ItemContainer4
        '
        '
        '
        '
        Me.ItemContainer4.BackgroundStyle.Class = ""
        Me.ItemContainer4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer4.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right
        Me.ItemContainer4.Name = "ItemContainer4"
        Me.ItemContainer4.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.LabelItem1, Me.ControlContainerItem5, Me.ControlContainerItem2, Me.LabelItem3, Me.ControlContainerItem11})
        Me.ItemContainer4.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle
        '
        'LabelItem1
        '
        Me.LabelItem1.Name = "LabelItem1"
        Me.LabelItem1.Text = "Início:"
        Me.LabelItem1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'ControlContainerItem5
        '
        Me.ControlContainerItem5.AllowItemResize = False
        Me.ControlContainerItem5.Control = Me.dtpDataInicio
        Me.ControlContainerItem5.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem5.Name = "ControlContainerItem5"
        '
        'ControlContainerItem2
        '
        Me.ControlContainerItem2.AllowItemResize = False
        Me.ControlContainerItem2.Control = Me.teHoraInicio
        Me.ControlContainerItem2.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem2.Name = "ControlContainerItem2"
        '
        'LabelItem3
        '
        Me.LabelItem3.Name = "LabelItem3"
        Me.LabelItem3.Text = "Ordem:"
        '
        'ControlContainerItem11
        '
        Me.ControlContainerItem11.AllowItemResize = False
        Me.ControlContainerItem11.Control = Me.cbOrdenar
        Me.ControlContainerItem11.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem11.Name = "ControlContainerItem11"
        '
        'ItemContainer6
        '
        '
        '
        '
        Me.ItemContainer6.BackgroundStyle.Class = ""
        Me.ItemContainer6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer6.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right
        Me.ItemContainer6.Name = "ItemContainer6"
        Me.ItemContainer6.ResizeItemsToFit = False
        Me.ItemContainer6.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.LabelItem4, Me.ControlContainerItem4, Me.ControlContainerItem3, Me.LabelItem5, Me.chkLimite, Me.ControlContainerItem7})
        Me.ItemContainer6.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle
        '
        'LabelItem4
        '
        Me.LabelItem4.Name = "LabelItem4"
        Me.LabelItem4.Text = "Fim:"
        Me.LabelItem4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'ControlContainerItem4
        '
        Me.ControlContainerItem4.AllowItemResize = False
        Me.ControlContainerItem4.Control = Me.dtpDataFim
        Me.ControlContainerItem4.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem4.Name = "ControlContainerItem4"
        '
        'ControlContainerItem3
        '
        Me.ControlContainerItem3.AllowItemResize = False
        Me.ControlContainerItem3.Control = Me.teHoraFim
        Me.ControlContainerItem3.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem3.Name = "ControlContainerItem3"
        '
        'LabelItem5
        '
        Me.LabelItem5.Name = "LabelItem5"
        Me.LabelItem5.Text = "          "
        '
        'chkLimite
        '
        Me.chkLimite.Checked = True
        Me.chkLimite.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLimite.Name = "chkLimite"
        Me.chkLimite.Text = "Limite"
        '
        'ControlContainerItem7
        '
        Me.ControlContainerItem7.AllowItemResize = False
        Me.ControlContainerItem7.Control = Me.txtLimite
        Me.ControlContainerItem7.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem7.Name = "ControlContainerItem7"
        '
        'ButtonItem6
        '
        Me.ButtonItem6.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem6.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_11
        Me.ButtonItem6.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem6.Name = "ButtonItem6"
        Me.ButtonItem6.Text = "Exportar CSV"
        Me.ButtonItem6.Visible = False
        '
        'ButtonItem2
        '
        Me.ButtonItem2.BeginGroup = True
        Me.ButtonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem2.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_11
        Me.ButtonItem2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.Text = "Importar CSV"
        Me.ButtonItem2.Visible = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BeginGroup = True
        Me.btnExcluir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnExcluir.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_14
        Me.btnExcluir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlDel)
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.Tooltip = "Cadastrar novo pagamento <ctrl> P"
        '
        'btnEditar
        '
        Me.btnEditar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnEditar.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_11
        Me.btnEditar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F3)
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.Tooltip = "Cadastrar novo pagamento <ctrl> P"
        '
        'btnNovo
        '
        Me.btnNovo.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnNovo.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_11
        Me.btnNovo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2)
        Me.btnNovo.Text = "Novo"
        '
        'btnColaboradores
        '
        Me.btnColaboradores.BeginGroup = True
        Me.btnColaboradores.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnColaboradores.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_14
        Me.btnColaboradores.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnColaboradores.Name = "btnColaboradores"
        Me.btnColaboradores.OptionGroup = "cadastro"
        Me.btnColaboradores.Text = "Colaboradores"
        Me.btnColaboradores.Tooltip = "Seleciona os Colaboradores"
        '
        'btnFornecedores
        '
        Me.btnFornecedores.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnFornecedores.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_15
        Me.btnFornecedores.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnFornecedores.Name = "btnFornecedores"
        Me.btnFornecedores.OptionGroup = "cadastro"
        Me.btnFornecedores.Text = "Fornecedores"
        Me.btnFornecedores.Tooltip = "Seleciona os Fornecedores"
        '
        'btnClientes
        '
        Me.btnClientes.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnClientes.Checked = True
        Me.btnClientes.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_04
        Me.btnClientes.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.OptionGroup = "cadastro"
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.Tooltip = "Cadastro de Clientes"
        '
        'btnExcluirCat
        '
        Me.btnExcluirCat.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnExcluirCat.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_15
        Me.btnExcluirCat.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnExcluirCat.Name = "btnExcluirCat"
        Me.btnExcluirCat.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlDel)
        Me.btnExcluirCat.SubItemsExpandWidth = 14
        Me.btnExcluirCat.Text = "Excluir"
        Me.btnExcluirCat.Tooltip = "Excluir a categoria selecionada"
        '
        'btnEditarCat
        '
        Me.btnEditarCat.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnEditarCat.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_14
        Me.btnEditarCat.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnEditarCat.Name = "btnEditarCat"
        Me.btnEditarCat.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlE)
        Me.btnEditarCat.SubItemsExpandWidth = 14
        Me.btnEditarCat.Text = "Editar"
        Me.btnEditarCat.Tooltip = "Alterar a categoria selecionada"
        '
        'btnNovaCategoria
        '
        Me.btnNovaCategoria.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnNovaCategoria.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_07
        Me.btnNovaCategoria.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnNovaCategoria.Name = "btnNovaCategoria"
        Me.btnNovaCategoria.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN)
        Me.btnNovaCategoria.Text = "Nova Categoria"
        Me.btnNovaCategoria.Tooltip = "Cadastrar nova caategoria"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.BeginGroup = True
        Me.ButtonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem1.Image = Global.SpyCdr.My.Resources.Resources.ExportarExcel
        Me.ButtonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.SubItemsExpandWidth = 14
        Me.ButtonItem1.Text = "Exportar para MS Excel"
        Me.ButtonItem1.Tooltip = "Apagar a conta selecionada"
        '
        'ButtonItemExcluirConta
        '
        Me.ButtonItemExcluirConta.BeginGroup = True
        Me.ButtonItemExcluirConta.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemExcluirConta.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_151
        Me.ButtonItemExcluirConta.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItemExcluirConta.Name = "ButtonItemExcluirConta"
        Me.ButtonItemExcluirConta.SubItemsExpandWidth = 14
        Me.ButtonItemExcluirConta.Text = "Excluir"
        Me.ButtonItemExcluirConta.Tooltip = "Apagar a conta selecionada"
        '
        'ButtonItemEditarConta
        '
        Me.ButtonItemEditarConta.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemEditarConta.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_14
        Me.ButtonItemEditarConta.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItemEditarConta.Name = "ButtonItemEditarConta"
        Me.ButtonItemEditarConta.SubItemsExpandWidth = 14
        Me.ButtonItemEditarConta.Text = "Editar"
        Me.ButtonItemEditarConta.Tooltip = "Alterar a conta selecionada"
        '
        'ButtonItemNovaConta
        '
        Me.ButtonItemNovaConta.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemNovaConta.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_04
        Me.ButtonItemNovaConta.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItemNovaConta.Name = "ButtonItemNovaConta"
        Me.ButtonItemNovaConta.Text = "Nova Conta"
        Me.ButtonItemNovaConta.Tooltip = "Cadastrar nova conta"
        '
        'btnImprimir
        '
        Me.btnImprimir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnImprimir.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_07
        Me.btnImprimir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.Tooltip = "Imprimir o relatório selecionado"
        '
        'ButtonItemAfastar
        '
        Me.ButtonItemAfastar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemAfastar.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_14
        Me.ButtonItemAfastar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItemAfastar.Name = "ButtonItemAfastar"
        Me.ButtonItemAfastar.Text = "Afastar"
        Me.ButtonItemAfastar.Tooltip = "Cadastrar nova conta"
        '
        'ButtonItemAproximar
        '
        Me.ButtonItemAproximar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemAproximar.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_14
        Me.ButtonItemAproximar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItemAproximar.Name = "ButtonItemAproximar"
        Me.ButtonItemAproximar.Text = "Aproximar"
        Me.ButtonItemAproximar.Tooltip = "Cadastrar nova conta"
        '
        'ButtonItemFavoritos
        '
        Me.ButtonItemFavoritos.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemFavoritos.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_11
        Me.ButtonItemFavoritos.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItemFavoritos.Name = "ButtonItemFavoritos"
        Me.ButtonItemFavoritos.Text = "Adicionar aos Favoritos"
        Me.ButtonItemFavoritos.Tooltip = "Cadastrar nova conta"
        '
        'ButtonItem8
        '
        Me.ButtonItem8.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem8.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_14
        Me.ButtonItem8.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem8.Name = "ButtonItem8"
        Me.ButtonItem8.Text = "Pesquisar CDRs"
        Me.ButtonItem8.Tooltip = "Recuperar registros de CDRs no banco de dados."
        '
        'RibbonPanel6
        '
        Me.RibbonPanel6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel6.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanel6.Name = "RibbonPanel6"
        Me.RibbonPanel6.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel6.Size = New System.Drawing.Size(1063, 129)
        '
        '
        '
        Me.RibbonPanel6.Style.Class = ""
        Me.RibbonPanel6.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel6.StyleMouseDown.Class = ""
        Me.RibbonPanel6.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel6.StyleMouseOver.Class = ""
        Me.RibbonPanel6.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel6.TabIndex = 15
        '
        'rbtInicio
        '
        Me.rbtInicio.Checked = True
        Me.rbtInicio.Name = "rbtInicio"
        Me.rbtInicio.Panel = Me.RibbonPanel8
        Me.rbtInicio.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlI)
        Me.rbtInicio.Text = "Início"
        '
        'rbtPesquisaCDRs
        '
        Me.rbtPesquisaCDRs.Name = "rbtPesquisaCDRs"
        Me.rbtPesquisaCDRs.Panel = Me.RibbonPanel1
        Me.rbtPesquisaCDRs.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2)
        Me.rbtPesquisaCDRs.Text = "Pesquisa CDRs"
        '
        'rbtResumoDiario
        '
        Me.rbtResumoDiario.Name = "rbtResumoDiario"
        Me.rbtResumoDiario.Panel = Me.RibbonPanel4
        Me.rbtResumoDiario.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F3)
        Me.rbtResumoDiario.Text = "Resumo Diário"
        '
        'rbtHistorico
        '
        Me.rbtHistorico.Name = "rbtHistorico"
        Me.rbtHistorico.Panel = Me.RibbonPanel5
        Me.rbtHistorico.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F4)
        Me.rbtHistorico.Text = "Histórico"
        '
        'RibbonTabItemLancamentos
        '
        Me.RibbonTabItemLancamentos.Name = "RibbonTabItemLancamentos"
        Me.RibbonTabItemLancamentos.Panel = Me.RibbonPanel2
        Me.RibbonTabItemLancamentos.Text = "Processamentos"
        '
        'RibbonTabItemProgramacao
        '
        Me.RibbonTabItemProgramacao.Name = "RibbonTabItemProgramacao"
        Me.RibbonTabItemProgramacao.Panel = Me.RibbonPanel3
        Me.RibbonTabItemProgramacao.Text = "Manutenções"
        '
        'RibbonTabItemPesquisa
        '
        Me.RibbonTabItemPesquisa.Name = "RibbonTabItemPesquisa"
        Me.RibbonTabItemPesquisa.Panel = Me.RibbonPanel7
        Me.RibbonTabItemPesquisa.Text = "Ajuda"
        '
        'buttonChangeStyle
        '
        Me.buttonChangeStyle.AutoExpandOnClick = True
        Me.buttonChangeStyle.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
        Me.buttonChangeStyle.Name = "buttonChangeStyle"
        Me.buttonChangeStyle.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonStyleOffice2007Blue, Me.buttonStyleOffice2007Black, Me.buttonStyleOffice2007Silver, Me.buttonStyleCustom})
        Me.buttonChangeStyle.Text = "Estilo"
        '
        'buttonStyleOffice2007Blue
        '
        Me.buttonStyleOffice2007Blue.Command = Me.AppCommandTheme
        Me.buttonStyleOffice2007Blue.CommandParameter = "Blue"
        Me.buttonStyleOffice2007Blue.Name = "buttonStyleOffice2007Blue"
        Me.buttonStyleOffice2007Blue.OptionGroup = "style"
        Me.buttonStyleOffice2007Blue.Text = "Office 2007 <font color=""Blue""><b>Azul</b></font>"
        '
        'AppCommandTheme
        '
        Me.AppCommandTheme.Checked = False
        Me.AppCommandTheme.Name = "AppCommandTheme"
        '
        'buttonStyleOffice2007Black
        '
        Me.buttonStyleOffice2007Black.Checked = True
        Me.buttonStyleOffice2007Black.Command = Me.AppCommandTheme
        Me.buttonStyleOffice2007Black.CommandParameter = "Black"
        Me.buttonStyleOffice2007Black.Name = "buttonStyleOffice2007Black"
        Me.buttonStyleOffice2007Black.OptionGroup = "style"
        Me.buttonStyleOffice2007Black.Text = "Office 2007 <font color=""Black""><b>Preto</b></font>"
        '
        'buttonStyleOffice2007Silver
        '
        Me.buttonStyleOffice2007Silver.Command = Me.AppCommandTheme
        Me.buttonStyleOffice2007Silver.CommandParameter = "Silver"
        Me.buttonStyleOffice2007Silver.Name = "buttonStyleOffice2007Silver"
        Me.buttonStyleOffice2007Silver.OptionGroup = "style"
        Me.buttonStyleOffice2007Silver.Text = "Office 2007 <font color=""Silver""><b>Prata</b></font>"
        '
        'buttonStyleCustom
        '
        Me.buttonStyleCustom.BeginGroup = True
        Me.buttonStyleCustom.Command = Me.AppCommandTheme
        Me.buttonStyleCustom.Name = "buttonStyleCustom"
        Me.buttonStyleCustom.OptionGroup = "style"
        Me.buttonStyleCustom.Text = "Personalizar"
        '
        'ButtonFile
        '
        Me.ButtonFile.AutoExpandOnClick = True
        Me.ButtonFile.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image
        Me.ButtonFile.Image = CType(resources.GetObject("ButtonFile.Image"), System.Drawing.Image)
        Me.ButtonFile.ImagePaddingHorizontal = 2
        Me.ButtonFile.ImagePaddingVertical = 2
        Me.ButtonFile.Name = "ButtonFile"
        Me.ButtonFile.ShowSubItems = False
        Me.ButtonFile.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.menuFileContainer})
        Me.ButtonFile.Text = "Cadastro"
        '
        'menuFileContainer
        '
        '
        '
        '
        Me.menuFileContainer.BackgroundStyle.Class = "RibbonFileMenuContainer"
        Me.menuFileContainer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.menuFileContainer.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.menuFileContainer.Name = "menuFileContainer"
        Me.menuFileContainer.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.menuFileTwoColumnContainer})
        '
        'menuFileTwoColumnContainer
        '
        '
        '
        '
        Me.menuFileTwoColumnContainer.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer"
        Me.menuFileTwoColumnContainer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.menuFileTwoColumnContainer.ItemSpacing = 0
        Me.menuFileTwoColumnContainer.Name = "menuFileTwoColumnContainer"
        Me.menuFileTwoColumnContainer.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.menuFileItems})
        '
        'menuFileItems
        '
        '
        '
        '
        Me.menuFileItems.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.menuFileItems.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer"
        Me.menuFileItems.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.menuFileItems.ItemSpacing = 4
        Me.menuFileItems.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.menuFileItems.MinimumSize = New System.Drawing.Size(120, 0)
        Me.menuFileItems.Name = "menuFileItems"
        Me.menuFileItems.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnMenuPesquisaCDRs, Me.btnMenuResumoDiario, Me.btnMenuConsultarHistorico, Me.btnMenuGerarHistorico, Me.btnMenuSair})
        '
        'btnMenuPesquisaCDRs
        '
        Me.btnMenuPesquisaCDRs.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnMenuPesquisaCDRs.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_14
        Me.btnMenuPesquisaCDRs.Name = "btnMenuPesquisaCDRs"
        Me.btnMenuPesquisaCDRs.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2)
        Me.btnMenuPesquisaCDRs.SubItemsExpandWidth = 24
        Me.btnMenuPesquisaCDRs.Text = "&Pesquisa CDRs"
        Me.btnMenuPesquisaCDRs.Tooltip = "Pesquisa chamadas no banco de dados"
        '
        'btnMenuResumoDiario
        '
        Me.btnMenuResumoDiario.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnMenuResumoDiario.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_151
        Me.btnMenuResumoDiario.Name = "btnMenuResumoDiario"
        Me.btnMenuResumoDiario.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F3)
        Me.btnMenuResumoDiario.SubItemsExpandWidth = 24
        Me.btnMenuResumoDiario.Text = "&Resumo diário"
        Me.btnMenuResumoDiario.Tooltip = "Acesso ao estatísticas diárias"
        '
        'btnMenuConsultarHistorico
        '
        Me.btnMenuConsultarHistorico.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnMenuConsultarHistorico.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_68
        Me.btnMenuConsultarHistorico.Name = "btnMenuConsultarHistorico"
        Me.btnMenuConsultarHistorico.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F4)
        Me.btnMenuConsultarHistorico.Text = "Consultar &Histórico"
        Me.btnMenuConsultarHistorico.Tooltip = "Permite acompanhar histórico de estatísticas"
        '
        'btnMenuGerarHistorico
        '
        Me.btnMenuGerarHistorico.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnMenuGerarHistorico.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_48
        Me.btnMenuGerarHistorico.Name = "btnMenuGerarHistorico"
        Me.btnMenuGerarHistorico.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5)
        Me.btnMenuGerarHistorico.Text = "&Gerar históricos"
        Me.btnMenuGerarHistorico.Tooltip = "Gera estatísticas por rota, por cliente..."
        '
        'btnMenuSair
        '
        Me.btnMenuSair.BeginGroup = True
        Me.btnMenuSair.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnMenuSair.Image = CType(resources.GetObject("btnMenuSair.Image"), System.Drawing.Image)
        Me.btnMenuSair.Name = "btnMenuSair"
        Me.btnMenuSair.SubItemsExpandWidth = 24
        Me.btnMenuSair.Text = "&Sair do Programa"
        Me.btnMenuSair.Tooltip = "Sair do programa"
        '
        'Office2007StartButton1
        '
        Me.Office2007StartButton1.AutoExpandOnClick = True
        Me.Office2007StartButton1.CanCustomize = False
        Me.Office2007StartButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image
        Me.Office2007StartButton1.Image = CType(resources.GetObject("Office2007StartButton1.Image"), System.Drawing.Image)
        Me.Office2007StartButton1.ImagePaddingHorizontal = 2
        Me.Office2007StartButton1.ImagePaddingVertical = 2
        Me.Office2007StartButton1.Name = "Office2007StartButton1"
        Me.Office2007StartButton1.ShowSubItems = False
        Me.Office2007StartButton1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer11})
        '
        'ItemContainer11
        '
        '
        '
        '
        Me.ItemContainer11.BackgroundStyle.Class = "RibbonFileMenuContainer"
        Me.ItemContainer11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer11.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer11.Name = "ItemContainer11"
        Me.ItemContainer11.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer14, Me.ItemContainer16})
        '
        'ItemContainer14
        '
        '
        '
        '
        Me.ItemContainer14.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer"
        Me.ItemContainer14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer14.ItemSpacing = 0
        Me.ItemContainer14.Name = "ItemContainer14"
        Me.ItemContainer14.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer15, Me.GalleryContainer1})
        '
        'ItemContainer15
        '
        '
        '
        '
        Me.ItemContainer15.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer"
        Me.ItemContainer15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer15.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer15.MinimumSize = New System.Drawing.Size(120, 0)
        Me.ItemContainer15.Name = "ItemContainer15"
        Me.ItemContainer15.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem10, Me.ButtonItem11, Me.ButtonItem12, Me.ButtonItem13, Me.ButtonItem14, Me.ButtonItem15})
        '
        'ButtonItem10
        '
        Me.ButtonItem10.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem10.Image = CType(resources.GetObject("ButtonItem10.Image"), System.Drawing.Image)
        Me.ButtonItem10.Name = "ButtonItem10"
        Me.ButtonItem10.SubItemsExpandWidth = 24
        '
        'ButtonItem11
        '
        Me.ButtonItem11.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem11.Image = CType(resources.GetObject("ButtonItem11.Image"), System.Drawing.Image)
        Me.ButtonItem11.Name = "ButtonItem11"
        Me.ButtonItem11.SubItemsExpandWidth = 24
        '
        'ButtonItem12
        '
        Me.ButtonItem12.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem12.Image = CType(resources.GetObject("ButtonItem12.Image"), System.Drawing.Image)
        Me.ButtonItem12.Name = "ButtonItem12"
        Me.ButtonItem12.SubItemsExpandWidth = 24
        '
        'ButtonItem13
        '
        Me.ButtonItem13.BeginGroup = True
        Me.ButtonItem13.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem13.Image = CType(resources.GetObject("ButtonItem13.Image"), System.Drawing.Image)
        Me.ButtonItem13.Name = "ButtonItem13"
        Me.ButtonItem13.SubItemsExpandWidth = 24
        '
        'ButtonItem14
        '
        Me.ButtonItem14.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem14.Image = CType(resources.GetObject("ButtonItem14.Image"), System.Drawing.Image)
        Me.ButtonItem14.Name = "ButtonItem14"
        Me.ButtonItem14.SubItemsExpandWidth = 24
        '
        'ButtonItem15
        '
        Me.ButtonItem15.BeginGroup = True
        Me.ButtonItem15.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem15.Image = CType(resources.GetObject("ButtonItem15.Image"), System.Drawing.Image)
        Me.ButtonItem15.Name = "ButtonItem15"
        Me.ButtonItem15.SubItemsExpandWidth = 24
        '
        'GalleryContainer1
        '
        '
        '
        '
        Me.GalleryContainer1.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer"
        Me.GalleryContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GalleryContainer1.EnableGalleryPopup = False
        Me.GalleryContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.GalleryContainer1.MinimumSize = New System.Drawing.Size(180, 240)
        Me.GalleryContainer1.MultiLine = False
        Me.GalleryContainer1.Name = "GalleryContainer1"
        Me.GalleryContainer1.PopupUsesStandardScrollbars = False
        Me.GalleryContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.labelItem8, Me.ButtonItem16, Me.ButtonItem17, Me.ButtonItem18, Me.ButtonItem19})
        '
        'labelItem8
        '
        Me.labelItem8.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.labelItem8.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.labelItem8.CanCustomize = False
        Me.labelItem8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labelItem8.Name = "labelItem8"
        Me.labelItem8.PaddingBottom = 2
        Me.labelItem8.PaddingTop = 2
        Me.labelItem8.Stretch = True
        '
        'ButtonItem16
        '
        Me.ButtonItem16.Name = "ButtonItem16"
        '
        'ButtonItem17
        '
        Me.ButtonItem17.Name = "ButtonItem17"
        '
        'ButtonItem18
        '
        Me.ButtonItem18.Name = "ButtonItem18"
        '
        'ButtonItem19
        '
        Me.ButtonItem19.Name = "ButtonItem19"
        '
        'ItemContainer16
        '
        '
        '
        '
        Me.ItemContainer16.BackgroundStyle.Class = "RibbonFileMenuBottomContainer"
        Me.ItemContainer16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer16.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right
        Me.ItemContainer16.Name = "ItemContainer16"
        Me.ItemContainer16.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem20, Me.ButtonItem21})
        '
        'ButtonItem20
        '
        Me.ButtonItem20.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem20.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonItem20.Image = CType(resources.GetObject("ButtonItem20.Image"), System.Drawing.Image)
        Me.ButtonItem20.Name = "ButtonItem20"
        Me.ButtonItem20.SubItemsExpandWidth = 24
        '
        'ButtonItem21
        '
        Me.ButtonItem21.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem21.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonItem21.Image = CType(resources.GetObject("ButtonItem21.Image"), System.Drawing.Image)
        Me.ButtonItem21.Name = "ButtonItem21"
        Me.ButtonItem21.SubItemsExpandWidth = 24
        '
        'ButtonItem9
        '
        Me.ButtonItem9.Name = "ButtonItem9"
        '
        'QatCustomizeItem1
        '
        Me.QatCustomizeItem1.Name = "QatCustomizeItem1"
        '
        'ItemContainer7
        '
        '
        '
        '
        Me.ItemContainer7.BackgroundStyle.Class = ""
        Me.ItemContainer7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer7.Name = "ItemContainer7"
        '
        'ItemContainer8
        '
        '
        '
        '
        Me.ItemContainer8.BackgroundStyle.Class = ""
        Me.ItemContainer8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer8.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right
        Me.ItemContainer8.Name = "ItemContainer8"
        Me.ItemContainer8.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ControlContainerItem6, Me.ControlContainerItem8})
        Me.ItemContainer8.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle
        '
        'ControlContainerItem6
        '
        Me.ControlContainerItem6.AllowItemResize = False
        Me.ControlContainerItem6.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem6.Name = "ControlContainerItem6"
        '
        'ControlContainerItem8
        '
        Me.ControlContainerItem8.AllowItemResize = False
        Me.ControlContainerItem8.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem8.Name = "ControlContainerItem8"
        '
        'HTML
        '
        Me.HTML.Text = "HTML"
        '
        'XML
        '
        Me.XML.Text = "XML"
        '
        'XLX
        '
        Me.XLX.Text = "XLX"
        '
        'XLS
        '
        Me.XLS.Text = "XLS"
        '
        'RTF
        '
        Me.RTF.Text = "RTF"
        '
        'PDF
        '
        Me.PDF.Text = "PDF"
        '
        'MHT
        '
        Me.MHT.Text = "MHT"
        '
        'TXT
        '
        Me.TXT.Text = "TXT"
        '
        'ItemContainer9
        '
        '
        '
        '
        Me.ItemContainer9.BackgroundStyle.Class = ""
        Me.ItemContainer9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer9.BeginGroup = True
        Me.ItemContainer9.Name = "ItemContainer9"
        Me.ItemContainer9.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnPrimeiraPag, Me.btnPagAnterior, Me.btnProximaPag, Me.btnUltimaPag})
        Me.ItemContainer9.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle
        '
        'btnPrimeiraPag
        '
        Me.btnPrimeiraPag.Name = "btnPrimeiraPag"
        Me.btnPrimeiraPag.Text = "<|"
        '
        'btnPagAnterior
        '
        Me.btnPagAnterior.Name = "btnPagAnterior"
        Me.btnPagAnterior.Text = "<"
        '
        'btnProximaPag
        '
        Me.btnProximaPag.Name = "btnProximaPag"
        Me.btnProximaPag.Text = ">"
        '
        'btnUltimaPag
        '
        Me.btnUltimaPag.Name = "btnUltimaPag"
        Me.btnUltimaPag.Text = "|>"
        '
        'ItemContainer10
        '
        '
        '
        '
        Me.ItemContainer10.BackgroundStyle.Class = ""
        Me.ItemContainer10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer10.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer10.Name = "ItemContainer10"
        Me.ItemContainer10.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.chkBarra, Me.chkPainelLateral})
        Me.ItemContainer10.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle
        '
        'chkBarra
        '
        Me.chkBarra.Name = "chkBarra"
        Me.chkBarra.Text = "Barra de ferramentas"
        '
        'chkPainelLateral
        '
        Me.chkPainelLateral.Checked = True
        Me.chkPainelLateral.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPainelLateral.Name = "chkPainelLateral"
        Me.chkPainelLateral.Text = "Painel Lateral"
        '
        'ItemContainer3
        '
        '
        '
        '
        Me.ItemContainer3.BackgroundStyle.Class = ""
        Me.ItemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer3.Name = "ItemContainer3"
        Me.ItemContainer3.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItemAgrupamento, Me.ButtonItemEscolherColunas})
        '
        'ButtonItemAgrupamento
        '
        Me.ButtonItemAgrupamento.Name = "ButtonItemAgrupamento"
        Me.ButtonItemAgrupamento.Text = "Agrupamento"
        '
        'ButtonItemEscolherColunas
        '
        Me.ButtonItemEscolherColunas.Name = "ButtonItemEscolherColunas"
        Me.ButtonItemEscolherColunas.Text = "Escolher Colunas"
        '
        'ItemContainer5
        '
        '
        '
        '
        Me.ItemContainer5.BackgroundStyle.Class = ""
        Me.ItemContainer5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer5.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer5.Name = "ItemContainer5"
        Me.ItemContainer5.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.CheckBoxItem2, Me.CheckBoxItem3})
        Me.ItemContainer5.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle
        '
        'CheckBoxItem2
        '
        Me.CheckBoxItem2.Name = "CheckBoxItem2"
        Me.CheckBoxItem2.Text = "Mostrar Painel Grupo"
        '
        'CheckBoxItem3
        '
        Me.CheckBoxItem3.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
        Me.CheckBoxItem3.Name = "CheckBoxItem3"
        Me.CheckBoxItem3.ShowSubItems = False
        Me.CheckBoxItem3.Text = "Escolher Colunas"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "6"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "7"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "8"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "9"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "10"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "11"
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "12"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "SpyCdr"
        '
        'ControlContainerItem1
        '
        Me.ControlContainerItem1.AllowItemResize = False
        Me.ControlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem1.Name = "ControlContainerItem1"
        '
        'ComboBoxItem1
        '
        Me.ComboBoxItem1.Category = "para:"
        Me.ComboBoxItem1.DropDownHeight = 106
        Me.ComboBoxItem1.Items.AddRange(New Object() {Me.ComboItem8, Me.ComboItem9, Me.ComboItem10, Me.ComboItem11, Me.ComboItem12, Me.ComboItem13, Me.ComboItem14, Me.ComboItem15})
        Me.ComboBoxItem1.Name = "ComboBoxItem1"
        Me.ComboBoxItem1.Text = "XLX"
        '
        'ComboItem8
        '
        Me.ComboItem8.Text = "HTML"
        '
        'ComboItem9
        '
        Me.ComboItem9.Text = "XML"
        '
        'ComboItem10
        '
        Me.ComboItem10.Text = "XLX"
        '
        'ComboItem11
        '
        Me.ComboItem11.Text = "XLS"
        '
        'ComboItem12
        '
        Me.ComboItem12.Text = "RTF"
        '
        'ComboItem13
        '
        Me.ComboItem13.Text = "PDF"
        '
        'ComboItem14
        '
        Me.ComboItem14.Text = "MHT"
        '
        'ComboItem15
        '
        Me.ComboItem15.Text = "TXT"
        '
        'ComboItem16
        '
        Me.ComboItem16.Text = "HTML"
        '
        'ComboItem17
        '
        Me.ComboItem17.Text = "XML"
        '
        'ComboItem18
        '
        Me.ComboItem18.Text = "XLX"
        '
        'ComboItem19
        '
        Me.ComboItem19.Text = "XLS"
        '
        'ComboItem20
        '
        Me.ComboItem20.Text = "RTF"
        '
        'ComboItem21
        '
        Me.ComboItem21.Text = "PDF"
        '
        'ComboItem22
        '
        Me.ComboItem22.Text = "MHT"
        '
        'ComboItem23
        '
        Me.ComboItem23.Text = "TXT"
        '
        'CheckBoxItem1
        '
        Me.CheckBoxItem1.Name = "CheckBoxItem1"
        Me.CheckBoxItem1.Text = "CheckBoxItem1"
        '
        'pb1
        '
        Me.pb1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.pb1.BackgroundStyle.Class = ""
        Me.pb1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.pb1.Location = New System.Drawing.Point(45, 2)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(882, 23)
        Me.pb1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.pb1.TabIndex = 116
        Me.pb1.Visible = False
        '
        'frmPrincipal2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1063, 557)
        Me.Controls.Add(Me.ribbonControl1)
        Me.Controls.Add(Me.barStatus)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmPrincipal2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "gf Getor Financeiro"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.barStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ribbonControl1.ResumeLayout(False)
        Me.ribbonControl1.PerformLayout()
        Me.RibbonPanel8.ResumeLayout(False)
        Me.RibbonPanel3.ResumeLayout(False)
        Me.RibbonPanel2.ResumeLayout(False)
        Me.RibbonPanel5.ResumeLayout(False)
        Me.RibbonPanel4.ResumeLayout(False)
        Me.RibbonPanel1.ResumeLayout(False)
        Me.rbLoop.ResumeLayout(False)
        Me.RibbonBar2.ResumeLayout(False)
        CType(Me.teHoraInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teHoraFim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Public Sub ProcessoInicio()
        'Me.Text = String.Format("SpyCdr - Investigador de bilhetes ({0:s})", My.Settings.Bilhetador)

        'Me.ToolStripStatusAguarde.Visible = True
        'Me.StatusStrip1.Refresh()
        Cursor = Cursors.WaitCursor
        labelStatus.Text = "Carregando formulário. AGUARDE..."
    End Sub

    Public Sub ProcessoFim()
        'Me.ToolStripStatusAguarde.Visible = False
        labelStatus.Text = ""
        barStatus.Refresh()
        Cursor = Cursors.Default
    End Sub

    Private Sub EnableFileItems()
        ' Accessing items through the Items collection and setting the properties on them
        ' will propagate certain properties to all items with the same name...
        If Me.ActiveMdiChild Is Nothing Then
            'btnPedido.Enabled = False
            'buttonPrint.Enabled = False
        Else
            'btnPedido.Enabled = True
            'buttonPrint.Enabled = True
        End If
    End Sub
    Private Sub frmMain_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        'frmLogin.Dispose()
    End Sub

    Private Function GetQueryStringParameters() As Specialized.NameValueCollection
        Dim NameValueTable As New Specialized.NameValueCollection()

        Dim QueryString As String = Deployment.Application.ApplicationDeployment.CurrentDeployment.ActivationUri.Query
        NameValueTable = HttpUtility.ParseQueryString(QueryString)

        GetQueryStringParameters = NameValueTable
    End Function

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\SpyCdr")
        If Not key Is Nothing Then
            Try
                Dim layout As String = key.GetValue("RibbonPadVBLayout", "").ToString()
                If layout <> "" And Not layout Is Nothing Then
                    ribbonControl1.QatLayout = layout
                End If

                Dim Estilo As String = key.GetValue("Estilo", "")
                If Estilo <> "" Then
                    Dim cs As eOffice2007ColorScheme = CType(System.Enum.Parse(GetType(eOffice2007ColorScheme), Estilo), eOffice2007ColorScheme)
                    ribbonControl1.Office2007ColorTable = cs
                    Dim Cor As Double = key.GetValue("Cor", 0)
                    If Cor <> 0 Then RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, cs, Color.FromArgb(Cor))
                    buttonStyleCustom.CommandParameter = buttonStyleCustom.SelectedColor
                End If


            Finally
                key.Close()
            End Try
        End If


        ' Create the list of the Frequently Used Commands for the Quick Access Toolbar Customize menu
        ribbonControl1.QatFrequentCommands.Add(btnProcessar)
        ribbonControl1.QatFrequentCommands.Add(btnMenuResumoDiario)
        ribbonControl1.QatFrequentCommands.Add(btnMenuSair)

        ' Neccessary for Automatic Tab-Strip Mdi support
        ''tabStrip1.MdiForm = Me

        UpdateTitle()

        ' Pulse Application Button
        'ButtonFile.Pulse(11)
        'My.Forms.frmInicio.MdiParent = Me
        'My.Forms.frmInicio.Show()
        'My.Forms.frmInicio.Activate()

        Me.NotifyIcon1.Visible = False

        frmManutencao.CarregaINI("")

        Conn = MySQL_Conn()
        If Conn Is Nothing Then
            'MsgBox("Não foi possível conectar ao banco de dados. Verifique as configurações.")
            Exit Sub
        End If

        My.Settings.Param1 = ""
        My.Settings.Param2 = ""
        'Se estiver executando do servidor
        Try
            If System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed Then
                My.Settings.Param1 = GetQueryStringParameters().Item("Param1").ToUpper
                My.Settings.Param2 = GetQueryStringParameters().Item("Param2").ToUpper
            Else
                If My.Application.CommandLineArgs.Count > 0 Then
                    My.Settings.Param1 = My.Application.CommandLineArgs(0).ToString.ToUpper
                    If My.Application.CommandLineArgs.Count > 1 Then My.Settings.Param2 = My.Application.CommandLineArgs(1).ToString.ToUpper
                End If
            End If
        Catch ex As Exception
        End Try

        If My.Settings.Param1 <> "" Then
            SplashSpyCdr.WindowState = FormWindowState.Minimized
            Me.NotifyIcon1.Visible = True
            'Hide()
            Me.Text &= " (" & My.Settings.Param1 & ") [" & frmManutencao.cbBilhetador.Text & "]"
        Else
            Me.Text &= " [" & frmManutencao.cbBilhetador.Text & "]"
        End If
        'StatusStrip1.Items(0).Text = "SpyCdr"

        If My.Settings.Param1 = "EXROP" Then
            'rtbNovidades.Visible = False
            'txtMensagemPrincipal.Visible = False
            'lblTitulo.Visible = False
            'lnkNovidades.Visible = False
            'lblUltimoTTFILE.Visible = False
            My.Forms.frmDumpShadow.MdiParent = Me
            My.Forms.frmDumpShadow.Show()
            My.Forms.frmDumpShadow.Activate()
        End If

        If My.Settings.Param1 = "GERADDX" Then
            Dim Data As Date
            If My.Settings.Param2 <> "" Then
                Data = Now().AddDays(-My.Settings.Param2)
            Else
                Data = Now()
            End If
            If frmGeraHistorico.ckbX_Rota_Entrada.Checked Then
                barStatus.Items(0).Text = "Gera_X_rota_entrada"
                Gera_X_rota_entrada(Format(Data, "yyyy-MM-dd"))
            End If
            If frmGeraHistorico.ckbX_Rota_Saida.Checked Then
                barStatus.Items(0).Text = "Gera_X_rota_saida"
                Gera_X_rota_saida(Format(Data, "yyyy-MM-dd"))
            End If
            If frmGeraHistorico.ckbX_Cliente_Originado.Checked Then
                barStatus.Items(0).Text = "Gera_X_Cliente_Originado"
                Gera_X_Cliente_Originado(Format(Data, "yyyy-MM-dd"))
            End If
            If frmGeraHistorico.ckbX_Cliente_Destinado.Checked Then
                barStatus.Items(0).Text = "Gera_X_Cliente_Destinado"
                Gera_X_Cliente_Destinado(Format(Data, "yyyy-MM-dd"))
            End If
            If frmGeraHistorico.ckbX_Grupo.Checked Then
                barStatus.Items(0).Text = "Gera_X_Grupo"
                Gera_X_Grupo(Format(Data, "yyyy-MM-dd"))
            End If
            If frmGeraHistorico.ckbX_ASS_A.Checked Then
                barStatus.Items(0).Text = "Gera_X_ASS_A"
                Gera_X_ASS_A(Format(Data, "yyyy-MM-dd"))
            End If
            If frmGeraHistorico.ckbX_ASS_B.Checked Then
                barStatus.Items(0).Text = "Gera_X_ASS_B"
                Gera_X_ASS_B(Format(Data, "yyyy-MM-dd"))
            End If
            If frmGeraHistorico.ckbX_EOS.Checked Then
                barStatus.Items(0).Text = "Gera_X_EOS"
                Gera_X_EOS(Format(Data, "yyyy-MM-dd"))
            End If
            If frmGeraHistorico.ckbX_EOS.Checked Then
                barStatus.Items(0).Text = "Gera_X_PPI"
                Gera_X_PPI(Format(Data, "yyyy-MM-dd"))
            End If

            Me.Close()
        End If
        Dim dt As New DataTable("log")
        dt = MySQL_Select(Conn, "select TTFILE, DATA_BMP, HORA_BMP from log order BY data_baixa DESC, hora_baixa DESC LIMIT 1")
        If dt.Rows.Count = 1 Then
            'lblUltimoTTFILE.Text = dt.Rows(0).Item("TTFILE").ToString & " " _
            '                    & Format(dt.Rows(0).Item("DATA_BMP"), "dd/MM/yyyy") & " " _
            '                   & dt.Rows(0).Item("HORA_BMP").ToString
        Else
            'lblUltimoTTFILE.Text = "..."
        End If
        dt = Nothing

    End Sub



#Region "Automatic Color Scheme creation based on the selected color table"
    Private m_ColorSelected As Boolean = False
    Private m_BaseColorScheme As eOffice2007ColorScheme = eOffice2007ColorScheme.Blue
    Private Sub buttonStyleCustom_ExpandChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonStyleCustom.ExpandChange
        If buttonStyleCustom.Expanded Then
            ' Remember the starting color scheme to apply if no color is selected during live-preview
            m_ColorSelected = False
            m_BaseColorScheme = CType(GlobalManager.Renderer, Office2007Renderer).ColorTable.InitialColorScheme
        Else
            If Not m_ColorSelected Then
                ribbonControl1.Office2007ColorTable = m_BaseColorScheme
            End If
        End If
    End Sub

    Private Sub buttonStyleCustom_ColorPreview(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.ColorPreviewEventArgs) Handles buttonStyleCustom.ColorPreview
        RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, m_BaseColorScheme, e.Color)
    End Sub

    Private Sub buttonStyleCustom_SelectedColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonStyleCustom.SelectedColorChanged
        m_ColorSelected = True ' Indicate that color was selected for buttonStyleCustom_ExpandChange method
        buttonStyleCustom.CommandParameter = buttonStyleCustom.SelectedColor
    End Sub
#End Region

    ' Updates the title displayed on Ribbon using the rich text markup
    Private Sub UpdateTitle()
        Dim t As String = ""
        If Not Me.ActiveMdiChild Is Nothing Then
            ' Note the usage of SysCaptionTextExtra for as the value of color attribute.
            ' It specifies the system color that changes based on selected color table.
            t += "<font color=""SysCaptionTextExtra"">" + Me.ActiveMdiChild.Text + "</font> "
        End If
        t += String.Format("<b>SpyCdr - Investigador de bilhetes ({0:s})</b>", My.Settings.Bilhetador)
        t += " <b><a name=""tip""><font color=""SysCaptionTextExtra""></font></a></b>"
        ribbonControl1.TitleText = t
    End Sub

    Private Sub barStatus_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles barStatus.SizeChanged
        'ProgressBarControl1.Width = Me.Width - 260
    End Sub

    Private Sub AppCommandTheme_Executed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppCommandTheme.Executed
        Dim source As ICommandSource = CType(sender, ICommandSource)
        If TypeOf (source.CommandParameter) Is String Then
            Dim cs As eOffice2007ColorScheme = CType(System.Enum.Parse(GetType(eOffice2007ColorScheme), source.CommandParameter.ToString()), eOffice2007ColorScheme)
            ' This is all that is needed to change the color table for all controls on the form
            ribbonControl1.Office2007ColorTable = cs
            'Guarda no registro
            Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\SpyCdr")
            key.SetValue("Estilo", cs)
            key.SetValue("Cor", 0)

        ElseIf TypeOf (source.CommandParameter) Is Color Then
            RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, m_BaseColorScheme, CType(source.CommandParameter, Color))
            'Guarda no registro
            Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\SpyCdr")
            key.SetValue("Cor", CType(source.CommandParameter, Color).ToArgb)
        End If
        Invalidate()
    End Sub
    Private Sub AppCommandClose_Executed(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmPrincipal_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ' Save Quick Access Toolbar layout if it has changed...
        If ribbonControl1.QatLayoutChanged Then
            Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\SpyCdr")
            Try
                key.SetValue("RibbonPadVBLayout", ribbonControl1.QatLayout)
            Finally
                key.Close()
            End Try
        End If

    End Sub

    Private Sub frmPrincipal_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        SplashSpyCdr.Dispose()
    End Sub

    Private Sub btnConsultaHistorico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ProcessoInicio()
        My.Forms.frmHistorico.MdiParent = Me
        My.Forms.frmHistorico.Show()
        My.Forms.frmHistorico.Activate()
        ProcessoFim()

    End Sub

    Private Sub rbtPesquisaCDRs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtPesquisaCDRs.Click
        ProcessoInicio()
        My.Settings.strSQL = Nothing
        Select Case frmManutencao.cbTipoCentral.Text
            Case "E"
                frmListaCdrs.statusTabela.Text = "cdrs_" & Format(Now, "yyyyMMdd")
                frmListaCdrs.MdiParent = Me
                frmListaCdrs.Show()
                frmListaCdrs.Activate()
            Case "H"
                dtpDataInicio.Value = Now
                frmListaCDRs_H.MdiParent = Me
                frmListaCDRs_H.Show()
                frmListaCDRs_H.Activate()
            Case "N"
                frmListaCdrs_N.statusTabela.Text = "cdrs_" & Format(Now, "yyyyMMdd")
                frmListaCdrs_N.MdiParent = Me
                My.Forms.frmListaCdrs_N.Show()
                frmListaCdrs_N.Activate()
        End Select
        ProcessoFim()

    End Sub

    Private Sub rbtResumoDiario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtResumoDiario.Click
        ProcessoInicio()
        My.Forms.frmResumo.MdiParent = Me
        My.Forms.frmResumo.Show()
        My.Forms.frmResumo.Activate()
        ProcessoFim()
    End Sub

    Private Sub btnNovidades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovidades.Click
        btnNovidades.Checked = Not btnNovidades.Checked
        frmInicio.rtbNovidades.Visible = btnNovidades.Checked
    End Sub

    Private Sub rbtInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtInicio.Click
        My.Forms.frmInicio.MdiParent = Me
        My.Forms.frmInicio.Show()
        My.Forms.frmInicio.Activate()
    End Sub

    Private Sub btnProcessar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcessar.Click
        Select Case My.Settings.TipoCentral
            Case "E"
            Case "H"
                frmListaCDRs_H.Processar()
            Case "N"
        End Select
    End Sub

    Private Sub btnLimparCriterios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimparCriterios.Click
        Select Case My.Settings.TipoCentral
            Case "E"
            Case "H"
                frmListaCDRs_H.btnLimpar_Criterios()
            Case "N"
        End Select
    End Sub

    Private Sub btnGravarCriterio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGravarCriterio.Click
        Select Case My.Settings.TipoCentral
            Case "E"
            Case "H"
                frmListaCDRs_H.Gravar_Criterio()
            Case "N"
        End Select
    End Sub

    Private Sub btnLerCriterio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLerCriterio.Click
        Select Case My.Settings.TipoCentral
            Case "E"
            Case "H"
                frmListaCDRs_H.Carregar_Criterio()
            Case "N"
        End Select
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Select Case My.Settings.TipoCentral
            Case "E"
            Case "H"
                frmListaCDRs_H.Exportar(cbExportarTipo.SelectedIndex)
            Case "N"
        End Select
    End Sub

    Private Sub btnIniciarPesquisaLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciarPesquisaLoop.Click
        Select Case My.Settings.TipoCentral
            Case "E"
            Case "H"
                txtApartirDe.Text = frmListaCDRs_H.LocalizaLoop(Val(txtApartirDe.Text))
            Case "N"
        End Select
    End Sub

    Private Sub chkMostrarPainel_CheckedChanged(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.CheckBoxChangeEventArgs) Handles chkMostrarPainel.CheckedChanged
        Select Case My.Settings.TipoCentral
            Case "E"
            Case "H"
                frmListaCDRs_H.expandableSplitter1.Expanded = Not chkMostrarPainel.Checked
                frmListaCDRs_H.gvCDRs.OptionsView.ShowGroupPanel = chkMostrarPainel.Checked
            Case "N"
        End Select
    End Sub

    Private Sub AtualizaParametrosListaCDRs()
        Select Case My.Settings.TipoCentral
            Case "E"
            Case "H"
                If frmListaCDRs_H.flagAtualizaSQL Then
                    frmListaCDRs_H.DataInicio = dtpDataInicio.Value.Date
                    frmListaCDRs_H.HoraInicio = String.Format("{0:hh:mm:ss}", teHoraInicio.Text)
                    frmListaCDRs_H.DataFim = dtpDataFim.Value.Date
                    frmListaCDRs_H.HoraFim = String.Format("{0:hh:mm:ss}", teHoraFim.Text)
                    frmListaCDRs_H.LimiteAtivado = chkLimite.Checked
                    frmListaCDRs_H.LimiteValor = txtLimite.Text
                    frmListaCDRs_H.Ordem = cbOrdenar.Text
                    frmListaCDRs_H.Filtro2SQL()
                End If
            Case "N"
        End Select
    End Sub

    Private Sub dtpDataInicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDataInicio.ValueChanged, cbOrdenar.TextChanged, txtLimite.TextChanged
        'dtpDataFim = dtpDataInicio
        AtualizaParametrosListaCDRs()
    End Sub

    Private Sub teHoraInicio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teHoraInicio.TextChanged, teHoraFim.TextChanged
        AtualizaParametrosListaCDRs()
    End Sub

    Private Sub chkLimite_CheckedChanged(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.CheckBoxChangeEventArgs) Handles chkLimite.CheckedChanged
        AtualizaParametrosListaCDRs()
    End Sub

    Private Sub btnLimparGrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimparGrade.Click
        Select Case My.Settings.TipoCentral
            Case "E"
            Case "H"
                frmListaCDRs_H.LimiteValor = 0
                frmListaCDRs_H.LimiteAtivado = True
                frmListaCDRs_H.Filtro2SQL()
                frmListaCDRs_H.Processar()
                AtualizaParametrosListaCDRs()
            Case "N"
        End Select
    End Sub

End Class
