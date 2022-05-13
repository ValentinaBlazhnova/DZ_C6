/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3*/

Console.WriteLine("Введите числа через запятую(после запятой пробел): ");
string numbers = Console.ReadLine();

int countNumbers = 1;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == ',')
    countNumbers++;
}

int[] array = new int[countNumbers];
int arrayIndex = 0;

for(int i = 0; i < numbers.Length; i++)
{
    string subString = String.Empty;
    while (numbers[i] != ',')
    {
        subString += numbers[i].ToString();
        i++;

        if (i >= numbers.Length)
        break;
    }

    if(subString == "" || subString == " ")
        continue;

    array[arrayIndex] = Convert.ToInt32(subString);
    arrayIndex++;
}

/*for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}                                          - ВЫВОД МАССИВА
код ввода чисел и вывода их в массив,
код ниже - проверка на кол-во чисел больше 0*/

int count =0;
for (int i = 0; i < array.Length; i++)
if (array[i] > 0)
count++;
Console.Write($"Больше 0: {count}");


