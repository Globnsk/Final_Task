// Создаем ввод с консоли элементов массива
// 1. Вводим количество элементов массива
Console.WriteLine("Введите количество элементов массива");
string k = Console.ReadLine();
int n = Convert.ToInt32(k);
//Console.WriteLine(n);
// 2. Создаем пустой str массив и заполняем его значениями
string [] arr_str = new string [n];
int i=0;
while (i<n)
{
    Console.WriteLine ("Введите  " + (i+1) + "-й элемент массива");
    arr_str[i] = Console.ReadLine ();
    Console.WriteLine(arr_str[i]);
    i+=1;
}