namespace OdevReflectionAcunMedya
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
            listBox1 = new ListBox();
            btnKlasorSec = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            btnOdemeYap = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 34);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 0;
            // 
            // btnKlasorSec
            // 
            btnKlasorSec.Location = new Point(39, 166);
            btnKlasorSec.Name = "btnKlasorSec";
            btnKlasorSec.Size = new Size(94, 29);
            btnKlasorSec.TabIndex = 1;
            btnKlasorSec.Text = "Klasör Seç";
            btnKlasorSec.UseVisualStyleBackColor = true;
            btnKlasorSec.Click += btnKlasorSec_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(194, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(194, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // btnOdemeYap
            // 
            btnOdemeYap.Location = new Point(207, 143);
            btnOdemeYap.Name = "btnOdemeYap";
            btnOdemeYap.Size = new Size(94, 29);
            btnOdemeYap.TabIndex = 4;
            btnOdemeYap.Text = "Ödeme Yap";
            btnOdemeYap.UseVisualStyleBackColor = true;
            btnOdemeYap.Click += btnOdemeYap_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 263);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnOdemeYap);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(btnKlasorSec);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button btnKlasorSec;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button btnOdemeYap;
        private Label label1;
    }
}
