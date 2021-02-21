using System;

namespace CashRegister
{
    class Program
    {



        public static void ChangeCalculation(decimal changeDue, decimal denomination)
        {

            changeDue = ChangeCalculator(changeDue, denomination);
            changeDue = ChangeCalculator(changeDue, 10.00m);
            changeDue = ChangeCalculator(changeDue, 05.00m);
            changeDue = ChangeCalculator(changeDue, 01.00m);
            changeDue = ChangeCalculator(changeDue, 00.25m);
            changeDue = ChangeCalculator(changeDue, 00.10m);
            changeDue = ChangeCalculator(changeDue, 00.05m);
            changeDue = ChangeCalculator(changeDue, 00.01m);


        }
        //method for Q4
        public static decimal UserInput(string request)
        {
            Console.Write(request);
            string userInput = Console.ReadLine();
            decimal convertedAmount = decimal.Parse(userInput);
            if (convertedAmount <= 0)
            {

            }
            return convertedAmount;

        }

        //method for  Q5
        public static decimal ChangeCalculator(decimal changeDue, decimal denomination)
        {
            int currencyCount = (int)(changeDue / denomination);
            decimal refund = (changeDue % denomination);

            if (currencyCount != 0)
                Console.WriteLine($"Printing out ({currencyCount}) ${denomination.ToString()}, You are owed ${refund}...");


            return refund;
        }

        public static decimal PaymentValidator()
        {
            decimal userPaymentAmount;
            decimal userPurchaseAmount;
            do
            {
                userPurchaseAmount = UserInput("Enter Purchase Amount: ");

            } while (userPurchaseAmount <= 0);


            do
            {
                userPaymentAmount = UserInput("Enter Payment Amount: ");

            } while (userPaymentAmount <= 0);

            return userPaymentAmount - userPurchaseAmount;
        }

        public static void Main(string[] args)
        {
            decimal differenceOfUserInputs;


            do
            {
                differenceOfUserInputs = PaymentValidator();

            } while (differenceOfUserInputs < 0);



            if (differenceOfUserInputs == 0)
            {
                Console.WriteLine("You have entered exact change, thank you.");
            }


            else
            {
                Console.WriteLine($"Your total change is ${differenceOfUserInputs}");

                ChangeCalculation(differenceOfUserInputs, 20.00m);
            }

        }

    }
}