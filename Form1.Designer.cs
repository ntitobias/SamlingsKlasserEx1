namespace SamlingsKlasserEx1
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
            this.gbxLäggTill = new System.Windows.Forms.GroupBox();
            this.btnLäggTill = new System.Windows.Forms.Button();
            this.tbxLäggTill = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblLista = new System.Windows.Forms.Label();
            this.gbxKollaVärde = new System.Windows.Forms.GroupBox();
            this.btnKollaVärde = new System.Windows.Forms.Button();
            this.tbxKollaVärde = new System.Windows.Forms.TextBox();
            this.gbxLäggTill.SuspendLayout();
            this.gbxKollaVärde.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLäggTill
            // 
            this.gbxLäggTill.Controls.Add(this.btnLäggTill);
            this.gbxLäggTill.Controls.Add(this.tbxLäggTill);
            this.gbxLäggTill.Location = new System.Drawing.Point(26, 22);
            this.gbxLäggTill.Name = "gbxLäggTill";
            this.gbxLäggTill.Size = new System.Drawing.Size(200, 100);
            this.gbxLäggTill.TabIndex = 0;
            this.gbxLäggTill.TabStop = false;
            this.gbxLäggTill.Text = "Lägg till";
            // 
            // btnLäggTill
            // 
            this.btnLäggTill.Location = new System.Drawing.Point(78, 60);
            this.btnLäggTill.Name = "btnLäggTill";
            this.btnLäggTill.Size = new System.Drawing.Size(75, 23);
            this.btnLäggTill.TabIndex = 1;
            this.btnLäggTill.Text = "Lägg till";
            this.btnLäggTill.UseVisualStyleBackColor = true;
            this.btnLäggTill.Click += new System.EventHandler(this.btnLäggTill_Click);
            // 
            // tbxLäggTill
            // 
            this.tbxLäggTill.Location = new System.Drawing.Point(16, 31);
            this.tbxLäggTill.Name = "tbxLäggTill";
            this.tbxLäggTill.Size = new System.Drawing.Size(100, 22);
            this.tbxLäggTill.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(561, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 1;
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(346, 22);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(46, 17);
            this.lblLista.TabIndex = 2;
            this.lblLista.Text = "label1";
            // 
            // gbxKollaVärde
            // 
            this.gbxKollaVärde.Controls.Add(this.btnKollaVärde);
            this.gbxKollaVärde.Controls.Add(this.tbxKollaVärde);
            this.gbxKollaVärde.Location = new System.Drawing.Point(26, 140);
            this.gbxKollaVärde.Name = "gbxKollaVärde";
            this.gbxKollaVärde.Size = new System.Drawing.Size(200, 109);
            this.gbxKollaVärde.TabIndex = 3;
            this.gbxKollaVärde.TabStop = false;
            this.gbxKollaVärde.Text = "Se om värde finns";
            // 
            // btnKollaVärde
            // 
            this.btnKollaVärde.Location = new System.Drawing.Point(78, 60);
            this.btnKollaVärde.Name = "btnKollaVärde";
            this.btnKollaVärde.Size = new System.Drawing.Size(75, 23);
            this.btnKollaVärde.TabIndex = 1;
            this.btnKollaVärde.Text = "Kolla värde";
            this.btnKollaVärde.UseVisualStyleBackColor = true;
            this.btnKollaVärde.Click += new System.EventHandler(this.btnKollaVärde_Click);
            // 
            // tbxKollaVärde
            // 
            this.tbxKollaVärde.Location = new System.Drawing.Point(16, 31);
            this.tbxKollaVärde.Name = "tbxKollaVärde";
            this.tbxKollaVärde.Size = new System.Drawing.Size(100, 22);
            this.tbxKollaVärde.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxKollaVärde);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gbxLäggTill);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxLäggTill.ResumeLayout(false);
            this.gbxLäggTill.PerformLayout();
            this.gbxKollaVärde.ResumeLayout(false);
            this.gbxKollaVärde.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLäggTill;
        private System.Windows.Forms.Button btnLäggTill;
        private System.Windows.Forms.TextBox tbxLäggTill;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.GroupBox gbxKollaVärde;
        private System.Windows.Forms.Button btnKollaVärde;
        private System.Windows.Forms.TextBox tbxKollaVärde;
    }
}

