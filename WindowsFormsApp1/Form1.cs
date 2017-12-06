using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvPlan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            /*txtStart.AutoCompleteMode = AutoCompleteMode.Suggest;*/
        }

        private void btnSuche_Click(object sender, EventArgs e)
        {
            SwissTransport.Transport transport = new SwissTransport.Transport();
            string start = txtStart.Text;
            string ziel = txtZiel.Text;
            var station = transport.GetConnections(start, ziel);
            foreach (var stat in station.ConnectionList)
            {
                int n = dgvPlan.Rows.Add();
                dgvPlan.Rows[n].Cells["colVon"].Value = start;
                dgvPlan.Rows[n].Cells["colBis"].Value = ziel;
                dgvPlan.Rows[n].Cells["colAbfahrt"].Value = DateTime.Parse(stat.From.Departure).ToString("HH:mm");
                dgvPlan.Rows[n].Cells["colAnkunft"].Value = DateTime.Parse(stat.To.Arrival).ToString("HH:mm");
                dgvPlan.Rows[n].Cells["colDauer"].Value = stat.Duration;
                dgvPlan.Rows[n].Cells["colGleis"].Value = stat.From.Platform;
            }
            dgvPlan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /*AutoCompleteStringCollection data = new AutoCompleteStringCollection();
        SwissTransport.Transport transport = new SwissTransport.Transport();*/

        private void txtStart_TextChanged(object sender, EventArgs e)
        {
           /* Thread.Sleep(200);
            string start = txtStart.Text;
            var station = transport.GetStations(start);
            foreach (var stat in station.StationList)
            {
                data.Add(stat.Name);
            }
            txtStart.AutoCompleteCustomSource = data;*/
        }
    }
}
