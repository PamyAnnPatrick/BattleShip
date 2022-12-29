using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_419
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            char[][] board =  new char[][] { 
                new char[] { 'X', '.', '.', 'X' },
                new char[] { '.', '.', '.', 'X' },
                new char[] { 'X', '.', '.', 'X' }
            };
            int count=s.CountBattleships(board);
        }
    }
}
