namespace SmartOilChange.Models
{
    internal class Motor
    {
        public int Id { get; set; }
        public string NomeMotor { get; set; }
        public int AnoInicio { get; set; }
        public int AnoFim { get; set; }

        public override string ToString()
        {
            return NomeMotor;
        }
    }
}
