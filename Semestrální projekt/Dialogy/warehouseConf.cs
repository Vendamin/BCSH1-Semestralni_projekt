using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semestrální_projekt;

public partial class warehouseConf : Form {
    private readonly BindingList<DataViewItem> dataViewItems = [];
    private readonly BindingSource bindingSource = new();
    private readonly SkladConfig _config;

    public warehouseConf(SkladConfig config) {
        this._config = config;
        InitializeComponent();

        dataGridView1.AutoGenerateColumns = false;
        id.Visible = false;
        rada.DisplayIndex = 0;
        sloupec.DisplayIndex = 1;
        patro.DisplayIndex = 2;
        akce.DisplayIndex = 3;

        bindingSource.DataSource = dataViewItems;
        dataGridView1.DataSource = bindingSource;

        LoadWarehouseConfiguration();
        UpdatePositionCount();
    }

    private void UpdatePositionCount()
    {
        int totalPositions = dataViewItems.Sum(item => item.PocetPater * item.PocetSloupcu);
        pocetPozic.Text = $"Počet pozic: {totalPositions}";
    }

    private void LoadWarehouseConfiguration()
    {
        try
        {
            var positions = _config.DatabaseInstance.GetAllWarehousePositions();
            var groupedByRada = positions
                .GroupBy(p => p.Item1)
                .Select(g => new
                {
                    Rada = g.Key,
                    MaxRegal = g.Max(p => p.Item2),
                    MaxPatro = g.Max(p => p.Item3)
                })
                .ToList();

            foreach (var group in groupedByRada)
            {
                pridatNovyZaznam(rada: group.Rada, pocetSloupcu: group.MaxRegal, pocetPater: group.MaxPatro);
            }

            if (groupedByRada.Any())
            {
                bindingSource.ResetBindings(false);
            }
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Chyba při načítání konfigurace: {ex.Message}");
        }
    }

    private void pridatNovyZaznam(string rada = "", int pocetPater = 0, int pocetSloupcu = 0, bool refresh = false) {
        rada = rada.Trim().Replace(" ", "").ToUpperInvariant();
        string[] dataRaw = rada.Split(',', StringSplitOptions.RemoveEmptyEntries);

        foreach (string zaznam in dataRaw) {
            if (zaznam.Contains('-')) {
                string[] range = zaznam.Split('-', 2, StringSplitOptions.RemoveEmptyEntries);
                if (range.Length != 2) {
                    continue;
                }

                foreach (string zaznamInside in ExpandAlphabetRange(range[0], range[1])) {
                    DataViewItem? existing = dataViewItems.FirstOrDefault(item => item.Rada == zaznamInside);
                    if (existing is not null) {
                        existing.PocetPater = pocetPater;
                        existing.PocetSloupcu = pocetSloupcu;
                    }
                    else {
                        dataViewItems.Add(new DataViewItem(zaznamInside, pocetPater, pocetSloupcu));
                    }
                }
            }
            else {
                DataViewItem? existing = dataViewItems.FirstOrDefault(item => item.Rada == zaznam);
                if (existing is not null) {
                    existing.PocetPater = pocetPater;
                    existing.PocetSloupcu = pocetSloupcu;
                }
                else {
                    dataViewItems.Add(new DataViewItem(zaznam, pocetPater, pocetSloupcu));
                }
            }
        }

        if (refresh) {
            bindingSource.ResetBindings(false);
        }
    }

    private static IEnumerable<string> ExpandAlphabetRange(string start, string end) {
        if (string.IsNullOrWhiteSpace(start) || string.IsNullOrWhiteSpace(end)) {
            yield break;
        }

        start = start.Trim().ToUpperInvariant();
        end = end.Trim().ToUpperInvariant();

        string current = start;
        while (true) {
            yield return current;
            if (current == end) {
                yield break;
            }

            string next = IncrementAlphabetCode(current);
            if (next == current) {
                yield break;
            }

            current = next;
        }
    }

    private static string IncrementAlphabetCode(string value) {
        char[] chars = value.ToCharArray();

        for (int i = chars.Length - 1; i >= 0; i--) {
            if (chars[i] < 'Z') {
                chars[i] = (char)(chars[i] + 1);
                for (int j = i + 1; j < chars.Length; j++) {
                    chars[j] = 'A';
                }
                return new string(chars);
            }
        }

        return new string('A', chars.Length + 1);
    }

    private void addNewButton_Click(object sender, EventArgs e) {
        pridatNovyZaznam(rada: rady.Text, pocetPater: (int)pocetPater.Value, pocetSloupcu: (int)pocetSloupcu.Value, refresh: true);
        rady.Clear();
        pocetPater.Value = 1;
        pocetSloupcu.Value = 1;
        UpdatePositionCount();
    }

    private void saveButton_Click(object sender, EventArgs e) {
        try
        {
            var oldPositions = _config.DatabaseInstance.GetAllWarehousePositions();
            var positionsWithProducts = _config.DatabaseInstance.GetPositionsWithProducts();

            var newPositions = new List<(string Rada, int Regal, int Patro)>();

            foreach (var item in dataViewItems) {
                for (int patro = 1; patro <= item.PocetPater; patro++) {
                    for (int regal = 1; regal <= item.PocetSloupcu; regal++) {
                        newPositions.Add((item.Rada, regal, patro));
                    }
                }
            }

            var oldPositionsSet = new HashSet<(string, int, int)>(oldPositions);
            var newPositionsSet = new HashSet<(string, int, int)>(newPositions);

            var positionsToDelete = oldPositionsSet.Except(newPositionsSet).ToList();
            var positionsToCreate = newPositionsSet.Except(oldPositionsSet).ToList();

            var orphanedProducts = positionsToDelete
                .Where(pos => positionsWithProducts.ContainsKey(pos))
                .ToList();

            if (orphanedProducts.Any())
            {
                var orphanedList = string.Join("\n", orphanedProducts
                    .Select(pos => $"  - Řada {pos.Item1}, Regál {pos.Item2}, Patro {pos.Item3}: " +
                        $"{positionsWithProducts[pos].Obsah} (Paleta #{positionsWithProducts[pos].PaletaId})"));

                var result = MessageBox.Show(
                    $"Následující pozice budou smazány a jejich produkty budou ztraceny:\n\n{orphanedList}\n\n" +
                    "Opravdu chcete pokračovat?",
                    "Upozornění – Ztráta dat",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

                if (result == DialogResult.No)
                    return;
            }

            using var conn = _config.DatabaseInstance.GetConnection();
            conn.Open();
            using var transaction = conn.BeginTransaction();

            try
            {
                if (positionsToDelete.Any())
                {
                    _config.DatabaseInstance.DeleteWarehousePositions(transaction, positionsToDelete);
                }

                if (positionsToCreate.Any())
                {
                    _config.DatabaseInstance.CreateWarehousePositions(transaction, positionsToCreate);
                }

                transaction.Commit();
                MessageBox.Show("Konfigurace skladu byla úspěšně uložena.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show($"Chyba při ukládání: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Chyba: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void cancelButton_Click(object sender, EventArgs e) {
        this.Close();
    }

    private void odebratZaznamButton_Click(object sender, DataGridViewCellEventArgs e) {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (dataGridView1.Columns[e.ColumnIndex] != akce) {
            return;
        }

        DataViewItem? item = dataGridView1.Rows[e.RowIndex].DataBoundItem as DataViewItem;
        if (item is null) {
            return;
        }

        dataViewItems.Remove(item);
        bindingSource.ResetBindings(false);
        UpdatePositionCount();
    }
}

partial class DataViewItem {
    public int Id { get; set; }
    public string Rada { get; set; } = "";
    public int PocetPater { get; set; }
    public int PocetSloupcu { get; set; }

    public DataViewItem(int id, string rada, int pocetPater, int pocetSloupcu) {
        this.Id = id;
        this.Rada = rada;
        this.PocetPater = pocetPater;
        this.PocetSloupcu = pocetSloupcu;
    }

    public DataViewItem(string rada, int pocetPater, int pocetSloupcu) {
        this.Rada = rada;
        this.PocetPater = pocetPater;   
        this.PocetSloupcu = pocetSloupcu;
    }
}