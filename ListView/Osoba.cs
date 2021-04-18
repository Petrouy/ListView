using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListView
{
    class Osoba : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public static Dictionary<string, Osoba> Osoby = new Dictionary<string, Osoba>();



        private string jmeno;
        public string Jmeno
        {
            get => jmeno;
            set { jmeno = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Jmeno")); }
        }


        private string prijmeni;
        public string Prijmeni
        {
            get => prijmeni;
            set { prijmeni = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Prijmeni")); }
        }



        private int datumNarozeni;
        public int DatumNarozeni
        {
            get => datumNarozeni;
            set { datumNarozeni = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DatumNarozeni")); }
        }



        private string rodneCislo;
        public string RodneCislo
        {
            get => rodneCislo;
            set { rodneCislo = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RodneCislo")); }
        }
        






        public static void InitOsoby()
        {
            Osoby["prvni"] = new Osoba
            {
                Jmeno = "Petr",
                Prijmeni = "Novák",
                DatumNarozeni = 05122000,
                RodneCislo = "001205/0235"               
            };


            Osoby["druhy"] = new Osoba
            {
                Jmeno = "Ivan",
                Prijmeni = "Skála",
                DatumNarozeni = 21061995,
                RodneCislo = "950621/8924"
            };


            Osoby["treti"] = new Osoba
            {
                Jmeno = "Jan",
                Prijmeni = "Ořech",
                DatumNarozeni = 30021986,
                RodneCislo = "860230/5723"
            };
        }




    }
}
