 using System;

namespace CashRegister
{
    class Program
    {
        //method for Q4
        public static double UserConverter(string userInput)
        {

            double convertedAmount = double.Parse(userInput);
            return convertedAmount;

        }

        //method for  Q5
        public static decimal ChangeCalculator(decimal changeDue, decimal denomination, string currency)
        {
            int currencyCount = (int)(changeDue / denomination);
            decimal changeLeft = (changeDue % denomination);

            if (currencyCount != 0)
            Console.WriteLine($"Printing out ({currencyCount}) {currency}, You are owed ${changeLeft}...");


            return changeLeft;
        }


         static void Main(string[] args)
        {


            string userPaymentAmount;
            string userPurchaseAmount;
            decimal purchaseValidator=1;
            decimal paymentValidator=0;

          
            while (paymentValidator < purchaseValidator) {

            Outer:
                try
                {
                    Console.WriteLine("Please check to make sure your inputs are valid.\nEnter purchase amount: ");
                    userPurchaseAmount = Console.ReadLine();
                    try
                    {
                        purchaseValidator = decimal.Parse(userPurchaseAmount);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                        goto Outer;
                    }
                    
                }
                catch(Exception e)
                {
                   
                    Console.WriteLine($"That is an invalid input. Exception thrown: {e.Message}");
                    goto Outer;
                }

                if (purchaseValidator <= 0)
                {
                    goto Outer;
                }
                try
                {
                    Console.WriteLine("Enter payment amount: ");
                    userPaymentAmount = Console.ReadLine();
                    try
                    {
                        paymentValidator = decimal.Parse(userPaymentAmount);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                        goto Outer;
                    }
                    
                }
                catch(Exception e)
                {
                    Console.WriteLine($"That is an invalid input. Exception thrown: {e.Message}");
                    goto Outer;
                }
               



            }


            decimal convertedPurchaseAmount = (decimal)UserConverter(purchaseValidator.ToString());
             
                decimal convertedPaymentAmount = (decimal)UserConverter(paymentValidator.ToString());

                if (convertedPaymentAmount < convertedPurchaseAmount)
                {
                    Console.WriteLine("That is not enough change");
                }
                else if (convertedPaymentAmount == convertedPurchaseAmount)
                {
                    Console.WriteLine("You have entered exact change, thank you.");
                }
                else
                    Console.WriteLine($"Your total change is ${convertedPaymentAmount - convertedPurchaseAmount}");
      

                



            decimal changeLeft = ChangeCalculator(convertedPaymentAmount - convertedPurchaseAmount, 20.00m, "20 dollar bill(s)");
            changeLeft = ChangeCalculator(changeLeft, 10.00m, "10 dollar bill(s)");
            changeLeft = ChangeCalculator(changeLeft, 05.00m, "5 dollar bill(s)");
            changeLeft = ChangeCalculator(changeLeft, 01.00m, "1 dollar bill(s)");
            changeLeft = ChangeCalculator(changeLeft, 00.25m, "quater(s)");
            changeLeft = ChangeCalculator(changeLeft, 00.10m, "dime(s)");
            changeLeft = ChangeCalculator(changeLeft, 00.05m, "nickel(s)");
            ChangeCalculator(changeLeft, 00.01m, "cents");



        }
        }


    }

