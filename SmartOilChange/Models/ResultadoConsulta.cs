using System.Collections.Generic;

namespace SmartOilChange.Models
{
    internal class ResultadoConsulta
    {
        public EspecificacaoOleo Oleo { get; set; }
        public FiltroOriginal FiltroOriginal { get; set; }
        public List<FiltroEquivalente> FiltrosEquivalentes { get; set; } = new List<FiltroEquivalente>();
    }
}
