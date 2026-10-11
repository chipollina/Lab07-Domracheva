// Задание 1.1
// string[] days = {"Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс"};
// for (int i = days.Length -1; i>=0; i--) {
//     Console.WriteLine($"{i}: {days[i]}");
// }


// // Задание 1.2
// double[] temps = {-5.5, 0.0, 3.2, 7.8, 12.1, -2.3, 5.0};
// foreach (double i in temps)
// {
//     Console.Write(i + " ");
// }


// Задание 2
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int a = 0;
// int b = 0;
// int c = 0;
// foreach (int i in prices)
// {
//     a += i;
//     b++;
//     if (i > 100)
//     {
//         c++;
//     }
// }
// Console.WriteLine($"общая сумма цен: {a}");
// Console.WriteLine($"средняя цена: {(double)a/b}");
// Console.WriteLine($"количество товаров дороже 100: {c}");


// Задание 3
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int min = prices[0];
// int max = prices[0];
// int ind = 0;
// for (int i = 1; i < prices.Length; i++)
// {
//     if (prices[i] < min)
//     {
//         min = prices[i];
//     }
//     if (prices[i] > max)
//     {
//         max = prices[i];
//         ind = i;
//     }
// }
// Console.WriteLine($"минимальная цена: {min}");
// Console.WriteLine($"максимальная цена:{max}, индекс: {ind}");


// Задание 4
// int[] balance = { 100, -50, 20, -5, 0, 75 };
// for (int i = 0; i < balance.Length; i++)
// {
//     if (balance[i] < 0)
//     {
//         balance[i] = 0;
//     }
//     Console.Write($"{balance[i]} ");
// }


// Задание 5
// int[] nums = new int[5];
// int c = 0;
// for (int i = 0; i < nums.Length; i++)
// {
//     Console.Write($"Введите число: ");
//     nums[i] = int.Parse(Console.ReadLine());
// }
// Console.Write("Массив в обратном порядке: ");
// for (int i = nums.Length -1 ; i>=0; i--)
// {
//     Console.Write(nums[i] + " ");
// }
// for (int i = 0; i < nums.Length; i++)
// {
//     if (nums[i] / 2 == 0)
//     {
//         c++;
//     }
// }
// Console.Write($"количество четных чисел: {c}");


// Задание 6
// string[] names = { "Анна", "Игорь",
// "Мария", "Олег", "Ольга" };
// bool a = false;
// Console.Write("Введите имя: ");
// string name = Console.ReadLine();
// for (int i = 0; i < names.Length; i++)
// {
//     if (names[i] == name)
//     {
//         Console.Write($"Позиция: {i}");
//         a = true;
//     }
// }
// if (a == false)
// {
//     Console.WriteLine("Не найдено");
// }


// Итоговая задача. «Журнал оценок» 
// int[] grades = new int[8];
// int a = 0;
// string b;
// int two = 0;
// int five = 0;
// for (int i = 0; i < grades.Length; i++){
//     Console.Write($"Введите число(от 2 до 5): ");
//     grades[i] = int.Parse(Console.ReadLine());}
// int min = grades[0];
// int max = grades[0];
// foreach (int i in grades){
//     Console.Write(i + " ");}
// for (int i = 0; i < grades.Length; i++){
//     a += grades[i];
//     if (grades[i] == 2){
//         two++;}
//     if (grades[i] == 5){
//         five++;}
//     if (grades[i] < min){
//         min = grades[i];}
//     if (grades[i] > max){
//         max = grades[i];
//     }}
// double sred = (double)a / grades.Length;
// if (sred >= 4.5){
//     b = "Отличник";}
// else if (sred >= 3.5){
//     b = "Хорошист";}
// else{
//     b = "есть над чем поработать";}
// Console.WriteLine($"Средняя оценка: {sred}");
// Console.WriteLine($"Наибольшая оценка: {max}, наименьшая: {min}");
// Console.WriteLine($"количество двоек: {two}, пятерок: {five}");
// Console.WriteLine($"{b}");


// Дополнительное задание ★★★ 
// int[] arr = { 1, 2, 3, 4, 5, 6 };
// int c = 0;
// for (int i = 0; i < arr.Length / 2; i++)
// {
//     c = arr[i];
//     arr[i] = arr[arr.Length - 1 - i];
//     arr[arr.Length - 1 - i] = c;
// }
// foreach (int i in arr)
// {
//     Console.Write(i + " ");
// } 