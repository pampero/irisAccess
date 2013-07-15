using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IrisAccess.Extensions
{
    public class BaseForm : Form
    {
        private AppDbContext _dbContext = null;

        protected AppDbContext DbContext
        {
            get
            {
                if (_dbContext == null)
                {
                    _dbContext = Program.Container.Resolve<AppDbContext>();
                }

                return _dbContext;
            }
        }
    }
}
