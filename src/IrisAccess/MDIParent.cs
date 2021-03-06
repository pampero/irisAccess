﻿using IrisAccess.Forms;
using Model;
using System;
using System.Windows.Forms;

namespace IrisAccess
{
    public partial class MDIParent : Form
    {
        public MDIParent()
        {
            InitializeComponent();

            this.AddDefaultEntityMenu<HardwareModel>("Modelo");
            this.AddDefaultEntityMenu<Address>("Edificio");

            this.AddEntityMenu<AreaList>("Área");
            this.AddEntityMenu<DoorList>("Puerta");
        }

        private void AddEntityMenu<TForm>(string entityName) where TForm : Form, new()
        {
            var item = new ToolStripMenuItem
            {
                Text = entityName + "s",
            };

            item.Click += delegate(object o, EventArgs e)
            {
                var form = new TForm();
                form.MdiParent = this;
                form.Show();
            };

            entitiesToolStripMenuItem.DropDownItems.Add(item);
        }

        private void AddDefaultEntityMenu<TEntity>(string entityName) where TEntity : DefaultEntity, new()
        {
            var item = new ToolStripMenuItem
            {
                Text = entityName + "s",
            };

            item.Click += delegate(object o, EventArgs e)
            {
                var form = new DefaultEntityList<TEntity>(entityName);
                form.MdiParent = this;
                form.Show();
            };

            entitiesToolStripMenuItem.DropDownItems.Add(item);
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open<UserProfileList>();
        }

        private void terminalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open<TerminalList>();
        }

        private void calendariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open<CalendarList>();
        }

        private void Open<TForm>() where TForm : Form, new()
        {
            var form = new TForm();
            form.MdiParent = this;
            form.Show();
        }
    }
}
