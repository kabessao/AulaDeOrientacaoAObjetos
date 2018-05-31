namespace Fornecedor
{
    class Fornecedor : Contato
    {
        private float valorCredito, valorDivida;

        public virtual  float ValorCredito 
        {
            get { return valorCredito;}
            set { valorCredito = value; }
        }

        public virtual float ValorDivida
        {
            get { return valorDivida; }
            set { valorDivida = value; }
        }
        public Fornecedor(string nome, int idade, string telefone, float valorCredito, float valorDivida) : 
            base(nome,idade,telefone)
        {
            valorCredito = valorCredito;
            valorDivida = valorDivida;
        }

        public float Saldo() => ValorCredito - ValorDivida;
    }
}