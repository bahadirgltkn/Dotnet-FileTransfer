using CSV.Domain;
using TXT.Domain;
using XML.Domain;


#region CSV

//CSVGenerator genarator = new();
//genarator.Write();

//CSVReader reader = new();
//reader.ReadFromConvertedTXT(@"C:\Users\Bahadır Gültekin\source\repos\DotnetFileTransfer\TXT.Domain\TxtFiles\Output.csv");

//foreach (Person person in reader.Persons)
//{
//    Console.WriteLine(person.Name);
//}

#endregion

#region TXT

//TXTtoCSVConverter converter = new();
//converter.ConvertToCSV();

#endregion

#region XML

//Serialize

XMLWriter xmlWriter = new XMLWriter();
var result = xmlWriter.SerializeObject(Person.GetPersonList());
Console.WriteLine(result);

XMLReader xmlReader = new XMLReader();
List<Person> personList = xmlReader.DeserializeXML<List<Person>>(result);

foreach (var person in personList)
{
    Console.WriteLine(person.Name);
}

#endregion

Console.ReadLine();