//2) Найти произведение двух матриц

void fillArray(int[,] arr, int startEl, int endEl)
{
	Random rnd = new Random();
	for(int i = 0; i < arr.GetLength(0); i++)
	{
		for(int j = 0; j < arr.GetLength(1); j++)
			arr[i,j] = rnd.Next(startEl, endEl + 1);
	}
}

void printArray(int[,] arr)
{
	for(int i = 0; i < arr.GetLength(0); i++)
	{
		for(int j = 0; j < arr.GetLength(1); j++)
			Console.Write(String.Format("{0 ,4 } ", arr[i,j]) );
		Console.WriteLine();	
	}	
}

void compositionArrays(int[,] arr1, int[,] arr2)
{
	int[,] resultArray = new int[arr1.GetLength(0),arr1.GetLength(1)];
	
	for(int i = 0; i < arr1.GetLength(0); i++)
	{
		for(int j = 0; j < arr1.GetLength(1); j++)
			resultArray[i,j] = arr1[i,j] * arr2[i,j] ;
	}

    Console.WriteLine("Произведение массивов: ");
    printArray(resultArray);
}

Console.WriteLine("Введи кол-во строк массивов: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введи кол-во столбцов массивов: ");
int n = int.Parse(Console.ReadLine());

int[,] array1 = new int[m,n];
int[,] array2 = new int[m,n];
fillArray(array1, 0, 10);
fillArray(array2, 0, 10);

Console.WriteLine("Исходный массива 1: ");
printArray(array1);

Console.WriteLine("Исходный массива 2: ");
printArray(array2);

compositionArrays(array1, array2);




