namespace Lecture4;
class Program
{
    static void Main(string[] args)
    {
        int numone, numtwo, maxnum;

        //num1 input
        Console.Write("a = ");
        string user_input = Console.ReadLine();
        numone = Convert.ToInt16(user_input);
        //num2 input
        Console.Write("b = ");
        string userinput = Console.ReadLine();
        numtwo = Convert.ToInt16(userinput);
        
        if(numone > numtwo){
            maxnum = numone;
        }
        else{
            maxnum = numtwo;
        }
        Console.WriteLine($"The largest number is: {maxnum}");
    }
}
