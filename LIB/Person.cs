namespace UniLib
{
    public class Person
    {

        //properties
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }


        public Person()
        {
            ID = Guid.NewGuid();
        }

        public Person(Guid id)
        {
            ID = id;


        }
        //methods
        public void GetName()
        {

        }
        public void SetName(string name)
        {
        }

    }
}
