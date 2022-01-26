
//  написать программу, которая из имеющегося массива строк
// формирует массив из строк, длинна которых меньше либо равна 3 символа.

string[] array = {"1df","2fdf","3fdfd","@"};
string[] newarray = new string[10];
// вводим счетчик
int counter1 = 0;
while (array[counter1].Length < 4)
{
    newarray[counter1]= array[counter1];
    counter1++;
}

Console.WriteLine(newarray[counter1-1]);