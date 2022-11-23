using Aspose.Cells;

namespace TXT.Domain
{
    public class TXTtoCSVConverter
    {

        public void ConvertToCSV()
        {
            var workbook = new Workbook(@"C:\Users\Bahadır Gültekin\source\repos\DotnetFileTransfer\TXT.Domain\TxtFiles\Person.txt");
            workbook.Save(@"C:\Users\Bahadır Gültekin\source\repos\DotnetFileTransfer\TXT.Domain\TxtFiles\Output.csv");
        }   
    }
}