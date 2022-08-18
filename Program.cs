// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int value = number * number;

// Console.WriteLine("Квадрат числа равен: "+value);

// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 == number2 * number2)
// {
//     Console.WriteLine("Решение: Да!");
// }
// else
// {
//     Console.WriteLine("Решение: Нет!");
// }




// Console.Write("Введите номер дня недели: ");
// int numberday = Convert.ToInt32(Console.ReadLine());
// if (numberday == 1)
// {
//    Console.WriteLine("Понедельник"); 
// }
// else
// {
//     if (numberday == 2)
//     {
//       Console.WriteLine("Вторник");  
//     }
//     else
//         if (numberday == 3)
//         {
//          Console.WriteLine("Среда");  
//         }
//         else
//             if (numberday == 4)
//             {
//               Console.WriteLine("Четверг");
//              }
//              else
//                 if (numberday == 5)
//                 {
//                   Console.WriteLine("Пятница");  
//                  }
//                  else
//                 if (numberday == 6)
//                 {
//                  Console.WriteLine("Суббота");  
//                 }
//                 else
//                     if (numberday == 7)
//                      {
//                     Console.WriteLine("Воскресенье");  
//                     }
//                     else
//                     {
//                        Console.WriteLine("Такого дня не существует"); 
//                     }
// }

Console.Write("Enter number : ");

int number = Convert.ToInt32(Console.ReadLine());

int number2 = number * (-1);

while(number2 <= number)
{

// Console.Write($"{number2},");
Console.Write(number2 + ",");

number2++;

}
