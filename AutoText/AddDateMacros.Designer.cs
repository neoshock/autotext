﻿namespace AutoText
{
	partial class AddDateMacros
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
			this.textBoxFormat = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.linkLabelHelp = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// textBoxFormat
			// 
			this.textBoxFormat.Location = new System.Drawing.Point(57, 17);
			this.textBoxFormat.Name = "textBoxFormat";
			this.textBoxFormat.Size = new System.Drawing.Size(124, 20);
			this.textBoxFormat.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Format";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(187, 15);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(49, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// linkLabelHelp
			// 
			this.linkLabelHelp.AutoSize = true;
			this.linkLabelHelp.Location = new System.Drawing.Point(152, 41);
			this.linkLabelHelp.Name = "linkLabelHelp";
			this.linkLabelHelp.Size = new System.Drawing.Size(29, 13);
			this.linkLabelHelp.TabIndex = 3;
			this.linkLabelHelp.TabStop = true;
			this.linkLabelHelp.Text = "Help";
			this.linkLabelHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHelp_LinkClicked);
			// 
			// AddDateMacros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(246, 63);
			this.Controls.Add(this.linkLabelHelp);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxFormat);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AddDateMacros";
			this.Text = "AddDateMacros";
			this.Load += new System.EventHandler(this.AddDateMacros_Load);
			this.Shown += new System.EventHandler(this.AddDateMacros_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxFormat;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.LinkLabel linkLabelHelp;
	}
}