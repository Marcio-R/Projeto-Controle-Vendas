using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.Model
{
    class Helpers
    {
        public void LimparTela(Form tela)
        {
            foreach (Control ctrPai in tela.Controls)
            {
                foreach (Control ctr1 in ctrPai.Controls)
                {
                    if(ctr1 is TabPage)
                    {
                        foreach (Control ctr2 in ctr1.Controls)
                        {
                            //Limpar textbox
                            if(ctr2 is TextBox)
                            {
                                (ctr2 as TextBox).Text = string.Empty;
                            }
                            //Limpar Maskedtextbox
                            if (ctr2 is MaskedTextBox)
                            {
                                (ctr2 as MaskedTextBox).Text = string.Empty;
                            }
                        }
                    }
                }
            }
        }
    }
}
