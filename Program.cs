//1  Создаем ввод с консоли элементов массива
//1.1 Вводим количество элементов массива
Console.WriteLine("Введите количество элементов массива");
string k = Console.ReadLine();
int num_elms = Convert.ToInt32(k);

//1.2 Вводим количество символов в элементе финального массива
Console.WriteLine("Введите количество символов в элементе финального массива");
string m = Console.ReadLine();
int char_nums = Convert.ToInt32(m);

// 1.3 Создаем пустой str массив и заполняем его значениями
string[] arr_str = new string[num_elms];
int i = 0;
while (i < num_elms)
{
    Console.WriteLine("Введите  " + (i + 1) + "-й элемент массива");
    arr_str[i] = Console.ReadLine();
    i += 1;
}

// 2. Определяем элементы массива с заданным количеством символов, формируем финальный массив и заполняем его элементами исходного массива нужной длины

//2.1 Определяем количество элементов заданной длины
int count = 0;
for (i = 0; i < num_elms; i++)
{
    if (arr_str[i].Length == char_nums)
    {
        count++;
    }
}

//2.2 Заполняем финальный массив элементами исходного массива нужной длины  и выводим на экран элементы финального массива
string[] arr_fnl = new string[count];
int j = 0;
for (i = 0; i < count; i++)
{
    if (arr_str[i].Length == char_nums)
    {
        arr_fnl[j] = arr_str[i];
        j += 1;
    }
}
Console.Write("[");
Console.Write(string.Join(", ", arr_str));
Console.Write("] => ");
Console.Write("[");
Console.Write(string.Join(", ", arr_fnl));
Console.Write("]");
