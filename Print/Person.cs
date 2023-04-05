namespace Print
{
    class Person : IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int ComareTo(Person person)
        {
            return person.Age.CompareTo(Age);
        }
    }
  
}
