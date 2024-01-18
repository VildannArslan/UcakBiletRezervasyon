using Newtonsoft.Json;

namespace UcakBiletRezervasyon;

public class JsonDataService<T>
{
    private readonly string filePath;

    public JsonDataService(string filePath)
    {
        this.filePath = filePath;
    }

    public List<T>? ReadData()
    {
        try
        {
            if (!File.Exists(filePath))
            {
                return new List<T>();
            }

            string jsonData = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<T>>(jsonData);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public void WriteData(T newData)
    {
        try
        {
            List<T>? list = ReadData();

            if (list == null)
            {
                list = new List<T>();
            }

            list.Add(newData);
            string jsonData = JsonConvert.SerializeObject(list, Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
            Console.WriteLine("Kayıt başarılı!");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
}