using System;
using System.Windows.Forms;

namespace Xml_Transformer {
	public partial class GeneralMessageForm : Form {
		public GeneralMessageForm() {
			InitializeComponent();
		}

		private void tsmiWrapText_Click(object sender, EventArgs e) {
			tsmiWrapText.Checked = !tsmiWrapText.Checked;
			rtbSchemaValidationMsg.WordWrap = tsmiWrapText.Checked;
		}
	}
}
