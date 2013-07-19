using IrisAccess.Extensions;
using Model;
using Model.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IrisAccess.Forms
{
    public partial class TerminalList : BaseForm
    {
        private IGenericUpdatableRepository<Terminal> _repository;
        private GridInitializer<Terminal> _grid;

        public TerminalList()
        {
            InitializeComponent();

            this._repository = new GenericUpdatableRepository<Terminal>(this.DbContext);
            this._grid = this.defaultEntityGrid.Initialize<Terminal>()
                .SetSearchButton(btnSearch)
                .SetSearchText(txtSearch)
                .SetSearchMethod(this.GetEntities);

            this.defaultEntityGrid.AutoGenerateColumns = false;
            this._grid.Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var createForm = new TerminalUpdate();
            var result = createForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _repository.Insert(createForm.Result);
                this._grid.Refresh();
            }
        }

        private IEnumerable<Terminal> GetEntities(string term = null)
        {
            return _repository.Get(
                filter:_ => string.IsNullOrEmpty(term) || 
                    _.IP.Contains(term) || 
                    _.Address.Description.Contains(term) ||
                    _.HardwareModel.Description.Contains(term) ||
                    _.Door.Description.Contains(term) ||
                    _.Area.Description.Contains(term),
                includeProperties: "Address,Area,Door,HardwareModel"
            );
        }

        private void defaultEntityGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.defaultEntityGrid.Columns[e.ColumnIndex] == btnEdit)
            {
                EditSelected();
            }
            else if (this.defaultEntityGrid.Columns[e.ColumnIndex] == btnDelete)
            {
                DeleteSelected();
            }
        }

        private void EditSelected()
        {
            if (this.SelectedItem != null)
            {
                var editForm = new TerminalUpdate(this.SelectedItem);
                var result = editForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _repository.Update(editForm.Result);
                    this._grid.Refresh();
                }
            }
        }

        private void DeleteSelected()
        {
            if (this.SelectedItem != null && MessageBox.Show("¿Confirma que desea borrar la Terminal \"" + this.SelectedItem.IP + "\"?", "Terminales", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _repository.Delete(this.SelectedItem.ID);
                this._grid.Refresh();
            }
        }

        private Terminal SelectedItem
        {
            get
            {
                if (this.defaultEntityGrid.SelectedRows.Count > 0)
                {
                    return (Terminal)this.defaultEntityGrid.SelectedRows[0].DataBoundItem;
                }

                return null;
            }
        }

        private void defaultEntityGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.EditSelected();
        }
    }
}
