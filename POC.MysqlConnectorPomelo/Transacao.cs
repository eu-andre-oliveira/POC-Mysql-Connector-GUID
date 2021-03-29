using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace POC.MysqlConnectorPomelo
{
    public partial class Transacao
    {
        public byte[] IdTransacao { get; set; }
        public byte[] IdFatura { get; set; }
        public byte[] IdPrimeiraParcela { get; set; }
        public byte[] IdEstabelecimento { get; set; }
        public byte[] IdTransacaoEstorno { get; set; }
        [NotMapped]
        public string Estabelecimento { get; set; }
        public string CodigoTransacao { get; set; }
        public string Descricao { get; set; }
        public int TipoTransacao { get; set; }
        public int DebitoCredito { get; set; }
        public decimal Valor { get; set; }
        public int? ParcelaAtual { get; set; }
        public int? TotalParcelas { get; set; }
        public string IdTerminal { get; set; }
        public int? Bit11NumeroSequencialTransacaoTef { get; set; }
        public int? Bit37NSUIntegradora { get; set; }
        public int? Bit127NSUAutorizador { get; set; }
        public int Bit11TransacaoOriginal { get; set; } //preenchida no cancelamento
        public int Bit37TransacaoOriginal { get; set; } //preenchida no cancelamento
        public DateTime? DtEstorno { get; set; }
        public DateTime? DtConciliacao { get; set; }
        public DateTime DtTransacao { get; set; } 
    }
}
