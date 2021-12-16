using System.ComponentModel;

namespace GenshinScanner.Components
{
	partial class SelectList
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.selectTitle = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// selectTitle
			// 
			this.selectTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.selectTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectTitle.Location = new System.Drawing.Point(0, 0);
			this.selectTitle.Name = "selectTitle";
			this.selectTitle.Size = new System.Drawing.Size(560, 23);
			this.selectTitle.TabIndex = 1;
			this.selectTitle.Text = "Title:";
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 23);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(560, 346);
			this.panel1.TabIndex = 2;
			// 
			// checkBox1
			// 
			this.checkBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.checkBox1.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1.Location = new System.Drawing.Point(0, 0);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(560, 24);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "checkBox1";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// SelectList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.selectTitle);
			this.Name = "SelectList";
			this.Size = new System.Drawing.Size(560, 369);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.CheckBox checkBox1;

		private System.Windows.Forms.Panel panel1;

		private System.Windows.Forms.ListBox listBox1;

		private System.Windows.Forms.Label selectTitle;

		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.Label label1;

		#endregion
	}
}