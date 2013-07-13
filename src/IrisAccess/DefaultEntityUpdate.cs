using Model;
using System;
using System.Windows.Forms;

namespace IrisAccess
{
    public partial class DefaultEntityUpdate<TEntity> : Form where TEntity : DefaultEntity, new()
    {
        public string DescriptionResult
        {
            get
            {
                return txtDescription.Text;
            }
        }

        public DefaultEntityUpdate(string entityName, string description = null)
        {
            InitializeComponent();

            this.Text = entityName + "s";
            lblEntityName.Text = (description == null ? "Alta de " : "Modificación de ") + entityName;
            txtDescription.Text = description;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
