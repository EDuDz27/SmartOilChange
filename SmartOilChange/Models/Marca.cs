namespace SmartOilChange.Models
{
    internal class Marca
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
