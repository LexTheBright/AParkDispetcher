using APark;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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

        public static string IsValidValue(string field_name, string expr, bool NotNULL = true)
        {
            string pattern = "";
            string vlid_error = "";
            if (NotNULL && expr == "") return "Не заполнено поле " + field_name;
            switch (field_name)
            {
                case "Логин":
                    pattern = @"^[А-Яа-яA-Za-z0-9]{8,15}$";
                    //int fst = 1024, dq = 256;
                    //pattern = @"^\[а-яё]$"; // nicodeRanges.Cyrillic.FirstCodePoint, UnicodeRanges.Cyrillic.Length
                    vlid_error = "Неверный логин! Логин должен состоять только из букв и цифр. А также должен содержать от 8 до 15 символов.";
                    break;
                case "Пароль":
                    pattern = @"^[А-Яа-яA-Za-z0-9]{8,20}$";
                    vlid_error = "Неверный пароль! Пароль должен состоять только из букв и цифр. А также должен содержать от 8 до 20 символов.";
                    break;
                case "ФИО":
                    //pattern = @"\w*\s\w*\s\w*";
                    pattern = @"[А-Яа-яA-Za-z]{3,49}\s[А-Яа-яA-Za-z]{3,49}\s[А-Яа-яA-Za-z]{3,50}";
                    vlid_error = "Ошибка! ФИО должно состоять из букв и содержать от 10 до 150 символов";
                    break;
                case "Табельный №":
                    pattern = @"^\d{6}$";
                    vlid_error = "Ошибка! Табельный номер должен содержать 6 цифр";
                    break;
                case "Описание":
                    pattern = @"^[А-Яа-яA-Za-z0-9.,:%!? ]{0,100}$";
                    vlid_error = "Ошибка! Описание может содержать только буквы, пробелы, цифры, знаки . , : %. Описание не должно превышать 100 знаков.";
                    break;
                case "Номер":
                    pattern = @"^[АВЕКМНОРСТУХ]{1,2}\d{3,4}[АВЕКМНОРСТУХ]{0,2}\d{2,3}RUS$";
                    //pattern = @"^[АВЕКМНОРСТУХ]{1,2}\d{3,4}(?<!000)[АВЕКМНОРСТУХ]{0,2}\d{2,3}RUS$";
                    vlid_error = "Ошибка! Неверный формат номеров!";
                    break;
                case "Модель":
                    pattern = @"^[А-Яа-яA-Za-z0-9() ]{3,40}$";
                    vlid_error = "Ошибка! Неверный формат Модели! Доступны только буквы, пробелы, цифры, знаки ( ). В строке должно быть от 3 до 40 символов";
                    break;
                case "Цвет":
                    pattern = @"^[А-Яа-я-]{3,20}$";
                    vlid_error = "Ошибка! Неверный формат Цвета! Цвет может содержать только буквы и знак -.  В строке должно быть от 3 до 20 символов";
                    break;
                case "Длительность":
                    pattern = @"^\d{2,3}$";
                    vlid_error = "Ошибка! Укажите длительность в минутах!";
                    break;
                case "Откуда":
                    pattern = @"^[А-Яа-яA-Za-z0-9.,: ]{2,60}$";
                    vlid_error = "Ошибка! Поле адреса может содержать только буквы, пробелы, цифры, знаки . , :. Описание не должно превышать 60 знаков.";
                    break;
                case "Куда":
                    pattern = @"^[А-Яа-яA-Za-z0-9.,: ]{2,60}$";
                    vlid_error = "Ошибка! Поле адреса может содержать только буквы, пробелы, цифры, знаки . , :. Описание не должно превышать 60 знаков.";
                    break;
                default:
                    break;
            }

            if (Regex.IsMatch(expr, pattern/*, RegexOptions.IgnoreCase*/)) { return null; }
            else
            {
                return vlid_error;
            }
        }
    }
}
