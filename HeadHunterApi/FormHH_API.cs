using HeadHunterLibrary;
using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HeadHunterApi
{
    public partial class FormHH_API : Form
    {
        HHModel model = new HHModel();

        public FormHH_API()
        {
            InitializeComponent();
        }

        private void GetVacancyBtn_Click(object sender, EventArgs e)
        {
            VacancyIDTextBox.Text = VacancyIDTextBox.Text == "" ? "28350957" : VacancyIDTextBox.Text;

            JToken parsedJson = JToken.Parse(model.GetRequest("https://api.hh.ru/vacancies/" + VacancyIDTextBox.Text + "/"));

            ResultTextBox.Text = parsedJson.ToString(Formatting.Indented);
        }

        private void GetSomeDataBtn_Click(object sender, EventArgs e)
        {
            VacancyIDTextBox.Text = VacancyIDTextBox.Text == "" ? "28350957" : VacancyIDTextBox.Text;
            ResultTextBox.Text = model.JsonParseString(model.GetRequest("https://api.hh.ru/vacancies/" + VacancyIDTextBox.Text + "/"));
        }

        private void GetWorkListBtn_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = model.JsonParseStringItems(model.GetRequest("https://api.hh.ru/vacancies?text=C%23%20developer"));
        }
    }
}
