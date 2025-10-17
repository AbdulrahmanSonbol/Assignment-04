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

        static void Main(string[] args)
        {
            #region Array

            //int[,] marks = new int[2, 5];

            //for (int i= 0; i < marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Grade of student number {i+1}");

            //    for (int j= 0; j < marks.GetLength(1); )
            //    {

            //       Console.WriteLine($"Subject number {j+1}");

            //        bool isparsed = int.TryParse(Console.ReadLine(), out marks[i,j]);

            //        if (isparsed) j++;
            //    }
            //}

            //Console.Clear();

            //for (int i = 0; i < marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Grade of student number {i + 1}");

            //    for (int j = 0; j < marks.GetLength(1); j++)
            //    {

            //        Console.WriteLine($"Subject number {j + 1} = {marks[i,j]}");

            //    }
            //}



            //int[,] marks = new int [2, 3];

            //for (int i = 0; i < marks.Length; i++ ) { 

            //     int.TryParse(Console.ReadLine(), out int mark);

            //    //if (isoarsed) i++;

            //    marks [i / marks.GetLength(1), i % marks.GetLength(1) ] = mark;


            //}

            //Console.WriteLine("--------------------");

            //for (int i = 0; i < marks.Length; i++)
            //{

            //    Console.WriteLine(marks[i / marks.GetLength(1), i % marks.GetLength(1)]);

            //}


            #endregion

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
        }
    }
}
