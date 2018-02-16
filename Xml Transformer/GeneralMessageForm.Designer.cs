namespace Xml_Transformer {
	partial class GeneralMessageForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralMessageForm));
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.rtbSchemaValidationMsg = new System.Windows.Forms.RichTextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tsmiOption = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiWrapText = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.rtbSchemaValidationMsg);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(736, 471);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(736, 495);
			this.toolStripContainer1.TabIndex = 1;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
			// 
			// rtbSchemaValidationMsg
			// 
			this.rtbSchemaValidationMsg.DetectUrls = false;
			this.rtbSchemaValidationMsg.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbSchemaValidationMsg.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.rtbSchemaValidationMsg.Location = new System.Drawing.Point(0, 0);
			this.rtbSchemaValidationMsg.Name = "rtbSchemaValidationMsg";
			this.rtbSchemaValidationMsg.ReadOnly = true;
			this.rtbSchemaValidationMsg.Size = new System.Drawing.Size(736, 471);
			this.rtbSchemaValidationMsg.TabIndex = 1;
			this.rtbSchemaValidationMsg.Text = "";
			this.rtbSchemaValidationMsg.WordWrap = false;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOption});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(736, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tsmiOption
			// 
			this.tsmiOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiWrapText});
			this.tsmiOption.Name = "tsmiOption";
			this.tsmiOption.Size = new System.Drawing.Size(51, 20);
			this.tsmiOption.Text = "&Option";
			// 
			// tsmiWrapText
			// 
			this.tsmiWrapText.Name = "tsmiWrapText";
			this.tsmiWrapText.Size = new System.Drawing.Size(125, 22);
			this.tsmiWrapText.Text = "Wrap Text";
			this.tsmiWrapText.Click += new System.EventHandler(this.tsmiWrapText_Click);
			// 
			// GeneralMessageForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(736, 495);
			this.Controls.Add(this.toolStripContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MinimizeBox = false;
			this.Name = "GeneralMessageForm";
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.RichTextBox rtbSchemaValidationMsg;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmiOption;
		private System.Windows.Forms.ToolStripMenuItem tsmiWrapText;

	}
}