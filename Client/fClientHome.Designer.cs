namespace Client
{
	partial class fClientHome
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
			this.lbName = new System.Windows.Forms.Label();
			this.lbUSername = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.listView2 = new System.Windows.Forms.ListView();
			this.btnFind = new System.Windows.Forms.Button();
			this.listView4 = new System.Windows.Forms.ListView();
			this.btnExit = new System.Windows.Forms.Button();
			this.lsvOnline = new System.Windows.Forms.ListView();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
			this.panel1.Controls.Add(this.lbName);
			this.panel1.Controls.Add(this.lbUSername);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(412, 76);
			this.panel1.TabIndex = 1;
			// 
			// lbName
			// 
			this.lbName.AutoSize = true;
			this.lbName.ForeColor = System.Drawing.Color.White;
			this.lbName.Location = new System.Drawing.Point(127, 40);
			this.lbName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(155, 18);
			this.lbName.TabIndex = 3;
			this.lbName.Text = "Thái Thanh Phong";
			// 
			// lbUSername
			// 
			this.lbUSername.AutoSize = true;
			this.lbUSername.ForeColor = System.Drawing.Color.White;
			this.lbUSername.Location = new System.Drawing.Point(127, 9);
			this.lbUSername.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lbUSername.Name = "lbUSername";
			this.lbUSername.Size = new System.Drawing.Size(112, 18);
			this.lbUSername.TabIndex = 2;
			this.lbUSername.Text = "tthanhphong";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(49, 40);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Name: ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(14, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username: ";
			// 
			// listView2
			// 
			this.listView2.Dock = System.Windows.Forms.DockStyle.Top;
			this.listView2.Location = new System.Drawing.Point(0, 76);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(412, 39);
			this.listView2.TabIndex = 3;
			this.listView2.UseCompatibleStateImageBehavior = false;
			// 
			// btnFind
			// 
			this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
			this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFind.ForeColor = System.Drawing.Color.White;
			this.btnFind.Location = new System.Drawing.Point(320, 83);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(80, 26);
			this.btnFind.TabIndex = 9;
			this.btnFind.Text = "+ Find";
			this.btnFind.UseVisualStyleBackColor = false;
			// 
			// listView4
			// 
			this.listView4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.listView4.Location = new System.Drawing.Point(0, 523);
			this.listView4.Name = "listView4";
			this.listView4.Size = new System.Drawing.Size(412, 48);
			this.listView4.TabIndex = 10;
			this.listView4.UseCompatibleStateImageBehavior = false;
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.ForeColor = System.Drawing.Color.White;
			this.btnExit.Location = new System.Drawing.Point(325, 532);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 27);
			this.btnExit.TabIndex = 11;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// lsvOnline
			// 
			this.lsvOnline.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lsvOnline.Location = new System.Drawing.Point(0, 115);
			this.lsvOnline.MultiSelect = false;
			this.lsvOnline.Name = "lsvOnline";
			this.lsvOnline.Size = new System.Drawing.Size(412, 408);
			this.lsvOnline.TabIndex = 12;
			this.lsvOnline.UseCompatibleStateImageBehavior = false;
			this.lsvOnline.View = System.Windows.Forms.View.List;
			this.lsvOnline.DoubleClick += new System.EventHandler(this.lsvOnline_DoubleClick);
			// 
			// fClientHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(412, 571);
			this.Controls.Add(this.lsvOnline);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.listView4);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.listView2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "fClientHome";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Home";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fClientHome_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fClientHome_FormClosed);
			this.Load += new System.EventHandler(this.fClientHome_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbName;
		private System.Windows.Forms.Label lbUSername;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.ListView listView4;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.ListView lsvOnline;
	}
}

