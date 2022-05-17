namespace Interview.Core
{
    public class Person : Entity
    {
        private IRepository<Person> @object;

        public Person()
        {
        }

        public Person(IRepository<Person> @object)
        {
            this.@object = @object;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}