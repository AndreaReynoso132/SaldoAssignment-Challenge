namespace SaldoAssignment.Domain.Entities 
{
    public class Gestor
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public List<Saldo> SaldosAsignados { get; set; } = new List<Saldo>();
    }
}
