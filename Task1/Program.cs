// Принимает на вход строку
string ReadDataStr(string msg)
{
    Console.Write(msg);
    return Console.ReadLine() ?? "0";
}

// Принимает на вход значение и преобразует его в целое число
int ReadDataInt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Создает массив из num элементов введеные пользователем
string[] ArrayGen1D(int num)
{
    string[] array = new string[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = ReadDataStr($"Заполнитете элемент {i+1} из {num} текстом из клавиатуры: ");
    }
    return array;
}

// Печатает 1д массив
void ArrayPrint1D(string[] arrayPrint)
{
    Console.Write("[ ");
    for (int i = 0; i < arrayPrint.Length - 1; i++)
    {
        Console.Write(arrayPrint[i] + ", ");
    }
    Console.WriteLine(arrayPrint[arrayPrint.Length - 1] + " ]");

}

// Метод принимающий на вход массив и количество символов, на выход отдающий новый с таким количеством символов или меньше
string[] ArrayModNValue(string[] arrOld, int n)
{
    string[] arrModNValue = new string[0];
    for (int index = 0; index < arrOld.Length; index++)
    {
        if (arrOld[index].Length <= n)
        {
            arrModNValue = arrModNValue.Concat(new string[] { arrOld[index] }).ToArray();
        }
    }
    return arrModNValue;
}

// ==============================
// Основной код программы
// ==============================

// 1. Пользователь создает массив
int num = ReadDataInt("Какого размера вы хотите создать массив. Введите число: ");
string[] arr = ArrayGen1D(num);

// 2. Выводим пользователю его массив
ArrayPrint1D(arr);

// 3. Создаем новый массив на основе страого с учетом максимального количества символов, который скажет пользователь. Затем показываем его пользователю
int limit = ReadDataInt("Сколько максимум должно быть символов в строке? Введите число: ");
string[] arrLimit = ArrayModNValue(arr, limit);
ArrayPrint1D(arrLimit);