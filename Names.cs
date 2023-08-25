public class Names
{
    public List<string> All { get; } = new List<string>();
    private readonly NameValidator _namesValidator = new NameValidator();

    public void AddNames(List<string> stringFromFile)
    {
       foreach(var name in stringFromFile)
        {
            AddName(name);
        }
    }

    public void AddName(string name)
    {
        if (_namesValidator.IsValid(name))
        {
            All.Add(name);
        }
    }
}
