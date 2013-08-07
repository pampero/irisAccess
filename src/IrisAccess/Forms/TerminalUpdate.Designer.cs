namespace IrisAccess.Forms
{
    partial class TerminalUpdate
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
            this.lblAddress = new System.Windows.Forms.Label();
            this.cmbAddress = new System.Windows.Forms.ComboBox();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.cmbDoor = new System.Windows.Forms.ComboBox();
            this.lblDoor = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.cmbHardwareModel = new System.Windows.Forms.ComboBox();
            this.lblhardwareModel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(169, 155);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(88, 155);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Aceptar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 15);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(44, 13);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Edificio:";
            // 
            // cmbAddress
            // 
            this.cmbAddress.DisplayMember = "Description";
            this.cmbAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddress.FormattingEnabled = true;
            this.cmbAddress.Location = new System.Drawing.Point(62, 12);
            this.cmbAddress.Name = "cmbAddress";
            this.cmbAddress.Size = new System.Drawing.Size(180, 21);
            this.cmbAddress.TabIndex = 1;
            this.cmbAddress.ValueMember = "ID";
            this.cmbAddress.SelectedValueChanged += new System.EventHandler(this.cmbAddress_SelectedValueChanged);
            // 
            // cmbArea
            // 
            this.cmbArea.DisplayMember = "Description";
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(62, 39);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(180, 21);
            this.cmbArea.TabIndex = 2;
            this.cmbArea.ValueMember = "ID";
            this.cmbArea.SelectedValueChanged += new System.EventHandler(this.cmbArea_SelectedValueChanged);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(12, 42);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 7;
            this.lblArea.Text = "Área:";
            // 
            // cmbDoor
            // 
            this.cmbDoor.DisplayMember = "Description";
            this.cmbDoor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoor.FormattingEnabled = true;
            this.cmbDoor.Location = new System.Drawing.Point(62, 66);
            this.cmbDoor.Name = "cmbDoor";
            this.cmbDoor.Size = new System.Drawing.Size(180, 21);
            this.cmbDoor.TabIndex = 3;
            this.cmbDoor.ValueMember = "ID";
            // 
            // lblDoor
            // 
            this.lblDoor.AutoSize = true;
            this.lblDoor.Location = new System.Drawing.Point(12, 69);
            this.lblDoor.Name = "lblDoor";
            this.lblDoor.Size = new System.Drawing.Size(41, 13);
            this.lblDoor.TabIndex = 9;
            this.lblDoor.Text = "Puerta:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(62, 93);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(180, 20);
            this.txtIP.TabIndex = 4;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(12, 96);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(20, 13);
            this.lblIP.TabIndex = 11;
            this.lblIP.Text = "IP:";
            // 
            // cmbHardwareModel
            // 
            this.cmbHardwareModel.DisplayMember = "Description";
            this.cmbHardwareModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHardwareModel.FormattingEnabled = true;
            this.cmbHardwareModel.Location = new System.Drawing.Point(62, 119);
            this.cmbHardwareModel.Name = "cmbHardwareModel";
            this.cmbHardwareModel.Size = new System.Drawing.Size(180, 21);
            this.cmbHardwareModel.TabIndex = 5;
            this.cmbHardwareModel.ValueMember = "ID";
            // 
            // lblhardwareModel
            // 
            this.lblhardwareModel.AutoSize = true;
            this.lblhardwareModel.Location = new System.Drawing.Point(12, 122);
            this.lblhardwareModel.Name = "lblhardwareModel";
            this.lblhardwareModel.Size = new System.Drawing.Size(45, 13);
            this.lblhardwareModel.TabIndex = 13;
            this.lblhardwareModel.Text = "Modelo:";
            // 
            // TerminalUpdate
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(256, 190);
            this.Controls.Add(this.lblhardwareModel);
            this.Controls.Add(this.cmbHardwareModel);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.lblDoor);
            this.Controls.Add(this.cmbDoor);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.cmbAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TerminalUpdate";
            this.Text = "Terminales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox cmbAddress;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cmbDoor;
        private System.Windows.Forms.Label lblDoor;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.ComboBox cmbHardwareModel;
        private System.Windows.Forms.Label lblhardwareModel;
    }
}