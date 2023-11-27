namespace WinFormsAppTwoForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxMain = new TextBox();
            LoadFileButton = new Button();
            EditButton = new Button();
            SuspendLayout();
            // 
            // textBoxMain
            // 
            textBoxMain.Location = new Point(326, 159);
            textBoxMain.Name = "textBoxMain";
            textBoxMain.Size = new Size(125, 27);
            textBoxMain.TabIndex = 0;
            // 
            // LoadFileButton
            // 
            LoadFileButton.Location = new Point(237, 245);
            LoadFileButton.Name = "LoadFileButton";
            LoadFileButton.Size = new Size(94, 29);
            LoadFileButton.TabIndex = 1;
            LoadFileButton.Text = "загрузить";
            LoadFileButton.UseVisualStyleBackColor = true;
            LoadFileButton.Click += LoadFileButton_Click_1;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(462, 245);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(94, 29);
            EditButton.TabIndex = 2;
            EditButton.Text = "редактировть";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EditButton);
            Controls.Add(LoadFileButton);
            Controls.Add(textBoxMain);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxMain;
        private Button LoadFileButton;
        private Button EditButton;
    }
}