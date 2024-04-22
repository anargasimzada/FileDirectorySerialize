using Newtonsoft.Json;

namespace File_Serialize_HW23._04
{
    internal class Program
    {
        private static string FilePath = "names.json";
        private static List<string> names = new List<string>();
        static void Main(string[] args)
        {

            Add("anar");
            Add("nurvin");

            Console.WriteLine("searching for 'anar': "+Search("anar "));
          
        }
        static void LoadData()
        {
            if (File.(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                names = DeserializeObject<List<string>>(json);
            }
        }

        private static T DeserializeObject<T>(string json)
        {
            throw new NotImplementedException();
        }

        static void SaveData()
        {
            string json = JsonConvert.SerializeObject(names);
            File.WriteAllLines(File, json);
        }
        static void Add(string name)
        {
            LoadData();
            names.Add(name);
            SaveData();
        }
        static bool Search(string name)
        {
            LoadData();
            return names.Contains(name);
        }
        static void Delete(int index)
        {
            LoadData();
            if (index >= 0 && index < names.Count)
            {
                names.RemoveAt(index);
                SaveData();
            }
            else
            {
                Console.WriteLine("Index out of range.");
            }

        }
    } 
}

