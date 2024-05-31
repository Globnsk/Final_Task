// Создаем ввод с консоли элементов массива
// 1. Вводим количество элементов массива
//string input_pars()
//{
    Console.WriteLine("Введите количество элементов массива");
    string k = Console.ReadLine();
    int num_elms = Convert.ToInt32(k);
    // Вводим количество символов в элементе финального массива
    Console.WriteLine("Введите количество символов в элементе финального массива");
    string m = Console.ReadLine();
    int char_nums = Convert.ToInt32(m);

    //Console.WriteLine(n);
    // 2. Создаем пустой str массив и заполняем его значениями
    string[] arr_str = new string[num_elms];
    int i = 0;
    while (i < num_elms)
    {
        Console.WriteLine("Введите  " + (i + 1) + "-й элемент массива");
        arr_str[i] = Console.ReadLine();
        //Console.WriteLine(arr_str[i]);
        i += 1;
    }
    //return (arr_str, num_arr_elms, char_nums);
//}
// 3. Метод определения элементов массива с заданным количеством символов
//string final_array(int n, int j, string[] arr)
//{
    //string[] arr_fnl = new string [n];
    //Определяем количество элементов заданной длины
    int count = 0;
    for ( i = 0; i < num_elms; i++)
    {
        if (arr_str[i].Length == char_nums)
        {
            count++;
        }
    }
    //return count;
    // Заполняем финальный массив элементами исходного массива нужной длины
    string[] arr_fnl = new string[count];
    int j = 0;
    for (i = 0; i < count ; i++)
    {
        if (arr_str[i].Length == char_nums)
        {
            arr_fnl[j] = arr_str[i];
            Console.Write ($"{arr_fnl[j]}" + ",");
            j+=1;
        }
    }
    //return (arr_fnl);
//}

// Выводим на экран финальный массив
//void PrintArray(string[] array)
//{
    //for (i = 0; i < arr_fnl.Length; i++)
    //{
       // Console.Write($"{arr_fnl[i]} ");
    //}
    //Console.WriteLine();
//}
//input_pars ();
//final_array (num_elms, char_nums,  arr_str);
//PrintArray ( arr_fnl );

