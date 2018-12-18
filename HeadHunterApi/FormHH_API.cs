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

        //https://api.hh.ru/vacancies?text=C%23%20developer

        private void GetVacancyBtn_Click(object sender, EventArgs e)
        {
            SearchTextBox.Text = SearchTextBox.Text == "" ? "28350957" : SearchTextBox.Text;

            JToken parsedJson = JToken.Parse(model.GetRequest("https://api.hh.ru/vacancies/" + SearchTextBox.Text + "/"));
        }
    }
}
