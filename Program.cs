
//  написать программу, которая из имеющегося массива строк
// формирует массив из строк, длинна которых меньше либо равна 3 символа.

string[] array = {"1df","dd","3fdd","@"};
string[] newarray = new string[30];
// вводим счетчик
int counter = 0;
int counter1 = 0;
int newaraylength = 0;

// записваем цикл
while (counter < array.Length)
{
    if (array[counter].Length < 4)
    newarray[counter1] = array[counter];
    counter++;
    counter1++;
}
// удаляем пусте строки
newarray = newarray.Where(x => x != null).ToArray();

// вводим на экран новый массив
while (newaraylength < newarray.Length)
{
    Console.WriteLine(newarray[newaraylength]);
    newaraylength++;
}