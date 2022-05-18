//------------------------------------------------------------------------------
// <auto-generated>
//    Ten kod źródłowy został wygenerowany na podstawie szablonu.
//
//    Ręczne modyfikacje tego pliku mogą spowodować nieoczekiwane zachowanie aplikacji.
//    Ręczne modyfikacje tego pliku zostaną zastąpione w przypadku ponownego wygenerowania kodu.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sklep.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produkt
    {
        public int id_produktu { get; set; }
        public int id_kategoria_producent { get; set; }
        public int id_dostawcy { get; set; }
        public int id_zdjęcia { get; set; }
        public int id_opisu { get; set; }
        public string nazwa_produktu { get; set; }
        public int ilosc_sztuk_w_sklepie { get; set; }
        public decimal cena { get; set; }
        public System.DateTime data_kolejnej_dostawy { get; set; }
    
        public virtual Dostawca Dostawca { get; set; }
        public virtual Kategoria_producent Kategoria_producent { get; set; }
        public virtual Opis_produktu Opis_produktu { get; set; }
        public virtual Zdjecie_produktu Zdjecie_produktu { get; set; }
    }
}