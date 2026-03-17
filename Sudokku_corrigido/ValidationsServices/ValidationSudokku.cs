using Sudokku.Services;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudokku_corrigido.ValidationsServices
{
    internal class ValidationSudokku
    {
        static List<int[]> listarrayatual = new List<int[]>(9);
        static public TableLayoutPanel Pl { get; private set; }

        public ValidationSudokku(TableLayoutPanel pl)
        {
            Pl = pl;
        }
        public void EntregarCarta()
        {

        }
        public bool VerifySquare()
        {
            for (int colummsqure = 0; colummsqure < 3; colummsqure++)
                for (int square = colummsqure; square < 3; square = square = 3)
                {
                    for (int l = square; l < 3; l++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            for (int c2 = 0; c2 < 9; c2++)
                            {
                                listarrayatual.Add(new int[9]);
                                listarrayatual[c][c2] = int.Parse(((Button)Pl.Controls[c2]).Text);
                            }
                        }
                    }
                }
            var rag = Enumerable.Range(1, 9);
            foreach (var item in listarrayatual)
            {
                foreach (var i in item)
                    if (item.Contains(i)) { continue; }
                return false;
            }
            return true;
        }
        public bool VerifyRow()
        {
            VerifySquare();
            for (int i = 0; i < Pl.Controls.Count; i++)
            {
                for (int c = 0; c < Pl.Controls.Count; c++)
                {
                    var range = Enumerable.Range(1, 9);
                    var cont = 0;
                    foreach (int item in range)
                    {
                        if (listarrayatual[cont].Contains(item))
                        {
                            continue;
                        }
                        return false;
                    }
                }
            }
            return true;
        }
        public bool VerifyCollum()
        {

            VerifySquare();
            for (int c = 0; c < Pl.Controls.Count; c++)
            {
                for (int i = 0; i < Pl.Controls.Count; i++)
                {
                    var range = Enumerable.Range(1, 9);
                    var cont = 0;
                    foreach (int item in range)
                    {
                        if (listarrayatual[cont].Contains(item))
                        {
                            continue;
                        }
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
