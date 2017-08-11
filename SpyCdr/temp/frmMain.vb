Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Imports System.Diagnostics
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.Gallery
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils
Imports DevExpress.Tutorials.Controls
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.LookAndFeel

Namespace DevExpress.XtraBars.Demos.RibbonSimplePad
    Partial Public Class frmMain
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm
        Public Sub New()
            InitializeComponent()
            CreateColorPopup(popupControlContainer1)
            InitSkinGallery()
            InitFontGallery()
            InitColorGallery()
            InitEditors()
            UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue")
        End Sub

        Private documentIndex As Integer = 0
        Private cp As ColorPopup
        Private dlgFind As frmFind = Nothing
        Private dlgReplace As frmReplace = Nothing
        Private fCurrentFontItem, fCurrentColorItem As GalleryItem
        Private ReadOnly Property DocumentName() As String
            Get
                Return String.Format("New Document {0}", documentIndex)
            End Get
        End Property

        Private Sub CreateNewDocument()
            CreateNewDocument(Nothing)
        End Sub
        Sub InitEditors()
            riicStyle.Items.Add(New ImageComboBoxItem("Office 2007", RibbonControlStyle.Office2007, -1))
            riicStyle.Items.Add(New ImageComboBoxItem("Office 2010", RibbonControlStyle.Office2010, -1))
            biStyle.EditValue = ribbonControl1.RibbonStyle
        End Sub
        Public Sub ShowHideFormatCategory()
            Dim selectionCategory As RibbonPageCategory = TryCast(Ribbon.PageCategories(0), RibbonPageCategory)
            If selectionCategory Is Nothing Then
                Return
            End If
            If CurrentRichTextBox Is Nothing Then
                selectionCategory.Visible = False
            Else
                selectionCategory.Visible = CurrentRichTextBox.SelectionLength <> 0
            End If
            If selectionCategory.Visible Then
                Ribbon.SelectedPage = selectionCategory.Pages(0)
            End If
        End Sub
        Private Sub CreateNewDocument(ByVal fileName As String)
            documentIndex += 1
            Dim pad As frmPad = New frmPad()
            If Not fileName Is Nothing Then
                pad.LoadDocument(fileName)
            Else
                pad.DocName = DocumentName
            End If
            pad.MdiParent = Me
            AddHandler pad.Closed, AddressOf Pad_Closed
            AddHandler pad.ShowPopupMenu, AddressOf Pad_ShowPopupMenu
            pad.Show()
            InitNewDocument(pad.RTBMain)
        End Sub

        Private Sub Pad_Closed(ByVal sender As Object, ByVal e As EventArgs)
            CloseFind()
        End Sub
        Private Sub Pad_ShowPopupMenu(ByVal sender As Object, ByVal e As EventArgs)
            pmMain.ShowPopup(Control.MousePosition)
        End Sub
        Private Sub CloseFind()
            If Not dlgFind Is Nothing AndAlso Not dlgFind.RichText Is CurrentRichTextBox Then
                dlgFind.Close()
                dlgFind = Nothing
            End If
            If Not dlgReplace Is Nothing AndAlso Not dlgReplace.RichText Is CurrentRichTextBox Then
                dlgReplace.Close()
                dlgReplace = Nothing
            End If
        End Sub

        Private Sub CreateColorPopup(ByVal container As PopupControlContainer)
            cp = New ColorPopup(container, iFontColor, Me)
        End Sub
#Region "Init"
        Private Sub frmMain_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
            InitPaste()
        End Sub
        Public Sub UpdateText()
            ribbonControl1.ApplicationCaption = "Ribbon Simple Pad"
            If CurrentModified Then
                ribbonControl1.ApplicationDocumentCaption = CurrentDocName + ("*")
            Else
                ribbonControl1.ApplicationDocumentCaption = CurrentDocName + ("")
            End If
            'Text = string.Format("Ribbon Simple Pad ({0})", CurrentDocName);
            siDocName.Caption = String.Format("  {0}", CurrentDocName)
        End Sub
        Sub ChangeActiveForm()
            UpdateText()
            InitCurrentDocument(CurrentRichTextBox)
            rtPad_SelectionChanged(CurrentRichTextBox, EventArgs.Empty)
            CloseFind()
        End Sub

        Private Sub frmMain_MdiChildActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MdiChildActivate
            ChangeActiveForm()
        End Sub
        Private Sub rtPad_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            ShowHideFormatCategory()
            Dim rtPad As RichTextBox = TryCast(sender, RichTextBox)
            InitFormat()
            Dim line As Integer = 0, col As Integer = 0

            If Not rtPad Is Nothing Then
                InitEdit(rtPad.SelectionLength > 0)
                line = rtPad.GetLineFromCharIndex(rtPad.SelectionStart) + 1
                col = rtPad.SelectionStart + 1
            Else
                InitEdit(False)
            End If
            siPosition.Caption = String.Format("   Line: {0}  Position: {1}   ", line, col)
            CurrentFontChanged()
        End Sub
        Private Sub rtPad_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            If CurrentForm Is Nothing Then
                Return
            End If
            CurrentForm.Modified = True
            InitCurrentDocument(CurrentRichTextBox)
        End Sub

        Protected Sub InitFormat()
            iBold.Enabled = Not SelectFont Is Nothing
            iItalic.Enabled = Not SelectFont Is Nothing
            iUnderline.Enabled = Not SelectFont Is Nothing
            iFont.Enabled = Not SelectFont Is Nothing
            iFontColor.Enabled = Not SelectFont Is Nothing
            If Not SelectFont Is Nothing Then
                iBold.Down = SelectFont.Bold
                iItalic.Down = SelectFont.Italic
                iUnderline.Down = SelectFont.Underline
            End If
            Dim enabled As Boolean = Not CurrentRichTextBox Is Nothing
            iProtected.Enabled = enabled
            iBullets.Enabled = enabled
            iAlignLeft.Enabled = enabled
            iAlignRight.Enabled = enabled
            iCenter.Enabled = enabled
            rgbiFont.Enabled = enabled
            rgbiFontColor.Enabled = enabled
            ribbonPageGroup9.ShowCaptionButton = enabled
            rpgFont.ShowCaptionButton = enabled
            rpgFontColor.ShowCaptionButton = enabled
            If (Not enabled) Then
                ClearFormats()
            End If
            If Not CurrentRichTextBox Is Nothing Then
                iProtected.Down = CurrentRichTextBox.SelectionProtected
                iBullets.Down = CurrentRichTextBox.SelectionBullet
                Select Case CurrentRichTextBox.SelectionAlignment
                    Case HorizontalAlignment.Left
                        iAlignLeft.Down = True
                    Case HorizontalAlignment.Center
                        iCenter.Down = True
                    Case HorizontalAlignment.Right
                        iAlignRight.Down = True
                End Select
            End If
        End Sub

        Private Sub ClearFormats()
            iBold.Down = False
            iItalic.Down = False
            iUnderline.Down = False
            iProtected.Down = False
            iBullets.Down = False
            iAlignLeft.Down = False
            iAlignRight.Down = False
            iCenter.Down = False
        End Sub

        Protected Sub InitPaste()
            Dim enabledPase As Boolean = Not CurrentRichTextBox Is Nothing AndAlso CurrentRichTextBox.CanPaste(DataFormats.GetFormat(0))
            iPaste.Enabled = enabledPase
            sbiPaste.Enabled = enabledPase
        End Sub

        Private Sub InitUndo()
            If Not CurrentRichTextBox Is Nothing Then
                iUndo.Enabled = CurrentRichTextBox.CanUndo
            Else
                iUndo.Enabled = False
            End If
            iLargeUndo.Enabled = iUndo.Enabled
        End Sub
        Protected Sub InitEdit(ByVal enabled As Boolean)
            iCut.Enabled = enabled
            iCopy.Enabled = enabled
            iClear.Enabled = enabled
            If Not CurrentRichTextBox Is Nothing Then
                iSelectAll.Enabled = CurrentRichTextBox.CanSelect
            Else
                iSelectAll.Enabled = False
            End If
            InitUndo()
        End Sub

        Private Sub InitNewDocument(ByVal rtbControl As RichTextBox)
            AddHandler rtbControl.SelectionChanged, AddressOf rtPad_SelectionChanged
            AddHandler rtbControl.TextChanged, AddressOf rtPad_TextChanged
        End Sub

        Private Sub InitCurrentDocument(ByVal rtbControl As RichTextBox)
            Dim enabled As Boolean = Not rtbControl Is Nothing
            iSaveAs.Enabled = enabled
            iClose.Enabled = enabled
            iPrint.Enabled = enabled
            sbiSave.Enabled = enabled
            sbiFind.Enabled = enabled
            iFind.Enabled = enabled
            iReplace.Enabled = enabled
            iSave.Enabled = CurrentModified
            SetModifiedCaption()
            InitPaste()
            InitFormat()
        End Sub

        Private Sub SetModifiedCaption()
            If CurrentForm Is Nothing Then
                siModified.Caption = ""
                Return
            End If
            If CurrentModified Then
                siModified.Caption = "   Modified   "
            Else
                siModified.Caption = ""
            End If
        End Sub
#End Region
#Region "Properties"
        Private ReadOnly Property CurrentForm() As frmPad
            Get
                If Me.ActiveMdiChild Is Nothing Then
                    Return Nothing
                End If
                If Not xtraTabbedMdiManager1.ActiveFloatForm Is Nothing Then
                    Return TryCast(xtraTabbedMdiManager1.ActiveFloatForm, frmPad)
                End If
                Return TryCast(Me.ActiveMdiChild, frmPad)
            End Get
        End Property

        Public ReadOnly Property CurrentRichTextBox() As RichTextBox
            Get
                If CurrentForm Is Nothing Then
                    Return Nothing
                End If
                Return CurrentForm.RTBMain
            End Get
        End Property

        Private ReadOnly Property CurrentDocName() As String
            Get
                If CurrentForm Is Nothing Then
                    Return ""
                End If
                Return CurrentForm.DocName
            End Get
        End Property

        Private ReadOnly Property CurrentModified() As Boolean
            Get
                If CurrentForm Is Nothing Then
                    Return False
                End If
                Return CurrentForm.Modified
            End Get
        End Property
#End Region
#Region "File"
        Private Sub idNew_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles idNew.ItemClick, iNew.ItemClick
            CreateNewDocument()
        End Sub

        Private Sub iClose_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iClose.ItemClick
            If Not CurrentForm Is Nothing Then
                CurrentForm.Close()
            End If
        End Sub

        Private Sub OpenFile()
            Dim dlg As OpenFileDialog = New OpenFileDialog()
            dlg.Filter = "Rich Text Files (*.rtf)|*.rtf"
            dlg.Title = "Open"
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                OpenFile(dlg.FileName)
            End If
        End Sub

        Private Sub OpenFile(ByVal name As String)
            CreateNewDocument(name)
            AddToMostRecentFiles(name, arMRUList)
        End Sub

        Private Sub iOpen_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iOpen.ItemClick
            OpenFile()
        End Sub

        Private Sub iPrint_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iPrint.ItemClick
            DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Note that you can use the XtraPrinting Library to print the contents of the standard RichTextBox control." + vbNewLine + "For more information, see the main XtraPrinting demo.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Private Sub iSave_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iSave.ItemClick
            Save()
        End Sub
        Private Sub iSaveAs_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iSaveAs.ItemClick
            SaveAs()
        End Sub
        Private Sub Save()
            If CurrentForm Is Nothing Then
                Return
            End If
            If CurrentForm.NewDocument Then
                SaveAs()
            Else
                CurrentRichTextBox.SaveFile(CurrentDocName, RichTextBoxStreamType.RichText)
                CurrentForm.Modified = False
            End If
            SetModifiedCaption()
        End Sub
        Private Sub SaveAs()
            If Not CurrentForm Is Nothing Then
                Dim s As String = CurrentForm.SaveAs()
                If s <> String.Empty Then
                    AddToMostRecentFiles(s, arMRUList)
                End If
                UpdateText()
            End If
        End Sub
        Private Sub iExit_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iExit.ItemClick
            Close()
        End Sub
        Private Sub frmMain_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        End Sub
        Private Sub ribbonPageGroup1_CaptionButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs) Handles ribbonPageGroup1.CaptionButtonClick
            OpenFile()
        End Sub

        Private Sub ribbonPageGroup9_CaptionButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs) Handles ribbonPageGroup9.CaptionButtonClick
            SaveAs()
        End Sub
#End Region
#Region "Format"
        Private Function rtPadFontStyle() As FontStyle
            Dim fs As FontStyle = New FontStyle()
            If iBold.Down Then
                fs = fs Or FontStyle.Bold
            End If
            If iItalic.Down Then
                fs = fs Or FontStyle.Italic
            End If
            If iUnderline.Down Then
                fs = fs Or FontStyle.Underline
            End If
            Return fs
        End Function

        Private Sub iBullets_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iBullets.ItemClick
            If CurrentRichTextBox Is Nothing Then
                Return
            End If
            CurrentRichTextBox.SelectionBullet = iBullets.Down
            InitUndo()
        End Sub

        Private Sub iFontStyle_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iBold.ItemClick, iItalic.ItemClick, iUnderline.ItemClick
            If CurrentRichTextBox Is Nothing Then
                Return
            End If
            CurrentRichTextBox.SelectionFont = New Font(SelectFont, rtPadFontStyle())
        End Sub

        Private Sub iProtected_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iProtected.ItemClick
            If CurrentRichTextBox Is Nothing Then
                Return
            End If
            CurrentRichTextBox.SelectionProtected = iProtected.Down
        End Sub

        Private Sub iAlign_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iCenter.ItemClick, iAlignLeft.ItemClick, iAlignRight.ItemClick
            If CurrentRichTextBox Is Nothing Then
                Return
            End If
            If iAlignLeft.Down Then
                CurrentRichTextBox.SelectionAlignment = HorizontalAlignment.Left
            End If
            If iCenter.Down Then
                CurrentRichTextBox.SelectionAlignment = HorizontalAlignment.Center
            End If
            If iAlignRight.Down Then
                CurrentRichTextBox.SelectionAlignment = HorizontalAlignment.Right
            End If
            InitUndo()
        End Sub


        Protected ReadOnly Property SelectFont() As Font
            Get
                If Not CurrentRichTextBox Is Nothing Then
                    Return CurrentRichTextBox.SelectionFont
                End If
                Return Nothing
            End Get
        End Property
        Private Sub ShowFontDialog()
            If CurrentRichTextBox Is Nothing Then
                Return
            End If
            Dim dialogFont As Font = Nothing
            If Not SelectFont Is Nothing Then
                dialogFont = CType(SelectFont.Clone(), Font)
            Else
                dialogFont = CurrentRichTextBox.Font
            End If
            Dim dlg As XtraFontDialog = New XtraFontDialog(dialogFont)
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                CurrentRichTextBox.SelectionFont = dlg.ResultFont
                beiFontSize.EditValue = dlg.ResultFont.Size
            End If
        End Sub
        Private Sub iFont_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iFont.ItemClick
            ShowFontDialog()
        End Sub
        Private Sub iFontColor_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iFontColor.ItemClick
            If CurrentRichTextBox Is Nothing Then
                Return
            End If
            CurrentRichTextBox.SelectionColor = cp.ResultColor
        End Sub
#End Region
#Region "Edit"
        Private Sub iUndo_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iUndo.ItemClick, iLargeUndo.ItemClick
            If CurrentRichTextBox Is Nothing Then
                Return
            End If
            CurrentRichTextBox.Undo()
            CurrentForm.Modified = CurrentRichTextBox.CanUndo
            SetModifiedCaption()
            InitUndo()
            InitFormat()
        End Sub

        Private Sub iCut_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iCut.ItemClick
            If CurrentRichTextBox Is Nothing Then
                Return
            End If
            CurrentRichTextBox.Cut()
            InitPaste()
        End Sub

        Private Sub iCopy_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iCopy.ItemClick
            If CurrentRichTextBox Is Nothing Then
                Return
            End If
            CurrentRichTextBox.Copy()
            InitPaste()
        End Sub

        Private Sub iPaste_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iPaste.ItemClick
            If CurrentRichTextBox Is Nothing Then
                Return
            End If
            CurrentRichTextBox.Paste()
        End Sub

        Private Sub iClear_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iClear.ItemClick
            If CurrentRichTextBox Is Nothing Then
                Return
            End If
            CurrentRichTextBox.SelectedRtf = ""
        End Sub

        Private Sub iSelectAll_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iSelectAll.ItemClick
            If CurrentRichTextBox Is Nothing Then
                Return
            End If
            CurrentRichTextBox.SelectAll()
        End Sub
        Private Sub ribbonPageGroup2_CaptionButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs) Handles ribbonPageGroup2.CaptionButtonClick
            pmMain.ShowPopup(ribbonControl1.Manager, MousePosition)
        End Sub
#End Region
#Region "SkinGallery"
        Private Sub InitSkinGallery()
            Dim imageButton As SimpleButton = New SimpleButton()
            For Each cnt As SkinContainer In SkinManager.Default.Skins
                imageButton.LookAndFeel.SetSkinStyle(cnt.SkinName)
                Dim gItem As GalleryItem = New GalleryItem()
                Dim groupIndex As Integer = 0
                If cnt.SkinName.Contains("Office") Then
                    groupIndex = 1
                End If
                If DevExpress.DXperience.Demos.LookAndFeelMenu.IsBonusSkin(cnt.SkinName) Then
                    groupIndex = 2
                End If
                rgbiSkins.Gallery.Groups(groupIndex).Items.Add(gItem)
                gItem.Caption = cnt.SkinName

                gItem.Image = GetSkinImage(imageButton, 32, 17, 2)
                gItem.HoverImage = GetSkinImage(imageButton, 70, 36, 5)
                gItem.Caption = cnt.SkinName
                gItem.Hint = cnt.SkinName
            Next cnt
            rgbiSkins.Gallery.Groups(1).Visible = False
            rgbiSkins.Gallery.Groups(2).Visible = False
        End Sub
        Private Function GetSkinImage(ByVal button As SimpleButton, ByVal width As Integer, ByVal height As Integer, ByVal indent As Integer) As Bitmap
            Dim image As Bitmap = New Bitmap(width, height)
            Using g As Graphics = Graphics.FromImage(image)
                Dim info As StyleObjectInfoArgs = New StyleObjectInfoArgs(New GraphicsCache(g))
                info.Bounds = New Rectangle(0, 0, width, height)
                button.LookAndFeel.Painter.GroupPanel.DrawObject(info)
                button.LookAndFeel.Painter.Border.DrawObject(info)
                info.Bounds = New Rectangle(indent, indent, width - indent * 2, height - indent * 2)
                button.LookAndFeel.Painter.Button.DrawObject(info)
            End Using
            Return image
        End Function
        Private Sub rgbiSkins_Gallery_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs) Handles rgbiSkins.Gallery.ItemClick
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(e.Item.Caption)
        End Sub

        Private Sub rgbiSkins_Gallery_InitDropDownGallery(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.InplaceGalleryEventArgs) Handles rgbiSkins.Gallery.InitDropDownGallery
            e.PopupGallery.CreateFrom(rgbiSkins.Gallery)
            e.PopupGallery.AllowFilter = False
            e.PopupGallery.ShowItemText = True
            e.PopupGallery.ShowGroupCaption = True
            e.PopupGallery.AllowHoverImages = False
            For Each galleryGroup As GalleryItemGroup In e.PopupGallery.Groups
                For Each item As GalleryItem In galleryGroup.Items
                    item.Image = item.HoverImage
                Next item
            Next galleryGroup
            e.PopupGallery.ColumnCount = 2
            e.PopupGallery.ImageSize = New Size(70, 36)
        End Sub
#End Region
#Region "FontGallery"
        Private Function GetFontImage(ByVal width As Integer, ByVal height As Integer, ByVal fontName As String, ByVal fontSize As Integer) As Image
            Dim rect As Rectangle = New Rectangle(0, 0, width, height)
            Dim fontImage As Image = New Bitmap(width, height)
            Try
                Using fontSample As Font = New Font(fontName, fontSize)
                    Dim g As Graphics = Graphics.FromImage(fontImage)
                    g.FillRectangle(Brushes.White, rect)
                    Using fs As StringFormat = New StringFormat()
                        fs.Alignment = StringAlignment.Center
                        fs.LineAlignment = StringAlignment.Center
                        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
                        g.DrawString("Aa", fontSample, Brushes.Black, rect, fs)
                        g.Dispose()
                    End Using
                End Using
            Catch
            End Try
            Return fontImage
        End Function
        Private Sub InitFont(ByVal groupDropDown As GalleryItemGroup, ByVal galleryGroup As GalleryItemGroup)
            Dim i As Integer = 0
            Do While i < FontFamily.Families.Length
                If FontFamily.Families(i).IsStyleAvailable(FontStyle.Regular) Then
                    Dim fontName As String = FontFamily.Families(i).Name
                    Dim item As GalleryItem = New GalleryItem()
                    item.Caption = fontName
                    item.Image = GetFontImage(32, 28, fontName, 12)
                    item.HoverImage = item.Image
                    item.Description = fontName
                    item.Hint = fontName
                    Try
                        item.Tag = New Font(fontName, 9)
                        If DevExpress.Utils.ControlUtils.IsSymbolFont(CType(item.Tag, Font)) Then
                            item.Tag = New Font(DevExpress.Utils.AppearanceObject.DefaultFont.FontFamily, 9)
                            item.Description &= " (Symbol Font)"
                        End If
                    Catch
                        i += 1
                        Continue Do
                    End Try
                    groupDropDown.Items.Add(item)
                    galleryGroup.Items.Add(item)
                End If
                i += 1
            Loop
        End Sub
        Private Sub InitFontGallery()
            InitFont(gddFont.Gallery.Groups(0), rgbiFont.Gallery.Groups(0))
            beiFontSize.EditValue = 8
        End Sub
        Private Sub SetFont(ByVal fontName As String, ByVal item As GalleryItem)
            If CurrentRichTextBox Is Nothing Then
                Return
            End If
            CurrentRichTextBox.SelectionFont = New Font(fontName, Convert.ToInt32(beiFontSize.EditValue), rtPadFontStyle())
            If Not item Is Nothing Then
                CurrentFontItem = item
            End If
        End Sub
        Private Sub gddFont_Gallery_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs) Handles gddFont.Gallery.ItemClick
            SetFont(e.Item.Caption, e.Item)
        End Sub
        Private Sub rpgFont_CaptionButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs) Handles rpgFont.CaptionButtonClick
            ShowFontDialog()
        End Sub
        Private Sub rgbiFont_Gallery_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs) Handles rgbiFont.Gallery.ItemClick
            SetFont(e.Item.Caption, e.Item)
        End Sub
        Private Sub gddFont_Gallery_CustomDrawItemText(ByVal sender As Object, ByVal e As GalleryItemCustomDrawEventArgs) Handles gddFont.Gallery.CustomDrawItemText
            Dim itemInfo As DevExpress.XtraBars.Ribbon.ViewInfo.GalleryItemViewInfo = TryCast(e.ItemInfo, DevExpress.XtraBars.Ribbon.ViewInfo.GalleryItemViewInfo)
            itemInfo.PaintAppearance.ItemDescription.DrawString(e.Cache, e.Item.Description, itemInfo.DescriptionBounds)
            Dim app As AppearanceObject = TryCast(itemInfo.PaintAppearance.ItemCaption.Clone(), AppearanceObject)
            app.Font = CType(e.Item.Tag, Font)
            Try
                e.Cache.Graphics.DrawString(e.Item.Caption, app.Font, app.GetForeBrush(e.Cache), itemInfo.CaptionBounds)
            Catch
            End Try
            e.Handled = True
        End Sub
#End Region
#Region "ColorGallery"
        Private Sub InitColorGallery()
            gddFontColor.BeginUpdate()
            For Each color As Color In DevExpress.XtraEditors.Popup.ColorListBoxViewInfo.WebColors
                If color = System.Drawing.Color.Transparent Then
                    Continue For
                End If
                Dim item As GalleryItem = New GalleryItem()
                item.Caption = color.Name
                item.Tag = color
                item.Hint = color.Name
                gddFontColor.Gallery.Groups(0).Items.Add(item)
                rgbiFontColor.Gallery.Groups(0).Items.Add(item)
            Next color
            For Each color As Color In DevExpress.XtraEditors.Popup.ColorListBoxViewInfo.SystemColors
                Dim item As GalleryItem = New GalleryItem()
                item.Caption = color.Name
                item.Tag = color
                gddFontColor.Gallery.Groups(1).Items.Add(item)
            Next color
            gddFontColor.EndUpdate()
        End Sub
        Private Sub gddFontColor_Gallery_CustomDrawItemImage(ByVal sender As Object, ByVal e As GalleryItemCustomDrawEventArgs) Handles gddFontColor.Gallery.CustomDrawItemImage, rgbiFontColor.Gallery.CustomDrawItemImage
            Dim clr As Color = CType(e.Item.Tag, Color)
            Using brush As Brush = New SolidBrush(clr)
                e.Cache.FillRectangle(brush, e.Bounds)
                e.Handled = True
            End Using
        End Sub
        Private Sub SetResultColor(ByVal color As Color, ByVal item As GalleryItem)
            If CurrentRichTextBox Is Nothing Then
                Return
            End If
            cp.ResultColor = color
            CurrentRichTextBox.SelectionColor = cp.ResultColor
            If Not item Is Nothing Then
                CurrentColorItem = item
            End If
        End Sub
        Private Sub gddFontColor_Gallery_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs) Handles gddFontColor.Gallery.ItemClick
            SetResultColor(CType(e.Item.Tag, Color), e.Item)
        End Sub
        Private Sub rpgFontColor_CaptionButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs) Handles rpgFontColor.CaptionButtonClick
            If CurrentRichTextBox Is Nothing Then
                Return
            End If
            popupControlContainer1.ShowPopup(ribbonControl1.Manager, MousePosition)
        End Sub

        Private Sub rgbiFontColor_Gallery_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs) Handles rgbiFontColor.Gallery.ItemClick
            SetResultColor(CType(e.Item.Tag, Color), e.Item)
        End Sub
#End Region

        Private Sub iFind_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iFind.ItemClick
            If CurrentRichTextBox Is Nothing Then
                Return
            End If
            If Not dlgReplace Is Nothing Then
                dlgReplace.Close()
            End If
            If Not dlgFind Is Nothing Then
                dlgFind.Close()
            End If
            dlgFind = New frmFind(CurrentRichTextBox, Bounds)
            AddOwnedForm(dlgFind)
            dlgFind.Show()
        End Sub

        Private Sub iReplace_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iReplace.ItemClick
            If CurrentRichTextBox Is Nothing Then
                Return
            End If
            If Not dlgReplace Is Nothing Then
                dlgReplace.Close()
            End If
            If Not dlgFind Is Nothing Then
                dlgFind.Close()
            End If
            dlgReplace = New frmReplace(CurrentRichTextBox, Bounds)
            AddOwnedForm(dlgReplace)
            dlgReplace.Show()
        End Sub

        Private Sub iWeb_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iWeb.ItemClick
            Dim process As Process = New Process()
            process.StartInfo.FileName = "http://www.devexpress.com"
            process.StartInfo.Verb = "Open"
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            process.Start()
        End Sub

        Private Sub iAbout_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iAbout.ItemClick
            Dim dlg As DevExpress.Utils.About.frmAbout = New DevExpress.Utils.About.frmAbout("Ribbon Demo for the XtraBars by Developer Express Inc.")
            dlg.ShowDialog()
        End Sub

        Private Function TextByCaption(ByVal caption As String) As String
            Return caption.Replace("&", "")
        End Function

        Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            arMRUList = New MRUArrayList(pcAppMenuFileLabels, imageCollection3.Images(0), imageCollection3.Images(1))
            AddHandler arMRUList.LabelClicked, AddressOf OnLabelClicked
            InitMostRecentFiles(arMRUList)
            ribbonControl1.ForceInitialize()
            For Each skin As DevExpress.Skins.SkinContainer In DevExpress.Skins.SkinManager.Default.Skins
                Dim item As BarCheckItem = ribbonControl1.Items.CreateCheckItem(skin.SkinName, False)
                item.Tag = skin.SkinName
                AddHandler item.ItemClick, AddressOf OnPaintStyleClick
                iPaintStyle.ItemLinks.Add(item)
            Next skin
            CreateNewDocument()
            BarEditItem1.EditValue = DevExpress.Utils.ResourceImageHelper.CreateImageFromResources("online.gif", GetType(frmMain).Assembly)
        End Sub

        Private Sub OnPaintStyleClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            defaultLookAndFeel1.LookAndFeel.SetSkinStyle(e.Item.Tag.ToString())
        End Sub

        Private Sub iPaintStyle_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles iPaintStyle.Popup
            For Each link As BarItemLink In iPaintStyle.ItemLinks
                CType(link.Item, BarCheckItem).Checked = link.Item.Caption = defaultLookAndFeel1.LookAndFeel.ActiveSkinName
            Next link
        End Sub
#Region "GalleryItemsChecked"

        Private Function GetColorItemByColor(ByVal color As Color, ByVal gallery As BaseGallery) As GalleryItem
            For Each galleryGroup As GalleryItemGroup In gallery.Groups
                For Each item As GalleryItem In galleryGroup.Items
                    If item.Caption = color.Name Then
                        Return item
                    End If
                Next item
            Next galleryGroup
            Return Nothing
        End Function
        Private Function GetFontItemByFont(ByVal fontName As String, ByVal gallery As BaseGallery) As GalleryItem
            For Each galleryGroup As GalleryItemGroup In gallery.Groups
                For Each item As GalleryItem In galleryGroup.Items
                    If item.Caption = fontName Then
                        Return item
                    End If
                Next item
            Next galleryGroup
            Return Nothing
        End Function
        Private Property CurrentFontItem() As GalleryItem
            Get
                Return fCurrentFontItem
            End Get
            Set(ByVal value As GalleryItem)
                If fCurrentFontItem Is value Then
                    Return
                End If
                If Not fCurrentFontItem Is Nothing Then
                    fCurrentFontItem.Checked = False
                End If
                fCurrentFontItem = value
                If Not fCurrentFontItem Is Nothing Then
                    fCurrentFontItem.Checked = True
                    MakeFontVisible(fCurrentFontItem)
                End If
            End Set
        End Property
        Private Sub MakeFontVisible(ByVal item As GalleryItem)
            gddFont.Gallery.MakeVisible(fCurrentFontItem)
            rgbiFont.Gallery.MakeVisible(fCurrentFontItem)
        End Sub
        Private Property CurrentColorItem() As GalleryItem
            Get
                Return fCurrentColorItem
            End Get
            Set(ByVal value As GalleryItem)
                If fCurrentColorItem Is value Then
                    Return
                End If
                If Not fCurrentColorItem Is Nothing Then
                    fCurrentColorItem.Checked = False
                End If
                fCurrentColorItem = value
                If Not fCurrentColorItem Is Nothing Then
                    fCurrentColorItem.Checked = True
                    MakeColorVisible(fCurrentColorItem)
                End If
            End Set
        End Property
        Private Sub MakeColorVisible(ByVal item As GalleryItem)
            gddFontColor.Gallery.MakeVisible(fCurrentColorItem)
            rgbiFontColor.Gallery.MakeVisible(fCurrentColorItem)
        End Sub
        Private Sub CurrentFontChanged()
            If CurrentRichTextBox Is Nothing OrElse CurrentRichTextBox.SelectionFont Is Nothing Then
                Return
            End If
            CurrentFontItem = GetFontItemByFont(CurrentRichTextBox.SelectionFont.Name, rgbiFont.Gallery)
            CurrentColorItem = GetColorItemByColor(CurrentRichTextBox.SelectionColor, rgbiFontColor.Gallery)
        End Sub
        Private Sub gddFont_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles gddFont.Popup
            MakeFontVisible(CurrentFontItem)
        End Sub

        Private Sub gddFontColor_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles gddFontColor.Popup
            MakeColorVisible(CurrentColorItem)
        End Sub
#End Region
#Region "MostRecentFiles"
        Private arMRUList As MRUArrayList = Nothing
        Private mrfFileName As String = "RibbonMRUFiles.ini"
        Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            SaveMostRecentFiles(arMRUList)
        End Sub
        Private Sub InitMostRecentFiles(ByVal arList As MRUArrayList)
            Dim fileName As String = Application.StartupPath & "\" & mrfFileName
            If (Not System.IO.File.Exists(fileName)) Then
                AddToMostRecentFiles("Document1.rtf", arList)
                Return
            End If
            Dim sr As System.IO.StreamReader = System.IO.File.OpenText(fileName)
            Dim s As String = sr.ReadLine()
            Do While Not s Is Nothing
                AddToMostRecentFiles(s, arList)
                s = sr.ReadLine()
            Loop
            sr.Close()
        End Sub

        Private Sub SaveMostRecentFiles(ByVal arList As MRUArrayList)
            Try
                Dim sw As System.IO.StreamWriter = System.IO.File.CreateText(Application.StartupPath & "\" & mrfFileName)
                For i As Integer = arList.Count - 1 To 0 Step -1
                    sw.WriteLine(String.Format("{0},{1}", arList(i).ToString(), arList.GetLabelChecked(arList(i).ToString())))
                Next i
                sw.Close()
            Catch
            End Try
        End Sub

        Private Sub AddToMostRecentFiles(ByVal name As String, ByVal arList As MRUArrayList)
            arList.InsertElement(name)
        End Sub
        Private Sub OnLabelClicked(ByVal sender As Object, ByVal e As EventArgs)
            pmAppMain.HidePopup()
            Me.Refresh()
            OpenFile(sender.ToString())
        End Sub
        Private Class MRUArrayList
            Inherits ArrayList
            Private container As PanelControl
            Private maxRecentFiles As Integer = 9
            Private imgChecked, imgUncheked As Image
            Public Event LabelClicked As EventHandler
            Public Sub New(ByVal cont As PanelControl, ByVal iChecked As Image, ByVal iUnchecked As Image)
                MyBase.New()
                Me.imgChecked = iChecked
                Me.imgUncheked = iUnchecked
                Me.container = cont
            End Sub
            Public Sub InsertElement(ByVal value As Object)
                Dim names As String() = value.ToString().Split(","c)
                Dim name As String = names(0)
                Dim checkedLabel As Boolean = False
                If names.Length > 1 Then
                    checkedLabel = names(1).ToLower().Equals("true")
                End If
                For Each ml As AppMenuFileLabel In container.Controls
                    If ml.Tag.Equals(name) Then
                        checkedLabel = ml.Checked
                        MyBase.Remove(name)
                        RemoveHandler ml.LabelClick, AddressOf OnLabelClick
                        ml.Dispose()
                        Exit For
                    End If
                Next ml
                Dim access As Boolean = True
                If MyBase.Count >= maxRecentFiles Then
                    access = RemoveLastElement()
                End If
                If access Then
                    MyBase.Insert(0, name)
                    Dim ml As AppMenuFileLabel = New AppMenuFileLabel()
                    container.Controls.Add(ml)
                    ml.Tag = name
                    ml.Text = GetFileName(name)
                    ml.Checked = checkedLabel
                    ml.AutoHeight = True
                    ml.Dock = DockStyle.Top
                    ml.Image = imgUncheked
                    ml.SelectedImage = imgChecked
                    AddHandler ml.LabelClick, AddressOf OnLabelClick
                    SetElementsRange()
                End If
            End Sub
            Private Sub OnLabelClick(ByVal sender As Object, ByVal e As EventArgs)
                If Not LabelClickedEvent Is Nothing Then
                    RaiseEvent LabelClicked((CType(sender, AppMenuFileLabel)).Tag.ToString(), e)
                End If
            End Sub
            Public Function RemoveLastElement() As Boolean
                Dim i As Integer = 0
                Do While i < container.Controls.Count
                    Dim ml As AppMenuFileLabel = TryCast(container.Controls(i), AppMenuFileLabel)
                    If (Not ml.Checked) Then
                        MyBase.Remove(ml.Tag)
                        RemoveHandler ml.LabelClick, AddressOf OnLabelClick
                        ml.Dispose()
                        Return True
                    End If
                    i += 1
                Loop
                Return False
            End Function
            Private Function GetFileName(ByVal obj As Object) As String
                Dim fi As FileInfo = New FileInfo(obj.ToString())
                Return fi.Name
            End Function
            Private Sub SetElementsRange()
                Dim i As Integer = 0
                For Each ml As AppMenuFileLabel In container.Controls
                    ml.Caption = String.Format("&{0}", container.Controls.Count - i)
                    i += 1
                Next ml
            End Sub
            Public Function GetLabelChecked(ByVal name As String) As Boolean
                For Each ml As AppMenuFileLabel In container.Controls
                    If ml.Tag.Equals(name) Then
                        Return ml.Checked
                    End If
                Next ml
                Return False
            End Function
        End Class
#End Region

        Private Sub BarEditItem1_ItemPress(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarEditItem1.ItemPress
            System.Diagnostics.Process.Start("http://www.devexpress.com")
        End Sub

        Private Sub xtraTabbedMdiManager1_FloatMDIChildActivated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xtraTabbedMdiManager1.FloatMDIChildActivated
            ChangeActiveForm()
        End Sub

        Private Sub xtraTabbedMdiManager1_FloatMDIChildDeactivated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xtraTabbedMdiManager1.FloatMDIChildDeactivated
            BeginInvoke(New MethodInvoker(AddressOf ChangeActiveForm))
        End Sub

        Private Sub biStyle_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles biStyle.EditValueChanged
            ribbonControl1.RibbonStyle = CType(biStyle.EditValue, RibbonControlStyle)
        End Sub
    End Class
End Namespace
