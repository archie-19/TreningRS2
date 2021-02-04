namespace TreningRS2.WinUI.ApplicationUser
{
    partial class frmApplicationUserDetalji
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPotvrda = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboOpcine = new System.Windows.Forms.ComboBox();
            this.pictureSlika = new System.Windows.Forms.PictureBox();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DatumRodjenja = new System.Windows.Forms.Label();
            this.dateRodjenje = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.btnM = new System.Windows.Forms.RadioButton();
            this.btnZ = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.btnSlika = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(12, 42);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(229, 20);
            this.txtIme.TabIndex = 0;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prezime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(12, 99);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(229, 20);
            this.txtPrezime.TabIndex = 2;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 158);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(229, 20);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Korisničko ime";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(12, 264);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(229, 20);
            this.txtUsername.TabIndex = 8;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 318);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(106, 20);
            this.txtPassword.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Potvrda";
            // 
            // txtPotvrda
            // 
            this.txtPotvrda.Location = new System.Drawing.Point(135, 318);
            this.txtPotvrda.Name = "txtPotvrda";
            this.txtPotvrda.Size = new System.Drawing.Size(106, 20);
            this.txtPotvrda.TabIndex = 12;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(535, 330);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(145, 23);
            this.btnSacuvaj.TabIndex = 14;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // comboOpcine
            // 
            this.comboOpcine.FormattingEnabled = true;
            this.comboOpcine.Location = new System.Drawing.Point(291, 40);
            this.comboOpcine.Name = "comboOpcine";
            this.comboOpcine.Size = new System.Drawing.Size(121, 21);
            this.comboOpcine.TabIndex = 18;
            this.comboOpcine.SelectedIndexChanged += new System.EventHandler(this.comboOpcine_SelectedIndexChanged);
            // 
            // pictureSlika
            // 
            this.pictureSlika.Location = new System.Drawing.Point(535, 23);
            this.pictureSlika.Name = "pictureSlika";
            this.pictureSlika.Size = new System.Drawing.Size(145, 114);
            this.pictureSlika.TabIndex = 19;
            this.pictureSlika.TabStop = false;
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(291, 99);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(204, 20);
            this.txtJMBG.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(289, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "JMBG";
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.AutoSize = true;
            this.DatumRodjenja.Location = new System.Drawing.Point(12, 194);
            this.DatumRodjenja.Name = "DatumRodjenja";
            this.DatumRodjenja.Size = new System.Drawing.Size(78, 13);
            this.DatumRodjenja.TabIndex = 22;
            this.DatumRodjenja.Text = "Datum rodjenja";
            // 
            // dateRodjenje
            // 
            this.dateRodjenje.Location = new System.Drawing.Point(12, 222);
            this.dateRodjenje.Name = "dateRodjenje";
            this.dateRodjenje.Size = new System.Drawing.Size(200, 20);
            this.dateRodjenje.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(288, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Spol";
            // 
            // btnM
            // 
            this.btnM.AutoSize = true;
            this.btnM.Location = new System.Drawing.Point(291, 266);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(34, 17);
            this.btnM.TabIndex = 25;
            this.btnM.TabStop = true;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = true;
            // 
            // btnZ
            // 
            this.btnZ.AutoSize = true;
            this.btnZ.Location = new System.Drawing.Point(334, 267);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(32, 17);
            this.btnZ.TabIndex = 26;
            this.btnZ.TabStop = true;
            this.btnZ.Text = "Ž";
            this.btnZ.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Opcina";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(293, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Slika";
            // 
            // txtSlika
            // 
            this.txtSlika.Location = new System.Drawing.Point(291, 158);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(121, 20);
            this.txtSlika.TabIndex = 29;
            // 
            // btnSlika
            // 
            this.btnSlika.Location = new System.Drawing.Point(420, 158);
            this.btnSlika.Name = "btnSlika";
            this.btnSlika.Size = new System.Drawing.Size(75, 23);
            this.btnSlika.TabIndex = 30;
            this.btnSlika.Text = "Dodaj";
            this.btnSlika.UseVisualStyleBackColor = true;
            this.btnSlika.Click += new System.EventHandler(this.btnSlika_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmApplicationUserDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.btnSlika);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnZ);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateRodjenje);
            this.Controls.Add(this.DatumRodjenja);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtJMBG);
            this.Controls.Add(this.pictureSlika);
            this.Controls.Add(this.comboOpcine);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPotvrda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIme);
            this.Name = "frmApplicationUserDetalji";
            this.Text = "frmApplicationUserDetalji";
            this.Load += new System.EventHandler(this.frmApplicationUserDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPotvrda;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox comboOpcine;
        private System.Windows.Forms.PictureBox pictureSlika;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.DateTimePicker dateRodjenje;
        private System.Windows.Forms.Label DatumRodjenja;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton btnZ;
        private System.Windows.Forms.RadioButton btnM;
        private System.Windows.Forms.Button btnSlika;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}