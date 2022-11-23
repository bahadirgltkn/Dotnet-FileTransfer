using CsvHelper;
using System.Globalization;

namespace CSV.Domain
{
    public class CSVReader
    {
        public IEnumerable<Person> Persons { get; set; } = new List<Person>();

        public void Read()
        {
            using (var reader = new StreamReader(@"C:\Users\Bahadır Gültekin\source\repos\TPI.Project\CSV.Domain\CsvFiles\filePerson.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                Persons = csv.GetRecords<Person>().ToList();
            }
        }

        public void ReadFromConvertedTXT(string path)
        {
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                Persons = csv.GetRecords<Person>().ToList();
            }
        }
    }
}