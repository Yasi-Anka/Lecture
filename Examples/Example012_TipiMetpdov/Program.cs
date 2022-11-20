//  Вид 1 - ничего не принимают и не возвращают
/*
void Method1()
{
    Console.WriteLine("Автор...");
}
Method1();

// Вид 2 ничего не возвращают, ено принимают какие-то аргументы

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текс сообщения");

void Method21(string msg, int count) // отправить на консоль текст 4 раза
{
    int i = 0;
    while ( i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4); // Или Method21(msg: "Текст", count: 4); - явно указать значение аргументов, можно тогда указывать не по порядку

// Вид 3 Не принимает аргументы но возвращает

int Method3()
{
    return DataTime.Now.Year;//показать текущий год
}

int yrar = Method3();
Console.EriteLine(year);

// Вид 4 Методы принимают и возвращают
string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf");//напечатает 10 раз "asdf"
Console.WriteLine(res);

// FOR

string Method4(int count, string text)
{
    string result = String.Empty;
    for( int i = 0; i < count; i++)
       {
        result = result + c;
        }
    return result;
}
string res = Method4(10, "asdf");//напечатает 10 раз "asdf"
Console.WriteLine(res);

// Цикл в цикле (таблица умножения)
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();//Разрыв для того что бы таблица умножения выглядела читабельней
}
// Дан текст. В тексте необходимо все пробелы
// заменить черточками, маленькие буквы "к"
//заменить большими "К", а большие "С" заменить
//на маленькие "С".

 string text = "Дорогие студенты!"
            + "Эта лекция дополнительная, смотреть её желательно, но не обязательно."
            + " - Успехов в обучении!"
             + " - На этом уроке:";

// string s = "qwerty"
//              012
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;// Считает кол-во символов в строке
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text,' ','|' );
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText,'к','К' );
Console.WriteLine(newText);

newText = Replace(newText,'С','с' );
Console.WriteLine(newText);
*/

// Сортировка в массиве:
// 1 Найти позицию минималльного элемента в неотсортированной части массива
// 2 Произвести обмен этого значение со значением первой неотсортированной позиции
// 3 Повторять пока есть не отсортированные элементы

int[] arr = {1, 5, 7, 6, 3, 9, 4, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1 ; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);