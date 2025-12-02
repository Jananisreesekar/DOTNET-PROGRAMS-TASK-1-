using System;
namespace mycode
{
    class program
    {
        static void Main()
        {
            string transactionID = "ABCDEF234245";
            Console.WriteLine("The transaction ID is:{0}",transactionID);
            decimal amount = 7986666.67M;
            Console.WriteLine("The amount is:{0}",amount);
            bool isInternational = true;
            Console.WriteLine(isInternational);
            float customerrating = 3.0f;
            Console.WriteLine("The Customer rating is:{0}", customerrating);
            DateTime transactiontimestamp = DateTime.Now;
            Console.WriteLine("The transaction timestamp is:{0}", transactiontimestamp);
            long rewardpoints = 66677776;
            Console.WriteLine("The rewardpoints is:{0}", rewardpoints);



        }
    }
}

