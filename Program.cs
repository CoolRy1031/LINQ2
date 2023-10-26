// See https://aka.ms/new-console-template for more information


// class Program
// {
//   public static void Main()
//   {
//     string [] cities = {"New York", "Atlanta", "LA", "Sydney", "London", "Chicago", "Frankfurt", "Toronto"};
//     List<string> citiesendingwiths = cities.Where(c => c.Length >= 6 && c.Contains("o")).ToList();
//     foreach (var c in citiesendingwiths)
//     {
//       Console.WriteLine(c);
//     }
//   }
// }

public class Person
{
  public int age;
  public string name;
  public Person(int age, string name)
  {
    this.name = name;
    this.age = age;
  }
}
class Program
{
  public static void Main()
  {
    Person p1 = new Person(9,"James");
    Person p2 = new Person(11,"Frank");
    Person p3 = new Person(15,"Phil");
    Person p4 = new Person(22,"David");
    Person p5 = new Person(50,"Chipper");
    List<Person> plist = new List<Person>();
    plist.Add(p1);
    plist.Add(p2);
    plist.Add(p3);
    plist.Add(p4);
    plist.Add(p5);
    List<string> personnames = plist.Where(p => p.age <= 12).Select(per => per.name).ToList();
    foreach(var pname in personnames)
    {
      Console.WriteLine(pname);
    }
  }
}