namespace ProceduresStudents.EntidadesDeNegocio
{
    public class HistoryPayments
    {
        public int paymentId { get; set; }
        public int StudentId { get; set; }
        public string? paymentdeadline { get; set; }
        public string? paymentamount { get; set; }
        public Students? Students { get; set; }
    }
}
