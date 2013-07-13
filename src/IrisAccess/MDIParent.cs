using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IrisAccess
{
    public partial class MDIParent : Form
    {
        private int childFormNumber = 0;

        public MDIParent()
        {
            InitializeComponent();

            this.AddDefaultEntityMenu<HardwareModel>("Modelo");
            this.AddDefaultEntityMenu<Area>("Area");
            this.AddDefaultEntityMenu<Door>("Puerta");
            this.AddDefaultEntityMenu<Address>("Edificio");
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
    }
}
