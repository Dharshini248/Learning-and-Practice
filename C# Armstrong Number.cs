using System;
public class Armstrong
{
    public static void Main(string[]args)
    {
        int n,r,temp,sum=0;
        Console.Write("Enter the Value: ");
        n=int.Parse(Console.ReadLine());
        temp=n;
        while(n!=0)
        {
            r=n%10;
            sum=sum+(r*r*r);
            n=n/10;
        }
        if(temp==sum)
        {
            Console.Write("The "+temp+" is Armstrong");
        }
        else
        {
            Console.Write("The "+temp+" is Not a Armstrong");
        }
    }
}
