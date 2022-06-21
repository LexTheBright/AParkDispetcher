using APark;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AParkDispetcher
{
    static class ParkDispecter
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DispetcherFrom());
        }

        public static string IsValidValue(string fieldName, string expression, bool notNULLFlag = true)
        {
            string pattern = "";
            string vlidError = "";
            if (notNULLFlag && expression == "") return "Не заполнено поле " + fieldName;
            switch (fieldName)
            {
                case "Логин":
                    pattern = @"^[А-Яа-яA-Za-z0-9]{5,16}$";
                    vlidError = "Неверный логин! Логин должен состоять только из букв и цифр. А также должен содержать от 8 до 15 символов.";
                    break;
                case "Пароль":
                    pattern = @"^[А-Яа-яA-Za-z0-9]{8,32}$";
                    vlidError = "Неверный пароль! Пароль должен состоять только из букв и цифр. А также должен содержать от 8 до 20 символов.";
                    break;
                case "ФИО":
                    pattern = @"[А-Яа-яA-Za-z]{3,49}\s[А-Яа-яA-Za-z]{3,49}\s[А-Яа-яA-Za-z]{3,50}";
                    vlidError = "Ошибка! ФИО должно состоять из букв и содержать от 10 до 150 символов";
                    break;
                case "Табельный №":
                    pattern = @"^\d{6}$";
                    vlidError = "Ошибка! Табельный номер должен содержать 6 цифр";
                    break;
                case "Описание":
                    pattern = @"^[А-Яа-яA-Za-z0-9.,:%!? ]{0,100}$";
                    vlidError = "Ошибка! Описание может содержать только буквы, пробелы, цифры, знаки . , : %. Описание не должно превышать 100 знаков.";
                    break;
                case "Номер":
                    pattern = @"^[АВЕКМНОРСТУХ]{1,2}\d{3,4}[АВЕКМНОРСТУХ]{0,2}\d{2,3}RUS$";
                    vlidError = "Ошибка! Неверный формат номеров!";
                    break;
                case "Модель":
                    pattern = @"^[А-Яа-яA-Za-z0-9() ]{3,40}$";
                    vlidError = "Ошибка! Неверный формат Модели! Доступны только буквы, пробелы, цифры, знаки ( ). В строке должно быть от 3 до 40 символов";
                    break;
                case "Цвет":
                    pattern = @"^[А-Яа-я-]{3,20}$";
                    vlidError = "Ошибка! Неверный формат Цвета! Цвет может содержать только буквы и знак -.  В строке должно быть от 3 до 20 символов";
                    break;
                case "Длительность":
                    pattern = @"^\d{1,2}$";
                    vlidError = "Ошибка! Укажите длительность в часах!";
                    break;
                case "Откуда":
                    pattern = @"^[А-Яа-яA-Za-z0-9.,: ]{2,60}$";
                    vlidError = "Ошибка! Поле адреса может содержать только буквы, пробелы, цифры, знаки . , :. Описание не должно превышать 60 знаков.";
                    break;
                case "Куда":
                    pattern = @"^[А-Яа-яA-Za-z0-9.,: ]{2,60}$";
                    vlidError = "Ошибка! Поле адреса может содержать только буквы, пробелы, цифры, знаки . , :. Описание не должно превышать 60 знаков.";
                    break;
                default:
                    break;
            }

            if (Regex.IsMatch(expression, pattern/*, RegexOptions.IgnoreCase*/)) { return null; }
            else
            {
                return vlidError;
            }
        }
    }
}
