namespace LearningClasses
{
    internal class Person
    {
        //Default parameterless constructor
        public Person()
        {

        }

        //parameterized constructor

        public Person(string n, string add, byte a)
        {
            this.Name = n;
            this.Address = add;
        }
        public string Name { get; set; }

        public string Address{ get; set; }

        public byte Age{ get; set; }

        public static string ScientificName = "Homo-sapiens";

        public static void Do()
        {
            
        }
    }
}