using Semestrální_projekt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semestrální_projekt
{
    public partial class PaletyPanelControl : UserControl, IRefreshable {
        private SkladConfig _config;
        private readonly SortableBindingList<Paleta> dataViewItems = [];
        private readonly BindingSource bindingSource = new();

        public PaletyPanelControl(SkladConfig config) {
            _config = config;
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;

            bindingSource.DataSource = dataViewItems;
            dataGridView1.DataSource = bindingSource;
        }

        public void ShowPalet() {
            Paleta selectedPaleta = this.dataGridView1.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault()?.DataBoundItem as Paleta;
            if (selectedPaleta != null) {
                System.Diagnostics.Debug.WriteLine($"Selected Paleta: Id={selectedPaleta.Id}, Obsah={selectedPaleta.Obsah}, PocetKusu={selectedPaleta.PocetKusu}, Hmotnost={selectedPaleta.Hmotnost}");
                idPaletyLabel.Text = string.Format("(#P{0:00000000})", selectedPaleta.Id);
                obsahLabel.Text = selectedPaleta.Obsah;
                pocetKusuLabel.Text = selectedPaleta.PocetKusuString;
                hmotnostLabel.Text = selectedPaleta.HmotnostString;
                aktPoziceLabel.Text = selectedPaleta.AktPozice?.ToString();
            }
        }

        private void ShowPalet(object sender, EventArgs e) {
            ShowPalet();
        }

        private void addNewButton_Click(object sender, EventArgs e) {
            AddPalet addPalet = new AddPalet();
            if (addPalet.ShowDialog() == DialogResult.OK) {
                Paleta? newPaleta = addPalet.CreatedPaleta;
                if (newPaleta != null) {
                    if (_config.DatabaseInstance != null) {
                        long newId = _config.DatabaseInstance.AddPaleta(newPaleta);
                        newPaleta.Id = newId;
                        dataViewItems.Add(newPaleta);
                    }
                }
            }
        }

        public void DeletePalet(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) {
                return;
            }

            Paleta? item = dataGridView1.Rows[e.RowIndex].DataBoundItem as Paleta;
            if (item is null) {
                return;
            }
            DeletePalet(item);
        }

        public void DeletePalet(object sender, EventArgs e) {
            Paleta? selectedPaleta = this.dataGridView1.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault()?.DataBoundItem as Paleta;
            if (selectedPaleta != null) {
                DeletePalet(selectedPaleta);
            }
        }

        public void DeletePalet(Paleta paleta) {
            if (paleta == null) {
                return;
            }

            if (_config.DatabaseInstance != null) {
                _config.DatabaseInstance.DeletePaleta(paleta.Id ?? 0);
            }

            dataViewItems.Remove(paleta);
        }

        public void RefreshData() {
            dataViewItems.Clear();

            if (_config.DatabaseInstance != null) {
                var paletyZDatabaze = _config.DatabaseInstance.GetAllPalety();
                foreach (var paleta in paletyZDatabaze) {
                    dataViewItems.Add(paleta);
                }
            }
        }
    }
}