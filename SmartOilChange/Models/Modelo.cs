namespace SmartOilChange.Models
{
    internal class Modelo
    {
        public int Id { get; set; }
        public int MarcaId { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
