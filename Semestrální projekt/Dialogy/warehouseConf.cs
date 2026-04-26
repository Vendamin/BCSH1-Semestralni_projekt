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

    public warehouseConf() {
        InitializeComponent();

        dataGridView1.AutoGenerateColumns = false;
        id.DisplayIndex = 0;
        rada.DisplayIndex = 1;
        sloupec.DisplayIndex = 2;
        patro.DisplayIndex = 3;
        akce.DisplayIndex = 4;

        bindingSource.DataSource = dataViewItems;
        dataGridView1.DataSource = bindingSource;
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
    }

    private void saveButton_Click(object sender, EventArgs e) {
        this.Close();
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