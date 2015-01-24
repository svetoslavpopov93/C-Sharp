using System;
public class Person
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name
    {
        get
        {
            return this.Name;
        }
        set
        {
            this.Name = value;
        }
    }

    public int Age
    {
        get
        {
            return this.Age;
        }
        set
        {
            //if (value < 0)
            //{
            //    throw new ArgumentOutOfRangeException("value", "Age value must be positive number.");
            //}
            this.Age = value;
        }
    }
}
