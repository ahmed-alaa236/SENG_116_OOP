
namespace HW0.App;

public class StudentCard
{
    //FIELDS
    public string Name { get; }
    public long Number { get; }

    public StudentCard(string name, long number) //CONSTRUCTOR
    {
        Name = name;
        Number = number;
    }

    public string Summary() => $"Student: {Name} ({Number})"; //METHOD
}
