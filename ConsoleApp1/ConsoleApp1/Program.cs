using System;

internal class Program
{
    public delegate void MyDelegate(string message);

   

    public static void showmessage(string message)
    { Console.WriteLine("Delegate 1 "+ message); }

    public static void showmessage2(string message)
    { Console.WriteLine("Delegate 2 " + message); }

    public static bool IsPlaindromeFun(string str)
    {
        char[] chars = str.ToCharArray();
        char[] chars1= str.ToCharArray(); 
        Array.Reverse(chars1);
        return chars.SequenceEqual(chars1);
    }
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int[] resultarray=nums1.Concat(nums2).Where(x=>x!=0).ToArray();
        Array.Sort(resultarray);
        foreach (int i in resultarray.Distinct().ToArray())
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
    private static void Main(string[] args)
    {
        for(int i=0;i<=5;i++)
        {
            for(int j=0;j<=i;j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        int[] num1 = { 1, 2, 3, 3, 0,0,0 };
        int[] num2 = { 1,4,5 };

        Program obj = new Program();

        obj.Merge(num1, 0, num2, 6);
        string IsPlaindrome=string.Empty;
        Console.WriteLine("Enter Palindrome: ");

        IsPlaindrome=Console.ReadLine();

        var Isresults=IsPlaindromeFun(IsPlaindrome);

        Console.WriteLine("Entered String "+ IsPlaindrome +" is "+ ((Isresults==true)? "Plaindrome":"Not Palindrome"));

        int[] Incrementlastposition = new int[] { 1, 2, 3 };
        int carry = 1;

        Array.Reverse(Incrementlastposition);

        for(int i=0;i<Incrementlastposition.Length;i++) 
        {
            if (carry == 1)
            {
                Incrementlastposition[i] = Incrementlastposition[i] + 1;
                carry = 0;
                Console.WriteLine(i);
            }
            break;
        }

        Array.Reverse(Incrementlastposition);

        foreach(int i in Incrementlastposition)
        {
            Console.Write (i+" ");
        }
                    
        Console.Write("\nTry Factorial n! = n*(n-1)*(n-2)*.....3 * 2 * 1 with trailing zeros : ");
        int readFactorial = Console.Read();
        //int count = 0;

        ////for(int i=5;i<=readFactorial;i*=5) { count += readFactorial / i; }
        int k=5;
        int counter = 0;
        while (readFactorial / k != 0)
        {
            counter += readFactorial / k;
            k *= 5;
        }
        Console.WriteLine("\nTrailing zeros: " + counter);

        List<int> nums = new List<int> { 10, 20, 30, 40, 50 };
        Console.WriteLine("Below are the list of integers :");
        foreach(int i in nums)
        {
            Console.Write(i+" ");
        }

        Console.WriteLine();
        Console.Write("Enter the number need to be searched: ");
        Console.WriteLine();
        int Targetnumger=20;
        //Targetnumger = Console.ReadLine();

        foreach (int i in nums)
        {
            if (i == Targetnumger)
            {
                Console.WriteLine("Entered Number Found :" + i);
                break;
            }
            else 
            { 
                Console.WriteLine("Entered Number Not Present in the list : " + i + " "); 
            }
        }

        string pattern="man";
        string CounterName = "Humuman";

        int countnumber = 0;
        int patternLength= pattern.Length;
        int CounterNameLength= CounterName.Length - patternLength+1;

        for(int i = 0;i<CounterNameLength;i++) 
        {
            bool found = true;
            for(int j=0;j<patternLength;j++) 
            {
                if (CounterName[i+j] != pattern[j]) 
                {
                    found = false;
                    break;
                }
            }

            if(found) { countnumber++; }    
        }

        Console.WriteLine(CounterName + " having " + countnumber + " Occurances matches of " + pattern);

        string str1= "Kiranachari Shilpi";
        char[] reversestring = str1.ToArray();

        Array.Reverse(reversestring);

        Console.WriteLine(str1);
        Console.WriteLine(string.Join(string.Empty,reversestring));

        //MyDelegate mydelegate = new MyDelegate(showmessage);

        //mydelegate("Show Kiran");

        //mydelegate += mydelegate("Show 2nd Delegate");

        MyDelegate myDelegate = showmessage;
        myDelegate += showmessage2;

        myDelegate("Multicast Delegate");

        MyDelegate myDelegate1 = new MyDelegate(showmessage);

        myDelegate1("Printing new Delegate1");

        myDelegate1("Hello World");

        myDelegate("I'm Kiran");

        //Git Practice

    }
}