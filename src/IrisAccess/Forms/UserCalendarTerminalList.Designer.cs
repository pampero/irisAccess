namespace IrisAccess.Forms
{
    partial class UserCalendarTerminalList
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.defaultEntityGrid = new System.Windows.Forms.DataGridView();
            this.defaultEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CalendarDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TerminalDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.defaultEntityGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultEntityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(408, 360);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(359, 12);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(124, 23);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Agregar Configuración";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // defaultEntityGrid
            // 
            this.defaultEntityGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultEntityGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.defaultEntityGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CalendarDescription,
            this.TerminalDescription,
            this.btnEdit,
            this.btnDelete});
            this.defaultEntityGrid.Location = new System.Drawing.Point(12, 38);
            this.defaultEntityGrid.MultiSelect = false;
            this.defaultEntityGrid.Name = "defaultEntityGrid";
            this.defaultEntityGrid.ReadOnly = true;
            this.defaultEntityGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.defaultEntityGrid.Size = new System.Drawing.Size(471, 316);
            this.defaultEntityGrid.TabIndex = 4;
            this.defaultEntityGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.defaultEntityGrid_CellContentClick);
            this.defaultEntityGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.defaultEntityGrid_CellDoubleClick);
            // 
            // defaultEntityBindingSource
            // 
            this.defaultEntityBindingSource.DataSource = typeof(Model.DefaultEntity);
            // 
            // CalendarDescription
            // 
            this.CalendarDescription.DataPropertyName = "CalendarDescription";
            this.CalendarDescription.HeaderText = "Calendario";
            this.CalendarDescription.Name = "CalendarDescription";
            this.CalendarDescription.ReadOnly = true;
            // 
            // TerminalDescription
            // 
            this.TerminalDescription.DataPropertyName = "TerminalDescription";
            this.TerminalDescription.HeaderText = "Terminal";
            this.TerminalDescription.Name = "TerminalDescription";
            this.TerminalDescription.ReadOnly = true;
            // 
            // btnEdit
            // 
            this.btnEdit.HeaderText = "Editar";
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ReadOnly = true;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseColumnTextForButtonValue = true;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Borrar";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // UserCalendarTerminalList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(495, 395);
            this.Controls.Add(this.defaultEntityGrid);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnClose);
            this.Name = "UserCalendarTerminalList";
            this.Text = "Configuración de Terminales por Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.defaultEntityGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultEntityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.BindingSource defaultEntityBindingSource;
        private System.Windows.Forms.DataGridView defaultEntityGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalendarDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerminalDescription;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}