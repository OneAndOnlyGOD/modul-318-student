using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvPlan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStationboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPlan.Visible = false;
            dgvStationboard.Visible = false;
            dgvPlan.BackgroundColor = Color.White;
            dgvStationboard.BackgroundColor = Color.White;
            listStart.Visible = false;
            listZiel.Visible = false;
            listStationBoard.Visible = false;
        }

        SwissTransport.Transport transport = new SwissTransport.Transport();
        bool _changed = false;

        private void btnSuche_Click(object sender, EventArgs e)
        {
            try
            {
                dgvPlan.Rows.Clear();
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
                    dgvPlan.Rows[n].Cells["colDauer"].Value = stat.Duration.Substring(3, 2) + " h " + stat.Duration.Substring(6, 2) + " min"; ;
                    dgvPlan.Rows[n].Cells["colGleis"].Value = stat.From.Platform;
                }

                if (dgvPlan.Visible == false)
                {
                    dgvPlan.Visible = true;
                }

                listStart.Visible = false;
                listZiel.Visible = false;
            }
            catch
            {
                MessageBox.Show("Keine Verbindung gefunden!", "OK");
                txtStart.Text = "";
                txtZiel.Text = "";
                txtStart.Focus();
            }
        }

        private void txtStart_TextChanged(object sender, EventArgs e)
        {
            if (_changed == false)
            {
                if (!(txtStart.Text.Length == 0))
                {
                    listStart.Visible = true;
                    listStart.Items.Clear();
                    string start = txtStart.Text;
                    var station = transport.GetStations(start);
                    foreach (var stat in station.StationList)
                    {
                        listStart.Items.Add(stat.Name);
                    }
                }
                else
                {
                    listStart.Visible = false;
                }
            }
        }

        private void txtZiel_TextChanged(object sender, EventArgs e)
        {
            if (_changed == false)
            {
                if (!(txtZiel.Text.Length == 0))
                {
                    listZiel.Visible = true;
                    listZiel.Items.Clear();
                    string ziel = txtZiel.Text;
                    var station = transport.GetStations(ziel);
                    foreach (var stat in station.StationList)
                    {
                        listZiel.Items.Add(stat.Name);
                    }
                }
                else
                {
                    listZiel.Visible = false;
                }
            }
        }

        private void listStart_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selected = listStart.SelectedItem.ToString();
            txtStart.Text = selected;
            listStart.Visible = false;
        }

        private void listZiel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selected = listZiel.SelectedItem.ToString();
            txtZiel.Text = selected;
            listZiel.Visible = false;
        }

        private void btnWechseln_Click(object sender, EventArgs e)
        {
            _changed = true;
            var start = txtStart.Text;
            var ziel = txtZiel.Text;

            txtStart.Text = ziel;
            txtZiel.Text = start;

            listStart.Visible = false;
            listZiel.Visible = false;

            _changed = false;
        }

        private void txtStation_TextChanged(object sender, EventArgs e)
        {
            if (!(txtStation.Text.Length == 0))
            {
                listStationBoard.Visible = true;
                listStationBoard.Items.Clear();
                string start = txtStation.Text;
                var station = transport.GetStations(start);
                foreach (var stat in station.StationList)
                {
                    listStationBoard.Items.Add(stat.Name);
                }
            }
            else
            {
                listStationBoard.Visible = false;
            }
        }

        private void listStationBoard_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selected = listStationBoard.SelectedItem.ToString();
            txtStation.Text = selected;
            listStationBoard.Visible = false;
        }

        private void btnStationSuche_Click(object sender, EventArgs e)
        {
            try
            {
                dgvStationboard.Rows.Clear();
                string start = txtStation.Text;
                var station = transport.GetStationBoard(start);
                foreach (var stat in station.Entries)
                {
                    int n = dgvStationboard.Rows.Add();
                    dgvStationboard.Rows[n].Cells["colBis1"].Value = stat.To;
                    dgvStationboard.Rows[n].Cells["colAbfahrt1"].Value = stat.Stop.Departure.ToShortTimeString();
                    dgvStationboard.Rows[n].Cells["colName"].Value = stat.Number;
                    dgvStationboard.Rows[n].Cells["colGleis1"].Value = stat.Stop.Platform;
                }

                if (dgvStationboard.Visible == false)
                {
                    dgvStationboard.Visible = true;
                }

                listStart.Visible = false;
                listZiel.Visible = false;
            }
            catch
            {
                MessageBox.Show("Keine Fahrten gefunden!", "OK");
                txtStation.Text = "";
                txtStation.Focus();
            }
        }

        private void btnMaps_Click(object sender, EventArgs e)
        {
            if (!(txtStation.Text == ""))
            {
                var station = txtStation.Text;
                string adresse = "https://www.google.ch/maps/place/" + station.ToString();
                System.Diagnostics.Process.Start(adresse);
            }
            else
            {
                MessageBox.Show("Kein Ort eingegeben!", "OK");
            }
        }

        private void txtStart_Leave(object sender, EventArgs e)
        {
            //listStart.Visible = false;
        }

        private void txtZiel_Leave(object sender, EventArgs e)
        {
            //listZiel.Visible = false;
        }

        private void btnMapZiel_Click(object sender, EventArgs e)
        {
            if (!(txtZiel.Text == ""))
            {
                var station = txtZiel.Text;
                string adresse = "https://www.google.ch/maps/place/" + station.ToString();
                System.Diagnostics.Process.Start(adresse);
            }
            else
            {
                MessageBox.Show("Kein Ort eingegeben!", "OK");
            }
        }

        private void btnMapStart_Click(object sender, EventArgs e)
        {
            if (!(txtStart.Text == ""))
            {
                var station = txtStart.Text;
                string adresse = "https://www.google.ch/maps/place/" + station.ToString();
                System.Diagnostics.Process.Start(adresse);
            }
            else
            {
                MessageBox.Show("Kein Ort eingegeben!", "OK");
            }
        }

        private void txtStart_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                listStart.Visible = false;
            }
            if (e.KeyData == (Keys.Tab | Keys.Shift))
            {
                listZiel.Visible = false;
            }
        }

        private void tabConnection_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStart.Text = "";
            txtZiel.Text = "";
            txtStation.Text = "";
            dgvPlan.Visible = false;
            dgvStationboard.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
