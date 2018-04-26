namespace AplicacaoFinanceira
{
    class Agencia
    {
        /* Método get no qual não é preciso tratar o dado recebido,
         * porem ainda é preciso controlar quem pode ou não modificar ou ver
         * os dados no atrubuto
         */
        public long Id { get;  set; }
        public string Numero { get; set; }
        public string Nome { get; set; }
    }
}
