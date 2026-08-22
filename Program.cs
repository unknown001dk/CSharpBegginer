// using System;
// using System.Collections.Generic;

// // list, hashtree, dic, 

// class Person
// {
//     public int Id;
//     public string name;
//     public int age;
//     public string city;
//     public string phone;
// }

// class Program
// {
//     static List<Person> people = new List<Person>();
//     // static field or static variable

//     static void Main()
//     {
//         Person FirstPerson = new Person();

//         FirstPerson.Id = 100;
//         FirstPerson.name = "Dinesh";
//         FirstPerson.age = 25;
//         FirstPerson.city = "Karur";
//         FirstPerson.phone = "9876453210";

//         people.Add(FirstPerson);

//          Person SecondPerson = new Person();

//         SecondPerson.Id = 101;
//         SecondPerson.name = "Dinesh";
//         SecondPerson.age = 25;
//         SecondPerson.city = "Karur";
//         SecondPerson.phone = "9876453210";

//         people.Add(SecondPerson);

//         Console.WriteLine("=======================");
//         Console.WriteLine("        PEOPLE ");
//         Console.WriteLine("=======================");

//         Console.WriteLine("1. Add person");
//         Console.WriteLine("2. View person");
//         Console.WriteLine("3. Update person");
//         Console.WriteLine("4. Delete person");
//         Console.WriteLine("5. Search person");
        

//         Console.WriteLine("Enter your choice: ");
//         int choice = Convert.ToInt32(Console.ReadLine());

//         switch(choice)
//         {
//             case 1:
//                 AddPerson();
//                 break;
//             case 2:
//                 ViewPerson();
//                 break;
//             case 3:
//                 UpdatePerson();
//                 break;
//             case 4:
//                 DeletePerson();
//                 break;
//             case 5:
//                 SearchPerson();
//                 break;
//             case 6:
//                 Console.WriteLine("Invaild Inputs");
//                 break;
//         }


//     }

//     static void AddPerson()
//     {
//         Console.WriteLine("=======================");
//         Console.WriteLine("        ADD person");
//         Console.WriteLine("=======================");

//         Person newPerson = new Person();

//         Console.WriteLine("Enter person ID: ");
//         newPerson.Id = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("Enter person Name: ");
//         newPerson.name = Console.ReadLine();

//         Console.WriteLine("Enter person age: ");
//         newPerson.age = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("Enter person City: ");
//         newPerson.city = Console.ReadLine();

//         Console.WriteLine("Enter person Phone: ");
//         newPerson.phone = Console.ReadLine();

//         people.Add(newPerson);

//         Console.WriteLine("Person Added Successfully!!");
//     }

//     static void ViewPerson()
//     {
//         Console.WriteLine("=======================");
//         Console.WriteLine("        VIEW person");
//         Console.WriteLine("=======================");

//         foreach (Person person in people)
//         {
//             Console.WriteLine($"Person ID: {person.Id}");
//             Console.WriteLine($"Person Name: {person.name}");
//             Console.WriteLine($"Person Age: {person.age}");
//             Console.WriteLine($"Person City: {person.city}");
//             Console.WriteLine($"Person Phone: {person.phone}");
//             Console.WriteLine("=======================");
//         }
//     }

//     static void UpdatePerson()
//     {
//         Console.WriteLine("UPDATE person");
//     }

//     static void DeletePerson()
//     {
//         Console.WriteLine("DELETE person");

//     }

//     static void SearchPerson()
//     {
//         Console.WriteLine("=======================");
//         Console.WriteLine("       SEARCH person");
//         Console.WriteLine("=======================");

//         Console.WriteLine("Enter personID: ");
//         int searchId = Convert.ToInt32(Console.ReadLine());

//         bool found = false;

//         foreach (Person person in people)
//         {
//             if(person.Id == searchId)
//             {
//                 Console.WriteLine("Person Found!");

                
//                 Console.WriteLine($"Person ID: {person.Id}");
//                 Console.WriteLine($"Person Name: {person.name}");
//                 Console.WriteLine($"Person Age: {person.age}");
//                 Console.WriteLine($"Person City: {person.city}");
//                 Console.WriteLine($"Person Phone: {person.phone}");

//                 found = true;
//             }
//         }

//         if(found == false)
//         {
//             Console.WriteLine("Person Not Found");
//         }

//     }
// }


// Food order

// using System;
// using System.Collections.Generic;

// class Food
// {
//     public int Id;
//     public string name;
//     public double price;
//     public int quantity;
// }

// class Program {

//     static List<Food> order = new List<Food>();
//     // static field

//     static void Main()
//     {
//         int choice = 0;
//         while(choice != 5) {
        
//             Console.WriteLine("1. Add Food");
//             Console.WriteLine("2. View Food");
//             Console.WriteLine("3. Update Food");
//             Console.WriteLine("4. Delete Food");
//             Console.WriteLine("5. Exit");


//             Console.WriteLine("Enter your choice: ");
//             choice = Convert.ToInt32(Console.ReadLine());

//             switch (choice)
//             {
//                 case 1: 
//                     AddFood();
//                     break;
//                 case 2: 
//                     ViewFood();
//                     break;
//                 case 3: 
//                     UpdateFood();
//                     break;
//                 case 4: 
//                     DeleteFood();
//                     break;
//                 case 5: 
//                     Console.WriteLine("Invalid Choices!");
//                     break;
//             }
//         }
//     }

//     static void AddFood()
//     {
//         Console.WriteLine("Food Menu");

//         Console.WriteLine("1. Briyani");
//         Console.WriteLine("2. Fired Rice");
//         Console.WriteLine("3. Noodles");

//         Console.WriteLine("Select food: ");
//         int choice = Convert.ToInt32(Console.ReadLine());

//         Food food = new Food();

//         if(choice ==1 )
//         {
//             food.Id = 1;
//             food.name = "Briyani";
//             food.quantity = 1;
//             food.price = 210;
//         } else if (choice == 2)
//         {
//             food.Id = 2;
//             food.name = "Fired rice";
//             food.quantity = 1;
//             food.price = 200;
//         } else if (choice == 3)
//         {
//             food.Id = 3;
//             food.name = "Noodles";
//             food.quantity = 1;
//             food.price = 120;
//         } else
//         {
//             Console.WriteLine("Invalid input");
//             return;
//         }

//         order.Add(food);
//         // list -> collection -> object key and value pair 
//         // {
//         //      "Id": 1
//         //      "name": "Briyani",
//         // },
//         // {
//         //      "Id": 2
//         //      "name": "Briyani",
//         // }
//         Console.WriteLine("Added successfully");
//     }

//     static void ViewFood()
//     {
//         Console.WriteLine("View Food");

//         if(order.Count == 0)
//         {
//             Console.WriteLine("No Food");
//         }

//         foreach(Food food in order)
//         {
//             Console.WriteLine($"Food id: {food.Id}");
//             Console.WriteLine($"Food name: {food.name}");
//             Console.WriteLine($"Food Price: {food.price}");
//             Console.WriteLine($"Food Quantity: {food.quantity}");
//         }
//     }

//     static void UpdateFood()
//     {
//         Console.WriteLine("Update Food");

//         Console.WriteLine("Enter food ID: ");
//         int foodId = Convert.ToInt32(Console.ReadLine());

//         bool found = false;

//         foreach(Food food in order)
//         {
//             if(food.Id == foodId)
//             {
//                 Console.WriteLine("Food Found !");

//                 Console.WriteLine("Enter new name: ");
//                 food.name = Console.ReadLine();

//                 found = true;
//                 Console.WriteLine("Order updated successfully");
//             }
//         }
        
//         if(found == false)
//         {
//             Console.WriteLine("Not found");
//         }


//     }
    
//     static void DeleteFood()
//     {
//         Console.WriteLine("Delete Food");
//     }
// }


// loops (for, foreach) array, objects


// class Program
// {
//     static void Main()
//     {

//         // array  -> []
//         // index start with 0
//         // 0, 1, 2, 3, 4

//         // int[] marks = { 85, 34, 45, 65, 76 };


//         // condition -> pass mark 40 > pass ? fail

//         // Console.WriteLine($"{marks.Length}");
//         // marks[2]

//         // for loop 
//         // for (int i = 0; i < marks.Length; i++)
//         // {
//         //     // Console.WriteLine($"{marks[i]}");
//         //     if(marks[i] >= 40)
//         //     {
//         //         Console.WriteLine("Pass");
//         //     } else
//         //     {
//         //         Console.WriteLine("Fail");  
//         //     }
//         // }

//         // int[] amount = {1200, 490, 560};
//         // // sum of all number in an array

//         // int total = 0;

//         // foreach(int price in amount)
//         // {
//         //     // Console.WriteLine($"{price}");
//         //     // total = total + price;

//         //     total += price;
//         // }

//         // Console.WriteLine($"Total: {total}");

//         // highest number in an array

//         // lowest number in an array, second lowest number in an array 
        

//         // int[] num = {34, 45, 67, 34, 78};

//         // int HighestValue = num[0];

//         // for (int i = 1; i < num.Length; i++)
//         // {
//         //     if(num[i] > HighestValue)
//         //     {
//         //         HighestValue = num[i];
//         //     }
//         // }
//         // Console.WriteLine($"Highest value: {HighestValue}");

//         // attendance system

//         int[] attendance = {0, 1, 1, 0, 1, 1, 0, 1};

//         int present = 0;
//         int absent = 0;

//         foreach (int status in attendance)
//         {
//             if(status == 0)
//             {
//                 absent++;
//             } else
//             {
//                 present++;
//             }
//         }

//         Console.WriteLine($"Total Present: {present}");
//         Console.WriteLine($"Total Absent: {absent}");
//     }
// }


// class Program
// {
//      static void Main()
//     {
//         int[] numbers = {10, 20, 30};

//         for (int i = 0; i < numbers.Length; i++)
//         {
//             Console.WriteLine(numbers[i]);
//         }

//         int[] newNum = new int[numbers.Length + 1];

//         for (int i = 0; i < numbers.Length; i++)
//         {
//             newNum[i] = numbers[i];
//         }
        
//         newNum[newNum.Length - 1] = 40;

//         numbers = newNum;

//         for (int i = 0; i < numbers.Length; i++)
//         {
//             Console.WriteLine(numbers[i]);
//         }
//     }
// }

class Program
{
    static void Main()
    {
        
        int[] numbers = {12, 13, 14}; 

        Console.WriteLine("Before add: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        int[] newNum = new int[numbers.Length + 1];

        for (int i = 0; i < numbers.Length; i++)
        {
            newNum[i] = numbers[i];

            // 0 = 0 index values
            // newNum[0] = 11
            // newNum[1] = 12
            // newNum[2] = 13
            // numbers
        }

        newNum[newNum.Length - 1] = 15;

        numbers = newNum;

        Console.WriteLine("After add: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }


    }
}