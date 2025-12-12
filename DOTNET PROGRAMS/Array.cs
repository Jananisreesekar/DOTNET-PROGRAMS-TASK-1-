////TASK-3
//using System;
//namespace Program
//{
//    class sample
//    {
//        static void Main()
//        {
//            Console.WriteLine("Enter the number of days:");
//            int a = int.Parse(Console.ReadLine());
//            Console.WriteLine("Original Sales Number:");
//            int[] b = new int[a];
//            for (int i = 0; i < a; i++)
//            {
//                b[i] = int.Parse(Console.ReadLine());
//            }

//            Console.WriteLine("The Values of the Array in original form:");
//            for (int i = 0; i < a; i++)
//            {
//                Console.WriteLine(b[i]);
//            }
//            Console.WriteLine("The Sorted Array is:");
//            Array.Sort(b);
//            for (int i = 0; i < a; i++)
//            {
//                Console.WriteLine(b[i]);
//            }
//            int total = 0;
//            int maximum = b[0];
//            int minimum = b[0];
//            for (int i = 0; i < a; i++)
//            {
//                total += b[i];
//                if (b[i] > maximum)
//                {
//                    maximum = b[i];
//                }
//                if (b[i] < minimum)
//                {
//                    minimum = b[i];

//                }
//            }
//            Console.WriteLine("The total is:" + total);
//            Console.WriteLine("The highest single-day sales is:" + maximum);
//            Console.WriteLine("The lowest single-day sales is:" + minimum);
//            Console.WriteLine("Enter the value to search");
//            int key = int.Parse(Console.ReadLine());
//            int result = Array.BinarySearch(b, key);
//            if (result < 0)
//            {
//                Console.WriteLine($"The searched value {key} is not found ");

//            }
//            else
//            {
//                Console.WriteLine($"The serached value {key} is found at the index {result}");
//            }
//            int[] d = new int[a];
//            Console.WriteLine("The Copied Array is:");
//            Array.Copy(b, d, b.Length);
//            for (int i = 0; i < a; i++)
//            {
//                Console.WriteLine(b[i]);
//            }
//            Console.WriteLine("Enter the number of days:");
//            int e = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter Sales Number by user:");
//            int[] f = new int[e];

//            for (int i = 0; i < e; i++)
//            {
//                f[i] = int.Parse(Console.ReadLine());
//            }
//            for (int i = 0; i < e; i++)
//            {
//                Console.WriteLine(f[i]+ "");
//            }
//            if (b.SequenceEqual(f))
//            {
//                Console.WriteLine("The Values in both sets are equal");
//            }
//            else
//            {
//                Console.WriteLine("The values in both sets are not equal");
//            }
//        }
//    }
//}

//TASK-3(2ND QUESTION)
//using System;
//namespace Program
//{
//    class Student
//    {
//        static void Main()
//        {

//            Console.WriteLine("Enter the no.of subject:");

//            int c = int.Parse(Console.ReadLine());
//            int[] b = new int[c];

//            Console.WriteLine("Enter the marks");
//            for (int i = 0; i < c; i++)
//            {

//                int a = int.Parse(Console.ReadLine());
//                b[i] = a;
//            }



//                Console.WriteLine("The Original Array is:");
//                for (int i = 0; i < c; i++)
//                {



//                Console.WriteLine(b[i]);

//                }
//            Console.WriteLine("The Sorted Array is:");
//            Array.Sort(b);
//            for(int i=0;i<c;i++)
//            {
//                Console.WriteLine(b[i]);
//            }
//            int total = 0;
//            int maximum = b[0];
//            int minimum = b[0];
//            for (int i = 0; i < c; i++)
//            {
//                total += b[i];

//                if (b[i]>maximum)
//                {
//                    maximum = b[i];

//                }
//                if (b[i]<minimum)
//                {
//                    minimum = b[i];

//                }


//            }
//            Console.WriteLine($"The total mark is:{total}");
//            Console.WriteLine($"The highest mark is:{maximum}");
//            Console.WriteLine($"The lowest mark is:{minimum}");

//            Console.WriteLine("Enter the mark you want to search");
//            int key = int.Parse(Console.ReadLine());
//            int result = Array.BinarySearch(b, key);
//            if(result<0)
//            {
//                Console.WriteLine($"The serached mark {key} is not found ");

//            }
//            else
//            {
//                Console.WriteLine($"The searched element {key} is found at the index {result}");
//            }
//            Console.WriteLine("The Copied Array is:");
//            int[] k= new int[c];
//            for (int i = 0; i < c; i++)
//            {
//                Array.Copy(b, k, b.Length);
//                Console.WriteLine(k[i]);
//            }


//            Console.WriteLine("Enter the second number of marks by the user:");
//            int e = int.Parse(Console.ReadLine());
//            int[] h = new int[e];
//            Console.WriteLine("Enter the marks:");
//            for (int i = 0; i < e; i++)
//            {
//                h[i] = int.Parse(Console.ReadLine());
//            }

//           if(b.SequenceEqual(h))
//            {
//                Console.WriteLine("The Values in both the arrays b and h are equal ");
//            }
//            else
//            {
//                Console.WriteLine("The Values in both the arrays b and h are not equal");
//            }
//        }
//        }
//    }









//Task -5(Using constructor)
//using System;
//namespace Program
//{
//    internal class Employee
//    {
//        string e_name;
//        decimal basicsalary, hra, da, tax, grosspay, netpay;


//        public Employee(string name, decimal salary)
//        {


//            e_name = name;
//            basicsalary = salary;
//        }
//        public void CalculateNetPay()
//        {
//            hra = basicsalary * 15 / 100;
//            da = basicsalary * 10 / 100;
//            grosspay = basicsalary + hra + da;
//            tax = grosspay * 8 / 100;
//            netpay = grosspay - tax;

//        }
//        internal void display()
//        {
//            Console.WriteLine($"Employee Name:{e_name}");
//            Console.WriteLine($"Basic Salary:{basicsalary}");
//            Console.WriteLine($"HRA:{hra}");
//            Console.WriteLine($"DA:{da}");
//            Console.WriteLine($"GROSSPAY:{grosspay}");
//            Console.WriteLine($"TAX:{tax}");
//            Console.WriteLine($"NETPAY:{netpay}");

//        }
//        static void Main()
//        {
//            Employee e = new Employee("Janani", 60000);
//            e.CalculateNetPay();
//            e.display();

//        }

//    }







//}

//////2nd Question

//using System;
//namespace program
//{
//    class Stock
//    {
//        string name;
//        string symbol;
//        double previousclosingprice;
//        double currentclosingprice;
//        double percentagechange;

//        public Stock(string name,string symbol,double previousclosingprice,double currentclosingprice)
//        {
//            this.name = name;
//            this.symbol = symbol;
//            this.previousclosingprice = previousclosingprice;
//            this.currentclosingprice = currentclosingprice;
//        }
//        internal void getChangePercentage()
//        {
//            percentagechange = (currentclosingprice - previousclosingprice) / previousclosingprice * 100;

//        }
//        internal void display()
//        {
//            Console.WriteLine($"Stock Name:{name}");
//            Console.WriteLine($"Stock Symbol:{symbol}");
//            Console.WriteLine($"Previous Closing Price:{previousclosingprice}");
//            Console.WriteLine($"Current Closing Price:{currentclosingprice}");
//            Console.WriteLine($"Percentage Change:{percentagechange}");

//        }
//        static void Main()
//        {
//            Stock s = new Stock("Sugar", "#", 15.000, 20.000);
//            s.getChangePercentage();
//            s.display();
//        }

//    }
//}


//Task-6:(Using Polymorphism and Inheritance)
using System;
namespace Program
{
    class Person
    {
        string firstname;
        string lastname;
        string emailaddress;
        DateTime dateofbirth;

        public Person(string firstname, string lastname, string emailaddress, DateTime dateofbirth)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.emailaddress = emailaddress;
            this.dateofbirth = dateofbirth;
        }
    }
}