using System.Collections.Generic;
using System.Windows.Forms;

namespace GenshinScanner.Components
{
	public partial class SelectList : UserControl
	{
		private Dictionary<string, bool> selected;
		public SelectList()
		{
			InitializeComponent();
		}
	}
}