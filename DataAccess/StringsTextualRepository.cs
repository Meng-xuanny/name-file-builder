namespace _2_NamesAfterRefactorToSRP.DataAccess;

public class StringsTextualRepository
{
    private static readonly string _separator = Environment.NewLine;

    public List<string> Read(string filepath)
    {
        var fileContents = File.ReadAllText(filepath);
        var namesFromFile = fileContents.Split(_separator).ToList();
        return namesFromFile;
    }

    public void Write(string filepath,List<string> names) =>
        File.WriteAllText(filepath, string.Join(_separator,names));

    
}
