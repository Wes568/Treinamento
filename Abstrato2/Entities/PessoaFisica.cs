using Abstrato2.Entities;

namespace Abstrato2.Entities
{
    class PessoaFisica : Contribuinte
    {
        public double GastoSaude { get; set; }

        public PessoaFisica() 
        {

        }

        public PessoaFisica(string nome, double rendaAnual, double gastoSaude):base(nome,rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double Imposto()
        {
            double imp;
            if(RendaAnual<20000)
            {
                imp = 0.15;
                return (RendaAnual * imp) - (GastoSaude * 0.5);

            }
            else if(RendaAnual>20000)
            {
                imp = 0.25;
                return (RendaAnual * imp) - (GastoSaude * 0.5);
            }

            return 0;
        }
    }
}
