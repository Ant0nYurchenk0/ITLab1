namespace ITLab1
{
    public class Column
    {
        public Column(string name, Types type)
        {
            Name = name;
            Type = type;
        }
        public string Name { get; set; }
        public Types Type { get; set; }


    }
}