using System.Collections.Generic;

namespace SmartOilChange.Models
{
    internal class ResultadoConsulta
    {
        public EspecificacaoOleo Oleo { get; set; }
        public List<Filtro> Filtros { get; set; } = new List<Filtro>();
    }
}
