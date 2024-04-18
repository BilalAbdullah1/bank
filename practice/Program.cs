


using System.Collections;
using System.Runtime.CompilerServices;

double CurrentBalance = 100000;
Console.WriteLine("Welcome User!");
int[] ints = new int[0];
while (true)
{
    List<int> list = new List<int>();

    Console.WriteLine("How can i help you today?");

    ArrayList arrayList = new ArrayList();


    arrayList.Add("1) Cash Withdrawl");
    arrayList.Add("2) Account Balance Inquiry");
    arrayList.Add("3) Mini Statement");
    //arrayList.Add("");

    foreach (var item in arrayList)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("Please Type the highlighted keywords");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num == 1)
    {
        while (true)
        {
            if (num == 1)
            {
                Console.WriteLine("Please Select Amount You want to Withdraw");
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

                        list.Add(Convert.ToInt32(-20000));

                        ints = list.ToArray();


                        Console.WriteLine($"Now Your Current Balance is {CurrentBalance}");
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
                        list.Add(Convert.ToInt32(-15000));

                        ints = list.ToArray();

                        Console.WriteLine($"Now Your Current Balance is {CurrentBalance}");
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
                        list.Add(Convert.ToInt32(-25000));

                        ints = list.ToArray();

                        Console.WriteLine($"Now Your Current Balance is {CurrentBalance}");
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

                        list.Add(Convert.ToInt32(-randomAmount));
                        ints = list.ToArray();

                        Console.WriteLine($"Now Your Current Balance is {CurrentBalance}");
                    }
                    else if (CurrentBalance <= randomAmount)
                    {
                        Console.WriteLine($"Your Balance is Insufficinet");
                    }
                    else
                    {
                        Console.WriteLine($"");
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
    }
    else if (num == 2)
    {
        Console.WriteLine($"Your Current Balance Is {CurrentBalance}");
        Console.WriteLine("Do You Want To Retrun Main Menu ?? Press 1 to return Press 2 to exit");
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
    else if (num == 3 /*&& ints.Count() > 1*/)
    {
        if (ints.Count() > 1)
        {
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
            continue;
        }
        else if (ints.Count() == 0)
        {

            Console.WriteLine("Your Haven't WithDraw Any Cash From Bank");
            //break;
        }
    }
    else
    {
        Console.WriteLine("You Entered Wrong Number .. Please Input Correct Number !!");
    }
}