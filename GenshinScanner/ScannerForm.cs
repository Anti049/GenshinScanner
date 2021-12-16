using System;
using System.Threading;
using System.Windows.Forms;
using GenshinScanner.Input;

namespace GenshinScanner
{
    public partial class ScannerForm : Form
    {
        // Process
        private static Thread mainThread;
        // Input
        public static KeyboardHook keyHook = new KeyboardHook();
        // Output
        private static string filePath = "";
        
        public ScannerForm()
        {
            InitializeComponent();
            
            this.Text = Resources.AppTitle + ' ' + Resources.AppVersion;
            this.comboLanguage.SelectedIndex = this.comboDelay.SelectedIndex = 0;
            
            // Default output file path
            textFilePath.Text = "";
            filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (filePath == "")
                textFilePath.Text = "Select Folder";
            else
            {
                filePath += "\\GenshinScanData";
                textFilePath.Text = filePath;
            }
        }
    }
}