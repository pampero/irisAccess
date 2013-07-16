using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IrisAccess.Extensions
{
    public class UpdateForm<TEntity> : Form
    {
        public TEntity Result { get; protected set; }
    }
}
