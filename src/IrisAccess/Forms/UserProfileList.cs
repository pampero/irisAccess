using IrisAccess.Extensions;
using Model;
using Model.Repositories.Interfaces;
using System;
using System.Windows.Forms;

namespace IrisAccess.Forms
{
    public partial class UserProfileList : BaseForm
    {
        private IGenericUpdatableRepository<UserProfile> _repository;

        public UserProfileList()
        {
            InitializeComponent();

            _repository = new GenericUpdatableRepository<UserProfile>(this.DbContext);
            this.defaultEntityGrid.AutoGenerateColumns = false;
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
            var createForm = new UserProfileUpdate();
            var result = createForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _repository.Insert(createForm.Result);
                this.RefreshGrid();
            }
        }

        private void RefreshGrid(string term = null)
        {
            var list = _repository.Get(_ => string.IsNullOrEmpty(term) || 
                _.FirstName.Contains(term) || 
                _.LastName.Contains(term) || 
                _.FileId.Contains(term) || 
                _.Identification.Contains(term));

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
                var editForm = new UserProfileUpdate(this.SelectedItem);
                var result = editForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _repository.Update(editForm.Result);

                    this.RefreshGrid();
                }
            }
        }

        private void DeleteSelected()
        {
            if (this.SelectedItem != null && MessageBox.Show("¿Confirma que desea borrar el Usuario \"" + this.SelectedItem.FirstName + "\"?", "Usuarios", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _repository.Delete(this.SelectedItem.ID);
                this.RefreshGrid();
            }
        }

        private UserProfile SelectedItem
        {
            get
            {
                if (this.defaultEntityGrid.SelectedRows.Count > 0)
                {
                    return (UserProfile)this.defaultEntityGrid.SelectedRows[0].DataBoundItem;
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
