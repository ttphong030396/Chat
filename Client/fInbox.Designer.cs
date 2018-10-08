namespace Client
{
	partial class fInbox
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.pnReceiver = new System.Windows.Forms.Panel();
			this.pnSender = new System.Windows.Forms.Panel();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(668, 37);
			this.panel1.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.txtMessage);
			this.panel3.Controls.Add(this.btnSend);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 329);
			this.panel3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(668, 28);
			this.panel3.TabIndex = 2;
			// 
			// txtMessage
			// 
			this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtMessage.Location = new System.Drawing.Point(0, 0);
			this.txtMessage.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(575, 27);
			this.txtMessage.TabIndex = 10;
			// 
			// btnSend
			// 
			this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
			this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSend.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSend.ForeColor = System.Drawing.Color.White;
			this.btnSend.Location = new System.Drawing.Point(575, 0);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(93, 28);
			this.btnSend.TabIndex = 9;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = false;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// pnReceiver
			// 
			this.pnReceiver.AutoScroll = true;
			this.pnReceiver.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnReceiver.Location = new System.Drawing.Point(0, 37);
			this.pnReceiver.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.pnReceiver.Name = "pnReceiver";
			this.pnReceiver.Size = new System.Drawing.Size(324, 292);
			this.pnReceiver.TabIndex = 3;
			// 
			// pnSender
			// 
			this.pnSender.AutoScroll = true;
			this.pnSender.AutoSize = true;
			this.pnSender.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pnSender.Cursor = System.Windows.Forms.Cursors.No;
			this.pnSender.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnSender.Location = new System.Drawing.Point(324, 37);
			this.pnSender.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.pnSender.Name = "pnSender";
			this.pnSender.Size = new System.Drawing.Size(344, 292);
			this.pnSender.TabIndex = 4;
			// 
			// fInbox
			// 
			this.AcceptButton = this.btnSend;
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(668, 357);
			this.Controls.Add(this.pnSender);
			this.Controls.Add(this.pnReceiver);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.MaximumSize = new System.Drawing.Size(684, 396);
			this.MinimumSize = new System.Drawing.Size(684, 396);
			this.Name = "fInbox";
			this.Text = "fInbox";
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.Panel pnReceiver;
		private System.Windows.Forms.Panel pnSender;
	}
}