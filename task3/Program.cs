//3) Сформировать трехмерный массив не повторяющимися двузначными числами 
//показать его построчно на экран выводя индексы соответствующего элемента

void PrintArray(int[,,] arr)
{	
    for(int i = 0; i < arr.GetLength(0); i++)
    {
       for(int j = 0; j < arr.GetLength(1); j++)
        {
            for(int k = 0; k < arr.GetLength(2); k++)
            {
                //Console.WriteLine("("+ i + "," + j + "," + k + "): " + arr[i,j,k] );
                Console.Write($"({i}, {j}, {k}) {arr[i, j, k]} \t");
            }
            //Console.WriteLine(" ");
        }  
        Console.WriteLine("\n");
    } 	
}

int generateElement(int[,,] arr, int ind1, int ind2, int ind3)
{	
    Random rnd = new Random();
    int num = 0;
    int z = arr.GetLength(2);
    bool f; 
    do{
        f = false;
        num = rnd.Next(10, 100); 
        for(int i = 0; i <= ind1; i++)
        {
            for(int j = 0; j <= ind2; j++)
            { 
                if(i == ind1 && j == ind2) z = ind3+1; 
                for(int k = 0; k < z; k++)
                {   
                    if(num == arr[i,j,k]) f = true;
                } 
            }    
        }

                    
    } while(f == true);   
    return num;  
    	
}

void fillArray(int[,,] arr)
{	
    int num = 0;
    for(int i = 0; i < arr.GetLength(0); i++)
    {   
       for(int j = 0; j < arr.GetLength(1); j++)  
       {
            for(int k = 0; k < arr.GetLength(2); k++)  
            {    
                num = generateElement(arr, i, j, k); 
                arr[i,j,k] = num; 
            } 
       }
    } 	
}

Console.WriteLine("Введи кол-во строк массива: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введи кол-во столбцов массива: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Введи размерность z массива: ");
int z = int.Parse(Console.ReadLine());

int[,,] array = new int[x,y,z];
fillArray(array);
PrintArray(array);
