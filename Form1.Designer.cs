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
            this.tbxLäggTill = new System.Windows.Forms.TextBox();
            this.btnLäggTill = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxLäggTill.SuspendLayout();
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
            this.gbxLäggTill.Text = "groupBox1";
            // 
            // tbxLäggTill
            // 
            this.tbxLäggTill.Location = new System.Drawing.Point(16, 31);
            this.tbxLäggTill.Name = "tbxLäggTill";
            this.tbxLäggTill.Size = new System.Drawing.Size(100, 22);
            this.tbxLäggTill.TabIndex = 0;
            // 
            // btnLäggTill
            // 
            this.btnLäggTill.Location = new System.Drawing.Point(78, 60);
            this.btnLäggTill.Name = "btnLäggTill";
            this.btnLäggTill.Size = new System.Drawing.Size(75, 23);
            this.btnLäggTill.TabIndex = 1;
            this.btnLäggTill.Text = "Lägg till";
            this.btnLäggTill.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(349, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gbxLäggTill);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxLäggTill.ResumeLayout(false);
            this.gbxLäggTill.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLäggTill;
        private System.Windows.Forms.Button btnLäggTill;
        private System.Windows.Forms.TextBox tbxLäggTill;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}

