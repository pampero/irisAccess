using IrisAccess.Extensions;
using Model;
using Model.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IrisAccess.Forms
{
    public partial class TerminalSearch : BaseForm
    {
        public Terminal Result { get; protected set; }
        private IGenericUpdatableRepository<Terminal> _repository;
        private GridInitializer<Terminal> _grid;

        public TerminalSearch()
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
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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
            this.DialogResult = DialogResult.OK;
            this.Result = this.SelectedItem;
            this.Close();
        }
    }
}
