namespace ChallengeApp
{
    public class Employee
    {
    public string name;
    public string surname;
    public int age;

    private List<int> score = new List<int>();

    public Employee(string name, string surname, int age)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
    }

    public string Name { get; private set; }
    public string Surname { get; private set; }
    public string Age { get; private set; }

    public int Result 
    { 
        get
        {
            return this.score.Sum();
        }
    }

    public void AddScore(int number)
    {
        this.score.Add(number);
    }
    }
}
