namespace Jachty.Models
{
    public class Klient
    {
        public int KlientID { get; set; }
        public string Imie { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }

        public ICollection<Wypozyczenie> Wypozyczenia { get; set; }
    }
}
