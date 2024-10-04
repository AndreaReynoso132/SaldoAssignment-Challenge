using SaldoAssignment.Domain.Entities;

namespace SaldoAssignment.ApplicationServices
{
    public class SaldoAssignmentService : ISaldoAssignmentService
    {
        public void AsignarSaldos(List<int> saldos, List<Gestor> gestores)
        {
            if (gestores == null || gestores.Count == 0)
            {
                throw new ArgumentException("La lista de gestores no puede estar vacía");
            }

            int gestorIndex = 0; 
            int saldoId = 1;     

            foreach (var valorSaldo in saldos)
            {
                var saldo = new Saldo
                {
                    Id = saldoId++,  
                    Valor = valorSaldo
                };

                gestores[gestorIndex].SaldosAsignados.Add(saldo);

                gestorIndex = (gestorIndex + 1) % gestores.Count;
            }
        }


    }
}
