


using System.Collections;
using System.Runtime.CompilerServices;

//DateTime date = new DateTime();
double CurrentBalance = 100000;
string CashWithdraw = "Cash Withdraw";
string CashDeposit = "Cash Deposit";
Console.WriteLine("Welcome User! \n");
string[] @string = new string[0];
List<string> list = new List<string>();
while (true)
{

    Console.WriteLine("How can i help you today? \n");

    ArrayList arrayList = new ArrayList();


    arrayList.Add("1) Cash Withdrawl");
    arrayList.Add("2) Account Balance Inquiry");
    arrayList.Add("3) Mini Statement");
    arrayList.Add("4) Cash Deposit");
    //arrayList.Add("");

    foreach (var item in arrayList)
    {
        Console.WriteLine(item);
    }
    Console.Write("\n");
    Console.WriteLine("Please Type the highlighted keywords");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num == 1)
    {
        while (true)
        {
            Console.WriteLine("\n" + "Please Select Amount You want to Withdraw" + "\n");
            Console.WriteLine("1) Rs 20000");
            Console.WriteLine("2) Rs 15000");
            Console.WriteLine("3) Rs 25000");
            Console.WriteLine("4) Other Amount");
            Console.WriteLine("5) Return in main Menu");

            int Withdraw = Convert.ToInt32(Console.ReadLine());

            if (Withdraw == 1)
            {
                if (CurrentBalance > 20000)
                {
                    CurrentBalance = CurrentBalance - 20000;

                    list.Add($"{CashWithdraw} -20000");
                    @string = list.ToArray();
                    Console.WriteLine($"Your Current Balance is {CurrentBalance}");
                }
                else
                {
                    Console.WriteLine("Your Balance is Insufficient");
                }

            }
            else if (Withdraw == 2)
            {
                if (CurrentBalance > 15000)
                {
                    CurrentBalance = CurrentBalance - 15000;
                    list.Add($"{CashWithdraw} -15000");
                    @string = list.ToArray();
                    Console.WriteLine($"Your Current Balance is {CurrentBalance}");
                }
                else
                {
                    Console.WriteLine("Your Balance is Insufficient");
                }
            }
            else if (Withdraw == 3)
            {
                if (CurrentBalance > 25000)
                {
                    CurrentBalance = CurrentBalance - 25000;
                    list.Add($"{CashWithdraw} -25000");
                    @string = list.ToArray();

                    Console.WriteLine($"Your Current Balance is {CurrentBalance}");
                }
                else
                {
                    Console.WriteLine("Your Balance is Insufficient");
                }

            }
            else if (Withdraw == 4)
            {
                Console.WriteLine("Input The Amount That You Want To Withdraw");
                int randomAmount = Convert.ToInt32(Console.ReadLine());
                if (CurrentBalance >= randomAmount)
                {
                    CurrentBalance = CurrentBalance - randomAmount;

                    list.Add(Convert.ToString($"{CashWithdraw} {-randomAmount}"));
                    @string = list.ToArray();

                    Console.WriteLine($"Your Current Balance is {CurrentBalance}");
                }
                else if (CurrentBalance <= randomAmount)
                {
                    Console.WriteLine($"Your Balance is Insufficinet");
                }
                else
                {
                    Console.WriteLine($"You Input Wrong");
                }
            }
            else if (Withdraw == 5)
            {
                break;
            }
            else
            {
                Console.WriteLine($"You Input Wrong Number");
            }
        }
    }
    else if (num == 2)
    {
        Console.WriteLine($"Your Current Balance Is {CurrentBalance}");
        Console.WriteLine("\nDo You Want To Retrun Main Menu ?? \n1) To return \n2) To exit");
        int balanceinquiry = Convert.ToInt32(Console.ReadLine());
        if (balanceinquiry == 1)
        {
            continue;
        }
        else
        {
            break;
        }
    }
    else if (num == 3)
    {
        if (@string.Count() >= 1)
        {
            foreach (var item in @string)
            {
                Console.WriteLine(item);
            }
            continue;
        }
        else if (@string.Count() == 0)
        {

            Console.WriteLine("Your Haven't WithDraw Any Cash From Bank");
            //break;
        }
    }
    else if (num == 4)
    {
        while (true)
        {

            Console.WriteLine("Insert the Amount That You Want To Deposit");
            int Deposit = Convert.ToInt32(Console.ReadLine());
            CurrentBalance += Deposit;

            Console.WriteLine($"Your Current Balance is {CurrentBalance}");

            list.Add(($"{CashDeposit} {Deposit}"));
            @string = list.ToArray();
            Console.WriteLine($"You Want To Desposit More Amount ?? yes or no ");
            string? DepositMAmt = Console.ReadLine();

            if (DepositMAmt == "yes")
            {
                continue;
            }
            else if (DepositMAmt == "no")
            {
                break;
            }
            else
            {
                break;
            }
        }
    }
    else
    {
        Console.WriteLine("You Entered Wrong Number .. Please Input Correct Number !!");
    }
}