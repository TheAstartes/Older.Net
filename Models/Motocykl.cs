namespace TheShop.Models
{
    public class Motocykl
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int RokProdukcji { get; set; }
        public string Przebieg { get; set; }
        public string Pojemnosc { get; set; }
        public string RodzajSilnika { get; set; }
        public string Moc { get; set; }
        public string Opis { get; set; }
        public decimal Cena { get; set; }
        public string ZdjecieUrl { get; set; }
        public string LogoUrl { get; set; }
        public bool JestMotocyklemTygodnia { get; set; }

        public string ZdjeciePrezentacja { get; set; }
        public string Wallpaper { get; set; }
        public string Pic1 { get; set; }
        public string Pic2 { get; set; }
        public string Pic3 { get; set; }


    }
}
