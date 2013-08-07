using IrisAccess.Extensions;
using Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace IrisAccess.Forms
{
    public partial class TerminalUpdate : BaseForm
    {
        public Terminal Result { get; protected set; }

        public TerminalUpdate(Terminal entity = null)
        {
            InitializeComponent();

            cmbAddress.DataSource = this.DbContext.Addresses.Where(a => !a.IsDeleted).ToList();
            cmbHardwareModel.DataSource = this.DbContext.HardwareModels.Where(a => !a.IsDeleted).ToList();

            if (entity == null)
            {
                this.Text = "Alta de Terminales";
            }
            else
            {
                this.Text = "Modificación de Terminal \"" + entity.IP + "\"";

                cmbAddress.SelectedValue = entity.Door.Area.AddressID;
                cmbArea.SelectedValue = entity.Door.AreaID;
                cmbDoor.SelectedValue = entity.DoorID;
                txtIP.Text = entity.IP;
                cmbHardwareModel.SelectedValue = entity.HardwareModelID;
            }

            this.Result = entity ?? new Terminal();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cmbDoor.SelectedValue != null && cmbHardwareModel.SelectedValue != null && !string.IsNullOrEmpty(txtIP.Text.Trim()))
            {
                Result.DoorID = (int)cmbDoor.SelectedValue;
                Result.IP = txtIP.Text;
                Result.HardwareModelID = (int)cmbHardwareModel.SelectedValue;

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
            var addressId = (int?)cmbAddress.SelectedValue;
            cmbArea.DataSource = this.DbContext.Areas.Where(a => !a.IsDeleted && a.AddressID == addressId).ToList();
        }

        private void cmbArea_SelectedValueChanged(object sender, EventArgs e)
        {
            var areaId = (int?)cmbArea.SelectedValue;
            cmbDoor.DataSource = this.DbContext.Doors.Where(a => !a.IsDeleted && a.AreaID == areaId).ToList();
        }
    }
}
