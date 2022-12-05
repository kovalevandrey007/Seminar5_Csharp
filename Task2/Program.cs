/*Задача 32: Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие
 отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/

 //задаю массив
int[] InitArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-9,10);
    }

    return array;
}

//печатает массив на экран
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

bool IsExist(int[]arr, int number)
{

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == number) return true;
    }
    return  false;
}


int[] array= InitArray(5);
PrintArray(array);
Console.WriteLine("введите чиcло: ");
int num = Convert.ToInt32(Console.ReadLine() ?? "");
Console.WriteLine(IsExist(array,num));

/*
int positiveSumm = GetPositiveSumm(arr);
int negativeSumm = GetNegativeSumm(arr);

(int pos, int neg) = GetPositiveAndNegativeSumm(arr);

Console.WriteLine($"Сумма положительных: {positiveSumm}. Сумма отрицательных: {negativeSumm}");

Console.WriteLine($"Сумма положительных: {pos}. Сумма отрицательных: {neg}");*/
/*
//получает сумму положительных элементов в массиве
int GetPositiveSumm(int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
            summ += arr[i];
    }

    return summ;
}
    {
        if(array[i] > 0)
            positive += array[i];
        else
            negative += array[i];
    }

    return (positive, negative);
}

int[] arr = InitArray(12);
PrintArray(arr);
int positiveSumm = GetPositiveSumm(arr);
int negativeSumm = GetNegativeSumm(arr);

(int pos, int neg) = GetPositiveAndNegativeSumm(arr);

Console.WriteLine($"Сумма положительных: {positiveSumm}. Сумма отрицательных: {negativeSumm}");

Console.WriteLine($"Сумма положительных: {pos}. Сумма отрицательных: {neg}");*/
