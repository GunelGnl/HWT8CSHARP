// Lesson 8//Task 54
    Console.WriteLine("Add n and m:");
        int m = InputNumber("Add m: ");
        int n = InputNumber("Add n: ");
        int range = InputNumber("Add range: ");

        int[,] array = new int[m, n];
        CreateArray(array, range);

        Console.WriteLine("Original array:");
        WriteArray(array);

        Console.WriteLine("Sorted array:");
        OrderArrayLines(array);
        WriteArray(array);

    static int InputNumber(string input)
    {
        Console.Write(input);
        int output;
        while (!int.TryParse(Console.ReadLine(), out output))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.Write(input);
        }
        return output;
    }

    static void CreateArray(int[,] array, int range)
    {
        Random random = new Random();

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(1, range + 1);
            }
        }
    }

    static void OrderArrayLines(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Array.Sort(GetRow(array, i), (a, b) => b.CompareTo(a));
        }
    }

    static int[] GetRow(int[,] array, int rowIndex)
    {
        int rowLength = array.GetLength(1);
        int[] row = new int[rowLength];

        for (int i = 0; i < rowLength; i++)
        {
            row[i] = array[rowIndex, i];
        }

        return row;
    }

    static void WriteArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }


    //Task 56

       Console.WriteLine("Add n and m:");
        int m = InputNumber("Add m: ");
        int n = InputNumber("Add n: ");

        int[,] array = new int[m, n];
        CreateArray(array);

        Console.WriteLine("Original array:");
        WriteArray(array);

        int minSumRowIndex = FindMinSumRowIndex(array);
        Console.WriteLine($"Row with the minimum sum of elements: {minSumRowIndex}");

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();


    static int InputNumber(string input)
    {
        Console.Write(input);
        int output;
        while (!int.TryParse(Console.ReadLine(), out output))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.Write(input);
        }
        return output;
    }

    static void CreateArray(int[,] array)
    {
        Random random = new Random();

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(1, 101); // Генерация случайного числа от 1 до 100
            }
        }
    }

    static int FindMinSumRowIndex(int[,] array)
    {
        int minSum = int.MaxValue;
        int minSumRowIndex = -1;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            int rowSum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                rowSum += array[i, j];
            }

            if (rowSum < minSum)
            {
                minSum = rowSum;
                minSumRowIndex = i;
            }
        }

        return minSumRowIndex;
    }

    static void WriteArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }  

//Task 58


int m = InputNumbers("Add number first string : ");
int n = InputNumbers("Add number first matrix : ");
int p = InputNumbers("Add number second matrix: ");
int range = InputNumbers("Add range ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"\nfirst matrix:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);
Console.WriteLine($"\nsecond matrix:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nfirst and second matrix:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array);

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }


  