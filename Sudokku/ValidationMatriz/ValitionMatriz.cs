using System.CodeDom;
using System.Security.Cryptography;
using System.Windows.forms

namespace Sudokku.Validations
{
    public class ValidationMatriz
    {
        public virtual void VerifySudokku(Panel pnl) 
        {
            return;
        }
    }
    public class PanelMatriz() : ValidationMatriz
    {
        public Button[] arraymatriz = new Button[81];
        public bool CheckErrorSudokku(Panel panel)
        {
            int value = 0;
            foreach (Button item in panel.Controls)
            {
                value += 1;
                item.Text = value.ToString();
            }
            return false;
        }
    }
    public class Square : ValidationMatriz
    {
        public override void VerifySudokku(Panel pnl) 
        {
            pnl.Controls[1].Text = "de";
            return;
        }
    }
    public class Collum : ValidationMatriz
    {
        public override void VerifySudokku(Panel pnl)
        {
            return;
        }
    }
    public class Row : ValidationMatriz
    {
        public override void VerifySudokku(Panel pnl)
        { 
            return;
        }
    }
}
