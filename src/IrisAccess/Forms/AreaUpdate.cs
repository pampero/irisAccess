using IrisAccess.Extensions;
using Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace IrisAccess.Forms
{
    public partial class AreaUpdate : BaseForm
    {
        public Area Result { get; protected set; }

        public AreaUpdate(Area entity = null)
        {
            InitializeComponent();

            cmbAddress.DataSource = this.DbContext.Addresses.Where(a => !a.IsDeleted).ToList();

            if (entity == null)
            {
                this.Text = "Alta de Áreas";
            }
            else
            {
                this.Text = "Modificación de Área \"" + entity.Description + "\"";

                cmbAddress.SelectedValue = entity.AddressID;
                txtDescription.Text = entity.Description;
            }

            this.Result = entity ?? new Area();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cmbAddress.SelectedValue != null && !string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                Result.AddressID = (int)cmbAddress.SelectedValue;
                Result.Description = txtDescription.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Faltan campos requeridos");
            }
        }
    }
}
