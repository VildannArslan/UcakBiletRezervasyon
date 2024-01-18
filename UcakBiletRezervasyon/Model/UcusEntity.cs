namespace UcakBiletRezervasyon.Model;

public class UcusEntity
{
    public int Id { get; set; }
    public int LokasyonId { get; set; }
    public string Saat { get; set; }
    public int UcakId { get; set; }
}