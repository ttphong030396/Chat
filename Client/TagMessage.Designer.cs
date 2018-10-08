namespace Client
{
	partial class TagMessage
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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
			this.pnBackColor = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbMessage = new System.Windows.Forms.Label();
			this.lbTime = new System.Windows.Forms.Label();
			this.pnBackColor.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnBackColor
			// 
			this.pnBackColor.Controls.Add(this.lbTime);
			this.pnBackColor.Controls.Add(this.panel1);
			this.pnBackColor.Location = new System.Drawing.Point(4, 3);
			this.pnBackColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.pnBackColor.Name = "pnBackColor";
			this.pnBackColor.Size = new System.Drawing.Size(324, 57);
			this.pnBackColor.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lbMessage);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(324, 31);
			this.panel1.TabIndex = 0;
			// 
			// lbMessage
			// 
			this.lbMessage.AutoSize = true;
			this.lbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbMessage.Location = new System.Drawing.Point(0, 0);
			this.lbMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbMessage.Name = "lbMessage";
			this.lbMessage.Size = new System.Drawing.Size(119, 18);
			this.lbMessage.TabIndex = 0;
			this.lbMessage.Text = "How are you?";
			// 
			// lbTime
			// 
			this.lbTime.AutoSize = true;
			this.lbTime.Dock = System.Windows.Forms.DockStyle.Right;
			this.lbTime.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTime.Location = new System.Drawing.Point(286, 31);
			this.lbTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbTime.Name = "lbTime";
			this.lbTime.Size = new System.Drawing.Size(38, 16);
			this.lbTime.TabIndex = 1;
			this.lbTime.Text = "9:40";
			// 
			// TagMessage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.pnBackColor);
			this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "TagMessage";
			this.Size = new System.Drawing.Size(332, 63);
			this.pnBackColor.ResumeLayout(false);
			this.pnBackColor.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnBackColor;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbTime;
		private System.Windows.Forms.Label lbMessage;
	}
}
