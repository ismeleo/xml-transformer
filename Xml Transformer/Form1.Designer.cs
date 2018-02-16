namespace Xml_Transformer
{
	partial class Form1
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.ssStatusBar = new System.Windows.Forms.StatusStrip();
			this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.tspbProgress = new System.Windows.Forms.ToolStripProgressBar();
			this.tscContainer = new System.Windows.Forms.ToolStripContainer();
			this.tlpLayout = new System.Windows.Forms.TableLayoutPanel();
			this.dgvXsltFiles = new System.Windows.Forms.DataGridView();
			this.XsltFileFolder = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.XsltFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OutputPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.XsltRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnBrowseXmlFile = new System.Windows.Forms.Button();
			this.btnClearAllXmlFiles = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbSingle = new System.Windows.Forms.RadioButton();
			this.rbMerged = new System.Windows.Forms.RadioButton();
			this.cbSaveMergedXml = new System.Windows.Forms.CheckBox();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnBrowseXslt = new System.Windows.Forms.Button();
			this.btnTransform = new System.Windows.Forms.Button();
			this.btnClearAllXsltFiles = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.dgvXmlFiles = new System.Windows.Forms.DataGridView();
			this.XmlFileFolder = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.XmlFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.XmlRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblTotalXmlFiles = new System.Windows.Forms.Label();
			this.dgvSchemaFiles = new System.Windows.Forms.DataGridView();
			this.SchemaFileFolder = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SchemaFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SchemaRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnBrowseSchema = new System.Windows.Forms.Button();
			this.btnValidate = new System.Windows.Forms.Button();
			this.btnClearAllSchemaFiles = new System.Windows.Forms.Button();
			this.msMenuBar = new System.Windows.Forms.MenuStrip();
			this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.ssStatusBar.SuspendLayout();
			this.tscContainer.ContentPanel.SuspendLayout();
			this.tscContainer.TopToolStripPanel.SuspendLayout();
			this.tscContainer.SuspendLayout();
			this.tlpLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvXsltFiles)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvXmlFiles)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSchemaFiles)).BeginInit();
			this.flowLayoutPanel3.SuspendLayout();
			this.msMenuBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// ssStatusBar
			// 
			this.ssStatusBar.BackColor = System.Drawing.SystemColors.Control;
			this.ssStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus,
            this.tspbProgress});
			this.ssStatusBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.ssStatusBar.Location = new System.Drawing.Point(0, 496);
			this.ssStatusBar.Name = "ssStatusBar";
			this.ssStatusBar.Size = new System.Drawing.Size(738, 23);
			this.ssStatusBar.TabIndex = 3;
			// 
			// tsslStatus
			// 
			this.tsslStatus.Name = "tsslStatus";
			this.tsslStatus.Size = new System.Drawing.Size(39, 18);
			this.tsslStatus.Text = "Ready";
			// 
			// tspbProgress
			// 
			this.tspbProgress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.tspbProgress.Name = "tspbProgress";
			this.tspbProgress.Size = new System.Drawing.Size(300, 17);
			this.tspbProgress.Step = 1;
			// 
			// tscContainer
			// 
			// 
			// tscContainer.ContentPanel
			// 
			this.tscContainer.ContentPanel.Controls.Add(this.tlpLayout);
			this.tscContainer.ContentPanel.Size = new System.Drawing.Size(738, 472);
			this.tscContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tscContainer.Location = new System.Drawing.Point(0, 0);
			this.tscContainer.Name = "tscContainer";
			this.tscContainer.Size = new System.Drawing.Size(738, 496);
			this.tscContainer.TabIndex = 6;
			this.tscContainer.Text = "toolStripContainer1";
			// 
			// tscContainer.TopToolStripPanel
			// 
			this.tscContainer.TopToolStripPanel.Controls.Add(this.msMenuBar);
			// 
			// tlpLayout
			// 
			this.tlpLayout.ColumnCount = 2;
			this.tlpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
			this.tlpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpLayout.Controls.Add(this.dgvXsltFiles, 1, 1);
			this.tlpLayout.Controls.Add(this.flowLayoutPanel1, 0, 0);
			this.tlpLayout.Controls.Add(this.flowLayoutPanel2, 0, 1);
			this.tlpLayout.Controls.Add(this.tableLayoutPanel1, 1, 0);
			this.tlpLayout.Controls.Add(this.dgvSchemaFiles, 1, 2);
			this.tlpLayout.Controls.Add(this.flowLayoutPanel3, 0, 2);
			this.tlpLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpLayout.Location = new System.Drawing.Point(0, 0);
			this.tlpLayout.Name = "tlpLayout";
			this.tlpLayout.RowCount = 3;
			this.tlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
			this.tlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
			this.tlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpLayout.Size = new System.Drawing.Size(738, 472);
			this.tlpLayout.TabIndex = 0;
			// 
			// dgvXsltFiles
			// 
			this.dgvXsltFiles.AllowUserToAddRows = false;
			this.dgvXsltFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvXsltFiles.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvXsltFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvXsltFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvXsltFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.XsltFileFolder,
            this.XsltFileName,
            this.OutputPath,
            this.XsltRemark});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvXsltFiles.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvXsltFiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvXsltFiles.Location = new System.Drawing.Point(146, 235);
			this.dgvXsltFiles.Name = "dgvXsltFiles";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvXsltFiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvXsltFiles.RowHeadersWidth = 25;
			this.dgvXsltFiles.RowTemplate.Height = 23;
			this.dgvXsltFiles.Size = new System.Drawing.Size(589, 114);
			this.dgvXsltFiles.TabIndex = 5;
			this.dgvXsltFiles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXsltFiles_CellDoubleClick);
			// 
			// XsltFileFolder
			// 
			this.XsltFileFolder.HeaderText = "File Folder";
			this.XsltFileFolder.Name = "XsltFileFolder";
			this.XsltFileFolder.ReadOnly = true;
			this.XsltFileFolder.Width = 80;
			// 
			// XsltFileName
			// 
			this.XsltFileName.HeaderText = "File Name";
			this.XsltFileName.Name = "XsltFileName";
			this.XsltFileName.ReadOnly = true;
			this.XsltFileName.Width = 79;
			// 
			// OutputPath
			// 
			this.OutputPath.HeaderText = "Output Path";
			this.OutputPath.Name = "OutputPath";
			this.OutputPath.ReadOnly = true;
			this.OutputPath.Width = 89;
			// 
			// XsltRemark
			// 
			this.XsltRemark.HeaderText = "Remark";
			this.XsltRemark.Name = "XsltRemark";
			this.XsltRemark.ReadOnly = true;
			this.XsltRemark.Width = 69;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.btnBrowseXmlFile);
			this.flowLayoutPanel1.Controls.Add(this.btnClearAllXmlFiles);
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this.panel1);
			this.flowLayoutPanel1.Controls.Add(this.cbSaveMergedXml);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(143, 232);
			this.flowLayoutPanel1.TabIndex = 6;
			// 
			// btnBrowseXmlFile
			// 
			this.btnBrowseXmlFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowseXmlFile.Location = new System.Drawing.Point(3, 3);
			this.btnBrowseXmlFile.Name = "btnBrowseXmlFile";
			this.btnBrowseXmlFile.Size = new System.Drawing.Size(137, 25);
			this.btnBrowseXmlFile.TabIndex = 2;
			this.btnBrowseXmlFile.Text = "Add XML File(s)";
			this.btnBrowseXmlFile.UseVisualStyleBackColor = true;
			this.btnBrowseXmlFile.Click += new System.EventHandler(this.btnBrowseXmlFile_Click);
			// 
			// btnClearAllXmlFiles
			// 
			this.btnClearAllXmlFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClearAllXmlFiles.Location = new System.Drawing.Point(3, 34);
			this.btnClearAllXmlFiles.Name = "btnClearAllXmlFiles";
			this.btnClearAllXmlFiles.Size = new System.Drawing.Size(137, 25);
			this.btnClearAllXmlFiles.TabIndex = 3;
			this.btnClearAllXmlFiles.Text = "Clear All";
			this.btnClearAllXmlFiles.UseVisualStyleBackColor = true;
			this.btnClearAllXmlFiles.Click += new System.EventHandler(this.btnClearAllXmlFiles_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Transform Mode:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rbSingle);
			this.panel1.Controls.Add(this.rbMerged);
			this.panel1.Location = new System.Drawing.Point(0, 75);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(143, 24);
			this.panel1.TabIndex = 6;
			// 
			// rbSingle
			// 
			this.rbSingle.AutoSize = true;
			this.rbSingle.Location = new System.Drawing.Point(70, 2);
			this.rbSingle.Margin = new System.Windows.Forms.Padding(0);
			this.rbSingle.Name = "rbSingle";
			this.rbSingle.Size = new System.Drawing.Size(54, 17);
			this.rbSingle.TabIndex = 3;
			this.rbSingle.Text = "Single";
			this.rbSingle.UseVisualStyleBackColor = true;
			this.rbSingle.CheckedChanged += new System.EventHandler(this.rbSingle_CheckedChanged);
			// 
			// rbMerged
			// 
			this.rbMerged.AutoSize = true;
			this.rbMerged.Checked = true;
			this.rbMerged.Location = new System.Drawing.Point(5, 2);
			this.rbMerged.Margin = new System.Windows.Forms.Padding(0);
			this.rbMerged.Name = "rbMerged";
			this.rbMerged.Size = new System.Drawing.Size(61, 17);
			this.rbMerged.TabIndex = 2;
			this.rbMerged.TabStop = true;
			this.rbMerged.Text = "Merged";
			this.rbMerged.UseVisualStyleBackColor = true;
			this.rbMerged.CheckedChanged += new System.EventHandler(this.rbMerged_CheckedChanged);
			// 
			// cbSaveMergedXml
			// 
			this.cbSaveMergedXml.AutoSize = true;
			this.cbSaveMergedXml.Location = new System.Drawing.Point(3, 102);
			this.cbSaveMergedXml.Name = "cbSaveMergedXml";
			this.cbSaveMergedXml.Size = new System.Drawing.Size(115, 17);
			this.cbSaveMergedXml.TabIndex = 7;
			this.cbSaveMergedXml.Text = "Save Merged XML";
			this.cbSaveMergedXml.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.btnBrowseXslt);
			this.flowLayoutPanel2.Controls.Add(this.btnTransform);
			this.flowLayoutPanel2.Controls.Add(this.btnClearAllXsltFiles);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 232);
			this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(143, 120);
			this.flowLayoutPanel2.TabIndex = 7;
			// 
			// btnBrowseXslt
			// 
			this.btnBrowseXslt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowseXslt.Location = new System.Drawing.Point(3, 3);
			this.btnBrowseXslt.Name = "btnBrowseXslt";
			this.btnBrowseXslt.Size = new System.Drawing.Size(137, 25);
			this.btnBrowseXslt.TabIndex = 3;
			this.btnBrowseXslt.Text = "Add XSLT File(s)";
			this.btnBrowseXslt.UseVisualStyleBackColor = true;
			this.btnBrowseXslt.Click += new System.EventHandler(this.btnBrowseXslt_Click);
			// 
			// btnTransform
			// 
			this.btnTransform.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnTransform.Location = new System.Drawing.Point(3, 34);
			this.btnTransform.Name = "btnTransform";
			this.btnTransform.Size = new System.Drawing.Size(137, 25);
			this.btnTransform.TabIndex = 8;
			this.btnTransform.Text = "Transform";
			this.btnTransform.UseVisualStyleBackColor = true;
			this.btnTransform.Click += new System.EventHandler(this.btnTransform_Click);
			// 
			// btnClearAllXsltFiles
			// 
			this.btnClearAllXsltFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClearAllXsltFiles.Location = new System.Drawing.Point(3, 65);
			this.btnClearAllXsltFiles.Name = "btnClearAllXsltFiles";
			this.btnClearAllXsltFiles.Size = new System.Drawing.Size(137, 25);
			this.btnClearAllXsltFiles.TabIndex = 4;
			this.btnClearAllXsltFiles.Text = "Clear All";
			this.btnClearAllXsltFiles.UseVisualStyleBackColor = true;
			this.btnClearAllXsltFiles.Click += new System.EventHandler(this.btnClearAllXsltFiles_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.dgvXmlFiles, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblTotalXmlFiles, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(143, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(595, 232);
			this.tableLayoutPanel1.TabIndex = 9;
			// 
			// dgvXmlFiles
			// 
			this.dgvXmlFiles.AllowUserToAddRows = false;
			this.dgvXmlFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvXmlFiles.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvXmlFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvXmlFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvXmlFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.XmlFileFolder,
            this.XmlFileName,
            this.XmlRemark});
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvXmlFiles.DefaultCellStyle = dataGridViewCellStyle5;
			this.dgvXmlFiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvXmlFiles.Location = new System.Drawing.Point(3, 3);
			this.dgvXmlFiles.Name = "dgvXmlFiles";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvXmlFiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvXmlFiles.RowHeadersWidth = 25;
			this.dgvXmlFiles.RowTemplate.Height = 23;
			this.dgvXmlFiles.Size = new System.Drawing.Size(589, 206);
			this.dgvXmlFiles.TabIndex = 4;
			this.dgvXmlFiles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXmlFiles_CellDoubleClick);
			this.dgvXmlFiles.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvXmlFiles_RowsAdded);
			this.dgvXmlFiles.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvXmlFiles_RowsRemoved);
			// 
			// XmlFileFolder
			// 
			this.XmlFileFolder.HeaderText = "File Folder";
			this.XmlFileFolder.Name = "XmlFileFolder";
			this.XmlFileFolder.ReadOnly = true;
			this.XmlFileFolder.Width = 80;
			// 
			// XmlFileName
			// 
			this.XmlFileName.HeaderText = "File Name";
			this.XmlFileName.Name = "XmlFileName";
			this.XmlFileName.ReadOnly = true;
			this.XmlFileName.Width = 79;
			// 
			// XmlRemark
			// 
			this.XmlRemark.HeaderText = "Remark";
			this.XmlRemark.Name = "XmlRemark";
			this.XmlRemark.ReadOnly = true;
			this.XmlRemark.Width = 69;
			// 
			// lblTotalXmlFiles
			// 
			this.lblTotalXmlFiles.AutoSize = true;
			this.lblTotalXmlFiles.Location = new System.Drawing.Point(3, 212);
			this.lblTotalXmlFiles.Name = "lblTotalXmlFiles";
			this.lblTotalXmlFiles.Size = new System.Drawing.Size(67, 13);
			this.lblTotalXmlFiles.TabIndex = 5;
			this.lblTotalXmlFiles.Text = "Total Files: 0";
			// 
			// dgvSchemaFiles
			// 
			this.dgvSchemaFiles.AllowUserToAddRows = false;
			this.dgvSchemaFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvSchemaFiles.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSchemaFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvSchemaFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSchemaFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SchemaFileFolder,
            this.SchemaFileName,
            this.SchemaRemark});
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSchemaFiles.DefaultCellStyle = dataGridViewCellStyle8;
			this.dgvSchemaFiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvSchemaFiles.Location = new System.Drawing.Point(146, 355);
			this.dgvSchemaFiles.Name = "dgvSchemaFiles";
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSchemaFiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dgvSchemaFiles.RowHeadersWidth = 25;
			this.dgvSchemaFiles.RowTemplate.Height = 23;
			this.dgvSchemaFiles.Size = new System.Drawing.Size(589, 114);
			this.dgvSchemaFiles.TabIndex = 11;
			this.dgvSchemaFiles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchemaFiles_CellDoubleClick);
			// 
			// SchemaFileFolder
			// 
			this.SchemaFileFolder.HeaderText = "File Folder";
			this.SchemaFileFolder.Name = "SchemaFileFolder";
			this.SchemaFileFolder.ReadOnly = true;
			this.SchemaFileFolder.Width = 80;
			// 
			// SchemaFileName
			// 
			this.SchemaFileName.HeaderText = "File Name";
			this.SchemaFileName.Name = "SchemaFileName";
			this.SchemaFileName.ReadOnly = true;
			this.SchemaFileName.Width = 79;
			// 
			// SchemaRemark
			// 
			this.SchemaRemark.HeaderText = "Remark";
			this.SchemaRemark.Name = "SchemaRemark";
			this.SchemaRemark.ReadOnly = true;
			this.SchemaRemark.Width = 69;
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.Controls.Add(this.btnBrowseSchema);
			this.flowLayoutPanel3.Controls.Add(this.btnValidate);
			this.flowLayoutPanel3.Controls.Add(this.btnClearAllSchemaFiles);
			this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 352);
			this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(143, 120);
			this.flowLayoutPanel3.TabIndex = 12;
			// 
			// btnBrowseSchema
			// 
			this.btnBrowseSchema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowseSchema.Location = new System.Drawing.Point(3, 3);
			this.btnBrowseSchema.Name = "btnBrowseSchema";
			this.btnBrowseSchema.Size = new System.Drawing.Size(137, 25);
			this.btnBrowseSchema.TabIndex = 3;
			this.btnBrowseSchema.Text = "Add XSD File(s)";
			this.btnBrowseSchema.UseVisualStyleBackColor = true;
			this.btnBrowseSchema.Click += new System.EventHandler(this.btnBrowseSchema_Click);
			// 
			// btnValidate
			// 
			this.btnValidate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnValidate.Location = new System.Drawing.Point(3, 34);
			this.btnValidate.Name = "btnValidate";
			this.btnValidate.Size = new System.Drawing.Size(137, 25);
			this.btnValidate.TabIndex = 3;
			this.btnValidate.Text = "Validate";
			this.btnValidate.UseVisualStyleBackColor = true;
			this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
			// 
			// btnClearAllSchemaFiles
			// 
			this.btnClearAllSchemaFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClearAllSchemaFiles.Location = new System.Drawing.Point(3, 65);
			this.btnClearAllSchemaFiles.Name = "btnClearAllSchemaFiles";
			this.btnClearAllSchemaFiles.Size = new System.Drawing.Size(137, 25);
			this.btnClearAllSchemaFiles.TabIndex = 4;
			this.btnClearAllSchemaFiles.Text = "Clear All";
			this.btnClearAllSchemaFiles.UseVisualStyleBackColor = true;
			this.btnClearAllSchemaFiles.Click += new System.EventHandler(this.btnClearAllSchemaFiles_Click);
			// 
			// msMenuBar
			// 
			this.msMenuBar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.msMenuBar.Dock = System.Windows.Forms.DockStyle.None;
			this.msMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.aboutToolStripMenuItem});
			this.msMenuBar.Location = new System.Drawing.Point(0, 0);
			this.msMenuBar.Name = "msMenuBar";
			this.msMenuBar.Size = new System.Drawing.Size(738, 24);
			this.msMenuBar.TabIndex = 6;
			// 
			// tsmiFile
			// 
			this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
			this.tsmiFile.Name = "tsmiFile";
			this.tsmiFile.Size = new System.Drawing.Size(37, 20);
			this.tsmiFile.Text = "&File";
			// 
			// tsmiExit
			// 
			this.tsmiExit.Name = "tsmiExit";
			this.tsmiExit.Size = new System.Drawing.Size(92, 22);
			this.tsmiExit.Text = "E&xit";
			this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.aboutToolStripMenuItem.Text = "Help";
			// 
			// tsmiAbout
			// 
			this.tsmiAbout.Name = "tsmiAbout";
			this.tsmiAbout.Size = new System.Drawing.Size(152, 22);
			this.tsmiAbout.Text = "&About";
			this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(738, 519);
			this.Controls.Add(this.tscContainer);
			this.Controls.Add(this.ssStatusBar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "XML Transformer";
			this.ssStatusBar.ResumeLayout(false);
			this.ssStatusBar.PerformLayout();
			this.tscContainer.ContentPanel.ResumeLayout(false);
			this.tscContainer.TopToolStripPanel.ResumeLayout(false);
			this.tscContainer.TopToolStripPanel.PerformLayout();
			this.tscContainer.ResumeLayout(false);
			this.tscContainer.PerformLayout();
			this.tlpLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvXsltFiles)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvXmlFiles)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSchemaFiles)).EndInit();
			this.flowLayoutPanel3.ResumeLayout(false);
			this.msMenuBar.ResumeLayout(false);
			this.msMenuBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip ssStatusBar;
		private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
		private System.Windows.Forms.ToolStripContainer tscContainer;
		private System.Windows.Forms.MenuStrip msMenuBar;
		private System.Windows.Forms.ToolStripMenuItem tsmiFile;
		private System.Windows.Forms.ToolStripMenuItem tsmiExit;
		private System.Windows.Forms.TableLayoutPanel tlpLayout;
		private System.Windows.Forms.ToolStripProgressBar tspbProgress;
		private System.Windows.Forms.DataGridView dgvXmlFiles;
		private System.Windows.Forms.DataGridView dgvXsltFiles;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button btnBrowseXmlFile;
		private System.Windows.Forms.Button btnClearAllXmlFiles;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.Button btnBrowseXslt;
		private System.Windows.Forms.Button btnClearAllXsltFiles;
		private System.Windows.Forms.DataGridViewTextBoxColumn XmlFileFolder;
		private System.Windows.Forms.DataGridViewTextBoxColumn XmlFileName;
		private System.Windows.Forms.DataGridViewTextBoxColumn XmlRemark;
		private System.Windows.Forms.DataGridViewTextBoxColumn XsltFileFolder;
		private System.Windows.Forms.DataGridViewTextBoxColumn XsltFileName;
		private System.Windows.Forms.DataGridViewTextBoxColumn OutputPath;
		private System.Windows.Forms.DataGridViewTextBoxColumn XsltRemark;
		private System.Windows.Forms.Button btnTransform;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rbSingle;
		private System.Windows.Forms.RadioButton rbMerged;
		private System.Windows.Forms.CheckBox cbSaveMergedXml;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lblTotalXmlFiles;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
		private System.Windows.Forms.DataGridView dgvSchemaFiles;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.Button btnBrowseSchema;
		private System.Windows.Forms.Button btnClearAllSchemaFiles;
		private System.Windows.Forms.DataGridViewTextBoxColumn SchemaFileFolder;
		private System.Windows.Forms.DataGridViewTextBoxColumn SchemaFileName;
		private System.Windows.Forms.DataGridViewTextBoxColumn SchemaRemark;
		private System.Windows.Forms.Button btnValidate;
	}
}

