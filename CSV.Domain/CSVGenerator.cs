using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV.Domain
{
    public class CSVGenerator
    {
        public void Write() 
        {
            using (var writer = new StreamWriter(@"C:\Users\Bahadır Gültekin\source\repos\DotnetFileTransfer\CSV.Domain\CsvFiles\personList.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(Person.GetPersonList());
            }
        }
    }
}
