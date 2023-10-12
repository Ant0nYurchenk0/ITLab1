using Newtonsoft.Json.Linq;

namespace ITLab1
{
    public class Program
    {
        static void Main(string[] args)
        {


            var json = File.ReadAllText("D:\\Prog\\new_db.json");
            var database = JObject.Parse(json).ToObject<Database>();
            var table = database.Tables.FirstOrDefault(t => t.Name == "table123");
            table.DeleteColumn("column1");
            json = JObject.FromObject(database).ToString();
            File.WriteAllText(Path.Combine(database.Path, database.Name + ".json"), json);
        }
    }
}