namespace Oppgaver
{
    public class Oppgave330A
    {
        public static void Run()
        {
            var bankAccount = new BankUserAccount("User1");
            var account1 = bankAccount.RegisterNewAccount("John Doe", "123 Street Name", 123456789, 1000);
            var account2 = bankAccount.RegisterNewAccount("Jane Doe", "456 Street Name", 987654321, 500);

            // bankAccount.TransferMoney(account1, account2, 500);
            // Console.WriteLine($"Balanse on account1 {account1.Money} or account2 {account2.Money}");
            // Console.WriteLine("Bank operation completed!");
         
            while (true)
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("Press 1 to create a new account");
                Console.WriteLine("Press 2 to transfer money");
                Console.WriteLine("Press 3 to close your account");
                Console.WriteLine("Press 4 to exit");
                var command = Console.ReadKey();
                bankAccount.HandleCommsand(command, account1, account2);
            }
            // ReSharper disable once FunctionNeverReturns
        }

        public class BankUserAccount
        {
            private string _name;
            private readonly List<Account> _accounts;

            public BankUserAccount(string name)
            {
                this._name = name;
                _accounts = new List<Account>();
            }

            public BankUserAccount(List<Account> accounts, string name)
            {
                _accounts = accounts;
                _name = name;
            }

            public Account RegisterNewAccount(string? nameOf, string? address, int phone, int money)
            {
                var account = new Account(nameOf, address, phone, money);
                _accounts.Add(account);
                return account;
            }

            public class Account
            {
                public string? NameOf { get; }
                public string? Address { get; }
                public int Phone { get; set; }
                public int Money { get; set; }

                public Account(string? nameOf, string? address, int phone, int money)
                {
                    NameOf = nameOf;
                    Address = address;
                    Phone = phone;
                    Money = money;
                }
            }

            public void TransferMoney1(Account account1, Account account2, int i)
            {
                account1.Money -= i;
                account2.Money += i;
            }
            public void TransferMoney2(Account account2, Account account1, int i)
            {
                account1.Money += i;
                account2.Money -= i;
            }

            public void HandleCommsand(ConsoleKeyInfo cmdKey, Account account1, Account account2)
            {
                while (cmdKey.Key != ConsoleKey.Escape)
                {
                    if (cmdKey.KeyChar == '1')
                    {
                        Console.Clear();
                        Console.WriteLine("\nCreating a new account...");
                        Console.Write("Enter Name: ");
                        string? name = Console.ReadLine();

                        Console.Write("Enter Address: ");
                        string? address = Console.ReadLine();
                        Console.Write("Enter Phone Number: ");
                        if (!int.TryParse(Console.ReadLine(), out int phone))
                        {
                            Console.WriteLine("Invalid phone number. Operation canceled.");
                            return;
                        }

                        Console.Write("Enter Money: ");
                        if (!int.TryParse(Console.ReadLine(), out int money))
                        {
                            Console.WriteLine("Invalid money number. Operation canceled.");
                            return;
                        }

                        var newAccount = RegisterNewAccount(name, address, phone, money);
                        Console.WriteLine(
                            $"Account created successfully for {newAccount} with balance {newAccount.Money}!");
                        return;
                    }
                    else if (cmdKey.KeyChar == '2')
                    {
                        Console.Clear();
                        Console.WriteLine("\nTransfering money...");
                        Console.WriteLine($"\nFor transfer of money from account1 {account1.Money} and to account2 {account2.Money} Press 1");
                        Console.WriteLine($"\nFor transfer of money from account2 {account2.Money} and to account1 {account1.Money} Press 2");
                        var command = Console.ReadKey();
                        if (command.KeyChar == '1')
                        {
                            Console.WriteLine("Write sum to transfer of money...");
                            var sum = Console.ReadLine();
                            if (sum != null) TransferMoney1(account1, account2, sum.Length);
                            Console.WriteLine($"Account balance Account1 {account1.Money} and Account2 {account2.Money}..");
                            return;
                        }
                        else if (command.KeyChar == '2')
                        {
                            Console.WriteLine("Write sum to transfer of money...");
                            var sum = Console.ReadLine();
                            if (sum != null) TransferMoney2(account2, account1, sum.Length);
                            Console.WriteLine($"Account balance Account1 {account1.Money} and Account2 {account2.Money}..");
                            return;
                        } 
                    }
                    else if (cmdKey.KeyChar == '3')
                    {
                        Console.WriteLine("\nWhich account do you want to delete?");
                        Console.WriteLine("Press 1 to delete account1");
                        Console.WriteLine("Press 2 to delete account2");
                        var deleteAccount = Console.ReadKey();
                        if (deleteAccount.KeyChar == '1')
                        {
                            if (DeleteAccount(account1))
                            {
                                Console.WriteLine($"Account {account1.NameOf} deleted successfully.");
                            }
                            else
                            {
                                Console.WriteLine($"Failed to delete account {account1.NameOf}. It might not exist.");
                            }
                        }
                        else if (deleteAccount.KeyChar == '2')
                        {
                            if (DeleteAccount(account2))
                            {
                                Console.WriteLine($"Account {account2.NameOf} deleted successfully.");
                            }
                            else
                            {
                                Console.WriteLine($"Failed to delete account {account2.NameOf}. It might not exist.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. No account deleted.");
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            private bool DeleteAccount(Account account)
            { 
               return _accounts.Remove(account);
            }
        }
    }
}