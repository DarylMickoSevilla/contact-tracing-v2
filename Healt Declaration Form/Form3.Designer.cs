namespace Healt_Declaration_Form
{
    partial class OpenFile
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
            this.OpenFilebtn = new System.Windows.Forms.Button();
            this.DisplayBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // OpenFilebtn
            // 
            this.OpenFilebtn.Location = new System.Drawing.Point(141, 219);
            this.OpenFilebtn.Name = "OpenFilebtn";
            this.OpenFilebtn.Size = new System.Drawing.Size(75, 23);
            this.OpenFilebtn.TabIndex = 0;
            this.OpenFilebtn.Text = "Open File Record";
            this.OpenFilebtn.UseVisualStyleBackColor = true;
            this.OpenFilebtn.Click += new System.EventHandler(this.OpenFilebtn_Click);
            // 
            // DisplayBox
            // 
            this.DisplayBox.Location = new System.Drawing.Point(30, 22);
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.Size = new System.Drawing.Size(323, 176);
            this.DisplayBox.TabIndex = 1;
            this.DisplayBox.Text = "";
            // 
            // OpenFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 265);
            this.Controls.Add(this.DisplayBox);
            this.Controls.Add(this.OpenFilebtn);
            this.Name = "OpenFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open File Window";
            this.ResumeLayout(false);

        }

        #endregion

        private Button OpenFilebtn;
        private RichTextBox DisplayBox;
    }
}