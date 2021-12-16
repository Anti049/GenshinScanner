using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using GenshinScanner.Input;

namespace GenshinScanner
{
    public partial class MainForm : Form
    {
        // Process
        private static Thread mainThread;
        // Input
        public static KeyboardHook keyHook = new KeyboardHook();
        // Output
        private static string filePath = "";

        public MainForm()
        {
            InitializeComponent();

            this.Text = Resources.AppTitle + ' ' + Resources.AppVersion;
            this.comboLanguage.SelectedIndex = this.comboDelay.SelectedIndex = 0;
            // Default output file path
            textOutputFileLocation.Text = "";
            filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (filePath == "")
                textOutputFileLocation.Text = "Select Folder";
            else
            {
                filePath += "\\GenshinScanData";
                textOutputFileLocation.Text = filePath;
            }
        }

        private void panelCharacterDetails_Resize(object sender, EventArgs e)
        {
            labelCharacterDescription.MaximumSize = new Size(panelCharacterDetails.Width - (panelCharacterDetails.Padding.Left + panelCharacterDetails.Padding.Right), 0);
        }
    }
}
