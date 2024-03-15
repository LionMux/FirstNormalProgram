public class Program
{
    Menu menu = new Menu();
    public void Switch()
    {
        bool exit = false;
        int status;
        menu.ShowMenu();
        do
        {

            string statusInput = Console.ReadLine();
            if (int.TryParse(statusInput, out status))
            {
                switch (status)
                {
                    case 1:
                        menu.InputName();
                        menu.ShowMenu();
                        break;
                    case 2:
                        menu.ListContact();
                        menu.ShowMenu();
                        break;
                    case 3:
                        menu.Search();
                        menu.ShowMenu();
                        break;
                    case 4:
                        menu.Edit();
                        menu.ShowMenu();
                        break;
                    case 5:
                        menu.DeleteContact();
                        menu.ShowMenu();
                        break;
                    case 6:
                        exit = true;
                        break;
                    default:
                        Console.Write("Номера под таким пунктом не существует, введите номер заново: ");
                        break;
                }
            }
            else
            {
                Console.Write("Номера под таким пунктом не существует, введите номер заново: ");
            }
        }
        while (!exit);
    }
}