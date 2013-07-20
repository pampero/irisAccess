namespace IrisAccess.Forms
{
    partial class TerminalSearch
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.defaultEntityGrid = new System.Windows.Forms.DataGridView();
            this.AddressDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoorDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HardwareModelDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defaultEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.defaultEntityGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultEntityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(500, 394);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Cancelar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(500, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(12, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(482, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // defaultEntityGrid
            // 
            this.defaultEntityGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultEntityGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.defaultEntityGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AddressDescription,
            this.AreaDescription,
            this.DoorDescription,
            this.IP,
            this.HardwareModelDescription});
            this.defaultEntityGrid.Location = new System.Drawing.Point(12, 38);
            this.defaultEntityGrid.MultiSelect = false;
            this.defaultEntityGrid.Name = "defaultEntityGrid";
            this.defaultEntityGrid.ReadOnly = true;
            this.defaultEntityGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.defaultEntityGrid.Size = new System.Drawing.Size(563, 350);
            this.defaultEntityGrid.TabIndex = 4;
            this.defaultEntityGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.defaultEntityGrid_CellDoubleClick);
            // 
            // AddressDescription
            // 
            this.AddressDescription.DataPropertyName = "AddressDescription";
            this.AddressDescription.HeaderText = "Edificio";
            this.AddressDescription.Name = "AddressDescription";
            this.AddressDescription.ReadOnly = true;
            // 
            // AreaDescription
            // 
            this.AreaDescription.DataPropertyName = "AreaDescription";
            this.AreaDescription.HeaderText = "Área";
            this.AreaDescription.Name = "AreaDescription";
            this.AreaDescription.ReadOnly = true;
            // 
            // DoorDescription
            // 
            this.DoorDescription.DataPropertyName = "DoorDescription";
            this.DoorDescription.HeaderText = "Puerta";
            this.DoorDescription.Name = "DoorDescription";
            this.DoorDescription.ReadOnly = true;
            // 
            // IP
            // 
            this.IP.DataPropertyName = "IP";
            this.IP.HeaderText = "IP";
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            // 
            // HardwareModelDescription
            // 
            this.HardwareModelDescription.DataPropertyName = "HardwareModelDescription";
            this.HardwareModelDescription.HeaderText = "Modelo";
            this.HardwareModelDescription.Name = "HardwareModelDescription";
            this.HardwareModelDescription.ReadOnly = true;
            // 
            // defaultEntityBindingSource
            // 
            this.defaultEntityBindingSource.DataSource = typeof(Model.DefaultEntity);
            // 
            // TerminalSearch
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(587, 429);
            this.Controls.Add(this.defaultEntityGrid);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClose);
            this.Name = "TerminalSearch";
            this.Text = "Búsqueda de Terminales";
            ((System.ComponentModel.ISupportInitialize)(this.defaultEntityGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultEntityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.BindingSource defaultEntityBindingSource;
        private System.Windows.Forms.DataGridView defaultEntityGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoorDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn HardwareModelDescription;
    }
}