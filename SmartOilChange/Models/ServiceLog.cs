using System;

namespace SmartOilChange.Models
{
    internal class ServiceLog
    {
        public int LogsId { get; set; }
        public string Placa { get; set; }
        public string OleoUtilizado { get; set; }
        public bool OleoTrocado { get; set; }
        public bool FiltroTrocado { get; set; }
        public bool TampaOk { get; set; }
        public bool LuzOleoOk { get; set; }
        public bool VazamentoOk { get; set; }
        public bool NivelOleoOk { get; set; }
        public bool EtiquetaOk { get; set; }
        public bool SobraOleoOk { get; set; }
        public string Observacoes { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
