using IrisAccess.Extensions;
using Model;
using Model.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IrisAccess.Forms
{
    public partial class AreaList : BaseForm
    {
        private IGenericUpdatableRepository<Area> _repository;
        private GridInitializer<Area> _grid;

        public AreaList()
        {
            InitializeComponent();

            this._repository = new GenericUpdatableRepository<Area>(this.DbContext);
            this._grid = this.defaultEntityGrid.Initialize<Area>()
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
            var createForm = new AreaUpdate();
            var result = createForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _repository.Insert(createForm.Result);
                this._grid.Refresh();
            }
        }

        private IEnumerable<Area> GetEntities(string term = null)
        {
            return _repository.Get(
                filter:_ => string.IsNullOrEmpty(term) ||
                    _.Description.Contains(term) ||
                    _.Address.Description.Contains(term),
                includeProperties: "Address"
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
                var editForm = new AreaUpdate(this.SelectedItem);
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
            if (this.SelectedItem != null && MessageBox.Show("¿Confirma que desea borrar el Área \"" + this.SelectedItem.Description + "\"?", "Áreas", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _repository.Delete(this.SelectedItem.ID);
                this._grid.Refresh();
            }
        }

        private Area SelectedItem
        {
            get
            {
                if (this.defaultEntityGrid.SelectedRows.Count > 0)
                {
                    return (Area)this.defaultEntityGrid.SelectedRows[0].DataBoundItem;
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
