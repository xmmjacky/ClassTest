using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemo
{
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
    class Program
    {
        public static List<Person>PersonsList()
        {
            List<Person> persons = new List<Person>();
            for(int i=0;i<7;i++)
            {
                Person p = new Person() { Name = i + "儿子", Age = 8 - i, };
                persons.Add(p);
            }
            return persons;
        }
        delegate int GuangChaoshi(int a,int b);
        static void Main(string[] args)
        {
            var p1 = new {  ID=1,  Name="",  Age=0 };
            var p2 = new { ID = 1, Name = "", Age = 0 };
            for (int i=0;i<10;i++)
            {
                List<Person> persons = PersonsList();
                var person = persons.SkipWhile(p => p.Age > 3);
                var person1 = persons.Skip(2);
                var person2 = persons.Take(2);
                var person3 = persons.TakeWhile(p => p.Age > 3);
            }
            #region 简单委托
            //List<Person> persons = PersonsList();
            //persons = persons.Where(p => p.Age > 6).ToList();
            //Person per = persons.SingleOrDefault(p => p.Age == 1);
            //persons = persons.Where(p => p.Name.Contains("儿子")).ToList();
            //Console.WriteLine(persons[0].Name);
            //Console.ReadKey();
            //GuangChaoshi gwl = JieZhang;
            //GuangChaoshi gwl = p => p + 10;
            #endregion

            #region 委托泛型
            //GuangChaoshi gwl = (p, z) =>
            //{
            //    int zuidixiaofei = 10;
            //    if (p < zuidixiaofei)
            //    {
            //        return 100;
            //    }
            //    else
            //    {
            //        return z - p - 10;
            //    }
            //};
            //Func<int, int, bool> gwl1 = (p, j) =>
            //{
            //    if (p + j == 10)
            //    {
            //        return true;
            //    }
            //    return false;
            //};
            //Console.WriteLine(gwl1(5, 5) + "");
            //Console.WriteLine(gwl(10, 100) + "");
            //Console.ReadKey();
            #endregion

        }
        public static int JieZhang(int a)
        {
            return a + 10;
        }

        
    }
}
