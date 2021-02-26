using Abstrato2.Entities;

namespace Abstrato2.Entities
{
    class PessoaJuridica : Contribuinte
    {
        public int NumFunc { get; set; }

        public PessoaJuridica()
        {

        }

        public PessoaJuridica(string nome, double rendaAnual, int numFunc) : base(nome, rendaAnual)
        {
            NumFunc = numFunc;
        }

        public override double Imposto()
        {
            double imp = 0.16;
            if (NumFunc > 10)
            {
                imp = 0.14;
                return (RendaAnual * imp);

            }

            return (RendaAnual * imp); ;
        }
    
    }
}
