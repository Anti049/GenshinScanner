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
        
        public ScannerForm()
        {
            InitializeComponent();
        }
    }
}