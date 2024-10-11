using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KokoulinIV.Sprint2.Task3.V7.Lib
{
    public class DataService : ISprint2Task3V7
    {
        public double Calculate(double x)
        {
            if (x > 1)
            {
                return Math.Round((x * Math.Pow((x * x + 1) / (x - 1), x)), 3);
            }
            else if (x == 0)
            {
                return Math.Round((x*x-Math.Cos(x*x)+10)/(x*x-Math.Sin(x*x)+12),3);
            }
            else if (x>-11 && x<2)
            {
                return Math.Round(Math.Pow(7 + 1 / (x * x), 2),3);
            }
            else if (x<-11)
            {
                return Math.Round(Math.Pow(x, 4) - (3 / x), 3);
            }
            else return (-11111);




        }
    }
}
