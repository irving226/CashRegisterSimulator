using System;

namespace CashRegister
{
    class Program
    {


        //method definitions for question's 1 & 2
        public static double userInput()
        {
            Console.WriteLine("Hello, Please enter a purchase amount: ");
            double purchaseAmount = double.Parse(Console.ReadLine());
            Console.WriteLine($"You've entered: {purchaseAmount}");
            return purchaseAmount;
        }

        public static double userPayment()
        {

            Console.WriteLine("Please enter a payment amount: ");
            double paymentAmount = double.Parse(Console.ReadLine());
            Console.WriteLine($"You've entered: {paymentAmount}");
            return paymentAmount;

        }

        //method def for Q3
   /*
     public static void ChangeCalculation(double purchaseAmount, double paymentAmount)
        {

            decimal changeDue = (decimal)(paymentAmount - purchaseAmount);
            Console.WriteLine($"Transaction sucessful, standby for: ${changeDue}");
            decimal twenty = 20.00m;
            int twenties = (int)(changeDue / twenty);
            decimal refund = (changeDue % twenty);
            Console.WriteLine($"Twenties: {twenties}");
            changeDue = refund;
            //mod 16.50


            decimal ten = 10.00m;
            int tens = (int)(changeDue / ten);
            refund = (changeDue % 10);
            Console.WriteLine($"Tens: {tens}");
            changeDue = refund;
            //6.5


            decimal five = 5.00m;
            int fives = (int)(changeDue / five);
            refund = (changeDue % five);
            Console.WriteLine($"Fives: {fives}");
            changeDue = refund;
            //1.5

            decimal one = 1.00m;
            int ones = (int)(changeDue / one);
            refund = (changeDue % one);
            Console.WriteLine($"Ones: {ones}");
            changeDue = refund;
            //.5


            decimal quater = 0.25m;
            int quaters = (int)(changeDue / quater);
            refund = (changeDue % quater);
            Console.WriteLine($"Quaters: {quaters}");
            changeDue = refund;

            decimal dime = 0.10m;
            int dimes = (int)(changeDue / dime);
            refund = (changeDue % dime);
            Console.WriteLine($"Dimes: {dimes}");
            changeDue = refund;
            //.5

            decimal nickel = 0.05m;
            int nickels = (int)(changeDue / nickel);
            refund = (changeDue % nickel);
            Console.WriteLine($"Nickels: {nickels}");
            changeDue = refund;
            //
            decimal penny = .01m;
            int pennies = (int)(changeDue / penny);
            refund = (changeDue % penny);
            Console.WriteLine($"Pennies: {pennies}");
            changeDue = refund;





        } */

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
            decimal refund = (changeDue % denomination);

            if (currencyCount != 0)
            Console.WriteLine($"Printing out ({currencyCount}) {currency}, You are owed ${refund}...");


            return refund;
        }




        static void Main(string[] args)
        {


            /*          //code for questions 1 & 2 & 3
                      double purchaseAmount = userInput();
                      double paymentAmount = userPayment();
                      ChangeCalculation(purchaseAmount, paymentAmount);

                      */

            //the code below are for questions 4 & 5

            string userPaymentAmount;
            string userPurchaseAmount;
            decimal purchaseValidator=1;
            decimal paymentValidator=0;

          
            while (paymentValidator < purchaseValidator) {

            Outer:
                try
                {
                    Console.WriteLine("Please check to make sure your inputs are valid. Enter purchase amount: ");
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

