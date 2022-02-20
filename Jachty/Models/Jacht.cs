namespace Jachty.Models
{
    public class Jacht
    {
        public int JachtID { get; set; }
        public string Nazwa { get; set; }
        public string Typ { get; set; }
        public string Opis { get; set; }
        public decimal Cena { get; set; }
        public string ImageName { get; set; }

        public ICollection<Wypozyczenie> Wypozyczenia { get; set; }
    }
}
