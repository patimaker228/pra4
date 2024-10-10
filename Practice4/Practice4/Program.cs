using System;

namespace Practice4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Работа с таблицей Users.");
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1) Посмотреть все записи");
            Console.WriteLine("2) Добавить нового пользователя");
            Console.WriteLine("3) Обновить существующего пользователя");
            Console.WriteLine("4) Удалить существующего пользователя");
            Console.WriteLine("5) Авторизоваться в системе");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    ShowAllUsers();
                    break;
                case "2":
                    Console.Clear();
                    AddNewUser();
                    break;
                case "3":
                    Console.Clear();
                    UpdateUser();
                    break;
                case "4":
                    Console.Clear();
                    DeleteUser();
                    break;
                case "5":
                    Console.Clear();
                    AuthorizeUser();
                    break;
                default:
                    Console.WriteLine("Выбрано неверное действие.");
                    break;
            }
        }

        static void ShowAllUsers()
        {
            // Здесь должен быть код для отображения всех пользователей из таблицы
        }

        static void AddNewUser()
        {
            // Здесь должен быть код для добавления нового пользователя в таблицу
        }

        static void UpdateUser()
        {
            // Здесь должен быть код для обновления существующего пользователя в таблице
        }

        static void DeleteUser()
        {
            // Здесь должен быть код для удаления существующего пользователя из таблицы
        }

        static void AuthorizeUser()
        {
            // Здесь должен быть код для авторизации пользователей в системе
        }
    }
}
