using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrmsPrototype.Forms.Notifications
{
    public partial class frmToastr : Form
    {
        int toastX, toastY;
        int y = 100;
        public frmToastr(string type, string message)
        {
            InitializeComponent();
            cType.Text = type;
            tMessage.Text = message;
            switch (type)
            {
                case "Success":
                    pic.Image = Properties.Resources.check;
                    toastColor.BackColor = Color.FromArgb(57, 155, 53);
                    break;
                case "Error":
                    pic.Image = Properties.Resources.error;
                    toastColor.BackColor = Color.FromArgb(227, 50, 45);
                    break;
                case "Information":
                    pic.Image = Properties.Resources.information;
                    toastColor.BackColor = Color.FromArgb(18, 136, 191);

                    break;
                case "Warning":
                    toastColor.BackColor = Color.FromArgb(245, 171, 35);
                    pic.Image = Properties.Resources.warning;
                    break;
            }
        }

        private void toastHide_Tick(object sender, EventArgs e)
        {
            y--;
            if (y <= 0)
            {
                toastY += 1;
                this.Location = new Point(toastX, toastY += 10);
                if (toastY > 800)
                {
                    toastHide.Stop();
                    y = 100;
                    Close();
                }
            }
        }

        private void toastTimer_Tick(object sender, EventArgs e)
        {
            toastY -= 10;
            this.Location = new Point(toastX, toastY);
            if (toastY <= 950)
            {
                toastTimer.Stop();
                toastHide.Start();
            }
        }

        private void frmToastr_Load(object sender, EventArgs e)
        {
            Position();
        }

        private void Position()
        {
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            toastX = screenWidth - this.Width;
            toastY = screenHeight - this.Height;

            this.Location = new Point(toastX, toastY);


        }
    }
}
