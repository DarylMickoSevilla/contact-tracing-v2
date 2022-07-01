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
            this.CameraBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ScannerBox1 = new System.Windows.Forms.PictureBox();
            this.strbtn = new System.Windows.Forms.Button();
            this.readbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DecodedText = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ScannerBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CameraBox1
            // 
            this.CameraBox1.FormattingEnabled = true;
            this.CameraBox1.Location = new System.Drawing.Point(137, 38);
            this.CameraBox1.Name = "CameraBox1";
            this.CameraBox1.Size = new System.Drawing.Size(257, 23);
            this.CameraBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Camera";
            // 
            // ScannerBox1
            // 
            this.ScannerBox1.Location = new System.Drawing.Point(83, 83);
            this.ScannerBox1.Name = "ScannerBox1";
            this.ScannerBox1.Size = new System.Drawing.Size(349, 303);
            this.ScannerBox1.TabIndex = 2;
            this.ScannerBox1.TabStop = false;
            // 
            // strbtn
            // 
            this.strbtn.Location = new System.Drawing.Point(216, 392);
            this.strbtn.Name = "strbtn";
            this.strbtn.Size = new System.Drawing.Size(75, 23);
            this.strbtn.TabIndex = 3;
            this.strbtn.Text = "Start";
            this.strbtn.UseVisualStyleBackColor = true;
            this.strbtn.Click += new System.EventHandler(this.strbtn_Click);
            // 
            // readbtn
            // 
            this.readbtn.Location = new System.Drawing.Point(216, 421);
            this.readbtn.Name = "readbtn";
            this.readbtn.Size = new System.Drawing.Size(75, 23);
            this.readbtn.TabIndex = 4;
            this.readbtn.Text = "Read";
            this.readbtn.UseVisualStyleBackColor = true;
            this.readbtn.Click += new System.EventHandler(this.readbtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DecodedText
            // 
            this.DecodedText.Location = new System.Drawing.Point(83, 463);
            this.DecodedText.Name = "DecodedText";
            this.DecodedText.Size = new System.Drawing.Size(349, 134);
            this.DecodedText.TabIndex = 5;
            this.DecodedText.Text = "";
            // 
            // CodeScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 636);
            this.Controls.Add(this.DecodedText);
            this.Controls.Add(this.readbtn);
            this.Controls.Add(this.strbtn);
            this.Controls.Add(this.ScannerBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CameraBox1);
            this.Name = "CodeScanner";
            this.Text = "QR Code Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CodeScanner_FormClosing);
            this.Load += new System.EventHandler(this.CodeScanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScannerBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox CameraBox1;
        private Label label1;
        private PictureBox ScannerBox1;
        private Button strbtn;
        private Button readbtn;
        private System.Windows.Forms.Timer timer1;
        private RichTextBox DecodedText;
    }
}