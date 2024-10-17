using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KokoulinIV.Sprint2.Task7.V4.Lib
{
    public class DataService : ISprint2Task7V4

    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool z;
            if ((x*x+y*y-1<=0)&&(y>=0))
            {
                if ((x * x + y * y - 0.09 <= 0) && (x >= 0) && (x <= 0.3))
                {
                    return false;
                }
                else return true;
            }
            else return false;
        }
    }
}
