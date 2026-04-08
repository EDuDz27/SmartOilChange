namespace SmartOilChange.Models
{
    internal class EspecificacaoOleo
    {
        public int OleoId { get; set; }
        public int MotorId { get; set; }
        public string Viscosidade { get; set; }
        public string NormaApi { get; set; }
        public string NormaAcea { get; set; }
        public decimal CapacidadeLitros { get; set; }
        public string Observacoes { get; set; }
    }
}
