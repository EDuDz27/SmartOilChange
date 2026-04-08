namespace SmartOilChange.Models
{
    internal class Marca
    {
        public int MarcaId { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
