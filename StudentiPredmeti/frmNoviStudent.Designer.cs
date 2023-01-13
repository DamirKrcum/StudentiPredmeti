namespace StudentiPredmeti
{
    partial class frmNoviStudent
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblindeks = new System.Windows.Forms.Label();
            this.txtIndeks = new System.Windows.Forms.TextBox();
            this.txtPolozeni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(73, 40);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(188, 23);
            this.txtIme.TabIndex = 0;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(12, 43);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 15);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Ime";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(200, 127);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(61, 23);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(12, 72);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(49, 15);
            this.lblPrezime.TabIndex = 4;
            this.lblPrezime.Text = "Prezime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(73, 69);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(188, 23);
            this.txtPrezime.TabIndex = 3;
            // 
            // lblindeks
            // 
            this.lblindeks.AutoSize = true;
            this.lblindeks.Location = new System.Drawing.Point(12, 101);
            this.lblindeks.Name = "lblindeks";
            this.lblindeks.Size = new System.Drawing.Size(41, 15);
            this.lblindeks.TabIndex = 6;
            this.lblindeks.Text = "Indeks";
            // 
            // txtIndeks
            // 
            this.txtIndeks.Location = new System.Drawing.Point(73, 98);
            this.txtIndeks.Name = "txtIndeks";
            this.txtIndeks.ReadOnly = true;
            this.txtIndeks.Size = new System.Drawing.Size(188, 23);
            this.txtIndeks.TabIndex = 5;
            // 
            // txtPolozeni
            // 
            this.txtPolozeni.Location = new System.Drawing.Point(73, 127);
            this.txtPolozeni.Name = "txtPolozeni";
            this.txtPolozeni.Size = new System.Drawing.Size(120, 23);
            this.txtPolozeni.TabIndex = 7;
            this.txtPolozeni.Text = "Polozeni Predmeti";
            this.txtPolozeni.UseVisualStyleBackColor = true;
            // 
            // frmNoviStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPolozeni);
            this.Controls.Add(this.lblindeks);
            this.Controls.Add(this.txtIndeks);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtIme);
            this.Name = "frmNoviStudent";
            this.Text = "Novi Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtIme;
        private Label lblIme;
        private Button btnDodaj;
        private Label lblPrezime;
        private TextBox txtPrezime;
        private Label lblindeks;
        private TextBox txtIndeks;
        private Button txtPolozeni;
    }
}