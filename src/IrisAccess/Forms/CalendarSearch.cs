using IrisAccess.Extensions;
using Model;
using Model.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IrisAccess.Forms
{
    public partial class CalendarSearch : BaseForm
    {
        public Calendar Result { get; protected set; }
        private IGenericUpdatableRepository<Calendar> _repository;

        public CalendarSearch()
        {
            InitializeComponent();

            this._repository = new GenericUpdatableRepository<Calendar>(this.DbContext);
            this.defaultEntityGrid.AutoGenerateColumns = false;
            this.RefreshGrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void RefreshGrid()
        {
            this.defaultEntityGrid.DataSource = _repository.Get();
        }

        private Calendar SelectedItem
        {
            get
            {
                if (this.defaultEntityGrid.SelectedRows.Count > 0)
                {
                    return (Calendar)this.defaultEntityGrid.SelectedRows[0].DataBoundItem;
                }

                return null;
            }
        }

        private void defaultEntityGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Result = this.SelectedItem;
            this.Close();
        }
    }
}
