using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IrisAccess.Extensions
{
    public class GridInitializer<TEntity> where TEntity : class
    {
        private DataGridView _gridView;
        private TextBox _txtSearch;
        private Button _btnSearch;
        private Func<string, IEnumerable<TEntity>> _searchAction;

        public GridInitializer(DataGridView gridView)
        {
            _gridView = gridView;
            _gridView.AutoGenerateColumns = false;
        }

        public GridInitializer<TEntity> SetSearchText(TextBox txtSearch)
        {
            _txtSearch = txtSearch;

            if (_btnSearch != null && _searchAction != null)
            {
                InitializeSearch();
            }

            return this;
        }

        public GridInitializer<TEntity> SetSearchButton(Button btnSearch)
        {
            _btnSearch = btnSearch;

            if (_txtSearch != null && _searchAction != null)
            {
                InitializeSearch();
            }

            return this;
        }

        public GridInitializer<TEntity> SetSearchMethod(Func<string, IEnumerable<TEntity>> searchAction)
        {
            _searchAction = searchAction;

            if (_txtSearch != null && _btnSearch != null)
            {
                InitializeSearch();
            }

            return this;
        }

        private void InitializeSearch()
        {
            _btnSearch.Click += new System.EventHandler(this.innerSearchEvent);
            Refresh();
        }

        private void innerSearchEvent(object sender, EventArgs e)
        {
            Refresh();
        }

        public void Refresh()
        {
            var term = _txtSearch.Text;
            var list = _searchAction(term);

            _gridView.DataSource = list;
        }
    }
}
