﻿namespace IrisAccess.Forms
{
    partial class DoorList
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.defaultEntityGrid = new System.Windows.Forms.DataGridView();
            this.defaultEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnClose.Location = new System.Drawing.Point(691, 394);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(610, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(691, 12);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Alta";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(12, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(592, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // defaultEntityGrid
            // 
            this.defaultEntityGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultEntityGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.defaultEntityGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.AreaDescription,
            this.AddressDescription,
            this.btnEdit,
            this.btnDelete});
            this.defaultEntityGrid.Location = new System.Drawing.Point(12, 38);
            this.defaultEntityGrid.MultiSelect = false;
            this.defaultEntityGrid.Name = "defaultEntityGrid";
            this.defaultEntityGrid.ReadOnly = true;
            this.defaultEntityGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.defaultEntityGrid.Size = new System.Drawing.Size(754, 350);
            this.defaultEntityGrid.TabIndex = 4;
            this.defaultEntityGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.defaultEntityGrid_CellContentClick);
            this.defaultEntityGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.defaultEntityGrid_CellDoubleClick);
            // 
            // defaultEntityBindingSource
            // 
            this.defaultEntityBindingSource.DataSource = typeof(Model.DefaultEntity);
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Descripción";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // AreaDescription
            // 
            this.AreaDescription.DataPropertyName = "AreaDescription";
            this.AreaDescription.HeaderText = "Área";
            this.AreaDescription.Name = "AreaDescription";
            this.AreaDescription.ReadOnly = true;
            // 
            // AddressDescription
            // 
            this.AddressDescription.DataPropertyName = "AddressDescription";
            this.AddressDescription.HeaderText = "Edificio";
            this.AddressDescription.Name = "AddressDescription";
            this.AddressDescription.ReadOnly = true;
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
            // DoorList
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(778, 429);
            this.Controls.Add(this.defaultEntityGrid);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClose);
            this.Name = "DoorList";
            this.Text = "Puertas";
            ((System.ComponentModel.ISupportInitialize)(this.defaultEntityGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultEntityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.BindingSource defaultEntityBindingSource;
        private System.Windows.Forms.DataGridView defaultEntityGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressDescription;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}