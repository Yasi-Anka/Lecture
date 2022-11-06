// Имеется одномерный массив array из n элементов,
// требуется найти элемент массива, равный find
// Алгоритм:
// 1 Установить счётчик index в позицию 0
// 2 Если array [index] = find , алгоритм завершил работу успешно
// 3 Увеличить index на 1
// 4 Если index < n перейти к шагу 2. В противном случае алгоритм завершил работу безуспешно
void FillArray(int[] collection)
{
    int length = collection.Length;//определить длинну массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);// положить в ячейку с индексом случайно сгенерированное число от 1 до 10
        index++;
    }

}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int Index0f(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // -1 для того что бы если эллемент не существует, то возвращали позицию -1 Будет означать что элемент не найден

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int[10];// определение массива из 10-ти эллементов

FillArray(array);// вызвать массив

PrintArray(array);//распечатать массив
Console.WriteLine();

int pos = Index0f(array, 4);
Console.WriteLine(pos);


