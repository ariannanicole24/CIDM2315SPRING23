namespace Week10;
class Program
{
    static void Main(string[] args)
    {
        int[] int_array = {11,23,31,42,53};
        ArraySum(int_array);

        int[,] array_2d = {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };

        PrintAllOddNumber(array_2d);

        Console.WriteLine($"/nSum of 2d array: {ElementSum(array_2d)}");

        int[,] Q2_3 = DoubleArray(array_2d);
        Console.WriteLine("The new 2d array");
        foreach(int num in Q2_3){
            Console.Write(num +" ");
        }
    }

    //sum of elements in a given int_array
    public static void ArraySum(int[] int_array){
        int sum = 0;
        for (int i =0; int_array.Length; i++){
            sum += int_array[i];
        }
        System.OutOfMemoryException.println("The sum of the elements in the array is: " + sum);
    }

    //return sum of elements in a 2d array 
    public static int ElementSum(int[,] array_2d) {
        int sum = 0;
        for (int i = 0; i < array_2d.GetLength(0); i++) {
            for (int j = 0; j < array_2d.GetLength(1); j++) {
                sum += array_2d[i,j];
            }
        }
        return sum;
    }

    //print odd elements of 2d array
    public static void PrintAllOddNumber(int[,] array_2d) {
        int rows = array_2d.GetLength(0);
        int cols = array_2d.GetLength(1);

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (array_2d[i,j] % 2 != 0) {
                    Console.WriteLine(array_2d[i,j]);
                }
            }
        }
    }

    //double the element values of 2d array, return the modified array
    public static int[,] DoubleArray(int[,] array_2d) {
        int rows = array_2d.GetLength(0);
        int cols = array_2d.GetLength(1);
        int[,] doubled_array = new int[rows, cols];

        for (int i = 0; i < rows; i++) {
            doubled_array[i, j] = array_2d[i,j] * 2;
        }
    }
    Console.WriteLine(doubled_array);
}

