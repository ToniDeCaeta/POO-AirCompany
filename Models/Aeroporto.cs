namespace MapaCompanhiaAerea.Aeroporto
{
    public class Aeroporto
    {
        private string Nome;
        private string Cidade;
        private string CodigoIATA;

        public Aeroporto(string nome, string cidade, string codigoIATA)
        {
            Nome = nome;
            Cidade = cidade;
            CodigoIATA = codigoIATA;
        }

        public string GetNome()
        {
            return Nome;
        }

        public string GetCidade()
        {
            return Cidade;
        }

        public string GetCodigoIATA()
        {
            return CodigoIATA;
        }
    }
}
