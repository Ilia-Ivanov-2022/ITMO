using System;


namespace ITMO.Group124_16.NewRegCSApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Массив названия полей для заполнения
            string[] dataToFill = { "Имя:", "Фамилия:", "Почту:", "Номер телефона:", "Пароль:" };


            // Опция выбора регистрации
            Console.WriteLine("Регистрация нового пользователя.\nВведите \"Да\", если готовы пройти регистрацию");
            string choise = Console.ReadLine();
            Console.WriteLine(choise);

            // Если выбрана регистрация, переходим в окно заполнения данных
            if (choise == "Да" || choise == "да" || choise == "ДА" || choise == "дА")
            {
                // Цикл "do - while" для проверки введенных данных
                do
                {
                    // Объявляем временный массив для хранения данных нового пользователя.
                    // Когда данные будут подтверждены, перенесем данные в постоянный массив.

                    string[] newUserData;
                    newUserData = new string[5];

                    Console.WriteLine("Пожалуйста, введите ваши данные:");

                    // Ввод данных пользователем. Данные записываем в массив newUserData
                    for (int i = 0; i < dataToFill.Length; i++)
                    {
                        Console.WriteLine("Пожалуйста, введите " + dataToFill[i]);
                        newUserData[i] = Console.ReadLine();
                    }

                    // Предлагаем пользователю проверить и подтвердить правильность введенных данных
                    Console.WriteLine("Вы ввели следующие данные:");

                    // Выводим введенные данные на экран
                    for (int i = 0; i < dataToFill.Length; i++)
                    {
                        Console.WriteLine(dataToFill[i] + "\t" + newUserData[i]);
                    }

                    Console.WriteLine("Введите \"Да\", если данные введены верно.");

                // Проверка ответа пользователя
                } while (Console.ReadLine() != "Да");

            }
            else // Если пользователь выбрал не проходить регистрацию, прощаемся.
            {
                Console.WriteLine("Жаль. Всего доброго! :)");
            }

        }
    }
}
