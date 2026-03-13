using Sudokku.Validations;

namespace Sudokku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var teste = new Square();
            var test2 = new PanelMatriz();
            test2.CheckErrorSudokku(panelMatriz);


        }

        private void EventClickNumbers(object sender, EventArgs e)
        {
            Button clickbutton = (Button)sender;
            switch (clickbutton.Name)
            {
                case "button2":
                    this.Show();
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void EventBtnRoudClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btnVerify":
                    TlpMenu.Visible = true;
                    break;
            }
        }

        private void EventButtonClickMenu(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btnFacil":
                    break;
                case "btnMedio":
                    TlpMenu.Visible = false;
                    break;
                case "btnDificil":
                    break;
            }
        }
    }
}
