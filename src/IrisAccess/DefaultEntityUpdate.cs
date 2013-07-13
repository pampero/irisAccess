using Model;
using System;
using System.Windows.Forms;

namespace IrisAccess
{
    public partial class DefaultEntityUpdate<TEntity> : Form where TEntity : DefaultEntity, new()
    {
        private TEntity _entity;

        public string DescriptionResult
        {
            get
            {
                return txtDescription.Text;
            }
        }

        public DefaultEntityUpdate(string entityName, TEntity entity = null)
        {
            InitializeComponent();

            this.Text = entityName + "s";
            this._entity = entity;
            lblEntityName.Text = (entity == null ? "Alta de " : "Modificación de ") + entityName;
            txtDescription.Text = entity != null ? entity.Description : string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (_entity != null)
            {
                _entity.Description = txtDescription.Text;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
