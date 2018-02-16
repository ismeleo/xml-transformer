using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using Saxon.Api;
using System.Diagnostics;
using System.Reflection;

namespace Xml_Transformer {
	public partial class Form1 : Form {
		bool stopThread = false;
		static GeneralMessageForm generalValidationMsgForm = new GeneralMessageForm();
		static RichTextBox msgBox = (RichTextBox) generalValidationMsgForm.Controls.Find("rtbSchemaValidationMsg", true)[0];

		public Form1() {
			InitializeComponent();

			Init();
		}

		private void Init() {
			//SetDefaultValue();

			this.MinimumSize = new Size(560, 400);

			this.Text = string.Format("XML Transformer (v{0})",
				FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion);

			dgvXmlFiles.AllowDrop = true;
			dgvXmlFiles.DragEnter += dgvFiles_DragEnter;
			dgvXmlFiles.DragDrop += dgvXmlFiles_DragDrop;

			dgvXsltFiles.AllowDrop = true;
			dgvXsltFiles.DragEnter += dgvFiles_DragEnter;
			dgvXsltFiles.DragDrop += dgvXsltFiles_DragDrop;

			dgvSchemaFiles.AllowDrop = true;
			dgvSchemaFiles.DragEnter += dgvFiles_DragEnter;
			dgvSchemaFiles.DragDrop += dgvSchemaFiles_DragDrop;
		}

		private void dgvXmlFiles_DragDrop(object sender, DragEventArgs e) {
			var list = (string[])e.Data.GetData(DataFormats.FileDrop, false);

			foreach (var f in list) {
				var attr = File.GetAttributes(f);
				if ((attr & FileAttributes.Directory) == FileAttributes.Directory) {	// folder
					foreach (var file in GetFiles(f, new[] { ".xml" })) {
						switch (Path.GetExtension(file).ToLower()) {
							case ".xml":
								AddXmlFile(file);
								break;
						}
					}
				}
				else {	// file
					switch (Path.GetExtension(f).ToLower()) {
						case ".xml":
							AddXmlFile(f);
							break;
					}
				}
			}
		}

		private void dgvXsltFiles_DragDrop(object sender, DragEventArgs e) {
			var list = (string[])e.Data.GetData(DataFormats.FileDrop, false);

			foreach (var f in list) {
				var attr = File.GetAttributes(f);
				if ((attr & FileAttributes.Directory) == FileAttributes.Directory) {	// folder
					foreach (var file in GetFiles(f, new[] { ".xsl", ".xslt" })) {
						switch (Path.GetExtension(file).ToLower()) {
							case ".xsl":
							case ".xslt":
								AddXsltFile(file);
								break;
						}
					}
				}
				else {	// file
					switch (Path.GetExtension(f).ToLower()) {
						case ".xsl":
						case ".xslt":
							AddXsltFile(f);
							break;
					}
				}
			}
		}

		private void dgvSchemaFiles_DragDrop(object sender, DragEventArgs e) {
			var list = (string[])e.Data.GetData(DataFormats.FileDrop, false);

			foreach (var f in list) {
				var attr = File.GetAttributes(f);
				if ((attr & FileAttributes.Directory) == FileAttributes.Directory) {	// folder
					foreach (var file in GetFiles(f, new[] { ".xsd", ".dtd" })) {
						switch (Path.GetExtension(file).ToLower()) {
							case ".xsd":
							case ".dtd":
								AddSchemaFile(file);
								break;
						}
					}
				}
				else {	// file
					switch (Path.GetExtension(f).ToLower()) {
						case ".xsd":
						case ".dtd":
							AddSchemaFile(f);
							break;
					}
				}
			}
		}

		private void dgvFiles_DragEnter(object sender, DragEventArgs e) {
			e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop)
				? DragDropEffects.Copy
				: DragDropEffects.None;
		}

		private IEnumerable<string> GetFiles(string folderPath, string[] exts) {
			var list = new List<string>();
			var folder = new DirectoryInfo(folderPath);
			foreach (var fi in folder.GetFiles()) {
				foreach (var ext in exts) {
					if (Path.GetExtension(fi.FullName).ToLower() == ext.ToLower()) {
						list.Add(fi.FullName);
					}
				}
			}

			foreach (var fi in folder.GetDirectories()) {
				foreach (var file in GetFiles(fi.FullName, exts)) {
					list.Add(file);
				}
			}

			return list;
		}

		private void tsmiExit_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void AddXmlFile(string xmlPath) {
			dgvXmlFiles.Rows.Add(new Object[] { Path.GetDirectoryName(xmlPath).TrimEnd('\\') + "\\", Path.GetFileName(xmlPath) });
		}

		private void AddXsltFile(string xsltPath) {
			dgvXsltFiles.Rows.Add(new Object[] { Path.GetDirectoryName(xsltPath).TrimEnd('\\') + "\\", Path.GetFileName(xsltPath) });
		}

		private void AddSchemaFile(string schemaPath) {
			dgvSchemaFiles.Rows.Add(new Object[] { Path.GetDirectoryName(schemaPath).TrimEnd('\\') + "\\", Path.GetFileName(schemaPath) });
		}

		private void btnBrowseXmlFile_Click(object sender, EventArgs e) {
			var dlg = new OpenFileDialog {
				Title = "XML File/Folder Path",
				Filter = "XML|*.xml",
				Multiselect = true
			};
			if (dlg.ShowDialog() != DialogResult.OK) { return; }
			foreach (var filePath in dlg.FileNames) {
				AddXmlFile(filePath);
			}
		}

		private void btnBrowseXslt_Click(object sender, EventArgs e) {
			var dlg = new OpenFileDialog {
				Title = "XSLT File",
				Filter = "XSLT|*.xsl;*.xslt",
				Multiselect = true
			};
			if (dlg.ShowDialog() != DialogResult.OK) { return; }
			foreach (var filePath in dlg.FileNames) {
				AddXsltFile(filePath);
			}
		}

		private void btnBrowseSchema_Click(object sender, EventArgs e) {
			var dlg = new OpenFileDialog {
				Title = "Schema File",
				Filter = "XSD/DTD|*.xsd;*.dtd",
				Multiselect = true
			};
			if (dlg.ShowDialog() != DialogResult.OK) { return; }
			foreach (var filePath in dlg.FileNames) {
				AddSchemaFile(filePath);
			}
		}

		private void dgvXmlFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
			if (e.ColumnIndex != dgvXmlFiles.Columns["XmlFileFolder"].Index &&
				e.ColumnIndex != dgvXmlFiles.Columns["XmlFileName"].Index) {
				return;
			}

			var dlg = new OpenFileDialog {
				Title = "XML File",
				Filter = "XML|*.xml"
			};
			if (dlg.ShowDialog() != DialogResult.OK) { return; }
			dgvXmlFiles.Rows[e.RowIndex].Cells["XmlFileFolder"].Value = Path.GetDirectoryName(dlg.FileName) + "\\";
			dgvXmlFiles.Rows[e.RowIndex].Cells["XmlFileName"].Value = Path.GetFileName(dlg.FileName);
		}

		private void dgvXsltFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
			if (e.ColumnIndex == dgvXsltFiles.Columns["XsltFileFolder"].Index ||
				e.ColumnIndex == dgvXsltFiles.Columns["XsltFileName"].Index) {
				var dlg = new OpenFileDialog {
					Title = "XSLT File",
					Filter = "XSLT|*.xsl;*.xslt"
				};
				if (dlg.ShowDialog() == DialogResult.OK) {
					dgvXsltFiles.Rows[e.RowIndex].Cells["XsltFileFolder"].Value = Path.GetDirectoryName(dlg.FileName) + "\\";
					dgvXsltFiles.Rows[e.RowIndex].Cells["XsltFileName"].Value = Path.GetFileName(dlg.FileName);
				}
			}

			if (e.ColumnIndex == dgvXsltFiles.Columns["OutputPath"].Index) {
				var dlg = new SaveFileDialog {
					Title = "Output File",
					Filter = "*.*|*.*"
				};
				if (dlg.ShowDialog() == DialogResult.OK) {
					dgvXsltFiles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = dlg.FileName;
				}
			}
		}

		private void dgvSchemaFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
			if (e.ColumnIndex == dgvSchemaFiles.Columns["SchemaFileFolder"].Index ||
				e.ColumnIndex == dgvSchemaFiles.Columns["SchemaFileName"].Index) {
				var dlg = new OpenFileDialog {
					Title = "XSD File",
					Filter = "XSD|*.xsd"
				};
				if (dlg.ShowDialog() != DialogResult.OK) {
					return;
				}
				dgvSchemaFiles.Rows[e.RowIndex].Cells["SchemaFileFolder"].Value = Path.GetDirectoryName(dlg.FileName) + "\\";
				dgvSchemaFiles.Rows[e.RowIndex].Cells["SchemaFileName"].Value = Path.GetFileName(dlg.FileName);
			}
			else if (e.ColumnIndex == dgvSchemaFiles.Columns["SchemaRemark"].Index) {
				if (dgvSchemaFiles.Rows[e.RowIndex].Cells["SchemaRemark"].Value.ToString() != "Double click to check the error.") {
					return;
				}
				try {
					generalValidationMsgForm.Text = "Schema Validation Message";
					msgBox.Text = _allFilesValidationMessage[e.RowIndex].ToString();
					msgBox.Select(0, 0);
					generalValidationMsgForm.ShowDialog();
				}
				catch (Exception) { }
			}
		}

		private void btnTransform_Click(object sender, EventArgs e) {
			if (btnTransform.Text == "Transform") {
				stopThread = false;

				if (dgvXmlFiles.Rows.Count == 0) {
					WarningMsg("Please add XML file(s) to be transformed");
					return;
				}

				if (dgvXsltFiles.Rows.Count == 0) {
					WarningMsg("Please add XSLT file(s) to transform the XML file(s)");
					return;
				}

				if (!ValidatePath()) {
					WarningMsg("File path invalid, please check the remark for detail.");
					return;
				}

				//new Task(new Action(Transform)).Start();
				new Thread(Transform).Start();
			}
			else {
				tsslStatus.Text = "Stopping...";
				stopThread = true;
			}
		}


		private void Transform() {
			CheckForIllegalCrossThreadCalls = false;

			var transformResult = true;

			btnTransform.Text = "Stop";

			tspbProgress.Minimum = 0;
			tspbProgress.Maximum = dgvXmlFiles.Rows.Count + 1;
			tspbProgress.Value = 0;

			if (rbMerged.Checked) {
				transformResult = TransformMerged();
			}
			else if (rbSingle.Checked) {
				transformResult = TransformSingle();
			}

			tspbProgress.Value = tspbProgress.Maximum;

			btnTransform.Text = "Transform";

			tsslStatus.Text = transformResult ? "Done" : "Cancelled";

			GC.Collect();
		}

		private bool TransformMerged() {
			var xml = new XmlDocument();
			var xml2 = new XmlDocument();

			var counter = 0;

			try {
				foreach (DataGridViewRow row in dgvXmlFiles.Rows) {
					var xmlFilePath = row.Cells["XmlFileFolder"].Value.ToString() + row.Cells["XmlFileName"].Value.ToString();

					if (stopThread) {
						tsslStatus.Text = "Stopped";
						tspbProgress.Value = 0;
						btnTransform.Text = "Transform";
						return false;
					}

					tsslStatus.Text = String.Format("Merging... ({0}/{1})", counter + 1, dgvXmlFiles.Rows.Count);
					tspbProgress.Value = counter + 1;

					if (++counter == 1) {
						xml.Load(xmlFilePath);
					}
					else {
						xml2.Load(xmlFilePath);
						foreach (XmlNode node in xml2.DocumentElement.ChildNodes) {
							xml.DocumentElement.AppendChild(xml.ImportNode(node, true));
						}
					}
				}
			}
			catch (Exception e) {
				dgvXmlFiles.Rows[counter - 1].Cells["XmlRemark"].Value = e.GetBaseException().Message;
				ErrorMsg(e.GetBaseException().Message);
				return false;
			}

			// save the merged xml
			if (cbSaveMergedXml.Enabled && cbSaveMergedXml.Checked) {
				tsslStatus.Text = "Saving the merged XML...";
				xml.Save(Environment.CurrentDirectory + "\\Merged_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xml");
			}

			var finalXml = xml.OuterXml;
			counter = 0;

			try {
				foreach (DataGridViewRow row in dgvXsltFiles.Rows) {
					tsslStatus.Text = String.Format("Transforming... {0}/{1}", ++counter, dgvXsltFiles.Rows.Count);
					var xsltFilePath = row.Cells["XsltFileFolder"].Value.ToString() + row.Cells["XsltFileName"].Value.ToString();
					var outputPath = row.Cells["OutputPath"].Value.ToString();
					TransformXmlV2(finalXml, xsltFilePath, outputPath);
				}
			}
			catch (Exception e) {
				dgvXsltFiles.Rows[counter - 1].Cells["XsltRemark"].Value = e.GetBaseException().Message;
				ErrorMsg(e.GetBaseException().Message);
				return false;
			}

			return true;
		}

		private bool TransformSingle() {
			var xml = new XmlDocument();

			var counter = 0;
			var counter2 = 0;

			foreach (DataGridViewRow rowXml in dgvXmlFiles.Rows) {
				var xmlFilePath = rowXml.Cells["XmlFileFolder"].Value.ToString() + rowXml.Cells["XmlFileName"].Value.ToString();

				if (stopThread) {
					tsslStatus.Text = "Stopped";
					tspbProgress.Value = 0;
					btnTransform.Text = "Transform";
					return false;
				}

				tspbProgress.Value = ++counter;
				tsslStatus.Text = String.Format("Transforming... ({0}/{1})", counter, dgvXmlFiles.Rows.Count);

				try {
					xml.Load(xmlFilePath);
				}
				catch (Exception e) {
					dgvXmlFiles.Rows[counter - 1].Cells["XmlRemark"].Value = e.GetBaseException().Message;
					ErrorMsg(e.GetBaseException().Message);
					return false;
				}

				foreach (DataGridViewRow rowXslt in dgvXsltFiles.Rows) {
					++counter2;

					var xsltFilePath = rowXslt.Cells["XsltFileFolder"].Value.ToString() + rowXslt.Cells["XsltFileName"].Value.ToString();
					var outputPath = rowXslt.Cells["OutputPath"].Value.ToString();

					try {
						TransformXmlV2(xml.OuterXml, xsltFilePath,
							String.Format("{0}\\{1} ({2}){3}",
							Path.GetDirectoryName(outputPath),
							Path.GetFileNameWithoutExtension(outputPath),
							Path.GetFileNameWithoutExtension(xmlFilePath),
							Path.GetExtension(outputPath)));
					}
					catch (Exception e) {
						dgvXsltFiles.Rows[counter2 - 1].Cells["XsltRemark"].Value = e.GetBaseException().Message;
						ErrorMsg(e.GetBaseException().Message);
						return false;
					}
				}
			}


			return true;
		}

		/// <summary>
		/// Xslt Version 2.0 Transformation
		/// </summary>
		public void TransformXmlV2(string xmlContent, string xsltPath, string outputPath) {
			/*
			var xml = new XmlDocument();
			xml.LoadXml(xmlContent);
			var dest = new TextWriterDestination(XmlWriter.Create(outputPath));
			var processor = new Processor();
			var xr = XmlReader.Create(xsltPath);

			try {
				var transformer = processor.NewXsltCompiler().Compile(xr).Load();
				transformer.InitialContextNode = processor.NewDocumentBuilder().Build(xml);
				transformer.Run(dest);
			}
			finally {
				try {
					xr.Close();
					dest.Close();
				}
				catch { }
			}
			*/

			Random r = new Random();
			int rInt = r.Next(0, 100);
			var tempFile = @"c:\windows\temp\xt_" + new DateTime().ToString("yyyyMMddHHmmss") + rInt;
			File.WriteAllText(tempFile, xmlContent, Encoding.UTF8);

			var input = new FileInfo(tempFile);
			var xslt = new FileInfo(xsltPath);
			var output = new FileInfo(outputPath);

			// Compile stylesheet
			var processor = new Processor();
			var compiler = processor.NewXsltCompiler();
			var executable = compiler.Compile(new Uri(xslt.FullName));

			// Do transformation to a destination
			var destination = new DomDestination();
			
			using (var inputStream = input.OpenRead()) {
				var transformer = executable.Load();
				transformer.SetInputStream(inputStream, new Uri(input.DirectoryName));
				transformer.Run(destination);
			}

			// Save result to a file (or whatever else you wanna do)
			destination.XmlDocument.Save(output.FullName);

			if (File.Exists(tempFile)) {
				File.Delete(tempFile);
			}
		}

		private bool ValidatePath() {
			var result = true;

			foreach (DataGridViewRow row in dgvXmlFiles.Rows) {
				var filePath = row.Cells["XmlFileFolder"].Value.ToString() + row.Cells["XmlFileName"].Value.ToString();
				if (!File.Exists(filePath)) {
					row.Cells["XmlRemark"].Value = "Invalid XML file path.";
					result = false;
				}
				else {
					row.Cells["XmlRemark"].Value = "";
				}
			}

			if (btnTransform.Focused) {
				foreach (DataGridViewRow row in dgvXsltFiles.Rows) {
					var xsltFilePath = row.Cells["XsltFileFolder"].Value.ToString() + row.Cells["XsltFileName"].Value.ToString();
					var outputPath = row.Cells["OutputPath"].Value == null ? "" : row.Cells["OutputPath"].Value.ToString();

					if (!File.Exists(xsltFilePath)) {
						row.Cells["XsltRemark"].Value = "Invalid XSLT file path.";
						result = false;
					} else if (String.IsNullOrEmpty(outputPath)) {
						row.Cells["XsltRemark"].Value = "Please specify output path.";
						result = false;
					} else {
						var testConflict = false;
						foreach (DataGridViewRow row2 in dgvXsltFiles.Rows) {
							if (row == row2) {
								continue;
							}

							if ((string) row.Cells["OutputPath"].Value == (string) row2.Cells["OutputPath"].Value) {
								row.Cells["XsltRemark"].Value = "Output path conflict with row " + (row2.Index + 1) + ".";
								testConflict = true;
							}
						}

						if (testConflict) {
							return false;
						}

						if (File.Exists(outputPath)) {
							try {
								var fs = File.Open(outputPath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
								fs.Close();

								row.Cells["XsltRemark"].Value = "";
								result = true;
							} catch (IOException) {
								row.Cells["XsltRemark"].Value = "The output file is being used by another process.";
								result = false;
							}
						} else {
							row.Cells["XsltRemark"].Value = "";
							result = true;
						}
					}
				}
			}

			if (btnValidate.Focused) {
				foreach (DataGridViewRow row in dgvSchemaFiles.Rows) {
					var filePath = row.Cells["SchemaFileFolder"].Value.ToString() + row.Cells["SchemaFileName"].Value.ToString();
					if (!File.Exists(filePath)) {
						row.Cells["SchemaRemark"].Value = "Invalid Schema file path.";
						result = false;
					} else {
						row.Cells["SchemaRemark"].Value = "";
					}
				}
			}

			return result;
		}

		private void btnClearAllXmlFiles_Click(object sender, EventArgs e) {
			dgvXmlFiles.Rows.Clear();
		}

		private void btnClearAllXsltFiles_Click(object sender, EventArgs e) {
			dgvXsltFiles.Rows.Clear();
		}

		private void btnClearAllSchemaFiles_Click(object sender, EventArgs e) {
			dgvSchemaFiles.Rows.Clear();
		}

		private static void WarningMsg(string msg) {
			MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private static void ErrorMsg(string msg) {
			MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void rbSingle_CheckedChanged(object sender, EventArgs e) {
			cbSaveMergedXml.Enabled = false;
		}

		private void rbMerged_CheckedChanged(object sender, EventArgs e) {
			cbSaveMergedXml.Enabled = true;
		}

		private void dgvXmlFiles_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) {
			lblTotalXmlFiles.Text = "Total Files: " + dgvXmlFiles.RowCount;
		}

		private void dgvXmlFiles_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) {
			lblTotalXmlFiles.Text = "Total Files: " + dgvXmlFiles.RowCount;
		}

		private void tsmiAbout_Click(object sender, EventArgs e) {
			new About().ShowDialog();
		}

		private void btnValidate_Click(object sender, EventArgs e) {
			if (btnValidate.Text == "Validate") {
				stopThread = false;

				if (dgvXmlFiles.Rows.Count == 0) {
					WarningMsg("Please add XML file(s) to be validated");
					return;
				}

				if (dgvSchemaFiles.Rows.Count == 0) {
					WarningMsg("Please add XSD file(s) to validate the XML file(s)");
					return;
				}

				if (!ValidatePath()) {
					WarningMsg("File path invalid, please check the remark for detail.");
					return;
				}

				//new Task(new Action(ValidateXml)).Start();
				new Thread(ValidateXml).Start();
			}
			else {
				tsslStatus.Text = "Stopping...";
				stopThread = true;
			}
		}

		private void ValidateXml() {
			CheckForIllegalCrossThreadCalls = false;

			btnValidate.Text = "Stop";

			tspbProgress.Minimum = 0;
			tspbProgress.Maximum = (dgvXmlFiles.Rows.Count + 1) * dgvSchemaFiles.Rows.Count;
			tspbProgress.Value = 0;

			var validateResult = ValidateXmlSchema();

			tspbProgress.Value = tspbProgress.Maximum;

			btnValidate.Text = "Validate";

			tsslStatus.Text = validateResult ? "Done" : "Cancelled";

			GC.Collect();
		}

		private StringBuilder _oneFileValidationMessage;
		private StringBuilder[] _allFilesValidationMessage;

		private void ValidationEventHandler(object sender, ValidationEventArgs e) {

			switch (e.Severity) {
				case XmlSeverityType.Warning:
					_oneFileValidationMessage.AppendLine(String.Format("WARNING (Line:{0},Pos:{1}): {2}", e.Exception.LineNumber, e.Exception.LinePosition, e.Message));
					break;
				case XmlSeverityType.Error:
					_oneFileValidationMessage.AppendLine(String.Format("ERROR (Line:{0},Pos:{1}): {2}", e.Exception.LineNumber, e.Exception.LinePosition, e.Message));
					break;
			}
		}

		private bool ValidateXmlSchema() {
			_allFilesValidationMessage = new StringBuilder[dgvSchemaFiles.Rows.Count];

			foreach (DataGridViewRow schemaRow in dgvSchemaFiles.Rows) {
				schemaRow.Cells["SchemaRemark"].Value = "";
				_allFilesValidationMessage[schemaRow.Index] = new StringBuilder();

				try {
					foreach (DataGridViewRow xmlRow in dgvXmlFiles.Rows) {
						if (stopThread) {
							tsslStatus.Text = "Stopped";
							tspbProgress.Value = 0;
							btnValidate.Text = "Validate";
							return false;
						}

						var schemaPath = schemaRow.Cells["SchemaFileFolder"].Value.ToString() +
										 schemaRow.Cells["SchemaFileName"].Value.ToString();
						var xmlPath = xmlRow.Cells["XmlFileFolder"].Value.ToString() + xmlRow.Cells["XmlFileName"].Value.ToString();

						var sc = new XmlSchemaSet();
						sc.Add(null, schemaPath);
						var settings = new XmlReaderSettings {
							ValidationType = ValidationType.Schema,
							Schemas = sc
						};
						settings.ValidationEventHandler += ValidationEventHandler;

						var reader = XmlReader.Create(xmlPath, settings);

						_oneFileValidationMessage = new StringBuilder();

						// Validate the file.
						while (reader.Read()) ;

						if (!"".Equals(_oneFileValidationMessage.ToString())) {
							_allFilesValidationMessage[schemaRow.Index].AppendLine(">>> " + xmlPath);
							_allFilesValidationMessage[schemaRow.Index].AppendLine(_oneFileValidationMessage.ToString());
							_allFilesValidationMessage[schemaRow.Index].AppendLine("");
						}

						_oneFileValidationMessage = null;

						tspbProgress.Value += 1;
						tsslStatus.Text = String.Format("Validating... ({0}/{1})", tspbProgress.Value, dgvXmlFiles.Rows.Count * dgvSchemaFiles.Rows.Count);
					}

					if ("".Equals(_allFilesValidationMessage[schemaRow.Index].ToString())) {
						schemaRow.Cells["SchemaRemark"].Value = "Validation Passed";
					}
					else {
						schemaRow.Cells["SchemaRemark"].Value = "Double click to check the error.";
					}
				}
				catch (Exception ex) {
					schemaRow.Cells["SchemaRemark"].Value = ex.Message;
					WarningMsg(ex.Message);
				}
			}

			return true;
		}

		public void f() {
			var xslt = new FileInfo(@"D:\Leo\Project\dotNetProject\xml-transformer\Xml Transformer\Sample\html.xslt");
			var input = new FileInfo(@"D:\Leo\Project\dotNetProject\xml-transformer\Xml Transformer\Sample\CD.xml");
			var output = new FileInfo(@"D:\Leo\Project\dotNetProject\xml-transformer\Xml Transformer\Sample\output.html");

			// Compile stylesheet
			var processor = new Processor();
			var compiler = processor.NewXsltCompiler();
			var executable = compiler.Compile(new Uri(xslt.FullName));

			// Do transformation to a destination
			var destination = new DomDestination();
			using (var inputStream = input.OpenRead()) {
				var transformer = executable.Load();
				transformer.SetInputStream(inputStream, new Uri(input.DirectoryName));
				transformer.Run(destination);
			}

			// Save result to a file (or whatever else you wanna do)
			destination.XmlDocument.Save(output.FullName);
		}
	}
}
