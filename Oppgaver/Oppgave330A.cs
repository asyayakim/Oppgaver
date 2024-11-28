using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace Oppgaver
{

    public class Oppgave330A
    {
        public static void Run()
        {
            var bankAccount = new BankUserAccount("User1");
            var account1 = bankAccount.RegisterNewAccount("John Doe", "123 Street Name", 123456789, 1000);
            var account2 = bankAccount.RegisterNewAccount("Jane Doe", "456 Street Name", 987654321, 500);

            bankAccount.TransferMoney(account1, account2, 500);
            Console.WriteLine($"Balanse on account1 {account1.Money} or account2 {account2.Money}");
            Console.WriteLine("Bank operation completed!");

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
            public Account RegisterNewAccount(string nameOf, string address, int phone, int money)
            {
              var account = new Account(nameOf, address, phone, money);
              _accounts.Add(account);
              return account;
            }

            public class Account
            {
               public string NameOf { get; }
               public string Address { get; }
               public int Phone { get; }
               public int Money { get; set; }

               public Account(string nameOf, string address, int phone, int money)
                {
                    NameOf = nameOf;
                    Address = address;
                    Phone = phone;
                    Money = money;
                }
            }

            public void TransferMoney(Account account1, Account account2, int i)
            {
               account1.Money -= i;
               account2.Money += i;
            }
        }
    }
}