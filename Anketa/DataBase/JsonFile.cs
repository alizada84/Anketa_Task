namespace Anketa;

using System.Text.Json;
using System.IO;

static public class JsonFile
{
    public static void WriteUserInJson<T>(List<T> users, string filename)
    {
        string json = JsonSerializer.Serialize(users, new JsonSerializerOptions
        {
            WriteIndented = true
        });
        File.WriteAllText($"..\\..\\..\\{filename}.json", json);
    }
    public static List<T> ReadUserInJson<T>(List<T> users, string filename)
    {
        // JSON file oxumaq
        if (File.Exists($"..\\..\\..\\{filename}.json"))
        {
            string jsonFromFile = File.ReadAllText($"..\\..\\..\\{filename}.json");
            var loadedUsers = JsonSerializer.Deserialize<List<T>>(jsonFromFile);

            if (loadedUsers != null)
            {
                users = loadedUsers;
                return users;
            }
            else
                throw new SystemException("Bro not list this file");
        }
        else
            throw new SystemException("File not found");
    }
}