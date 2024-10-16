﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KokoulinIV.Sprint2.Task2.V19.Lib
{
    public class DataService : ISprint2Task2V19
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ( x >= 3 && x <= 5  && y >= 3 && y <= 7) return true;
            else if (x >= 6 && x <= 10 && y >= 5 && y <= 7) return true;
            else if(x >= 3 && x <= 6 && y >= 11 && y <= 11) return true;
            else if(x >= 6 && x <= 6 && y >= 8 && y <= 10) return true;
            else if(x >= 9 && x <= 10 && y >= 3 && y <= 4) return true;
            else if(x >= 11 && x <= 12 && y >= 3 && y <= 3) return true;
            else if(x >= 11 && x <= 13 && y >= 6 && y <= 8) return true;
            else if(x >= 11 && x <= 12 && y >= 9 && y <= 11) return true;
            else if(x >= 9 && x <= 11 && y >= 11 && y <= 14) return true;
            else if(x >= 7 && x <= 8 && y >= 13 && y <= 13) return true;
            else if(x >= 12 && x <= 13 && y >= 14 && y <= 14) return true;
            else return false;
        }
    }
}
