namespace IrisAccess.Forms
{
    partial class UserCalendarTerminalUpdate
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
            this.btnSearchCalendar = new System.Windows.Forms.Button();
            this.txtCalendar = new System.Windows.Forms.TextBox();
            this.txtTerminal = new System.Windows.Forms.TextBox();
            this.btnSearchTerminal = new System.Windows.Forms.Button();
            this.lblCalendar = new System.Windows.Forms.Label();
            this.lblTerminal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(318, 77);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(237, 77);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Aceptar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnSearchCalendar
            // 
            this.btnSearchCalendar.Location = new System.Drawing.Point(317, 12);
            this.btnSearchCalendar.Name = "btnSearchCalendar";
            this.btnSearchCalendar.Size = new System.Drawing.Size(75, 23);
            this.btnSearchCalendar.TabIndex = 2;
            this.btnSearchCalendar.Text = "Buscar";
            this.btnSearchCalendar.UseVisualStyleBackColor = true;
            this.btnSearchCalendar.Click += new System.EventHandler(this.btnSearchCalendar_Click);
            // 
            // txtCalendar
            // 
            this.txtCalendar.Enabled = false;
            this.txtCalendar.Location = new System.Drawing.Point(78, 14);
            this.txtCalendar.Name = "txtCalendar";
            this.txtCalendar.Size = new System.Drawing.Size(233, 20);
            this.txtCalendar.TabIndex = 1;
            // 
            // txtTerminal
            // 
            this.txtTerminal.Enabled = false;
            this.txtTerminal.Location = new System.Drawing.Point(78, 43);
            this.txtTerminal.Name = "txtTerminal";
            this.txtTerminal.Size = new System.Drawing.Size(232, 20);
            this.txtTerminal.TabIndex = 3;
            // 
            // btnSearchTerminal
            // 
            this.btnSearchTerminal.Location = new System.Drawing.Point(317, 41);
            this.btnSearchTerminal.Name = "btnSearchTerminal";
            this.btnSearchTerminal.Size = new System.Drawing.Size(75, 23);
            this.btnSearchTerminal.TabIndex = 4;
            this.btnSearchTerminal.Text = "Buscar";
            this.btnSearchTerminal.UseVisualStyleBackColor = true;
            this.btnSearchTerminal.Click += new System.EventHandler(this.btnSearchTerminal_Click);
            // 
            // lblCalendar
            // 
            this.lblCalendar.AutoSize = true;
            this.lblCalendar.Location = new System.Drawing.Point(12, 17);
            this.lblCalendar.Name = "lblCalendar";
            this.lblCalendar.Size = new System.Drawing.Size(60, 13);
            this.lblCalendar.TabIndex = 13;
            this.lblCalendar.Text = "Calendario:";
            // 
            // lblTerminal
            // 
            this.lblTerminal.AutoSize = true;
            this.lblTerminal.Location = new System.Drawing.Point(12, 46);
            this.lblTerminal.Name = "lblTerminal";
            this.lblTerminal.Size = new System.Drawing.Size(50, 13);
            this.lblTerminal.TabIndex = 14;
            this.lblTerminal.Text = "Terminal:";
            // 
            // UserCalendarTerminalUpdate
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(405, 112);
            this.Controls.Add(this.lblTerminal);
            this.Controls.Add(this.lblCalendar);
            this.Controls.Add(this.btnSearchTerminal);
            this.Controls.Add(this.txtTerminal);
            this.Controls.Add(this.txtCalendar);
            this.Controls.Add(this.btnSearchCalendar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserCalendarTerminalUpdate";
            this.Text = "Configuración";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnSearchCalendar;
        private System.Windows.Forms.TextBox txtCalendar;
        private System.Windows.Forms.TextBox txtTerminal;
        private System.Windows.Forms.Button btnSearchTerminal;
        private System.Windows.Forms.Label lblCalendar;
        private System.Windows.Forms.Label lblTerminal;
    }
}