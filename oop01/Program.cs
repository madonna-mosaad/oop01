namespace oop01
{
    //q1
    enum Days
    {
        Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday
    }
    //q2 and q7
    struct Person
    {
        public string Name
        {
            get; set;
        }
        public int Age
        {
            get; set;
        }
        public override string ToString()
        {
            return $"the name : {Name} and the age : {Age}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine((Days)i);
            //}
            #endregion
            #region q2
            //Person P1 = new Person();
            //Person P2 = new Person();
            //Person P3 = new Person();
            //P1.Name = "mina";
            //P1.Age = 10;
            //P2.Name = "mark";
            //P2.Age = 20;
            //P3.Name = "ahmed";
            //P3.Age = 33;
            //Person[] people = { P1, P2, P3 };
            //for (int i = 0; i < people.Length; i++) 
            //{
            //    Console.WriteLine(people[i].ToString());
            //}
            #endregion

        }
    }
}
