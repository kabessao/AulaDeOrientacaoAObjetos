namespace AplicacaoFinanceira
{
    class Banco
    {
        /* Metodo get usado para tratamento de dados,
         * como ver se o atributo esta vazio ou com valor incorreto
         */
        public Banco()
        {

        }
        public Banco(long id, string numero, string cnpj, string nome)
        {
            _id = id;
            _numero = numero;
            _cnpj = cnpj;
            _nome = nome;
        }
        private long _id;
        public long Id { get { return _id; } set { _id = value; } }

        private string _numero;
        public string Numero { get { return _numero; }  set {_numero = value;}}

        private string _cnpj;
        public string Cnpj { get { return _cnpj; } set {_cnpj = value;} }

        private string _nome;
        public string Nome { get { return _nome; }  set {_nome = value;}}
        
        
    }
}
