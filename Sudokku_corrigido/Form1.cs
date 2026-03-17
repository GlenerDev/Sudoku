using Sudokku_corrigido.Services;
using Sudokku_corrigido.ValidationsServices;
using System.Runtime.InteropServices;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Web;
namespace Sudokku_corrigido
{
    public partial class Form1 : Form
    {

        private Button btnglobalSelect { get; set; }
        public Form1()
        {
            InitializeComponent();
            var api = new ApiSudokkuService("vKEHky0R9dq3gyewpyK5J_YS3cbr9A3eLE2Uw0G_NIA", "x-api-key", "application/json");

        }
        private async Task EventClickButtonMenu(object sender, EventArgs e)
        {

        }
        private void EventClickButtonRouds(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btnCancel":
                    DialogResult result = MessageBox.Show("Tem certeza que deseja parar por aqui?", "confirmaçao", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.No) return;
                    break;

            }
            tplRoud.Visible = false;
            TlpMenu.Visible = true;
        }
        private void EventClicksBtnsGrade(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btnglobalSelect is not null)
            {
                btn.Text = btnglobalSelect.Text;
                var initialgame = new ValidationSudokku(tlpMatrix);

                if (
                initialgame.VerifySquare() &&
                initialgame.VerifyCollum() &&
                initialgame.VerifyRow())
                {
                    MessageBox.Show($"teste {1}", initialgame.ToString());
                    MessageBox.Show($"teste {initialgame}");
                    MessageBox.Show($"teste" + initialgame + " ");
                }
            }
        }

        private async void EventBtnmenu(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string obj = string.Empty;
            var Df = ("easy", "medium", "hard");
            switch (btn.Name)
            {
                case "btnFacil":
                    obj = await ApiSudokkuService.GenerateSudokku(Df.Item1, true, false);
                    break;
                case "btnMedio":
                    obj = await ApiSudokkuService.GenerateSudokku(Df.Item2, true, false);
                    break;
                case "btnDificil":
                    obj = await ApiSudokkuService.GenerateSudokku(Df.Item3, true, false);
                    break;
            }
            SudokkuService.AddStringResponsseFromGrade(obj, tlpMatrix);
            TlpMenu.Visible = false;
            tplRoud.Visible = true;
        }

        private void EventBtnClickSelectDigit(object sender, EventArgs e)
        {
            Button btn_atual = sender as Button;
            if (btnglobalSelect is not null)
            {
                btnglobalSelect.BackColor = Color.CadetBlue;
            }
            btn_atual.BackColor = Color.White;
            btnglobalSelect = btn_atual;

        }
    }
}
