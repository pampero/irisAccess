using IrisAccess.Extensions;
using Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace IrisAccess.Forms
{
    public partial class UserCalendarTerminalUpdate : BaseForm
    {
        public UserCalendarTerminal Result { get; protected set; }
        private Calendar _calendar;
        private Terminal _terminal;

        public UserCalendarTerminalUpdate(UserProfile user)
        {
            InitializeComponent();

            this.Text = "Alta de Configuracion para el Usuario \"" + user.FullName + "\"";
            this.Result = new UserCalendarTerminal
            {
                UserProfile = user,
            };
        }

        public UserCalendarTerminalUpdate(UserCalendarTerminal entity)
        {
            InitializeComponent();

            this._calendar = entity.Calendar;
            this._terminal = entity.Terminal;

            this.Text = "Modificación de Configuración para el Usuario \"" + entity.UserProfileDescription + "\"";
            this.txtCalendar.Text = entity.CalendarDescription;
            this.txtTerminal.Text = entity.TerminalDescription;
            this.Result = entity;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Result.Calendar = _calendar;
            this.Result.Terminal = _terminal;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSearchCalendar_Click(object sender, EventArgs e)
        {
            var searchForm = new CalendarSearch();
            var result = searchForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                this._calendar = searchForm.Result;
                this.txtCalendar.Text = searchForm.Result.Description;
            }
        }

        private void btnSearchTerminal_Click(object sender, EventArgs e)
        {
            var searchForm = new TerminalSearch();
            var result = searchForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                this._terminal = searchForm.Result;
                this.txtTerminal.Text = searchForm.Result.IP;
            }
        }
    }
}
