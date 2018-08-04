namespace ExemploSobrecarga
{
    public class Professor
    {
        private double salarioBruto;
        private double salarioLiquido;

        public string Matricula { get; set; }
        public string Nome { get; set; }
        public float SalarioBruto { get; set; }
        public float SalarioLiquido { get;  set; }
        public int QuantidadeDisciplina { get; set; }

        public Professor(
            string matricula,
            string nome,
            float salarioBruto,
            int quantidadeDisciplina)
        {
            Matricula = matricula;
            Nome = nome;
            SalarioBruto = salarioBruto;
            QuantidadeDisciplina = quantidadeDisciplina;
        }


        public virtual float CalcularSalarioLiquido()
        {
            SalarioLiquido = SalarioBruto - (SalarioBruto * 0.2f) + QuantidadeDisciplina * 50;
            return SalarioLiquido;
        }



    }

}
