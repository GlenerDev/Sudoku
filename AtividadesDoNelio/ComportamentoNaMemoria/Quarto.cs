using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AtividadesDoNelio.ComportamentoNaMemoria.Atividade_QuartosOcupados;

namespace AtividadesDoNelio.ComportamentoNaMemoria
{
    public class Quarto
    {
        public int Numero { get; private set; }
        public int SetNumero
        {
            get => Numero;
            set => Numero = value;
        }
        public Estudante _morador { get; private set; }
        public Estudante SetEstudante
        {
            set 
            {
                if (value is not null)
                {
                    _morador = value;
                    return;
                }
                _morador = null!;
            }
        }
        public Quarto(Estudante morador = null!)
        {
            _morador = morador;
        }

        public void DefinirMorador(Estudante morador)
        {
            if (_morador is not null)
            {
                _morador = morador;
            }
        }
        public override string ToString() => $"{Numero} : {_morador.Nome},{_morador.Email}";
    }
}
