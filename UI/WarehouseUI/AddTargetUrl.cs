using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseUI
{
    public partial class AddTargetUrl : Form
    {
        public AddTargetUrl()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string targetBaseUrl = tbTargetUrl.Text.Trim();

            int indexOfLastChar = targetBaseUrl.Length - 1;
            if (targetBaseUrl.Length > 0 && targetBaseUrl[indexOfLastChar] != '/')
                targetBaseUrl = targetBaseUrl + "/";

            Target.Url = targetBaseUrl;
            this.Close();
        }
    }
}
