using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KokoulinIV.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            string res;
            switch (m)
            {
                case 1:
             
                    res = "Января";
                    break;
                case 2:
                    res = "Февраля";
                    break;
                case 3:
                    res = "Марта";
                    break;
                case 4:
                    res = "Апреля";
                    break;
                case 5:
                    res = "Мая";
                    break;
                case 6:
                    res = "Июня";
                    break;
                case 7:
                    res = "Июля";
                    break;
                case 8:
                    res = "Августа";
                    break;
                case 9:
                    res = "Сентября";
                    break;
                case 10:
                    res = "Октября";
                    break;
                case 11:
                    res = "Ноября";
                    break;
                case 12:
                    res = "Декабря";
                    break;
                default:
                    throw new Exception($"Значение месяца должно быть от 1 до 12. Значение{m}.");
                  

            }

            return ($"{n} {res}");
        }
    }
}
