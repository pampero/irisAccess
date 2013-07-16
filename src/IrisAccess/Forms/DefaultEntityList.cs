using IrisAccess.Extensions;
using Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IrisAccess.Forms
{
    public partial class DefaultEntityList<TEntity> : BaseForm where TEntity : DefaultEntity, new()
    {
        private DefaultEntityRepository<TEntity>  _repository;
        private string _entityName;
        private GridInitializer<TEntity> _grid;

        public DefaultEntityList(string entityName)
        {
            InitializeComponent();
            
            _repository = new DefaultEntityRepository<TEntity>(this.DbContext);
            _entityName = entityName;

            this.Text = entityName + "s";

            this._grid = this.defaultEntityGrid.Initialize<TEntity>()
                .SetSearchButton(btnSearch)
                .SetSearchText(txtSearch)
                .SetSearchMethod(this.GetEntities);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var createForm = new DefaultEntityUpdate<TEntity>(_entityName);
            var result = createForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _repository.Insert(createForm.Result);
                this._grid.Refresh();
            }
        }

        private IEnumerable<TEntity> GetEntities(string term = null)
        {
            return _repository.Get(_ => string.IsNullOrEmpty(term) || _.Description.Contains(term));
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
            var item = this.defaultEntityGrid.GetSelected<TEntity>();

            if (item != null)
            {
                var editForm = new DefaultEntityUpdate<TEntity>(_entityName, item);
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
            var item = this.defaultEntityGrid.GetSelected<TEntity>();

            if (item != null && MessageBox.Show("¿Confirma que desea borrar el " + _entityName + " \"" + item.Description + "\"?", _entityName + "s", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _repository.Delete(item.ID);
                this._grid.Refresh();
            }
        }

        private void defaultEntityGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.EditSelected();
        }
    }
}
