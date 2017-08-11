Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Rendering
Imports DevExpress.XtraExport
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Export
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UserDesigner
Imports DevExpress.XtraPrinting

Public Class frmPrincipal
    'Inherits DevComponents.DotNetBar.Office2007RibbonForm
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm


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
    Friend WithEvents ButtonItem25 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonPrint As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents menuFileContainer As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents menuFileTwoColumnContainer As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents menuFileItems As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ButtonFile As DevComponents.DotNetBar.Office2007StartButton
    Friend WithEvents ItemContainerPrincipal As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents lblUsuario As DevComponents.DotNetBar.LabelItem
    Friend WithEvents lblMensRegistros As DevComponents.DotNetBar.LabelItem
    Friend WithEvents AppCommandTheme As DevComponents.DotNetBar.Command
    Friend WithEvents buttonChangeStyle As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonStyleOffice2007Blue As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonStyleOffice2007Black As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonStyleOffice2007Silver As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonStyleCustom As DevComponents.DotNetBar.ColorPickerDropDown
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents tabStrip1 As DevComponents.DotNetBar.TabStrip
    Friend WithEvents RibbonTabItemGroup1 As DevComponents.DotNetBar.RibbonTabItemGroup
    Public WithEvents btnNovaCategoria As DevComponents.DotNetBar.ButtonItem
    Public WithEvents btnEditarCat As DevComponents.DotNetBar.ButtonItem
    Public WithEvents btnExcluirCat As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnProgTransferencia As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnNovaContaPagar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnNovaContaReceber As DevComponents.DotNetBar.ButtonItem
    Public WithEvents btnDepositar As DevComponents.DotNetBar.ButtonItem
    Public WithEvents ButtonItemPagar As DevComponents.DotNetBar.ButtonItem
    Public WithEvents ButtonItemTransferir As DevComponents.DotNetBar.ButtonItem
    Public WithEvents ButtonItemReconciliar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents QatCustomizeItem1 As DevComponents.DotNetBar.QatCustomizeItem
    Friend WithEvents chkMostrarPainel As DevComponents.DotNetBar.CheckBoxItem
    Public WithEvents ButtonItemEditar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ItemContainer1 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ButtonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem8 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem9 As DevComponents.DotNetBar.ButtonItem
    Public WithEvents ButtonItemsalvarAnexo As DevComponents.DotNetBar.ButtonItem
    Public WithEvents ButtonItemExcluir As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ItemContainer2 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ButtonItemCompensado As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItemCancelado As DevComponents.DotNetBar.ButtonItem
    Public WithEvents ButtonItemImportarExtrato As DevComponents.DotNetBar.ButtonItem
    Private WithEvents ButtonItemImportarCSV As DevComponents.DotNetBar.ButtonItem
    Public WithEvents ButtonItemExportarXLS As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItemNovoItem As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItemClientes As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItemFornecedores As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItemColaboradores As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItemRecibos As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItemBackup As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItemRestaurar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItemNovaConta As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItemEditarConta As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItemExcluirConta As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ItemContainer3 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ButtonItemAgrupamento As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItemEscolherColunas As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ItemContainer4 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents CheckBoxItem1 As DevComponents.DotNetBar.CheckBoxItem
    Friend WithEvents btnNovo As DevComponents.DotNetBar.ButtonItem
    Public WithEvents btnEditar As DevComponents.DotNetBar.ButtonItem
    Public WithEvents btnExcluir As DevComponents.DotNetBar.ButtonItem
    Public WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Public WithEvents ButtonItem6 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ItemContainer5 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents CheckBoxItem2 As DevComponents.DotNetBar.CheckBoxItem
    Friend WithEvents CheckBoxItem3 As DevComponents.DotNetBar.CheckBoxItem
    Public WithEvents btnClientes As DevComponents.DotNetBar.ButtonItem
    Public WithEvents btnFornecedores As DevComponents.DotNetBar.ButtonItem
    Public WithEvents btnColaboradores As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents cbExportarTipo As DevComponents.DotNetBar.ComboBoxItem
    Friend WithEvents HTML As DevComponents.Editors.ComboItem
    Friend WithEvents XML As DevComponents.Editors.ComboItem
    Friend WithEvents XLX As DevComponents.Editors.ComboItem
    Friend WithEvents XLS As DevComponents.Editors.ComboItem
    Friend WithEvents RTF As DevComponents.Editors.ComboItem
    Friend WithEvents PDF As DevComponents.Editors.ComboItem
    Friend WithEvents MHT As DevComponents.Editors.ComboItem
    Friend WithEvents TXT As DevComponents.Editors.ComboItem
    Friend WithEvents ItemContainer6 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents txtPesquisa As DevComponents.DotNetBar.TextBoxItem
    Friend WithEvents btnPesquisa As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ItemContainer7 As DevComponents.DotNetBar.ItemContainer
    Public WithEvents chkContasAPagar As DevComponents.DotNetBar.CheckBoxItem
    Public WithEvents chkContasAReceber As DevComponents.DotNetBar.CheckBoxItem
    Public WithEvents chkLancamentos As DevComponents.DotNetBar.CheckBoxItem
    Friend WithEvents ItemContainer8 As DevComponents.DotNetBar.ItemContainer
    Public WithEvents chkClientes As DevComponents.DotNetBar.CheckBoxItem
    Public WithEvents chkColaboradores As DevComponents.DotNetBar.CheckBoxItem
    Public WithEvents chkFornecedores As DevComponents.DotNetBar.CheckBoxItem
    Friend WithEvents ButtonItemAproximar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItemAfastar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ItemContainer9 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents btnPrimeiraPag As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnPagAnterior As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnProximaPag As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnUltimaPag As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents chkBarra As DevComponents.DotNetBar.CheckBoxItem
    Friend WithEvents ItemContainer10 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents chkPainelLateral As DevComponents.DotNetBar.CheckBoxItem
    Friend WithEvents ButtonItemFavoritos As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnImprimir As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonTabItemGroup2 As DevComponents.DotNetBar.RibbonTabItemGroup
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.barStatus = New DevComponents.DotNetBar.Bar()
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.lblMensRegistros = New DevComponents.DotNetBar.LabelItem()
        Me.ItemContainerPrincipal = New DevComponents.DotNetBar.ItemContainer()
        Me.labelStatus = New DevComponents.DotNetBar.LabelItem()
        Me.lblUsuario = New DevComponents.DotNetBar.LabelItem()
        Me.ribbonControl1 = New DevComponents.DotNetBar.RibbonControl()
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
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem4 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonPrint = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem25 = New DevComponents.DotNetBar.ButtonItem()
        Me.QatCustomizeItem1 = New DevComponents.DotNetBar.QatCustomizeItem()
        Me.RibbonTabItemGroup1 = New DevComponents.DotNetBar.RibbonTabItemGroup()
        Me.RibbonTabItemGroup2 = New DevComponents.DotNetBar.RibbonTabItemGroup()
        Me.ButtonItemRecibos = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemBackup = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemRestaurar = New DevComponents.DotNetBar.ButtonItem()
        Me.btnNovaContaReceber = New DevComponents.DotNetBar.ButtonItem()
        Me.btnNovaContaPagar = New DevComponents.DotNetBar.ButtonItem()
        Me.btnProgTransferencia = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemNovoItem = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemClientes = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemFornecedores = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemColaboradores = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemFavoritos = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemAproximar = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemAfastar = New DevComponents.DotNetBar.ButtonItem()
        Me.ItemContainer9 = New DevComponents.DotNetBar.ItemContainer()
        Me.btnPrimeiraPag = New DevComponents.DotNetBar.ButtonItem()
        Me.btnPagAnterior = New DevComponents.DotNetBar.ButtonItem()
        Me.btnProximaPag = New DevComponents.DotNetBar.ButtonItem()
        Me.btnUltimaPag = New DevComponents.DotNetBar.ButtonItem()
        Me.ItemContainer10 = New DevComponents.DotNetBar.ItemContainer()
        Me.chkBarra = New DevComponents.DotNetBar.CheckBoxItem()
        Me.chkPainelLateral = New DevComponents.DotNetBar.CheckBoxItem()
        Me.btnImprimir = New DevComponents.DotNetBar.ButtonItem()
        Me.ItemContainer4 = New DevComponents.DotNetBar.ItemContainer()
        Me.chkMostrarPainel = New DevComponents.DotNetBar.CheckBoxItem()
        Me.CheckBoxItem1 = New DevComponents.DotNetBar.CheckBoxItem()
        Me.ButtonItemImportarExtrato = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemImportarCSV = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemExportarXLS = New DevComponents.DotNetBar.ButtonItem()
        Me.cbExportarTipo = New DevComponents.DotNetBar.ComboBoxItem()
        Me.HTML = New DevComponents.Editors.ComboItem()
        Me.XML = New DevComponents.Editors.ComboItem()
        Me.XLX = New DevComponents.Editors.ComboItem()
        Me.XLS = New DevComponents.Editors.ComboItem()
        Me.RTF = New DevComponents.Editors.ComboItem()
        Me.PDF = New DevComponents.Editors.ComboItem()
        Me.MHT = New DevComponents.Editors.ComboItem()
        Me.TXT = New DevComponents.Editors.ComboItem()
        Me.ItemContainer2 = New DevComponents.DotNetBar.ItemContainer()
        Me.ButtonItemCompensado = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemCancelado = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemEditar = New DevComponents.DotNetBar.ButtonItem()
        Me.ItemContainer1 = New DevComponents.DotNetBar.ItemContainer()
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem8 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem9 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemsalvarAnexo = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemExcluir = New DevComponents.DotNetBar.ButtonItem()
        Me.btnDepositar = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemPagar = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemTransferir = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemReconciliar = New DevComponents.DotNetBar.ButtonItem()
        Me.ItemContainer3 = New DevComponents.DotNetBar.ItemContainer()
        Me.ButtonItemAgrupamento = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemEscolherColunas = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemNovaConta = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemEditarConta = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItemExcluirConta = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.btnNovaCategoria = New DevComponents.DotNetBar.ButtonItem()
        Me.btnEditarCat = New DevComponents.DotNetBar.ButtonItem()
        Me.btnExcluirCat = New DevComponents.DotNetBar.ButtonItem()
        Me.ItemContainer7 = New DevComponents.DotNetBar.ItemContainer()
        Me.chkContasAPagar = New DevComponents.DotNetBar.CheckBoxItem()
        Me.chkContasAReceber = New DevComponents.DotNetBar.CheckBoxItem()
        Me.chkLancamentos = New DevComponents.DotNetBar.CheckBoxItem()
        Me.ItemContainer8 = New DevComponents.DotNetBar.ItemContainer()
        Me.chkClientes = New DevComponents.DotNetBar.CheckBoxItem()
        Me.chkFornecedores = New DevComponents.DotNetBar.CheckBoxItem()
        Me.chkColaboradores = New DevComponents.DotNetBar.CheckBoxItem()
        Me.ItemContainer6 = New DevComponents.DotNetBar.ItemContainer()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.txtPesquisa = New DevComponents.DotNetBar.TextBoxItem()
        Me.btnPesquisa = New DevComponents.DotNetBar.ButtonItem()
        Me.btnClientes = New DevComponents.DotNetBar.ButtonItem()
        Me.btnFornecedores = New DevComponents.DotNetBar.ButtonItem()
        Me.btnColaboradores = New DevComponents.DotNetBar.ButtonItem()
        Me.ItemContainer5 = New DevComponents.DotNetBar.ItemContainer()
        Me.CheckBoxItem2 = New DevComponents.DotNetBar.CheckBoxItem()
        Me.CheckBoxItem3 = New DevComponents.DotNetBar.CheckBoxItem()
        Me.btnNovo = New DevComponents.DotNetBar.ButtonItem()
        Me.btnEditar = New DevComponents.DotNetBar.ButtonItem()
        Me.btnExcluir = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem6 = New DevComponents.DotNetBar.ButtonItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.tabStrip1 = New DevComponents.DotNetBar.TabStrip()
        CType(Me.barStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barStatus.SuspendLayout()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.barStatus.Controls.Add(Me.ProgressBarControl1)
        Me.barStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barStatus.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.ResizeHandle
        Me.barStatus.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.lblMensRegistros, Me.ItemContainerPrincipal, Me.labelStatus, Me.lblUsuario})
        Me.barStatus.ItemSpacing = 2
        Me.barStatus.Location = New System.Drawing.Point(0, 339)
        Me.barStatus.Name = "barStatus"
        Me.barStatus.Size = New System.Drawing.Size(1063, 27)
        Me.barStatus.Stretch = True
        Me.barStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.barStatus.TabIndex = 9
        Me.barStatus.TabStop = False
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Location = New System.Drawing.Point(0, 6)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Size = New System.Drawing.Size(1051, 20)
        Me.ProgressBarControl1.TabIndex = 0
        Me.ProgressBarControl1.Visible = False
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
        Me.ribbonControl1.CaptionVisible = True
        Me.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ribbonControl1.EnableQatPlacement = False
        Me.ribbonControl1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonChangeStyle})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MdiSystemItemVisible = False
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black
        Me.ribbonControl1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.ribbonControl1.QuickToolbarItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonFile, Me.QatCustomizeItem1})
        Me.ribbonControl1.Size = New System.Drawing.Size(1063, 91)
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
        Me.ribbonControl1.TabGroups.AddRange(New DevComponents.DotNetBar.RibbonTabItemGroup() {Me.RibbonTabItemGroup1, Me.RibbonTabItemGroup2})
        Me.ribbonControl1.TabIndex = 0
        Me.ribbonControl1.Text = "gf"
        Me.ribbonControl1.TitleText = "gf-Gestor Financeira"
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
        Me.ButtonFile.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_11
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
        Me.menuFileItems.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem3, Me.ButtonItem4, Me.buttonPrint, Me.ButtonItem25})
        '
        'ButtonItem3
        '
        Me.ButtonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem3.Image = CType(resources.GetObject("ButtonItem3.Image"), System.Drawing.Image)
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.Text = "Contr. Produção"
        Me.ButtonItem3.Tooltip = "Controle da produção"
        '
        'ButtonItem4
        '
        Me.ButtonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem4.Icon = CType(resources.GetObject("ButtonItem4.Icon"), System.Drawing.Icon)
        Me.ButtonItem4.Name = "ButtonItem4"
        Me.ButtonItem4.SubItemsExpandWidth = 14
        Me.ButtonItem4.Text = "Entrada/Saída"
        Me.ButtonItem4.Tooltip = "Entrada/Saída"
        '
        'buttonPrint
        '
        Me.buttonPrint.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.buttonPrint.Image = CType(resources.GetObject("buttonPrint.Image"), System.Drawing.Image)
        Me.buttonPrint.Name = "buttonPrint"
        Me.buttonPrint.SubItemsExpandWidth = 24
        Me.buttonPrint.Text = "&Impressão..."
        Me.buttonPrint.Tooltip = "Listagens"
        '
        'ButtonItem25
        '
        Me.ButtonItem25.BeginGroup = True
        Me.ButtonItem25.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem25.Image = CType(resources.GetObject("ButtonItem25.Image"), System.Drawing.Image)
        Me.ButtonItem25.Name = "ButtonItem25"
        Me.ButtonItem25.SubItemsExpandWidth = 24
        Me.ButtonItem25.Text = "&Sair do Programa"
        Me.ButtonItem25.Tooltip = "Sair do programa"
        '
        'QatCustomizeItem1
        '
        Me.QatCustomizeItem1.Name = "QatCustomizeItem1"
        '
        'RibbonTabItemGroup1
        '
        Me.RibbonTabItemGroup1.GroupTitle = "New Group"
        Me.RibbonTabItemGroup1.Name = "RibbonTabItemGroup1"
        '
        '
        '
        Me.RibbonTabItemGroup1.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.RibbonTabItemGroup1.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.RibbonTabItemGroup1.Style.BackColorGradientAngle = 90
        Me.RibbonTabItemGroup1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.RibbonTabItemGroup1.Style.BorderBottomWidth = 1
        Me.RibbonTabItemGroup1.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.RibbonTabItemGroup1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.RibbonTabItemGroup1.Style.BorderLeftWidth = 1
        Me.RibbonTabItemGroup1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.RibbonTabItemGroup1.Style.BorderRightWidth = 1
        Me.RibbonTabItemGroup1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.RibbonTabItemGroup1.Style.BorderTopWidth = 1
        Me.RibbonTabItemGroup1.Style.Class = ""
        Me.RibbonTabItemGroup1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonTabItemGroup1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.RibbonTabItemGroup1.Style.TextColor = System.Drawing.Color.White
        Me.RibbonTabItemGroup1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.RibbonTabItemGroup1.Style.TextShadowColor = System.Drawing.Color.Black
        Me.RibbonTabItemGroup1.Style.TextShadowOffset = New System.Drawing.Point(1, 1)
        '
        'RibbonTabItemGroup2
        '
        Me.RibbonTabItemGroup2.GroupTitle = "New Group"
        Me.RibbonTabItemGroup2.Name = "RibbonTabItemGroup2"
        '
        '
        '
        Me.RibbonTabItemGroup2.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.RibbonTabItemGroup2.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.RibbonTabItemGroup2.Style.BackColorGradientAngle = 90
        Me.RibbonTabItemGroup2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.RibbonTabItemGroup2.Style.BorderBottomWidth = 1
        Me.RibbonTabItemGroup2.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.RibbonTabItemGroup2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.RibbonTabItemGroup2.Style.BorderLeftWidth = 1
        Me.RibbonTabItemGroup2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.RibbonTabItemGroup2.Style.BorderRightWidth = 1
        Me.RibbonTabItemGroup2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.RibbonTabItemGroup2.Style.BorderTopWidth = 1
        Me.RibbonTabItemGroup2.Style.Class = ""
        Me.RibbonTabItemGroup2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonTabItemGroup2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.RibbonTabItemGroup2.Style.TextColor = System.Drawing.Color.White
        Me.RibbonTabItemGroup2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.RibbonTabItemGroup2.Style.TextShadowColor = System.Drawing.Color.Black
        Me.RibbonTabItemGroup2.Style.TextShadowOffset = New System.Drawing.Point(1, 1)
        '
        'ButtonItemRecibos
        '
        Me.ButtonItemRecibos.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemRecibos.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.ButtonItemRecibos.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItemRecibos.Name = "ButtonItemRecibos"
        Me.ButtonItemRecibos.Text = "Recibos"
        '
        'ButtonItemBackup
        '
        Me.ButtonItemBackup.BeginGroup = True
        Me.ButtonItemBackup.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemBackup.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.ButtonItemBackup.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItemBackup.Name = "ButtonItemBackup"
        Me.ButtonItemBackup.Text = "Backup"
        '
        'ButtonItemRestaurar
        '
        Me.ButtonItemRestaurar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemRestaurar.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.ButtonItemRestaurar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItemRestaurar.Name = "ButtonItemRestaurar"
        Me.ButtonItemRestaurar.Text = "Restaurar Backup"
        '
        'btnNovaContaReceber
        '
        Me.btnNovaContaReceber.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnNovaContaReceber.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.btnNovaContaReceber.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnNovaContaReceber.Name = "btnNovaContaReceber"
        Me.btnNovaContaReceber.Text = "Nova Conta  a Receber"
        Me.btnNovaContaReceber.Tooltip = "Cadastrar nova conta a receber"
        '
        'btnNovaContaPagar
        '
        Me.btnNovaContaPagar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnNovaContaPagar.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.btnNovaContaPagar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnNovaContaPagar.Name = "btnNovaContaPagar"
        Me.btnNovaContaPagar.SubItemsExpandWidth = 14
        Me.btnNovaContaPagar.Text = "Nova Conta a Pagar"
        Me.btnNovaContaPagar.Tooltip = "Cadastrar nova conta a pagar"
        '
        'btnProgTransferencia
        '
        Me.btnProgTransferencia.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnProgTransferencia.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.btnProgTransferencia.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnProgTransferencia.Name = "btnProgTransferencia"
        Me.btnProgTransferencia.SubItemsExpandWidth = 14
        Me.btnProgTransferencia.Text = "Programar Transferência"
        Me.btnProgTransferencia.Tooltip = "Programar transferência entre contas"
        '
        'ButtonItemNovoItem
        '
        Me.ButtonItemNovoItem.BeginGroup = True
        Me.ButtonItemNovoItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemNovoItem.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.ButtonItemNovoItem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItemNovoItem.Name = "ButtonItemNovoItem"
        Me.ButtonItemNovoItem.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItemClientes, Me.ButtonItemFornecedores, Me.ButtonItemColaboradores})
        Me.ButtonItemNovoItem.Text = "Novo Ítem"
        Me.ButtonItemNovoItem.Tooltip = "Cadastrar novo ítem (cliente, fornecedor ou colaborador)"
        '
        'ButtonItemClientes
        '
        Me.ButtonItemClientes.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.ButtonItemClientes.Name = "ButtonItemClientes"
        Me.ButtonItemClientes.Text = "Clientes"
        '
        'ButtonItemFornecedores
        '
        Me.ButtonItemFornecedores.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.ButtonItemFornecedores.Name = "ButtonItemFornecedores"
        Me.ButtonItemFornecedores.Text = "Fornecedores"
        '
        'ButtonItemColaboradores
        '
        Me.ButtonItemColaboradores.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.ButtonItemColaboradores.Name = "ButtonItemColaboradores"
        Me.ButtonItemColaboradores.Text = "Colaboradores"
        '
        'ButtonItemFavoritos
        '
        Me.ButtonItemFavoritos.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemFavoritos.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.ButtonItemFavoritos.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItemFavoritos.Name = "ButtonItemFavoritos"
        Me.ButtonItemFavoritos.Text = "Adicionar aos Favoritos"
        Me.ButtonItemFavoritos.Tooltip = "Cadastrar nova conta"
        '
        'ButtonItemAproximar
        '
        Me.ButtonItemAproximar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemAproximar.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.ButtonItemAproximar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItemAproximar.Name = "ButtonItemAproximar"
        Me.ButtonItemAproximar.Text = "Aproximar"
        Me.ButtonItemAproximar.Tooltip = "Cadastrar nova conta"
        '
        'ButtonItemAfastar
        '
        Me.ButtonItemAfastar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemAfastar.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.ButtonItemAfastar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItemAfastar.Name = "ButtonItemAfastar"
        Me.ButtonItemAfastar.Text = "Afastar"
        Me.ButtonItemAfastar.Tooltip = "Cadastrar nova conta"
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
        'btnImprimir
        '
        Me.btnImprimir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnImprimir.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.btnImprimir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.Tooltip = "Imprimir o relatório selecionado"
        '
        'ItemContainer4
        '
        '
        '
        '
        Me.ItemContainer4.BackgroundStyle.Class = ""
        Me.ItemContainer4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer4.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer4.Name = "ItemContainer4"
        Me.ItemContainer4.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.chkMostrarPainel, Me.CheckBoxItem1})
        Me.ItemContainer4.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle
        '
        'chkMostrarPainel
        '
        Me.chkMostrarPainel.Name = "chkMostrarPainel"
        Me.chkMostrarPainel.Text = "Mostrar Painel Grupo"
        '
        'CheckBoxItem1
        '
        Me.CheckBoxItem1.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
        Me.CheckBoxItem1.Name = "CheckBoxItem1"
        Me.CheckBoxItem1.ShowSubItems = False
        Me.CheckBoxItem1.Text = "Escolher Colunas"
        '
        'ButtonItemImportarExtrato
        '
        Me.ButtonItemImportarExtrato.BeginGroup = True
        Me.ButtonItemImportarExtrato.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemImportarExtrato.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.ButtonItemImportarExtrato.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItemImportarExtrato.Name = "ButtonItemImportarExtrato"
        Me.ButtonItemImportarExtrato.Text = "Importar Extrato (OFX, OFC ou QIF)"
        '
        'ButtonItemImportarCSV
        '
        Me.ButtonItemImportarCSV.BeginGroup = True
        Me.ButtonItemImportarCSV.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemImportarCSV.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.ButtonItemImportarCSV.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItemImportarCSV.Name = "ButtonItemImportarCSV"
        Me.ButtonItemImportarCSV.Text = "Importar CSV"
        '
        'ButtonItemExportarXLS
        '
        Me.ButtonItemExportarXLS.BeginGroup = True
        Me.ButtonItemExportarXLS.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemExportarXLS.FixedSize = New System.Drawing.Size(80, 50)
        Me.ButtonItemExportarXLS.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.ButtonItemExportarXLS.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItemExportarXLS.Name = "ButtonItemExportarXLS"
        Me.ButtonItemExportarXLS.Text = "Exportar"
        Me.ButtonItemExportarXLS.Tooltip = "Exportar os dados da grade."
        '
        'cbExportarTipo
        '
        Me.cbExportarTipo.Caption = "XLS"
        Me.cbExportarTipo.DropDownHeight = 106
        Me.cbExportarTipo.Items.AddRange(New Object() {Me.HTML, Me.XML, Me.XLX, Me.XLS, Me.RTF, Me.PDF, Me.MHT, Me.TXT})
        Me.cbExportarTipo.Name = "cbExportarTipo"
        Me.cbExportarTipo.Text = "XLS"
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
        'ItemContainer2
        '
        '
        '
        '
        Me.ItemContainer2.BackgroundStyle.Class = ""
        Me.ItemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer2.Name = "ItemContainer2"
        Me.ItemContainer2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItemCompensado, Me.ButtonItemCancelado})
        '
        'ButtonItemCompensado
        '
        Me.ButtonItemCompensado.Name = "ButtonItemCompensado"
        Me.ButtonItemCompensado.Text = "Compensado"
        '
        'ButtonItemCancelado
        '
        Me.ButtonItemCancelado.Name = "ButtonItemCancelado"
        Me.ButtonItemCancelado.Text = "Cancelado"
        '
        'ButtonItemEditar
        '
        Me.ButtonItemEditar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemEditar.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.ButtonItemEditar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItemEditar.Name = "ButtonItemEditar"
        Me.ButtonItemEditar.Text = "Editar"
        Me.ButtonItemEditar.Tooltip = "Cadastrar novo pagamento <ctrl> P"
        '
        'ItemContainer1
        '
        '
        '
        '
        Me.ItemContainer1.BackgroundStyle.Class = ""
        Me.ItemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer1.BeginGroup = True
        Me.ItemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer1.Name = "ItemContainer1"
        Me.ItemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem5, Me.ButtonItem8, Me.ButtonItem9})
        '
        'ButtonItem5
        '
        Me.ButtonItem5.Name = "ButtonItem5"
        Me.ButtonItem5.Text = "Mover Para Conta"
        '
        'ButtonItem8
        '
        Me.ButtonItem8.Name = "ButtonItem8"
        Me.ButtonItem8.Text = "Associar com Conta a Receber"
        '
        'ButtonItem9
        '
        Me.ButtonItem9.Name = "ButtonItem9"
        Me.ButtonItem9.Text = "Associar com Transf. Programada"
        '
        'ButtonItemsalvarAnexo
        '
        Me.ButtonItemsalvarAnexo.BeginGroup = True
        Me.ButtonItemsalvarAnexo.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemsalvarAnexo.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.ButtonItemsalvarAnexo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItemsalvarAnexo.Name = "ButtonItemsalvarAnexo"
        Me.ButtonItemsalvarAnexo.Text = "Salvar Anexo"
        Me.ButtonItemsalvarAnexo.Tooltip = "Cadastrar novo pagamento <ctrl> P"
        '
        'ButtonItemExcluir
        '
        Me.ButtonItemExcluir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemExcluir.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.ButtonItemExcluir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItemExcluir.Name = "ButtonItemExcluir"
        Me.ButtonItemExcluir.Text = "Excluir"
        Me.ButtonItemExcluir.Tooltip = "Cadastrar novo pagamento <ctrl> P"
        '
        'btnDepositar
        '
        Me.btnDepositar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnDepositar.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.btnDepositar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnDepositar.Name = "btnDepositar"
        Me.btnDepositar.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2)
        Me.btnDepositar.Text = "Depositar"
        Me.btnDepositar.Tooltip = "Depositar <CTRL + D>"
        '
        'ButtonItemPagar
        '
        Me.ButtonItemPagar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemPagar.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.ButtonItemPagar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItemPagar.Name = "ButtonItemPagar"
        Me.ButtonItemPagar.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlP)
        Me.ButtonItemPagar.Text = "Pagar"
        Me.ButtonItemPagar.Tooltip = "Cadastrar novo pagamento <ctrl> P"
        '
        'ButtonItemTransferir
        '
        Me.ButtonItemTransferir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemTransferir.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
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
        Me.ButtonItemReconciliar.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.ButtonItemReconciliar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItemReconciliar.Name = "ButtonItemReconciliar"
        Me.ButtonItemReconciliar.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2)
        Me.ButtonItemReconciliar.Text = "Reconciliar"
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
        'ButtonItemNovaConta
        '
        Me.ButtonItemNovaConta.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemNovaConta.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.ButtonItemNovaConta.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItemNovaConta.Name = "ButtonItemNovaConta"
        Me.ButtonItemNovaConta.Text = "Nova Conta"
        Me.ButtonItemNovaConta.Tooltip = "Cadastrar nova conta"
        '
        'ButtonItemEditarConta
        '
        Me.ButtonItemEditarConta.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemEditarConta.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.ButtonItemEditarConta.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItemEditarConta.Name = "ButtonItemEditarConta"
        Me.ButtonItemEditarConta.SubItemsExpandWidth = 14
        Me.ButtonItemEditarConta.Text = "Editar"
        Me.ButtonItemEditarConta.Tooltip = "Alterar a conta selecionada"
        '
        'ButtonItemExcluirConta
        '
        Me.ButtonItemExcluirConta.BeginGroup = True
        Me.ButtonItemExcluirConta.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItemExcluirConta.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.ButtonItemExcluirConta.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItemExcluirConta.Name = "ButtonItemExcluirConta"
        Me.ButtonItemExcluirConta.SubItemsExpandWidth = 14
        Me.ButtonItemExcluirConta.Text = "Excluir"
        Me.ButtonItemExcluirConta.Tooltip = "Apagar a conta selecionada"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.BeginGroup = True
        Me.ButtonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem1.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.ButtonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.SubItemsExpandWidth = 14
        Me.ButtonItem1.Text = "Exportar para MS Excel"
        Me.ButtonItem1.Tooltip = "Apagar a conta selecionada"
        '
        'btnNovaCategoria
        '
        Me.btnNovaCategoria.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnNovaCategoria.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.btnNovaCategoria.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnNovaCategoria.Name = "btnNovaCategoria"
        Me.btnNovaCategoria.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN)
        Me.btnNovaCategoria.Text = "Nova Categoria"
        Me.btnNovaCategoria.Tooltip = "Cadastrar nova caategoria"
        '
        'btnEditarCat
        '
        Me.btnEditarCat.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnEditarCat.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.btnEditarCat.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnEditarCat.Name = "btnEditarCat"
        Me.btnEditarCat.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlE)
        Me.btnEditarCat.SubItemsExpandWidth = 14
        Me.btnEditarCat.Text = "Editar"
        Me.btnEditarCat.Tooltip = "Alterar a categoria selecionada"
        '
        'btnExcluirCat
        '
        Me.btnExcluirCat.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnExcluirCat.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.btnExcluirCat.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnExcluirCat.Name = "btnExcluirCat"
        Me.btnExcluirCat.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlDel)
        Me.btnExcluirCat.SubItemsExpandWidth = 14
        Me.btnExcluirCat.Text = "Excluir"
        Me.btnExcluirCat.Tooltip = "Excluir a categoria selecionada"
        '
        'ItemContainer7
        '
        '
        '
        '
        Me.ItemContainer7.BackgroundStyle.Class = ""
        Me.ItemContainer7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer7.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer7.Name = "ItemContainer7"
        Me.ItemContainer7.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.chkContasAPagar, Me.chkContasAReceber, Me.chkLancamentos})
        '
        'chkContasAPagar
        '
        Me.chkContasAPagar.Checked = True
        Me.chkContasAPagar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkContasAPagar.Name = "chkContasAPagar"
        Me.chkContasAPagar.Text = "Contas a Pagar"
        '
        'chkContasAReceber
        '
        Me.chkContasAReceber.Checked = True
        Me.chkContasAReceber.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkContasAReceber.Name = "chkContasAReceber"
        Me.chkContasAReceber.Text = "Contas a Receber"
        '
        'chkLancamentos
        '
        Me.chkLancamentos.Checked = True
        Me.chkLancamentos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLancamentos.Name = "chkLancamentos"
        Me.chkLancamentos.Text = "Lançamentos"
        '
        'ItemContainer8
        '
        '
        '
        '
        Me.ItemContainer8.BackgroundStyle.Class = ""
        Me.ItemContainer8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer8.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer8.Name = "ItemContainer8"
        Me.ItemContainer8.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.chkClientes, Me.chkFornecedores, Me.chkColaboradores})
        '
        'chkClientes
        '
        Me.chkClientes.Checked = True
        Me.chkClientes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkClientes.Name = "chkClientes"
        Me.chkClientes.Text = "Clientes"
        '
        'chkFornecedores
        '
        Me.chkFornecedores.Checked = True
        Me.chkFornecedores.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFornecedores.Name = "chkFornecedores"
        Me.chkFornecedores.Text = "Fornecedores"
        '
        'chkColaboradores
        '
        Me.chkColaboradores.Checked = True
        Me.chkColaboradores.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkColaboradores.Name = "chkColaboradores"
        Me.chkColaboradores.Text = "Colaboradores"
        '
        'ItemContainer6
        '
        '
        '
        '
        Me.ItemContainer6.BackgroundStyle.Class = ""
        Me.ItemContainer6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer6.Name = "ItemContainer6"
        Me.ItemContainer6.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.LabelItem1, Me.txtPesquisa, Me.btnPesquisa})
        '
        'LabelItem1
        '
        Me.LabelItem1.Name = "LabelItem1"
        Me.LabelItem1.Text = "Pesquisar por:"
        '
        'txtPesquisa
        '
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.TextBoxWidth = 200
        Me.txtPesquisa.WatermarkColor = System.Drawing.SystemColors.GrayText
        Me.txtPesquisa.WatermarkText = "informe o que pesquisar"
        '
        'btnPesquisa
        '
        Me.btnPesquisa.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnPesquisa.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.btnPesquisa.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnPesquisa.Name = "btnPesquisa"
        Me.btnPesquisa.Text = "Pesquisar"
        '
        'btnClientes
        '
        Me.btnClientes.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnClientes.Checked = True
        Me.btnClientes.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.btnClientes.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.OptionGroup = "cadastro"
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.Tooltip = "Cadastro de Clientes"
        '
        'btnFornecedores
        '
        Me.btnFornecedores.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnFornecedores.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.btnFornecedores.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnFornecedores.Name = "btnFornecedores"
        Me.btnFornecedores.OptionGroup = "cadastro"
        Me.btnFornecedores.Text = "Fornecedores"
        Me.btnFornecedores.Tooltip = "Seleciona os Fornecedores"
        '
        'btnColaboradores
        '
        Me.btnColaboradores.BeginGroup = True
        Me.btnColaboradores.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnColaboradores.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.btnColaboradores.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnColaboradores.Name = "btnColaboradores"
        Me.btnColaboradores.OptionGroup = "cadastro"
        Me.btnColaboradores.Text = "Colaboradores"
        Me.btnColaboradores.Tooltip = "Seleciona os Colaboradores"
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
        'btnNovo
        '
        Me.btnNovo.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnNovo.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.btnNovo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2)
        Me.btnNovo.Text = "Novo"
        '
        'btnEditar
        '
        Me.btnEditar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnEditar.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.btnEditar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F3)
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.Tooltip = "Cadastrar novo pagamento <ctrl> P"
        '
        'btnExcluir
        '
        Me.btnExcluir.BeginGroup = True
        Me.btnExcluir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnExcluir.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.btnExcluir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlDel)
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.Tooltip = "Cadastrar novo pagamento <ctrl> P"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.BeginGroup = True
        Me.ButtonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem2.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.ButtonItem2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.Text = "Importar CSV"
        Me.ButtonItem2.Visible = False
        '
        'ButtonItem6
        '
        Me.ButtonItem6.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem6.Image = Global.SpyCdr.My.Resources.Resources.button_showDVD_L
        Me.ButtonItem6.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem6.Name = "ButtonItem6"
        Me.ButtonItem6.Text = "Exportar CSV"
        Me.ButtonItem6.Visible = False
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
        'tabStrip1
        '
        Me.tabStrip1.AutoSelectAttachedControl = True
        Me.tabStrip1.CanReorderTabs = False
        Me.tabStrip1.CloseButtonOnTabsAlwaysDisplayed = False
        Me.tabStrip1.CloseButtonVisible = False
        Me.tabStrip1.Dock = System.Windows.Forms.DockStyle.Top
        Me.tabStrip1.Enabled = False
        Me.tabStrip1.Location = New System.Drawing.Point(0, 91)
        Me.tabStrip1.MdiAutoHide = False
        Me.tabStrip1.Name = "tabStrip1"
        Me.tabStrip1.SelectedTab = Nothing
        Me.tabStrip1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabStrip1.Size = New System.Drawing.Size(1063, 26)
        Me.tabStrip1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document
        Me.tabStrip1.TabIndex = 7
        Me.tabStrip1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.MultilineNoNavigationBox
        Me.tabStrip1.TabStop = False
        Me.tabStrip1.ThemeAware = True
        '
        'frmPrincipal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1063, 366)
        Me.Controls.Add(Me.tabStrip1)
        Me.Controls.Add(Me.ribbonControl1)
        Me.Controls.Add(Me.barStatus)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "gf Getor Financeiro"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.barStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barStatus.ResumeLayout(False)
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    'Private dlgLogin As frmIdentificacao = Nothing


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
        'ribbonControl1.QatFrequentCommands.Add(btnProcessar)
        'ribbonControl1.QatFrequentCommands.Add(btnMenuResumoDiario)
        'ribbonControl1.QatFrequentCommands.Add(btnMenuSair)

        ' Neccessary for Automatic Tab-Strip Mdi support
        ''tabStrip1.MdiForm = Me

        UpdateTitle()

        ' Pulse Application Button
        'ButtonFile.Pulse(11)
        'My.Forms.frmInicio.MdiParent = Me
        'My.Forms.frmInicio.Show()
        'My.Forms.frmInicio.Activate()

        'Me.NotifyIcon1.Visible = False

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
            'Me.NotifyIcon1.Visible = True
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

End Class
