namespace WinFormsAppTwoForms
{
    public partial class Form1 : Form
    {
        private string filePath;
        private Button editButton; 

        public Form1()
        {
            InitializeComponent();
            editButton = new Button();
            Controls.Add(editButton);

            editButton.Click += EditButton_Click_1;
            editButton.Enabled = false;
        }

        private void EditForm_TextChanged(object sender, EventArgs e)
        {
            textBoxMain.Text = ((EditForm)sender).EditedText;
        }

        private void EditButton_Click_1(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(textBoxMain.Text);
            editForm.TextChanged += EditForm_TextChanged;
            editForm.Show();
        }

        private void LoadFileButton_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    textBoxMain.Text = File.ReadAllText(filePath);
                    editButton.Enabled = true;
                }
            }
        }
    }
}