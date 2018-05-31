namespace Fornecedor
{
    class FornecedorNacional : Fornecedor
    {
        public FornecedorNacional(string nome, int idade, string telefone, float valorCredito, float valorDivida)
            : base(nome, idade, telefone, valorCredito, valorDivida)
        {
        }

        public override float ValorCredito
        {
            get{ return base.ValorCredito;} 
            
            set{
                float teste = value;
                base.ValorCredito =  value + (value * 0.20f);}
        }
    }
}