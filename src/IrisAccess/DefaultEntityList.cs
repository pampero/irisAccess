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
    public partial class DefaultEntityList<TEntity> : Form where TEntity : DefaultEntity, new()
    {
        private DefaultEntityRepository<TEntity>  _repository;
        private AppDbContext _context;
        private string _entityName;

        public DefaultEntityList(string entityName)
        {
            InitializeComponent();
            
            _context = Program.Container.Resolve<AppDbContext>();
            _repository = new DefaultEntityRepository<TEntity>(_context);
            _entityName = entityName;

            this.defaultEntityGrid.AutoGenerateColumns = false;
            this.Text = entityName + "s";
            this.RefreshGrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var term = txtSearch.Text;

            this.RefreshGrid(term);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var createForm = new DefaultEntityUpdate<TEntity>(_entityName);
            var result = createForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _repository.Insert(createForm.DescriptionResult);
                this.RefreshGrid();
            }
        }

        private void RefreshGrid(string term = null)
        {
            var list = _repository.Get(_ => string.IsNullOrEmpty(term) || _.Description.Contains(term));

            txtSearch.Text = term;
            defaultEntityGrid.DataSource = list;
        }
    }
}
