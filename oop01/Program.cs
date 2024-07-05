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
    //q3
    enum Seasons
    {
        Spring, Summer, Autumn, Winter
    }
    //q4
    [Flags]
    enum Permissions
    {
        Read = 1, write = 2, Delete = 4, Execute = 8
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
            #region q3
            //Seasons season ;
            //do
            //{
            //    Console.Write("enter the season : ");
            //    bool flag = Enum.TryParse(Console.ReadLine(), true, out season);
            //} while (season != Seasons.Winter && season!=Seasons.Spring && season != Seasons.Summer && season != Seasons.Autumn);
            //switch (season)
            //{
            //    case Seasons.Spring:
            //        Console.WriteLine("march to may");
            //        break;
            //    case Seasons.Winter:
            //        Console.WriteLine("December to February");
            //        break;
            //    case Seasons.Autumn:
            //        Console.WriteLine("September to November");
            //        break;
            //    case Seasons.Summer:
            //        Console.WriteLine("june to august");
            //        break;

            //}
            #endregion
            #region q4
            //try
            //{
            //    Permissions P = (Permissions)7;
            //    //to add
            //    P |= Permissions.Execute;
            //    //to delete
            //    P &= ~(Permissions.Read);
            //    //to check

            //    if ((P & Permissions.Execute) == Permissions.Execute)
            //    {
            //        Console.WriteLine("the delete permission is exist");
            //    }
            //    else
            //    {
            //        Console.WriteLine("the delete permission is not exist");
            //    }
            //}
            //catch (Exception e) 
            //{
            //    Console.WriteLine(e.Message);
            //}
            #endregion
        }
    }
}
