namespace POO_Heranca.Classes
{
    public class PessoaJuridica : Pessoa //Utilizar herança
    {
        public string cnpj;
        public string inscricaoEstadual;

        public bool ValidarCNPJ(string documento){

            if(documento != ""){
                return true;
            }
            return false;
        }
    }
}