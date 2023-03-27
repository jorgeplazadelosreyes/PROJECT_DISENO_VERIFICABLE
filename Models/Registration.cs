namespace PROJECT1.Models
{
    public class Registration
    {
        public int Id { get; set; }
        public string Cne { get; set; }
        public string Commune { get; set; }
        public string Block { get; set; }
        public string Property { get; set; }
        public int Sheets { get; set; }
        public DateTime InscriptionDate { get; set; }
        public int InscriptionNumber { get; set; }
    }
}
