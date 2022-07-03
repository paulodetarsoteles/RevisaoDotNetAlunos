using RevisaoBasica.Enums; 
using RevisaoBasica.Interfaces; 

namespace RevisaoBasica
{
    public class Aluno : IPessoa
    {
        public string Nome { get; set; }
        public decimal Nota { get; set; }
        public Conceito Conceito { get; set; }

        public void ConceitoAluno()
        {
            if(Nota >= 8) this.Conceito = Conceito.A; 
            else if(Nota >= 6 && Nota < 8) this.Conceito = Conceito.B; 
            else if(Nota >= 4 && Nota < 6) this.Conceito = Conceito.C; 
            else if(Nota >= 2 && Nota < 4) this.Conceito = Conceito.D; 
            else if(Nota >= 1 && Nota < 2) this.Conceito = Conceito.E; 
            else this.Conceito = Conceito.F; 
        }

        public override string ToString()
        {
            return $"Nome: {Nome} - Nota: {Nota} - Conceito: {Conceito}";
        }
    }
}