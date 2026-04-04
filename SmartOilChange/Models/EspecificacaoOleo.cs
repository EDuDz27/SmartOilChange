namespace SmartOilChange.Models
{
    internal class EspecificacaoOleo
    {
        public int Id { get; set; }
        public int MotorId { get; set; }
        public string Viscosidade { get; set; }
        public string Especificacao { get; set; }
        public decimal CapacidadeLitros { get; set; }
    }
}
