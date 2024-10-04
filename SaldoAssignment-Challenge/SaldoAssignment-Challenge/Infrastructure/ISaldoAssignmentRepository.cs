using SaldoAssignment.Domain.Entities;

namespace SaldoAssignment_Challenge.Infrastructure
{
    public interface ISaldoAssignmentRepository
    {
        void GuardarAsignacionDeSaldos(List<Gestor> gestores);
        List<Gestor> ObtenerGestores();
        List<int> ObtenerSaldos();
    }
}
