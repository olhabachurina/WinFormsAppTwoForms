using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppTwoForms
{
    public partial class EditForm : Form
    {
        public event EventHandler TextChanged;

        public string EditedText
        {
            get { return textBoxEdit.Text; }
        }

        public EditForm(string initialText)
        {
            InitializeComponent();
            textBoxEdit.Text = initialText;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            OnTextChanged();
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OnTextChanged()
        {
            TextChanged?.Invoke(this, EventArgs.Empty);
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            OnTextChanged();
            Close();
        }
    }
}