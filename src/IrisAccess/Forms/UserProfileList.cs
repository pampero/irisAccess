using IrisAccess.Extensions;
using Model;
using Model.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IrisAccess.Forms
{
    public partial class UserProfileList : BaseForm
    {
        private IGenericUpdatableRepository<UserProfile> _repository;
        private GridInitializer<UserProfile> _grid;

        public UserProfileList()
        {
            InitializeComponent();

            this._repository = new GenericUpdatableRepository<UserProfile>(this.DbContext);
            this._grid = this.defaultEntityGrid.Initialize<UserProfile>()
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
            var createForm = new UserProfileUpdate();
            var result = createForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _repository.Insert(createForm.Result);
                this._grid.Refresh();
            }
        }

        private IEnumerable<UserProfile> GetEntities(string term = null)
        {
            return _repository.Get(_ => string.IsNullOrEmpty(term) || 
                _.FirstName.Contains(term) || 
                _.LastName.Contains(term) || 
                _.FileId.Contains(term) || 
                _.Identification.Contains(term));
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
                    this._grid.Refresh();
                }
            }
        }

        private void DeleteSelected()
        {
            if (this.SelectedItem != null && MessageBox.Show("¿Confirma que desea borrar el Usuario \"" + this.SelectedItem.FirstName + "\"?", "Usuarios", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _repository.Delete(this.SelectedItem.ID);
                this._grid.Refresh();
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
