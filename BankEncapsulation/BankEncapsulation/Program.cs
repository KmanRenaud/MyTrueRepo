


using BankEncapsulation;

Console.WriteLine("How much money do you want to deposit? ");
double dep = Convert.ToDouble(Console.ReadLine());
Bank_Account.Deposit(dep);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("How much money do you want to withdrawal? ");
double wit = Convert.ToDouble(Console.ReadLine());
Bank_Account.Withdrawal(wit);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Console.Write("Your total money is...");
Bank_Account.GetBalance();