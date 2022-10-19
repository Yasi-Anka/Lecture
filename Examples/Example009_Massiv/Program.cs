// Найти максимум из 9-ти чисел, используя массив и функцию
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3; 
    return result;
}

int[] array = { 41, 21, 35,4 , 53, 46, 67, 88, 91 };//Массив

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
    );
Console.WriteLine(result);