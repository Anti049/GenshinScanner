namespace GenshinScanner.Components
{
	public class DoubleBufferedPanel : System.Windows.Forms.Panel
	{
		public DoubleBufferedPanel() : base()
		{
			this.DoubleBuffered = true;
		}
	}
}