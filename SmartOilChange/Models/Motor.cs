namespace SmartOilChange.Models
{
    internal class Motor
    {
        public int MotorId { get; set; }
        public int ModeloMotorId { get; set; }
        public string Nome { get; set; }
        public int AnoInicio { get; set; }
        public int AnoFim { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
