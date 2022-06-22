using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WinningNumber.Services
{
    public class LotteryService : ILotteryServices
    {
        private static readonly Random rnd = new();
        public string GetWinningNumber()
        {
            string number = " ";
            for (int i = 0; i < 7; i++)
            {
                number += rnd.Next(0, 10).ToString();
            }
            return number;
        }
    }
}
