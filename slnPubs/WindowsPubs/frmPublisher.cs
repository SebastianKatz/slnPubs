using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.Admin;

namespace WindowsPubs
{
    public partial class frmPublisher : Form
    {
        public frmPublisher()
        {
            InitializeComponent();
        }

        private void frmPublisher_Load(object sender, EventArgs e)
        {
            gridPublisher.DataSource = AdmPublisher.Listar();
        }
    }
}
