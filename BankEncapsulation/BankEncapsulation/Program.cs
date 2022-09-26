using BankEncapsulation;

Bank_Account Bob = new Bank_Account();

Console.WriteLine("How much money do you want to deposit? ");
double dep = Convert.ToDouble(Console.ReadLine());
Bob.Deposit(dep);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("How much money do you want to withdrawal? ");
double wit = Convert.ToDouble(Console.ReadLine());
Bob.Withdrawal(wit);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Console.Write("Your total money is...");
Bob.GetBalance();