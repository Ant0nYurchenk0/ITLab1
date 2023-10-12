using Newtonsoft.Json.Linq;


namespace ITLab1
{
    public class Database
    {
        public Database(string name, string path)
        {
            Name = name;
            if (!path.EndsWith(".json"))
            {
                Path = path + '\\' + Name + ".json";
            }
            else
            {
                Path = path;
            }
            Tables = new();
        }
        public string Name { get; private set; }
        public string Path { get; private set; }
        public List<Table> Tables { get; private set; }
        public void AddTable(string name)
        {
            if (Tables.Any(t => t.Name == name))
            {
                throw new ArgumentException("Table with such name has been already created");
            }

            Tables.Add(new Table(name));
        }
        public void DeleteTable(string name)
        {
            if (Tables.Any(t => t.Name == name))
            {
                Tables = Tables.Where(t => t.Name != name).ToList();
            }
            else
            {
                throw new ArgumentException("There is no such table in the database");
            }
        }
        public void Save()
        {
            var json = JObject.FromObject(this).ToString();
            File.WriteAllText(Path, json);
        }
        public static Database Open(string path)
        {
            var json = File.ReadAllText(path);
            return JObject.Parse(json).ToObject<Database>();
        }
    }
}
