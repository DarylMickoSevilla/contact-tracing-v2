namespace Healt_Declaration_Form
{
    partial class CodeScanner
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
            this.components = new System.ComponentModel.Container();
            this.CameraBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ScannerBox = new System.Windows.Forms.PictureBox();
            this.Startbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Savebtn = new System.Windows.Forms.Button();
            this.DisplayFilelbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ScannerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CameraBox
            // 
            this.CameraBox.FormattingEnabled = true;
            this.CameraBox.Location = new System.Drawing.Point(66, 30);
            this.CameraBox.Name = "CameraBox";
            this.CameraBox.Size = new System.Drawing.Size(330, 23);
            this.CameraBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Camera";
            // 
            // ScannerBox
            // 
            this.ScannerBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ScannerBox.Location = new System.Drawing.Point(48, 78);
            this.ScannerBox.Name = "ScannerBox";
            this.ScannerBox.Size = new System.Drawing.Size(348, 241);
            this.ScannerBox.TabIndex = 2;
            this.ScannerBox.TabStop = false;
            // 
            // Startbtn
            // 
            this.Startbtn.Location = new System.Drawing.Point(173, 335);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(75, 23);
            this.Startbtn.TabIndex = 3;
            this.Startbtn.Text = "Start";
            this.Startbtn.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(431, 103);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(274, 200);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(527, 309);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 5;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // DisplayFilelbl
            // 
            this.DisplayFilelbl.AutoSize = true;
            this.DisplayFilelbl.Location = new System.Drawing.Point(506, 78);
            this.DisplayFilelbl.Name = "DisplayFilelbl";
            this.DisplayFilelbl.Size = new System.Drawing.Size(120, 15);
            this.DisplayFilelbl.TabIndex = 6;
            this.DisplayFilelbl.Text = "Decoded Information";
            // 
            // CodeScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 400);
            this.Controls.Add(this.DisplayFilelbl);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Startbtn);
            this.Controls.Add(this.ScannerBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CameraBox);
            this.Name = "CodeScanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code Scanner";
            this.Load += new System.EventHandler(this.CodeScanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScannerBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox CameraBox;
        private Label label1;
        private PictureBox ScannerBox;
        private Button Startbtn;
        private System.Windows.Forms.Timer timer1;
        private RichTextBox richTextBox1;
        private Button Savebtn;
        private Label DisplayFilelbl;
    }
}