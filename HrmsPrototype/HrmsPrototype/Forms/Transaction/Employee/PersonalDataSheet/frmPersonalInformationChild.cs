using System;
using System.Windows.Forms;

namespace HrmsPrototype.Forms.Transaction.Employee.PersonalDataSheet
{
    public partial class frmPersonalInformationChild : Form
    {

        public int ID { get; set; }
        public static frmPersonalInformationChild instance;
        public frmPersonalInformationChild()
        {
            instance = this;
            InitializeComponent();
        }

        private void frmPersonalInformationChild_Load(object sender, EventArgs e)
        {

        }
    }
}
