using System;

namespace CriptografiaMD5
{
    public partial class cadastro : System.Web.UI.Page
    {
        //http://msdn.microsoft.com/en-us/library/system.configuration.rsaprotectedconfigurationprovider(v=vs.110).aspx


        protected void Page_Load(object sender, EventArgs e)
        {
         

        }


        protected void btnCriptografar_Click(object sender, EventArgs e)
        {
            string strToCript = txtParaEncriptar.Text;
            strToCript = MD5Crypt.Criptografar(strToCript);
            txtResultadoEncriptar.Text = strToCript;



        }


        protected void btnDescriptar_Click(object sender, EventArgs e)
        {
            string strToDecript = txtParaDesEncriptar.Text;
            strToDecript = MD5Crypt.Descriptografar(strToDecript);
            txtResultadoDesEncriptar.Text = strToDecript;
        }

        protected void btnCripto_Click(object sender, EventArgs e)
        {
            cifrawebconfig.ProtegerConfiguration();
        }

        protected void btnDescripto_Click(object sender, EventArgs e)
        {
            cifrawebconfig.DesprotegerConfiguration();
        }



    }


}