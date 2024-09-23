namespace NiOP_06_CheckBox
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
            this.Dorucak = new System.Windows.Forms.CheckBox();
            this.Rucak = new System.Windows.Forms.CheckBox();
            this.Vecera = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Sakrij_narudzbu = new System.Windows.Forms.CheckBox();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Dorucak
            // 
            this.Dorucak.AutoSize = true;
            this.Dorucak.Location = new System.Drawing.Point(12, 14);
            this.Dorucak.Name = "Dorucak";
            this.Dorucak.Size = new System.Drawing.Size(67, 17);
            this.Dorucak.TabIndex = 0;
            this.Dorucak.Text = "Dorucak";
            this.Dorucak.UseVisualStyleBackColor = true;
            this.Dorucak.CheckedChanged += new System.EventHandler(this.Dorucak_CheckedChanged);
            // 
            // Rucak
            // 
            this.Rucak.AutoSize = true;
            this.Rucak.Location = new System.Drawing.Point(12, 37);
            this.Rucak.Name = "Rucak";
            this.Rucak.Size = new System.Drawing.Size(58, 17);
            this.Rucak.TabIndex = 1;
            this.Rucak.Text = "Rucak";
            this.Rucak.UseVisualStyleBackColor = true;
            this.Rucak.CheckedChanged += new System.EventHandler(this.Rucak_CheckedChanged);
            // 
            // Vecera
            // 
            this.Vecera.AutoSize = true;
            this.Vecera.Location = new System.Drawing.Point(12, 60);
            this.Vecera.Name = "Vecera";
            this.Vecera.Size = new System.Drawing.Size(60, 17);
            this.Vecera.TabIndex = 2;
            this.Vecera.Text = "Vecera";
            this.Vecera.UseVisualStyleBackColor = true;
            this.Vecera.CheckedChanged += new System.EventHandler(this.Vecera_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pošalji";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Sakrij_narudzbu
            // 
            this.Sakrij_narudzbu.AutoSize = true;
            this.Sakrij_narudzbu.Location = new System.Drawing.Point(105, 114);
            this.Sakrij_narudzbu.Name = "Sakrij_narudzbu";
            this.Sakrij_narudzbu.Size = new System.Drawing.Size(99, 17);
            this.Sakrij_narudzbu.TabIndex = 4;
            this.Sakrij_narudzbu.Text = "Sakrij narudžbu";
            this.Sakrij_narudzbu.UseVisualStyleBackColor = true;
            this.Sakrij_narudzbu.CheckedChanged += new System.EventHandler(this.Sakrij_narudzbu_CheckedChanged);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(96, 12);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(212, 74);
            this.TextBox.TabIndex = 5;
            this.TextBox.Text = "Odabrali ste:";
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 142);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Sakrij_narudzbu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Vecera);
            this.Controls.Add(this.Rucak);
            this.Controls.Add(this.Dorucak);
            this.Name = "Form1";
            this.Text = "Upotreba CheckBox kontrole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Dorucak;
        private System.Windows.Forms.CheckBox Rucak;
        private System.Windows.Forms.CheckBox Vecera;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox Sakrij_narudzbu;
        private System.Windows.Forms.TextBox TextBox;
    }
}

