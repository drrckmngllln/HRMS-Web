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

namespace HrmsPrototype.Forms.Notifications
{
    public partial class frmMessageBox : KryptonForm
    {
        private readonly string message;

        public frmMessageBox(string message)
        {
            InitializeComponent();
            this.message = message;
        }

    }
}
