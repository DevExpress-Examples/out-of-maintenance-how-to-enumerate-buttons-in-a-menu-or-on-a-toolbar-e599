Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraBars
Imports DevExpress.XtraTreeList.Nodes

Namespace IterateLinks
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private bar1 As DevExpress.XtraBars.Bar
		Private mFile As DevExpress.XtraBars.BarSubItem
		Private iNew As DevExpress.XtraBars.BarButtonItem
		Private iOpen As DevExpress.XtraBars.BarButtonItem
		Private iClose As DevExpress.XtraBars.BarButtonItem
		Private iSave As DevExpress.XtraBars.BarButtonItem
		Private iSaveAs As DevExpress.XtraBars.BarButtonItem
		Private iPrint As DevExpress.XtraBars.BarButtonItem
		Private iExit As DevExpress.XtraBars.BarButtonItem
		Private mEdit As DevExpress.XtraBars.BarSubItem
		Private iUndo As DevExpress.XtraBars.BarButtonItem
		Private iCut As DevExpress.XtraBars.BarButtonItem
		Private iCopy As DevExpress.XtraBars.BarButtonItem
		Private iPaste As DevExpress.XtraBars.BarButtonItem
		Private iClear As DevExpress.XtraBars.BarButtonItem
		Private iSelectAll As DevExpress.XtraBars.BarButtonItem
		Private iFind As DevExpress.XtraBars.BarButtonItem
		Private iReplace As DevExpress.XtraBars.BarButtonItem
		Private mFormat As DevExpress.XtraBars.BarSubItem
		Private iFont As DevExpress.XtraBars.BarButtonItem
		Private iFontColor As DevExpress.XtraBars.BarButtonItem
		Private iBullets As DevExpress.XtraBars.BarButtonItem
		Private iProtected As DevExpress.XtraBars.BarButtonItem
		Private iToolBars As DevExpress.XtraBars.BarToolbarsListItem
		Private mHelp As DevExpress.XtraBars.BarSubItem
		Private iWeb As DevExpress.XtraBars.BarButtonItem
		Private iAbout As DevExpress.XtraBars.BarButtonItem
		Private bar2 As DevExpress.XtraBars.Bar
		Private bar3 As DevExpress.XtraBars.Bar
		Private iBold As DevExpress.XtraBars.BarButtonItem
		Private iItalic As DevExpress.XtraBars.BarButtonItem
		Private iUnderline As DevExpress.XtraBars.BarButtonItem
		Private iAlignLeft As DevExpress.XtraBars.BarButtonItem
		Private iCenter As DevExpress.XtraBars.BarButtonItem
		Private iAlignRight As DevExpress.XtraBars.BarButtonItem
		Private bar4 As DevExpress.XtraBars.Bar
		Private iEdit As DevExpress.XtraBars.BarButtonItem
		Private bar5 As DevExpress.XtraBars.Bar
		Private sPosition As DevExpress.XtraBars.BarStaticItem
		Private sModifier As DevExpress.XtraBars.BarStaticItem
		Private sDocName As DevExpress.XtraBars.BarStaticItem
		Private bar7 As DevExpress.XtraBars.Bar
		Private iPaintStyle As DevExpress.XtraBars.BarSubItem
		Private ipsDefault As DevExpress.XtraBars.BarButtonItem
		Private ipsWXP As DevExpress.XtraBars.BarButtonItem
		Private ipsOXP As DevExpress.XtraBars.BarButtonItem
		Private ipsO2K As DevExpress.XtraBars.BarButtonItem
		Private ipsO3 As DevExpress.XtraBars.BarButtonItem
		Private barDockControl1 As DevExpress.XtraBars.BarDockControl
		Private barDockControl2 As DevExpress.XtraBars.BarDockControl
		Private barDockControl3 As DevExpress.XtraBars.BarDockControl
		Private barDockControl4 As DevExpress.XtraBars.BarDockControl
		Private imageList1 As System.Windows.Forms.ImageList
		Private WithEvents barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private treeList1 As DevExpress.XtraTreeList.TreeList
		Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private components As System.ComponentModel.IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.bar1 = New DevExpress.XtraBars.Bar()
			Me.mFile = New DevExpress.XtraBars.BarSubItem()
			Me.iNew = New DevExpress.XtraBars.BarButtonItem()
			Me.iOpen = New DevExpress.XtraBars.BarButtonItem()
			Me.iClose = New DevExpress.XtraBars.BarButtonItem()
			Me.iSave = New DevExpress.XtraBars.BarButtonItem()
			Me.iSaveAs = New DevExpress.XtraBars.BarButtonItem()
			Me.iPrint = New DevExpress.XtraBars.BarButtonItem()
			Me.iExit = New DevExpress.XtraBars.BarButtonItem()
			Me.mEdit = New DevExpress.XtraBars.BarSubItem()
			Me.iUndo = New DevExpress.XtraBars.BarButtonItem()
			Me.iCut = New DevExpress.XtraBars.BarButtonItem()
			Me.iCopy = New DevExpress.XtraBars.BarButtonItem()
			Me.iPaste = New DevExpress.XtraBars.BarButtonItem()
			Me.iClear = New DevExpress.XtraBars.BarButtonItem()
			Me.iSelectAll = New DevExpress.XtraBars.BarButtonItem()
			Me.iFind = New DevExpress.XtraBars.BarButtonItem()
			Me.iReplace = New DevExpress.XtraBars.BarButtonItem()
			Me.mFormat = New DevExpress.XtraBars.BarSubItem()
			Me.iFont = New DevExpress.XtraBars.BarButtonItem()
			Me.iFontColor = New DevExpress.XtraBars.BarButtonItem()
			Me.iBullets = New DevExpress.XtraBars.BarButtonItem()
			Me.iProtected = New DevExpress.XtraBars.BarButtonItem()
			Me.iToolBars = New DevExpress.XtraBars.BarToolbarsListItem()
			Me.mHelp = New DevExpress.XtraBars.BarSubItem()
			Me.iWeb = New DevExpress.XtraBars.BarButtonItem()
			Me.iAbout = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.bar2 = New DevExpress.XtraBars.Bar()
			Me.bar3 = New DevExpress.XtraBars.Bar()
			Me.iBold = New DevExpress.XtraBars.BarButtonItem()
			Me.iItalic = New DevExpress.XtraBars.BarButtonItem()
			Me.iUnderline = New DevExpress.XtraBars.BarButtonItem()
			Me.iAlignLeft = New DevExpress.XtraBars.BarButtonItem()
			Me.iCenter = New DevExpress.XtraBars.BarButtonItem()
			Me.iAlignRight = New DevExpress.XtraBars.BarButtonItem()
			Me.bar4 = New DevExpress.XtraBars.Bar()
			Me.iEdit = New DevExpress.XtraBars.BarButtonItem()
			Me.bar5 = New DevExpress.XtraBars.Bar()
			Me.sPosition = New DevExpress.XtraBars.BarStaticItem()
			Me.sModifier = New DevExpress.XtraBars.BarStaticItem()
			Me.sDocName = New DevExpress.XtraBars.BarStaticItem()
			Me.bar7 = New DevExpress.XtraBars.Bar()
			Me.iPaintStyle = New DevExpress.XtraBars.BarSubItem()
			Me.ipsDefault = New DevExpress.XtraBars.BarButtonItem()
			Me.ipsWXP = New DevExpress.XtraBars.BarButtonItem()
			Me.ipsOXP = New DevExpress.XtraBars.BarButtonItem()
			Me.ipsO2K = New DevExpress.XtraBars.BarButtonItem()
			Me.ipsO3 = New DevExpress.XtraBars.BarButtonItem()
			Me.barDockControl1 = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControl2 = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControl3 = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControl4 = New DevExpress.XtraBars.BarDockControl()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1, Me.bar2, Me.bar3, Me.bar4, Me.bar5, Me.bar7})
			Me.barManager1.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() { New DevExpress.XtraBars.BarManagerCategory("File", New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")), New DevExpress.XtraBars.BarManagerCategory("Edit", New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")), New DevExpress.XtraBars.BarManagerCategory("Format", New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")), New DevExpress.XtraBars.BarManagerCategory("Help", New System.Guid("e07a4c24-66ac-4de6-bbcb-c0b6cfa7798b")), New DevExpress.XtraBars.BarManagerCategory("Popup", New System.Guid("78945463-36c5-4beb-a57f-d50b6a74e9b9")), New DevExpress.XtraBars.BarManagerCategory("Status", New System.Guid("77795bb7-9bc5-4dd2-a297-cc758682e23d")), New DevExpress.XtraBars.BarManagerCategory("Built-in Menus", New System.Guid("02ed6c1c-df85-47f8-9572-b20022d647f9")), New DevExpress.XtraBars.BarManagerCategory("ToolBars", New System.Guid("3856091a-e0f6-4a7c-80e9-103dece20d5b")), New DevExpress.XtraBars.BarManagerCategory("PaintStyle", New System.Guid("7102d69f-976b-49fe-978d-97325e115e10"))})
			Me.barManager1.DockControls.Add(Me.barDockControl1)
			Me.barManager1.DockControls.Add(Me.barDockControl2)
			Me.barManager1.DockControls.Add(Me.barDockControl3)
			Me.barManager1.DockControls.Add(Me.barDockControl4)
			Me.barManager1.Form = Me
			Me.barManager1.Images = Me.imageList1
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.iNew, Me.iOpen, Me.iClose, Me.iSave, Me.iSaveAs, Me.iPrint, Me.iExit, Me.mFile, Me.iUndo, Me.iCut, Me.iCopy, Me.iPaste, Me.iClear, Me.iSelectAll, Me.iFind, Me.iReplace, Me.mEdit, Me.iFont, Me.iBullets, Me.iProtected, Me.mFormat, Me.iWeb, Me.iAbout, Me.mHelp, Me.iBold, Me.iItalic, Me.iUnderline, Me.iAlignLeft, Me.iCenter, Me.iAlignRight, Me.iFontColor, Me.iEdit, Me.sPosition, Me.sModifier, Me.sDocName, Me.iToolBars, Me.iPaintStyle, Me.ipsWXP, Me.ipsOXP, Me.ipsO2K, Me.ipsO3, Me.ipsDefault, Me.barButtonItem1})
			Me.barManager1.MainMenu = Me.bar1
			Me.barManager1.MaxItemId = 87
			Me.barManager1.StatusBar = Me.bar5
			' 
			' bar1
			' 
			Me.bar1.BarName = "MainMenu"
			Me.bar1.DockCol = 0
			Me.bar1.DockRow = 0
			Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar1.FloatSize = New System.Drawing.Size(30, 22)
			Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.mFile), New DevExpress.XtraBars.LinkPersistInfo(Me.mEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.mFormat), New DevExpress.XtraBars.LinkPersistInfo(Me.iToolBars), New DevExpress.XtraBars.LinkPersistInfo(Me.mHelp), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1)})
			Me.bar1.OptionsBar.DrawDragBorder = False
			Me.bar1.OptionsBar.MultiLine = True
			Me.bar1.OptionsBar.UseWholeRow = True
			Me.bar1.Text = "MainMenu"
			' 
			' mFile
			' 
			Me.mFile.Caption = "&File"
			Me.mFile.CategoryGuid = New System.Guid("02ed6c1c-df85-47f8-9572-b20022d647f9")
			Me.mFile.Id = 7
			Me.mFile.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.iNew), New DevExpress.XtraBars.LinkPersistInfo(Me.iOpen), New DevExpress.XtraBars.LinkPersistInfo(Me.iClose), New DevExpress.XtraBars.LinkPersistInfo(Me.iSave, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, Me.iSaveAs, "", False, False, True, 0), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, Me.iPrint, "", True, False, True, 0), New DevExpress.XtraBars.LinkPersistInfo(Me.iExit, True)})
			Me.mFile.MenuBarWidth = 20
			Me.mFile.Name = "mFile"
			' 
			' iNew
			' 
			Me.iNew.Caption = "&New"
			Me.iNew.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
			Me.iNew.Description = "Creates a new, blank file."
			Me.iNew.Hint = "New Blank Document"
			Me.iNew.Id = 0
			Me.iNew.ImageIndex = 6
			Me.iNew.Name = "iNew"
			' 
			' iOpen
			' 
			Me.iOpen.Caption = "&Open..."
			Me.iOpen.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
			Me.iOpen.Description = "Opens a file."
			Me.iOpen.Hint = "Open"
			Me.iOpen.Id = 1
			Me.iOpen.ImageIndex = 7
			Me.iOpen.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O))
			Me.iOpen.Name = "iOpen"
			' 
			' iClose
			' 
			Me.iClose.Caption = "&Close"
			Me.iClose.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
			Me.iClose.Description = "Closes the active document."
			Me.iClose.Hint = "Close Document"
			Me.iClose.Id = 2
			Me.iClose.ImageIndex = 12
			Me.iClose.Name = "iClose"
			' 
			' iSave
			' 
			Me.iSave.Caption = "&Save"
			Me.iSave.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
			Me.iSave.Description = "Saves the active document with its current file name."
			Me.iSave.Hint = "Save"
			Me.iSave.Id = 3
			Me.iSave.ImageIndex = 10
			Me.iSave.Name = "iSave"
			' 
			' iSaveAs
			' 
			Me.iSaveAs.Caption = "Save &As..."
			Me.iSaveAs.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
			Me.iSaveAs.Description = "Saves the active document with a different file name."
			Me.iSaveAs.Id = 4
			Me.iSaveAs.Name = "iSaveAs"
			' 
			' iPrint
			' 
			Me.iPrint.Caption = "&Print"
			Me.iPrint.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
			Me.iPrint.Description = "Prints the active document."
			Me.iPrint.Hint = "Print"
			Me.iPrint.Id = 5
			Me.iPrint.ImageIndex = 9
			Me.iPrint.Name = "iPrint"
			' 
			' iExit
			' 
			Me.iExit.Caption = "E&xit"
			Me.iExit.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
			Me.iExit.Description = "Closes this program after prompting you to save unsaved document."
			Me.iExit.Id = 6
			Me.iExit.Name = "iExit"
			' 
			' mEdit
			' 
			Me.mEdit.Caption = "&Edit"
			Me.mEdit.CategoryGuid = New System.Guid("02ed6c1c-df85-47f8-9572-b20022d647f9")
			Me.mEdit.Id = 16
			Me.mEdit.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.iUndo), New DevExpress.XtraBars.LinkPersistInfo(Me.iCut, True), New DevExpress.XtraBars.LinkPersistInfo(Me.iCopy), New DevExpress.XtraBars.LinkPersistInfo(Me.iPaste), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, Me.iClear, "", True, False, True, 0), New DevExpress.XtraBars.LinkPersistInfo(Me.iSelectAll), New DevExpress.XtraBars.LinkPersistInfo(Me.iFind, True), New DevExpress.XtraBars.LinkPersistInfo(Me.iReplace)})
			Me.mEdit.Name = "mEdit"
			' 
			' iUndo
			' 
			Me.iUndo.Caption = "&Undo"
			Me.iUndo.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
			Me.iUndo.Description = "Reverses the last command or deletes the last entry you typed."
			Me.iUndo.Hint = "Undo"
			Me.iUndo.Id = 8
			Me.iUndo.ImageIndex = 11
			Me.iUndo.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z))
			Me.iUndo.Name = "iUndo"
			' 
			' iCut
			' 
			Me.iCut.Caption = "Cu&t"
			Me.iCut.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
			Me.iCut.Description = "Removes the selection from the active document and places it on the Clipboard."
			Me.iCut.Hint = "Cut"
			Me.iCut.Id = 9
			Me.iCut.ImageIndex = 2
			Me.iCut.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X))
			Me.iCut.Name = "iCut"
			' 
			' iCopy
			' 
			Me.iCopy.Caption = "&Copy"
			Me.iCopy.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
			Me.iCopy.Description = "Copies the selection to the Clipboard."
			Me.iCopy.Hint = "Copy"
			Me.iCopy.Id = 10
			Me.iCopy.ImageIndex = 1
			Me.iCopy.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C))
			Me.iCopy.Name = "iCopy"
			' 
			' iPaste
			' 
			Me.iPaste.Caption = "&Paste"
			Me.iPaste.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
			Me.iPaste.Description = "Inserts the contents of the Clipboard at the insertion point, and replaces any se" & "lection. This command is available only if you have cut or copied a text."
			Me.iPaste.Hint = "Paste"
			Me.iPaste.Id = 11
			Me.iPaste.ImageIndex = 8
			Me.iPaste.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V))
			Me.iPaste.Name = "iPaste"
			' 
			' iClear
			' 
			Me.iClear.Caption = "Cle&ar"
			Me.iClear.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
			Me.iClear.Description = "Deletes the selected text without putting it on the Clipboard. This command is av" & "ailable only if a text is selected. "
			Me.iClear.Hint = "Clear"
			Me.iClear.Id = 12
			Me.iClear.ImageIndex = 13
			Me.iClear.Name = "iClear"
			' 
			' iSelectAll
			' 
			Me.iSelectAll.Caption = "Select A&ll"
			Me.iSelectAll.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
			Me.iSelectAll.Description = "Selects all text in the active document."
			Me.iSelectAll.Id = 13
			Me.iSelectAll.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A))
			Me.iSelectAll.Name = "iSelectAll"
			' 
			' iFind
			' 
			Me.iFind.Caption = "&Find..."
			Me.iFind.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
			Me.iFind.Description = "Searches for the specified text."
			Me.iFind.Hint = "Find"
			Me.iFind.Id = 14
			Me.iFind.ImageIndex = 3
			Me.iFind.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
			Me.iFind.Name = "iFind"
			' 
			' iReplace
			' 
			Me.iReplace.Caption = "R&eplace..."
			Me.iReplace.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
			Me.iReplace.Description = "Searches for and replaces the specified text."
			Me.iReplace.Hint = "Replace"
			Me.iReplace.Id = 15
			Me.iReplace.ImageIndex = 14
			Me.iReplace.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H))
			Me.iReplace.Name = "iReplace"
			' 
			' mFormat
			' 
			Me.mFormat.Caption = "F&ormat"
			Me.mFormat.CategoryGuid = New System.Guid("02ed6c1c-df85-47f8-9572-b20022d647f9")
			Me.mFormat.Id = 20
			Me.mFormat.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.iFont), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, Me.iFontColor, "", False, False, True, 0), New DevExpress.XtraBars.LinkPersistInfo(Me.iBullets, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, Me.iProtected, "", False, False, True, 0)})
			Me.mFormat.Name = "mFormat"
			' 
			' iFont
			' 
			Me.iFont.Caption = "&Font..."
			Me.iFont.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
			Me.iFont.Description = "Changes the font and character spacing formats of the selected text."
			Me.iFont.Hint = "Font Dialog"
			Me.iFont.Id = 17
			Me.iFont.ImageIndex = 4
			Me.iFont.Name = "iFont"
			' 
			' iFontColor
			' 
			Me.iFontColor.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.iFontColor.Caption = "Font C&olor"
			Me.iFontColor.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
			Me.iFontColor.Description = "Formats the selected text with the color you click."
			Me.iFontColor.Hint = "Font Color"
			Me.iFontColor.Id = 30
			Me.iFontColor.ImageIndex = 5
			Me.iFontColor.Name = "iFontColor"
			' 
			' iBullets
			' 
			Me.iBullets.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.iBullets.Caption = "&Bullets"
			Me.iBullets.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
			Me.iBullets.Description = "Adds bullets to or removes bullets from selected paragraphs."
			Me.iBullets.Hint = "Bullets"
			Me.iBullets.Id = 18
			Me.iBullets.ImageIndex = 0
			Me.iBullets.Name = "iBullets"
			' 
			' iProtected
			' 
			Me.iProtected.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.iProtected.Caption = "P&rotected"
			Me.iProtected.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
			Me.iProtected.Description = "Protectes the selected text."
			Me.iProtected.Id = 19
			Me.iProtected.Name = "iProtected"
			' 
			' iToolBars
			' 
			Me.iToolBars.Caption = "&ToolBars"
			Me.iToolBars.CategoryGuid = New System.Guid("3856091a-e0f6-4a7c-80e9-103dece20d5b")
			Me.iToolBars.Id = 38
			Me.iToolBars.Name = "iToolBars"
			' 
			' mHelp
			' 
			Me.mHelp.Caption = "&Help"
			Me.mHelp.CategoryGuid = New System.Guid("02ed6c1c-df85-47f8-9572-b20022d647f9")
			Me.mHelp.Id = 23
			Me.mHelp.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.iWeb), New DevExpress.XtraBars.LinkPersistInfo(Me.iAbout, True)})
			Me.mHelp.Name = "mHelp"
			' 
			' iWeb
			' 
			Me.iWeb.Caption = "&Developer Express on the Web"
			Me.iWeb.CategoryGuid = New System.Guid("e07a4c24-66ac-4de6-bbcb-c0b6cfa7798b")
			Me.iWeb.Description = "Opens the web page."
			Me.iWeb.Hint = "Developer Express on the Web"
			Me.iWeb.Id = 21
			Me.iWeb.ImageIndex = 21
			Me.iWeb.Name = "iWeb"
			' 
			' iAbout
			' 
			Me.iAbout.Caption = "&About"
			Me.iAbout.CategoryGuid = New System.Guid("e07a4c24-66ac-4de6-bbcb-c0b6cfa7798b")
			Me.iAbout.Description = "Displays the description of this program."
			Me.iAbout.Id = 22
			Me.iAbout.Name = "iAbout"
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "Update Links Tree"
			Me.barButtonItem1.Id = 86
			Me.barButtonItem1.Name = "barButtonItem1"
'			Me.barButtonItem1.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barButtonItem1_ItemClick);
			' 
			' bar2
			' 
			Me.bar2.BarName = "Standard"
			Me.bar2.DockCol = 0
			Me.bar2.DockRow = 1
			Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar2.FloatSize = New System.Drawing.Size(48, 26)
			Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.iNew), New DevExpress.XtraBars.LinkPersistInfo(Me.iOpen), New DevExpress.XtraBars.LinkPersistInfo(Me.iSave), New DevExpress.XtraBars.LinkPersistInfo(Me.iPrint, True), New DevExpress.XtraBars.LinkPersistInfo(Me.iCut, True), New DevExpress.XtraBars.LinkPersistInfo(Me.iCopy), New DevExpress.XtraBars.LinkPersistInfo(Me.iPaste), New DevExpress.XtraBars.LinkPersistInfo(Me.iUndo, True)})
			Me.bar2.Text = "Standard"
			' 
			' bar3
			' 
			Me.bar3.BarName = "Format"
			Me.bar3.DockCol = 0
			Me.bar3.DockRow = 2
			Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar3.FloatLocation = New System.Drawing.Point(34, 212)
			Me.bar3.FloatSize = New System.Drawing.Size(27, 168)
			Me.bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.iBold), New DevExpress.XtraBars.LinkPersistInfo(Me.iItalic), New DevExpress.XtraBars.LinkPersistInfo(Me.iUnderline), New DevExpress.XtraBars.LinkPersistInfo(Me.iAlignLeft, True), New DevExpress.XtraBars.LinkPersistInfo(Me.iCenter), New DevExpress.XtraBars.LinkPersistInfo(Me.iAlignRight), New DevExpress.XtraBars.LinkPersistInfo(Me.iBullets, True)})
			Me.bar3.Text = "Format"
			' 
			' iBold
			' 
			Me.iBold.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.iBold.Caption = "&Bold"
			Me.iBold.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
			Me.iBold.Description = "Makes selected text and numbers bold. If the selection is already bold, clicking " & "button removes bold formatting."
			Me.iBold.Hint = "Bold"
			Me.iBold.Id = 24
			Me.iBold.ImageIndex = 15
			Me.iBold.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B))
			Me.iBold.Name = "iBold"
			' 
			' iItalic
			' 
			Me.iItalic.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.iItalic.Caption = "&Italic"
			Me.iItalic.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
			Me.iItalic.Description = "Makes selected text and numbers italic. If the selection is already italic, click" & "ing button removes italic formatting."
			Me.iItalic.Hint = "Italic"
			Me.iItalic.Id = 25
			Me.iItalic.ImageIndex = 16
			Me.iItalic.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I))
			Me.iItalic.Name = "iItalic"
			' 
			' iUnderline
			' 
			Me.iUnderline.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.iUnderline.Caption = "&Underline"
			Me.iUnderline.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
			Me.iUnderline.Description = "Underlines selected text and numbers. If the selection is already underlined, cli" & "cking button removes underlining."
			Me.iUnderline.Hint = "Underline"
			Me.iUnderline.Id = 26
			Me.iUnderline.ImageIndex = 17
			Me.iUnderline.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U))
			Me.iUnderline.Name = "iUnderline"
			' 
			' iAlignLeft
			' 
			Me.iAlignLeft.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.iAlignLeft.Caption = "Align &Left"
			Me.iAlignLeft.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
			Me.iAlignLeft.Description = "Aligns the selected text to the left."
			Me.iAlignLeft.GroupIndex = 1
			Me.iAlignLeft.Hint = "Align Left"
			Me.iAlignLeft.Id = 27
			Me.iAlignLeft.ImageIndex = 18
			Me.iAlignLeft.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L))
			Me.iAlignLeft.Name = "iAlignLeft"
			' 
			' iCenter
			' 
			Me.iCenter.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.iCenter.Caption = "&Center"
			Me.iCenter.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
			Me.iCenter.Description = "Centers the selected text."
			Me.iCenter.GroupIndex = 1
			Me.iCenter.Hint = "Center"
			Me.iCenter.Id = 28
			Me.iCenter.ImageIndex = 19
			Me.iCenter.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E))
			Me.iCenter.Name = "iCenter"
			' 
			' iAlignRight
			' 
			Me.iAlignRight.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.iAlignRight.Caption = "Align &Right"
			Me.iAlignRight.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
			Me.iAlignRight.Description = "Aligns the selected text to the right."
			Me.iAlignRight.GroupIndex = 1
			Me.iAlignRight.Hint = "Align Right"
			Me.iAlignRight.Id = 29
			Me.iAlignRight.ImageIndex = 20
			Me.iAlignRight.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R))
			Me.iAlignRight.Name = "iAlignRight"
			' 
			' bar4
			' 
			Me.bar4.BarName = "Font"
			Me.bar4.DockCol = 0
			Me.bar4.DockRow = 0
			Me.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Right
			Me.bar4.FloatLocation = New System.Drawing.Point(493, 252)
			Me.bar4.FloatSize = New System.Drawing.Size(48, 26)
			Me.bar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.iFont), New DevExpress.XtraBars.LinkPersistInfo(Me.iFontColor), New DevExpress.XtraBars.LinkPersistInfo(Me.iEdit, True)})
			Me.bar4.Text = "Font"
			' 
			' iEdit
			' 
			Me.iEdit.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.iEdit.Caption = "&Edit..."
			Me.iEdit.CategoryGuid = New System.Guid("78945463-36c5-4beb-a57f-d50b6a74e9b9")
			Me.iEdit.Hint = "Edit Menu"
			Me.iEdit.Id = 31
			Me.iEdit.ImageIndex = 22
			Me.iEdit.Name = "iEdit"
			' 
			' bar5
			' 
			Me.bar5.BarName = "StatusBar"
			Me.bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
			Me.bar5.DockCol = 0
			Me.bar5.DockRow = 0
			Me.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
			Me.bar5.FloatLocation = New System.Drawing.Point(86, 499)
			Me.bar5.FloatSize = New System.Drawing.Size(48, 26)
			Me.bar5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.sPosition), New DevExpress.XtraBars.LinkPersistInfo(Me.sModifier), New DevExpress.XtraBars.LinkPersistInfo(Me.sDocName)})
			Me.bar5.OptionsBar.AllowQuickCustomization = False
			Me.bar5.OptionsBar.DrawDragBorder = False
			Me.bar5.OptionsBar.DrawSizeGrip = True
			Me.bar5.OptionsBar.UseWholeRow = True
			Me.bar5.Text = "StatusBar"
			' 
			' sPosition
			' 
			Me.sPosition.AutoSize = DevExpress.XtraBars.BarStaticItemSize.None
			Me.sPosition.Caption = "Position"
			Me.sPosition.CategoryGuid = New System.Guid("77795bb7-9bc5-4dd2-a297-cc758682e23d")
			Me.sPosition.Id = 32
			Me.sPosition.Name = "sPosition"
			Me.sPosition.RightIndent = 2
			Me.sPosition.TextAlignment = System.Drawing.StringAlignment.Center
			Me.sPosition.Width = 145
			' 
			' sModifier
			' 
			Me.sModifier.AutoSize = DevExpress.XtraBars.BarStaticItemSize.None
			Me.sModifier.Caption = "Modifier"
			Me.sModifier.CategoryGuid = New System.Guid("77795bb7-9bc5-4dd2-a297-cc758682e23d")
			Me.sModifier.Id = 33
			Me.sModifier.Name = "sModifier"
			Me.sModifier.RightIndent = 2
			Me.sModifier.TextAlignment = System.Drawing.StringAlignment.Center
			Me.sModifier.Width = 60
			' 
			' sDocName
			' 
			Me.sDocName.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring
			Me.sDocName.Caption = "Name"
			Me.sDocName.CategoryGuid = New System.Guid("77795bb7-9bc5-4dd2-a297-cc758682e23d")
			Me.sDocName.Id = 34
			Me.sDocName.Name = "sDocName"
			Me.sDocName.TextAlignment = System.Drawing.StringAlignment.Near
			Me.sDocName.Width = 245
			' 
			' bar7
			' 
			Me.bar7.BarName = "PaintStyle"
			Me.bar7.DockCol = 1
			Me.bar7.DockRow = 1
			Me.bar7.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar7.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.iPaintStyle)})
			Me.bar7.Offset = 226
			Me.bar7.OptionsBar.AllowQuickCustomization = False
			Me.bar7.OptionsBar.RotateWhenVertical = False
			Me.bar7.Text = "PaintStyle"
			' 
			' iPaintStyle
			' 
			Me.iPaintStyle.Caption = "Paint Style"
			Me.iPaintStyle.CategoryGuid = New System.Guid("7102d69f-976b-49fe-978d-97325e115e10")
			Me.iPaintStyle.Id = 55
			Me.iPaintStyle.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.ipsDefault), New DevExpress.XtraBars.LinkPersistInfo(Me.ipsWXP), New DevExpress.XtraBars.LinkPersistInfo(Me.ipsOXP), New DevExpress.XtraBars.LinkPersistInfo(Me.ipsO2K), New DevExpress.XtraBars.LinkPersistInfo(Me.ipsO3)})
			Me.iPaintStyle.Name = "iPaintStyle"
			Me.iPaintStyle.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
			' 
			' ipsDefault
			' 
			Me.ipsDefault.Caption = "Default"
			Me.ipsDefault.CategoryGuid = New System.Guid("7102d69f-976b-49fe-978d-97325e115e10")
			Me.ipsDefault.Description = "Default"
			Me.ipsDefault.Id = 74
			Me.ipsDefault.Name = "ipsDefault"
			' 
			' ipsWXP
			' 
			Me.ipsWXP.Caption = "Windows XP"
			Me.ipsWXP.CategoryGuid = New System.Guid("7102d69f-976b-49fe-978d-97325e115e10")
			Me.ipsWXP.Description = "WindowsXP"
			Me.ipsWXP.Id = 56
			Me.ipsWXP.ImageIndex = 25
			Me.ipsWXP.Name = "ipsWXP"
			' 
			' ipsOXP
			' 
			Me.ipsOXP.Caption = "Office XP"
			Me.ipsOXP.CategoryGuid = New System.Guid("7102d69f-976b-49fe-978d-97325e115e10")
			Me.ipsOXP.Description = "OfficeXP"
			Me.ipsOXP.Id = 57
			Me.ipsOXP.ImageIndex = 23
			Me.ipsOXP.Name = "ipsOXP"
			' 
			' ipsO2K
			' 
			Me.ipsO2K.Caption = "Office 2000"
			Me.ipsO2K.CategoryGuid = New System.Guid("7102d69f-976b-49fe-978d-97325e115e10")
			Me.ipsO2K.Description = "Office2000"
			Me.ipsO2K.Id = 58
			Me.ipsO2K.ImageIndex = 24
			Me.ipsO2K.Name = "ipsO2K"
			' 
			' ipsO3
			' 
			Me.ipsO3.Caption = "Office 2003"
			Me.ipsO3.CategoryGuid = New System.Guid("7102d69f-976b-49fe-978d-97325e115e10")
			Me.ipsO3.Description = "Office2003"
			Me.ipsO3.Id = 69
			Me.ipsO3.ImageIndex = 26
			Me.ipsO3.Name = "ipsO3"
			' 
			' barDockControl1
			' 
			Me.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControl1.Location = New System.Drawing.Point(0, 0)
			Me.barDockControl1.Size = New System.Drawing.Size(550, 78)
			' 
			' barDockControl2
			' 
			Me.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControl2.Location = New System.Drawing.Point(0, 374)
			Me.barDockControl2.Size = New System.Drawing.Size(550, 28)
			' 
			' barDockControl3
			' 
			Me.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControl3.Location = New System.Drawing.Point(0, 78)
			Me.barDockControl3.Size = New System.Drawing.Size(0, 296)
			' 
			' barDockControl4
			' 
			Me.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControl4.Location = New System.Drawing.Point(513, 78)
			Me.barDockControl4.Size = New System.Drawing.Size(37, 296)
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
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
			Me.imageList1.Images.SetKeyName(24, "")
			Me.imageList1.Images.SetKeyName(25, "")
			Me.imageList1.Images.SetKeyName(26, "")
			' 
			' treeList1
			' 
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.treeListColumn1})
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(0, 78)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.OptionsBehavior.Editable = False
			Me.treeList1.Size = New System.Drawing.Size(513, 296)
			Me.treeList1.TabIndex = 4
			' 
			' treeListColumn1
			' 
			Me.treeListColumn1.Caption = "Toolbar / Item Name"
			Me.treeListColumn1.FieldName = "Toolbar / Item Name"
			Me.treeListColumn1.Name = "treeListColumn1"
			Me.treeListColumn1.Visible = True
			Me.treeListColumn1.VisibleIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(550, 402)
			Me.Controls.Add(Me.treeList1)
			Me.Controls.Add(Me.barDockControl3)
			Me.Controls.Add(Me.barDockControl4)
			Me.Controls.Add(Me.barDockControl2)
			Me.Controls.Add(Me.barDockControl1)
			Me.Name = "Form1"
			Me.Text = "How to enumerate buttons in a menu or on a toolbar"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			barManager1.ForceInitialize()
			FillItemTree()
		End Sub

		Private Sub FillItemTree()
			treeList1.BeginUnboundLoad()
			treeList1.ClearNodes()
			Try
				For Each bar As Bar In barManager1.Bars
					FillItemBranch(treeList1.AppendNode(New Object() {bar.Text}, -1), bar.ItemLinks)
				Next bar
			Finally
				treeList1.EndUnboundLoad()
			End Try
		End Sub

		Private Sub FillItemBranch(ByVal parent As TreeListNode, ByVal links As BarItemLinkCollection)
			For Each link As BarItemLink In links
				Dim node As TreeListNode = parent.TreeList.AppendNode(New Object() {link.Caption}, parent)
				If TypeOf link.Item Is BarSubItem Then
					FillItemBranch(node, (CType(link.Item, BarSubItem)).ItemLinks)
				End If
			Next link
		End Sub

		Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem1.ItemClick
			FillItemTree()
		End Sub
	End Class
End Namespace
