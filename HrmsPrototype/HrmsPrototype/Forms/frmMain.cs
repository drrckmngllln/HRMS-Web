using HrmsPrototype.Forms.Settings;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrmsPrototype.Forms
{
    public partial class frmMain : KryptonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            if (panelLibrary.Visible == false)
            {
                panelLibrary.Visible = true;
            }
            else
            {
                panelLibrary.Visible = false;
            }
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            if (panelTransaction.Visible == false)
            {
                panelTransaction.Visible = true;
            }
            else
            {
                panelTransaction.Visible = false;
            }
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            var frm = new frmDepartments();
            frm.TopLevel = false;
            panelTask.Controls.Clear();
            panelTask.Controls.Add(frm);
            frm.Show();
        }

        private void btnPositions_Click(object sender, EventArgs e)
        {
            var frm = new frmPositions();
            frm.TopLevel = false;
            panelTask.Controls.Clear();
            panelTask.Controls.Add(frm);
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new frmCampus();
            frm.TopLevel = false;
            panelTask.Controls.Clear();
            panelTask.Controls.Add(frm);
            frm.Show();
        }

        private void btnLeaveSetup_Click(object sender, EventArgs e)
        {
            var frm = new frmLeaveSetup();
            frm.TopLevel = false;
            panelTask.Controls.Clear();
            panelTask.Controls.Add(frm);
            frm.Show();
        }
    }
}
