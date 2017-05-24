namespace TCP_klient
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
            this.przyciskpolacz = new System.Windows.Forms.Button();
            this.infoopolaczeniu = new System.Windows.Forms.ListBox();
            this.myport = new System.Windows.Forms.NumericUpDown();
            this.adres = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.myport)).BeginInit();
            this.SuspendLayout();
            // 
            // przyciskpolacz
            // 
            this.przyciskpolacz.Location = new System.Drawing.Point(243, 365);
            this.przyciskpolacz.Name = "przyciskpolacz";
            this.przyciskpolacz.Size = new System.Drawing.Size(186, 73);
            this.przyciskpolacz.TabIndex = 0;
            this.przyciskpolacz.Text = "polacz";
            this.przyciskpolacz.UseVisualStyleBackColor = true;
            // 
            // infoopolaczeniu
            // 
            this.infoopolaczeniu.FormattingEnabled = true;
            this.infoopolaczeniu.Location = new System.Drawing.Point(21, 71);
            this.infoopolaczeniu.Name = "infoopolaczeniu";
            this.infoopolaczeniu.Size = new System.Drawing.Size(630, 264);
            this.infoopolaczeniu.TabIndex = 1;
            // 
            // myport
            // 
            this.myport.Location = new System.Drawing.Point(435, 28);
            this.myport.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.myport.Name = "myport";
            this.myport.Size = new System.Drawing.Size(216, 20);
            this.myport.TabIndex = 2;
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(21, 27);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(331, 20);
            this.adres.TabIndex = 3;
            this.adres.Text = "adres";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 474);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.myport);
            this.Controls.Add(this.infoopolaczeniu);
            this.Controls.Add(this.przyciskpolacz);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button przyciskpolacz;
        private System.Windows.Forms.ListBox infoopolaczeniu;
        private System.Windows.Forms.NumericUpDown myport;
        private System.Windows.Forms.TextBox adres;
    }
}

