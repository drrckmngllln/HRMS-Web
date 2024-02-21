using HrmsPrototype.Entities.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrmsPrototype
{
    public partial class Form1 : Form
    {
        const string baseUrl = "https://localhost:5001/api/departments/";
        private HttpClient http = new HttpClient();
        public int Id { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await GetRecords();
        }

        private async Task GetRecords()
        {
            dgv.DataSource = await getDepartments();
        }

        private async Task<IReadOnlyList<Departments>> getDepartments()
        {
            
            var response = await http.GetAsync(baseUrl);
            if (response.IsSuccessStatusCode)
            {
                string read = await response.Content.ReadAsStringAsync();
                var json = JsonConvert.DeserializeObject<Departments[]>(read);
                return json;
            }

            return null;
        }

        private async Task AddUpdate()
        {
            if (btnSave.Text == "Save")
            {
                await AddDepartmentAsync();
                await GetRecords();
            }
            else if (btnSave.Text == "Update")
            {
                await UpdateDepartmentsAsync();
                await GetRecords();
            }
        }

        private async Task AddDepartmentAsync()
        {
            var department = new Departments
            {
                Name = tName.Text
            };

            var json = JsonConvert.SerializeObject(department);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await http.PostAsync(baseUrl + "create", content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Create Success");
            }

        }
        private async Task UpdateDepartmentsAsync()
        {
            var department = new Departments
            {
                Id = Id,
                Name = tName.Text
            };
            var json = JsonConvert.SerializeObject(department);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await http.PutAsync(baseUrl + "update", content);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Updated");
            }
        }

        private async Task DeleteDepartmentsAsync()
        {
            var response = await http.DeleteAsync(baseUrl + Id);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Deleted");
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            await AddUpdate();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dgv.CurrentRow.Cells["Id"].Value);
            tName.Text = dgv.CurrentRow.Cells["Name"].Value.ToString();
            btnSave.Text = "Update";
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            await DeleteDepartmentsAsync();
            await GetRecords();
        }
    }
}
