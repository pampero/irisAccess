using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IrisAccess.Extensions
{
    public static class GridExtensions
    {
        public static GridInitializer<TEntity> Initialize<TEntity>(this DataGridView gridView) where TEntity : class
        {
            return new GridInitializer<TEntity>(gridView);
        }

        public static TEntity GetSelected<TEntity>(this DataGridView gridView) where TEntity : class
        {
            if (gridView.SelectedRows.Count > 0)
            {
                return (TEntity)gridView.SelectedRows[0].DataBoundItem;
            }

            return null;
        }
    }
}
