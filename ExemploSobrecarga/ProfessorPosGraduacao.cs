namespace ExemploSobrecarga
{
    class ProfessorPosGraduacao : Professor
    {
        public byte QtdAnosDoutorado { get; set; }
        public short QtdArtigos { get; set; }

        public ProfessorPosGraduacao(
            string matricula,
            string nome,
            float salarioBruto,
            byte quantidadeDisciplina,
            byte qtdAnosDoutorado,
            short qtdArtigos) 
            : base(
                  matricula,
                  nome,
                  salarioBruto,
                  quantidadeDisciplina)
        {
            QtdAnosDoutorado = qtdAnosDoutorado;
            QtdArtigos = qtdArtigos;
        }

        public override float CalcularSalarioLiquido()
        {
            base.SalarioLiquido = base.CalcularSalarioLiquido() + this.QtdArtigos * 150;
            return base.SalarioLiquido;
        }
    }
}
