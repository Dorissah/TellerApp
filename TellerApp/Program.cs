using System;

namespace TellerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BankTeller spring = new BankTeller();
            spring.ClientInput();
            spring.DisplayToClient();
        }
    }
    class BankTeller
    {
        public string AccountType { get; set; }
        public decimal Amount { get; set; }
        private decimal SavingsRate = 2.0m / 100;
        private decimal CurrentRate = 3.0m / 100;
        public string FullName { get; set; }

        public void ClientInput()
        {
            Console.WriteLine("Welcome! to Wema Bank, tap enter to calculate your accumulative amount below");
            Console.ReadLine();
            Console.WriteLine("Enter FullName:");
            FullName = Console.ReadLine();
            Console.WriteLine("Enter your preferred account type: ");
            AccountType = Console.ReadLine();
            Console.WriteLine("Enter Amount: ");
            Amount = decimal.Parse(Console.ReadLine());

        }
        public decimal SelectRate(string accountType)
        {
            decimal selectRate;
            if (AccountType == "savings")
            {
                selectRate = SavingsRate;
                return selectRate;

            }
            else if (AccountType == "current")
            {
                selectRate = CurrentRate;
                return selectRate;
            }
            else
            {
                Console.WriteLine("Enter account type again");
                Console.ReadLine();
            }
            return 0;
        }

        public decimal CompoundInterest6()
        {
            decimal interest;
            decimal vat = 7.5m/100m;
            decimal accumAmount = Amount;

            for(int i = 0; i < 6; i++)
            {
                interest = SelectRate(AccountType) * accumAmount;
                interest = interest - (vat * interest);
                accumAmount = accumAmount + interest;
            }
            return accumAmount;
        }

        public decimal CompoundInterest9()
        {
            decimal interest;
            decimal vat = 7.5m / 100m;
            decimal accumAmount = Amount;

            for (int i = 0; i < 9; i++)
            {
                interest = SelectRate(AccountType) * accumAmount;
                interest = interest - (vat * interest);
                accumAmount = accumAmount + interest;
            }
            return accumAmount;
        }

        public decimal CompoundInterest12()
        {
            decimal interest;
            decimal vat = 7.5m / 100m;
            decimal accumAmount = Amount;

            for (int i = 0; i < 12; i++)
            {
                interest = SelectRate(AccountType) * accumAmount;
                interest = interest - (vat * interest);
                accumAmount = accumAmount + interest;
            }
            return accumAmount;
        }
        public decimal CompoundInterest24()
        {
            decimal interest;
            decimal vat = 7.5m / 100m;
            decimal accumAmount = Amount;

            for (int i = 0; i < 24; i++)
            {
                interest = SelectRate(AccountType) * accumAmount;
                interest = interest - (vat * interest);
                accumAmount = accumAmount + interest;
            }
            return accumAmount;
        }
        public decimal CompoundInterest60()
        {
            decimal interest;
            decimal vat = 7.5m / 100m;
            decimal accumAmount = Amount;

            for (int i = 0; i < 60; i++)
            {
                interest = SelectRate(AccountType) * accumAmount;
                interest = interest - (vat * interest);
                accumAmount = accumAmount + interest;
            }
            return accumAmount;
        }
        
        public void DisplayToClient()
        {
            Console.WriteLine ("Your Accumulative savings for 6 month is " + CompoundInterest6());
            Console.WriteLine("Your Accumulative savings for 9 month is " + CompoundInterest9());
            Console.WriteLine("Your Accumulative savings for 12 month is " + CompoundInterest12());
            Console.WriteLine("Your Accumulative savings for 24 month is " + CompoundInterest24());
            Console.WriteLine("Your Accumulative savings for 60 month is " + CompoundInterest60());
        }
    }


}
    
   
