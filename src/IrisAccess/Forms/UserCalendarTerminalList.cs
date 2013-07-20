using IrisAccess.Extensions;
using Model;
using Model.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IrisAccess.Forms
{
    public partial class UserCalendarTerminalList : BaseForm
    {
        private IGenericUpdatableRepository<UserCalendarTerminal> _repository;
        private UserProfile _userProfile;

        public UserCalendarTerminalList(UserProfile user)
        {
            InitializeComponent();

            this._userProfile = user;
            this._repository = new GenericUpdatableRepository<UserCalendarTerminal>(this.DbContext);
            this.defaultEntityGrid.AutoGenerateColumns = false;
            this.Text = "Configuración de Terminales para el Usuario " + user.FullName;
            this.RefreshGrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var createForm = new UserCalendarTerminalUpdate(_userProfile);
            var result = createForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _repository.Insert(createForm.Result);
                this.RefreshGrid();
            }
        }

        private void RefreshGrid()
        {
            this.defaultEntityGrid.DataSource = _repository.Get(
                filter: _ => _.UserProfileID == _userProfile.ID,
                includeProperties: "Calendar,UserProfile,Terminal"
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
                var editForm = new UserCalendarTerminalUpdate(this.SelectedItem);
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
            if (this.SelectedItem != null && MessageBox.Show("¿Confirma que desea borrar la configuración?", "Configuraciones", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _repository.Delete(this.SelectedItem.ID);
                this.RefreshGrid();
            }
        }

        private UserCalendarTerminal SelectedItem
        {
            get
            {
                if (this.defaultEntityGrid.SelectedRows.Count > 0)
                {
                    return (UserCalendarTerminal)this.defaultEntityGrid.SelectedRows[0].DataBoundItem;
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
