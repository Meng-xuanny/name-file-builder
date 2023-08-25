public class Formatter
{
    public string Format(List<string> names) =>
        string.Join(Environment.NewLine, names);
}