using SaldoAssignment.Domain.Entities;

namespace SaldoAssignment.ApplicationServices.Models
{
    public class AsignacionSaldosRequest
    {
        public List<int>? Saldos { get; set; }
        public List<Gestor>? Gestores { get; set; }
    }
}
