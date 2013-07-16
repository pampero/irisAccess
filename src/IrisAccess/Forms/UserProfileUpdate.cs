﻿using IrisAccess.Extensions;
using Model;
using System;
using System.Windows.Forms;

namespace IrisAccess.Forms
{
    public partial class UserProfileUpdate : UpdateForm<UserProfile>
    {
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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Result = new UserProfile
            {
                FileId = txtFileId.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Identification = txtIdentification.Text,
                IsMale = rbMale.Checked,
                Birthdate = dtpBirthdate.Value,
                Email = txtEmail.Text,
            };

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
    }
}
