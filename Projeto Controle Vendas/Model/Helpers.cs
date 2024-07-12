using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.Model
{
    public class Helpers
    {
        public void LimpaTela(Form tela)
        {
            //Aqui ele percorre todos os controles da mimha tela
            foreach (Control ctrPai in tela.Controls)
            {
                //Vai percorres os controles e verificar se existe um controle chamado TagPage
                foreach (Control control in ctrPai.Controls)
                {
                    //Ele é do tipo tagPage
                    if(control is TabPage)
                    {
                        //Percorra todo os controles do tagPage
                        foreach (Control controlB in control.Controls)
                        {
                            //E verifique quais deles são texbox
                            if(controlB is TextBox)
                            {
                                //Limpar o campo de texto
                                (controlB as TextBox).Text = string.Empty;
                            }
                            if (controlB is MaskedTextBox)
                            {
                                (controlB as MaskedTextBox).Text = string.Empty;
                            }
                        }
                    }
                }
            }
        }
    }
}
