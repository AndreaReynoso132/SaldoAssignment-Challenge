using SaldoAssignment.Data;
using SaldoAssignment.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using SaldoAssignment_Challenge.Infrastructure;

namespace SaldoAssignment.Infrastructure
{
    public class SaldoAssignmentRepository : ISaldoAssignmentRepository
    {
        private readonly SaldoContext _context;

        public SaldoAssignmentRepository(SaldoContext context)
        {
            _context = context;
        }

        public List<int> ObtenerSaldos()
        {
            return _context.Saldos.Select(s => s.Valor).ToList();
        }

        public List<Gestor> ObtenerGestores()
        {
            // Obtenemos los gestores almacenados en la base de datos en memoria
            return _context.Gestores.ToList();
        }

        public void GuardarAsignacionDeSaldos(List<Gestor> gestores)
        {
            foreach (var gestor in gestores)
            {
                _context.Gestores.Update(gestor);
            }
            _context.SaveChanges();
        }
    }
}
