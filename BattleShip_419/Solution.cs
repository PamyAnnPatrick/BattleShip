using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_419
{
    public class Solution
    {

        public int CountBattleships(char[][] board)
        {
            int count = 0; int n = board.Length, m = board[0].Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (board[i][j] == 'X')
                    {
                        if((i>0 && board[i-1][j]=='X')||
                            (j>0 && board[i][j - 1] == 'X'))
                        {
                            continue;
                        }
                        count++;                      
                    }
                }
            }
            return count;
        }

        private void dfs(char[][] board, int i, int j, int n, int m)
        {
            board[i][j] = '.';
            if (i + 1 < n && board[i + 1][j] == 'X')
                dfs(board, i + 1, j, n, m);

        }
        private void bfs(char[][] board, int i, int j, int n, int m)
        {
            board[i][j] = '.';
            if (j + 1 < m && board[i][j + 1] == 'X')
                bfs(board, i, j + 1, n, m);

        }
    }
}
