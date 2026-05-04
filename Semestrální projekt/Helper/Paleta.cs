using System;
using System.Collections.Generic;
using System.Text;

namespace Semestrální_projekt;

public class Paleta(long ?id, string obsah, int pocetKusu, float hmotnost, SkladovaPozice ?aktualniPozice) {
    public long ?Id { get; set; } = id;
    public string Obsah { get; set; } = obsah;
    public int PocetKusu { get; set; } = pocetKusu;
    public float Hmotnost { get; set; } = hmotnost;
    public string PocetKusuString {
        get { 
            if (PocetKusu == 1) {
                return String.Format("{0} box", PocetKusu);
            } else if ( PocetKusu < 5) {
                return String.Format("{0} boxy", PocetKusu);
            } else {
                return String.Format("{0} boxů", PocetKusu);
            }
    } }
    public string HmotnostString { get {
            float hmot = 0;
            string jednotka = Properties.Settings.Default.def_metric;
            if (jednotka == "g") {
                hmot = Hmotnost * 1000;
            } else if (jednotka == "lb") {
                hmot = Hmotnost * 2.20462262f;
            } else {
                hmot = Hmotnost;
            }
            return String.Format("{0:0.##}{1}", hmot, Properties.Settings.Default.def_metric);
    } }
    public SkladovaPozice ?AktPozice { get; set; } = aktualniPozice;
}