﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KokoulinIV.Sprint2.Task0.V12.Lib
{
    public class DataService : ISprint2Task0V12

    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x >= y  ;
            res[1] = x == y;
            res[2] = x > y;
            res[3] = x < y;
            res[4] = x != y;
            res[5] = x +10 == y;

            return res;








           // (True, False, True, False, True, False), при x = 1095, y = 475
        }
    }
}
