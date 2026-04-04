namespace SmartOilChange.Models
{
    internal enum TipoFiltro
    {
        Blindado,
        Refil
    }

    internal class FiltroOriginal
    {
        public int Id { get; set; }
        public TipoFiltro Tipo { get; set; }
        public string Marca { get; set; }
        public string NumeroPeca { get; set; }
    }
}
