using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _14exMyGame
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.InputEncoding = Encoding.UTF8;
            ConsoleKeyInfo keyPressed;
            do
            {
                DateTime toDay = DateTime.Today;
                Random random = new Random();
                int randValue=0;                
                int modPars;
                int counter = 2;
                int numberTo = 9;
                int next = 10;
                Console.Write("Введите свое имя : ");
                string yourName = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Добрый день, " + yourName.ToUpper() + "! " + "Добро пожаловать в игру - Смерть фюрера. Тебе нужно угадать через сколько месяцев умрет путлер!!\nВ случае победы в игре ты продолжишь жить дальше обычной жизнью,\nно будешь знать наверное самое важное событие будущего всего человечества, в противном случае испытаешь удачу ещё раз!\nПравила игры просты: я загадываю случайное количество месяцев от 0 до 9, а потом ты.\nЕсли наши мысли сольются в унисон, то событие обязательно сбудется. Просто, да? У тебя будет целых ТРИ попытки на это.\n\nНу что, начнем?\n\n ");
                Console.ReadKey();
                Console.WriteLine("Если согласен с условиями введи - 1 \nEсли хочешь использовать ХАРДКОР мод, введи - 0");
                string mod = Console.ReadLine();
                while (!int.TryParse(mod, out modPars) || modPars < 0 || modPars > 1)
                {
                    Console.WriteLine("Ошибка ввода. Попробуй ещё раз!");
                    Console.Write("Введи 0 или 1: ");
                    mod = Console.ReadLine();
                }
                if (modPars == 0)
                {
                    counter = 0;
                    numberTo = 5;
                    next = 6;
                    Console.Clear();
                    Console.WriteLine("Ну что ж, удачи. У тебя есть одна попытка. ОК. Ты мне нравишься, я тебе поддамся и загадаю число от 0 до " + numberTo + ".");
                    Console.ReadKey();
                }

                
                Console.Clear();
                Console.Write("Загадываю число: ");
                for (int i = 0; i < 150; i++)
                { 
                    randValue = random.Next(next);                    
                    Console.SetCursorPosition(18, 0);
                    Console.Write(randValue);
                    Thread.Sleep(28);
                    if (i == 50) {
                        Console.SetCursorPosition(20, 0);
                        Console.Write("Ммммм....");
                    }
                    if (i == 100)
                    {
                        Console.SetCursorPosition(30, 0);
                        Console.Write("Щяяяяя...");
                    }
                }
                
                Console.SetCursorPosition(18, 0);
                Console.Write("*                    \nСделано!");
                Console.Write(" Теперь ты загадай любое число от 0 до " + numberTo + ":");
                int youValue;
                string str = Console.ReadLine();
                while (!int.TryParse(str, out youValue) || youValue < 0 || youValue > 9)
                {                    
                    Console.WriteLine("Ошибка ввода. Попробуй ещё раз!");
                    Console.Write("Введите число от 0 до " + numberTo + ":");
                    str = Console.ReadLine();
                }

                DateTime dateTime = toDay.AddMonths(randValue);
                for (int i = counter; i > 0; i--)
                {

                    if (randValue == youValue)
                    {
                        
                        Console.WriteLine("Браво " + yourName.ToUpper() + " , я тоже загадал "+ randValue + ", прими мои поздравления!\nТеперь мы оба знаем, когда все здравомыслящие люди мира вздохнут с облегчением. В эту дату, " + dateTime.ToLongDateString() + " здохнет самый конченый дед в мире,\nи ты можешь себе позволить количество алкоголя немножко больше обычного!");
                        break;
                    }
                    if (randValue > youValue)
                    {
                        Console.WriteLine(yourName.ToUpper() + ", к сожалению ты не угадал, я не такой оптимистичный. У тебя осталось " + i + " попытки");
                        do
                        {                            
                            Console.Write("Введи число от 0 до " + numberTo + ":");
                            str = Console.ReadLine();
                            if (youValue < 0 || youValue > 10) { Console.Write("Ошибка ввода. Попробуй ещё раз!");}
                        }
                        while (!int.TryParse(str, out youValue) || youValue < 0 || youValue > numberTo);
                        continue;
                    }
                    if (randValue < youValue)
                    {
                        Console.WriteLine(yourName.ToUpper() + ", к сожалению ты не угадал. Думаешь я готов столько ждать? У тебя осталось " + i + " попытки");
                        do
                        {                            
                            Console.Write("Введи число от 0 до " + numberTo + ":");
                            str = Console.ReadLine();
                            if (youValue < 0 || youValue > 10){ Console.Write("Ошибка ввода. Попробуй ещё раз!");}
                        }
                        while (!int.TryParse(str, out youValue) || youValue < 0 || youValue > numberTo);
                        continue;
                    }
                }
                Console.Clear();
                if (randValue == youValue)
                { Console.WriteLine("Браво " + yourName.ToUpper() + " , я тоже загадал " + randValue + ", прими мои поздравления!\nТеперь мы оба знаем, когда все здравомыслящие люди мира вздохнут с облегчением. В эту дату, " + dateTime.ToLongDateString() + " здохнет самый конченый дед в мире,\nи ты можешь себе позволить количество алкоголя немножко больше обычного!"); }
                else { Console.WriteLine("Ты проиграл! Мне так жаль что мы не узнаем когда умрет фюрер. Но я уверен мы оба знаем, что он точно ЗДОХНЕТ!"); }
                Console.Write("\nНажмите любую клавишу, чтобы сыграть ещё раз. Нажмите ESC для выхода.");
                keyPressed = Console.ReadKey();
                Console.Clear();
            }
            while (keyPressed.Key != ConsoleKey.Escape);
        }
    }
}
