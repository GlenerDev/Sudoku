using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudokku_corrigido.ValidationsServices
{
    internal class ValidationSudokku
    {
        int[,] arraycontrols = new int[9, 9];
        public TableLayoutPanel Pl { get; private set; }
        public ValidationSudokku(TableLayoutPanel pl)
        {
            Pl = pl;
        }

        public void VerifySudoku() 
        {
            List<int[,]> listarrayatual = new List<int[,]>();
            for (int square = 0; square < 3; square = square = 3) 
            {
                for (int l = 0; l < 3; l++) 
                {
                    for (int c = 0; c < 3; c++) 
                    {
                        
                    }
                }
            }
        }
    }
}
