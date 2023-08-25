using System.Xml.Linq;
using _2_NamesAfterRefactorToSRP.DataAccess;

var names = new Names();
var builder = new NamesFilePathBuilder();
var path = builder.BuildFilePath();
var repo = new StringsTextualRepository();

if (File.Exists(path))
{
    Console.WriteLine("Names file already exists. Loading names.");
   var stringsFromFile= repo.Read(path);
    names.AddNames(stringsFromFile);
}
else
{
    Console.WriteLine("Names file does not yet exist.");

    //let's imagine they are given by the user
    names.AddName("Blue");
    names.AddName("not a valid name");
    names.AddName("Lulu");
    names.AddName("123 definitely not a valid name");

    Console.WriteLine("Saving names to the file.");
    repo.Write(path,names.All);
}
Console.WriteLine(new Formatter().Format(names.All));

Console.ReadLine();
