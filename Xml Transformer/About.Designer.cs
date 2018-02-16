namespace Xml_Transformer {
	partial class About {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblChangeList = new System.Windows.Forms.Label();
            this.rtbChangeList = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(12, 9);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(173, 13);
            this.lblAuthor.TabIndex = 0;
            this.lblAuthor.Text = "Author: Leo Li ( ismeleo@live.com )";
            // 
            // lblChangeList
            // 
            this.lblChangeList.AutoSize = true;
            this.lblChangeList.Location = new System.Drawing.Point(12, 29);
            this.lblChangeList.Name = "lblChangeList";
            this.lblChangeList.Size = new System.Drawing.Size(63, 13);
            this.lblChangeList.TabIndex = 1;
            this.lblChangeList.Text = "Change List";
            // 
            // rtbChangeList
            // 
            this.rtbChangeList.Location = new System.Drawing.Point(15, 46);
            this.rtbChangeList.Name = "rtbChangeList";
            this.rtbChangeList.ReadOnly = true;
            this.rtbChangeList.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbChangeList.Size = new System.Drawing.Size(373, 265);
            this.rtbChangeList.TabIndex = 2;
            this.rtbChangeList.Text = resources.GetString("rtbChangeList.Text");
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 323);
            this.Controls.Add(this.rtbChangeList);
            this.Controls.Add(this.lblChangeList);
            this.Controls.Add(this.lblAuthor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblAuthor;
		private System.Windows.Forms.Label lblChangeList;
		private System.Windows.Forms.RichTextBox rtbChangeList;
	}
}