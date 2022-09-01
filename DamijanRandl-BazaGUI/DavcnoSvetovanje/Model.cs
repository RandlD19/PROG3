using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace DavcnoSvetovanje
{
    public class Model
    {
        public static void DodajNarocnika(Narocnik narocnik)
        {
            Baza baza = new Baza();
            string poizvedba = "INSERT INTO narocnik (davcna_stevilka, priimek, ime, naslov, telefonska_stevilka, elektronska_posta, datum, status) VALUES (@davcna_stevilka, @priimek, @ime, '', '', '', '', @status)";
            SQLiteCommand ukaz = new SQLiteCommand(poizvedba, baza.povezava);
            baza.OdpriPovezavo();
            ukaz.Parameters.AddWithValue("@davcna_stevilka", narocnik.Davcna_stevilka);
            ukaz.Parameters.AddWithValue("@priimek", narocnik.Priimek);
            ukaz.Parameters.AddWithValue("@ime", narocnik.Ime);
            ukaz.Parameters.AddWithValue("@status", narocnik.Status);
            ukaz.ExecuteNonQuery();
            baza.ZapriPovezavo();
        }

        public static List<Narocnik> IzpisiNarocnike()
        {
            Baza baza = new Baza();
            List < Narocnik > narocniki = new List<Narocnik>();
            string poizvedba = "SELECT davcna_stevilka, priimek, ime, status FROM narocnik ORDER BY priimek, ime";
            SQLiteCommand ukaz = new SQLiteCommand(poizvedba, baza.povezava);
            baza.OdpriPovezavo();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(ukaz);
            DataSet podatki = new DataSet();
            adapter.Fill(podatki);
            foreach (DataRow vrstica in podatki.Tables[0].Rows)
            {
                narocniki.Add(new Narocnik(vrstica["davcna_stevilka"].ToString(), vrstica["priimek"].ToString(), vrstica["ime"].ToString(), int.Parse(vrstica["status"].ToString())));
            }
            return narocniki;
        }
    }
}
