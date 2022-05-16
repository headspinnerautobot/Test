namespace Interview.Core
{
    public class Person : Entity
    {
        public string Name { get; set; }
        public int Age { get; set; }

        Repository<Person> entityRepository = new Repository<Person>();
    }
}