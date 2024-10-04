using SaldoAssignment.Domain.Entities;

namespace SaldoAssignment.ApplicationServices
{
    public interface ISaldoAssignmentService
    {
        void AsignarSaldos(List<int> saldos, List<Gestor> gestores);
    }
}
