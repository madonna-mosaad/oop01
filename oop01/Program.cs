namespace oop01
{
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
            #region q5
            //Console.Write("enter the color : ");
            //bool flag = Enum.TryParse(Console.ReadLine(), true, out Colors color);
            //if (flag)
            //{
            //    for (int i = 0; i < 3; i++)
            //    {
            //        if (((Colors)i) == color)
            //        {
            //            Console.WriteLine("the input color is a primary color");
            //            break;
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("the input color is not a primary color");
            //}
            #endregion
            #region q6
            //Point point01=new Point();
            //Point point02=new Point();
            //double x01,x02, y01, y02;

            //do
            //{
            //    Console.Write("enter x01 : ");
            //} while (!double.TryParse(Console.ReadLine(), out x01));
            //point01.X = x01;
            //do
            //{
            //    Console.Write("enter y01 : ");
            //} while (!double.TryParse(Console.ReadLine(), out y01));
            //point01.Y = y01;
            //do
            //{
            //    Console.Write("enter x02 : ");
            //} while (!double.TryParse(Console.ReadLine(), out x02));
            //point02.X = x02;
            //do
            //{
            //    Console.Write("enter y02 : ");
            //} while (!double.TryParse(Console.ReadLine(), out y02));
            //point02.Y = y02;
            //Console.WriteLine($"the distance between point01 and point02 is : {Math.Sqrt(Math.Pow((x01-x02),2)+Math.Pow((y01-y02),2))}");

            #endregion
            #region q7
            //Person p01 = new Person();
            //Person p02 = new Person();
            //Person p03 = new Person();
            //int Age;
            //Console.Write("enter Name of first person: ");
            //p01.Name = Console.ReadLine();
            //do
            //{
            //    Console.Write("enter Age of first person : ");
            //} while (!int.TryParse(Console.ReadLine(), out Age));
            //p01.Age = Age;
            //Console.Write("enter Name of second person: ");
            //p02.Name = Console.ReadLine();
            //do
            //{
            //    Console.Write("enter Age of second person : ");
            //} while (!int.TryParse(Console.ReadLine(), out Age));
            //p02.Age = Age;
            //Console.Write("enter Name of third person: ");
            //p03.Name = Console.ReadLine();
            //do
            //{
            //    Console.Write("enter Age of third person : ");
            //} while (!int.TryParse(Console.ReadLine(), out Age));
            //p03.Age = Age;

            //int oldest=p03.Age;
            //if (p01.Age > oldest)
            //{
            //    if (p02.Age > p01.Age)
            //    {
            //        oldest = p02.Age;
            //    }
            //    else
            //    {
            //        oldest = p01.Age;
            //    }
            //}
            //else
            //{
            //    if (p02.Age > oldest)
            //    {
            //        oldest = p02.Age;
            //    }
            //}
            //if(oldest == p01.Age)
            //{
            //    Console.WriteLine(p01.ToString());
            //}
            //if (oldest == p02.Age)
            //{
            //    Console.WriteLine(p02.ToString());
            //}
            //if(oldest == p03.Age)
            //{
            //    Console.WriteLine(p03.ToString());
            //}
            #endregion
        }
    }
}
