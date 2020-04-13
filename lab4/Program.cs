/*Завдання
 Вихідним є текстовий файл. У текст можуть входити слова з латинських букв, цифри, знаки арифметичних
 операцій, крапка, кома, пробіл. Потрібно зчитати текст з файлу, вивести цого на екран, після рішення
 задачі вивести на екран результат. Групою букв будемо називати таку сукупність послідовно розташованих
 букв (слово), якій безпосередньо не передує і за якою безпосередньо не слідує буква. Аналогічно визначається
 група цифр і група знаків.
 Розробити список тестів та реалізувати код з урахуванням даних тестів і вивести результати тестування на
 екран.

 Вивести на екран текст, складених з останніх букв усіх груп букв даного файлу.
 */

using System;
using System.IO;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            try
            {   //відкриття текстового файлу за допомогою зчитувача потоків
                //lab4/bin/Debug/netcoreapp3.1 - місцезнаходження у папці з проектом файлу "text.txt"
                using (StreamReader sr = new StreamReader("text.txt"))
                {
                    //зчитування потоку в строку і запис строки в консоль
                    string line1 = sr.ReadToEnd();
                    Console.WriteLine("Вихідний текст: " + line1);

                    string[] array = line1.Split(' ', ',', '.'); /*використовується для розбиття рядка 
                                                                   з роздільниками на підрядки*/
                    string line2 = "";

                    for (int i = 0; i < array.Length; i++)
                    {
                        line2 += array[i][array[i].Length - 1];
                    }
                    Console.WriteLine("Текст, складений з останніх букв усіх груп букв: " + line2);
                    Console.ReadKey();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Файл неможливо відкрити. Перевірте його наявність у проекті");
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Пустий файл");
            }
        }
    }
}