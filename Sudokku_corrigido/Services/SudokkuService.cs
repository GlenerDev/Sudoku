using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Sudokku_corrigido.Services
{
    internal class SudokkuService
    {
        public static void AddStringResponsseFromGrade(string sudo,TableLayoutPanel table) 
        {
            string[] arraynumbssudoku = sudo.Split(':');
            string nunberssudoku = arraynumbssudoku[2];
            string sudokuclean = Regex.Replace(nunberssudoku, @"[^\d]", "");
            var cont = 0;
            var resulvalidate = ' ';
            foreach (char number in sudokuclean) 
            {
                if (number == '0') 
                {
                    table.Controls[cont].Text = resulvalidate.ToString();
                    cont++;
                    continue;
                }
                table.Controls[cont].Text = number.ToString();
                cont++;
            }
        }
    }
}
