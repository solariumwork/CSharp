namespace Task1.Person
{
    using System;
    
    static class PersonFormatter
    {
        public static string Concatenate(Person person)
        {
            return "Имя: " + person.Name + " Фамилия: " + person.Surname + " Возраст: " + person.Age + " Рост: " + person.Height + " Вес: " + person.Weight;
        }
        
        public static string Format(Person person)
        {
            return String.Format("Имя: {0} Фамилия: {1} Возраст: {2} Рост: {3} Вес: {4}", person.Name, person.Surname, person.Age, person.Height, person.Weight);
        }
        
        public static string FormatViaDollar(Person person)
        {
            return $"Имя: {person.Name} фамилия: {person.Surname} Возраст: {person.Age} Рост: {person.Height} Вес: {person.Weight}";
        }
    }
}
