//Electricity bill with multiple consumers and their summary report
using System;
namespace program
{
    class sample
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of consumers:");
            int N = int.Parse(Console.ReadLine());
            double Totalrevenue = 0;
            double highestbill = 0;
            int domestictype = 0;
            int commercialtype = 0;
            string Highestbillconsumerid = "";


            Console.WriteLine("CONSUMER DETAILS");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Enter the Consumer id:");
                string consumerid = Console.ReadLine();
                Console.WriteLine("The Consumer id is:" + consumerid);
                Console.WriteLine("Enter the units consumed:");
                int unitsconsumed = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the connection type:");
                int connectiontype = int.Parse(Console.ReadLine());
                if (connectiontype == 1)
                {
                    Console.WriteLine("The connection type is Domestic");
                    domestictype++;
                }
                else
                {
                    Console.WriteLine("The connection type is Commercial");
                    commercialtype++;
                }

                Console.WriteLine("BASE CHARGE");
                double basecharge = 0;
                if (connectiontype == 1)
                {
                    if (unitsconsumed <= 100)
                    {
                        basecharge = unitsconsumed * 1.50;
                        Console.WriteLine("The Basecharge is:" + basecharge);
                    }
                    else if (unitsconsumed > 100 && unitsconsumed <= 300)
                    {
                        basecharge = unitsconsumed * 2.50;
                        Console.WriteLine("The Basecharge is:" + basecharge);



                    }
                    else
                    {
                        basecharge = unitsconsumed * 4.00;
                        Console.WriteLine("The Basecharge is:" + basecharge);
                    }
                }

                else
                {
                    if (unitsconsumed <= 200)
                    {
                        basecharge = unitsconsumed * 5.00;
                        Console.WriteLine("The Basecharge is:" + basecharge);

                    }
                    else if (unitsconsumed > 200 && unitsconsumed <= 500)
                    {
                        basecharge = unitsconsumed * 6.50;
                        Console.WriteLine("The Basecharge is:" + basecharge);
                    }
                    else
                    {
                        basecharge = unitsconsumed * 8.00;
                        Console.WriteLine("The Basecharge is:"+basecharge);
                    }
                }

                Console.WriteLine("ADDITIONAL DETAILS");
                double environmentalsurcharge = 0;
                environmentalsurcharge = 0.03 * basecharge;
                Console.WriteLine("The environmental surcharge is:" + environmentalsurcharge);
                int penalty = unitsconsumed > 500 ? 200 : 0;
                Console.WriteLine("The penalty is:" + penalty);
                double total = basecharge + environmentalsurcharge + penalty;
                Console.WriteLine("The total is:" + total);
                double discount = (total > 2000) ? (total * 0.05) : 0;
                Console.WriteLine("The Discount is:" + discount);
                double Finalbill = total - discount;
                Console.WriteLine("The Final bill is:" + Finalbill);
              

                Totalrevenue += Finalbill;
                if (Finalbill > highestbill)
                {
                    highestbill = Finalbill;
                    Highestbillconsumerid = consumerid;

                }
                
            }
            Console.WriteLine("THE SUMMARY REPORT");
            Console.WriteLine("The total Consumers is:" + N);
            Console.WriteLine("The Total revenue is:" + Totalrevenue);
            Console.WriteLine("The Highest bill is:" + highestbill);
            Console.WriteLine("The Highest consumer id is:" + Highestbillconsumerid);
            Console.WriteLine("The Domestic consumers :" + domestictype);
            Console.WriteLine("The Commercial Consumers:" + commercialtype);


        }
    }
}