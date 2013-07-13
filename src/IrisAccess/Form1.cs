using System.Windows.Forms;
using ServiceStack.Logging;
using ServiceStack.Logging.Log4Net;
using Services.interfaces;

namespace IrisAccess
{
    public partial class Form1 : Form
    {
        public IAttributesService _attributesService { get; set; }

        public Form1()
        {
            InitializeComponent();
              // TODO: Esto debería ser automático
            _attributesService = Program.Container.Resolve<IAttributesService>();
        }

        private void form2ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var form2 = new Form2(_attributesService);
            form2.Show();
        }
    }
}
