using HeadHunterLibrary;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace HeadHunterApi
{
    public partial class FormHH_API : Form
    {
        HHModel model = new HHModel();

        public FormHH_API()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            List<Vacancy> vacancies = new List<Vacancy>();
                
            for (int i = 0; i <= 19; i++)
                vacancies.AddRange(model.JsonParseStringItems(model.GetRequest("https://api.hh.ru/vacancies?text=" + SearchTextBox.Text + ";page=" + i + ";per_page=100")));

            dataGridView.Rows.Clear();

            int vCount = vacancies.Count;
            labelInfo.Text = "По запросу: " + (SearchTextBox.Text == "" ? "Все" : SearchTextBox.Text) + "\nНайденно вакансий: " + vCount;

            foreach (Vacancy v in vacancies)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView.Rows[0].Clone();
                row.Cells[0].Value = v.id;
                row.Cells[1].Value = v.name;
                row.Cells[2].Value = v.employer_name;
                row.Cells[3].Value = v.address;
                row.Cells[4].Value = v.salary_from;
                row.Cells[5].Value = v.salary_to;
                row.Cells[6].Value = v.info;

                dataGridView.Rows.Add(row);
            }
        }

        private void dataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (sender is DataGridView)
                if ((sender as DataGridView).Columns[e.ColumnIndex] is DataGridViewLinkColumn)
                    Process.Start(dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
        }
    }
}