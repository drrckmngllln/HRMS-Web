using HrmsPrototype.Core.Entities.Transactions;
using HrmsPrototype.Core.Notifications;
using HrmsPrototype.Infrastructure.Repositories;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrmsPrototype.Forms.Transaction.Employee.PersonalDataSheet
{
    public partial class frmPersonalInformationChild : Form
    {
        GenericRepository<PersonalInformation> _personalInfoRepo = new GenericRepository<PersonalInformation>();

        public int ID { get; set; }

        private const string baseEndpoint = "personaldatasheets/personalinformation/";

        public static frmPersonalInformationChild instance;
        public frmPersonalInformationChild()
        {
            instance = this;
            InitializeComponent();
        }

        private async void frmPersonalInformationChild_Load(object sender, EventArgs e)
        {
            await loadPersonalInformation();
            loadGender();
        }

        private void loadGender()
        {
            tSex.DataSource = Enum.GetValues(typeof(Sex));
        }

        private async Task loadPersonalInformation()
        {
            var personalInformation = await _personalInfoRepo.GetByIdAsync(baseEndpoint + ID.ToString());
            if (personalInformation != null)
            {
                tSurname.Text = personalInformation.Surname;
                tFirstName.Text = personalInformation.Firstname;
                tMiddleName.Text = personalInformation.Middlename;
                tDateOfBirth.Text = personalInformation.DateOfBirth;
                tSex.SelectedItem = (Sex)personalInformation.Sex;
                tCivilStatus.SelectedItem = (CivilStatus)personalInformation.CivilStatus;
                tHeight.Text = personalInformation.Height;
                tBloodType.Text = personalInformation.BloodType;
                tGsis.Text = personalInformation.GsisIdNo;
                tPagibig.Text = personalInformation.PagibigIdNo;
                tPhilHealth.Text = personalInformation.PhilhealthNo;
                tSss.Text = personalInformation.SssNo;
                tTin.Text = personalInformation.TinNo;
                tAgencyNumber.Text = personalInformation.AgencyEmployeeNo;
                btnSave.Text = "Update";
            }
            
        }

        private async Task AddEditAsync()
        {
            if (btnSave.Text == "Save")
            {
                var item = new PersonalInformation
                {
                    Surname = tSurname.Text,
                    Firstname = tFirstName.Text,
                    Middlename = tMiddleName.Text,
                    DateOfBirth = tDateOfBirth.Text,
                    Sex = (Sex)tSex.SelectedItem,
                    CivilStatus = (CivilStatus)tCivilStatus.SelectedItem,
                    Height = tHeight.Text,
                    BloodType = tBloodType.Text,
                    GsisIdNo = tGsis.Text,
                    PagibigIdNo = tPagibig.Text,
                    PhilhealthNo = tPhilHealth.Text,
                    SssNo = tSss.Text,
                    TinNo = tTin.Text,
                    AgencyEmployeeNo = tAgencyNumber.Text
                };
                await _personalInfoRepo.AddAsync(item, baseEndpoint + "create");
                new Toastr("Success", "Personal information added");
                await loadPersonalInformation();
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            await AddEditAsync();
        }
    }
}
