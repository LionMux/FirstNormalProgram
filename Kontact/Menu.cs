using System;
public class Menu
{
    string[] name = new string[10];
    string[] fullname = new string[10];
    long[] number = new long[10];
    string[] mail = new string[10];
    int Ncontact = 0;
    public void ShowMenu()
    {
        Console.WriteLine("\r\n1. Добавить новый контакт\r\n2. Просмотреть список контактов\r\n3. Найти контакт по имени или фамилии\r\n4. Редактировать контакт\r\n5. Удалить контакт\r\n6. Выйти из программы");
        Console.Write("\r\nВыберите действие: ");
    }
    public void InputName()
    {
        if (Ncontact < name.Length)
        {
            Console.Write("\r\nВведите имя: ");
            name[Ncontact] = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            fullname[Ncontact] = Console.ReadLine();
            Console.Write("Введите номер телефона: +");
            long numberOutput;
            bool answerNumb = false;
            do
            {
                string numberInput = Console.ReadLine();
                if (long.TryParse(numberInput, out numberOutput))
                {
                    number[Ncontact] = numberOutput;
                    answerNumb = true;
                }
                else
                {
                    Console.Write("Вы ввели некорректное значение номера, ввидите коорректный номер телефона: +");
                }
            }
            while (!answerNumb);
            Console.Write("Введите почту: ");
            string mailInput;
            bool answerMail = false;
            do
            {
                mailInput = Console.ReadLine();
                if (mailInput.Contains("@") && mailInput.Contains("."))
                {
                    mail[Ncontact] = mailInput;
                    Ncontact++;
                    Console.Clear();
                    answerMail = true;
                }
                else
                {
                    Console.WriteLine("Некорректно введенная почта, ввидите корректную почту: ");
                }

            }
            while (!answerMail);
        }
        else
        {
            Console.WriteLine("Место для нового пользователя кончилось, удалите ненужный контакт");
        }
    }
    public void ListContact()
    {
        Console.Clear();
        for (int i = 0; i < Ncontact; i++)
        {
            Console.WriteLine($"{i + 1}. Имя: {name[i]}, Фамилия: {fullname[i]}, Номер телефона: +{number[i]}, Почта: {mail[i]}");
        }
    }
    public void Search()
    {
        Console.Clear();
        Console.Write("Введите имя или фамилию для поиска: ");
        string searchName = Console.ReadLine();
        bool contactFound = false;
        for (int i = 0; i < Ncontact; i++)
        {
            if (name[i].Contains(searchName) || fullname[i].Contains(searchName))
            {
                Console.WriteLine($"Найден контакт: {i + 1}. Имя: {name[i]}, Фамилия: {fullname[i]}, Номер телефона: {number[i]}, Почта: {mail[i]}");
                contactFound = true;
            }
        }
        if (!contactFound)
        {
            Console.WriteLine($"Контакт по запросу: {searchName}, не найден");
        }
    }
    public void Edit()
    {
        Console.Clear();
        Console.Write("Введите порядковый номер контакта для его редактирования:");
        int NumberLine = int.Parse(Console.ReadLine());
        if (NumberLine - 1 < Ncontact)
        {
            Console.Write("\r\nВведите имя: ");
            name[NumberLine - 1] = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            fullname[NumberLine - 1] = Console.ReadLine();
            Console.Write("Введите номер: +");
            number[NumberLine - 1] = long.Parse(Console.ReadLine());
            Console.Write("Введите почту: ");
            mail[NumberLine - 1] = Console.ReadLine();
            Console.Write("\r\nВыбранный контакт перезаписан\r\n");
        }
        else
        {
            Console.WriteLine("Контакт под введенным порядковым номером не найден");
        }
    }
    public void DeleteContact()
    {
        Console.Clear();
        Console.Write("Введите порядковый номер контакта, который хотите удалить: ");
        int contactDelete = int.Parse(Console.ReadLine());
        if (contactDelete >= 1 && contactDelete <= Ncontact)
        {
            for (int i = contactDelete - 1; i < Ncontact - 1; i++)
            {
                name[i] = name[i + 1];
                fullname[i] = fullname[i + 1];
                number[i] = number[i + 1];
                mail[i] = mail[i + 1];
            }
            Ncontact--;
        }
        else
        {
            Console.WriteLine($"Контакта с введенным порядковым номером:{contactDelete}, не существует");
        }
    }
}