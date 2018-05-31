namespace Fornecedor
{
    class FornecedorInternacional : Fornecedor
    {
        public override float ValorDivida
        {
            get { return base.ValorDivida;}
            set
            {
                if (!(value > ValorCredito))
                {
                    base.ValorDivida = value;
                }
            }
        }

        public FornecedorInternacional(string nome, int idade, string telefone, float valorCredito ) : base(nome, idade, telefone, valorCredito , 0)
        {
        }
    }
}