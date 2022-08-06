namespace ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new DataReader();
            reader.ImportAndPrintData("data.csv");
        }
    }
}

#region Changes
//1.I changed "reader.ImportAndPrintData("dataa.csv");" as "reader.ImportAndPrintData("data.csv");" // the name of document was wrong
//2.I created ImportedObjectBaseClass and ImportedObject separately. Also changed ImportedObjectBaseClass  as an abstract class. Deleted Name property from ImportedObject  class because it is available in ImportedObjectBaseClass abstract class.
//3.Put using statements before namespaces in DataReader.cs file
//4.Because of in the 366 row in the data.csv file we got value.lenght= 5.That's why when we run our code we get an "Indexoutofbound exception." To catch this error I used the if (values.Length > 6) statement.
//5.Changed IEnumerable<ImportedObject> ImportedObjects; as List<ImportedObject> ImportedObjects = new List<ImportedObject>();
//6.Changed  if(impObj.ParentType == importedObject.Type) as   if (impObj.ParentType.ToUpper() == importedObject.Type.ToUpper())
#endregion
