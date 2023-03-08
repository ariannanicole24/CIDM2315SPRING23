namespace Lecture3._0;
class Program
{
    static void Main(string[] args)
        {
        bool prime = true;
        Console.WriteLine("Input an integer: ");

        string user_input = Console.ReadLine();
        int number = Convert.ToInt32(user_input);

        for(int i=2; i<number/2;i++)
        {
            if(number%i==0)
            {
                prime = false;
                break;
            }
        }
        if(prime)
        {
            Console.WriteLine( user_input +" is Prime");
        }
        else{
            Console.WriteLine( user_input +" is non-prime");
        }


        //question 2
        Console.WriteLine("Assign an int value to N: ");

        int N_input = Convert.ToInt16(Console.ReadLine());

        for(int i = 0;i<N_input;i++){

            for(int j =0;j<N_input;j++){
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }
}
