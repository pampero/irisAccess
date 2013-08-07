using IrisAccess.Extensions;
using Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace IrisAccess.Forms
{
    public partial class DoorUpdate : BaseForm
    {
        public Door Result { get; protected set; }

        public DoorUpdate(Door entity = null)
        {
            InitializeComponent();

            cmbAddress.DataSource = this.DbContext.Addresses.Where(a => !a.IsDeleted).ToList();
            
            var addressId = (int?)cmbAddress.SelectedValue;
            cmbArea.DataSource = this.DbContext.Areas.Where(a => !a.IsDeleted && a.AddressID == addressId).ToList();

            if (entity == null)
            {
                this.Text = "Alta de Puertas";
            }
            else
            {
                this.Text = "Modificación de Puerta \"" + entity.Description + "\"";

                cmbAddress.SelectedValue = entity.Area.AddressID;
                cmbArea.SelectedValue = entity.AreaID;
                txtDescription.Text = entity.Description;
            }

            this.Result = entity ?? new Door();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cmbArea.SelectedValue != null && !string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                Result.AreaID = (int)cmbArea.SelectedValue;
                Result.Description = txtDescription.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Faltan campos requeridos");
            }
        }

        private void cmbAddress_SelectedValueChanged(object sender, EventArgs e)
        {
            var addressId = (int)cmbAddress.SelectedValue;
            cmbArea.DataSource = this.DbContext.Areas.Where(a => !a.IsDeleted && a.AddressID == addressId).ToList();
        }
    }
}
