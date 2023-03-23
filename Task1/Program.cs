// Принимает на вход значение, преообразует его в int
string ReadData(string msg)
{
    Console.Write(msg);
    return Console.ReadLine() ?? "0";
}

// Создает массив из num элементов введеные пользователем
string[] ArrayGen1D(int num)
{
    string[] array = new string[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = ReadData($"Заполнитете элемент {i} из {num} текстом из клавиатуры");
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

// 