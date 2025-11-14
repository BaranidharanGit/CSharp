namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start of the programming world
            HelloWorld();

            Console.WriteLine();

            NumericDataType();

            Console.WriteLine();

            StringDataType();

            Console.WriteLine();

            BooleanDataType();

            Console.WriteLine();

            Operators();

            Console.WriteLine();

            StringToNumberConversion();

            Console.WriteLine();

        }

        public static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        public static void DataTypesInitialization()
        {
            //Numeric DataType
            int num1;
            long num2;
            double num3;
            float num4;
            decimal num5;

            //Text DataType
            string name;
            char value;

            //Boolean DataType
            bool isTrueOrFalse;
        }
        public static void NumericDataType()
        {
            Console.WriteLine("----- NumericDataType -----");

            //WholeNumber
            int number = 10;
            Console.WriteLine(number);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine();

            long numberTwo = 100;
            Console.WriteLine(numberTwo);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine();

            //DecimalNumbers
            double numberThree = 10.5;
            Console.WriteLine(numberThree);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine();

            float numberFour = 10.00F;
            Console.WriteLine(numberFour);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine();

            decimal numberFive = 10.000M;
            Console.WriteLine(numberFive);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            Console.ReadLine();
        }

        public static void StringDataType()
        {
            Console.WriteLine("----- StringDataType -----");
            //For Whole words
            string name = "Barani";
            Console.WriteLine(name);

            //For Single character 
            char value = 'A';
            Console.WriteLine(value);

            Console.ReadLine();
        }

        public static void BooleanDataType()
        {
            Console.WriteLine("----- BooleanDataType -----");

            bool updated = true;
            Console.WriteLine(updated);

            bool notUpdated = false;
            Console.WriteLine(notUpdated);

            Console.ReadLine();
        }
        public static void Operators()
        {
            Console.WriteLine("----- Operators -----");

            int num1 = 30;
            int num2 = 10;
            int result;

            //Addition of numbers
            result = num1 + num2;
            Console.WriteLine(result);

            //Subtraction of numbers
            result = num1 - num2;
            Console.WriteLine(result);

            //Division of numbers returns quotient
            result = num1 / num2;
            Console.WriteLine(result);

            //Multiplication of numbers
            result = num1 * num2;
            Console.WriteLine(result);

            //Modulus of numbers returns remainder
            result = num1 % num2;
            Console.WriteLine(result);

            //If you need the decimal values of the divison result use double datatype
            double doubleNumberOne = 20;
            double doubleNumberTwo = 3;
            double doubleResult;
            doubleResult = doubleNumberOne / doubleNumberTwo;
            Console.WriteLine(doubleResult);

            //Increament before
            Console.WriteLine(++num1);

            //Increament after
            Console.WriteLine(num1++);
            Console.WriteLine("After Increamenting :" + num1);

            //Decrement before
            Console.WriteLine(--num1);

            //Decrement after
            Console.WriteLine(num1--);
            Console.WriteLine("After Decrementing" + num1);

            Console.ReadLine();
        }

        public static void StringToNumberConversion()
        {
            Console.WriteLine("----- StringToNumberConversion -----");

            string smallNumber = "50";
            int convertedSmallNumber = Convert.ToInt32(smallNumber);
            Console.WriteLine($"Converted Number : {convertedSmallNumber}");

            string LargeNumber = "9000000000000";
            long convertedLargeNumber = Convert.ToInt64(LargeNumber);
            Console.WriteLine($"Converted Large Number : {convertedLargeNumber}");

            string negativeNumber = "-60";
            int negativeNumberConverted = Convert.ToInt32(negativeNumber);
            Console.WriteLine($"Converted Negative Number : {negativeNumberConverted}");

            string decimalString = "55.23";
            decimal decimalNumberConverted = Convert.ToDecimal(decimalString);
            Console.WriteLine($"Converted Decimal Number : {decimalNumberConverted}");

            string floatString = "20.30";
            float floatNumberConverted = Convert.ToSingle(floatString);
            Console.WriteLine($"Converted Float Number : {floatNumberConverted}");

            Console.ReadLine();
        }
    }
}
