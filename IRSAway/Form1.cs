using System;
using System.Windows.Forms;

namespace IRSAway
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateMin = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 1);
            DateTime dateMax = dateMin.AddDays(DateTime.DaysInMonth(dateMin.Year, dateMin.Month) - 1);
            tableTableAdapter.FillByDate(database1DataSet.Table, dateMin, dateMax);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dateMin = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 1);
            DateTime dateMax = dateMin.AddDays(DateTime.DaysInMonth(dateMin.Year, dateMin.Month) - 1);
            tableTableAdapter.FillByDate(database1DataSet.Table, dateMin, dateMax);
        }

        private void toolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableTableAdapter.Update(this.database1DataSet);
        }
    }
}