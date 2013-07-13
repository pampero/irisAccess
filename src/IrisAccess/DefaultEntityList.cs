using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IrisAccess
{
    public partial class DefaultEntityList<TEntity> : Form where TEntity : DefaultEntity, new()
    {
        private DefaultEntityRepository<TEntity>  _repository;
        private AppDbContext _context;
        private string _entityName;

        public DefaultEntityList(string entityName)
        {
            InitializeComponent();
            
            _context = Program.Container.Resolve<AppDbContext>();
            _repository = new DefaultEntityRepository<TEntity>(_context);
            _entityName = entityName;

            this.defaultEntityGrid.AutoGenerateColumns = false;
            this.Text = entityName + "s";
            this.RefreshGrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var term = txtSearch.Text;

            this.RefreshGrid(term);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var createForm = new DefaultEntityUpdate<TEntity>(_entityName);
            var result = createForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _repository.Insert(createForm.DescriptionResult);
                this.RefreshGrid();
            }
        }

        private void RefreshGrid(string term = null)
        {
            var list = _repository.Get(_ => string.IsNullOrEmpty(term) || _.Description.Contains(term));

            txtSearch.Text = term;
            defaultEntityGrid.DataSource = list;
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
                var editForm = new DefaultEntityUpdate<TEntity>(_entityName, this.SelectedItem);
                var result = editForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    var entityToUpdate = _repository.GetByID(this.SelectedItem.ID);
                    entityToUpdate.Description = editForm.DescriptionResult;
                    _repository.Update(entityToUpdate);

                    this.RefreshGrid();
                }
            }
        }

        private void DeleteSelected()
        {
            if (this.SelectedItem != null && MessageBox.Show("¿Confirma que desea borrar el " + _entityName + " \"" + this.SelectedItem.Description + "\"?", _entityName + "s", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _repository.Delete(this.SelectedItem.ID);
                this.RefreshGrid();
            }
        }

        private TEntity SelectedItem
        {
            get
            {
                if (this.defaultEntityGrid.SelectedRows.Count > 0)
                {
                    return (TEntity)this.defaultEntityGrid.SelectedRows[0].DataBoundItem;
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
