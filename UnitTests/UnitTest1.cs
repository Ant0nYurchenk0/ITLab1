using ITLab1;

namespace UnitTests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddColumn_NewColumnIsAdded_ThereIsOneColumnInTable()
        {
            var table = new Table("name");

            table.AddColumn("column", Types.String);

            Assert.That(table.Columns.Count, Is.EqualTo(1));
        }

        [Test]
        public void AddColumn_DuplicateColumnIsAdded_ExceptionThrown()
        {
            var table = new Table("name");

            table.AddColumn("column", Types.String);
            

            Assert.Throws(typeof(ArgumentException), () => table.AddColumn("column", Types.String));
        }

        [Test]
        public void Intersect_IntersectTableWithItself_SameTable()
        {
            var table = new Table("name");
            table.AddColumn("column", Types.String);
            table.AddRow(-1, "row1");

            var result = Table.Intersect(table, table);

            Assert.That(result.Columns.Count, Is.EqualTo(table.Columns.Count));
            Assert.That(result.Rows.Count, Is.EqualTo(table.Rows.Count));
            Assert.That(result.Rows[0].Values[0], Is.EqualTo(table.Rows[0].Values[0]));
        }
    }
}