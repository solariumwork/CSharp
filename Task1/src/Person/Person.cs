namespace Task1.Person
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public ushort Age { get; set; }
        public ushort Height { get; set; }
        public ushort Weight { get; set; }
        
        public Person(string name, string surname, ushort age, ushort height, ushort weight)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Height = height;
            Weight = weight;
        }
    }
}
