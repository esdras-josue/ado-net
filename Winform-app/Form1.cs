using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_app
{
    public partial class FrmDisk : Form
    {
        public FrmDisk()
        {
            InitializeComponent();
        }

        private void FrmDisk_Load(object sender, EventArgs e)
        {
            DiskBusiness business = new DiskBusiness();
            dgvDisk.DataSource = business.toList();
        }
    }
}
