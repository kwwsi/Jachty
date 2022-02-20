namespace Jachty.Models
{
    public class Wypozyczenie
    {
        public int WypozyczenieID { get; set; }
        public int JachtID { get; set; }
        public int KlientId { get; set; }
        public DateTime WypozyczenieStart { get; set; }
        public DateTime WypozyczenieKoniec { get; set; }
    }
}
