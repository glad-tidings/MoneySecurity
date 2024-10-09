Public Class Main
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents IFT1 As System.Windows.Forms.PictureBox
    Friend WithEvents IFT2 As System.Windows.Forms.PictureBox
    Friend WithEvents IFT3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Tab As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Friend WithEvents MList As System.Windows.Forms.ListView
    Friend WithEvents DeleteB As System.Windows.Forms.Button
    Friend WithEvents EditB As System.Windows.Forms.Button
    Friend WithEvents AddB As System.Windows.Forms.Button
    Friend WithEvents Panel As Microsoft.VisualBasic.Compatibility.VB6.PanelArray
    Friend WithEvents TabTitrL As System.Windows.Forms.Label
    Friend WithEvents WelcomePanel As System.Windows.Forms.Panel
    Friend WithEvents AList As System.Windows.Forms.ListView
    Friend WithEvents MoveB As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents BMT As System.Windows.Forms.Label
    Friend WithEvents LMT As System.Windows.Forms.Label
    Friend WithEvents LBT As System.Windows.Forms.Label
    Friend WithEvents BPGT As System.Windows.Forms.Label
    Friend WithEvents BGDT As System.Windows.Forms.Label
    Friend WithEvents AdList As System.Windows.Forms.ListView
    Friend WithEvents BMDeleteB As System.Windows.Forms.Button
    Friend WithEvents BMEditB As System.Windows.Forms.Button
    Friend WithEvents BMAddB As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BrowseB As System.Windows.Forms.Button
    Friend WithEvents BackupB As System.Windows.Forms.Button
    Friend WithEvents RestoreB As System.Windows.Forms.Button
    Friend WithEvents ReList As System.Windows.Forms.ListView
    Friend WithEvents DateList As System.Windows.Forms.ComboBox
    Friend WithEvents LogoImage As System.Windows.Forms.PictureBox
    Friend WithEvents MoshtariEn As System.Windows.Forms.StatusBarPanel
    Friend WithEvents ArchiveEn As System.Windows.Forms.StatusBarPanel
    Friend WithEvents BackupEn As System.Windows.Forms.StatusBarPanel
    Friend WithEvents ReportEn As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Time As System.Windows.Forms.Timer
    Friend WithEvents StTime As System.Windows.Forms.StatusBarPanel
    Friend WithEvents LMTMenu As System.Windows.Forms.MenuItem
    Friend WithEvents LMTOMenu As System.Windows.Forms.MenuItem
    Friend WithEvents LMTViewMenu As System.Windows.Forms.MenuItem
    Friend WithEvents LMTAddMenu As System.Windows.Forms.MenuItem
    Friend WithEvents LMTEditMenu As System.Windows.Forms.MenuItem
    Friend WithEvents LMTDeleteMenu As System.Windows.Forms.MenuItem
    Friend WithEvents LBTMenu As System.Windows.Forms.MenuItem
    Friend WithEvents LBTOMenu As System.Windows.Forms.MenuItem
    Friend WithEvents LBTViewMenu As System.Windows.Forms.MenuItem
    Friend WithEvents LBTMoveMenu As System.Windows.Forms.MenuItem
    Friend WithEvents FindN1Menu As System.Windows.Forms.MenuItem
    Friend WithEvents FindN2Menu As System.Windows.Forms.MenuItem
    Friend WithEvents AboutMenu As System.Windows.Forms.MenuItem
    Friend WithEvents BMTMenu As System.Windows.Forms.MenuItem
    Friend WithEvents BPGTMenu As System.Windows.Forms.MenuItem
    Friend WithEvents BMTOMenu As System.Windows.Forms.MenuItem
    Friend WithEvents BGDTMenu As System.Windows.Forms.MenuItem
    Friend WithEvents ExitMenu As System.Windows.Forms.MenuItem
    Friend WithEvents OnAdminID As System.Windows.Forms.TextBox
    Friend WithEvents IsGod As System.Windows.Forms.CheckBox
    Friend WithEvents AboutLogo As System.Windows.Forms.PictureBox
    Friend WithEvents BMTAddMenu As System.Windows.Forms.MenuItem
    Friend WithEvents BMTEditMenu As System.Windows.Forms.MenuItem
    Friend WithEvents BMTDeleteMenu As System.Windows.Forms.MenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.MenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.MenuItem
    Friend WithEvents HelpOMenu As System.Windows.Forms.MenuItem
    Friend WithEvents Browse As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents BackupFA As System.Windows.Forms.Label
    Friend WithEvents SaveB As System.Windows.Forms.Button
    Friend WithEvents AutoBackup As System.Windows.Forms.CheckBox
    Friend WithEvents SaveFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents LogoutMenu As System.Windows.Forms.MenuItem
    Friend WithEvents OpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DIPanel As System.Windows.Forms.Panel
    Friend WithEvents DIT As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LMPanel As System.Windows.Forms.Panel
    Friend WithEvents LBPanel As System.Windows.Forms.Panel
    Friend WithEvents BMPanel As System.Windows.Forms.Panel
    Friend WithEvents BPGPanel As System.Windows.Forms.Panel
    Friend WithEvents BGDPanel As System.Windows.Forms.Panel
    Friend WithEvents DBPanel As System.Windows.Forms.Panel
    Friend WithEvents DIList As System.Windows.Forms.ListView
    Friend WithEvents DIDeleteB As System.Windows.Forms.Button
    Friend WithEvents WriteB As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader27 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader28 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GetAlarmList As System.Windows.Forms.Timer
    Friend WithEvents SetAlarm As System.Windows.Forms.Timer
    Friend WithEvents AlarmList As System.Windows.Forms.ListView
    Friend WithEvents UnlockMenu As System.Windows.Forms.MenuItem
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Licensed As System.Windows.Forms.Label
    Friend WithEvents BackupFAO As System.Windows.Forms.TextBox
    Friend WithEvents FindN4Menu As System.Windows.Forms.MenuItem
    Friend WithEvents FindN3Menu As System.Windows.Forms.MenuItem
    Friend WithEvents DITMenu As System.Windows.Forms.MenuItem
    Friend WithEvents Line1Menu As System.Windows.Forms.MenuItem
    Friend WithEvents CalcMenu As System.Windows.Forms.MenuItem
    Friend WithEvents IconTry As System.Windows.Forms.NotifyIcon
    Friend WithEvents ExitConMenu As System.Windows.Forms.MenuItem
    Friend WithEvents LIne1ConMenu As System.Windows.Forms.MenuItem
    Friend WithEvents BackupConMenu As System.Windows.Forms.MenuItem
    Friend WithEvents DayList As System.Windows.Forms.ComboBox
    Friend WithEvents DayCheck As System.Windows.Forms.RadioButton
    Friend WithEvents DateCheck As System.Windows.Forms.RadioButton
    Friend WithEvents RPrintB As System.Windows.Forms.Button
    Friend WithEvents SysTryMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents HVPanel As System.Windows.Forms.Panel
    Friend WithEvents HBPanel As System.Windows.Forms.Panel
    Friend WithEvents VHesabEn As System.Windows.Forms.StatusBarPanel
    Friend WithEvents BHesabEn As System.Windows.Forms.StatusBarPanel
    Friend WithEvents UserLogin As System.Windows.Forms.StatusBarPanel
    Friend WithEvents AdminAcc As System.Windows.Forms.StatusBarPanel
    Friend WithEvents VHT As System.Windows.Forms.Label
    Friend WithEvents BHT As System.Windows.Forms.Label
    Friend WithEvents VHDeleteB As System.Windows.Forms.Button
    Friend WithEvents VHEditB As System.Windows.Forms.Button
    Friend WithEvents VHAddB As System.Windows.Forms.Button
    Friend WithEvents BHDeleteB As System.Windows.Forms.Button
    Friend WithEvents BHEditB As System.Windows.Forms.Button
    Friend WithEvents BHAddB As System.Windows.Forms.Button
    Friend WithEvents HMenu As System.Windows.Forms.MenuItem
    Friend WithEvents VHTMenu As System.Windows.Forms.MenuItem
    Friend WithEvents BHTMenu As System.Windows.Forms.MenuItem
    Friend WithEvents VHAddMenu As System.Windows.Forms.MenuItem
    Friend WithEvents VHEditMenu As System.Windows.Forms.MenuItem
    Friend WithEvents VHDeleteMenu As System.Windows.Forms.MenuItem
    Friend WithEvents VHPrintMenu As System.Windows.Forms.MenuItem
    Friend WithEvents LMTPrintMenu As System.Windows.Forms.MenuItem
    Friend WithEvents BHAddMenu As System.Windows.Forms.MenuItem
    Friend WithEvents BHEditMenu As System.Windows.Forms.MenuItem
    Friend WithEvents BHDeleteMenu As System.Windows.Forms.MenuItem
    Friend WithEvents BHPrintMenu As System.Windows.Forms.MenuItem
    Friend WithEvents VHTOMenu As System.Windows.Forms.MenuItem
    Friend WithEvents BHTOMenu As System.Windows.Forms.MenuItem
    Friend WithEvents DateBGDTMenu As System.Windows.Forms.MenuItem
    Friend WithEvents DayBGDTMenu As System.Windows.Forms.MenuItem
    Friend WithEvents ActiveUnB As System.Windows.Forms.Button
    Friend WithEvents HVList As System.Windows.Forms.ListView
    Friend WithEvents HBList As System.Windows.Forms.ListView
    Friend WithEvents BSGT As System.Windows.Forms.Label
    Friend WithEvents DBT As System.Windows.Forms.Label
    Friend WithEvents BSGPanel As System.Windows.Forms.Panel
    Friend WithEvents SGList As System.Windows.Forms.ListView
    Friend WithEvents SGDeleteB As System.Windows.Forms.Button
    Friend WithEvents SGEditB As System.Windows.Forms.Button
    Friend WithEvents SGAddB As System.Windows.Forms.Button
    Friend WithEvents MSBPrintB As System.Windows.Forms.Button
    Friend WithEvents SGEn As System.Windows.Forms.StatusBarPanel
    Friend WithEvents AdminEn As System.Windows.Forms.StatusBarPanel
    Friend WithEvents SGTMenu As System.Windows.Forms.MenuItem
    Friend WithEvents SGTOMenu As System.Windows.Forms.MenuItem
    Friend WithEvents SGTViewMenu As System.Windows.Forms.MenuItem
    Friend WithEvents SGTAddMenu As System.Windows.Forms.MenuItem
    Friend WithEvents SGTEditMenu As System.Windows.Forms.MenuItem
    Friend WithEvents SGTDeleteMenu As System.Windows.Forms.MenuItem
    Friend WithEvents SGSBPrintB As System.Windows.Forms.Button
    Friend WithEvents ListsMenu As System.Windows.Forms.MenuItem
    Friend WithEvents DayListMenu As System.Windows.Forms.MenuItem
    Friend WithEvents DirListMenu As System.Windows.Forms.MenuItem
    Friend WithEvents HelpListMenu As System.Windows.Forms.MenuItem
    Friend WithEvents MoshtariListMenu As System.Windows.Forms.MenuItem
    Friend WithEvents Line3Menu As System.Windows.Forms.MenuItem
    Friend WithEvents Line4Menu As System.Windows.Forms.MenuItem
    Friend WithEvents Line5Menu As System.Windows.Forms.MenuItem
    Friend WithEvents Line6Menu As System.Windows.Forms.MenuItem
    Friend WithEvents Line7Menu As System.Windows.Forms.MenuItem
    Friend WithEvents Line8Menu As System.Windows.Forms.MenuItem
    Friend WithEvents Line9Menu As System.Windows.Forms.MenuItem
    Friend WithEvents Line10Menu As System.Windows.Forms.MenuItem
    Friend WithEvents Line12Menu As System.Windows.Forms.MenuItem
    Friend WithEvents ReportsMenu As System.Windows.Forms.MenuItem
    Friend WithEvents PStatusBar As System.Windows.Forms.StatusBar
    Friend WithEvents UStatusBar As System.Windows.Forms.StatusBar
    Friend WithEvents HBReportB As System.Windows.Forms.Button
    Friend WithEvents HVReportB As System.Windows.Forms.Button
    Friend WithEvents ChangeTTB As System.Windows.Forms.Button
    Friend WithEvents TTarikh As System.Windows.Forms.Label
    Friend WithEvents ChangeFTB As System.Windows.Forms.Button
    Friend WithEvents FTarikh As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ViewB As System.Windows.Forms.Button
    Friend WithEvents FTCheck As System.Windows.Forms.RadioButton
    Friend WithEvents BHAllDeleteB As System.Windows.Forms.Button
    Friend WithEvents VHAllDeleteB As System.Windows.Forms.Button
    Friend WithEvents HVRMenu As System.Windows.Forms.MenuItem
    Friend WithEvents HBRMenu As System.Windows.Forms.MenuItem
    Friend WithEvents SGResidB As System.Windows.Forms.Button
    Friend WithEvents FindMenu As System.Windows.Forms.MenuItem
    Friend WithEvents StDate As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Support As System.Windows.Forms.Label
    Friend WithEvents Company As System.Windows.Forms.Label
    Friend WithEvents CancelPB As System.Windows.Forms.Button
    Friend WithEvents Programmer As System.Windows.Forms.Label
    Friend WithEvents Line2Menu As System.Windows.Forms.MenuItem
    Friend WithEvents MoveSysTryMenu As System.Windows.Forms.MenuItem
    Friend WithEvents Line34Menu As System.Windows.Forms.MenuItem
    Friend WithEvents ShowConMenu As System.Windows.Forms.MenuItem
    Friend WithEvents LIne2ConMenu As System.Windows.Forms.MenuItem
    Friend WithEvents FileFRestore As Microsoft.VisualBasic.Compatibility.VB6.FileListBox
    Friend WithEvents BurnB As System.Windows.Forms.Button
    Friend WithEvents MListMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents GoldPicMenu As System.Windows.Forms.MenuItem
    Friend WithEvents ViewGoldPicMenu As System.Windows.Forms.MenuItem
    Friend WithEvents PrintGoldPicMenu As System.Windows.Forms.MenuItem
    Friend WithEvents PicPrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents PicPrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents PicPrintPreviewDialog As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents OptionsMenu As System.Windows.Forms.MenuItem
    Friend WithEvents AutoSaveChangeMenu As System.Windows.Forms.MenuItem
    Friend WithEvents MListIDHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents MListPicExHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents MListCGoldHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents MListTellHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents MListMostajerHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents MListMoajerHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents MListShParvandeNumHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents AlistIDHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents AlistTellHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents AlistMostajerHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents AlistMoajerHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents AlistShParvandeNumHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents IDAdHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents GodAdHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents EnDisAdHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents AccessAdHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents FNameAdHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents UserAdHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents DIListIDHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents DIListTarikhHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents DIListSubjectHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents DIListWriterHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents HVListIDHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents HVListTarikhHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents HVListPriceHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents HVListShParvandehNumHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents HVListMoajerHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents HVListMostajerHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents HBListIDHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents HBListTarikhHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents HBListPriceHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents HBListFSubjectHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents HBListPardakhterHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents SGListIDHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents SGListShShHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents SGListFathNameHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents SGListSGNameHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents SGListGHNumHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents ReListIDHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents ReListMostajerHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents ReListMoajerHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents ReListShParvandehNumHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents HVListTellHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents HBListTellHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents ReListTellHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents AllCB As System.Windows.Forms.Button
    Friend WithEvents AllCMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents AllCGMenu As System.Windows.Forms.MenuItem
    Friend WithEvents AllCSGMenu As System.Windows.Forms.MenuItem
    Friend WithEvents FullMList As System.Windows.Forms.CheckBox
    Friend WithEvents MPicMenu As System.Windows.Forms.MenuItem
    Friend WithEvents ViewMPicMenu As System.Windows.Forms.MenuItem
    Friend WithEvents PrintMPicMenu As System.Windows.Forms.MenuItem
    Friend WithEvents MListMPicExHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents AllPrintMMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents MSBPrintMenu As System.Windows.Forms.MenuItem
    Friend WithEvents MPrintMenu As System.Windows.Forms.MenuItem
    Friend WithEvents MInfPrintMenu As System.Windows.Forms.MenuItem
    Friend WithEvents MFormPrintMenu As System.Windows.Forms.MenuItem
    Friend WithEvents AllCMVMenu As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Main))
        Me.MainMenu = New System.Windows.Forms.MainMenu
        Me.FileMenu = New System.Windows.Forms.MenuItem
        Me.BMTMenu = New System.Windows.Forms.MenuItem
        Me.BMTOMenu = New System.Windows.Forms.MenuItem
        Me.Line6Menu = New System.Windows.Forms.MenuItem
        Me.BMTAddMenu = New System.Windows.Forms.MenuItem
        Me.BMTEditMenu = New System.Windows.Forms.MenuItem
        Me.BMTDeleteMenu = New System.Windows.Forms.MenuItem
        Me.LMTMenu = New System.Windows.Forms.MenuItem
        Me.LMTOMenu = New System.Windows.Forms.MenuItem
        Me.Line7Menu = New System.Windows.Forms.MenuItem
        Me.LMTViewMenu = New System.Windows.Forms.MenuItem
        Me.LMTAddMenu = New System.Windows.Forms.MenuItem
        Me.LMTEditMenu = New System.Windows.Forms.MenuItem
        Me.LMTDeleteMenu = New System.Windows.Forms.MenuItem
        Me.LMTPrintMenu = New System.Windows.Forms.MenuItem
        Me.LBTMenu = New System.Windows.Forms.MenuItem
        Me.LBTOMenu = New System.Windows.Forms.MenuItem
        Me.Line8Menu = New System.Windows.Forms.MenuItem
        Me.LBTViewMenu = New System.Windows.Forms.MenuItem
        Me.LBTMoveMenu = New System.Windows.Forms.MenuItem
        Me.BPGTMenu = New System.Windows.Forms.MenuItem
        Me.BGDTMenu = New System.Windows.Forms.MenuItem
        Me.DateBGDTMenu = New System.Windows.Forms.MenuItem
        Me.DayBGDTMenu = New System.Windows.Forms.MenuItem
        Me.DITMenu = New System.Windows.Forms.MenuItem
        Me.HMenu = New System.Windows.Forms.MenuItem
        Me.VHTMenu = New System.Windows.Forms.MenuItem
        Me.VHTOMenu = New System.Windows.Forms.MenuItem
        Me.Line9Menu = New System.Windows.Forms.MenuItem
        Me.VHAddMenu = New System.Windows.Forms.MenuItem
        Me.VHEditMenu = New System.Windows.Forms.MenuItem
        Me.VHDeleteMenu = New System.Windows.Forms.MenuItem
        Me.VHPrintMenu = New System.Windows.Forms.MenuItem
        Me.BHTMenu = New System.Windows.Forms.MenuItem
        Me.BHTOMenu = New System.Windows.Forms.MenuItem
        Me.Line10Menu = New System.Windows.Forms.MenuItem
        Me.BHAddMenu = New System.Windows.Forms.MenuItem
        Me.BHEditMenu = New System.Windows.Forms.MenuItem
        Me.BHDeleteMenu = New System.Windows.Forms.MenuItem
        Me.BHPrintMenu = New System.Windows.Forms.MenuItem
        Me.SGTMenu = New System.Windows.Forms.MenuItem
        Me.SGTOMenu = New System.Windows.Forms.MenuItem
        Me.Line12Menu = New System.Windows.Forms.MenuItem
        Me.SGTViewMenu = New System.Windows.Forms.MenuItem
        Me.SGTAddMenu = New System.Windows.Forms.MenuItem
        Me.SGTEditMenu = New System.Windows.Forms.MenuItem
        Me.SGTDeleteMenu = New System.Windows.Forms.MenuItem
        Me.Line1Menu = New System.Windows.Forms.MenuItem
        Me.UnlockMenu = New System.Windows.Forms.MenuItem
        Me.Line2Menu = New System.Windows.Forms.MenuItem
        Me.LogoutMenu = New System.Windows.Forms.MenuItem
        Me.Line3Menu = New System.Windows.Forms.MenuItem
        Me.MoveSysTryMenu = New System.Windows.Forms.MenuItem
        Me.Line34Menu = New System.Windows.Forms.MenuItem
        Me.CalcMenu = New System.Windows.Forms.MenuItem
        Me.Line4Menu = New System.Windows.Forms.MenuItem
        Me.ExitMenu = New System.Windows.Forms.MenuItem
        Me.FindMenu = New System.Windows.Forms.MenuItem
        Me.FindN1Menu = New System.Windows.Forms.MenuItem
        Me.FindN2Menu = New System.Windows.Forms.MenuItem
        Me.FindN3Menu = New System.Windows.Forms.MenuItem
        Me.FindN4Menu = New System.Windows.Forms.MenuItem
        Me.ListsMenu = New System.Windows.Forms.MenuItem
        Me.DayListMenu = New System.Windows.Forms.MenuItem
        Me.DirListMenu = New System.Windows.Forms.MenuItem
        Me.HelpListMenu = New System.Windows.Forms.MenuItem
        Me.MoshtariListMenu = New System.Windows.Forms.MenuItem
        Me.ReportsMenu = New System.Windows.Forms.MenuItem
        Me.HVRMenu = New System.Windows.Forms.MenuItem
        Me.HBRMenu = New System.Windows.Forms.MenuItem
        Me.OptionsMenu = New System.Windows.Forms.MenuItem
        Me.AutoSaveChangeMenu = New System.Windows.Forms.MenuItem
        Me.HelpMenu = New System.Windows.Forms.MenuItem
        Me.HelpOMenu = New System.Windows.Forms.MenuItem
        Me.Line5Menu = New System.Windows.Forms.MenuItem
        Me.AboutMenu = New System.Windows.Forms.MenuItem
        Me.IFT1 = New System.Windows.Forms.PictureBox
        Me.IFT2 = New System.Windows.Forms.PictureBox
        Me.IFT3 = New System.Windows.Forms.PictureBox
        Me.BMT = New System.Windows.Forms.Label
        Me.LMT = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Tab = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.LBT = New System.Windows.Forms.Label
        Me.BPGT = New System.Windows.Forms.Label
        Me.BGDT = New System.Windows.Forms.Label
        Me.VHT = New System.Windows.Forms.Label
        Me.DIT = New System.Windows.Forms.Label
        Me.BHT = New System.Windows.Forms.Label
        Me.BSGT = New System.Windows.Forms.Label
        Me.DBT = New System.Windows.Forms.Label
        Me.TabTitrL = New System.Windows.Forms.Label
        Me.LMPanel = New System.Windows.Forms.Panel
        Me.MSBPrintB = New System.Windows.Forms.Button
        Me.MList = New System.Windows.Forms.ListView
        Me.MListIDHeader = New System.Windows.Forms.ColumnHeader
        Me.MListMPicExHeader = New System.Windows.Forms.ColumnHeader
        Me.MListPicExHeader = New System.Windows.Forms.ColumnHeader
        Me.MListCGoldHeader = New System.Windows.Forms.ColumnHeader
        Me.MListTellHeader = New System.Windows.Forms.ColumnHeader
        Me.MListMostajerHeader = New System.Windows.Forms.ColumnHeader
        Me.MListMoajerHeader = New System.Windows.Forms.ColumnHeader
        Me.MListShParvandeNumHeader = New System.Windows.Forms.ColumnHeader
        Me.DeleteB = New System.Windows.Forms.Button
        Me.EditB = New System.Windows.Forms.Button
        Me.AddB = New System.Windows.Forms.Button
        Me.Panel = New Microsoft.VisualBasic.Compatibility.VB6.PanelArray(Me.components)
        Me.LBPanel = New System.Windows.Forms.Panel
        Me.CancelPB = New System.Windows.Forms.Button
        Me.AList = New System.Windows.Forms.ListView
        Me.AlistIDHeader = New System.Windows.Forms.ColumnHeader
        Me.AlistTellHeader = New System.Windows.Forms.ColumnHeader
        Me.AlistMostajerHeader = New System.Windows.Forms.ColumnHeader
        Me.AlistMoajerHeader = New System.Windows.Forms.ColumnHeader
        Me.AlistShParvandeNumHeader = New System.Windows.Forms.ColumnHeader
        Me.MoveB = New System.Windows.Forms.Button
        Me.BMPanel = New System.Windows.Forms.Panel
        Me.BMDeleteB = New System.Windows.Forms.Button
        Me.FullMList = New System.Windows.Forms.CheckBox
        Me.ActiveUnB = New System.Windows.Forms.Button
        Me.OnAdminID = New System.Windows.Forms.TextBox
        Me.IsGod = New System.Windows.Forms.CheckBox
        Me.AdList = New System.Windows.Forms.ListView
        Me.IDAdHeader = New System.Windows.Forms.ColumnHeader
        Me.GodAdHeader = New System.Windows.Forms.ColumnHeader
        Me.EnDisAdHeader = New System.Windows.Forms.ColumnHeader
        Me.AccessAdHeader = New System.Windows.Forms.ColumnHeader
        Me.FNameAdHeader = New System.Windows.Forms.ColumnHeader
        Me.UserAdHeader = New System.Windows.Forms.ColumnHeader
        Me.BMEditB = New System.Windows.Forms.Button
        Me.BMAddB = New System.Windows.Forms.Button
        Me.BPGPanel = New System.Windows.Forms.Panel
        Me.BurnB = New System.Windows.Forms.Button
        Me.FileFRestore = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox
        Me.SaveB = New System.Windows.Forms.Button
        Me.RestoreB = New System.Windows.Forms.Button
        Me.BackupB = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.AutoBackup = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BackupFA = New System.Windows.Forms.Label
        Me.BrowseB = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.BackupFAO = New System.Windows.Forms.TextBox
        Me.BGDPanel = New System.Windows.Forms.Panel
        Me.ViewB = New System.Windows.Forms.Button
        Me.ChangeTTB = New System.Windows.Forms.Button
        Me.TTarikh = New System.Windows.Forms.Label
        Me.ChangeFTB = New System.Windows.Forms.Button
        Me.FTarikh = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.FTCheck = New System.Windows.Forms.RadioButton
        Me.RPrintB = New System.Windows.Forms.Button
        Me.DayList = New System.Windows.Forms.ComboBox
        Me.DayCheck = New System.Windows.Forms.RadioButton
        Me.DateList = New System.Windows.Forms.ComboBox
        Me.DateCheck = New System.Windows.Forms.RadioButton
        Me.ReList = New System.Windows.Forms.ListView
        Me.ReListIDHeader = New System.Windows.Forms.ColumnHeader
        Me.ReListTellHeader = New System.Windows.Forms.ColumnHeader
        Me.ReListMostajerHeader = New System.Windows.Forms.ColumnHeader
        Me.ReListMoajerHeader = New System.Windows.Forms.ColumnHeader
        Me.ReListShParvandehNumHeader = New System.Windows.Forms.ColumnHeader
        Me.DBPanel = New System.Windows.Forms.Panel
        Me.Programmer = New System.Windows.Forms.Label
        Me.Licensed = New System.Windows.Forms.Label
        Me.Support = New System.Windows.Forms.Label
        Me.Company = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.AboutLogo = New System.Windows.Forms.PictureBox
        Me.DIPanel = New System.Windows.Forms.Panel
        Me.DIList = New System.Windows.Forms.ListView
        Me.DIListIDHeader = New System.Windows.Forms.ColumnHeader
        Me.DIListTarikhHeader = New System.Windows.Forms.ColumnHeader
        Me.DIListSubjectHeader = New System.Windows.Forms.ColumnHeader
        Me.DIListWriterHeader = New System.Windows.Forms.ColumnHeader
        Me.DIDeleteB = New System.Windows.Forms.Button
        Me.WriteB = New System.Windows.Forms.Button
        Me.HVPanel = New System.Windows.Forms.Panel
        Me.VHAllDeleteB = New System.Windows.Forms.Button
        Me.HVReportB = New System.Windows.Forms.Button
        Me.HVList = New System.Windows.Forms.ListView
        Me.HVListIDHeader = New System.Windows.Forms.ColumnHeader
        Me.HVListTarikhHeader = New System.Windows.Forms.ColumnHeader
        Me.HVListPriceHeader = New System.Windows.Forms.ColumnHeader
        Me.HVListTellHeader = New System.Windows.Forms.ColumnHeader
        Me.HVListShParvandehNumHeader = New System.Windows.Forms.ColumnHeader
        Me.HVListMoajerHeader = New System.Windows.Forms.ColumnHeader
        Me.HVListMostajerHeader = New System.Windows.Forms.ColumnHeader
        Me.VHDeleteB = New System.Windows.Forms.Button
        Me.VHEditB = New System.Windows.Forms.Button
        Me.VHAddB = New System.Windows.Forms.Button
        Me.HBPanel = New System.Windows.Forms.Panel
        Me.BHAllDeleteB = New System.Windows.Forms.Button
        Me.HBReportB = New System.Windows.Forms.Button
        Me.HBList = New System.Windows.Forms.ListView
        Me.HBListIDHeader = New System.Windows.Forms.ColumnHeader
        Me.HBListTarikhHeader = New System.Windows.Forms.ColumnHeader
        Me.HBListPriceHeader = New System.Windows.Forms.ColumnHeader
        Me.HBListFSubjectHeader = New System.Windows.Forms.ColumnHeader
        Me.HBListTellHeader = New System.Windows.Forms.ColumnHeader
        Me.HBListPardakhterHeader = New System.Windows.Forms.ColumnHeader
        Me.BHDeleteB = New System.Windows.Forms.Button
        Me.BHEditB = New System.Windows.Forms.Button
        Me.BHAddB = New System.Windows.Forms.Button
        Me.BSGPanel = New System.Windows.Forms.Panel
        Me.AllCB = New System.Windows.Forms.Button
        Me.SGResidB = New System.Windows.Forms.Button
        Me.SGSBPrintB = New System.Windows.Forms.Button
        Me.SGList = New System.Windows.Forms.ListView
        Me.SGListIDHeader = New System.Windows.Forms.ColumnHeader
        Me.SGListShShHeader = New System.Windows.Forms.ColumnHeader
        Me.SGListFathNameHeader = New System.Windows.Forms.ColumnHeader
        Me.SGListSGNameHeader = New System.Windows.Forms.ColumnHeader
        Me.SGListGHNumHeader = New System.Windows.Forms.ColumnHeader
        Me.SGDeleteB = New System.Windows.Forms.Button
        Me.SGEditB = New System.Windows.Forms.Button
        Me.SGAddB = New System.Windows.Forms.Button
        Me.WelcomePanel = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.LogoImage = New System.Windows.Forms.PictureBox
        Me.PStatusBar = New System.Windows.Forms.StatusBar
        Me.StTime = New System.Windows.Forms.StatusBarPanel
        Me.SGEn = New System.Windows.Forms.StatusBarPanel
        Me.BHesabEn = New System.Windows.Forms.StatusBarPanel
        Me.VHesabEn = New System.Windows.Forms.StatusBarPanel
        Me.ReportEn = New System.Windows.Forms.StatusBarPanel
        Me.BackupEn = New System.Windows.Forms.StatusBarPanel
        Me.ArchiveEn = New System.Windows.Forms.StatusBarPanel
        Me.MoshtariEn = New System.Windows.Forms.StatusBarPanel
        Me.Time = New System.Windows.Forms.Timer(Me.components)
        Me.Browse = New System.Windows.Forms.FolderBrowserDialog
        Me.SaveFile = New System.Windows.Forms.SaveFileDialog
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog
        Me.AlarmList = New System.Windows.Forms.ListView
        Me.ColumnHeader22 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader27 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader28 = New System.Windows.Forms.ColumnHeader
        Me.GetAlarmList = New System.Windows.Forms.Timer(Me.components)
        Me.SetAlarm = New System.Windows.Forms.Timer(Me.components)
        Me.IconTry = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SysTryMenu = New System.Windows.Forms.ContextMenu
        Me.ShowConMenu = New System.Windows.Forms.MenuItem
        Me.LIne2ConMenu = New System.Windows.Forms.MenuItem
        Me.BackupConMenu = New System.Windows.Forms.MenuItem
        Me.LIne1ConMenu = New System.Windows.Forms.MenuItem
        Me.ExitConMenu = New System.Windows.Forms.MenuItem
        Me.UStatusBar = New System.Windows.Forms.StatusBar
        Me.StDate = New System.Windows.Forms.StatusBarPanel
        Me.AdminEn = New System.Windows.Forms.StatusBarPanel
        Me.AdminAcc = New System.Windows.Forms.StatusBarPanel
        Me.UserLogin = New System.Windows.Forms.StatusBarPanel
        Me.MListMenu = New System.Windows.Forms.ContextMenu
        Me.GoldPicMenu = New System.Windows.Forms.MenuItem
        Me.ViewGoldPicMenu = New System.Windows.Forms.MenuItem
        Me.PrintGoldPicMenu = New System.Windows.Forms.MenuItem
        Me.MPicMenu = New System.Windows.Forms.MenuItem
        Me.ViewMPicMenu = New System.Windows.Forms.MenuItem
        Me.PrintMPicMenu = New System.Windows.Forms.MenuItem
        Me.PicPrintDocument = New System.Drawing.Printing.PrintDocument
        Me.PicPrintDialog = New System.Windows.Forms.PrintDialog
        Me.PicPrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog
        Me.AllCMenu = New System.Windows.Forms.ContextMenu
        Me.AllCGMenu = New System.Windows.Forms.MenuItem
        Me.AllCSGMenu = New System.Windows.Forms.MenuItem
        Me.AllCMVMenu = New System.Windows.Forms.MenuItem
        Me.AllPrintMMenu = New System.Windows.Forms.ContextMenu
        Me.MSBPrintMenu = New System.Windows.Forms.MenuItem
        Me.MPrintMenu = New System.Windows.Forms.MenuItem
        Me.MInfPrintMenu = New System.Windows.Forms.MenuItem
        Me.MFormPrintMenu = New System.Windows.Forms.MenuItem
        CType(Me.Tab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LMPanel.SuspendLayout()
        CType(Me.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LBPanel.SuspendLayout()
        Me.BMPanel.SuspendLayout()
        Me.BPGPanel.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.BGDPanel.SuspendLayout()
        Me.DBPanel.SuspendLayout()
        Me.DIPanel.SuspendLayout()
        Me.HVPanel.SuspendLayout()
        Me.HBPanel.SuspendLayout()
        Me.BSGPanel.SuspendLayout()
        Me.WelcomePanel.SuspendLayout()
        CType(Me.StTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SGEn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BHesabEn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VHesabEn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportEn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackupEn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArchiveEn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoshtariEn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminEn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminAcc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.FileMenu, Me.FindMenu, Me.ListsMenu, Me.ReportsMenu, Me.OptionsMenu, Me.HelpMenu})
        '
        'FileMenu
        '
        Me.FileMenu.Index = 0
        Me.FileMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.BMTMenu, Me.LMTMenu, Me.LBTMenu, Me.BPGTMenu, Me.BGDTMenu, Me.DITMenu, Me.HMenu, Me.SGTMenu, Me.Line1Menu, Me.UnlockMenu, Me.Line2Menu, Me.LogoutMenu, Me.Line3Menu, Me.MoveSysTryMenu, Me.Line34Menu, Me.CalcMenu, Me.Line4Menu, Me.ExitMenu})
        Me.FileMenu.Text = "فایل"
        '
        'BMTMenu
        '
        Me.BMTMenu.Index = 0
        Me.BMTMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.BMTOMenu, Me.Line6Menu, Me.BMTAddMenu, Me.BMTEditMenu, Me.BMTDeleteMenu})
        Me.BMTMenu.Text = "بخش مدیریت"
        '
        'BMTOMenu
        '
        Me.BMTOMenu.Index = 0
        Me.BMTOMenu.Text = "بخش مدیریت"
        '
        'Line6Menu
        '
        Me.Line6Menu.Index = 1
        Me.Line6Menu.Text = "-"
        '
        'BMTAddMenu
        '
        Me.BMTAddMenu.Index = 2
        Me.BMTAddMenu.Text = "اضافه کردن مدیر جدید"
        '
        'BMTEditMenu
        '
        Me.BMTEditMenu.Index = 3
        Me.BMTEditMenu.Text = "ویرایش اطلاعات مدیر"
        '
        'BMTDeleteMenu
        '
        Me.BMTDeleteMenu.Index = 4
        Me.BMTDeleteMenu.Text = "حذف مدیر"
        '
        'LMTMenu
        '
        Me.LMTMenu.Index = 1
        Me.LMTMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.LMTOMenu, Me.Line7Menu, Me.LMTViewMenu, Me.LMTAddMenu, Me.LMTEditMenu, Me.LMTDeleteMenu, Me.LMTPrintMenu})
        Me.LMTMenu.Text = "لیست مشتریان"
        '
        'LMTOMenu
        '
        Me.LMTOMenu.Index = 0
        Me.LMTOMenu.Text = "لیست مشتریان"
        '
        'Line7Menu
        '
        Me.Line7Menu.Index = 1
        Me.Line7Menu.Text = "-"
        '
        'LMTViewMenu
        '
        Me.LMTViewMenu.Index = 2
        Me.LMTViewMenu.Text = "نمایش اطلاعات مشتری"
        '
        'LMTAddMenu
        '
        Me.LMTAddMenu.Index = 3
        Me.LMTAddMenu.Text = "اضافه کردن مشتری جدید"
        '
        'LMTEditMenu
        '
        Me.LMTEditMenu.Index = 4
        Me.LMTEditMenu.Text = "ویرایش اطلاعات مشتری"
        '
        'LMTDeleteMenu
        '
        Me.LMTDeleteMenu.Index = 5
        Me.LMTDeleteMenu.Text = "حذف مشتری"
        '
        'LMTPrintMenu
        '
        Me.LMTPrintMenu.Index = 6
        Me.LMTPrintMenu.Text = "چاپ"
        '
        'LBTMenu
        '
        Me.LBTMenu.Index = 2
        Me.LBTMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.LBTOMenu, Me.Line8Menu, Me.LBTViewMenu, Me.LBTMoveMenu})
        Me.LBTMenu.Text = "لیست بایگانی"
        '
        'LBTOMenu
        '
        Me.LBTOMenu.Index = 0
        Me.LBTOMenu.Text = "لیست بایگانی"
        '
        'Line8Menu
        '
        Me.Line8Menu.Index = 1
        Me.Line8Menu.Text = "-"
        '
        'LBTViewMenu
        '
        Me.LBTViewMenu.Index = 2
        Me.LBTViewMenu.Text = "نمایش اطلاعات مشتری"
        '
        'LBTMoveMenu
        '
        Me.LBTMoveMenu.Index = 3
        Me.LBTMoveMenu.Text = "فرستادن به لیست مشتریان"
        '
        'BPGTMenu
        '
        Me.BPGTMenu.Index = 3
        Me.BPGTMenu.Text = "بخش پشتیبان گیری"
        '
        'BGDTMenu
        '
        Me.BGDTMenu.Index = 4
        Me.BGDTMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.DateBGDTMenu, Me.DayBGDTMenu})
        Me.BGDTMenu.Text = "بخش گزارش دهی"
        '
        'DateBGDTMenu
        '
        Me.DateBGDTMenu.Index = 0
        Me.DateBGDTMenu.Text = "بر اساس تاریخ"
        '
        'DayBGDTMenu
        '
        Me.DayBGDTMenu.Index = 1
        Me.DayBGDTMenu.Text = "بر اساس روز"
        '
        'DITMenu
        '
        Me.DITMenu.Index = 5
        Me.DITMenu.Text = "دفتر یاداشت"
        '
        'HMenu
        '
        Me.HMenu.Index = 6
        Me.HMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.VHTMenu, Me.BHTMenu})
        Me.HMenu.Text = "حسابداری"
        '
        'VHTMenu
        '
        Me.VHTMenu.Index = 0
        Me.VHTMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.VHTOMenu, Me.Line9Menu, Me.VHAddMenu, Me.VHEditMenu, Me.VHDeleteMenu, Me.VHPrintMenu})
        Me.VHTMenu.Text = "وصول"
        '
        'VHTOMenu
        '
        Me.VHTOMenu.Index = 0
        Me.VHTOMenu.Text = "وصول"
        '
        'Line9Menu
        '
        Me.Line9Menu.Index = 1
        Me.Line9Menu.Text = "-"
        '
        'VHAddMenu
        '
        Me.VHAddMenu.Index = 2
        Me.VHAddMenu.Text = "وصول"
        '
        'VHEditMenu
        '
        Me.VHEditMenu.Index = 3
        Me.VHEditMenu.Text = "ویرایش"
        '
        'VHDeleteMenu
        '
        Me.VHDeleteMenu.Index = 4
        Me.VHDeleteMenu.Text = "حذف"
        '
        'VHPrintMenu
        '
        Me.VHPrintMenu.Index = 5
        Me.VHPrintMenu.Text = "چاپ"
        '
        'BHTMenu
        '
        Me.BHTMenu.Index = 1
        Me.BHTMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.BHTOMenu, Me.Line10Menu, Me.BHAddMenu, Me.BHEditMenu, Me.BHDeleteMenu, Me.BHPrintMenu})
        Me.BHTMenu.Text = "برداشت"
        '
        'BHTOMenu
        '
        Me.BHTOMenu.Index = 0
        Me.BHTOMenu.Text = "برداشت"
        '
        'Line10Menu
        '
        Me.Line10Menu.Index = 1
        Me.Line10Menu.Text = "-"
        '
        'BHAddMenu
        '
        Me.BHAddMenu.Index = 2
        Me.BHAddMenu.Text = "برداشت"
        '
        'BHEditMenu
        '
        Me.BHEditMenu.Index = 3
        Me.BHEditMenu.Text = "ویرایش"
        '
        'BHDeleteMenu
        '
        Me.BHDeleteMenu.Index = 4
        Me.BHDeleteMenu.Text = "حذف"
        '
        'BHPrintMenu
        '
        Me.BHPrintMenu.Index = 5
        Me.BHPrintMenu.Text = "چاپ"
        '
        'SGTMenu
        '
        Me.SGTMenu.Index = 7
        Me.SGTMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.SGTOMenu, Me.Line12Menu, Me.SGTViewMenu, Me.SGTAddMenu, Me.SGTEditMenu, Me.SGTDeleteMenu})
        Me.SGTMenu.Text = "بخش سرمایه گذاری"
        '
        'SGTOMenu
        '
        Me.SGTOMenu.Index = 0
        Me.SGTOMenu.Text = "بخش سرمایه گذاری"
        '
        'Line12Menu
        '
        Me.Line12Menu.Index = 1
        Me.Line12Menu.Text = "-"
        '
        'SGTViewMenu
        '
        Me.SGTViewMenu.Index = 2
        Me.SGTViewMenu.Text = "نمایش خط موبایلهای سرمایه گذار"
        '
        'SGTAddMenu
        '
        Me.SGTAddMenu.Index = 3
        Me.SGTAddMenu.Text = "اضافه کردن سرمایه گذار جدید"
        '
        'SGTEditMenu
        '
        Me.SGTEditMenu.Index = 4
        Me.SGTEditMenu.Text = "ویرایش اطلاعات سرمایه گذار"
        '
        'SGTDeleteMenu
        '
        Me.SGTDeleteMenu.Index = 5
        Me.SGTDeleteMenu.Text = "حذف سرمایه گذار"
        '
        'Line1Menu
        '
        Me.Line1Menu.Index = 8
        Me.Line1Menu.Text = "-"
        '
        'UnlockMenu
        '
        Me.UnlockMenu.Index = 9
        Me.UnlockMenu.Shortcut = System.Windows.Forms.Shortcut.CtrlU
        Me.UnlockMenu.Text = "قفل برنامه                          Ctrl+U"
        '
        'Line2Menu
        '
        Me.Line2Menu.Index = 10
        Me.Line2Menu.Text = "-"
        '
        'LogoutMenu
        '
        Me.LogoutMenu.Index = 11
        Me.LogoutMenu.Shortcut = System.Windows.Forms.Shortcut.CtrlL
        Me.LogoutMenu.Text = "ورود با کاربر دیگر                  Ctrl+L"
        '
        'Line3Menu
        '
        Me.Line3Menu.Index = 12
        Me.Line3Menu.Text = "-"
        '
        'MoveSysTryMenu
        '
        Me.MoveSysTryMenu.Index = 13
        Me.MoveSysTryMenu.Shortcut = System.Windows.Forms.Shortcut.CtrlI
        Me.MoveSysTryMenu.Text = "انتقال به سیستم ترای       Ctrl+I"
        '
        'Line34Menu
        '
        Me.Line34Menu.Index = 14
        Me.Line34Menu.Text = "-"
        '
        'CalcMenu
        '
        Me.CalcMenu.Index = 15
        Me.CalcMenu.Shortcut = System.Windows.Forms.Shortcut.CtrlC
        Me.CalcMenu.Text = "ماشین حساب                    Ctrl+C"
        '
        'Line4Menu
        '
        Me.Line4Menu.Index = 16
        Me.Line4Menu.Text = "-"
        '
        'ExitMenu
        '
        Me.ExitMenu.Index = 17
        Me.ExitMenu.Shortcut = System.Windows.Forms.Shortcut.CtrlQ
        Me.ExitMenu.Text = "خروج                                  Ctrl+Q"
        '
        'FindMenu
        '
        Me.FindMenu.Index = 1
        Me.FindMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.FindN1Menu, Me.FindN2Menu, Me.FindN3Menu, Me.FindN4Menu})
        Me.FindMenu.Text = "جستجو"
        '
        'FindN1Menu
        '
        Me.FindN1Menu.Index = 0
        Me.FindN1Menu.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.FindN1Menu.Text = "بر اساس شماره شناسایی پرونده          F2"
        '
        'FindN2Menu
        '
        Me.FindN2Menu.Index = 1
        Me.FindN2Menu.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.FindN2Menu.Text = "بر اساس نام و نام خانوادگی موجر          F3"
        '
        'FindN3Menu
        '
        Me.FindN3Menu.Index = 2
        Me.FindN3Menu.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.FindN3Menu.Text = "بر اساس نام و نام خانوادگی مستاجر     F4"
        '
        'FindN4Menu
        '
        Me.FindN4Menu.Index = 3
        Me.FindN4Menu.Shortcut = System.Windows.Forms.Shortcut.F5
        Me.FindN4Menu.Text = "بر اساس شماره تلفن تماس                  F5"
        '
        'ListsMenu
        '
        Me.ListsMenu.Index = 2
        Me.ListsMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.DayListMenu, Me.DirListMenu, Me.HelpListMenu, Me.MoshtariListMenu})
        Me.ListsMenu.Text = "لیستها"
        '
        'DayListMenu
        '
        Me.DayListMenu.Index = 0
        Me.DayListMenu.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.DayListMenu.Text = "لیست روزانه اقساط                   F6"
        '
        'DirListMenu
        '
        Me.DirListMenu.Index = 1
        Me.DirListMenu.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.DirListMenu.Text = "لیست اقساط بدهکاران              F7"
        '
        'HelpListMenu
        '
        Me.HelpListMenu.Index = 2
        Me.HelpListMenu.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.HelpListMenu.Text = "لیست راهنما                             F8"
        '
        'MoshtariListMenu
        '
        Me.MoshtariListMenu.Index = 3
        Me.MoshtariListMenu.Shortcut = System.Windows.Forms.Shortcut.F9
        Me.MoshtariListMenu.Text = "لیست اصلی مشتریان               F9"
        '
        'ReportsMenu
        '
        Me.ReportsMenu.Index = 3
        Me.ReportsMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.HVRMenu, Me.HBRMenu})
        Me.ReportsMenu.Text = "گزارشها"
        '
        'HVRMenu
        '
        Me.HVRMenu.Index = 0
        Me.HVRMenu.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftV
        Me.HVRMenu.Text = "حسابداری - وصول           Ctrl+Shift+V"
        '
        'HBRMenu
        '
        Me.HBRMenu.Index = 1
        Me.HBRMenu.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftB
        Me.HBRMenu.Text = "حسابداری - برداشت       Ctrl+Shift+B"
        '
        'OptionsMenu
        '
        Me.OptionsMenu.Index = 4
        Me.OptionsMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.AutoSaveChangeMenu})
        Me.OptionsMenu.Text = "تنظیمات"
        '
        'AutoSaveChangeMenu
        '
        Me.AutoSaveChangeMenu.Index = 0
        Me.AutoSaveChangeMenu.Text = "ذخیره تغییرات در هنگام خروج"
        '
        'HelpMenu
        '
        Me.HelpMenu.Index = 5
        Me.HelpMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.HelpOMenu, Me.Line5Menu, Me.AboutMenu})
        Me.HelpMenu.Text = "راهنما"
        '
        'HelpOMenu
        '
        Me.HelpOMenu.Index = 0
        Me.HelpOMenu.Shortcut = System.Windows.Forms.Shortcut.F1
        Me.HelpOMenu.Text = "راهنما              F1"
        '
        'Line5Menu
        '
        Me.Line5Menu.Index = 1
        Me.Line5Menu.Text = "-"
        '
        'AboutMenu
        '
        Me.AboutMenu.Index = 2
        Me.AboutMenu.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftA
        Me.AboutMenu.Text = "درباره برنامه      Ctrl+Shift+A"
        '
        'IFT1
        '
        Me.IFT1.Image = CType(resources.GetObject("IFT1.Image"), System.Drawing.Image)
        Me.IFT1.Location = New System.Drawing.Point(608, 456)
        Me.IFT1.Name = "IFT1"
        Me.IFT1.Size = New System.Drawing.Size(150, 25)
        Me.IFT1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IFT1.TabIndex = 4
        Me.IFT1.TabStop = False
        Me.IFT1.Visible = False
        '
        'IFT2
        '
        Me.IFT2.Image = CType(resources.GetObject("IFT2.Image"), System.Drawing.Image)
        Me.IFT2.Location = New System.Drawing.Point(600, 456)
        Me.IFT2.Name = "IFT2"
        Me.IFT2.Size = New System.Drawing.Size(150, 25)
        Me.IFT2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IFT2.TabIndex = 5
        Me.IFT2.TabStop = False
        Me.IFT2.Visible = False
        '
        'IFT3
        '
        Me.IFT3.Image = CType(resources.GetObject("IFT3.Image"), System.Drawing.Image)
        Me.IFT3.Location = New System.Drawing.Point(592, 456)
        Me.IFT3.Name = "IFT3"
        Me.IFT3.Size = New System.Drawing.Size(150, 25)
        Me.IFT3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IFT3.TabIndex = 6
        Me.IFT3.TabStop = False
        Me.IFT3.Visible = False
        '
        'BMT
        '
        Me.BMT.ForeColor = System.Drawing.Color.Maroon
        Me.BMT.Image = CType(resources.GetObject("BMT.Image"), System.Drawing.Image)
        Me.Tab.SetIndex(Me.BMT, CType(0, Short))
        Me.BMT.Location = New System.Drawing.Point(607, 96)
        Me.BMT.Name = "BMT"
        Me.BMT.Size = New System.Drawing.Size(150, 25)
        Me.BMT.TabIndex = 7
        Me.BMT.Text = "بخش مدیریت"
        Me.BMT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LMT
        '
        Me.LMT.ForeColor = System.Drawing.Color.Maroon
        Me.LMT.Image = CType(resources.GetObject("LMT.Image"), System.Drawing.Image)
        Me.Tab.SetIndex(Me.LMT, CType(1, Short))
        Me.LMT.Location = New System.Drawing.Point(607, 128)
        Me.LMT.Name = "LMT"
        Me.LMT.Size = New System.Drawing.Size(150, 25)
        Me.LMT.TabIndex = 8
        Me.LMT.Text = "لیست مشتریان"
        Me.LMT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(600, 376)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Tab
        '
        '
        'LBT
        '
        Me.LBT.ForeColor = System.Drawing.Color.Maroon
        Me.LBT.Image = CType(resources.GetObject("LBT.Image"), System.Drawing.Image)
        Me.Tab.SetIndex(Me.LBT, CType(2, Short))
        Me.LBT.Location = New System.Drawing.Point(607, 160)
        Me.LBT.Name = "LBT"
        Me.LBT.Size = New System.Drawing.Size(150, 25)
        Me.LBT.TabIndex = 18
        Me.LBT.Text = "لیست بایگانی"
        Me.LBT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BPGT
        '
        Me.BPGT.ForeColor = System.Drawing.Color.Maroon
        Me.BPGT.Image = CType(resources.GetObject("BPGT.Image"), System.Drawing.Image)
        Me.Tab.SetIndex(Me.BPGT, CType(3, Short))
        Me.BPGT.Location = New System.Drawing.Point(607, 192)
        Me.BPGT.Name = "BPGT"
        Me.BPGT.Size = New System.Drawing.Size(150, 25)
        Me.BPGT.TabIndex = 19
        Me.BPGT.Text = "بخش پشتیبان گیری"
        Me.BPGT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BGDT
        '
        Me.BGDT.ForeColor = System.Drawing.Color.Maroon
        Me.BGDT.Image = CType(resources.GetObject("BGDT.Image"), System.Drawing.Image)
        Me.Tab.SetIndex(Me.BGDT, CType(4, Short))
        Me.BGDT.Location = New System.Drawing.Point(607, 224)
        Me.BGDT.Name = "BGDT"
        Me.BGDT.Size = New System.Drawing.Size(150, 25)
        Me.BGDT.TabIndex = 20
        Me.BGDT.Text = "بخش گزارش دهی"
        Me.BGDT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VHT
        '
        Me.VHT.ForeColor = System.Drawing.Color.Maroon
        Me.VHT.Image = CType(resources.GetObject("VHT.Image"), System.Drawing.Image)
        Me.Tab.SetIndex(Me.VHT, CType(6, Short))
        Me.VHT.Location = New System.Drawing.Point(607, 288)
        Me.VHT.Name = "VHT"
        Me.VHT.Size = New System.Drawing.Size(150, 25)
        Me.VHT.TabIndex = 21
        Me.VHT.Text = "حسابداری - وصول"
        Me.VHT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DIT
        '
        Me.DIT.ForeColor = System.Drawing.Color.Maroon
        Me.DIT.Image = CType(resources.GetObject("DIT.Image"), System.Drawing.Image)
        Me.Tab.SetIndex(Me.DIT, CType(5, Short))
        Me.DIT.Location = New System.Drawing.Point(607, 256)
        Me.DIT.Name = "DIT"
        Me.DIT.Size = New System.Drawing.Size(150, 25)
        Me.DIT.TabIndex = 35
        Me.DIT.Text = "دفتر یاداشت"
        Me.DIT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BHT
        '
        Me.BHT.ForeColor = System.Drawing.Color.Maroon
        Me.BHT.Image = CType(resources.GetObject("BHT.Image"), System.Drawing.Image)
        Me.Tab.SetIndex(Me.BHT, CType(7, Short))
        Me.BHT.Location = New System.Drawing.Point(607, 320)
        Me.BHT.Name = "BHT"
        Me.BHT.Size = New System.Drawing.Size(150, 25)
        Me.BHT.TabIndex = 41
        Me.BHT.Text = "حسابداری - برداشت"
        Me.BHT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BSGT
        '
        Me.BSGT.ForeColor = System.Drawing.Color.Maroon
        Me.BSGT.Image = CType(resources.GetObject("BSGT.Image"), System.Drawing.Image)
        Me.Tab.SetIndex(Me.BSGT, CType(8, Short))
        Me.BSGT.Location = New System.Drawing.Point(607, 352)
        Me.BSGT.Name = "BSGT"
        Me.BSGT.Size = New System.Drawing.Size(150, 25)
        Me.BSGT.TabIndex = 44
        Me.BSGT.Text = "بخش سرمایه گذاری"
        Me.BSGT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DBT
        '
        Me.DBT.ForeColor = System.Drawing.Color.Maroon
        Me.DBT.Image = CType(resources.GetObject("DBT.Image"), System.Drawing.Image)
        Me.Tab.SetIndex(Me.DBT, CType(9, Short))
        Me.DBT.Location = New System.Drawing.Point(607, 384)
        Me.DBT.Name = "DBT"
        Me.DBT.Size = New System.Drawing.Size(150, 25)
        Me.DBT.TabIndex = 45
        Me.DBT.Text = "درباره برنامه"
        Me.DBT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabTitrL
        '
        Me.TabTitrL.Font = New System.Drawing.Font("2  Homa", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TabTitrL.ForeColor = System.Drawing.Color.Black
        Me.TabTitrL.Location = New System.Drawing.Point(32, 104)
        Me.TabTitrL.Name = "TabTitrL"
        Me.TabTitrL.Size = New System.Drawing.Size(552, 32)
        Me.TabTitrL.TabIndex = 12
        Me.TabTitrL.Text = "به برنامه حسابداری موبایل زاگرس خوش آمدید"
        Me.TabTitrL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LMPanel
        '
        Me.LMPanel.Controls.Add(Me.MSBPrintB)
        Me.LMPanel.Controls.Add(Me.MList)
        Me.LMPanel.Controls.Add(Me.DeleteB)
        Me.LMPanel.Controls.Add(Me.EditB)
        Me.LMPanel.Controls.Add(Me.AddB)
        Me.Panel.SetIndex(Me.LMPanel, CType(1, Short))
        Me.LMPanel.Location = New System.Drawing.Point(32, 448)
        Me.LMPanel.Name = "LMPanel"
        Me.LMPanel.Size = New System.Drawing.Size(584, 304)
        Me.LMPanel.TabIndex = 13
        Me.LMPanel.Visible = False
        '
        'MSBPrintB
        '
        Me.MSBPrintB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.MSBPrintB.Image = CType(resources.GetObject("MSBPrintB.Image"), System.Drawing.Image)
        Me.MSBPrintB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MSBPrintB.Location = New System.Drawing.Point(208, 272)
        Me.MSBPrintB.Name = "MSBPrintB"
        Me.MSBPrintB.Size = New System.Drawing.Size(80, 24)
        Me.MSBPrintB.TabIndex = 4
        Me.MSBPrintB.Text = "چاپ"
        '
        'MList
        '
        Me.MList.BackColor = System.Drawing.Color.DarkGray
        Me.MList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.MListIDHeader, Me.MListMPicExHeader, Me.MListPicExHeader, Me.MListCGoldHeader, Me.MListTellHeader, Me.MListMostajerHeader, Me.MListMoajerHeader, Me.MListShParvandeNumHeader})
        Me.MList.ForeColor = System.Drawing.Color.White
        Me.MList.FullRowSelect = True
        Me.MList.GridLines = True
        Me.MList.Location = New System.Drawing.Point(8, 8)
        Me.MList.MultiSelect = False
        Me.MList.Name = "MList"
        Me.MList.Size = New System.Drawing.Size(568, 256)
        Me.MList.TabIndex = 0
        Me.MList.View = System.Windows.Forms.View.Details
        '
        'MListIDHeader
        '
        Me.MListIDHeader.Text = "آیدی"
        Me.MListIDHeader.Width = 0
        '
        'MListMPicExHeader
        '
        Me.MListMPicExHeader.Text = "مشتری"
        Me.MListMPicExHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MListPicExHeader
        '
        Me.MListPicExHeader.Text = "طلا"
        Me.MListPicExHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MListCGoldHeader
        '
        Me.MListCGoldHeader.Text = "مقدار طلا"
        Me.MListCGoldHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MListCGoldHeader.Width = 68
        '
        'MListTellHeader
        '
        Me.MListTellHeader.Text = "تلفن تماس"
        Me.MListTellHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MListTellHeader.Width = 77
        '
        'MListMostajerHeader
        '
        Me.MListMostajerHeader.Text = "مستاجر"
        Me.MListMostajerHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MListMostajerHeader.Width = 117
        '
        'MListMoajerHeader
        '
        Me.MListMoajerHeader.Text = "موجر"
        Me.MListMoajerHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MListMoajerHeader.Width = 117
        '
        'MListShParvandeNumHeader
        '
        Me.MListShParvandeNumHeader.Text = "پرونده"
        Me.MListShParvandeNumHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MListShParvandeNumHeader.Width = 69
        '
        'DeleteB
        '
        Me.DeleteB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.DeleteB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DeleteB.Location = New System.Drawing.Point(296, 272)
        Me.DeleteB.Name = "DeleteB"
        Me.DeleteB.Size = New System.Drawing.Size(88, 23)
        Me.DeleteB.TabIndex = 3
        Me.DeleteB.Text = "حذف"
        '
        'EditB
        '
        Me.EditB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.EditB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.EditB.Location = New System.Drawing.Point(392, 272)
        Me.EditB.Name = "EditB"
        Me.EditB.Size = New System.Drawing.Size(88, 23)
        Me.EditB.TabIndex = 2
        Me.EditB.Text = "ویرایش"
        '
        'AddB
        '
        Me.AddB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.AddB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AddB.Location = New System.Drawing.Point(488, 272)
        Me.AddB.Name = "AddB"
        Me.AddB.Size = New System.Drawing.Size(88, 23)
        Me.AddB.TabIndex = 1
        Me.AddB.Text = "اضافه کردن"
        '
        'LBPanel
        '
        Me.LBPanel.Controls.Add(Me.CancelPB)
        Me.LBPanel.Controls.Add(Me.AList)
        Me.LBPanel.Controls.Add(Me.MoveB)
        Me.Panel.SetIndex(Me.LBPanel, CType(2, Short))
        Me.LBPanel.Location = New System.Drawing.Point(56, 448)
        Me.LBPanel.Name = "LBPanel"
        Me.LBPanel.Size = New System.Drawing.Size(584, 304)
        Me.LBPanel.TabIndex = 14
        Me.LBPanel.Visible = False
        '
        'CancelPB
        '
        Me.CancelPB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.CancelPB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CancelPB.Location = New System.Drawing.Point(304, 272)
        Me.CancelPB.Name = "CancelPB"
        Me.CancelPB.Size = New System.Drawing.Size(176, 23)
        Me.CancelPB.TabIndex = 2
        Me.CancelPB.Text = "مسدود کردن پرونده"
        '
        'AList
        '
        Me.AList.BackColor = System.Drawing.Color.DarkGray
        Me.AList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.AlistIDHeader, Me.AlistTellHeader, Me.AlistMostajerHeader, Me.AlistMoajerHeader, Me.AlistShParvandeNumHeader})
        Me.AList.ForeColor = System.Drawing.Color.White
        Me.AList.FullRowSelect = True
        Me.AList.GridLines = True
        Me.AList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.AList.Location = New System.Drawing.Point(8, 8)
        Me.AList.MultiSelect = False
        Me.AList.Name = "AList"
        Me.AList.Size = New System.Drawing.Size(568, 256)
        Me.AList.TabIndex = 0
        Me.AList.View = System.Windows.Forms.View.Details
        '
        'AlistIDHeader
        '
        Me.AlistIDHeader.Text = "آیدی"
        Me.AlistIDHeader.Width = 0
        '
        'AlistTellHeader
        '
        Me.AlistTellHeader.Text = "تلفن تماس"
        Me.AlistTellHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.AlistTellHeader.Width = 115
        '
        'AlistMostajerHeader
        '
        Me.AlistMostajerHeader.Text = "مستاجر"
        Me.AlistMostajerHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.AlistMostajerHeader.Width = 160
        '
        'AlistMoajerHeader
        '
        Me.AlistMoajerHeader.Text = "موجر"
        Me.AlistMoajerHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.AlistMoajerHeader.Width = 150
        '
        'AlistShParvandeNumHeader
        '
        Me.AlistShParvandeNumHeader.Text = "شماره پرونده"
        Me.AlistShParvandeNumHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.AlistShParvandeNumHeader.Width = 143
        '
        'MoveB
        '
        Me.MoveB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.MoveB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MoveB.Location = New System.Drawing.Point(104, 272)
        Me.MoveB.Name = "MoveB"
        Me.MoveB.Size = New System.Drawing.Size(176, 23)
        Me.MoveB.TabIndex = 1
        Me.MoveB.Text = "فرستادن به لیست مشتریان"
        '
        'BMPanel
        '
        Me.BMPanel.Controls.Add(Me.BMDeleteB)
        Me.BMPanel.Controls.Add(Me.FullMList)
        Me.BMPanel.Controls.Add(Me.ActiveUnB)
        Me.BMPanel.Controls.Add(Me.OnAdminID)
        Me.BMPanel.Controls.Add(Me.IsGod)
        Me.BMPanel.Controls.Add(Me.AdList)
        Me.BMPanel.Controls.Add(Me.BMEditB)
        Me.BMPanel.Controls.Add(Me.BMAddB)
        Me.Panel.SetIndex(Me.BMPanel, CType(0, Short))
        Me.BMPanel.Location = New System.Drawing.Point(8, 448)
        Me.BMPanel.Name = "BMPanel"
        Me.BMPanel.Size = New System.Drawing.Size(584, 304)
        Me.BMPanel.TabIndex = 22
        Me.BMPanel.Visible = False
        '
        'BMDeleteB
        '
        Me.BMDeleteB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.BMDeleteB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BMDeleteB.Location = New System.Drawing.Point(8, 272)
        Me.BMDeleteB.Name = "BMDeleteB"
        Me.BMDeleteB.Size = New System.Drawing.Size(120, 23)
        Me.BMDeleteB.TabIndex = 4
        Me.BMDeleteB.Text = "حذف مدیر"
        '
        'FullMList
        '
        Me.FullMList.Location = New System.Drawing.Point(40, 280)
        Me.FullMList.Name = "FullMList"
        Me.FullMList.Size = New System.Drawing.Size(16, 16)
        Me.FullMList.TabIndex = 15
        Me.FullMList.TabStop = False
        Me.FullMList.Visible = False
        '
        'ActiveUnB
        '
        Me.ActiveUnB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.ActiveUnB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ActiveUnB.Location = New System.Drawing.Point(144, 272)
        Me.ActiveUnB.Name = "ActiveUnB"
        Me.ActiveUnB.Size = New System.Drawing.Size(120, 23)
        Me.ActiveUnB.TabIndex = 3
        Me.ActiveUnB.Text = "غیر فعال"
        '
        'OnAdminID
        '
        Me.OnAdminID.Location = New System.Drawing.Point(16, 280)
        Me.OnAdminID.Name = "OnAdminID"
        Me.OnAdminID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OnAdminID.Size = New System.Drawing.Size(24, 23)
        Me.OnAdminID.TabIndex = 13
        Me.OnAdminID.TabStop = False
        Me.OnAdminID.Text = ""
        Me.OnAdminID.Visible = False
        '
        'IsGod
        '
        Me.IsGod.Location = New System.Drawing.Point(0, 280)
        Me.IsGod.Name = "IsGod"
        Me.IsGod.Size = New System.Drawing.Size(16, 16)
        Me.IsGod.TabIndex = 12
        Me.IsGod.TabStop = False
        Me.IsGod.Visible = False
        '
        'AdList
        '
        Me.AdList.BackColor = System.Drawing.Color.DarkGray
        Me.AdList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AdList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IDAdHeader, Me.GodAdHeader, Me.EnDisAdHeader, Me.AccessAdHeader, Me.FNameAdHeader, Me.UserAdHeader})
        Me.AdList.ForeColor = System.Drawing.Color.White
        Me.AdList.FullRowSelect = True
        Me.AdList.GridLines = True
        Me.AdList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.AdList.Location = New System.Drawing.Point(8, 8)
        Me.AdList.MultiSelect = False
        Me.AdList.Name = "AdList"
        Me.AdList.Size = New System.Drawing.Size(568, 256)
        Me.AdList.TabIndex = 0
        Me.AdList.View = System.Windows.Forms.View.Details
        '
        'IDAdHeader
        '
        Me.IDAdHeader.Text = "آیدی"
        Me.IDAdHeader.Width = 0
        '
        'GodAdHeader
        '
        Me.GodAdHeader.Text = "مدیر کل"
        Me.GodAdHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.GodAdHeader.Width = 0
        '
        'EnDisAdHeader
        '
        Me.EnDisAdHeader.Text = "فعال"
        Me.EnDisAdHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.EnDisAdHeader.Width = 0
        '
        'AccessAdHeader
        '
        Me.AccessAdHeader.Text = "سطح دسترسی"
        Me.AccessAdHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.AccessAdHeader.Width = 140
        '
        'FNameAdHeader
        '
        Me.FNameAdHeader.Text = "نام و نام خانوادگی"
        Me.FNameAdHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.FNameAdHeader.Width = 223
        '
        'UserAdHeader
        '
        Me.UserAdHeader.Text = "نام کاربری"
        Me.UserAdHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.UserAdHeader.Width = 205
        '
        'BMEditB
        '
        Me.BMEditB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.BMEditB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BMEditB.Location = New System.Drawing.Point(280, 272)
        Me.BMEditB.Name = "BMEditB"
        Me.BMEditB.Size = New System.Drawing.Size(144, 23)
        Me.BMEditB.TabIndex = 2
        Me.BMEditB.Text = "ویرایش اطلاعات مدیر"
        '
        'BMAddB
        '
        Me.BMAddB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.BMAddB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BMAddB.Location = New System.Drawing.Point(440, 272)
        Me.BMAddB.Name = "BMAddB"
        Me.BMAddB.Size = New System.Drawing.Size(136, 23)
        Me.BMAddB.TabIndex = 1
        Me.BMAddB.Text = "اضافه کردن مدیر جدید"
        '
        'BPGPanel
        '
        Me.BPGPanel.Controls.Add(Me.BurnB)
        Me.BPGPanel.Controls.Add(Me.FileFRestore)
        Me.BPGPanel.Controls.Add(Me.SaveB)
        Me.BPGPanel.Controls.Add(Me.RestoreB)
        Me.BPGPanel.Controls.Add(Me.BackupB)
        Me.BPGPanel.Controls.Add(Me.GroupBox2)
        Me.BPGPanel.Controls.Add(Me.GroupBox1)
        Me.BPGPanel.Controls.Add(Me.BackupFAO)
        Me.Panel.SetIndex(Me.BPGPanel, CType(3, Short))
        Me.BPGPanel.Location = New System.Drawing.Point(80, 448)
        Me.BPGPanel.Name = "BPGPanel"
        Me.BPGPanel.Size = New System.Drawing.Size(584, 304)
        Me.BPGPanel.TabIndex = 23
        Me.BPGPanel.Visible = False
        '
        'BurnB
        '
        Me.BurnB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.BurnB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BurnB.Location = New System.Drawing.Point(72, 272)
        Me.BurnB.Name = "BurnB"
        Me.BurnB.Size = New System.Drawing.Size(136, 23)
        Me.BurnB.TabIndex = 5
        Me.BurnB.Text = "رایت پشتیبان"
        '
        'FileFRestore
        '
        Me.FileFRestore.Location = New System.Drawing.Point(568, 288)
        Me.FileFRestore.Name = "FileFRestore"
        Me.FileFRestore.Pattern = "*.bum"
        Me.FileFRestore.Size = New System.Drawing.Size(16, 20)
        Me.FileFRestore.TabIndex = 39
        Me.FileFRestore.Visible = False
        '
        'SaveB
        '
        Me.SaveB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.SaveB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SaveB.Location = New System.Drawing.Point(240, 208)
        Me.SaveB.Name = "SaveB"
        Me.SaveB.Size = New System.Drawing.Size(96, 23)
        Me.SaveB.TabIndex = 2
        Me.SaveB.Text = "ذخیره تغییرات"
        '
        'RestoreB
        '
        Me.RestoreB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.RestoreB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RestoreB.Location = New System.Drawing.Point(376, 272)
        Me.RestoreB.Name = "RestoreB"
        Me.RestoreB.Size = New System.Drawing.Size(136, 23)
        Me.RestoreB.TabIndex = 4
        Me.RestoreB.Text = "بازیابی فایل پشتیبان"
        '
        'BackupB
        '
        Me.BackupB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.BackupB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BackupB.Location = New System.Drawing.Point(224, 272)
        Me.BackupB.Name = "BackupB"
        Me.BackupB.Size = New System.Drawing.Size(136, 23)
        Me.BackupB.TabIndex = 3
        Me.BackupB.Text = "پشتیبان گیری سریع"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AutoBackup)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(16, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(552, 72)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " تنظیمات پشتیبان گیری خودکار "
        '
        'AutoBackup
        '
        Me.AutoBackup.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AutoBackup.Location = New System.Drawing.Point(216, 32)
        Me.AutoBackup.Name = "AutoBackup"
        Me.AutoBackup.Size = New System.Drawing.Size(320, 24)
        Me.AutoBackup.TabIndex = 1
        Me.AutoBackup.Text = "پشتیبان گیری از بانک اطلاعاتی هنگام خروج از برنامه"
        Me.AutoBackup.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BackupFA)
        Me.GroupBox1.Controls.Add(Me.BrowseB)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " تنظیمات پشتیبان گیری "
        '
        'BackupFA
        '
        Me.BackupFA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BackupFA.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BackupFA.Location = New System.Drawing.Point(16, 64)
        Me.BackupFA.Name = "BackupFA"
        Me.BackupFA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BackupFA.Size = New System.Drawing.Size(328, 23)
        Me.BackupFA.TabIndex = 2
        Me.BackupFA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BrowseB
        '
        Me.BrowseB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.BrowseB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BrowseB.ForeColor = System.Drawing.Color.Black
        Me.BrowseB.Location = New System.Drawing.Point(352, 64)
        Me.BrowseB.Name = "BrowseB"
        Me.BrowseB.Size = New System.Drawing.Size(56, 24)
        Me.BrowseB.TabIndex = 0
        Me.BrowseB.Text = "جستجو"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(384, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "محل ذخیره فایل پشتیبان :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BackupFAO
        '
        Me.BackupFAO.Location = New System.Drawing.Point(0, 288)
        Me.BackupFAO.Name = "BackupFAO"
        Me.BackupFAO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BackupFAO.Size = New System.Drawing.Size(16, 23)
        Me.BackupFAO.TabIndex = 37
        Me.BackupFAO.Text = ""
        Me.BackupFAO.Visible = False
        '
        'BGDPanel
        '
        Me.BGDPanel.Controls.Add(Me.ViewB)
        Me.BGDPanel.Controls.Add(Me.ChangeTTB)
        Me.BGDPanel.Controls.Add(Me.TTarikh)
        Me.BGDPanel.Controls.Add(Me.ChangeFTB)
        Me.BGDPanel.Controls.Add(Me.FTarikh)
        Me.BGDPanel.Controls.Add(Me.Label10)
        Me.BGDPanel.Controls.Add(Me.FTCheck)
        Me.BGDPanel.Controls.Add(Me.RPrintB)
        Me.BGDPanel.Controls.Add(Me.DayList)
        Me.BGDPanel.Controls.Add(Me.DayCheck)
        Me.BGDPanel.Controls.Add(Me.DateList)
        Me.BGDPanel.Controls.Add(Me.DateCheck)
        Me.BGDPanel.Controls.Add(Me.ReList)
        Me.Panel.SetIndex(Me.BGDPanel, CType(4, Short))
        Me.BGDPanel.Location = New System.Drawing.Point(104, 448)
        Me.BGDPanel.Name = "BGDPanel"
        Me.BGDPanel.Size = New System.Drawing.Size(584, 304)
        Me.BGDPanel.TabIndex = 24
        Me.BGDPanel.Visible = False
        '
        'ViewB
        '
        Me.ViewB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.ViewB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ViewB.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ViewB.Location = New System.Drawing.Point(40, 72)
        Me.ViewB.Name = "ViewB"
        Me.ViewB.Size = New System.Drawing.Size(56, 23)
        Me.ViewB.TabIndex = 3
        Me.ViewB.Text = "نمایش"
        '
        'ChangeTTB
        '
        Me.ChangeTTB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.ChangeTTB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ChangeTTB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChangeTTB.Location = New System.Drawing.Point(104, 72)
        Me.ChangeTTB.Name = "ChangeTTB"
        Me.ChangeTTB.Size = New System.Drawing.Size(40, 20)
        Me.ChangeTTB.TabIndex = 2
        Me.ChangeTTB.Text = "تغییر"
        '
        'TTarikh
        '
        Me.TTarikh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TTarikh.Location = New System.Drawing.Point(152, 72)
        Me.TTarikh.Name = "TTarikh"
        Me.TTarikh.Size = New System.Drawing.Size(80, 23)
        Me.TTarikh.TabIndex = 32
        Me.TTarikh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChangeFTB
        '
        Me.ChangeFTB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.ChangeFTB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ChangeFTB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChangeFTB.Location = New System.Drawing.Point(296, 72)
        Me.ChangeFTB.Name = "ChangeFTB"
        Me.ChangeFTB.Size = New System.Drawing.Size(40, 20)
        Me.ChangeFTB.TabIndex = 1
        Me.ChangeFTB.Text = "تغییر"
        '
        'FTarikh
        '
        Me.FTarikh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FTarikh.Location = New System.Drawing.Point(344, 72)
        Me.FTarikh.Name = "FTarikh"
        Me.FTarikh.Size = New System.Drawing.Size(80, 23)
        Me.FTarikh.TabIndex = 31
        Me.FTarikh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(232, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 23)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "تا تاریخ :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FTCheck
        '
        Me.FTCheck.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.FTCheck.Location = New System.Drawing.Point(424, 72)
        Me.FTCheck.Name = "FTCheck"
        Me.FTCheck.Size = New System.Drawing.Size(152, 24)
        Me.FTCheck.TabIndex = 0
        Me.FTCheck.Text = "مشتریان مربوط به تاریخ"
        Me.FTCheck.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'RPrintB
        '
        Me.RPrintB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.RPrintB.Image = CType(resources.GetObject("RPrintB.Image"), System.Drawing.Image)
        Me.RPrintB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RPrintB.Location = New System.Drawing.Point(240, 272)
        Me.RPrintB.Name = "RPrintB"
        Me.RPrintB.Size = New System.Drawing.Size(104, 24)
        Me.RPrintB.TabIndex = 5
        Me.RPrintB.Text = "چاپ گزارش"
        Me.RPrintB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DayList
        '
        Me.DayList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DayList.Location = New System.Drawing.Point(344, 40)
        Me.DayList.Name = "DayList"
        Me.DayList.Size = New System.Drawing.Size(80, 24)
        Me.DayList.TabIndex = 1
        '
        'DayCheck
        '
        Me.DayCheck.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DayCheck.Location = New System.Drawing.Point(432, 40)
        Me.DayCheck.Name = "DayCheck"
        Me.DayCheck.Size = New System.Drawing.Size(144, 24)
        Me.DayCheck.TabIndex = 0
        Me.DayCheck.Text = "مشتریان مربوط به روز"
        '
        'DateList
        '
        Me.DateList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DateList.Location = New System.Drawing.Point(344, 8)
        Me.DateList.Name = "DateList"
        Me.DateList.Size = New System.Drawing.Size(80, 24)
        Me.DateList.Sorted = True
        Me.DateList.TabIndex = 1
        '
        'DateCheck
        '
        Me.DateCheck.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DateCheck.Location = New System.Drawing.Point(424, 8)
        Me.DateCheck.Name = "DateCheck"
        Me.DateCheck.Size = New System.Drawing.Size(152, 24)
        Me.DateCheck.TabIndex = 0
        Me.DateCheck.Text = "مشتریان مربوط به تاریخ"
        '
        'ReList
        '
        Me.ReList.BackColor = System.Drawing.Color.DarkGray
        Me.ReList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ReListIDHeader, Me.ReListTellHeader, Me.ReListMostajerHeader, Me.ReListMoajerHeader, Me.ReListShParvandehNumHeader})
        Me.ReList.ForeColor = System.Drawing.Color.White
        Me.ReList.FullRowSelect = True
        Me.ReList.GridLines = True
        Me.ReList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ReList.Location = New System.Drawing.Point(8, 104)
        Me.ReList.MultiSelect = False
        Me.ReList.Name = "ReList"
        Me.ReList.Size = New System.Drawing.Size(568, 160)
        Me.ReList.TabIndex = 4
        Me.ReList.View = System.Windows.Forms.View.Details
        '
        'ReListIDHeader
        '
        Me.ReListIDHeader.Text = "آیدی"
        Me.ReListIDHeader.Width = 0
        '
        'ReListTellHeader
        '
        Me.ReListTellHeader.Text = "تلفن تماس"
        Me.ReListTellHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ReListTellHeader.Width = 115
        '
        'ReListMostajerHeader
        '
        Me.ReListMostajerHeader.Text = "مستاجر"
        Me.ReListMostajerHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ReListMostajerHeader.Width = 160
        '
        'ReListMoajerHeader
        '
        Me.ReListMoajerHeader.Text = "موجر"
        Me.ReListMoajerHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ReListMoajerHeader.Width = 150
        '
        'ReListShParvandehNumHeader
        '
        Me.ReListShParvandehNumHeader.Text = "شماره پرونده"
        Me.ReListShParvandehNumHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ReListShParvandehNumHeader.Width = 143
        '
        'DBPanel
        '
        Me.DBPanel.Controls.Add(Me.Programmer)
        Me.DBPanel.Controls.Add(Me.Licensed)
        Me.DBPanel.Controls.Add(Me.Support)
        Me.DBPanel.Controls.Add(Me.Company)
        Me.DBPanel.Controls.Add(Me.Label5)
        Me.DBPanel.Controls.Add(Me.Label9)
        Me.DBPanel.Controls.Add(Me.Label6)
        Me.DBPanel.Controls.Add(Me.AboutLogo)
        Me.Panel.SetIndex(Me.DBPanel, CType(9, Short))
        Me.DBPanel.Location = New System.Drawing.Point(224, 448)
        Me.DBPanel.Name = "DBPanel"
        Me.DBPanel.Size = New System.Drawing.Size(584, 304)
        Me.DBPanel.TabIndex = 25
        Me.DBPanel.Visible = False
        '
        'Programmer
        '
        Me.Programmer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Programmer.Font = New System.Drawing.Font("2  Homa", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Programmer.ForeColor = System.Drawing.Color.DarkRed
        Me.Programmer.Location = New System.Drawing.Point(32, 272)
        Me.Programmer.Name = "Programmer"
        Me.Programmer.Size = New System.Drawing.Size(528, 23)
        Me.Programmer.TabIndex = 8
        Me.Programmer.Text = "برنامه نویسی شده توسط نوید سلطنت پوری تلفن 09188733476"
        Me.Programmer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Licensed
        '
        Me.Licensed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Licensed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Licensed.Font = New System.Drawing.Font("SF New Republic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Licensed.ForeColor = System.Drawing.Color.FromArgb(CType(179, Byte), CType(122, Byte), CType(0, Byte))
        Me.Licensed.Location = New System.Drawing.Point(24, 200)
        Me.Licensed.Name = "Licensed"
        Me.Licensed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Licensed.Size = New System.Drawing.Size(376, 64)
        Me.Licensed.TabIndex = 7
        Me.Licensed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Support
        '
        Me.Support.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Support.Font = New System.Drawing.Font("SF New Republic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Support.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(47, Byte), CType(64, Byte))
        Me.Support.Location = New System.Drawing.Point(24, 176)
        Me.Support.Name = "Support"
        Me.Support.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Support.Size = New System.Drawing.Size(336, 23)
        Me.Support.TabIndex = 5
        Me.Support.Text = "http://www.irashyane.com"
        Me.Support.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Company
        '
        Me.Company.BackColor = System.Drawing.Color.White
        Me.Company.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Company.Font = New System.Drawing.Font("SF New Republic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Company.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(45, Byte), CType(8, Byte))
        Me.Company.Location = New System.Drawing.Point(24, 152)
        Me.Company.Name = "Company"
        Me.Company.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Company.Size = New System.Drawing.Size(160, 23)
        Me.Company.TabIndex = 3
        Me.Company.Text = "iDrive Team"
        Me.Company.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("2  Homa", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(400, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "لیسانس این نسخه :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("2  Homa", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.Location = New System.Drawing.Point(480, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 23)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "پشتیبانی :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("2  Homa", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(440, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 23)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "کاری از گروه :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AboutLogo
        '
        Me.AboutLogo.Location = New System.Drawing.Point(72, 16)
        Me.AboutLogo.Name = "AboutLogo"
        Me.AboutLogo.Size = New System.Drawing.Size(463, 134)
        Me.AboutLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.AboutLogo.TabIndex = 0
        Me.AboutLogo.TabStop = False
        '
        'DIPanel
        '
        Me.DIPanel.Controls.Add(Me.DIList)
        Me.DIPanel.Controls.Add(Me.DIDeleteB)
        Me.DIPanel.Controls.Add(Me.WriteB)
        Me.Panel.SetIndex(Me.DIPanel, CType(5, Short))
        Me.DIPanel.Location = New System.Drawing.Point(128, 448)
        Me.DIPanel.Name = "DIPanel"
        Me.DIPanel.Size = New System.Drawing.Size(584, 304)
        Me.DIPanel.TabIndex = 34
        Me.DIPanel.Visible = False
        '
        'DIList
        '
        Me.DIList.BackColor = System.Drawing.Color.DarkGray
        Me.DIList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DIList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.DIListIDHeader, Me.DIListTarikhHeader, Me.DIListSubjectHeader, Me.DIListWriterHeader})
        Me.DIList.ForeColor = System.Drawing.Color.White
        Me.DIList.FullRowSelect = True
        Me.DIList.GridLines = True
        Me.DIList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.DIList.Location = New System.Drawing.Point(8, 9)
        Me.DIList.MultiSelect = False
        Me.DIList.Name = "DIList"
        Me.DIList.Size = New System.Drawing.Size(568, 256)
        Me.DIList.TabIndex = 0
        Me.DIList.View = System.Windows.Forms.View.Details
        '
        'DIListIDHeader
        '
        Me.DIListIDHeader.Text = "آیدی"
        Me.DIListIDHeader.Width = 0
        '
        'DIListTarikhHeader
        '
        Me.DIListTarikhHeader.Text = "تاریخ یاداشت"
        Me.DIListTarikhHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DIListTarikhHeader.Width = 105
        '
        'DIListSubjectHeader
        '
        Me.DIListSubjectHeader.Text = "موضوع"
        Me.DIListSubjectHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DIListSubjectHeader.Width = 267
        '
        'DIListWriterHeader
        '
        Me.DIListWriterHeader.Text = "نویسنده"
        Me.DIListWriterHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DIListWriterHeader.Width = 196
        '
        'DIDeleteB
        '
        Me.DIDeleteB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.DIDeleteB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DIDeleteB.Location = New System.Drawing.Point(136, 272)
        Me.DIDeleteB.Name = "DIDeleteB"
        Me.DIDeleteB.Size = New System.Drawing.Size(144, 23)
        Me.DIDeleteB.TabIndex = 2
        Me.DIDeleteB.Text = "حذف یاداشت"
        '
        'WriteB
        '
        Me.WriteB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.WriteB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.WriteB.Location = New System.Drawing.Point(304, 272)
        Me.WriteB.Name = "WriteB"
        Me.WriteB.Size = New System.Drawing.Size(144, 23)
        Me.WriteB.TabIndex = 1
        Me.WriteB.Text = "نوشتن یاداشت جدید"
        '
        'HVPanel
        '
        Me.HVPanel.Controls.Add(Me.VHAllDeleteB)
        Me.HVPanel.Controls.Add(Me.HVReportB)
        Me.HVPanel.Controls.Add(Me.HVList)
        Me.HVPanel.Controls.Add(Me.VHDeleteB)
        Me.HVPanel.Controls.Add(Me.VHEditB)
        Me.HVPanel.Controls.Add(Me.VHAddB)
        Me.Panel.SetIndex(Me.HVPanel, CType(6, Short))
        Me.HVPanel.Location = New System.Drawing.Point(152, 448)
        Me.HVPanel.Name = "HVPanel"
        Me.HVPanel.Size = New System.Drawing.Size(584, 304)
        Me.HVPanel.TabIndex = 38
        Me.HVPanel.Visible = False
        '
        'VHAllDeleteB
        '
        Me.VHAllDeleteB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.VHAllDeleteB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.VHAllDeleteB.Location = New System.Drawing.Point(128, 272)
        Me.VHAllDeleteB.Name = "VHAllDeleteB"
        Me.VHAllDeleteB.Size = New System.Drawing.Size(104, 23)
        Me.VHAllDeleteB.TabIndex = 4
        Me.VHAllDeleteB.Text = "حذف همه"
        '
        'HVReportB
        '
        Me.HVReportB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.HVReportB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.HVReportB.Location = New System.Drawing.Point(16, 272)
        Me.HVReportB.Name = "HVReportB"
        Me.HVReportB.Size = New System.Drawing.Size(104, 23)
        Me.HVReportB.TabIndex = 5
        Me.HVReportB.Text = "گزارش"
        '
        'HVList
        '
        Me.HVList.BackColor = System.Drawing.Color.DarkGray
        Me.HVList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HVList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.HVListIDHeader, Me.HVListTarikhHeader, Me.HVListPriceHeader, Me.HVListTellHeader, Me.HVListShParvandehNumHeader, Me.HVListMoajerHeader, Me.HVListMostajerHeader})
        Me.HVList.ForeColor = System.Drawing.Color.White
        Me.HVList.FullRowSelect = True
        Me.HVList.GridLines = True
        Me.HVList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.HVList.Location = New System.Drawing.Point(8, 8)
        Me.HVList.MultiSelect = False
        Me.HVList.Name = "HVList"
        Me.HVList.Size = New System.Drawing.Size(568, 256)
        Me.HVList.TabIndex = 0
        Me.HVList.View = System.Windows.Forms.View.Details
        '
        'HVListIDHeader
        '
        Me.HVListIDHeader.Text = "آیدی"
        Me.HVListIDHeader.Width = 0
        '
        'HVListTarikhHeader
        '
        Me.HVListTarikhHeader.Text = "تاریخ وصول"
        Me.HVListTarikhHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.HVListTarikhHeader.Width = 78
        '
        'HVListPriceHeader
        '
        Me.HVListPriceHeader.Text = "مبلغ وصول"
        Me.HVListPriceHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.HVListPriceHeader.Width = 81
        '
        'HVListTellHeader
        '
        Me.HVListTellHeader.Text = "تلفن تماس"
        Me.HVListTellHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.HVListTellHeader.Width = 89
        '
        'HVListShParvandehNumHeader
        '
        Me.HVListShParvandehNumHeader.Text = "شماره پرونده"
        Me.HVListShParvandehNumHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.HVListShParvandehNumHeader.Width = 89
        '
        'HVListMoajerHeader
        '
        Me.HVListMoajerHeader.Text = "موجر"
        Me.HVListMoajerHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.HVListMoajerHeader.Width = 112
        '
        'HVListMostajerHeader
        '
        Me.HVListMostajerHeader.Text = "مستاجر"
        Me.HVListMostajerHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.HVListMostajerHeader.Width = 119
        '
        'VHDeleteB
        '
        Me.VHDeleteB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.VHDeleteB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.VHDeleteB.Location = New System.Drawing.Point(240, 272)
        Me.VHDeleteB.Name = "VHDeleteB"
        Me.VHDeleteB.Size = New System.Drawing.Size(104, 23)
        Me.VHDeleteB.TabIndex = 3
        Me.VHDeleteB.Text = "حذف"
        '
        'VHEditB
        '
        Me.VHEditB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.VHEditB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.VHEditB.Location = New System.Drawing.Point(352, 272)
        Me.VHEditB.Name = "VHEditB"
        Me.VHEditB.Size = New System.Drawing.Size(104, 23)
        Me.VHEditB.TabIndex = 2
        Me.VHEditB.Text = "ویرایش"
        '
        'VHAddB
        '
        Me.VHAddB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.VHAddB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.VHAddB.Location = New System.Drawing.Point(464, 272)
        Me.VHAddB.Name = "VHAddB"
        Me.VHAddB.Size = New System.Drawing.Size(104, 23)
        Me.VHAddB.TabIndex = 1
        Me.VHAddB.Text = "وصول"
        '
        'HBPanel
        '
        Me.HBPanel.Controls.Add(Me.BHAllDeleteB)
        Me.HBPanel.Controls.Add(Me.HBReportB)
        Me.HBPanel.Controls.Add(Me.HBList)
        Me.HBPanel.Controls.Add(Me.BHDeleteB)
        Me.HBPanel.Controls.Add(Me.BHEditB)
        Me.HBPanel.Controls.Add(Me.BHAddB)
        Me.Panel.SetIndex(Me.HBPanel, CType(7, Short))
        Me.HBPanel.Location = New System.Drawing.Point(176, 448)
        Me.HBPanel.Name = "HBPanel"
        Me.HBPanel.Size = New System.Drawing.Size(584, 304)
        Me.HBPanel.TabIndex = 39
        Me.HBPanel.Visible = False
        '
        'BHAllDeleteB
        '
        Me.BHAllDeleteB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.BHAllDeleteB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BHAllDeleteB.Location = New System.Drawing.Point(128, 272)
        Me.BHAllDeleteB.Name = "BHAllDeleteB"
        Me.BHAllDeleteB.Size = New System.Drawing.Size(104, 23)
        Me.BHAllDeleteB.TabIndex = 4
        Me.BHAllDeleteB.Text = "حذف همه"
        '
        'HBReportB
        '
        Me.HBReportB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.HBReportB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.HBReportB.Location = New System.Drawing.Point(16, 272)
        Me.HBReportB.Name = "HBReportB"
        Me.HBReportB.Size = New System.Drawing.Size(104, 23)
        Me.HBReportB.TabIndex = 5
        Me.HBReportB.Text = "گزارش"
        '
        'HBList
        '
        Me.HBList.BackColor = System.Drawing.Color.DarkGray
        Me.HBList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HBList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.HBListIDHeader, Me.HBListTarikhHeader, Me.HBListPriceHeader, Me.HBListFSubjectHeader, Me.HBListTellHeader, Me.HBListPardakhterHeader})
        Me.HBList.ForeColor = System.Drawing.Color.White
        Me.HBList.FullRowSelect = True
        Me.HBList.GridLines = True
        Me.HBList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.HBList.Location = New System.Drawing.Point(8, 8)
        Me.HBList.MultiSelect = False
        Me.HBList.Name = "HBList"
        Me.HBList.Size = New System.Drawing.Size(568, 256)
        Me.HBList.TabIndex = 0
        Me.HBList.View = System.Windows.Forms.View.Details
        '
        'HBListIDHeader
        '
        Me.HBListIDHeader.Text = "آیدی"
        Me.HBListIDHeader.Width = 0
        '
        'HBListTarikhHeader
        '
        Me.HBListTarikhHeader.Text = "تاریخ برداشت"
        Me.HBListTarikhHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.HBListTarikhHeader.Width = 91
        '
        'HBListPriceHeader
        '
        Me.HBListPriceHeader.Text = "مبلغ برداشت"
        Me.HBListPriceHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.HBListPriceHeader.Width = 95
        '
        'HBListFSubjectHeader
        '
        Me.HBListFSubjectHeader.Text = "بابت موضوع"
        Me.HBListFSubjectHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.HBListFSubjectHeader.Width = 146
        '
        'HBListTellHeader
        '
        Me.HBListTellHeader.Text = "تلفن تماس"
        Me.HBListTellHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.HBListTellHeader.Width = 102
        '
        'HBListPardakhterHeader
        '
        Me.HBListPardakhterHeader.Text = "پرداخت کننده"
        Me.HBListPardakhterHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.HBListPardakhterHeader.Width = 134
        '
        'BHDeleteB
        '
        Me.BHDeleteB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.BHDeleteB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BHDeleteB.Location = New System.Drawing.Point(240, 272)
        Me.BHDeleteB.Name = "BHDeleteB"
        Me.BHDeleteB.Size = New System.Drawing.Size(104, 23)
        Me.BHDeleteB.TabIndex = 3
        Me.BHDeleteB.Text = "حذف"
        '
        'BHEditB
        '
        Me.BHEditB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.BHEditB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BHEditB.Location = New System.Drawing.Point(352, 272)
        Me.BHEditB.Name = "BHEditB"
        Me.BHEditB.Size = New System.Drawing.Size(104, 23)
        Me.BHEditB.TabIndex = 2
        Me.BHEditB.Text = "ویرایش"
        '
        'BHAddB
        '
        Me.BHAddB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.BHAddB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BHAddB.Location = New System.Drawing.Point(464, 272)
        Me.BHAddB.Name = "BHAddB"
        Me.BHAddB.Size = New System.Drawing.Size(104, 23)
        Me.BHAddB.TabIndex = 1
        Me.BHAddB.Text = "برداشت"
        '
        'BSGPanel
        '
        Me.BSGPanel.Controls.Add(Me.AllCB)
        Me.BSGPanel.Controls.Add(Me.SGResidB)
        Me.BSGPanel.Controls.Add(Me.SGSBPrintB)
        Me.BSGPanel.Controls.Add(Me.SGList)
        Me.BSGPanel.Controls.Add(Me.SGDeleteB)
        Me.BSGPanel.Controls.Add(Me.SGEditB)
        Me.BSGPanel.Controls.Add(Me.SGAddB)
        Me.Panel.SetIndex(Me.BSGPanel, CType(8, Short))
        Me.BSGPanel.Location = New System.Drawing.Point(200, 448)
        Me.BSGPanel.Name = "BSGPanel"
        Me.BSGPanel.Size = New System.Drawing.Size(584, 304)
        Me.BSGPanel.TabIndex = 46
        Me.BSGPanel.Visible = False
        '
        'AllCB
        '
        Me.AllCB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.AllCB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AllCB.Location = New System.Drawing.Point(232, 272)
        Me.AllCB.Name = "AllCB"
        Me.AllCB.Size = New System.Drawing.Size(80, 23)
        Me.AllCB.TabIndex = 4
        Me.AllCB.Text = "مجموع"
        '
        'SGResidB
        '
        Me.SGResidB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.SGResidB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SGResidB.Location = New System.Drawing.Point(120, 272)
        Me.SGResidB.Name = "SGResidB"
        Me.SGResidB.Size = New System.Drawing.Size(104, 23)
        Me.SGResidB.TabIndex = 5
        Me.SGResidB.Text = "ارائه رسید"
        '
        'SGSBPrintB
        '
        Me.SGSBPrintB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.SGSBPrintB.Image = CType(resources.GetObject("SGSBPrintB.Image"), System.Drawing.Image)
        Me.SGSBPrintB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SGSBPrintB.Location = New System.Drawing.Point(8, 272)
        Me.SGSBPrintB.Name = "SGSBPrintB"
        Me.SGSBPrintB.Size = New System.Drawing.Size(104, 24)
        Me.SGSBPrintB.TabIndex = 6
        Me.SGSBPrintB.Text = "چاپ سربرگ"
        Me.SGSBPrintB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SGList
        '
        Me.SGList.BackColor = System.Drawing.Color.DarkGray
        Me.SGList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SGList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SGListIDHeader, Me.SGListShShHeader, Me.SGListFathNameHeader, Me.SGListSGNameHeader, Me.SGListGHNumHeader})
        Me.SGList.ForeColor = System.Drawing.Color.White
        Me.SGList.FullRowSelect = True
        Me.SGList.GridLines = True
        Me.SGList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.SGList.Location = New System.Drawing.Point(8, 8)
        Me.SGList.MultiSelect = False
        Me.SGList.Name = "SGList"
        Me.SGList.Size = New System.Drawing.Size(568, 256)
        Me.SGList.TabIndex = 0
        Me.SGList.View = System.Windows.Forms.View.Details
        '
        'SGListIDHeader
        '
        Me.SGListIDHeader.Text = "آیدی"
        Me.SGListIDHeader.Width = 0
        '
        'SGListShShHeader
        '
        Me.SGListShShHeader.Text = "شماره شناسنامه"
        Me.SGListShShHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SGListShShHeader.Width = 127
        '
        'SGListFathNameHeader
        '
        Me.SGListFathNameHeader.Text = "فرزند"
        Me.SGListFathNameHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SGListFathNameHeader.Width = 115
        '
        'SGListSGNameHeader
        '
        Me.SGListSGNameHeader.Text = "سرمایه گذار"
        Me.SGListSGNameHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SGListSGNameHeader.Width = 208
        '
        'SGListGHNumHeader
        '
        Me.SGListGHNumHeader.Text = "شماره قرارداد"
        Me.SGListGHNumHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SGListGHNumHeader.Width = 116
        '
        'SGDeleteB
        '
        Me.SGDeleteB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.SGDeleteB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SGDeleteB.Location = New System.Drawing.Point(320, 272)
        Me.SGDeleteB.Name = "SGDeleteB"
        Me.SGDeleteB.Size = New System.Drawing.Size(80, 23)
        Me.SGDeleteB.TabIndex = 3
        Me.SGDeleteB.Text = "حذف"
        '
        'SGEditB
        '
        Me.SGEditB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.SGEditB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SGEditB.Location = New System.Drawing.Point(408, 272)
        Me.SGEditB.Name = "SGEditB"
        Me.SGEditB.Size = New System.Drawing.Size(80, 23)
        Me.SGEditB.TabIndex = 2
        Me.SGEditB.Text = "ویرایش"
        '
        'SGAddB
        '
        Me.SGAddB.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.SGAddB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SGAddB.Location = New System.Drawing.Point(496, 272)
        Me.SGAddB.Name = "SGAddB"
        Me.SGAddB.Size = New System.Drawing.Size(80, 23)
        Me.SGAddB.TabIndex = 1
        Me.SGAddB.Text = "اضافه کردن"
        '
        'WelcomePanel
        '
        Me.WelcomePanel.Controls.Add(Me.Label3)
        Me.WelcomePanel.Controls.Add(Me.Label2)
        Me.WelcomePanel.Controls.Add(Me.Label1)
        Me.WelcomePanel.Controls.Add(Me.PictureBox2)
        Me.WelcomePanel.Location = New System.Drawing.Point(16, 144)
        Me.WelcomePanel.Name = "WelcomePanel"
        Me.WelcomePanel.Size = New System.Drawing.Size(584, 304)
        Me.WelcomePanel.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label3.Location = New System.Drawing.Point(16, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(560, 176)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "اگر اطلاعات مالی در حد شخصی باشند، برای نگهداری و مدیریت آنها، تنها به چند صفحه ك" & _
        "اغذ نیاز است! اما برای مدیریت و بایگانی اطلاعات مالی در حجمهای بالا روشهای مختلف" & _
        "ی وجود دارد.یكی از همه گیر ترین و سنتی ترین روشها، استفاده از «دفاتر حسابداری» م" & _
        "ی‌باشد. این دفترهای بزرگ دارای صفحه های جدول بندی شده است كه شما می‌توانید هر اط" & _
        "لاعاتی را در آنها وارد كنید و به این ترتیب اطلاعات مالی شما بایگانی خواهد شد. ام" & _
        "ا بزرگترین عیب این روش، در قسمت گزارش گیری (یا خروجی گیری) آشكار می‌شود. فرض كنی" & _
        "د شما كلیه اطلاعات مالی مربوط به مؤسسه تان را در طی 3 سال در 5 دفتر كل وارد كرده" & _
        "‌اید، حالا شما به هر دلیلی به سابقه‌های خرید یك مشتری خاص در طی سال دوم نیاز دار" & _
        "ید.برای اینكار باید در دفاتر مربوط به سال دوم را صفحه به صفحه جستجو كنید و داده‌" & _
        "های مورد نظر خود را جمع آوری نمایید و جایی یادداشت كنید! مسلما این روش به وقت بس" & _
        "یار زیادی نیاز دارد و همچنین درصد خطا در آن بسیار بالاست. اما رایانه‌ها آمده اند" & _
        " تا اینكار و كارهایی از این قبیل را ظرف تنها چند ثانیه و با دقتی اعجاب‌انگیز برا" & _
        "ی شما انجام بدهند! و نیز اولین قدم در اجرای سیاستهای تجارت الكترونیك، استفاده از" & _
        " یك برنامه حسابداری رایانه‌ای، برای حذف كاغذ از فعالیتهای اداری و تجاری است."
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label2.Location = New System.Drawing.Point(16, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(560, 45)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "یكی از زیرشاخه‌های مدیریت پایگاه داده، «حسابداری» است. هر فرد یا مركزی كه به نحوی" & _
        " با مسائل اقتصادی سر و كار دارد، برای سامان دهی مسائل مالی خود، باید از حسابداری" & _
        " استفاده كند. اما روش استفاده با توجه به حجم اطلاعات مالی مربوط به شخص یا مؤسسه،" & _
        " متغیر است."
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label1.Location = New System.Drawing.Point(80, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(496, 72)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "بدون شك یكی از مهمترین كاربردهای (و شاید مهمترین كاربرد) رایانه،استفاده از آن در " & _
        "امور مدیریت حجم عظیم اطلاعات یا همان مدیریت بانكهای اطلاعاتی است. رایانه ها با ت" & _
        "وانایی و سرعت و دقت بی‌نظیر خود، تمام روشهای سنتی مدیریت اطلاعات (آن هم در حجم ب" & _
        "الا) را منسوخ كرده و جایگاه خود را به عنوان یك وسیله‌ی حیاتی در تمام مراكز و دفا" & _
        "تر سراسر دنیا كه با امور اطلاعاتی سر و كار دارند، تثبیت نموده اند."
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(52, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(747, 85)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        '
        'LogoImage
        '
        Me.LogoImage.Location = New System.Drawing.Point(16, 96)
        Me.LogoImage.Name = "LogoImage"
        Me.LogoImage.Size = New System.Drawing.Size(48, 48)
        Me.LogoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoImage.TabIndex = 26
        Me.LogoImage.TabStop = False
        '
        'PStatusBar
        '
        Me.PStatusBar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PStatusBar.Location = New System.Drawing.Point(0, 491)
        Me.PStatusBar.Name = "PStatusBar"
        Me.PStatusBar.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StTime, Me.SGEn, Me.BHesabEn, Me.VHesabEn, Me.ReportEn, Me.BackupEn, Me.ArchiveEn, Me.MoshtariEn})
        Me.PStatusBar.ShowPanels = True
        Me.PStatusBar.Size = New System.Drawing.Size(762, 24)
        Me.PStatusBar.SizingGrip = False
        Me.PStatusBar.TabIndex = 33
        '
        'StTime
        '
        Me.StTime.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.StTime.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StTime.Width = 545
        '
        'SGEn
        '
        Me.SGEn.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.SGEn.Icon = CType(resources.GetObject("SGEn.Icon"), System.Drawing.Icon)
        Me.SGEn.ToolTipText = "بخش سرمایه گذاری"
        Me.SGEn.Width = 31
        '
        'BHesabEn
        '
        Me.BHesabEn.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.BHesabEn.Icon = CType(resources.GetObject("BHesabEn.Icon"), System.Drawing.Icon)
        Me.BHesabEn.ToolTipText = "حسابداری - برداشت"
        Me.BHesabEn.Width = 31
        '
        'VHesabEn
        '
        Me.VHesabEn.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.VHesabEn.Icon = CType(resources.GetObject("VHesabEn.Icon"), System.Drawing.Icon)
        Me.VHesabEn.ToolTipText = "حسابداری - وصول"
        Me.VHesabEn.Width = 31
        '
        'ReportEn
        '
        Me.ReportEn.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.ReportEn.Icon = CType(resources.GetObject("ReportEn.Icon"), System.Drawing.Icon)
        Me.ReportEn.ToolTipText = "بخش گزارش دهی"
        Me.ReportEn.Width = 31
        '
        'BackupEn
        '
        Me.BackupEn.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.BackupEn.Icon = CType(resources.GetObject("BackupEn.Icon"), System.Drawing.Icon)
        Me.BackupEn.ToolTipText = "بخش پشتیبان گیری"
        Me.BackupEn.Width = 31
        '
        'ArchiveEn
        '
        Me.ArchiveEn.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.ArchiveEn.Icon = CType(resources.GetObject("ArchiveEn.Icon"), System.Drawing.Icon)
        Me.ArchiveEn.ToolTipText = "لیست بایگانی"
        Me.ArchiveEn.Width = 31
        '
        'MoshtariEn
        '
        Me.MoshtariEn.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.MoshtariEn.Icon = CType(resources.GetObject("MoshtariEn.Icon"), System.Drawing.Icon)
        Me.MoshtariEn.ToolTipText = "لیست مشتریان"
        Me.MoshtariEn.Width = 31
        '
        'Time
        '
        Me.Time.Interval = 500
        '
        'Browse
        '
        Me.Browse.Description = "انتخاب محل ذخیره فایل پشتیبان"
        '
        'SaveFile
        '
        Me.SaveFile.Filter = "Backup Files (*.bum)|*.bum"
        Me.SaveFile.Title = "ذخیره فایل پشتیبان"
        '
        'OpenFile
        '
        Me.OpenFile.Filter = "Backup Files (*.bum)|*.bum"
        Me.OpenFile.Title = "باز کردن فایل پشتیبان"
        '
        'AlarmList
        '
        Me.AlarmList.BackColor = System.Drawing.Color.DarkGray
        Me.AlarmList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AlarmList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader22, Me.ColumnHeader27, Me.ColumnHeader28})
        Me.AlarmList.ForeColor = System.Drawing.Color.White
        Me.AlarmList.FullRowSelect = True
        Me.AlarmList.GridLines = True
        Me.AlarmList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.AlarmList.Location = New System.Drawing.Point(736, 448)
        Me.AlarmList.MultiSelect = False
        Me.AlarmList.Name = "AlarmList"
        Me.AlarmList.Size = New System.Drawing.Size(24, 16)
        Me.AlarmList.TabIndex = 36
        Me.AlarmList.View = System.Windows.Forms.View.Details
        Me.AlarmList.Visible = False
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "آیدی"
        Me.ColumnHeader22.Width = 0
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "Time"
        Me.ColumnHeader27.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader27.Width = 160
        '
        'ColumnHeader28
        '
        Me.ColumnHeader28.Text = "Date"
        Me.ColumnHeader28.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader28.Width = 133
        '
        'GetAlarmList
        '
        Me.GetAlarmList.Interval = 90000
        '
        'SetAlarm
        '
        Me.SetAlarm.Interval = 60000
        '
        'IconTry
        '
        Me.IconTry.ContextMenu = Me.SysTryMenu
        Me.IconTry.Icon = CType(resources.GetObject("IconTry.Icon"), System.Drawing.Icon)
        Me.IconTry.Text = "Money Security Accountant Edition Gold v4.0"
        '
        'SysTryMenu
        '
        Me.SysTryMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.ShowConMenu, Me.LIne2ConMenu, Me.BackupConMenu, Me.LIne1ConMenu, Me.ExitConMenu})
        Me.SysTryMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'ShowConMenu
        '
        Me.ShowConMenu.Index = 0
        Me.ShowConMenu.Text = "نمایش برنامه"
        '
        'LIne2ConMenu
        '
        Me.LIne2ConMenu.Index = 1
        Me.LIne2ConMenu.Text = "-"
        '
        'BackupConMenu
        '
        Me.BackupConMenu.Index = 2
        Me.BackupConMenu.Text = "پشتیبان گیری از بانک اطلاعاتی"
        '
        'LIne1ConMenu
        '
        Me.LIne1ConMenu.Index = 3
        Me.LIne1ConMenu.Text = "-"
        '
        'ExitConMenu
        '
        Me.ExitConMenu.Index = 4
        Me.ExitConMenu.Text = "خروج"
        '
        'UStatusBar
        '
        Me.UStatusBar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UStatusBar.Location = New System.Drawing.Point(0, 469)
        Me.UStatusBar.Name = "UStatusBar"
        Me.UStatusBar.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StDate, Me.AdminEn, Me.AdminAcc, Me.UserLogin})
        Me.UStatusBar.ShowPanels = True
        Me.UStatusBar.Size = New System.Drawing.Size(762, 22)
        Me.UStatusBar.SizingGrip = False
        Me.UStatusBar.TabIndex = 40
        '
        'StDate
        '
        Me.StDate.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.StDate.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StDate.Width = 690
        '
        'AdminEn
        '
        Me.AdminEn.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.AdminEn.Icon = CType(resources.GetObject("AdminEn.Icon"), System.Drawing.Icon)
        Me.AdminEn.ToolTipText = "بخش مدیریت"
        Me.AdminEn.Width = 31
        '
        'AdminAcc
        '
        Me.AdminAcc.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.AdminAcc.ToolTipText = "سطح دسترسی"
        Me.AdminAcc.Width = 10
        '
        'UserLogin
        '
        Me.UserLogin.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.UserLogin.Icon = CType(resources.GetObject("UserLogin.Icon"), System.Drawing.Icon)
        Me.UserLogin.ToolTipText = "کاربر آنلاین"
        Me.UserLogin.Width = 31
        '
        'MListMenu
        '
        Me.MListMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.GoldPicMenu, Me.MPicMenu})
        Me.MListMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'GoldPicMenu
        '
        Me.GoldPicMenu.Index = 0
        Me.GoldPicMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.ViewGoldPicMenu, Me.PrintGoldPicMenu})
        Me.GoldPicMenu.Text = "عکس طلا"
        '
        'ViewGoldPicMenu
        '
        Me.ViewGoldPicMenu.Index = 0
        Me.ViewGoldPicMenu.Text = "نمایش"
        '
        'PrintGoldPicMenu
        '
        Me.PrintGoldPicMenu.Index = 1
        Me.PrintGoldPicMenu.Text = "چاپ"
        '
        'MPicMenu
        '
        Me.MPicMenu.Index = 1
        Me.MPicMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.ViewMPicMenu, Me.PrintMPicMenu})
        Me.MPicMenu.Text = "عکس مشتری"
        '
        'ViewMPicMenu
        '
        Me.ViewMPicMenu.Index = 0
        Me.ViewMPicMenu.Text = "نمایش"
        '
        'PrintMPicMenu
        '
        Me.PrintMPicMenu.Index = 1
        Me.PrintMPicMenu.Text = "چاپ"
        '
        'PicPrintDocument
        '
        Me.PicPrintDocument.DocumentName = "عکس طلا"
        '
        'PicPrintDialog
        '
        Me.PicPrintDialog.Document = Me.PicPrintDocument
        '
        'PicPrintPreviewDialog
        '
        Me.PicPrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PicPrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PicPrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.PicPrintPreviewDialog.Document = Me.PicPrintDocument
        Me.PicPrintPreviewDialog.Enabled = True
        Me.PicPrintPreviewDialog.Icon = CType(resources.GetObject("PicPrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.PicPrintPreviewDialog.Location = New System.Drawing.Point(199, 18)
        Me.PicPrintPreviewDialog.MinimumSize = New System.Drawing.Size(375, 250)
        Me.PicPrintPreviewDialog.Name = "PicPrintPreviewDialog"
        Me.PicPrintPreviewDialog.TransparencyKey = System.Drawing.Color.Empty
        Me.PicPrintPreviewDialog.Visible = False
        '
        'AllCMenu
        '
        Me.AllCMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.AllCGMenu, Me.AllCSGMenu, Me.AllCMVMenu})
        '
        'AllCGMenu
        '
        Me.AllCGMenu.Index = 0
        Me.AllCGMenu.Text = "مجموع طلا"
        '
        'AllCSGMenu
        '
        Me.AllCSGMenu.Index = 1
        Me.AllCSGMenu.Text = "مجموع سرمایه"
        '
        'AllCMVMenu
        '
        Me.AllCMVMenu.Index = 2
        Me.AllCMVMenu.Text = "مجموع مبلغ وام"
        '
        'AllPrintMMenu
        '
        Me.AllPrintMMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MSBPrintMenu, Me.MPrintMenu, Me.MInfPrintMenu, Me.MFormPrintMenu})
        '
        'MSBPrintMenu
        '
        Me.MSBPrintMenu.Index = 0
        Me.MSBPrintMenu.Text = "سربرگ"
        '
        'MPrintMenu
        '
        Me.MPrintMenu.Index = 1
        Me.MPrintMenu.Text = "دفترچه قسط"
        '
        'MInfPrintMenu
        '
        Me.MInfPrintMenu.Index = 2
        Me.MInfPrintMenu.Text = "اطلاعات"
        '
        'MFormPrintMenu
        '
        Me.MFormPrintMenu.Index = 3
        Me.MFormPrintMenu.Text = "فرم شناسه مشتری"
        '
        'Main
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(762, 515)
        Me.Controls.Add(Me.UStatusBar)
        Me.Controls.Add(Me.PStatusBar)
        Me.Controls.Add(Me.DBPanel)
        Me.Controls.Add(Me.BSGPanel)
        Me.Controls.Add(Me.HBPanel)
        Me.Controls.Add(Me.HVPanel)
        Me.Controls.Add(Me.AlarmList)
        Me.Controls.Add(Me.DIPanel)
        Me.Controls.Add(Me.BGDPanel)
        Me.Controls.Add(Me.BPGPanel)
        Me.Controls.Add(Me.LBPanel)
        Me.Controls.Add(Me.LMPanel)
        Me.Controls.Add(Me.BMPanel)
        Me.Controls.Add(Me.VHT)
        Me.Controls.Add(Me.BGDT)
        Me.Controls.Add(Me.BPGT)
        Me.Controls.Add(Me.LBT)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.LMT)
        Me.Controls.Add(Me.BMT)
        Me.Controls.Add(Me.IFT3)
        Me.Controls.Add(Me.IFT2)
        Me.Controls.Add(Me.IFT1)
        Me.Controls.Add(Me.WelcomePanel)
        Me.Controls.Add(Me.DIT)
        Me.Controls.Add(Me.BHT)
        Me.Controls.Add(Me.LogoImage)
        Me.Controls.Add(Me.TabTitrL)
        Me.Controls.Add(Me.DBT)
        Me.Controls.Add(Me.BSGT)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu
        Me.Name = "Main"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Money Security Accountant Edition Gold"
        CType(Me.Tab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LMPanel.ResumeLayout(False)
        CType(Me.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LBPanel.ResumeLayout(False)
        Me.BMPanel.ResumeLayout(False)
        Me.BPGPanel.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.BGDPanel.ResumeLayout(False)
        Me.DBPanel.ResumeLayout(False)
        Me.DIPanel.ResumeLayout(False)
        Me.HVPanel.ResumeLayout(False)
        Me.HBPanel.ResumeLayout(False)
        Me.BSGPanel.ResumeLayout(False)
        Me.WelcomePanel.ResumeLayout(False)
        CType(Me.StTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SGEn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BHesabEn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VHesabEn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportEn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackupEn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArchiveEn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoshtariEn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminEn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminAcc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Decs"
    Dim DBConn As DBConnection
    Dim Item As ListViewItem
    Dim TabC(9) As Boolean
    Dim IFNE As Boolean = False
    Dim MVF As Boolean = False
    Dim MeLeft As Integer
    Dim MeTop As Integer
    Dim sortColumn As Integer = -1
    Dim PPDMode As Integer
#End Region

    Private Sub ExitMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitMenu.Click, ExitConMenu.Click
        Me.Close()
    End Sub

    Private Sub Main_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        SetGetChange("Set")
        IconTry.Dispose()
        End
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = " موبایل زاگرس                                                                                   Money Security Accountant Edition Gold"
        StDate.Text = Long_Shamsi()
        StTime.Text = "  " & TimeOfDay & " "
        Time.Enabled = True
        GetAlarmList.Enabled = True
        SetAlarm.Enabled = True
        SetGetChange("Get")
    End Sub

    Private Sub Tab_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Tab.MouseDown
        Dim Index As Short = Tab.GetIndex(sender)
        Tab(Index).Image = IFT3.Image
    End Sub

    Private Sub Tab_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tab.MouseLeave
        Dim Index As Short = Tab.GetIndex(sender)
        If TabC(Index) = False Then Tab(Index).Image = IFT1.Image
    End Sub

    Private Sub Tab_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Tab.MouseMove
        Dim Index As Short = Tab.GetIndex(sender)
        If TabC(Index) = False Then Tab(Index).Image = IFT2.Image
    End Sub

    Private Sub Tab_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tab.Click
        Dim Index As Short = Tab.GetIndex(sender)
        Dim ToolsForm As New Tools
        If TabC(Index) = False Then
            Tab(Index).Image = IFT3.Image
            TabC(Index) = True
            Panel(Index).Left = 16
            Panel(Index).Top = 144
            Panel(Index).Visible = True
            Panel(Index).BringToFront()
            For I As Integer = 0 To Tab.Count - 1
                If I <> Index Then Tab(I).Image = IFT1.Image : TabC(I) = False : Panel(I).Visible = False
            Next
            LogoImage.Visible = True
            LogoImage.Image = ToolsForm.Logo(Index).Image
            Get_Title(Index)
        Else
            Tab(Index).Image = IFT2.Image
            TabC(Index) = False
            Panel(Index).Visible = False
            LogoImage.Image = Nothing
            Get_Title(10)
        End If
    End Sub

    Private Sub Get_Title(ByVal Index As Integer)
        Select Case Index
            Case 0
                TabTitrL.Text = "بخش مدیریت"
            Case 1
                TabTitrL.Text = "لیست مشتریان"
            Case 2
                TabTitrL.Text = "لیست بایگانی"
            Case 3
                TabTitrL.Text = "بخش پشتیبان گیری"
            Case 4
                TabTitrL.Text = "بخش گزارش دهی"
            Case 5
                TabTitrL.Text = "دفتر یاداشت"
            Case 6
                TabTitrL.Text = "حسابداری - وصول"
            Case 7
                TabTitrL.Text = "حسابداری - برداشت"
            Case 8
                TabTitrL.Text = "بخش سرمایه گذاری"
            Case 9
                TabTitrL.Text = "درباره برنامه"
            Case 10
                TabTitrL.Text = "به برنامه حسابداری موبایل زاگرس خوش آمدید"
        End Select
    End Sub

    Public Sub Get_Setting(ByVal Index As Integer)
        Application.DoEvents()
        Select Case Index
            Case 0
                'TabTitrL.Text = "بخش مدیریت"
                AdList.Items.Clear()
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("SELECT * FROM Administrator;")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                        Do While d.Read
                            Item = AdList.Items.Add(d("ID".ToString))
                            With Item
                                .SubItems.Add(d("God".ToString))
                                .SubItems.Add(d("Active".ToString))
                                .SubItems.Add(d("AdminAcc".ToString))
                                .SubItems.Add(d("FullName".ToString))
                                .SubItems.Add(d("AdminID".ToString))
                            End With
                            Application.DoEvents()
                        Loop
                        Try
                            DBConn.OLEConn.Close()
                        Catch err As System.Exception
                            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                        End Try
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
            Case 1
                'TabTitrL.Text = "لیست مشتریان"
                MList.Items.Clear()
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("SELECT * FROM MoshtariList WHERE IsArchive=False ORDER BY SHParvandeNum;")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                        Do While d.Read
                            Item = MList.Items.Add(d("ID".ToString))
                            With Item
                                If d("MPicExist".ToString) = True Then .SubItems.Add("موجود") Else .SubItems.Add("")
                                If d("PicExist".ToString) = True Then .SubItems.Add("موجود") Else .SubItems.Add("")
                                .SubItems.Add(d("CGGold".ToString))
                                .SubItems.Add(d("Tell".ToString))
                                .SubItems.Add(d("MostajerFN".ToString) & " " & d("MostajerLN".ToString))
                                .SubItems.Add(d("MoajerFN".ToString) & " " & d("MoajerLN".ToString))
                                .SubItems.Add(d("SHParvandeNum".ToString))
                            End With
                            Application.DoEvents()
                        Loop
                        Try
                            DBConn.OLEConn.Close()
                        Catch err As System.Exception
                            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                        End Try
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
            Case 2
                'TabTitrL.Text = "لیست بایگانی"
                AList.Items.Clear()
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("SELECT * FROM MoshtariList WHERE IsArchive=True ORDER BY SHParvandeNum;")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                        Do While d.Read
                            Item = AList.Items.Add(d("ID".ToString))
                            With Item
                                .SubItems.Add(d("Tell".ToString))
                                .SubItems.Add(d("MostajerFN".ToString) & " " & d("MostajerLN".ToString))
                                .SubItems.Add(d("MoajerFN".ToString) & " " & d("MoajerLN".ToString))
                                .SubItems.Add(d("SHParvandeNum".ToString))
                                If d("IsCancel".ToString) Then
                                    .BackColor = System.Drawing.Color.RosyBrown
                                    '.ForeColor = System.Drawing.Color.White
                                End If
                                If d("IsBlackCancel".ToString) Then
                                    .BackColor = System.Drawing.Color.Black
                                    .ForeColor = System.Drawing.Color.White
                                End If
                            End With
                            Application.DoEvents()
                        Loop
                        Try
                            DBConn.OLEConn.Close()
                        Catch err As System.Exception
                            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                        End Try
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
            Case 3
                'TabTitrL.Text = "بخش پشتیبان گیری"
                Try
                    BackupFAO.Text = GetValue("HKEY_LOCAL_MACHINE", "SOFTWARE\Money Security\Accountant Edition Gold\Backup", "BackupPath")
                    AutoBackup.CheckState = GetValue("HKEY_LOCAL_MACHINE", "SOFTWARE\Money Security\Accountant Edition Gold\Backup", "AutoBackup")
                Catch err As System.Exception
                    'If MessageBox("خطا در تنظیمات پشتیبان گیر. آیا می خواهید برنامه به حالت پیش فرض باز گردد؟", MsgBoxStyle.YesNo, "بخش پشتیبان گیری") = True Then
                    SetValue("HKEY_LOCAL_MACHINE", "SOFTWARE\Money Security\Accountant Edition Gold\Backup", "BackupPath", App_Path() & "Backup\")
                    SetValue("HKEY_LOCAL_MACHINE", "SOFTWARE\Money Security\Accountant Edition Gold\Backup", "AutoBackup", 0)
                    BackupFAO.Text = App_Path() & "Backup\"
                    AutoBackup.CheckState = 0
                    'Else
                    'BackupFA.Text = ""
                    'AutoBackup.Checked = False
                    'End If
                End Try
                If BackupFAO.Text.Length > 33 Then
                    BackupFA.Text = Microsoft.VisualBasic.Left(BackupFAO.Text, 45) & "..."
                Else
                    BackupFA.Text = BackupFAO.Text
                End If
                SaveB.Enabled = False
            Case 4
                'TabTitrL.Text = "بخش گزارش دهی"
                DateList.Items.Clear()
                DateList.Items.Add("")
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("SELECT * FROM MoshtariList WHERE IsBlackCancel=False;")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                        Do While d.Read
                            IFNE = False
                            For I As Integer = 0 To DateList.Items.Count - 1
                                If DateList.Items.Item(I) = d("TarikheGha".ToString) Then IFNE = True : Exit For
                            Next
                            If IFNE = False Then DateList.Items.Add(d("TarikheGha".ToString))
                        Loop
                        Try
                            DBConn.OLEConn.Close()
                        Catch err As System.Exception
                            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                        End Try
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
                If DateList.Items.Count > 0 Then DateList.SelectedIndex = 0
                DayList.Items.Clear()
                DayList.Items.Add("")
                For I As Integer = 1 To 31
                    DayList.Items.Add(I)
                Next
                FTarikh.Text = Shamsi()
                TTarikh.Text = Shamsi()
                DayList.SelectedIndex = 0
                DateCheck.Checked = True
            Case 5
                'TabTitrL.Text = "دفتر یاداشت"
                DIList.Items.Clear()
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("SELECT * FROM NoteBook;")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                        Do While d.Read
                            Select Case IsGod.Checked
                                Case True
                                    Item = DIList.Items.Add(d("ID".ToString))
                                    With Item
                                        .SubItems.Add(d("WriteDate".ToString))
                                        .SubItems.Add(d("Subject".ToString))
                                        .SubItems.Add(d("Writer".ToString))
                                    End With
                                Case False
                                    If d("Prem".ToString) = "All" Then
                                        Item = DIList.Items.Add(d("ID".ToString))
                                        With Item
                                            .SubItems.Add(d("WriteDate".ToString))
                                            .SubItems.Add(d("Subject".ToString))
                                            .SubItems.Add(d("Writer".ToString))
                                        End With
                                    ElseIf d("Prem".ToString) = "Clear" Then
                                        If d("AdminID".ToString) = OnAdminID.Text Then
                                            Item = DIList.Items.Add(d("ID".ToString))
                                            With Item
                                                .SubItems.Add(d("WriteDate".ToString))
                                                .SubItems.Add(d("Subject".ToString))
                                                .SubItems.Add(d("Writer".ToString))
                                            End With
                                        End If
                                    Else
                                        If d("AdminID".ToString) = OnAdminID.Text Or d("Prem".ToString) = OnAdminID.Text Then
                                            Item = DIList.Items.Add(d("ID".ToString))
                                            With Item
                                                .SubItems.Add(d("WriteDate".ToString))
                                                .SubItems.Add(d("Subject".ToString))
                                                .SubItems.Add(d("Writer".ToString))
                                            End With
                                        End If
                                    End If
                            End Select
                            Application.DoEvents()
                        Loop
                        Try
                            DBConn.OLEConn.Close()
                        Catch err As System.Exception
                            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                        End Try
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
            Case 6
                'TabTitrL.Text = "حسابداری - وصول"
                HVList.Items.Clear()
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("SELECT * FROM HVList;")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                        Do While d.Read
                            Item = HVList.Items.Add(d("ID".ToString))
                            With Item
                                .SubItems.Add(d("Tarikh".ToString))
                                .SubItems.Add(d("Mablagh".ToString))
                                .SubItems.Add(d("Tell".ToString))
                                .SubItems.Add(d("SHParvandeNum".ToString))
                                .SubItems.Add(d("Moajer".ToString))
                                .SubItems.Add(d("Mostajer".ToString))
                            End With
                            Application.DoEvents()
                        Loop
                        Try
                            DBConn.OLEConn.Close()
                        Catch err As System.Exception
                            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                        End Try
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
            Case 7
                'TabTitrL.Text = "حسابداری - برداشت"
                HBList.Items.Clear()
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("SELECT * FROM HBList;")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                        Do While d.Read
                            Item = HBList.Items.Add(d("ID".ToString))
                            With Item
                                .SubItems.Add(d("Tarikh".ToString))
                                .SubItems.Add(d("Mablagh".ToString))
                                .SubItems.Add(d("ForSub".ToString))
                                .SubItems.Add(d("Tell".ToString))
                                .SubItems.Add(d("Pardakhter".ToString))
                            End With
                            Application.DoEvents()
                        Loop
                        Try
                            DBConn.OLEConn.Close()
                        Catch err As System.Exception
                            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                        End Try
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
            Case 8
                'TabTitrL.Text = "بخش سرمایه گذاری"
                SGList.Items.Clear()
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("SELECT * FROM SGozari ORDER BY GharardadNum;")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                        Do While d.Read
                            Item = SGList.Items.Add(d("ID".ToString))
                            With Item
                                .SubItems.Add(d("SHenasnameNum".ToString))
                                .SubItems.Add(d("Farzand".ToString))
                                .SubItems.Add(d("SFName".ToString) & " " & d("SLName".ToString))
                                .SubItems.Add(d("GharardadNum".ToString))
                            End With
                            Application.DoEvents()
                        Loop
                        Try
                            DBConn.OLEConn.Close()
                        Catch err As System.Exception
                            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                        End Try
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
            Case 9
                'TabTitrL.Text = "درباره برنامه"
                Dim ToolsForm As New Tools
                AboutLogo.Image = ToolsForm.AboutLogo.Image
                Try
                    Licensed.Text = " Full Name : " & GetValue("HKEY_LOCAL_MACHINE", "SOFTWARE\Money Security\Accountant Edition Gold\Register", "FirstName") & " " & GetValue("HKEY_LOCAL_MACHINE", "SOFTWARE\Money Security\Accountant Edition Gold\Register", "LastName")
                Catch err As System.Exception
                    Licensed.Text = " Full Name : Unknown"
                End Try
                Licensed.Text = Licensed.Text & vbCrLf
                Try
                    Licensed.Text = Licensed.Text & " Serial Number : " & GetValue("HKEY_LOCAL_MACHINE", "SOFTWARE\Money Security\Accountant Edition Gold\Register", "SerialNumber")
                Catch err As System.Exception
                    Licensed.Text = Licensed.Text & " Serial Number : Unknown"
                End Try
                Licensed.Text = Licensed.Text & vbCrLf
                Try
                    Licensed.Text = Licensed.Text & " Activation Code : " & GetValue("HKEY_LOCAL_MACHINE", "SOFTWARE\Money Security\Accountant Edition Gold\Register", "ActiveCode")
                Catch err As System.Exception
                    Licensed.Text = Licensed.Text & " Activation Code : Unknown"
                End Try
            Case 10
                'TabTitrL.Text = "به برنامه حسابداری موبایل زاگرس خوش آمدید"
        End Select
    End Sub

    Private Sub AddB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddB.Click, LMTAddMenu.Click
        Dim AddForm As New AddF
        AddForm.ShowDialog()
        'Get_Setting(1)
        If AddForm.OK = True Then
            SortType = "Numeric"
            NewCol = -1
            Item = MList.Items.Add(AddForm.SHParvandeNum.Text)
            With Item
                If AddForm.MPicExist.Checked = True Then .SubItems.Add("موجود") Else .SubItems.Add("")
                If AddForm.PicExist.Checked = True Then .SubItems.Add("موجود") Else .SubItems.Add("")
                .SubItems.Add(AddForm.CGGold.Text)
                .SubItems.Add(AddForm.Tell.Text)
                .SubItems.Add(AddForm.MostajerFN.Text & " " & AddForm.MostajerLN.Text)
                .SubItems.Add(AddForm.MoajerFN.Text & " " & AddForm.MoajerLN.Text)
                .SubItems.Add(AddForm.SHParvandeNum.Text)
            End With
            MList.Sorting = SortOrder.Ascending
            NewCol = 7
            MList.Sort()
            MList.ListViewItemSorter = New ColumnSorter(7, MList.Sorting)
            MList.Items(Item.Index).Selected = True
            MList.Focus()
        End If
    End Sub

    Private Sub MoveB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveB.Click, LBTMoveMenu.Click
        If AList.SelectedItems.Count > 0 Then
            If AList.SelectedItems(0).BackColor.Name = "Black" Then MessageBox("پرونده مورد نظر مسدود می باشد برای انتقال ابتدا آن را فعال کنید.", MsgBoxStyle.OKOnly, "انتقال مشتریان") : Exit Sub
            If MessageBox("آیا می خواهید مشتری مورد نظر با شماره پرونده " & AList.SelectedItems(0).SubItems(4).Text & " را به لیست مشتریان انتقال دهید؟", MsgBoxStyle.YesNo, "انتقال مشتریان") = True Then
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("Update MoshtariList SET IsArchive=False, IsCancel=False WHERE ID=" & AList.SelectedItems(0).SubItems(0).Text & ";")
                    DBConn.OLEComm.Connection = DBConn.OLEConn
                    DBConn.OLEComm.ExecuteNonQuery()
                    DBConn.OLEConn.Close()
                    'Get_Setting(2)
                    SortType = "Numeric"
                    NewCol = -1
                    Try
                        DBConn = New DBConnection
                        DBConn.connectMe("SELECT * FROM MoshtariList WHERE ID=" & AList.SelectedItems(0).SubItems(0).Text & ";")
                        Try
                            DBConn.OLEComm.Connection = DBConn.OLEConn
                            Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                            Do While d.Read
                                Item = MList.Items.Add(d("ID".ToString))
                                With Item
                                    If d("PicExist".ToString) = True Then .SubItems.Add("موجود") Else .SubItems.Add("")
                                    .SubItems.Add(d("CGGold".ToString))
                                    .SubItems.Add(d("Tell".ToString))
                                    .SubItems.Add(d("MostajerFN".ToString) & " " & d("MostajerLN".ToString))
                                    .SubItems.Add(d("MoajerFN".ToString) & " " & d("MoajerLN".ToString))
                                    .SubItems.Add(d("SHParvandeNum".ToString))
                                End With
                            Loop
                            Try
                                DBConn.OLEConn.Close()
                            Catch err As System.Exception
                                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                            End Try
                        Catch err As System.Exception
                            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                        End Try
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    End Try
                    AList.SelectedItems(0).Remove()
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
                MList.Sorting = SortOrder.Ascending
                NewCol = 6
                MList.Sort()
                MList.ListViewItemSorter = New ColumnSorter(6, MList.Sorting)
            End If
        End If
    End Sub

    Private Sub MList_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MList.DoubleClick, LMTViewMenu.Click
        If MList.SelectedItems.Count > 0 Then
            Dim ViewFormM As New ViewF
            ViewFormM.SHParvandeNum.Text = MList.SelectedItems(0).SubItems(7).Text
            ViewFormM.IsArchive.Checked = False
            ViewFormM.PeGet.Text = Microsoft.VisualBasic.Left(UserLogin.Text, UserLogin.Text.Length - 1)
            ViewFormM.CancelMoveB.Enabled = FullMList.Checked
            ViewFormM.MoveB.Enabled = FullMList.Checked
            ViewFormM.ShowDialog()
            If MoveArchive = True Then
                'Get_Setting(1)
                Item = AList.Items.Add(MList.SelectedItems(0).SubItems(0).Text)
                With Item
                    .SubItems.Add(MList.SelectedItems(0).SubItems(4).Text)
                    .SubItems.Add(MList.SelectedItems(0).SubItems(5).Text)
                    .SubItems.Add(MList.SelectedItems(0).SubItems(6).Text)
                    .SubItems.Add(MList.SelectedItems(0).SubItems(7).Text)
                    If ViewFormM.CancelP = True Then .BackColor = System.Drawing.Color.RosyBrown
                End With
                MList.SelectedItems(0).Remove()
                If MList.Items.Count <> 0 Then MList.Items(0).Selected = True
                MList.Focus()
                MoveArchive = False
            End If
        End If
    End Sub

    Private Sub DeleteB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteB.Click, LMTDeleteMenu.Click
        If MList.SelectedItems.Count > 0 Then
            If MessageBox("آیا می خواهید مشتری مورد نظر با شماره پرونده " & MList.SelectedItems(0).SubItems(6).Text & " را حذف کنید؟", MsgBoxStyle.YesNo, "لیست مشتریان") = True Then
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("Delete From MoshtariList WHERE SHParvandeNum = " & MList.SelectedItems(0).SubItems(7).Text & ";")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        DBConn.OLEComm.ExecuteNonQuery()
                        DBConn.OLEConn.Close()
                        Try
                            DBConn.OLEConn.Close()
                        Catch err As System.Exception
                            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                        End Try
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                End Try
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("Delete From AnyMoshtari WHERE SHParvandeNum = '" & MList.SelectedItems(0).SubItems(7).Text & "';")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        DBConn.OLEComm.ExecuteNonQuery()
                        DBConn.OLEConn.Close()
                        Try
                            DBConn.OLEConn.Close()
                        Catch err As System.Exception
                            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                        End Try
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                End Try
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("Delete From AnySGozari WHERE SHParvandeNum='" & MList.SelectedItems(0).SubItems(7).Text & "';")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        DBConn.OLEComm.ExecuteNonQuery()
                        DBConn.OLEConn.Close()
                        Try
                            DBConn.OLEConn.Close()
                        Catch err As System.Exception
                            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                        End Try
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                End Try
                'Get_Setting(1)
                MList.SelectedItems(0).Remove()
                If MList.Items.Count <> 0 Then MList.Items(0).Selected = True
                MList.Focus()
            End If
        Else
            MessageBox("برای حذف از لیست مشتریان لطفا ابتدا مشتری مورد نطر را انتخاب کنید.", MsgBoxStyle.OKOnly, "لیست مشتریان")
        End If
    End Sub

    Private Sub EditB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditB.Click, LMTEditMenu.Click
        If MList.SelectedItems.Count > 0 Then
            Dim EditForm As New EditF
            EditForm.SHParvandeNum.Text = MList.SelectedItems(0).SubItems(7).Text
            EditForm.ID.Text = MList.SelectedItems(0).SubItems(0).Text
            EditForm.ShowDialog()
            Get_Setting_Single(1)
            MList.Focus()
        Else
            MessageBox("برای ویرایش مشتریان لطفا ابتدا مشتری مورد نطر را انتخاب کنید.", MsgBoxStyle.OKOnly, "ویرایش مشتریان")
        End If
    End Sub

    Private Sub AList_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AList.DoubleClick, LBTViewMenu.Click
        If AList.SelectedItems.Count > 0 Then
            Dim ViewFormA As New ViewF
            ViewFormA.SHParvandeNum.Text = AList.SelectedItems(0).SubItems(4).Text
            ViewFormA.IsArchive.Checked = True
            ViewFormA.ShowDialog()
        End If
    End Sub

    Private Sub FindN1Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindN1Menu.Click
        Dim FindForm As New FindF
        FindForm.LNFind.Text = "شماره شناسایی پرونده :"
        FindForm.NFind.Text = "1"
        FindForm.txtFind.TextAlign = HorizontalAlignment.Right
        FindForm.ShowDialog()
        If FindForm.OKClick = False Then Exit Sub
        Dim ViewFindForm As New ViewFindF
        ViewFindForm.txtFind.Text = FindForm.txtFind.Text
        ViewFindForm.NFind.Text = FindForm.NFind.Text
        ViewFindForm.ShowDialog()
    End Sub

    Private Sub FindN2Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindN2Menu.Click
        Dim FindForm As New FindF
        FindForm.LNFind.Text = "نام و نام خانوادگی موجر :"
        FindForm.NFind.Text = "2"
        FindForm.ShowDialog()
        If FindForm.OKClick = False Then Exit Sub
        Dim ViewFindForm As New ViewFindF
        ViewFindForm.txtFind.Text = FindForm.txtFind.Text
        ViewFindForm.NFind.Text = FindForm.NFind.Text
        ViewFindForm.ShowDialog()
    End Sub

    Private Sub FindN3Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindN3Menu.Click
        Dim FindForm As New FindF
        FindForm.LNFind.Text = "نام و نام خانوادگی مستاجر :"
        FindForm.NFind.Text = "3"
        FindForm.ShowDialog()
        If FindForm.OKClick = False Then Exit Sub
        Dim ViewFindForm As New ViewFindF
        ViewFindForm.txtFind.Text = FindForm.txtFind.Text
        ViewFindForm.NFind.Text = FindForm.NFind.Text
        ViewFindForm.ShowDialog()
    End Sub

    Private Sub FindN4Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindN4Menu.Click
        Dim FindForm As New FindF
        FindForm.LNFind.Text = "شماره تلفن تماس :"
        FindForm.NFind.Text = "4"
        FindForm.txtFind.TextAlign = HorizontalAlignment.Right
        FindForm.ShowDialog()
        If FindForm.OKClick = False Then Exit Sub
        Dim ViewFindForm As New ViewFindF
        ViewFindForm.txtFind.Text = FindForm.txtFind.Text
        ViewFindForm.NFind.Text = FindForm.NFind.Text
        ViewFindForm.ShowDialog()
    End Sub

    Private Sub LMTOMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LMTOMenu.Click
        If TabC(1) = False Then Tab_Click(LMT, e)
    End Sub

    Private Sub LMTMenu_Select(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LMTMenu.Select
        If MList.SelectedItems.Count > 0 Then
            LMTViewMenu.Enabled = True
            LMTEditMenu.Enabled = True
            LMTDeleteMenu.Enabled = True
            LMTPrintMenu.Enabled = True
        Else
            LMTViewMenu.Enabled = False
            LMTEditMenu.Enabled = False
            LMTDeleteMenu.Enabled = False
            LMTPrintMenu.Enabled = False
        End If
    End Sub

    Private Sub LBTMenu_Select(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBTMenu.Select
        If AList.SelectedItems.Count > 0 Then
            LBTViewMenu.Enabled = True
            LBTMoveMenu.Enabled = True
        Else
            LBTViewMenu.Enabled = False
            LBTMoveMenu.Enabled = False
        End If
    End Sub

    Private Sub LBTOMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBTOMenu.Click
        If TabC(2) = False Then Tab_Click(LBT, e)
    End Sub

    Private Sub BrowseB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseB.Click
        If Browse.ShowDialog = DialogResult.OK Then
            If Microsoft.VisualBasic.Right(Browse.SelectedPath, 1) = "\" Or Microsoft.VisualBasic.Right(Browse.SelectedPath, 1) = "/" Then
                BackupFAO.Text = Browse.SelectedPath
            Else
                BackupFAO.Text = Browse.SelectedPath & "\"
            End If
            If BackupFAO.Text.Length > 33 Then
                BackupFA.Text = Microsoft.VisualBasic.Left(BackupFAO.Text, 45) & "..."
            Else
                BackupFA.Text = BackupFAO.Text
            End If
            SaveB.Enabled = True
        End If
    End Sub

    Private Sub DateList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateList.SelectedIndexChanged
        ReList.Items.Clear()
        If DateList.Text = "" Then Exit Sub
        Try
            DBConn = New DBConnection
            DBConn.connectMe("SELECT * FROM MoshtariList WHERE TarikheGha='" & DateList.Text & "' And IsBlackCancel=False ORDER BY SHParvandeNum;")
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                Do While d.Read
                    Item = ReList.Items.Add(d("ID".ToString))
                    With Item
                        .SubItems.Add(d("Tell".ToString))
                        .SubItems.Add(d("MostajerFN".ToString) & " " & d("MostajerLN".ToString))
                        .SubItems.Add(d("MoajerFN".ToString) & " " & d("MoajerLN".ToString))
                        .SubItems.Add(d("SHParvandeNum".ToString))
                    End With
                Loop
                Try
                    DBConn.OLEConn.Close()
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            End Try
        Catch err As System.Exception
            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
        End Try
    End Sub

    Private Sub BMAddB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BMAddB.Click, BMTAddMenu.Click
        If IsGod.Checked = True Then
            Dim AdminAddForm As New AdminAddF
            AdminAddForm.OnAdminID.Text = OnAdminID.Text
            AdminAddForm.IsGod.Checked = IsGod.Checked
            AdminAddForm.ShowDialog()
            Get_Setting(0)
        Else
            MessageBox("کاربر گرامی شما قادر به اضافه کردن مدیر جدید نمی باشید.", MsgBoxStyle.OKOnly, "بخش مدیریت")
        End If
    End Sub

    Private Sub Time_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Time.Tick
        StTime.Text = "  " & TimeOfDay & " "
        StDate.Text = Long_Shamsi()
    End Sub

    Private Sub BMEditB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BMEditB.Click, BMTEditMenu.Click
        If AdList.SelectedItems.Count > 0 Then
            If IsGod.Checked = True Then
                Dim AdminEditForm As New AdminEditF
                AdminEditForm.ID.Text = AdList.SelectedItems(0).SubItems(0).Text
                AdminEditForm.OnAdminID.Text = OnAdminID.Text
                AdminEditForm.IsGod.Checked = IsGod.Checked
                AdminEditForm.ShowDialog()
                Get_Setting_Single(0)
                AdList.Focus()
            ElseIf OnAdminID.Text = AdList.SelectedItems(0).SubItems(5).Text Then
                Dim AdminEditForm As New AdminEditF
                AdminEditForm.ID.Text = AdList.SelectedItems(0).SubItems(0).Text
                AdminEditForm.OnAdminID.Text = OnAdminID.Text
                AdminEditForm.IsGod.Checked = IsGod.Checked
                AdminEditForm.ShowDialog()
                Get_Setting_Single(0)
                AdList.Focus()
            Else
                MessageBox("کاربر گرامی شما قادر به ویرایش اطلاعات مدیران نمی باشید.", MsgBoxStyle.OKOnly, "بخش مدیریت")
            End If
        Else
            MessageBox("برای ویرایش اطلاعات مدیران لطفا ابتدا مدیر مورد نطر را انتخاب کنید.", MsgBoxStyle.OKOnly, "بخش مدیریت")
        End If
    End Sub

    Private Sub BMDeleteB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BMDeleteB.Click, BMTDeleteMenu.Click
        If AdList.SelectedItems.Count > 0 Then
            If AdList.SelectedItems(0).SubItems(1).Text = True Then MessageBox("شناسه کاربری مدیر کل قابل حذف نیست.", MsgBoxStyle.OKOnly, "بخش مدیریت") : Exit Sub
            If IsGod.Checked = True Then
                If MessageBox("آیا می خواهید مدیر مورد نظر را حذف کنید؟ ", MsgBoxStyle.YesNo, "بخش مدیریت") = True Then
                    Try
                        DBConn = New DBConnection
                        DBConn.connectMe("Delete From Administrator WHERE ID = " & AdList.SelectedItems(0).SubItems(0).Text & ";")
                        Try
                            DBConn.OLEComm.Connection = DBConn.OLEConn
                            DBConn.OLEComm.ExecuteNonQuery()
                            DBConn.OLEConn.Close()
                            Try
                                DBConn.OLEConn.Close()
                            Catch err As System.Exception
                                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                            End Try
                        Catch err As System.Exception
                            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                        End Try
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                    End Try
                    Get_Setting(0)
                End If
            Else
                MessageBox("کاربر گرامی شما قادر به حذف مدیر نمی باشید.", MsgBoxStyle.OKOnly, "بخش مدیریت")
            End If
        Else
            MessageBox("برای حذف مدیر لطفا ابتدا مدیر مورد نطر را انتخاب کنید.", MsgBoxStyle.OKOnly, "بخش مدیریت")
        End If
    End Sub

    Private Sub ReList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReList.DoubleClick
        If ReList.SelectedItems.Count > 0 Then
            Dim ViewFormRe As New ViewF
            ViewFormRe.SHParvandeNum.Text = ReList.SelectedItems(0).SubItems(4).Text
            ViewFormRe.IsArchive.Checked = True
            ViewFormRe.ShowDialog()
        End If
    End Sub

    Private Sub BMTMenu_Select(ByVal sender As Object, ByVal e As System.EventArgs) Handles BMTMenu.Select
        If AdList.SelectedItems.Count > 0 Then
            BMTEditMenu.Enabled = True
            BMTDeleteMenu.Enabled = True
        Else
            BMTEditMenu.Enabled = False
            BMTDeleteMenu.Enabled = False
        End If
    End Sub

    Private Sub AboutMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutMenu.Click
        If TabC(9) = False Then Tab_Click(DBT, e)
    End Sub

    Private Sub BMTOMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BMTOMenu.Click
        If TabC(0) = False Then Tab_Click(BMT, e)
    End Sub

    Private Sub BPGTMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPGTMenu.Click
        If TabC(3) = False Then Tab_Click(BPGT, e)
    End Sub

    Private Sub SaveB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveB.Click
        SetValue("HKEY_LOCAL_MACHINE", "SOFTWARE\Money Security\Accountant Edition Gold\Backup", "BackupPath", BackupFAO.Text)
        SetValue("HKEY_LOCAL_MACHINE", "SOFTWARE\Money Security\Accountant Edition Gold\Backup", "AutoBackup", AutoBackup.CheckState)
        SaveB.Enabled = False
    End Sub

    Private Sub Main_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If MessageBox("آیا می خواهید از برنامه خارج شوید؟", MsgBoxStyle.YesNoCancel, "خروج") = False Then e.Cancel = True : Exit Sub
        Me.Hide()
        Dim BackupPath As String
        Dim OldBackupPath1 As String
        Dim OldBackupPath2 As String
        Dim BackupName1 As String
        Dim BackupName2 As String
        Try
            If GetValue("HKEY_LOCAL_MACHINE", "SOFTWARE\Money Security\Accountant Edition Gold\Backup", "AutoBackup") = "1" Then
                Try
                    BackupPath = GetValue("HKEY_LOCAL_MACHINE", "SOFTWARE\Money Security\Accountant Edition Gold\Backup", "BackupPath")
                Catch err As System.Exception
                    SetValue("HKEY_LOCAL_MACHINE", "SOFTWARE\Money Security\Accountant Edition Gold\Backup", "BackupPath", "")
                End Try
                Try
                    OldBackupPath1 = GetValue("HKEY_LOCAL_MACHINE", "SOFTWARE\Money Security\Accountant Edition Gold\Backup", "MoneySecLastBackup")
                    OldBackupPath2 = GetValue("HKEY_LOCAL_MACHINE", "SOFTWARE\Money Security\Accountant Edition Gold\Backup", "MoneySecResidLastBackup")
                Catch err As System.Exception
                    SetValue("HKEY_LOCAL_MACHINE", "SOFTWARE\Money Security\Accountant Edition Gold\Backup", "MoneySecLastBackup", "")
                    SetValue("HKEY_LOCAL_MACHINE", "SOFTWARE\Money Security\Accountant Edition Gold\Backup", "MoneySecResidLastBackup", "")
                End Try
                Try
                    Kill(OldBackupPath1)
                    Kill(OldBackupPath2)
                Catch err As System.Exception

                End Try
                BackupName1 = "MoneySec.DataBase.Backup " & Microsoft.VisualBasic.Left(Shamsi, 2) & "-" & Mid(Shamsi, 4, 2) & "-" & Microsoft.VisualBasic.Right(Shamsi, 2) & " " & TimeOfDay.Hour & "-" & TimeOfDay.Minute & ".bum"
                BackupName2 = "MoneySec.DataBase.Resid.Backup " & Microsoft.VisualBasic.Left(Shamsi, 2) & "-" & Mid(Shamsi, 4, 2) & "-" & Microsoft.VisualBasic.Right(Shamsi, 2) & " " & TimeOfDay.Hour & "-" & TimeOfDay.Minute & ".bum"
                FileCopy(App_Path() & "MoneySec.DataBase.dll", BackupPath & BackupName1)
                FileCopy(App_Path() & "Resid\MoneySec.Resid.DataBase.dll", BackupPath & BackupName2)
                SetValue("HKEY_LOCAL_MACHINE", "SOFTWARE\Money Security\Accountant Edition Gold\Backup", "MoneySecLastBackup", BackupPath & BackupName1)
                SetValue("HKEY_LOCAL_MACHINE", "SOFTWARE\Money Security\Accountant Edition Gold\Backup", "MoneySecResidLastBackup", BackupPath & BackupName2)
            End If
        Catch err As System.Exception
            SetValue("HKEY_LOCAL_MACHINE", "SOFTWARE\Money Security\Accountant Edition Gold\Backup", "AutoBackup", "0")
        End Try
    End Sub

    Private Sub BackupB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupB.Click, BackupConMenu.Click
        If Browse.ShowDialog = DialogResult.OK Then
            Dim BackupPath As String
            Dim BackupName1 As String
            Dim BackupName2 As String
            If Microsoft.VisualBasic.Right(Browse.SelectedPath, 1) = "\" Or Microsoft.VisualBasic.Right(Browse.SelectedPath, 1) = "/" Then
                BackupPath = Browse.SelectedPath
            Else
                BackupPath = Browse.SelectedPath & "\"
            End If
            BackupName1 = "MoneySec.DataBase.Backup " & Microsoft.VisualBasic.Left(Shamsi, 2) & "-" & Mid(Shamsi, 4, 2) & "-" & Microsoft.VisualBasic.Right(Shamsi, 2) & " " & TimeOfDay.Hour & "-" & TimeOfDay.Minute & ".bum"
            BackupName2 = "MoneySec.DataBase.Resid.Backup " & Microsoft.VisualBasic.Left(Shamsi, 2) & "-" & Mid(Shamsi, 4, 2) & "-" & Microsoft.VisualBasic.Right(Shamsi, 2) & " " & TimeOfDay.Hour & "-" & TimeOfDay.Minute & ".bum"
            FileCopy(App_Path() & "MoneySec.DataBase.dll", BackupPath & BackupName1)
            FileCopy(App_Path() & "Resid\MoneySec.Resid.DataBase.dll", BackupPath & BackupName2)
        End If
    End Sub

    Private Sub LogoutMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutMenu.Click
        Dim LoginForm As New LoginF
        LoginForm.Show()
        DayListF.DefInstance.Close()
        DirListF.DefInstance.Close()
        HelpListF.DefInstance.Close()
        MoshtariListF.DefInstance.Close()
        ReportModeF.DefInstance.Close()
        ReportListF.DefInstance.Close()
        GhPrintF.DefInstance.Close()
        MVF = True
        Me.Hide()
    End Sub

    Private Sub RestoreB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoreB.Click
        If MessageBox("آیا می خواهید بانک اطلاعاتی بازیابی گردد.", MsgBoxStyle.YesNo, "بخش پشتیبان گیری") = True Then
            If Browse.ShowDialog = DialogResult.OK Then
                Dim RestorePath As String
                If Microsoft.VisualBasic.Right(Browse.SelectedPath, 1) = "\" Or Microsoft.VisualBasic.Right(Browse.SelectedPath, 1) = "/" Then
                    RestorePath = Browse.SelectedPath
                Else
                    RestorePath = Browse.SelectedPath & "\"
                End If
                FileFRestore.Path = RestorePath
                If FileFRestore.Items.Count <> 0 Then
                    For I As Integer = 0 To FileFRestore.Items.Count - 1
                        Select Case Mid(FileFRestore.Items(I), 19, 1)
                            Case "B"
                                Try
                                    FileCopy(RestorePath & FileFRestore.Items(I), App_Path() & "MoneySec.DataBase.dll")
                                Catch err As System.Exception

                                End Try
                            Case "R"
                                Try
                                    FileCopy(RestorePath & FileFRestore.Items(I), App_Path() & "Resid\MoneySec.Resid.DataBase.dll")
                                Catch err As System.Exception

                                End Try
                        End Select
                    Next
                Else
                    MessageBox("هیچ فایلی پیدا نشد.", MsgBoxStyle.OKOnly, "بخش پشتیبان گیری")
                End If
            End If
        End If
    End Sub

    Private Sub Company_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Company.MouseLeave
        Company.ForeColor = System.Drawing.ColorTranslator.FromOle(RGB(0, 45, 8))
    End Sub

    Private Sub Company_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Company.MouseMove
        Company.ForeColor = System.Drawing.ColorTranslator.FromOle(RGB(0, 147, 28))
    End Sub

    Private Sub Support_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Support.MouseLeave
        Support.ForeColor = System.Drawing.ColorTranslator.FromOle(RGB(0, 47, 64))
    End Sub

    Private Sub Support_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Support.MouseMove
        Support.ForeColor = System.Drawing.ColorTranslator.FromOle(RGB(0, 101, 139))
    End Sub

    Private Sub WriteB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WriteB.Click
        Dim DIAddForm As New DIAddF
        DIAddForm.AdminID.Text = OnAdminID.Text
        DIAddForm.ShowDialog()
        Get_Setting(5)
    End Sub

    Private Sub DIList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DIList.DoubleClick
        If DIList.SelectedItems.Count > 0 Then
            Dim DIViewForm As New DIViewF
            DIViewForm.ID.Text = DIList.SelectedItems(0).SubItems(0).Text
            DIViewForm.ShowDialog()
        End If
    End Sub

    Private Sub DIDeleteB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DIDeleteB.Click
        If DIList.SelectedItems.Count > 0 Then
            Try
                DBConn = New DBConnection
                DBConn.connectMe("Delete From NoteBook WHERE ID = " & DIList.SelectedItems(0).SubItems(0).Text & ";")
                Try
                    DBConn.OLEComm.Connection = DBConn.OLEConn
                    DBConn.OLEComm.ExecuteNonQuery()
                    DBConn.OLEConn.Close()
                    Try
                        DBConn.OLEConn.Close()
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                End Try
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
            End Try
            Get_Setting(5)
        Else
            MessageBox("برای حذف یاداشت لطفا ابتدا یاداشت مورد نطر را انتخاب کنید.", MsgBoxStyle.OKOnly, "دفتر یاداشت")
        End If
    End Sub

    Private Sub Get_Alarm_Setting()
        AlarmList.Items.Clear()
        Try
            DBConn = New DBConnection
            DBConn.connectMe("SELECT * FROM NoteBook WHERE Alarm=true and AlarmDate='" & Shamsi() & "';")
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                Do While d.Read
                    'If d("AlarmDate".ToString) = Shamsi() Then
                    Item = AlarmList.Items.Add(d("ID".ToString))
                    With Item
                        .SubItems.Add(d("AlarmTime".ToString))
                        .SubItems.Add(d("AlarmDate".ToString))
                    End With
                    'End If
                Loop
                Try
                    DBConn.OLEConn.Close()
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            End Try
        Catch err As System.Exception
            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
        End Try
    End Sub

    Private Sub GetAlarmList_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetAlarmList.Tick
        Get_Alarm_Setting()
    End Sub

    Private Sub SetAlarm_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetAlarm.Tick
        For I As Integer = 0 To AlarmList.Items.Count - 1
            If AlarmList.Items(I).SubItems(1).Text = MeTime() Then
                Dim DIViewForm As New DIViewF
                DIViewForm.ID.Text = AlarmList.Items(I).SubItems(0).Text
                DIViewForm.TopMost = True
                DIViewForm.DeleteB.Visible = True
                DIViewForm.NextB.Visible = True
                DIViewForm.Show()
                Play_Sound("Message")
            End If
        Next
    End Sub

    Private Sub UnlockMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnlockMenu.Click
        UnLock = True
        MoveSysTryMenu_Click(MoveSysTryMenu, e)
    End Sub

    Private Sub DayListMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DayListMenu.Click
        DayListF.DefInstance.Show()
    End Sub

    Private Sub MPrintMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MPrintMenu.Click, LMTPrintMenu.Click
        If MList.SelectedItems.Count > 0 Then
            Dim MR(9) As String
            Dim TarikhePa As String
            Try
                DBConn = New DBConnection
                DBConn.connectMe("SELECT * FROM MoshtariList WHERE SHParvandeNum=" & MList.SelectedItems(0).SubItems(7).Text & ";")
                Try
                    DBConn.OLEComm.Connection = DBConn.OLEConn
                    Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                    Do While d.Read
                        MR(0) = d("SHParvandeNum".ToString)
                        MR(1) = d("MoajerFN".ToString) & " " & d("MoajerLN".ToString)
                        MR(2) = d("MostajerFN".ToString) & " " & d("MostajerLN".ToString)
                        MR(3) = d("MablagheGh".ToString)
                        MR(4) = d("AghsatCount".ToString)
                        MR(5) = d("NTashilat".ToString)
                        MR(6) = d("JTakhir".ToString)
                        MR(7) = d("TarikheGha".ToString)
                        MR(8) = d("CGGold".ToString)
                        MR(9) = d("Tell".ToString)
                    Loop
                    Try
                        DBConn.OLEConn.Close()
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            End Try
            For I As Integer = 1 To MR(4)
                Select Case ((Mid(MR(7), 4, 2) + I) Mod 12)
                    Case 0
                        TarikhePa = ((Microsoft.VisualBasic.Left(MR(7), 2) + ((Mid(MR(7), 4, 2)) + I) \ 12) - 1) & "/12" & Microsoft.VisualBasic.Right(MR(7), 3)
                    Case 1, 2, 3, 4, 5, 6, 7, 8, 9
                        TarikhePa = (Microsoft.VisualBasic.Left(MR(7), 2) + ((Mid(MR(7), 4, 2)) + I) \ 12) & "/0" & ((Mid(MR(7), 4, 2) + I) Mod 12) & Microsoft.VisualBasic.Right(MR(7), 3)
                    Case 10, 11
                        TarikhePa = (Microsoft.VisualBasic.Left(MR(7), 2) + ((Mid(MR(7), 4, 2)) + I) \ 12) & "/" & ((Mid(MR(7), 4, 2) + I) Mod 12) & Microsoft.VisualBasic.Right(MR(7), 3)
                End Select
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("Insert Into MReport (SHParvandeNum,Moajer,Mostajer,MablagheGh,TarikhePa,AghsatCount,Ghest,NTashilat,JTakhir,CGGold,Tell) Values ('" & MR(0) & "', '" & MR(1) & "', '" & MR(2) & "', '" & MR(3) & "', '" & TarikhePa & "', '" & MR(4) & "', '" & I & "', '" & MR(5) & "', '" & MR(6) & "', '" & MR(8) & "', '" & MR(9) & "');")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        DBConn.OLEComm.ExecuteNonQuery()
                        DBConn.OLEConn.Close()
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    End Try
                    Try
                        DBConn.OLEConn.Close()
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
            Next
            If MessageBox("آیا می خواهید دفترچه اقساط مشتری را چاپ کنید؟", MsgBoxStyle.SystemModal, "چاپ دفترچه اقساط") = True Then
                Dim PrintForm As New PrintF
                PrintForm.WP.Text = 1
                PrintForm.ShowDialog()
            End If
            Try
                DBConn = New DBConnection
                DBConn.connectMe("Delete From MReport;")
                Try
                    DBConn.OLEComm.Connection = DBConn.OLEConn
                    DBConn.OLEComm.ExecuteNonQuery()
                    DBConn.OLEConn.Close()
                    Try
                        DBConn.OLEConn.Close()
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                End Try
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
            End Try
        Else
            MessageBox("برای چاپ دفترچه اقساط مشتری لطفا ابتدا مشتری مورد نطر را انتخاب کنید.", MsgBoxStyle.OKOnly, "لیست مشتریان")
        End If
    End Sub

    Private Sub DirListMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirListMenu.Click
        DirListF.DefInstance.Show()
    End Sub

    Private Sub DITMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DITMenu.Click
        If TabC(5) = False Then Tab_Click(DIT, e)
    End Sub

    Private Sub CalcMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcMenu.Click
        On Error GoTo get_error
        Shell(App_Path() & "Calculator.exe", AppWinStyle.NormalFocus)
        Exit Sub
get_error:
        MsgBox("ماشین حساب پیدا نشد", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "ماشین حساب") : Exit Sub
    End Sub

    Private Sub HelpListMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpListMenu.Click
        HelpListF.DefInstance.Show()
    End Sub

    Private Sub Main_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible = True Or MVF = True Then
            IconTry.Visible = False
        End If
    End Sub

    Private Sub DateCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateCheck.CheckedChanged
        If DateCheck.Checked = True Then
            DateList.Enabled = True
            DayList.Enabled = False
            FTarikh.Enabled = False
            ChangeFTB.Enabled = False
            TTarikh.Enabled = False
            ChangeTTB.Enabled = False
            ViewB.Enabled = False
            ReList.Items.Clear()
            If DateList.Items.Count > 0 Then DateList.SelectedIndex = 0
        End If
    End Sub

    Private Sub DayList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DayList.SelectedIndexChanged
        ReList.Items.Clear()
        If DayList.Text = "" Then Exit Sub
        Try
            DBConn = New DBConnection
            DBConn.connectMe("SELECT * FROM MoshtariList WHERE IsBlackCancel=False ORDER BY SHParvandeNum;")
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                Do While d.Read
                    If Int(DayList.Text) = Int(Microsoft.VisualBasic.Right(d("TarikheGha".ToString), 2)) Then
                        Item = ReList.Items.Add(d("ID".ToString))
                        With Item
                            .SubItems.Add(d("Tell".ToString))
                            .SubItems.Add(d("MostajerFN".ToString) & " " & d("MostajerLN".ToString))
                            .SubItems.Add(d("MoajerFN".ToString) & " " & d("MoajerLN".ToString))
                            .SubItems.Add(d("SHParvandeNum".ToString))
                        End With
                    End If
                Loop
                Try
                    DBConn.OLEConn.Close()
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            End Try
        Catch err As System.Exception
            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
        End Try
    End Sub

    Private Sub RPrintB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RPrintB.Click
        If DateCheck.Checked = True Then
            If DateList.Text = "" Then MessageBox("براي چاپ ليست روزانه مشتريان لطفا ابتدا تاريخ مورد نطر را انتخاب کنيد.", MsgBoxStyle.OKOnly, "بخش گزارس دهی") : Exit Sub
        ElseIf DayCheck.Checked = True Then
            If DayList.Text = "" Then MessageBox("براي چاپ ليست روزانه مشتريان لطفا ابتدا روز مورد نطر را انتخاب کنيد.", MsgBoxStyle.OKOnly, "بخش گزارس دهی") : Exit Sub
        Else
            If Dirkard(FTarikh.Text, TTarikh.Text) = True Then MsgBox("خطا در مشخص کردن محدوده تاریخ", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "بخش گزارس دهی") : Exit Sub
        End If
        If ReList.Items.Count = 0 Then MessageBox("لیست روزانه مشتریان خالی است.", MsgBoxStyle.OKOnly, "بخش گزارس دهی") : Exit Sub
        Dim MBR(6) As String
        For I As Integer = 0 To ReList.Items.Count - 1
            Try
                DBConn = New DBConnection
                DBConn.connectMe("SELECT * FROM MoshtariList WHERE ID=" & ReList.Items(I).SubItems(0).Text & ";")
                Try
                    DBConn.OLEComm.Connection = DBConn.OLEConn
                    Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                    Do While d.Read
                        MBR(0) = d("SHParvandeNum".ToString)
                        MBR(1) = d("MostajerFN".ToString) & " " & d("MostajerLN".ToString)
                        MBR(2) = d("MoajerFN".ToString) & " " & d("MoajerLN".ToString)
                        MBR(3) = d("Tell".ToString)
                        MBR(4) = d("TarikheGha".ToString)
                        MBR(5) = d("AghsatCount".ToString)
                        MBR(6) = d("MablagheGh".ToString)
                    Loop
                    Try
                        DBConn.OLEConn.Close()
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            End Try
            Try
                DBConn = New DBConnection
                If DateCheck.Checked = True Then
                    DBConn.connectMe("Insert Into MDaReport (SHParvandeNum,Mostajer,Moajer,Tell,TarikheGha,AghsatCount,MablagheGh,MT) Values ('" & MBR(0) & "', '" & MBR(1) & "', '" & MBR(2) & "', '" & MBR(3) & "', '" & MBR(4) & "', '" & MBR(5) & "', '" & MBR(6) & "', '" & DateList.Text & "');")
                ElseIf DayCheck.Checked = True Then
                    DBConn.connectMe("Insert Into MDaReport (SHParvandeNum,Mostajer,Moajer,Tell,TarikheGha,AghsatCount,MablagheGh,MDay) Values ('" & MBR(0) & "', '" & MBR(1) & "', '" & MBR(2) & "', '" & MBR(3) & "', '" & MBR(4) & "', '" & MBR(5) & "', '" & MBR(6) & "', '" & DayList.Text & "');")
                Else
                    DBConn.connectMe("Insert Into MDaReport (SHParvandeNum,Mostajer,Moajer,Tell,TarikheGha,AghsatCount,MablagheGh,MT) Values ('" & MBR(0) & "', '" & MBR(1) & "', '" & MBR(2) & "', '" & MBR(3) & "', '" & MBR(4) & "', '" & MBR(5) & "', '" & MBR(6) & "', '" & FTarikh.Text & " تا تاریخ " & TTarikh.Text & "');")
                End If
                Try
                    DBConn.OLEComm.Connection = DBConn.OLEConn
                    DBConn.OLEComm.ExecuteNonQuery()
                    DBConn.OLEConn.Close()
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
                Try
                    DBConn.OLEConn.Close()
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            End Try
        Next
        If DateCheck.Checked = True Then
            If MessageBox("آیا می خواهید لیست روزانه مشتریان مربوط به تاریخ " & DateList.Text & " را چاپ کنید؟", MsgBoxStyle.SystemModal, "چاپ لیست گزارش مشتریان") = True Then
                Dim PrintForm As New PrintF
                PrintForm.WP.Text = 7
                PrintForm.ShowDialog()
            End If
        ElseIf DayCheck.Checked = True Then
            If MessageBox("آیا می خواهید لیست روزانه مشتریان مربوط به روز " & DayList.Text & " را چاپ کنید؟", MsgBoxStyle.SystemModal, "چاپ لیست گزارش مشتریان") = True Then
                Dim PrintForm As New PrintF
                PrintForm.WP.Text = 5
                PrintForm.ShowDialog()
            End If
        Else
            If MessageBox("آیا می خواهید لیست روزانه مشتریان مربوط به تاریخ " & FTarikh.Text & " تا تاریخ " & TTarikh.Text & " را چاپ کنید؟", MsgBoxStyle.SystemModal, "چاپ لیست گزارش مشتریان") = True Then
                Dim PrintForm As New PrintF
                PrintForm.WP.Text = 17
                PrintForm.ShowDialog()
            End If
        End If
        Try
            DBConn = New DBConnection
            DBConn.connectMe("Delete From MDaReport;")
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                DBConn.OLEComm.ExecuteNonQuery()
                DBConn.OLEConn.Close()
                Try
                    DBConn.OLEConn.Close()
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                End Try
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
            End Try
        Catch err As System.Exception
            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
        End Try
    End Sub

    Private Sub VHTOMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VHTOMenu.Click
        If TabC(6) = False Then Tab_Click(VHT, e)
    End Sub

    Private Sub BHTOMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BHTOMenu.Click
        If TabC(7) = False Then Tab_Click(BHT, e)
    End Sub

    Private Sub HVTMenu_Select(ByVal sender As Object, ByVal e As System.EventArgs) Handles VHTMenu.Select
        If HVList.SelectedItems.Count > 0 Then
            VHEditMenu.Enabled = True
            VHDeleteMenu.Enabled = True
            VHPrintMenu.Enabled = True
        Else
            VHEditMenu.Enabled = False
            VHDeleteMenu.Enabled = False
            VHPrintMenu.Enabled = False
        End If
    End Sub

    Private Sub HBTMenu_Select(ByVal sender As Object, ByVal e As System.EventArgs) Handles BHTMenu.Select
        If HBList.SelectedItems.Count > 0 Then
            BHEditMenu.Enabled = True
            BHDeleteMenu.Enabled = True
            BHPrintMenu.Enabled = True
        Else
            BHEditMenu.Enabled = False
            BHDeleteMenu.Enabled = False
            BHPrintMenu.Enabled = False
        End If
    End Sub

    Private Sub DateBGDTMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateBGDTMenu.Click
        If TabC(4) = False Then Tab_Click(BGDT, e)
        DateCheck.Checked = True
    End Sub

    Private Sub DayBGDTMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DayBGDTMenu.Click
        If TabC(4) = False Then Tab_Click(BGDT, e)
        DayCheck.Checked = True
    End Sub

    Private Sub AdList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AdList.Click
        If AdList.SelectedItems.Count <> 0 Then
            If AdList.SelectedItems(0).SubItems(2).Text = True Then ActiveUnB.Text = "غیر فعال" Else ActiveUnB.Text = "فعال"
        End If
    End Sub

    Private Sub ActiveUnB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActiveUnB.Click
        If AdList.SelectedItems.Count > 0 Then
            If AdList.SelectedItems(0).SubItems(1).Text = True Then MessageBox("شناسه کاربری مدیر کل غیر فعال نمی گردد.", MsgBoxStyle.OKOnly, "بخش مدیریت") : Exit Sub
            If IsGod.Checked = True Then
                If MessageBox("آیا می خواهید مدیر مورد نظر را " & ActiveUnB.Text & " کنید؟", MsgBoxStyle.YesNo, "بخش مدیریت") = True Then
                    Dim ActiveCh As Boolean = False
                    If ActiveUnB.Text = "فعال" Then ActiveCh = True
                    Try
                        DBConn = New DBConnection
                        DBConn.connectMe("Update Administrator SET Active=" & ActiveCh & " WHERE ID=" & AdList.SelectedItems(0).SubItems(0).Text & ";")
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        DBConn.OLEComm.ExecuteNonQuery()
                        DBConn.OLEConn.Close()
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    End Try
                    Get_Setting_Single(0)
                    AdList.Focus()
                End If
            Else
                MessageBox("کاربر گرامی شما قادر به تغییر فعال سازی مدیر نمی باشید.", MsgBoxStyle.OKOnly, "بخش مدیریت")
            End If
        Else
            MessageBox("برای تغییر فعال سازی مدیر لطفا ابتدا مدیر مورد نطر را انتخاب کنید.", MsgBoxStyle.OKOnly, "بخش مدیریت")
        End If
    End Sub

    Private Sub MoshtariListMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoshtariListMenu.Click
        MoshtariListF.DefInstance.Show()
    End Sub

    Private Sub VHAddB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VHAddB.Click
        Dim AddHVForm As New HVAddF
        AddHVForm.ShowDialog()
        Get_Setting(6)
    End Sub

    Private Sub VHEditB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VHEditB.Click
        If HVList.SelectedItems.Count > 0 Then
            Dim HVEditForm As New HVEditF
            HVEditForm.ID.Text = HVList.SelectedItems(0).SubItems(0).Text
            HVEditForm.ShowDialog()
            Get_Setting_Single(6)
            HVList.Focus()
        Else
            MessageBox("برای ویرایش وصول لطفا ابتدا وصول مورد نطر را انتخاب کنید.", MsgBoxStyle.OKOnly, "حسابداری - وصول")
        End If
    End Sub

    Private Sub VHDeleteB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VHDeleteB.Click
        If HVList.SelectedItems.Count > 0 Then
            If MessageBox("آیا می خواهید وصول مورد نظر را حذف کنید؟ ", MsgBoxStyle.YesNo, "حسابداری - وصول") = True Then
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("Delete From HVList WHERE ID = " & HVList.SelectedItems(0).SubItems(0).Text & ";")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        DBConn.OLEComm.ExecuteNonQuery()
                        DBConn.OLEConn.Close()
                        Try
                            DBConn.OLEConn.Close()
                        Catch err As System.Exception
                            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                        End Try
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                End Try
                Get_Setting(6)
            End If
        Else
            MessageBox("برای حذف وصول لطفا ابتدا وصول مورد نطر را انتخاب کنید.", MsgBoxStyle.OKOnly, "حسابداری - وصول")
        End If
    End Sub

    Private Sub BHAddB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BHAddB.Click
        Dim AddHBForm As New HBAddF
        AddHBForm.ShowDialog()
        Get_Setting(7)
    End Sub

    Private Sub BHEditB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BHEditB.Click
        If HBList.SelectedItems.Count > 0 Then
            Dim HBEditForm As New HBEditF
            HBEditForm.ID.Text = HBList.SelectedItems(0).SubItems(0).Text
            HBEditForm.ShowDialog()
            Get_Setting_Single(7)
            HBList.Focus()
        Else
            MessageBox("برای ویرایش برداشت لطفا ابتدا برداشت مورد نطر را انتخاب کنید.", MsgBoxStyle.OKOnly, "حسابداری - برداشت")
        End If
    End Sub

    Private Sub BHDeleteB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BHDeleteB.Click
        If HBList.SelectedItems.Count > 0 Then
            If MessageBox("آیا می خواهید برداشت مورد نظر را حذف کنید؟ ", MsgBoxStyle.YesNo, "حسابداری - برداشت") = True Then
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("Delete From HBList WHERE ID = " & HBList.SelectedItems(0).SubItems(0).Text & ";")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        DBConn.OLEComm.ExecuteNonQuery()
                        DBConn.OLEConn.Close()
                        Try
                            DBConn.OLEConn.Close()
                        Catch err As System.Exception
                            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                        End Try
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                End Try
                Get_Setting(7)
            End If
        Else
            MessageBox("برای حذف برداشت لطفا ابتدا برداشت مورد نطر را انتخاب کنید.", MsgBoxStyle.OKOnly, "حسابداری - برداشت")
        End If
    End Sub

    Private Sub SGAddB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SGAddB.Click, SGTAddMenu.Click
        Dim SGAddForm As New SGAddF
        SGAddForm.ShowDialog()
        Get_Setting(8)
    End Sub

    Private Sub SGList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles SGList.DoubleClick, SGTViewMenu.Click
        If SGList.SelectedItems.Count <> 0 Then
            Dim GhPrintForm As New GhPrintF
            GhPrintFormSG = SGList.SelectedItems(0).SubItems(3).Text
            GhPrintFormGHNum = SGList.SelectedItems(0).SubItems(4).Text
            GhPrintForm.DefInstance.Show()
        End If
    End Sub

    Private Sub SGDeleteB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SGDeleteB.Click, SGTDeleteMenu.Click
        If SGList.SelectedItems.Count <> 0 Then
            If MessageBox("آیا می خواهید سرمایه گذار مورد نظر را حذف کنید؟ ", MsgBoxStyle.YesNo, "بخش سرمایه گذاری") = True Then
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("Delete From SGozari WHERE ID = " & SGList.SelectedItems(0).SubItems(0).Text & ";")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        DBConn.OLEComm.ExecuteNonQuery()
                        DBConn.OLEConn.Close()
                        Try
                            DBConn.OLEConn.Close()
                        Catch err As System.Exception
                            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                        End Try
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                End Try
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("Delete From AnySGozari WHERE GharardadNum='" & SGList.SelectedItems(0).SubItems(4).Text & "';")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        DBConn.OLEComm.ExecuteNonQuery()
                        DBConn.OLEConn.Close()
                        Try
                            DBConn.OLEConn.Close()
                        Catch err As System.Exception
                            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                        End Try
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                End Try
                Get_Setting(8)
            End If
        Else
            MessageBox("برای حذف سرمایه گذار لطفا ابتدا سرمایه گذار مورد نطر را انتخاب کنید.", MsgBoxStyle.OKOnly, "بخش سرمایه گذاری")
        End If
    End Sub

    Private Sub SGEditB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SGEditB.Click, SGTEditMenu.Click
        If SGList.SelectedItems.Count <> 0 Then
            Dim SGEditForm As New SGEditF
            SGEditForm.ID.Text = SGList.SelectedItems(0).SubItems(0).Text
            SGEditForm.ShowDialog()
            Get_Setting_Single(8)
            SGList.Focus()
        Else
            MessageBox("برای ویرایش سرمایه گذار لطفا ابتدا سرمایه گذار مورد نطر را انتخاب کنید.", MsgBoxStyle.OKOnly, "بخش سرمایه گذاری")
        End If
    End Sub

    Private Sub MSBPrintMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSBPrintMenu.Click
        If MList.SelectedItems.Count > 0 Then
            Dim MR(14) As String
            Try
                DBConn = New DBConnection
                DBConn.connectMe("SELECT * FROM MoshtariList WHERE SHParvandeNum=" & MList.SelectedItems(0).SubItems(7).Text & ";")
                Try
                    DBConn.OLEComm.Connection = DBConn.OLEConn
                    Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                    Do While d.Read
                        MR(0) = d("SHParvandeNum".ToString)
                        MR(1) = d("NTashilat".ToString)
                        MR(2) = d("AghsatCount".ToString)
                        MR(3) = d("MablagheGh".ToString)
                        MR(4) = d("MablagheVKH".ToString)
                        MR(5) = d("MoajerFN".ToString) & " " & d("MoajerLN".ToString)
                        MR(6) = d("MostajerFN".ToString) & " " & d("MostajerLN".ToString)
                        MR(7) = d("CGGold".ToString)
                        MR(8) = d("TarikheGha".ToString)
                        MR(9) = d("TarikheFa".ToString)
                        MR(10) = d("Adrress".ToString)
                        MR(11) = d("Tell".ToString)
                        MR(12) = d("Office".ToString)
                        MR(13) = d("Mobile".ToString)
                        MR(14) = d("Tozihat".ToString)
                    Loop
                    Try
                        DBConn.OLEConn.Close()
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            End Try
            Try
                DBConn = New DBConnection
                DBConn.connectMe("Insert Into SBReport (SHParvandeNum,NTashilat,AghsatCount,MablagheGh,MablagheVKH,Moajer,Mostajer,CGGold,TarikheGha,TarikheFa,Adrress,Tell,Office,Mobile,Tozihat) Values ('" & MR(0) & "', '" & MR(1) & "', '" & MR(2) & "', '" & MR(3) & "', '" & MR(4) & "', '" & MR(5) & "', '" & MR(6) & "', '" & MR(7) & "', '" & MR(8) & "', '" & MR(9) & "', '" & MR(10) & "', '" & MR(11) & "', '" & MR(12) & "', '" & MR(13) & "', '" & MR(14) & "');")
                Try
                    DBConn.OLEComm.Connection = DBConn.OLEConn
                    DBConn.OLEComm.ExecuteNonQuery()
                    DBConn.OLEConn.Close()
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
                Try
                    DBConn.OLEConn.Close()
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            End Try
            If MessageBox("آیا می خواهید سربرگ پرونده مشتری را چاپ کنید؟", MsgBoxStyle.SystemModal, "چاپ سربرگ پرونده") = True Then
                Dim PrintForm As New PrintF
                PrintForm.WP.Text = 15
                PrintForm.ShowDialog()
            End If
            Try
                DBConn = New DBConnection
                DBConn.connectMe("Delete From SBReport;")
                Try
                    DBConn.OLEComm.Connection = DBConn.OLEConn
                    DBConn.OLEComm.ExecuteNonQuery()
                    DBConn.OLEConn.Close()
                    Try
                        DBConn.OLEConn.Close()
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                End Try
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
            End Try
        Else
            MessageBox("برای چاپ سربرگ پرونده مشتری لطفا ابتدا مشتری مورد نطر را انتخاب کنید.", MsgBoxStyle.OKOnly, "لیست مشتریان")
        End If
    End Sub

    Private Sub SGTOMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SGTOMenu.Click
        If TabC(9) = False Then Tab_Click(BSGT, e)
    End Sub

    Private Sub SGTMenu_Select(ByVal sender As Object, ByVal e As System.EventArgs) Handles SGTMenu.Select
        If SGList.SelectedItems.Count > 0 Then
            SGTViewMenu.Enabled = True
            SGTEditMenu.Enabled = True
            SGTDeleteMenu.Enabled = True
        Else
            SGTViewMenu.Enabled = False
            SGTEditMenu.Enabled = False
            SGTDeleteMenu.Enabled = False
        End If
    End Sub

    Private Sub Get_Setting_Single(ByVal Index As Integer)
        Select Case Index
            Case 0
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("SELECT * FROM Administrator WHERE ID=" & AdList.SelectedItems(0).SubItems(0).Text & ";")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                        Do While d.Read
                            AdList.SelectedItems(0).SubItems(1).Text = d("God".ToString)
                            AdList.SelectedItems(0).SubItems(2).Text = d("Active".ToString)
                            AdList.SelectedItems(0).SubItems(3).Text = d("AdminAcc".ToString)
                            AdList.SelectedItems(0).SubItems(4).Text = d("FullName".ToString)
                            AdList.SelectedItems(0).SubItems(5).Text = d("AdminID".ToString)
                        Loop
                        Try
                            DBConn.OLEConn.Close()
                        Catch err As System.Exception
                            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                        End Try
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
            Case 1
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("SELECT * FROM MoshtariList WHERE ID=" & MList.SelectedItems(0).SubItems(0).Text & ";")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                        Do While d.Read
                            If d("MPicExist".ToString) = True Then MList.SelectedItems(0).SubItems(1).Text = "موجود" Else MList.SelectedItems(0).SubItems(1).Text = ""
                            If d("PicExist".ToString) = True Then MList.SelectedItems(0).SubItems(2).Text = "موجود" Else MList.SelectedItems(0).SubItems(2).Text = ""
                            MList.SelectedItems(0).SubItems(3).Text = d("CGGold".ToString)
                            MList.SelectedItems(0).SubItems(4).Text = d("Tell".ToString)
                            MList.SelectedItems(0).SubItems(5).Text = d("MostajerFN".ToString) & " " & d("MostajerLN".ToString)
                            MList.SelectedItems(0).SubItems(6).Text = d("MoajerFN".ToString) & " " & d("MoajerLN".ToString)
                            MList.SelectedItems(0).SubItems(7).Text = d("SHParvandeNum".ToString)
                        Loop
                        Try
                            DBConn.OLEConn.Close()
                        Catch err As System.Exception
                            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                        End Try
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
            Case 2
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("SELECT * FROM MoshtariList WHERE ID=" & AList.SelectedItems(0).SubItems(0).Text & ";")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                        Do While d.Read
                            If d("IsCancel".ToString) Then
                                AList.SelectedItems(0).BackColor = System.Drawing.Color.RosyBrown
                                'AList.SelectedItems(0).ForeColor = System.Drawing.Color.White
                            Else
                                AList.SelectedItems(0).BackColor = System.Drawing.Color.DarkGray
                                'AList.SelectedItems(0).ForeColor = System.Drawing.Color.White
                            End If
                            If d("IsBlackCancel".ToString) Then
                                AList.SelectedItems(0).BackColor = System.Drawing.Color.Black
                                AList.SelectedItems(0).ForeColor = System.Drawing.Color.White
                            End If
                        Loop
                        Try
                            DBConn.OLEConn.Close()
                        Catch err As System.Exception
                            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                        End Try
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
            Case 3
                'None
            Case 4
                'None
            Case 5
                'None
            Case 6
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("SELECT * FROM HVList WHERE ID=" & HVList.SelectedItems(0).SubItems(0).Text & ";")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                        Do While d.Read
                            HVList.SelectedItems(0).SubItems(1).Text = d("Tarikh".ToString)
                            HVList.SelectedItems(0).SubItems(2).Text = d("Mablagh".ToString)
                            HVList.SelectedItems(0).SubItems(3).Text = d("Tell".ToString)
                            HVList.SelectedItems(0).SubItems(4).Text = d("SHParvandeNum".ToString)
                            HVList.SelectedItems(0).SubItems(5).Text = d("Moajer".ToString)
                            HVList.SelectedItems(0).SubItems(6).Text = d("Mostajer".ToString)
                        Loop
                        Try
                            DBConn.OLEConn.Close()
                        Catch err As System.Exception
                            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                        End Try
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
            Case 7
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("SELECT * FROM HBList WHERE ID=" & HBList.SelectedItems(0).SubItems(0).Text & ";")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                        Do While d.Read
                            HBList.SelectedItems(0).SubItems(1).Text = d("Tarikh".ToString)
                            HBList.SelectedItems(0).SubItems(2).Text = d("Mablagh".ToString)
                            HBList.SelectedItems(0).SubItems(3).Text = d("ForSub".ToString)
                            HBList.SelectedItems(0).SubItems(4).Text = d("Tell".ToString)
                            HBList.SelectedItems(0).SubItems(5).Text = d("Pardakhter".ToString)
                        Loop
                        Try
                            DBConn.OLEConn.Close()
                        Catch err As System.Exception
                            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                        End Try
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
            Case 8
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("SELECT * FROM SGozari WHERE ID=" & SGList.SelectedItems(0).SubItems(0).Text & ";")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                        Do While d.Read
                            SGList.SelectedItems(0).SubItems(1).Text = d("SHenasnameNum".ToString)
                            SGList.SelectedItems(0).SubItems(2).Text = d("Farzand".ToString)
                            SGList.SelectedItems(0).SubItems(3).Text = d("SFName".ToString) & " " & d("SLName".ToString)
                            SGList.SelectedItems(0).SubItems(4).Text = d("GharardadNum".ToString)
                        Loop
                        Try
                            DBConn.OLEConn.Close()
                        Catch err As System.Exception
                            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                        End Try
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
            Case 9
                'None
            Case 10
                'None
        End Select
    End Sub

    Private Sub AutoBackup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoBackup.CheckedChanged
        SaveB.Enabled = True
    End Sub

    Private Sub SGSBPrintB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SGSBPrintB.Click
        If SGList.SelectedItems.Count > 0 Then
            If MessageBox("آیا می خواهید سربرگ پرونده سرمایه گذار را چاپ کنید؟", MsgBoxStyle.SystemModal, "چاپ دفترچه اقساط") = True Then
                Dim SGR(7) As String
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("SELECT * FROM SGozari WHERE GharardadNum=" & SGList.SelectedItems(0).SubItems(4).Text & ";")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                        Do While d.Read
                            SGR(0) = d("GharardadNum".ToString)
                            SGR(1) = d("SFName".ToString) & " " & d("SLName".ToString)
                            SGR(2) = d("FT".ToString)
                            SGR(3) = d("TT".ToString)
                            SGR(4) = d("Mablagh".ToString)
                            SGR(5) = d("Addrress".ToString)
                            SGR(6) = d("Tell".ToString)
                            SGR(7) = d("Tozih".ToString)
                        Loop
                        Try
                            DBConn.OLEConn.Close()
                        Catch err As System.Exception
                            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                        End Try
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("Insert Into SGSBReport (GharardadNum,Sarmaiegozar,FT,TT,Mablagh,Addrress,Tell,Tozih) Values ('" & SGR(0) & "', '" & SGR(1) & "', '" & SGR(2) & "', '" & SGR(3) & "', '" & SGR(4) & "', '" & SGR(5) & "', '" & SGR(6) & "', '" & SGR(7) & "');")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        DBConn.OLEComm.ExecuteNonQuery()
                        DBConn.OLEConn.Close()
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    End Try
                    Try
                        DBConn.OLEConn.Close()
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try

                Dim PrintForm As New PrintF
                PrintForm.WP.Text = 16
                PrintForm.ShowDialog()
                Try
                    DBConn = New DBConnection
                    DBConn.connectMe("Delete From SGSBReport;")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        DBConn.OLEComm.ExecuteNonQuery()
                        DBConn.OLEConn.Close()
                        Try
                            DBConn.OLEConn.Close()
                        Catch err As System.Exception
                            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                        End Try
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                End Try
            End If
        Else
        MessageBox("برای چاپ سربرگ پرونده سرمایه گذار لطفا ابتدا سرمایه گذار مورد نطر را انتخاب کنید.", MsgBoxStyle.OKOnly, "بخش سرمایه گذاری")
        End If
    End Sub

    Private Sub HBReportB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HBReportB.Click
        ReportModeFormViewReport = "B"
        ReportModeF.DefInstance.Show()
    End Sub

    Private Sub HVReportB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HVReportB.Click
        ReportModeFormViewReport = "V"
        ReportModeF.DefInstance.Show()
    End Sub

    Private Sub ViewB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewB.Click
        ReList.Items.Clear()
        Dim F_Tarikh As String = Microsoft.VisualBasic.Left(FTarikh.Text, 2) & Mid(FTarikh.Text, 4, 2) & Microsoft.VisualBasic.Right(FTarikh.Text, 2)
        Dim T_Tarikh As String = Microsoft.VisualBasic.Left(TTarikh.Text, 2) & Mid(TTarikh.Text, 4, 2) & Microsoft.VisualBasic.Right(TTarikh.Text, 2)
        If Dirkard(FTarikh.Text, TTarikh.Text) = True Then MsgBox("خطا در مشخص کردن محدوده تاریخ", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "بخش گزارس دهی") : Exit Sub
        If Diff(F_Tarikh, T_Tarikh) > 250 Then MsgBox("محدوده تاریخ بیشتر از حد مجاز است. محدوده تا 250 روز قابل قبول است.", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "بخش گزارس دهی") : Exit Sub
        Try
            DBConn = New DBConnection
            DBConn.connectMe("SELECT * FROM MoshtariList WHERE (" & Get_Tarikhs(FTarikh.Text, TTarikh.Text) & ") AND IsBlackCancel=False ORDER BY SHParvandeNum;")
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                Do While d.Read
                    Item = ReList.Items.Add(d("ID".ToString))
                    With Item
                        .SubItems.Add(d("Tell".ToString))
                        .SubItems.Add(d("MostajerFN".ToString) & " " & d("MostajerLN".ToString))
                        .SubItems.Add(d("MoajerFN".ToString) & " " & d("MoajerLN".ToString))
                        .SubItems.Add(d("SHParvandeNum".ToString))
                    End With
                Loop
                Try
                    DBConn.OLEConn.Close()
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتي لطفا مشکل بوجود آمده را بررسي کرده و دوباره تلاش کنيد." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتي")
                End Try
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتي لطفا مشکل بوجود آمده را بررسي کرده و دوباره تلاش کنيد." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتي")
            End Try
        Catch err As System.Exception
            MsgBox("مشکل در ارتباط با بانک اطلاعاتي لطفا مشکل بوجود آمده را بررسي کرده و دوباره تلاش کنيد." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتي")
        End Try
    End Sub

    Private Sub DayCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DayCheck.CheckedChanged
        If DayCheck.Checked = True Then
            DayList.Enabled = True
            DateList.Enabled = False
            FTarikh.Enabled = False
            ChangeFTB.Enabled = False
            TTarikh.Enabled = False
            ChangeTTB.Enabled = False
            ViewB.Enabled = False
            ReList.Items.Clear()
            DayList.SelectedIndex = 0
        End If
    End Sub

    Private Sub ChangeFTB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeFTB.Click
        Dim InputBoxForm As New InputBoxF
        InputBoxForm.TVosool.Text = FTarikh.Text
        InputBoxForm.Message.Text = "لطفا در صورت اشتباه بودن تاریخ گزارش درج شده توسط برنامه تاریخ گزارش صحیح را وارد کنید."
        InputBoxForm.ShowDialog()
        FTarikh.Text = InputBoxForm.TVosool.Text
    End Sub

    Private Sub ChangeTTB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeTTB.Click
        Dim InputBoxForm As New InputBoxF
        InputBoxForm.TVosool.Text = TTarikh.Text
        InputBoxForm.Message.Text = "لطفا در صورت اشتباه بودن تاریخ گزارش درج شده توسط برنامه تاریخ گزارش صحیح را وارد کنید."
        InputBoxForm.ShowDialog()
        TTarikh.Text = InputBoxForm.TVosool.Text
    End Sub

    Private Sub FTCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FTCheck.CheckedChanged
        If FTCheck.Checked = True Then
            FTarikh.Enabled = True
            ChangeFTB.Enabled = True
            TTarikh.Enabled = True
            ChangeTTB.Enabled = True
            ViewB.Enabled = True
            DayList.Enabled = False
            DateList.Enabled = False
            ReList.Items.Clear()
        End If
    End Sub

    Function Get_Tarikhs(ByVal FT As String, ByVal TT As String) As String
        Dim Ekh As Long
        Ekh = Diff(Microsoft.VisualBasic.Left(FT, 2) & Mid(FT, 4, 2) & Microsoft.VisualBasic.Right(FT, 2), Microsoft.VisualBasic.Left(TT, 2) & Mid(TT, 4, 2) & Microsoft.VisualBasic.Right(TT, 2))
        Get_Tarikhs = ""
        For I As Integer = 0 To Ekh
            If I <> Ekh Then Get_Tarikhs = Get_Tarikhs & "TarikheGha='" & SubtractDay(TT, I) & "' or " Else Get_Tarikhs = Get_Tarikhs & "TarikheGha='" & SubtractDay(TT, I) & "'"
        Next
    End Function

    Private Sub BHAllDeleteB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BHAllDeleteB.Click
        If MessageBox("آیا می خواهید همه برداشتها را حذف کنید؟ ", MsgBoxStyle.YesNo, "حسابداری - برداشت") = True Then
            Try
                DBConn = New DBConnection
                DBConn.connectMe("Delete From HBList;")
                Try
                    DBConn.OLEComm.Connection = DBConn.OLEConn
                    DBConn.OLEComm.ExecuteNonQuery()
                    DBConn.OLEConn.Close()
                    Try
                        DBConn.OLEConn.Close()
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                End Try
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
            End Try
            Get_Setting(7)
        End If
    End Sub

    Private Sub VHAllDeleteB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VHAllDeleteB.Click
        If MessageBox("آیا می خواهید همه وصولها را حذف کنید؟ ", MsgBoxStyle.YesNo, "حسابداری - وصول") = True Then
            Try
                DBConn = New DBConnection
                DBConn.connectMe("Delete From HVList;")
                Try
                    DBConn.OLEComm.Connection = DBConn.OLEConn
                    DBConn.OLEComm.ExecuteNonQuery()
                    DBConn.OLEConn.Close()
                    Try
                        DBConn.OLEConn.Close()
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                End Try
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
            End Try
            Get_Setting(6)
        End If
    End Sub

    Private Sub HVRMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HVRMenu.Click
        HVReportB_Click(HVReportB, e)
    End Sub

    Private Sub HBRMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HBRMenu.Click
        HBReportB_Click(HBReportB, e)
    End Sub

    Private Sub SGResidB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SGResidB.Click
        If SGList.SelectedItems.Count <> 0 Then
            Dim ResidForm As New ResidF
            ResidForm.ID.Text = SGList.SelectedItems(0).SubItems(0).Text
            ResidForm.ShowDialog()
        Else
            MessageBox("برای ارائه رسید به سرمایه گذار لطفا ابتدا سرمایه گذار مورد نطر را انتخاب کنید.", MsgBoxStyle.OKOnly, "بخش سرمایه گذاری")
        End If
    End Sub

    Private Sub Licensed_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Licensed.MouseLeave
        Licensed.ForeColor = System.Drawing.ColorTranslator.FromOle(RGB(179, 122, 0))
    End Sub

    Private Sub Licensed_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Licensed.MouseMove
        Licensed.ForeColor = System.Drawing.ColorTranslator.FromOle(RGB(255, 119, 59))
    End Sub

    Private Sub CancelPB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelPB.Click
        If AList.SelectedItems.Count > 0 Then
            Select Case CancelPB.Text
                Case "فعال کردن پرونده"
                    If MessageBox("آیا می خواهید پرونده مورد نظر با شماره پرونده " & AList.SelectedItems(0).SubItems(4).Text & " را فعال کنید؟", MsgBoxStyle.YesNo, "فعال کردن پرونده") = True Then
                        Try
                            DBConn = New DBConnection
                            DBConn.connectMe("Update MoshtariList SET IsBlackCancel=False WHERE ID=" & AList.SelectedItems(0).SubItems(0).Text & ";")
                            DBConn.OLEComm.Connection = DBConn.OLEConn
                            DBConn.OLEComm.ExecuteNonQuery()
                            DBConn.OLEConn.Close()
                            Get_Setting_Single(2)
                        Catch err As System.Exception
                            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                        End Try
                    End If
                Case "مسدود کردن پرونده"
                    If MessageBox("آیا می خواهید پرونده مورد نظر با شماره پرونده " & AList.SelectedItems(0).SubItems(4).Text & " را مسدود کنید؟", MsgBoxStyle.YesNo, "مسدود کردن پرونده") = True Then
                        Try
                            DBConn = New DBConnection
                            DBConn.connectMe("Update MoshtariList SET IsBlackCancel=True WHERE ID=" & AList.SelectedItems(0).SubItems(0).Text & ";")
                            DBConn.OLEComm.Connection = DBConn.OLEConn
                            DBConn.OLEComm.ExecuteNonQuery()
                            DBConn.OLEConn.Close()
                        Catch err As System.Exception
                            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                        End Try
                        Try
                            DBConn = New DBConnection
                            DBConn.connectMe("Delete From AnySGozari WHERE SHParvandeNum='" & AList.SelectedItems(0).SubItems(4).Text & "';")
                            Try
                                DBConn.OLEComm.Connection = DBConn.OLEConn
                                DBConn.OLEComm.ExecuteNonQuery()
                                DBConn.OLEConn.Close()
                                Try
                                    DBConn.OLEConn.Close()
                                Catch err As System.Exception
                                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                                End Try
                            Catch err As System.Exception
                                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                            End Try
                        Catch err As System.Exception
                            MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                        End Try
                        Get_Setting_Single(2)
                    End If
            End Select
        End If
    End Sub

    Private Sub AList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AList.Click
        If AList.SelectedItems.Count > 0 Then
            If AList.SelectedItems(0).BackColor.Name = "Black" Then
                CancelPB.Text = "فعال کردن پرونده"
            Else
                CancelPB.Text = "مسدود کردن پرونده"
            End If
        End If
    End Sub

    Private Sub Programmer_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Programmer.MouseLeave
        Programmer.ForeColor = System.Drawing.Color.DarkRed
    End Sub

    Private Sub Programmer_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Programmer.MouseMove
        Programmer.ForeColor = System.Drawing.Color.OrangeRed
    End Sub

    Private Sub MInfPrintMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MInfPrintMenu.Click
        If MList.SelectedItems.Count > 0 Then
            Dim MR(6) As String
            Try
                DBConn = New DBConnection
                DBConn.connectMe("SELECT * FROM MoshtariList WHERE SHParvandeNum=" & MList.SelectedItems(0).SubItems(7).Text & ";")
                Try
                    DBConn.OLEComm.Connection = DBConn.OLEConn
                    Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                    Do While d.Read
                        MR(0) = "شماره پرونده : " & d("SHParvandeNum".ToString)
                        MR(1) = "نام و نام خانوادگی ماجر : " & d("MoajerFN".ToString) & " " & d("MoajerLN".ToString)
                        MR(2) = "نام و نام خانوادگی مستاجر : " & d("MostajerFN".ToString) & " " & d("MostajerLN".ToString)
                        MR(3) = "مقدار گرم طلا : " & d("CGGold".ToString)
                        MR(4) = "آدرس : " & d("Adrress".ToString)
                        MR(5) = "تلفن تماس : " & d("Tell".ToString)
                        MR(6) = "توضیحات : " & d("Tozihat".ToString)
                    Loop
                    Try
                        DBConn.OLEConn.Close()
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            End Try
            Try
                DBConn = New DBConnection
                DBConn.connectMe("Insert Into InfMReport (SHParvandeNum,Moajer,Mostajer,CGGold,Adrress,Tell,Tozihat) Values ('" & MR(0) & "', '" & MR(1) & "', '" & MR(2) & "', '" & MR(3) & "', '" & MR(4) & "', '" & MR(5) & "', '" & MR(6) & "');")
                Try
                    DBConn.OLEComm.Connection = DBConn.OLEConn
                    DBConn.OLEComm.ExecuteNonQuery()
                    DBConn.OLEConn.Close()
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
                Try
                    DBConn.OLEConn.Close()
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            End Try
            If MessageBox("آیا می خواهید اطلاعات پرونده مشتری را چاپ کنید؟", MsgBoxStyle.SystemModal, "چاپ اطلاعات پرونده") = True Then
                Dim PrintForm As New PrintF
                PrintForm.WP.Text = 22
                PrintForm.ShowDialog()
            End If
            Try
                DBConn = New DBConnection
                DBConn.connectMe("Delete From InfMReport;")
                Try
                    DBConn.OLEComm.Connection = DBConn.OLEConn
                    DBConn.OLEComm.ExecuteNonQuery()
                    DBConn.OLEConn.Close()
                    Try
                        DBConn.OLEConn.Close()
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                End Try
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
            End Try
        Else
            MessageBox("برای چاپ اطلاعات پرونده مشتری لطفا ابتدا مشتری مورد نطر را انتخاب کنید.", MsgBoxStyle.OKOnly, "لیست مشتریان")
        End If
    End Sub

    Private Sub MoveSysTryMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveSysTryMenu.Click
        DayListF.DefInstance.Close()
        DirListF.DefInstance.Close()
        HelpListF.DefInstance.Close()
        MoshtariListF.DefInstance.Close()
        ReportModeF.DefInstance.Close()
        ReportListF.DefInstance.Close()
        GhPrintF.DefInstance.Close()
        Me.WindowState = FormWindowState.Minimized
        IconTry.Visible = True
        Me.Hide()
    End Sub

    Private Sub ShowConMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowConMenu.Click
        If UnLock = True Then
            Dim UnlockForm As New UnlockF
            UnlockFAdminID = OnAdminID.Text
            UnlockForm.ShowDialog()
        End If
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub IconTry_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles IconTry.DoubleClick
        ShowConMenu_Click(ShowConMenu, e)
    End Sub

    Private Sub BurnB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BurnB.Click
        On Error GoTo get_error
        Shell(App_Path() & "CDBurning.exe", AppWinStyle.NormalFocus)
        Exit Sub
get_error:
        MsgBox("برنامه رایت پیدا نشد", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "رایت پشتیبان") : Exit Sub
    End Sub

    Private Sub AList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AList.SelectedIndexChanged
        If AList.SelectedItems.Count > 0 Then
            If AList.SelectedItems(0).BackColor.Name = "Black" Then
                CancelPB.Text = "فعال کردن پرونده"
            Else
                CancelPB.Text = "مسدود کردن پرونده"
            End If
        End If
    End Sub

    Private Sub MList_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MList.MouseUp
        If MList.SelectedItems.Count <> 0 And e.Button = MouseButtons.Right Then
            If MList.SelectedItems(0).SubItems(2).Text = "" Then GoldPicMenu.Enabled = False Else GoldPicMenu.Enabled = True
            If MList.SelectedItems(0).SubItems(1).Text = "" Then MPicMenu.Enabled = False Else MPicMenu.Enabled = True
            Dim RCPos As System.Drawing.Point
            RCPos = New Point(e.X, e.Y)
            MListMenu.Show(MList, RCPos)
        End If
    End Sub

    Private Sub PicPrintDocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PicPrintDocument.PrintPage
        Try
            Select Case PPDMode
                Case 0
                    e.Graphics.DrawImage(System.Drawing.Image.FromFile(App_Path() & "GPics\" & MList.SelectedItems(0).SubItems(0).Text & ".jpg"), 70, 60, 680, 500)
                Case 1
                    e.Graphics.DrawImage(System.Drawing.Image.FromFile(App_Path() & "MPics\" & MList.SelectedItems(0).SubItems(0).Text & ".jpg"), 70, 60, 680, 500)
            End Select
        Catch err As System.Exception
            MsgBox("مشکل در چاپ سند و شناسنامه :" & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "چاپ سند و شناسنامه") : Exit Sub
        End Try
    End Sub

    Private Sub PrintGoldPicMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintGoldPicMenu.Click
        If PicPrintDialog.ShowDialog = DialogResult.OK Then
            PPDMode = 0
            PicPrintDocument.Print()
        End If
    End Sub

    Private Sub ViewGoldPicMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewGoldPicMenu.Click
        PPDMode = 0
        'PicPrintPreviewDialog.WindowState = FormWindowState.Maximized
        PicPrintPreviewDialog.ShowDialog()
    End Sub

    Private Sub OptionsMenu_Select(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptionsMenu.Select
        Try
            If GetSetting("Money Security", "Accountant Edition Gold", "SaveEnabled") = "1" Then
                AutoSaveChangeMenu.Checked = True
            Else
                AutoSaveChangeMenu.Checked = False
            End If
        Catch err As System.Exception
            SaveSetting("Money Security", "Accountant Edition Gold", "SaveEnabled", "0")
            AutoSaveChangeMenu.Checked = False
        End Try
    End Sub

    Private Sub AutoSaveChangeMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoSaveChangeMenu.Click
        If AutoSaveChangeMenu.Checked = True Then
            SaveSetting("Money Security", "Accountant Edition Gold", "SaveEnabled", "0")
            AutoSaveChangeMenu.Checked = False
        Else
            SaveSetting("Money Security", "Accountant Edition Gold", "SaveEnabled", "1")
            AutoSaveChangeMenu.Checked = True
        End If
    End Sub

    Private Function SetGetChange(ByVal Mode As String)
        On Error Resume Next
        Select Case Mode
            Case "Set"
                If GetSetting("Money Security", "Accountant Edition", "SaveEnabled") = "1" Then
                    'Main
                    SaveSetting("Money Security", "Accountant Edition Gold", "MainLeft", MeLeft)
                    SaveSetting("Money Security", "Accountant Edition Gold", "MainTop", MeTop)
                    'Admin List
                    SaveSetting("Money Security", "Accountant Edition Gold", "AccessAdHeader", AccessAdHeader.Width)
                    SaveSetting("Money Security", "Accountant Edition Gold", "FNameAdHeader", FNameAdHeader.Width)
                    SaveSetting("Money Security", "Accountant Edition Gold", "UserAdHeader", UserAdHeader.Width)
                    'Moshtari List
                    SaveSetting("Money Security", "Accountant Edition Gold", "MListMoajerHeader", MListMoajerHeader.Width)
                    SaveSetting("Money Security", "Accountant Edition Gold", "MListCGoldHeader", MListCGoldHeader.Width)
                    SaveSetting("Money Security", "Accountant Edition Gold", "MListTellHeader", MListTellHeader.Width)
                    SaveSetting("Money Security", "Accountant Edition Gold", "MListMostajerHeader", MListMostajerHeader.Width)
                    SaveSetting("Money Security", "Accountant Edition Gold", "MListPicExHeader", MListPicExHeader.Width)
                    SaveSetting("Money Security", "Accountant Edition Gold", "MListShParvandeNumHeader", MListShParvandeNumHeader.Width)
                    'Archive List
                    SaveSetting("Money Security", "Accountant Edition Gold", "AlistTellHeader", AlistTellHeader.Width)
                    SaveSetting("Money Security", "Accountant Edition Gold", "AlistMostajerHeader", AlistMostajerHeader.Width)
                    SaveSetting("Money Security", "Accountant Edition Gold", "AlistMoajerHeader", AlistMoajerHeader.Width)
                    SaveSetting("Money Security", "Accountant Edition Gold", "AlistShParvandeNumHeader", AlistShParvandeNumHeader.Width)
                    'Report List
                    SaveSetting("Money Security", "Accountant Edition Gold", "ReListTellHeader", ReListTellHeader.Width)
                    SaveSetting("Money Security", "Accountant Edition Gold", "ReListMostajerHeader", ReListMostajerHeader.Width)
                    SaveSetting("Money Security", "Accountant Edition Gold", "ReListMoajerHeader", ReListMoajerHeader.Width)
                    SaveSetting("Money Security", "Accountant Edition Gold", "ReListShParvandehNumHeader", ReListShParvandehNumHeader.Width)
                    'NotePad List
                    SaveSetting("Money Security", "Accountant Edition Gold", "DIListTarikhHeader", DIListTarikhHeader.Width)
                    SaveSetting("Money Security", "Accountant Edition Gold", "DIListSubjectHeader", DIListSubjectHeader.Width)
                    SaveSetting("Money Security", "Accountant Edition Gold", "DIListWriterHeader", DIListWriterHeader.Width)
                    'Hesabdari Vosool List
                    SaveSetting("Money Security", "Accountant Edition Gold", "HVListMoajerHeader", HVListMoajerHeader.Width)
                    SaveSetting("Money Security", "Accountant Edition Gold", "HVListTellHeader", HVListTellHeader.Width)
                    SaveSetting("Money Security", "Accountant Edition Gold", "HVListMostajerHeader", HVListMostajerHeader.Width)
                    SaveSetting("Money Security", "Accountant Edition Gold", "HVListTarikhHeader", HVListTarikhHeader.Width)
                    SaveSetting("Money Security", "Accountant Edition Gold", "HVListShParvandehNumHeader", HVListShParvandehNumHeader.Width)
                    SaveSetting("Money Security", "Accountant Edition Gold", "HVListPriceHeader", HVListPriceHeader.Width)
                    'Hesabdari Bardasht List
                    SaveSetting("Money Security", "Accountant Edition Gold", "HBListTellHeader", HBListTellHeader.Width)
                    SaveSetting("Money Security", "Accountant Edition Gold", "HBListFSubjectHeader", HBListFSubjectHeader.Width)
                    SaveSetting("Money Security", "Accountant Edition Gold", "HBListTarikhHeader", HBListTarikhHeader.Width)
                    SaveSetting("Money Security", "Accountant Edition Gold", "HBListPardakhterHeader", HBListPardakhterHeader.Width)
                    SaveSetting("Money Security", "Accountant Edition Gold", "HBListPriceHeader", HBListPriceHeader.Width)
                    'Sarmaiegozari List
                    SaveSetting("Money Security", "Accountant Edition Gold", "SGListFathNameHeader", SGListFathNameHeader.Width)
                    SaveSetting("Money Security", "Accountant Edition Gold", "SGListGHNumHeader", SGListGHNumHeader.Width)
                    SaveSetting("Money Security", "Accountant Edition Gold", "SGListSGNameHeader", SGListSGNameHeader.Width)
                    SaveSetting("Money Security", "Accountant Edition Gold", "SGListShShHeader", SGListShShHeader.Width)
                End If
            Case "Get"
                If GetSetting("Money Security", "Accountant Edition", "SaveEnabled") = "1" Then
                    'Main
                    Me.Left = GetSetting("Money Security", "Accountant Edition Gold", "MainLeft")
                    Me.Top = GetSetting("Money Security", "Accountant Edition Gold", "MainTop")
                    'Admin List
                    AccessAdHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "AccessAdHeader")
                    FNameAdHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "FNameAdHeader")
                    UserAdHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "UserAdHeader")
                    'Moshtari List
                    MListMoajerHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "MListMoajerHeader")
                    MListCGoldHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "MListCGoldHeader")
                    MListTellHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "MListTellHeader")
                    MListMostajerHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "MListMostajerHeader")
                    MListPicExHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "MListPicExHeader")
                    MListShParvandeNumHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "MListShParvandeNumHeader")
                    'Archive List
                    AlistTellHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "AlistTellHeader")
                    AlistMostajerHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "AlistMostajerHeader")
                    AlistMoajerHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "AlistMoajerHeader")
                    AlistShParvandeNumHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "AlistShParvandeNumHeader")
                    'Report List
                    ReListTellHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "ReListTellHeader")
                    ReListMostajerHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "ReListMostajerHeader")
                    ReListMoajerHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "ReListMoajerHeader")
                    ReListShParvandehNumHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "ReListShParvandehNumHeader")
                    'NotePad List
                    DIListTarikhHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "DIListTarikhHeader")
                    DIListSubjectHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "DIListSubjectHeader")
                    DIListWriterHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "DIListWriterHeader")
                    'Hesabdari Vosool List
                    HVListMoajerHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "HVListMoajerHeader")
                    HVListTellHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "HVListTellHeader")
                    HVListMostajerHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "HVListMostajerHeader")
                    HVListTarikhHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "HVListTarikhHeader")
                    HVListShParvandehNumHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "HVListShParvandehNumHeader")
                    HVListPriceHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "HVListPriceHeader")
                    'Hesabdari Bardasht List
                    HBListTellHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "HBListTellHeader")
                    HBListFSubjectHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "HBListFSubjectHeader")
                    HBListTarikhHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "HBListTarikhHeader")
                    HBListPardakhterHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "HBListPardakhterHeader")
                    HBListPriceHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "HBListPriceHeader")
                    'Sarmaiegozari List
                    SGListFathNameHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "SGListFathNameHeader")
                    SGListGHNumHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "SGListGHNumHeader")
                    SGListSGNameHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "SGListSGNameHeader")
                    SGListShShHeader.Width = GetSetting("Money Security", "Accountant Edition Gold", "SGListShShHeader")
                End If
        End Select
    End Function

    Private Sub Main_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Move
        If Me.WindowState = FormWindowState.Normal Then
            MeLeft = Me.Left
            MeTop = Me.Top
        End If
    End Sub

    Private Sub MList_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles MList.ColumnClick
        If e.Column <> sortColumn Then
            sortColumn = e.Column
            MList.Sorting = SortOrder.Descending
        Else
            If MList.Sorting = SortOrder.Ascending Then
                MList.Sorting = SortOrder.Descending
            Else
                MList.Sorting = SortOrder.Ascending
            End If
        End If
        Select Case e.Column
            Case 3, 4, 7
                SortType = "Numeric"
            Case 5, 6
                SortType = "String"
            Case Else
                Exit Sub
        End Select
        NewCol = e.Column
        MList.Sort()
        MList.ListViewItemSorter = New ColumnSorter(e.Column, MList.Sorting)
    End Sub

    Private Sub AllCB_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles AllCB.MouseUp
        If e.Button = MouseButtons.Left Then
            Dim RCPos As System.Drawing.Point
            RCPos = New Point(e.X, e.Y)
            AllCMenu.Show(AllCB, RCPos)
        End If
    End Sub

    Private Sub AllCGMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllCGMenu.Click
        Dim ACGoldForm As New ACGoldF
        ACGoldForm.JMode = "G"
        ACGoldForm.ShowDialog()
    End Sub

    Private Sub AllCSGMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllCSGMenu.Click
        Dim ACGoldForm As New ACGoldF
        ACGoldForm.JMode = "SG"
        ACGoldForm.ShowDialog()
    End Sub

    Private Sub ViewMPicMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewMPicMenu.Click
        PPDMode = 1
        'PicPrintPreviewDialog.WindowState = FormWindowState.Maximized
        PicPrintPreviewDialog.ShowDialog()
    End Sub

    Private Sub PrintMPicMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintMPicMenu.Click
        If PicPrintDialog.ShowDialog = DialogResult.OK Then
            PPDMode = 1
            PicPrintDocument.Print()
        End If
    End Sub

    Private Sub MSBPrintB_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MSBPrintB.MouseUp
        If e.Button = MouseButtons.Left Then
            Dim RCPos As System.Drawing.Point
            RCPos = New Point(e.X, e.Y)
            AllPrintMMenu.Show(MSBPrintB, RCPos)
        End If
    End Sub

    Private Sub MFormPrintMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MFormPrintMenu.Click
        If MList.SelectedItems.Count > 0 Then
            Dim MR(6) As String
            Try
                DBConn = New DBConnection
                DBConn.connectMe("SELECT * FROM MoshtariList WHERE SHParvandeNum=" & MList.SelectedItems(0).SubItems(7).Text & ";")
                Try
                    DBConn.OLEComm.Connection = DBConn.OLEConn
                    Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                    Do While d.Read
                        MR(0) = "شماره پرونده : " & d("SHParvandeNum".ToString)
                        MR(1) = "نام و نام خانوادگی ماجر : " & d("MoajerFN".ToString) & " " & d("MoajerLN".ToString)
                        MR(2) = "نام و نام خانوادگی مستاجر : " & d("MostajerFN".ToString) & " " & d("MostajerLN".ToString)
                        MR(3) = "مقدار گرم طلا : " & d("CGGold".ToString)
                        MR(4) = "آدرس : " & d("Adrress".ToString)
                        MR(5) = "تلفن تماس : " & d("Tell".ToString)
                        MR(6) = "توضیحات : " & d("Tozihat".ToString)
                    Loop
                    Try
                        DBConn.OLEConn.Close()
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            End Try
            Try
                DBConn = New DBConnection
                DBConn.connectMe("Insert Into InfMReport (SHParvandeNum,Moajer,Mostajer,CGGold,Adrress,Tell,Tozihat) Values ('" & MR(0) & "', '" & MR(1) & "', '" & MR(2) & "', '" & MR(3) & "', '" & MR(4) & "', '" & MR(5) & "', '" & MR(6) & "');")
                Try
                    DBConn.OLEComm.Connection = DBConn.OLEConn
                    DBConn.OLEComm.ExecuteNonQuery()
                    DBConn.OLEConn.Close()
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
                Try
                    DBConn.OLEConn.Close()
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
                End Try
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی")
            End Try
            If MessageBox("آیا می خواهید فرم شناسه مشتری را چاپ کنید؟", MsgBoxStyle.SystemModal, "چاپ اطلاعات پرونده") = True Then
                Dim PrintForm As New PrintF
                PrintForm.WP.Text = 23
                PrintForm.ShowDialog()
            End If
            Try
                DBConn = New DBConnection
                DBConn.connectMe("Delete From InfMReport;")
                Try
                    DBConn.OLEComm.Connection = DBConn.OLEConn
                    DBConn.OLEComm.ExecuteNonQuery()
                    DBConn.OLEConn.Close()
                    Try
                        DBConn.OLEConn.Close()
                    Catch err As System.Exception
                        MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                    End Try
                Catch err As System.Exception
                    MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
                End Try
            Catch err As System.Exception
                MsgBox("مشکل در ارتباط با بانک اطلاعاتی لطفا مشکل بوجود آمده را بررسی کرده و دوباره تلاش کنید." & vbCrLf & "مشکل بوجود آمده :" & vbCrLf & err.Message, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight, "بانک اطلاعاتی") : Exit Sub
            End Try
        Else
            MessageBox("برای چاپ اطلاعات پرونده مشتری لطفا ابتدا مشتری مورد نطر را انتخاب کنید.", MsgBoxStyle.OKOnly, "لیست مشتریان")
        End If
    End Sub

    Private Sub AllCMVMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllCMVMenu.Click
        Dim ACGoldForm As New ACGoldF
        ACGoldForm.JMode = "MV"
        ACGoldForm.ShowDialog()
    End Sub
End Class
