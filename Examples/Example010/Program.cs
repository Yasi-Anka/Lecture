// Имеется одномерный массив array из n элементов,
// требуется найти элемент массива, равный find
// Алгоритм:
// 1 Установить счётчик index в позицию 0
// 2 Если array [index] = find , алгоритм завершил работу успешно
// 3 Увеличить index на 1
// 4 Если index < n перейти к шагу 2. В противном случае алгоритм завершил работу безуспешно


int [] array = {1,12,31, 4, 15, 16, 17, 18};

int n = array.Length; // определить длинну массива
int find = 4;

int index = 0;

while (index < n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
        break; // прервать, если выполняется условие (для того что бы найти только 1 эллемент и не искать дальше)
    }
    // index = index + 1;
    index++;
 }