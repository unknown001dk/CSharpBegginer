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

//         // foreach (Person person in people)
//         // {
//         //     Console.WriteLine($"Person ID: {person.Id}");
//         //     Console.WriteLine($"Person Name: {person.name}");
//         //     Console.WriteLine($"Person Age: {person.age}");
//         //     Console.WriteLine($"Person City: {person.city}");
//         //     Console.WriteLine($"Person Phone: {person.phone}");
//         //     Console.WriteLine("=======================");
//         // }
//         for (int i = 0; i < people.Count; i++)
//         {
//             // Console.WriteLine(people[i].name);
//             if(people[i].Id == 101)
//             {
//                 Console.WriteLine("Found");
//             }
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

// class Program
// {
//     static void Main()
//     {
        
//         int[] numbers = {12, 13, 14}; 

//         Console.WriteLine("Before add: ");
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             Console.WriteLine(numbers[i]);
//         }

//         int[] newNum = new int[numbers.Length + 1];

//         for (int i = 0; i < numbers.Length; i++)
//         {
//             newNum[i] = numbers[i];

//             // 0 = 0 index values
//             // newNum[0] = 11
//             // newNum[1] = 12
//             // newNum[2] = 13
//             // numbers
//         }

//         newNum[newNum.Length - 1] = 15;

//         numbers = newNum;

//         Console.WriteLine("After add: ");
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             Console.WriteLine(numbers[i]);
//         }


//     }
// }

// class Program {
//     static void Main()
//     {
//         // step 1 
//         // create a array
//         int[] numbers = {10, 20, 30};

//         // step 2 
//         // print the values in an array
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             Console.WriteLine(numbers[i]);
//         }

//         // step 3 
//         // create a new array 
//         // create a array size which is one greater than numbers
//         int[] newNumbers = new int[numbers.Length + 1];

//         // step 4
//         // add values to the newNumbers array
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             newNumbers[i] = numbers[i];
//             // newNumbers[0] = 10
//             // newNumbers[1] = 20
//             // newNumbers[2] = 30
//         }

//         // step 5
//         // add last value in a newNumbers array
//         newNumbers[newNumbers.Length -1] = 40;

//         // step 6
//         // change array values numbers to newNumbers
//         numbers = newNumbers;

//         //step 7
//         // print all values in an array
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             Console.WriteLine(numbers[i]);
//         }
//     }
// }

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         List<int> numbers = new List<int>();

//         numbers.Add(10);
//         numbers.Add(20);
//         numbers.Add(30);
//         numbers.Add(40);
//         numbers.Add(50);

//         Console.WriteLine("Enter number: ");
//         int value = Convert.ToInt32(Console.ReadLine());

//         numbers.Contains(value);



//         // numbers.Add(number);

//         foreach (int number in numbers)
//         {
//             Console.WriteLine("~~~~~~~~~~~~~~~~~");
//             Console.WriteLine(number);
//         }

//         // Console.WriteLine(numbers.Count);

//         // number[i]

//     }
// }


// using System;
// using System.IO;

// class Program
// {
//     static void Main()
//     {
//         string filePath = "data.txt";

//         // file create -> File.Create()

//         // file existing or not -> File.Exists
//         if(File.Exists(filePath))
//         {   
//             File.Delete(filePath);
//             Console.WriteLine("File deleted.");
//         } else
//         {
//             // File.Create(filePath);
//             Console.WriteLine("File not deleted");
//         }

//         // Console.Write("Enter Text: ");
//         // string text = Console.ReadLine();

//         // // add text inside the file
//         // File.WriteAllText(filePath, text);

//         // string data = File.ReadAllText(filePath);
//         // Console.WriteLine(data);

//         // File.AppendAllText(filePath, text + Environment.NewLine);

//         // Console.WriteLine("Text added");



//         // file edit

//         // Console.WriteLine("Enter Want to edit text: ");
//         // string oldValue = Console.ReadLine();

//         // Console.WriteLine("Enter new value: ");
//         // string newValue = Console.ReadLine();

//         // // contains -> is have or not
//         // if (data.Contains(oldValue))
//         // {
//         //     data = data.Replace(oldValue, newValue);
//         //     File.WriteAllText(filePath, data);
//         //     Console.WriteLine("Valued added");
//         // } else
//         // {
//         //     Console.WriteLine("Value not found!");
//         // }


//         // read file
//         // find
//         // remove
//         // write




//     }
// }


// variables
// data types 
    // int 
    // float
    // double
    // boolean
    // string
// operators
  // arithimatic operator
    // addition +
    // subtraction -
    // multiplication *
    // division /
    // modules %
  // logical operator
    // and &&
    // or ||
    // not !
  // comparsion operator
    // equal == 
    // greater than >
    // greater than or equal to >=
    // less than <
    // less than or equal to <=
    // not equal to !=

// conditons -> if,  else if, else
// switch
// loops -> for, foreach, while
// methods / functions
// array 
// list
// file handling
// debuging

// yet to know
// class -> oops 




// using System;
// using System.IO;

// class Program
// {
//     static void Main()
//     {
//         string filePath = "data2.txt";

        // File.Create(filePath);

        // if(File.Exists(filePath)) 
        // {
        //   Console.WriteLine("File already exists!");
        // } else {
        //   File.Create(filePath);
        //   Console.WriteLine("File created!");
        // }

        // file create -> File.Create()

        // file existing or not -> File.Exists
        // if(File.Exists(filePath))
        // {   
        //     File.Delete(filePath);
        //     Console.WriteLine("File deleted.");
        // } else
        // {
        //     // File.Create(filePath);
        //     Console.WriteLine("File not deleted");
        // }

        // Console.WriteLine("Enter Text: ");
        // string text = Console.ReadLine();

        // // // add text inside the file
        // File.WriteAllText(filePath, text);

        // string data = File.ReadAllText(filePath);
        // Console.WriteLine(data);

        // File.AppendAllText(filePath, text + Environment.NewLine);

        // Console.WriteLine("Text added");



        // file edit

        // Console.WriteLine("Enter Want to edit text: ");
        // string oldValue = Console.ReadLine();

        // Console.WriteLine("Enter new value: ");
        // string newValue = Console.ReadLine();

        // // contains -> is have or not
        // if (data.Contains(oldValue))
        // {
        //     data = data.Replace(oldValue, newValue);
        //     File.WriteAllText(filePath, data);
        //     Console.WriteLine("Valued added");
        // } else
        // {
        //     Console.WriteLine("Value not found!");
        // }


        // read file
        // find
        // remove
        // write
//     }
// }

// oops -> object oriented programming
  // encapsulation
  // inheritance
  // polymorphism
  // abstraction

// encapsulation

// private , public 

// using System;


// class BankAccount
// {
//     private double balance = 500;

//     // declare (amount)
//     public void Deposit(double amount)
//     {
//         if(amount > 0)
//         {
//             balance += amount;
//             // balance = balance + amount;
//             Console.WriteLine("Amount deposited successfully");
//         } else
//         {
//             Console.WriteLine("Invalid amount");
//         }
//     }

//     public void showBalance()
//     {
//         Console.WriteLine($"Balance: {balance}");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         BankAccount account = new BankAccount();

//         account.Deposit(5000);
//         account.showBalance();

//         account.Deposit(9000);
//         account.showBalance();

//         account.Deposit(8000);
//         account.showBalance();
//     }    
// }


// parent , child  -> inheritance 

// using System;

// // parent class
// class Person
// {
//     public string name;
//     public int age;

//     public void DisplayPerson()
//     {
//         Console.WriteLine($"Name: {name}");
//         Console.WriteLine($"Age: {age}");
//     } 
// }

// class Employee : Person
// {
//     public string department;
//     public double salary;
//     public void DisplayEmployee()
//     {
//         DisplayPerson();
//         Console.WriteLine($"Department: {department}");
//         Console.WriteLine($"salary: {salary}");
//     } 
// }


// class Program
// {
//     static void Main()
//     {
//         Employee employee = new Employee();

//         employee.name = "Dinesh";
//         employee.age = 22;
//         employee.department = "IT";
//         employee.salary = 3000;

//         employee.DisplayEmployee(); 
//     }
// }

// // polymorphism
// // abstraction


// bool isLoggedIn = false;

// string email = "dk@gmail.com";
// string password = "123456";

// if (email == "dk@gmail.com" && password == "123456")
// {
//   Console.WriteLine("Login successful");
// } else {
//   Console.WriteLine("Login failed");
// }

// polymorphism
// method overriding
// using System;

// class Payment
// {
  
//   public virtual void Pay()
//   {
//     Console.WriteLine("Payment processing...");
//   }
// }

// class UPIPayment: Payment
// {
//   public override void Pay()
//   {
//     Console.WriteLine("Payment process through UPI");
//   }

//   public void Test()
//   {
//     Console.WriteLine("Test");
//   }
// }

// class CardPayment : Payment
// {
//    public override void Pay()
//   {
//     Console.WriteLine("Payment process through Card");
//   }
// }

// class Program {
//   static void Main() {
//     Payment payment;

//     payment = new UPIPayment();
//     payment.Pay();
//     ((UPIPayment)payment).Test();
//     // type casting 

//     payment = new CardPayment();
//     payment.Pay();
//   }
// }

// try catch -> error handling
// using System;

// class Program
// {
//   static void Main()
//   {
//     int balance = 10000;

//     try
//     {
//       // code 
//       Console.WriteLine("Enter the amount: ");
//       int amount = Convert.ToInt32(Console.ReadLine());

//       if(amount <= 0)
//       {
//         Console.WriteLine("Amount must be greater than 0");
//       } else if ( amount > balance)
//       {
//         Console.WriteLine("Insufficient balance");
//       } else
//       {
//         balance -= amount;
//         Console.WriteLine("Withdrawl successfull"); 
//         Console.WriteLine($"Remaining Balance: {balance}");
//       }
//     }
//     catch (Exception ex)
//     {
//       // error 
//       Console.WriteLine($"Something went wrong: {ex.Message}");
//     } finally
//     {
//       Console.WriteLine("It always working");
//     }
    
//   }
// }

// using System;

// class Program
// {
//   static void Main()
//   {
//     try
//     {
//       string username = "admin";
//       string password = "123456";

//       Console.WriteLine("Enter username: ");
//       string inputUsername = Console.ReadLine();

//       Console.WriteLine("Enter password: ");
//       string inputPassword = Console.ReadLine();

//       if(inputUsername == username && inputPassword == password)
//       {
//         Console.WriteLine("Login successful");
//       } else
//       {
//         throw new Exception("Invaild username or password");
//       }
//     }
//     catch (Exception ex)
//     {
//       Console.WriteLine($"Login Faild: {ex.Message}");
//     }
//   }
// }

