Imports System
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel

Namespace WindowsFormsApp_RegularDataSourceKPI

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.WXI)
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call Application.Run(New Form1())
        End Sub
    End Module
End Namespace
