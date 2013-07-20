using IrisAccess.Extensions;
using Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace IrisAccess.Forms
{
    public partial class CalendarUpdate : BaseForm
    {
        public Calendar Result { get; protected set; }

        public CalendarUpdate(Calendar entity = null)
        {
            InitializeComponent();

            if (entity == null)
            {
                this.Text = "Alta de Calendarios";

                dtpStartTime.Enabled = false;
                dtpEndTime.Enabled = false;
                dtpStartDate.Enabled = false;
                dtpEndDate.Enabled = false;
                chkMonday.Enabled = false;
                chkTuesday.Enabled = false;
                chkWednesday.Enabled = false;
                chkThursday.Enabled = false;
                chkFriday.Enabled = false;
                chkSaturday.Enabled = false;
                chkSunday.Enabled = false;
            }
            else
            {
                this.Text = "Modificación de Calendario \"" + entity.ID + "\"";

                if (entity.StartTime != null && entity.EndTime != null)
                {
                    chkTime.Checked = true;
                    dtpStartTime.Value = entity.StartTime.Value;
                    dtpEndTime.Value = entity.EndTime.Value;
                }
                else
                {
                    dtpStartTime.Enabled = false;
                    dtpEndTime.Enabled = false;
                }

                if (entity.StartDate != null && entity.EndDate != null)
                {
                    chkDate.Checked = true;
                    dtpStartDate.Value = entity.StartDate.Value;
                    dtpEndDate.Value = entity.EndDate.Value;
                }
                else
                {
                    dtpStartDate.Enabled = false;
                    dtpEndDate.Enabled = false;
                }

                if (entity.OnMonday != null && entity.OnTuesday != null && entity.OnWednesday != null && entity.OnThursday != null && entity.OnFriday != null && entity.OnSaturday != null && entity.OnSunday != null)
                {
                    chkDays.Checked = true;
                    chkMonday.Checked = entity.OnMonday.Value;
                    chkTuesday.Checked = entity.OnTuesday.Value;
                    chkWednesday.Checked = entity.OnWednesday.Value;
                    chkThursday.Checked = entity.OnThursday.Value;
                    chkFriday.Checked = entity.OnFriday.Value;
                    chkSaturday.Checked = entity.OnSaturday.Value;
                    chkSunday.Checked = entity.OnSunday.Value;
                }
                else
                {
                    chkMonday.Enabled = false;
                    chkTuesday.Enabled = false;
                    chkWednesday.Enabled = false;
                    chkThursday.Enabled = false;
                    chkFriday.Enabled = false;
                    chkSaturday.Enabled = false;
                    chkSunday.Enabled = false;
                }
            }

            this.Result = entity ?? new Calendar();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Result.StartTime = chkTime.Checked ? (DateTime?)dtpStartTime.Value : null;
            Result.EndTime = chkTime.Checked ? (DateTime?)dtpEndTime.Value : null;
            Result.StartDate = chkDate.Checked ? (DateTime?)dtpStartDate.Value : null;
            Result.EndDate = chkDate.Checked ? (DateTime?)dtpEndDate.Value : null;
            Result.OnMonday = chkDays.Checked ? (bool?)chkMonday.Checked : null;
            Result.OnTuesday = chkDays.Checked ? (bool?)chkTuesday.Checked : null;
            Result.OnWednesday = chkDays.Checked ? (bool?)chkWednesday.Checked : null;
            Result.OnThursday = chkDays.Checked ? (bool?)chkThursday.Checked : null;
            Result.OnFriday = chkDays.Checked ? (bool?)chkFriday.Checked : null;
            Result.OnSaturday = chkDays.Checked ? (bool?)chkSaturday.Checked : null;
            Result.OnSunday = chkDays.Checked ? (bool?)chkSunday.Checked : null;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void chkDays_CheckedChanged(object sender, EventArgs e)
        {
            chkMonday.Enabled = chkDays.Checked;
            chkTuesday.Enabled = chkDays.Checked;
            chkWednesday.Enabled = chkDays.Checked;
            chkThursday.Enabled = chkDays.Checked;
            chkFriday.Enabled = chkDays.Checked;
            chkSaturday.Enabled = chkDays.Checked;
            chkSunday.Enabled = chkDays.Checked;
        }

        private void chkTime_CheckedChanged(object sender, EventArgs e)
        {
            dtpStartTime.Enabled = chkTime.Checked;
            dtpEndTime.Enabled = chkTime.Checked;
        }

        private void chkDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = chkDate.Checked;
            dtpEndDate.Enabled = chkDate.Checked;
        }
    }
}
