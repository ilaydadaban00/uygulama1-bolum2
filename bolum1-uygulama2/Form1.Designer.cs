namespace bolum1_uygulama2
{
    partial class grpArkaplanrengi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKirmizi = new System.Windows.Forms.Button();
            this.btnYesil = new System.Windows.Forms.Button();
            this.btnMavi = new System.Windows.Forms.Button();
            this.brnTuruncu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.brnTuruncu);
            this.groupBox1.Controls.Add(this.btnMavi);
            this.groupBox1.Controls.Add(this.btnYesil);
            this.groupBox1.Controls.Add(this.btnKirmizi);
            this.groupBox1.Location = new System.Drawing.Point(153, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arka plan rengi";
            // 
            // btnKirmizi
            // 
            this.btnKirmizi.BackColor = System.Drawing.Color.Red;
            this.btnKirmizi.Location = new System.Drawing.Point(29, 30);
            this.btnKirmizi.Name = "btnKirmizi";
            this.btnKirmizi.Size = new System.Drawing.Size(106, 40);
            this.btnKirmizi.TabIndex = 0;
            this.btnKirmizi.Text = "kırmızı";
            this.btnKirmizi.UseVisualStyleBackColor = false;
            this.btnKirmizi.Click += new System.EventHandler(this.btnrenk_Click);
            // 
            // btnYesil
            // 
            this.btnYesil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnYesil.Location = new System.Drawing.Point(164, 30);
            this.btnYesil.Name = "btnYesil";
            this.btnYesil.Size = new System.Drawing.Size(106, 40);
            this.btnYesil.TabIndex = 1;
            this.btnYesil.Text = "yeşil";
            this.btnYesil.UseVisualStyleBackColor = false;
            this.btnYesil.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMavi
            // 
            this.btnMavi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMavi.Location = new System.Drawing.Point(29, 76);
            this.btnMavi.Name = "btnMavi";
            this.btnMavi.Size = new System.Drawing.Size(106, 40);
            this.btnMavi.TabIndex = 2;
            this.btnMavi.Text = "mavi";
            this.btnMavi.UseVisualStyleBackColor = false;
            this.btnMavi.Click += new System.EventHandler(this.button2_Click);
            // 
            // brnTuruncu
            // 
            this.brnTuruncu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.brnTuruncu.Location = new System.Drawing.Point(164, 76);
            this.brnTuruncu.Name = "brnTuruncu";
            this.brnTuruncu.Size = new System.Drawing.Size(106, 40);
            this.brnTuruncu.TabIndex = 3;
            this.brnTuruncu.Text = "turuncu";
            this.brnTuruncu.UseVisualStyleBackColor = false;
            this.brnTuruncu.Click += new System.EventHandler(this.button3_Click);
            // 
            // grpArkaplanrengi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "grpArkaplanrengi";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button brnTuruncu;
        private System.Windows.Forms.Button btnMavi;
        private System.Windows.Forms.Button btnYesil;
        private System.Windows.Forms.Button btnKirmizi;
    }
}

