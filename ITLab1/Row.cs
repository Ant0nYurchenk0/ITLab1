namespace ITLab1
{
    public class Row
    {
        public Row(int id, IEnumerable<string> values)
        {
            Id = id;
            Values = values.ToList();
        }
        public int Id { get; set; }
        public List<string> Values { get; set; }
        public void AddColumn()
        {
            Values.Add(null);
        }
        public void ChangeValues(IEnumerable<string> values)
        {
            Values = values.ToList();
        }

    }
}