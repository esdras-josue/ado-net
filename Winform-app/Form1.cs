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
        private List<Disk> diskList;
        public FrmDisk()
        {
            InitializeComponent();
        }

        private void FrmDisk_Load(object sender, EventArgs e)
        {
            DiskBusiness business = new DiskBusiness();
            diskList = business.toList();
            dgvDisk.DataSource = diskList;
            dgvDisk.Columns["UrlImagen"].Visible = false;
            loadImage(diskList[0].UrlImagen);
        }

        private void dgvDisk_SelectionChanged(object sender, EventArgs e)
        {
           Disk selected = (Disk) dgvDisk.CurrentRow.DataBoundItem;
           loadImage(selected.UrlImagen);
        }
        private void loadImage(string image)
        {
            try
            {
                pbxDisk.Load(image);
            }
            catch (Exception ex)
            {
                pbxDisk.Load("https://th.bing.com/th/id/OIP.F00dCf4bXxX0J-qEEf4qIQHaD6?rs=1&pid=ImgDetMain");
            }  
        }
    }
}
