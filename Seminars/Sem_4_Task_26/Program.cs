/* 
Задача 26: Напишите программу, которая принимает на вход число 
и выдаёт количество цифр в числе. 
456 -> 3
78 -> 2
89126 -> 5
*/
Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (userNumber > 0)
{
    userNumber = userNumber / 10;
    count++;
}
Console.WriteLine($"Число состоит из {count} цифр!");