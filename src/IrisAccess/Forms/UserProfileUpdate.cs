using IrisAccess.Extensions;
using Model;
using System;
using System.Windows.Forms;

namespace IrisAccess.Forms
{
    public partial class UserProfileUpdate : Form
    {
        public UserProfile Result { get; protected set; }

        public UserProfileUpdate(UserProfile entity = null)
        {
            InitializeComponent();

            if (entity == null)
            {
                this.Text = "Alta de Usuarios";
            }
            else
            {
                this.Text = "Modificación de Usuario \"" + entity.FullName + "\"";

                txtFileId.Text = entity.FileId;
                txtFirstName.Text = entity.FirstName;
                txtLastName.Text = entity.LastName;
                txtIdentification.Text = entity.Identification;
                rbMale.Checked = entity.IsMale;
                rbFemale.Checked = !entity.IsMale;
                dtpBirthdate.Value = entity.Birthdate ?? DateTime.Now;
                txtEmail.Text = entity.Email;
            }

            this.Result = entity ?? new UserProfile();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Result.FileId = txtFileId.Text;
            Result.FirstName = txtFirstName.Text;
            Result.LastName = txtLastName.Text;
            Result.Identification = txtIdentification.Text;
            Result.IsMale = rbMale.Checked;
            Result.Birthdate = dtpBirthdate.Value;
            Result.Email = txtEmail.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            rbFemale.Checked = !rbMale.Checked;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            rbMale.Checked = !rbFemale.Checked;
        }

        private void btnConfiguration_Click(object sender, EventArgs e)
        {
            if (this.Result.ID == 0)
            {
                MessageBox.Show("Debe guardar el usuario antes de cambiar la configuración");
                return;
            }

            var configurationForm = new UserCalendarTerminalList(this.Result);
            var result = configurationForm.ShowDialog();
        }
    }
}
