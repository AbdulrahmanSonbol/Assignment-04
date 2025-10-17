namespace Sonbol
{
    internal class Program
    {

        #region Q1

        //public static void ChangeValueByValue(int? num)
        //{
        //    num = 7; 
        //}

        //public static void ChangeValueByRef(ref int? num)
        //{
        //    num = 7;
        //}

        #endregion

        #region Q2

        //public static void ChangeNumByValue(int[] arr, int size)
        //{

        //    arr[0] = 7;

        //    arr = new int[] { 7, 7, 7, 7, 7 }; 

        //    for (int i = 0; i < size; i++)
        //    {
        //        Console.Write(arr[i] + " ");
        //    }
        //}

        //public static void ChangeNumByRef(ref int[] arr, int size)
        //{

        //    arr = new int[] { 21, 21, 21, 21, 21, 21, 21 };

        //    for (int i = 0; i < size; i++)
        //    {
        //        Console.Write(arr[i] + " ");
        //    }
        //}


        #endregion

        #region Q3

        //public static void SumAndSub(int x, int y, out int sum, out int sub)
        //{
        //    sum = x + y;
        //    sub = x - y;
        //}

        #endregion

        #region Q4

        //public static int SumOfTheIndividualDigits(ref int num)
        //{
        //    int original = num; // عشان احافظ علي القيمه الاصليه

        //    int sum = 0;

        //    while (num != 0) 
        //    {
        //        int digit = num % 10; 
        //        sum += digit;         
        //        num /= 10;            


        //    }

        //    num = original; 

        //    return sum;

        //}


        #endregion

        #region Q5

        //public static bool IsPrime(int num)
        //{
        //    if (num <= 1)
        //    {
        //        return false;
        //    }


        //    for (int i = 2; i < num; i++)
        //    {
        //        if (num % i == 0)
        //        {
        //            return false;
        //        }

        //    }

        //    return true;
        //}

        #endregion

        #region Q6

        //public static void MinMaxArray(ref int[] arr, int size,  ref int min , ref int max)
        //{

        //    for (int i = 0; i < size; i++)
        //    {
        //        if (arr[i] < min) min = arr[i];
        //        else if (arr[i] > max)  max = arr[i];
        //    }


        //}

        #endregion

        #region Q7

        //public static int FactorialOfTheNumber (ref int number)
        //{

        //    int Count = 1;

        //    for (int i = 1; i <= number; i++)
        //    {
        //        Count *= i;
        //    }

        //    return Count;

        //}   


        #endregion

        #region Q8

        //public static void ChangeChar (ref char[] arr, int size, int position, char letter)
        //{

        //    arr[position] = letter ;

        //    for (int i = 0; i < size; i++) {
            
        //       Console.Write (arr[i] + " ");
            
        //    }

        //}

        #endregion


        static void Main(string[] args)
        {
            #region Q1

            //Value type -->
            // 1- by value
            // A- ينسخ القيمة فقط
            // B- اي تغيير يحصل داخل الدالة ما بيأثرش على المتغير الأصلي

            //Example

            //int? x = 21;

            //ChangeValueByValue(x);

            //Console.WriteLine($"After ChangeValueByValue: {X}");


            // 2- by Reference
            // A- يمرر Ref بدل القيمه
            // B- اي تغيير يحصل داخل الدالة ياثر على المتغير الأصلي

            //Example

            //int? y = 21;

            //ChangeValueByRef(ref y);

            //Console.WriteLine($"After ChangeValueByValue: {y}");


            #endregion

            #region Q2

            // Reference type -->

            // 1- by value
            // A- يمرر نسخه من Ref 
            // B- اي تغيير يحصل داخل الدالة ياثر على المتغير الأصلي
            // C- لو الRef اتغير مش بياثر علي الRef القديم

            //Example

            //int[] x = { 1, 2, 3, 4, 5 };

            //ChangeNumByValue(x, x.Length );

            //Console.Write($"After ChangeValueByValue: ");

            //foreach (var i in x) Console.Write(i + " ");

            // 2- by Reference
            // A- يمرر الRef نفسه مش نسخه منه 
            // B- اي تغيير يحصل داخل الدالة او فالRef ياثر على المتغير الأصلي

            //Example

            //int[] y = { 1, 2, 3, 4, 5 };

            //ChangeNumByRef(ref y, y.Length);

            //Console.Write($"After ChangeValueByRef: ");

            //foreach (var i in y) Console.Write(i + " ");


            #endregion

            #region Q3

            //int num1 = 7, num2 = 21;
            //int sum , sub;


            //SumAndSub(num1, num2, out sum, out sub);

            //Console.WriteLine($"{num1} + {num2} =  {sum} \n{num1} - {num2} =  {sub}");


            #endregion

            #region Q4

            //int x;

            //Console.Write("Enter a number: ");

            //bool isparsed = int.TryParse(Console.ReadLine(), out x);

            //if (isparsed) {

            //    int result = SumOfTheIndividualDigits(ref x);
            //    Console.WriteLine(result);
            //}

            #endregion

            #region Q5

            //Console.WriteLine(IsPrime(4));
            //Console.WriteLine(IsPrime(3));


            #endregion

            #region Q6

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 21 };

            //int size = arr.Length;

            //int min = arr[0], max = arr[0]; 

            //MinMaxArray(ref arr,size,ref min, ref max);

            //Console.WriteLine($"Maximum value in array: {max}");
            //Console.WriteLine($"Minimum value in array: {min}");

            #endregion

            #region Q7

            //int x = 5;

            //Console.WriteLine(FactorialOfTheNumber(ref x));

            #endregion

            #region Q8

            //char[] arr = { 'B', 'B', 'D', 'O' };
            //int size = arr.Length;

            //ChangeChar(ref arr, size, 0, 'A');

            #endregion

            #region Q9

            //int[] arr = { -1, 2, 3, 4, 5, -6, 7, 8, 9, -10 };

            //int count = 0;

            //for (int i = 0; i < arr.Length; i++) {

            //    count += arr[i];
            //}

            //Console.WriteLine(count);

            #endregion

            #region Q10

            //int[] arr1 = { 1, 2, 3, 4, 5 };
            //int[] arr2 = { 6, 7, 8, 9, 10 };

            //int size = arr1.Length + arr2.Length;

            //int[] merged = new int[size];


            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    merged[i] = arr1[i];
            //}


            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    merged[arr1.Length + i] = arr2[i];
            //}

            //Array.Sort(merged);


            //Console.Write("Merged array in ascending order: ");

            //foreach (int num in merged)
            //{
            //    Console.Write(num + " ");
            //}



            #endregion

            #region Q11

            //int[] arr = { 7, 1, 2, 21, 3, 8, 3, 4, 5, 6, 7, 7, 8, 8, 9, 10, 21, 21, };

            //int size = arr.Length;



            //int[] arrFreq = new int[size];

            //Console.Write("Array elements:");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            //Console.WriteLine("\n");


            //bool[] visited = new bool[size];


            //for (int i = 0; i < size; i++)
            //{
            //    Array.Sort(arr);

            //    if (visited[i]) continue;

            //    int count = 0;


            //    for (int j = 0; j < size; j++)
            //    {

            //        if (arr[i] == arr[j]) { 

            //            count++;

            //            visited[j] = true;
            //        }


            //    }

            //    arrFreq[i] = count;

            //    Console.WriteLine($"Element {arr[i]}  \t{arrFreq[i]} \ttimes");


            //}

            #endregion

            #region Q12


            //int[] arr = { 1, 2, 3, 4, 5, 6, -7, 21 };

            //int size = arr.Length,
            //    min = arr[0],
            //    max = arr[1];

            //for (int i = 0; i < size; i++)
            //{

            //    if (arr[i] < min) min = arr[i];
            //    if (arr[i] > max) max = arr[i];

            //}


            //Console.Write("Array elements: ");

            //foreach (int num in arr) Console.Write(num + " ");

            //Console.WriteLine("\n");

            //Console.WriteLine($"Maximum element is: {max} \nMaximum element is: {min}" );


            #endregion

            #region Q13


            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 21 };

            //int size = arr.Length,
            //    max = arr[0],
            //    SecondLargestElement = arr[1];

            //for (int i = 0; i < size; i++)
            //{
            //    SecondLargestElement = max;

            //    if (arr[i] > max) max = arr[i];


            //}


            //Console.Write("Array elements: ");

            //foreach (int num in arr) Console.Write(num + " ");

            //Console.WriteLine("\n");

            //Console.WriteLine($"Second largest element is: {SecondLargestElement} ");


            #endregion

            #region Q14


            //Console.Write("Enter size of array: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] arr = new int[size];

            //Console.WriteLine("Enter array elements:");

            //for (int i = 0; i < size;)
            //{
            //    bool isparsed = int.TryParse(Console.ReadLine(), out arr[i]);

            //    if (isparsed) i++;
            //}

            //int maxDistance = 0;

           
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = i + 1; j < size; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int distance = j - i - 1; 

            //            if (distance > maxDistance)
            //            {
            //                maxDistance = distance;
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine($"\nThe longest distance between two equal elements is: {maxDistance}");


            #endregion

            #region Q15


            //Console.Write("Enter a sentence: ");
            //string input = Console.ReadLine();


            //string[] words = input.Split(' ');

            //Array.Reverse(words);


            //Console.Write("Reversed: ");

            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.Write(words[i]);

            //    if (i < words.Length - 1)
            //        Console.Write(" ");
            //}


            #endregion

            #region Q16

            //int rows, cols;

            //Console.Write("Enter number of rows: ");
            //rows = int.Parse(Console.ReadLine());

            //Console.Write("Enter number of columns: ");
            //cols = int.Parse(Console.ReadLine());

            //int[,] arr1 = new int[rows, cols];
            //int[,] arr2 = new int[rows, cols];

            //Console.WriteLine("\nEnter elements of the first array: ");

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols;)
            //    {
            //        Console.Write($"Element [{i},{j}]: ");
            //        bool isParsed = int.TryParse(Console.ReadLine(), out arr1[i, j]);

            //        if (isParsed)
            //            j++;
            //        else
            //            Console.WriteLine("Invalid input Please enter a valid number.");
            //    }
            //}

            //Console.Clear();

            //Console.WriteLine("Elements of the 'first' array:\n");

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(arr1[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}


            //Array.Copy(arr1, arr2, arr1.Length);


            //Console.WriteLine("\nElements of the 'second' array 'after copy': \n");

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(arr2[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Q17

            //int[] arr = { 1, -2, 0, 3, -4, -5, 6, -7, 21 };

            //int size = arr.Length;
            //Array.Sort(arr);
            //Array.Reverse(arr);
            //for (int i = 0; i < size; i++)
            //{

            //    Console.WriteLine($"\t{arr[i]}");

            //}



            #endregion





        }
    }
}
