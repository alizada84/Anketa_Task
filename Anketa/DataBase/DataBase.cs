using System.Text.Json;

namespace Anketa;

public class DataBase
{
    List<Person> persons = new List<Person>();

    public DataBase()
    {
        ReadFromJsonFile("../../../Persons.json", ref persons);
    }

    // DataBase Methods
    public void ReadFromJsonFile<T>(string filePath, ref List<T>? list)
    {
        if (File.Exists(filePath))
        {
            string jsonText = File.ReadAllText(filePath);
            list = JsonSerializer.Deserialize<List<T>>(jsonText);
        }
        else
            throw new FileNotFoundException($"File not found: {filePath}");
    }
    public void WriteToJsonFile<T>(string filePath, List<T> list)
    {
        string jsonText = JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true });

        File.WriteAllText(filePath, jsonText);
    }

    public void AddPerson(Person person)
    {
        persons.Add(person);
        WriteToJsonFile<Person>("../../../Persons.json", persons);
    }
    public void RemovePerson(Person person)
    {
        persons.Remove(person);
        WriteToJsonFile<Person>("../../../Persons.json", persons);
    }
}
