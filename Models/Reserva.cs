
namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {        
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }        

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count())
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A quantidade de hóspedes pretendida é maior que a capacidade da suíte");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidade;
            if (Hospedes.Equals(null))
            {
                quantidade = 0;
            }
            else
            {
                quantidade = Hospedes.Count();
            }
            return quantidade;
        }

        public decimal CalcularValorHospedagem()
        {
            return DiasReservados >= 10 ? (Suite.ValorDiaria * DiasReservados) - Suite.ValorDiaria * DiasReservados / 10 : Suite.ValorDiaria * DiasReservados;
        }
    }
}