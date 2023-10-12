namespace ITLab1
{
    public class Table
    {
        public Table(string name)
        {

            Name = name;
            Columns = new();
            Rows = new();
        }
        public string Name { get; set; }
        public List<Column> Columns { get; private set; }
        public List<Row> Rows { get; private set; }

        public static Table Intersect(Table table1, Table table2)
        {
            var result = new Table(table1.Name + " Intersect " + table2.Name);
            var columns = table1.Columns.Select(t => t.Name).Intersect(table2.Columns.Select(t => t.Name)).ToList();
            foreach (var column in columns) result.AddColumn(column, Types.String);
            var rows = new List<List<string>>();
            foreach (var row1 in table1.Rows)
            {
                foreach (var row2 in table2.Rows)
                {
                    var row = new List<string> ();
                    var isEqual = true;

                    foreach (var column in columns)
                    {
                        var value1 = row1.Values[table1.Columns.IndexOf(table1.Columns.Single(t => t.Name == column))];
                        var value2 = row2.Values[table2.Columns.IndexOf(table2.Columns.Single(t => t.Name == column))];
                        if (value1 == value2) row.Add(value1);
                        else isEqual = false;
                        
                    }
                    if (isEqual) rows.Add(row);
                }
            }

            foreach (var row in rows) result.AddRow(-1, row.ToArray());

            return result;
        }
        public void AddColumn(string name, Types type)
        {
            if (Columns.Any(c => c.Name == name))
            {
                throw new ArgumentException("Column with such name has been already created");
            }
            Columns.Add(new Column(name, type));
            foreach (Row row in Rows)
            {
                row.AddColumn();
            }
        }

        public void DeleteColumn(string name)
        {
            var column = Columns.SingleOrDefault(c => c.Name == name);
            if (column != null)
            {
                var index = Columns.IndexOf(column);
                foreach (Row row in Rows)
                {
                    row.Values.RemoveAt(index);
                }
                Columns = Columns.Where(c => c.Name != name).ToList();
            }
            else
            {
                throw new ArgumentException("There is no such column in the table");
            }
        }

        public void AddRow(int id, params string[] values)
        {
            if (Rows.Count > 0 && id == -1)
            {
                id = Rows.Max(c => c.Id) + 1;
            }
            if (Rows.Count == 0)
            {
                id = 0;
            }
            if (values.Count() != Columns.Count)
            {
                throw new ArgumentException("Number of arguments must exactly match the number of columns");
            }
            for (int i = 0; i < Columns.Count; i++)
            {
                if (!IsType(values[i], Columns.ElementAt(i).Type))
                {
                    throw new ArgumentException("Types do not match");
                }
            }
            if (Rows.Any(r => r.Id == id))
            {
                Rows.FirstOrDefault(r => r.Id == id).ChangeValues(values);
            }
            else
            {
                Rows.Add(new Row(id, values));
            }

        }
        public void DeleteRow(int id)
        {
            if (Rows.Any(r => r.Id == id))
            {
                Rows = Rows.Where(r => r.Id != id).ToList();
            }
            else
            {
                throw new ArgumentException("There is no such row in the table");
            }

        }
        private bool IsType(string value, Types type)
        {
            switch (type)
            {
                case Types.String:
                    return true;
                case Types.Int:
                    return int.TryParse(value, out var _);
                case Types.Real:
                    return double.TryParse(value, out var _);
                case Types.Char:
                    return char.TryParse(value, out var _);
                case Types.DateTime:
                    return DateTime.TryParse(value, out var _);
                default:
                    return false;
            }
        }
    }
}