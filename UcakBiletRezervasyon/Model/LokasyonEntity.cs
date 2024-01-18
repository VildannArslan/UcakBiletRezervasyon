namespace UcakBiletRezervasyon.Model;

public class LokasyonEntity
{
    public int Id { get; set; }
    public string Ulke { get; set; }
    public string Sehir { get; set; }
    public string Havaalani { get; set; }
    public bool AktifMi { get; set; }
}