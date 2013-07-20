namespace IrisAccess.Forms
{
    partial class UserProfileUpdate
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.dataGroupBox = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.lblIsMale = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lblIdentification = new System.Windows.Forms.Label();
            this.txtIdentification = new System.Windows.Forms.TextBox();
            this.txtFileId = new System.Windows.Forms.TextBox();
            this.lblFileId = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnConfiguration = new System.Windows.Forms.Button();
            this.dataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(430, 265);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(349, 265);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Aceptar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(78, 45);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(180, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(6, 48);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(47, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Nombre:";
            // 
            // dataGroupBox
            // 
            this.dataGroupBox.Controls.Add(this.lblEmail);
            this.dataGroupBox.Controls.Add(this.txtEmail);
            this.dataGroupBox.Controls.Add(this.lblBirthdate);
            this.dataGroupBox.Controls.Add(this.dtpBirthdate);
            this.dataGroupBox.Controls.Add(this.lblIsMale);
            this.dataGroupBox.Controls.Add(this.rbFemale);
            this.dataGroupBox.Controls.Add(this.rbMale);
            this.dataGroupBox.Controls.Add(this.lblIdentification);
            this.dataGroupBox.Controls.Add(this.txtIdentification);
            this.dataGroupBox.Controls.Add(this.txtFileId);
            this.dataGroupBox.Controls.Add(this.lblFileId);
            this.dataGroupBox.Controls.Add(this.txtLastName);
            this.dataGroupBox.Controls.Add(this.lblLastName);
            this.dataGroupBox.Controls.Add(this.lblFirstName);
            this.dataGroupBox.Controls.Add(this.txtFirstName);
            this.dataGroupBox.Location = new System.Drawing.Point(12, 25);
            this.dataGroupBox.Name = "dataGroupBox";
            this.dataGroupBox.Size = new System.Drawing.Size(264, 201);
            this.dataGroupBox.TabIndex = 4;
            this.dataGroupBox.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 176);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(78, 173);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(6, 153);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(63, 13);
            this.lblBirthdate.TabIndex = 12;
            this.lblBirthdate.Text = "Fecha Nac:";
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthdate.Location = new System.Drawing.Point(78, 147);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(180, 20);
            this.dtpBirthdate.TabIndex = 7;
            // 
            // lblIsMale
            // 
            this.lblIsMale.AutoSize = true;
            this.lblIsMale.Location = new System.Drawing.Point(6, 125);
            this.lblIsMale.Name = "lblIsMale";
            this.lblIsMale.Size = new System.Drawing.Size(34, 13);
            this.lblIsMale.TabIndex = 6;
            this.lblIsMale.Text = "Sexo:";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(119, 123);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(31, 17);
            this.rbFemale.TabIndex = 6;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "F";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(78, 123);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(34, 17);
            this.rbMale.TabIndex = 5;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "M";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // lblIdentification
            // 
            this.lblIdentification.AutoSize = true;
            this.lblIdentification.Location = new System.Drawing.Point(6, 100);
            this.lblIdentification.Name = "lblIdentification";
            this.lblIdentification.Size = new System.Drawing.Size(29, 13);
            this.lblIdentification.TabIndex = 8;
            this.lblIdentification.Text = "DNI:";
            // 
            // txtIdentification
            // 
            this.txtIdentification.Location = new System.Drawing.Point(78, 97);
            this.txtIdentification.Name = "txtIdentification";
            this.txtIdentification.Size = new System.Drawing.Size(180, 20);
            this.txtIdentification.TabIndex = 4;
            // 
            // txtFileId
            // 
            this.txtFileId.Location = new System.Drawing.Point(78, 19);
            this.txtFileId.Name = "txtFileId";
            this.txtFileId.Size = new System.Drawing.Size(180, 20);
            this.txtFileId.TabIndex = 1;
            // 
            // lblFileId
            // 
            this.lblFileId.AutoSize = true;
            this.lblFileId.Location = new System.Drawing.Point(6, 22);
            this.lblFileId.Name = "lblFileId";
            this.lblFileId.Size = new System.Drawing.Size(42, 13);
            this.lblFileId.TabIndex = 4;
            this.lblFileId.Text = "Legajo:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(78, 71);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(180, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(6, 74);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(47, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Apellido:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 9);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(70, 13);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "lblDescription";
            // 
            // btnConfiguration
            // 
            this.btnConfiguration.Location = new System.Drawing.Point(190, 232);
            this.btnConfiguration.Name = "btnConfiguration";
            this.btnConfiguration.Size = new System.Drawing.Size(86, 23);
            this.btnConfiguration.TabIndex = 9;
            this.btnConfiguration.Text = "Configuración";
            this.btnConfiguration.UseVisualStyleBackColor = true;
            this.btnConfiguration.Click += new System.EventHandler(this.btnConfiguration_Click);
            // 
            // UserProfileUpdate
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(517, 300);
            this.Controls.Add(this.btnConfiguration);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.dataGroupBox);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserProfileUpdate";
            this.Text = "Usuarios";
            this.dataGroupBox.ResumeLayout(false);
            this.dataGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox dataGroupBox;
        private System.Windows.Forms.TextBox txtFileId;
        private System.Windows.Forms.Label lblFileId;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.Label lblIsMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lblIdentification;
        private System.Windows.Forms.TextBox txtIdentification;
        private System.Windows.Forms.Button btnConfiguration;
    }
}