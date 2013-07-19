using IrisAccess.Extensions;
using Model;
using System;
using System.Windows.Forms;

namespace IrisAccess.Forms
{
    public partial class DefaultEntityUpdate<TEntity> : Form where TEntity : DefaultEntity, new()
    {
        public TEntity Result { get; protected set; }

        public DefaultEntityUpdate(string entityName, TEntity entity = null)
        {
            InitializeComponent();

            this.Text = entityName + "s";
            this.Result = entity ?? new TEntity();

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
            this.Result.Description = txtDescription.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
