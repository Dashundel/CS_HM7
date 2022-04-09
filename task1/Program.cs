//1) Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
//что это невозможно (в случае, если матрица не квадратная).

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
			Console.Write(String.Format("{0, 4 } ", arr[i,j]) );
		Console.WriteLine();	
	}	
}

void changeStringColumn(int[,] arr)
{
    int t = 0;
	for(int i = 0; i < arr.GetLength(0); i++)
	{
		for(int j = i + 1 ; j < arr.GetLength(1); j++)
		{	
            t = arr[i,j];
            arr[i,j] = arr[j,i];
            arr[j,i] = t;
        }
	}	
}

Console.WriteLine("Введи кол-во строк массива: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введи кол-во столбцов массива: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m,n];
fillArray(array, 0, 99);
Console.WriteLine("Исходный массива: ");
printArray(array);

if(m != n) Console.WriteLine("Матрица не квадратная ");
else 
{
   changeStringColumn(array);
   Console.WriteLine("Измененный массива: ");
    printArray(array);
}


