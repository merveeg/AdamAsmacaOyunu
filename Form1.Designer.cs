namespace adamasmacaoyun
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlHarfler = new System.Windows.Forms.Panel();
            this.btnOyunaBasla = new System.Windows.Forms.Button();
            this.lblYanlis = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(177, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Harf Tahmin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(560, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 107);
            this.textBox1.MaxLength = 22;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // pnlHarfler
            // 
            this.pnlHarfler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHarfler.Location = new System.Drawing.Point(57, 32);
            this.pnlHarfler.Name = "pnlHarfler";
            this.pnlHarfler.Size = new System.Drawing.Size(391, 69);
            this.pnlHarfler.TabIndex = 12;
            // 
            // btnOyunaBasla
            // 
            this.btnOyunaBasla.Location = new System.Drawing.Point(93, 320);
            this.btnOyunaBasla.Name = "btnOyunaBasla";
            this.btnOyunaBasla.Size = new System.Drawing.Size(75, 23);
            this.btnOyunaBasla.TabIndex = 14;
            this.btnOyunaBasla.Text = "Oyuna Başla";
            this.btnOyunaBasla.UseVisualStyleBackColor = true;
            this.btnOyunaBasla.Click += new System.EventHandler(this.btnOyunaBasla_Click);
            // 
            // lblYanlis
            // 
            this.lblYanlis.AutoSize = true;
            this.lblYanlis.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYanlis.Location = new System.Drawing.Point(28, 253);
            this.lblYanlis.Name = "lblYanlis";
            this.lblYanlis.Size = new System.Drawing.Size(153, 23);
            this.lblYanlis.TabIndex = 15;
            this.lblYanlis.Text = "Denenen Harfler";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(207, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Oyunu Bitir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblYanlis);
            this.Controls.Add(this.btnOyunaBasla);
            this.Controls.Add(this.pnlHarfler);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnlHarfler;
        private System.Windows.Forms.Button btnOyunaBasla;
        private System.Windows.Forms.Label lblYanlis;
        private System.Windows.Forms.Button button2;
    }
}

