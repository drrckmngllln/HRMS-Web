using HrmsPrototype.Forms.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrmsPrototype.Core.Notifications
{
    internal class Toastr
    {
        private readonly string type;
        private readonly string message;

        public Toastr(string type, string message)
        {
            this.type = type;
            this.message = message;
            LaunchToastr();
        }

        private void LaunchToastr()
        {
            var frm = new frmToastr(type, message);
            frm.ShowDialog();
        }
    }
}
