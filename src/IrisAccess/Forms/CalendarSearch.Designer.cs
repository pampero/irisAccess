namespace IrisAccess.Forms
{
    partial class CalendarSearch
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
            this.defaultEntityGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defaultEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.defaultEntityGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultEntityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(530, 307);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Cancelar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // defaultEntityGrid
            // 
            this.defaultEntityGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultEntityGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.defaultEntityGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.StartTime,
            this.EndTime,
            this.StartDate,
            this.EndDate,
            this.Days});
            this.defaultEntityGrid.Location = new System.Drawing.Point(12, 12);
            this.defaultEntityGrid.MultiSelect = false;
            this.defaultEntityGrid.Name = "defaultEntityGrid";
            this.defaultEntityGrid.ReadOnly = true;
            this.defaultEntityGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.defaultEntityGrid.Size = new System.Drawing.Size(593, 289);
            this.defaultEntityGrid.TabIndex = 4;
            this.defaultEntityGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.defaultEntityGrid_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "N°";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // StartTime
            // 
            this.StartTime.DataPropertyName = "StartTimeText";
            this.StartTime.HeaderText = "Hora Inicial";
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            this.StartTime.Width = 90;
            // 
            // EndTime
            // 
            this.EndTime.DataPropertyName = "EndTimeText";
            this.EndTime.HeaderText = "Hora Fin";
            this.EndTime.Name = "EndTime";
            this.EndTime.ReadOnly = true;
            this.EndTime.Width = 90;
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDateText";
            this.StartDate.HeaderText = "Fecha Inicial";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDateText";
            this.EndDate.HeaderText = "Fecha Fin";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // Days
            // 
            this.Days.DataPropertyName = "DaysText";
            this.Days.HeaderText = "Días";
            this.Days.Name = "Days";
            this.Days.ReadOnly = true;
            // 
            // defaultEntityBindingSource
            // 
            this.defaultEntityBindingSource.DataSource = typeof(Model.DefaultEntity);
            // 
            // CalendarSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(617, 342);
            this.Controls.Add(this.defaultEntityGrid);
            this.Controls.Add(this.btnClose);
            this.Name = "CalendarSearch";
            this.Text = "Búsqueda de Calendarios";
            ((System.ComponentModel.ISupportInitialize)(this.defaultEntityGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultEntityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource defaultEntityBindingSource;
        private System.Windows.Forms.DataGridView defaultEntityGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Days;
    }
}