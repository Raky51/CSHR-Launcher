
Option Strict Off
Option Explicit On

Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
<Assembly: System.Reflection.AssemblyTitleAttribute("CSHR_Launcher_V3"),  _
 Assembly: System.Reflection.AssemblyVersionAttribute("1.0.0.0"),  _
 Assembly: System.Reflection.AssemblyCopyrightAttribute("Copyright ©  2017"),  _
 Assembly: System.Reflection.AssemblyDescriptionAttribute(""),  _
 Assembly: System.Reflection.AssemblyFileVersionAttribute("1.0.0.0"),  _
 Assembly: System.Runtime.InteropServices.GuidAttribute("1d504b69-9f46-4330-8967-993367b9b4c4"),  _
 Assembly: System.Reflection.AssemblyTrademarkAttribute("CSHR_Launcher_V3™"),  _
 Assembly: System.Reflection.AssemblyProductAttribute("CSHR_Launcher_V3"),  _
 Assembly: System.Reflection.AssemblyCompanyAttribute(""),  _
 Assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)> 

Namespace CSHR_Launcher_V3
    
    <Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
    Partial Public Class Fenêtre_Krypton1
        Inherits ComponentFactory.Krypton.Toolkit.KryptonForm
        
        Public kryptonButton3 As ComponentFactory.Krypton.Toolkit.KryptonButton
        
        Public kryptonButton2 As ComponentFactory.Krypton.Toolkit.KryptonButton
        
        Public kryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
        
        Public kryptonLinkLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
        
        Public kryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
        
        Public Sub New()
            MyBase.New
            Me.InitializeComponent
        End Sub
        
        Public Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fenêtre_Krypton1))
            Me.kryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
            Me.kryptonButton3 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
            Me.kryptonButton2 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
            Me.kryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
            Me.kryptonLinkLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
            CType(Me.kryptonPanel1,System.ComponentModel.ISupportInitialize).BeginInit
            Me.kryptonPanel1.SuspendLayout
            Me.SuspendLayout
            '
            'kryptonPanel1
            '
            Me.kryptonPanel1.Controls.Add(Me.kryptonLinkLabel1)
            Me.kryptonPanel1.Controls.Add(Me.kryptonButton3)
            Me.kryptonPanel1.Controls.Add(Me.kryptonButton2)
            Me.kryptonPanel1.Controls.Add(Me.kryptonButton1)
            Me.kryptonPanel1.Cursor = System.Windows.Forms.Cursors.Default
            Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.kryptonPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.kryptonPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.kryptonPanel1.Location = New System.Drawing.Point(0, 0)
            Me.kryptonPanel1.Name = "kryptonPanel1"
            Me.kryptonPanel1.Size = New System.Drawing.Size(438, 258)
            Me.kryptonPanel1.TabIndex = 0
            '
            'kryptonButton3
            '
            Me.kryptonButton3.Cursor = System.Windows.Forms.Cursors.Default
            Me.kryptonButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.kryptonButton3.ImeMode = System.Windows.Forms.ImeMode.Disable
            Me.kryptonButton3.Location = New System.Drawing.Point(12, 13)
            Me.kryptonButton3.Name = "kryptonButton3"
            Me.kryptonButton3.Size = New System.Drawing.Size(90, 25)
            Me.kryptonButton3.TabIndex = 2
            Me.kryptonButton3.Values.Text = "Contact us"
            '
            'kryptonButton2
            '
            Me.kryptonButton2.Cursor = System.Windows.Forms.Cursors.Default
            Me.kryptonButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.kryptonButton2.ImeMode = System.Windows.Forms.ImeMode.Disable
            Me.kryptonButton2.Location = New System.Drawing.Point(336, 13)
            Me.kryptonButton2.Name = "kryptonButton2"
            Me.kryptonButton2.Size = New System.Drawing.Size(90, 25)
            Me.kryptonButton2.TabIndex = 1
            Me.kryptonButton2.Values.Text = "Visit CSHR.CF"
            '
            'kryptonButton1
            '
            Me.kryptonButton1.Cursor = System.Windows.Forms.Cursors.Default
            Me.kryptonButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.kryptonButton1.ImeMode = System.Windows.Forms.ImeMode.Disable
            Me.kryptonButton1.Location = New System.Drawing.Point(51, 153)
            Me.kryptonButton1.Name = "kryptonButton1"
            Me.kryptonButton1.Size = New System.Drawing.Size(327, 93)
            Me.kryptonButton1.TabIndex = 0
            Me.kryptonButton1.Values.Text = "Play !"
            '
            'kryptonLinkLabel1
            '
            Me.kryptonLinkLabel1.Cursor = System.Windows.Forms.Cursors.Default
            Me.kryptonLinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.kryptonLinkLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.kryptonLinkLabel1.Location = New System.Drawing.Point(220, 13)
            Me.kryptonLinkLabel1.Name = "kryptonLinkLabel1"
            Me.kryptonLinkLabel1.Size = New System.Drawing.Size(66, 20)
            Me.kryptonLinkLabel1.TabIndex = 3
            Me.kryptonLinkLabel1.Values.Text = "Donate us"
            '
            'Fenêtre_Krypton1
            '
            Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
            Me.ClientSize = New System.Drawing.Size(438, 258)
            Me.Controls.Add(Me.kryptonPanel1)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
            Me.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Name = "Fenêtre_Krypton1"
            Me.Text = "CSHR Launcher Version 3.0"
            CType(Me.kryptonPanel1,System.ComponentModel.ISupportInitialize).EndInit
            Me.kryptonPanel1.ResumeLayout(false)
            Me.kryptonPanel1.PerformLayout
            Me.ResumeLayout(false)
            AddHandler kryptonButton1.Click, AddressOf Me.kryptonButton1_Click
            AddHandler kryptonButton2.Click, AddressOf Me.kryptonButton2_Click
            AddHandler kryptonButton3.Click, AddressOf Me.kryptonButton3_Click
            AddHandler kryptonLinkLabel1.Click, AddressOf Me.kryptonLinkLabel1_Click
        End Sub
        
        <System.STAThreadAttribute()>  _
        Public Shared Sub Main()
            _manager.Run(System.Environment.GetCommandLineArgs())
        End Sub
    End Class
    
    Public Class Fenêtre_Krypton1
        
        'Fonction kryptonButton1_Click
        Public Sub kryptonButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            VelerSoftware_GeneralPlugin.RunProcess("samp://play.cshr.cf:7777", System.Diagnostics.ProcessWindowStyle.Normal, "", "False")
        End Sub
        
        'Fonction kryptonButton2_Click
        Public Sub kryptonButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            VelerSoftware_GeneralPlugin.RunProcess("http://cshr.cf", System.Diagnostics.ProcessWindowStyle.Normal, "", "False")
        End Sub
        
        'Fonction kryptonButton3_Click
        Public Sub kryptonButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            System.Windows.Forms.MessageBox.Show("You can contact us by sending an e-mail to admin@cshr.cf or by posting thread in the forum at : http://forum.cshr.cf", "CSHR Launcher V3 - Contact Us", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information)
        End Sub
        
        'Fonction kryptonLinkLabel1_Click
        Public Sub kryptonLinkLabel1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            VelerSoftware_GeneralPlugin.RunProcess("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=PBVQD3KGN4VZW", System.Diagnostics.ProcessWindowStyle.Normal, "", "False")
        End Sub
    End Class
End Namespace

Namespace CSHR_Launcher_V3.My
    
    Partial Friend Class MyApplication
        Inherits Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
        
        <System.Diagnostics.DebuggerStepThroughAttribute()>  _
        Public Sub New()
            MyBase.New(Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.Windows)
            Me.IsSingleInstance = false
            Me.EnableVisualStyles = true
            Me.SaveMySettingsOnExit = true
            Me.ShutdownStyle = Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterMainFormCloses
        End Sub
        
        <System.Diagnostics.DebuggerStepThroughAttribute()>  _
        Protected Overrides Sub OnCreateMainForm()
            Me.MainForm = Variables.Fenêtre_Krypton1
        End Sub
    End Class
End Namespace


Partial Public Class VelerSoftware_GeneralPlugin

    Shared Function RunProcess(ByVal File As String, ByVal Mode As System.Diagnostics.ProcessWindowStyle, ByVal Arguments As String, ByVal WaitForExit As Boolean) As String
        Dim result As String = Nothing
        If Microsoft.VisualBasic.FileIO.FileSystem.FileExists(File) Then
            Dim proc As New System.Diagnostics.Process
            With proc.StartInfo
                .FileName = File
                .ErrorDialog = True
                .RedirectStandardOutput = True
                .UseShellExecute = False
                If Mode = System.Diagnostics.ProcessWindowStyle.Hidden Then .CreateNoWindow = True
                .WindowStyle = Mode
                .Arguments = Arguments
            End With
            proc.Start()
            If WaitForExit Then
                result = proc.StandardOutput.ReadToEnd
                proc.WaitForExit()
            End If
        Else
            System.Diagnostics.Process.Start(File)
        End If
        Return result
    End Function

End Class




Namespace CSHR_Launcher_V3
  Module Variables
      Public _manager As My.MyApplication = New My.MyApplication
      Public _computer As Microsoft.VisualBasic.Devices.Computer = New Microsoft.VisualBasic.Devices.Computer
      Private _Fenêtre_Krypton1 As New Global.CSHR_Launcher_V3.Fenêtre_Krypton1()
      Public Property Fenêtre_Krypton1 As Global.CSHR_Launcher_V3.Fenêtre_Krypton1 ' Window Fenêtre_Krypton1
           Get
               If _Fenêtre_Krypton1.IsDisposed Then _Fenêtre_Krypton1 = New Global.CSHR_Launcher_V3.Fenêtre_Krypton1()
               Return _Fenêtre_Krypton1
           End Get
           Set(ByVal value As Global.CSHR_Launcher_V3.Fenêtre_Krypton1)
               _Fenêtre_Krypton1 = value
           End Set
      End Property
  End Module
End NameSpace
