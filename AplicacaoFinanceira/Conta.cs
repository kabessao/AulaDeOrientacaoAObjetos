namespace AplicacaoFinanceira
{
    class Conta
    {
        // No C# existem três tipos de Getter e Setters

        /* Método get convencional que se pode achar em qualquer
         * linguagem de programação orientada a objetos
         */
        private long _id;
        private string _numero;
        private double _saldo;

        public void setId(long id)
        {
            _id = id;
        }
        public void setNumero(string numero)
        {
            _numero = numero;
        }
        public void setSaldo(double saldo)
        {
            _saldo = saldo;
        }
        public long getId()
        {
            return this._id;
        }
        public string getNumero()
        {
            return this._numero;
        }
        public double getSaldo()
        {
            return this._saldo;
        }


        
    }
}
