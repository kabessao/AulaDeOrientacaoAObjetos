namespace ExemploSobrecarga
{
    class ProfessorPosGraduacao : ProfessorGraduacao
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

        public override float CalcularSalario()
        {
            base.SalarioLiquido = base.CalcularSalario() + this.QtdArtigos * 150;
            return base.SalarioLiquido;
        }
    }
}
