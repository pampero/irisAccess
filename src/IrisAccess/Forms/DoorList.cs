using IrisAccess.Extensions;
using Model;
using Model.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IrisAccess.Forms
{
    public partial class DoorList : BaseForm
    {
        private IGenericUpdatableRepository<Door> _repository;
        private GridInitializer<Door> _grid;

        public DoorList()
        {
            InitializeComponent();

            this._repository = new GenericUpdatableRepository<Door>(this.DbContext);
            this._grid = this.defaultEntityGrid.Initialize<Door>()
                .SetSearchButton(btnSearch)
                .SetSearchText(txtSearch)
                .SetSearchMethod(this.GetEntities);

            this._grid.Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var createForm = new DoorUpdate();
            var result = createForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _repository.Insert(createForm.Result);
                this._grid.Refresh();
            }
        }

        private IEnumerable<Door> GetEntities(string term = null)
        {
            return _repository.Get(
                filter:_ => string.IsNullOrEmpty(term) || 
                    _.Description.Contains(term) ||
                    _.Area.Description.Contains(term) ||
                    _.Area.Address.Description.Contains(term),
                includeProperties: "Area,Area.Address"
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
                var editForm = new DoorUpdate(this.SelectedItem);
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
            if (this.SelectedItem != null && MessageBox.Show("¿Confirma que desea borrar la Puerta \"" + this.SelectedItem.Description + "\"?", "Puertas", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _repository.Delete(this.SelectedItem.ID);
                this._grid.Refresh();
            }
        }

        private Door SelectedItem
        {
            get
            {
                if (this.defaultEntityGrid.SelectedRows.Count > 0)
                {
                    return (Door)this.defaultEntityGrid.SelectedRows[0].DataBoundItem;
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
