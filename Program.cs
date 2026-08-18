using System;
using System.Collections.Generic;

// list, hashtree, dic, 

class Person
{
    public int Id;
    public string name;
    public int age;
    public string city;
    public string phone;
}

class Program
{
    static List<Person> people = new List<Person>();

    static void Main()
    {
        Person FirstPerson = new Person();

        FirstPerson.Id = 100;
        FirstPerson.name = "Dinesh";
        FirstPerson.age = 25;
        FirstPerson.city = "Karur";
        FirstPerson.phone = "9876453210";

        people.Add(FirstPerson);

         Person SecondPerson = new Person();

        SecondPerson.Id = 101;
        SecondPerson.name = "Dinesh";
        SecondPerson.age = 25;
        SecondPerson.city = "Karur";
        SecondPerson.phone = "9876453210";

        people.Add(SecondPerson);

        Console.WriteLine("=======================");
        Console.WriteLine("        PEOPLE ");
        Console.WriteLine("=======================");

        Console.WriteLine("1. Add person");
        Console.WriteLine("2. View person");
        Console.WriteLine("3. Update person");
        Console.WriteLine("4. Delete person");
        Console.WriteLine("5. Search person");
        

        Console.WriteLine("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch(choice)
        {
            case 1:
                AddPerson();
                break;
            case 2:
                ViewPerson();
                break;
            case 3:
                UpdatePerson();
                break;
            case 4:
                DeletePerson();
                break;
            case 5:
                SearchPerson();
                break;
            case 6:
                Console.WriteLine("Invaild Inputs");
                break;
        }


    }

    static void AddPerson()
    {
        Console.WriteLine("=======================");
        Console.WriteLine("        ADD person");
        Console.WriteLine("=======================");

        Person newPerson = new Person();

        Console.WriteLine("Enter person ID: ");
        newPerson.Id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter person Name: ");
        newPerson.name = Console.ReadLine();

        Console.WriteLine("Enter person age: ");
        newPerson.age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter person City: ");
        newPerson.city = Console.ReadLine();

        Console.WriteLine("Enter person Phone: ");
        newPerson.phone = Console.ReadLine();

        people.Add(newPerson);

        Console.WriteLine("Person Added Successfully!!");
    }

    static void ViewPerson()
    {
        Console.WriteLine("=======================");
        Console.WriteLine("        VIEW person");
        Console.WriteLine("=======================");

        foreach (Person person in people)
        {
            Console.WriteLine($"Person ID: {person.Id}");
            Console.WriteLine($"Person Name: {person.name}");
            Console.WriteLine($"Person Age: {person.age}");
            Console.WriteLine($"Person City: {person.city}");
            Console.WriteLine($"Person Phone: {person.phone}");
            Console.WriteLine("=======================");
        }
    }

    static void UpdatePerson()
    {
        Console.WriteLine("UPDATE person");
    }

    static void DeletePerson()
    {
        Console.WriteLine("DELETE person");
    }

    static void SearchPerson()
    {
        Console.WriteLine("=======================");
        Console.WriteLine("       SEARCH person");
        Console.WriteLine("=======================");

        Console.WriteLine("Enter personID: ");
        int searchId = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        foreach (Person person in people)
        {
            if(person.Id == searchId)
            {
                Console.WriteLine("Person Found!");

                
                Console.WriteLine($"Person ID: {person.Id}");
                Console.WriteLine($"Person Name: {person.name}");
                Console.WriteLine($"Person Age: {person.age}");
                Console.WriteLine($"Person City: {person.city}");
                Console.WriteLine($"Person Phone: {person.phone}");

                found = true;
            }
        }

        if(found == false)
        {
            Console.WriteLine("Person Not Found");
        }

    }
}