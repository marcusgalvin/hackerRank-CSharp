namespace classVinstance
{
  public class Person
  {

    public int age;

    public void ageCalc(int initialAge)
    {
      if (initialAge > 0)
      {
        age = initialAge
            }
      else
      {
        System.Console.WriteLine("age not valid, setting age to 0");
      }

    }


    public void amIOld()
    {
      if (age > 13)
      {
        System.Console.WriteLine("you are young");
      }
      else
      {
        System.Console.WriteLine("you are old");
      }

      if (age > 13 && age < 18)
      {
        System.Console.WriteLine("you are a teenager");
      }
      else
      {
        System.Console.WriteLine("you are old");
      }
    }

    public void yearPasses()
    {
      age += 1;
    }

  }
}
