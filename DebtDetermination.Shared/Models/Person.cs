namespace DebtDetermination.Shared.Models
{
    public class Person
    {
        public string Name { get; }

        public Person(string name)
        {
            this.Name = name;
        }
        public Person() { }
    }
}
