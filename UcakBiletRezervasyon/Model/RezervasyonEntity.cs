namespace UcakBiletRezervasyon.Model;

public class RezervasyonEntity
{
    public int Id { get; set; }
    public int UcusId { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int Yas { get; set; }
}