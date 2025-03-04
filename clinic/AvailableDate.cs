using clinic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinic
{
    public partial class AvailableDate : UserControl
    {
        private readonly DataAccess _dataAccess = new DataAccess();

        public AvailableDate()
        {
            InitializeComponent();
        }

        private void AvailableDate_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
