namespace ProceduresStudents.EntidadesDeNegocio
{
    public class Requests
    {
        public int RequestsId { get; set; }

        public int StudentId { get; set; }
        public string? Requestdate { get; set; }
        public string? Requeststatus { get; set; }
       public Students? Students { get; set; }

    }
}
