namespace UsingPrintHelper
{
    partial class PrintHelper
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnPHok = new System.Windows.Forms.Button();
            this.btnHPcancelar = new System.Windows.Forms.Button();
            this.labelph1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(414, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnPHok
            // 
            this.btnPHok.Location = new System.Drawing.Point(93, 193);
            this.btnPHok.Name = "btnPHok";
            this.btnPHok.Size = new System.Drawing.Size(75, 23);
            this.btnPHok.TabIndex = 1;
            this.btnPHok.Text = "Aceptar";
            this.btnPHok.UseVisualStyleBackColor = true;
            // 
            // btnHPcancelar
            // 
            this.btnHPcancelar.Location = new System.Drawing.Point(250, 193);
            this.btnHPcancelar.Name = "btnHPcancelar";
            this.btnHPcancelar.Size = new System.Drawing.Size(75, 23);
            this.btnHPcancelar.TabIndex = 2;
            this.btnHPcancelar.Text = "Cancelar";
            this.btnHPcancelar.UseVisualStyleBackColor = true;
            // 
            // labelph1
            // 
            this.labelph1.AutoSize = true;
            this.labelph1.Location = new System.Drawing.Point(36, 40);
            this.labelph1.Name = "labelph1";
            this.labelph1.Size = new System.Drawing.Size(35, 13);
            this.labelph1.TabIndex = 3;
            this.labelph1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 4;
            // 
            // PrintHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 224);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelph1);
            this.Controls.Add(this.btnHPcancelar);
            this.Controls.Add(this.btnPHok);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrintHelper";
            this.Text = "PrintHelper";
            this.Load += new System.EventHandler(this.PrintHelper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnPHok;
        private System.Windows.Forms.Button btnHPcancelar;
        private System.Windows.Forms.Label labelph1;
        private System.Windows.Forms.TextBox textBox1;
    }
}