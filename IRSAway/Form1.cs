using System;
using System.Windows.Forms;
using System.IO;

namespace IRSAway
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            //StreamWriter writer = new StreamWriter("Accounts\\" + textBoxYear.Text + "\\" + textBoxMonth.Text + ".txt");
            //int indexSize = dataGridViewAccounts.Rows.Count;
            //string[] dates = new string[indexSize], transactions = new string[indexSize], amounts = new string[indexSize],
            //    nets = new string[indexSize], salestaxes = new string[indexSize];

            ////CODE A CHECK TO MAKE SURE NO ROW HAS ANY EMPTY SPOTS.

            //foreach(DataGridViewRow row in dataGridViewAccounts.Rows)
            //{
            //    for (int i = 0; i < row.Cells.Count; i++)
            //    {
            //        if (row.Cells[i].ColumnIndex == 0)
            //            dates[i] = (string) row.Cells[i].Value;
            //    }
            //}
        }
    }
}
