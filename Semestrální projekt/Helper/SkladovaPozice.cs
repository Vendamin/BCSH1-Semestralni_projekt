using System;
using System.Collections.Generic;
using System.Text;

namespace Semestrální_projekt;

public class SkladovaPozice {
    public int Id { get; set; }
    public string Rada { get; set; }
    public int PocetPater { get; set; }
    public int PocetSloupcu { get; set; }

    public SkladovaPozice(int id, string rada, int pocetPater, int pocetSloupcu) {
        this.Id = id;
        this.Rada = rada;
        this.PocetPater = pocetPater;
        this.PocetSloupcu = pocetSloupcu;
    }

    public SkladovaPozice(string rada, int pocetPater, int pocetSloupcu) {
        this.Rada = rada;
        this.PocetPater = pocetPater;
        this.PocetSloupcu = pocetSloupcu;
    }

    override public string ToString() {
        return $"{Rada}-{PocetSloupcu}-{PocetPater}";
    }
}
