//using Autorizador.Domain.ContextTransacao.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace POC.MysqlConnectorPomelo
{
    public class TransacaoMap : IEntityTypeConfiguration<Transacao>
    {
        public void Configure(EntityTypeBuilder<Transacao> builder)
        {
            builder.HasKey(e => e.IdTransacao);

            builder.ToTable("tb_transacao");

            //builder.HasIndex(e => e.IdFatura)
            //    .HasName("fk_transacao__fatura");

            //builder.HasIndex(e => e.IdEstabelecimento)
            //    .HasName("fk_transacao__estabelecimento_idx");

            builder.Property(e => e.IdTransacao)
                .HasColumnName("id_transacao")
                .HasColumnType("binary(16)")
                .ValueGeneratedNever();

            builder.Property(e => e.IdTransacaoEstorno)
                .HasColumnName("id_transacao_estorno")
                .HasColumnType("binary(16)")
                .ValueGeneratedNever();

            builder.Property(e => e.IdFatura)
                .HasColumnName("id_fatura")
                .HasColumnType("binary(16)")
                .ValueGeneratedNever();

            builder.Property(e => e.IdPrimeiraParcela)
                .HasColumnName("id_primeira_parcela")
                .HasColumnType("binary(16)")
                .ValueGeneratedNever();

            builder.Property(e => e.IdEstabelecimento)
                .HasColumnName("id_estabelecimento")
                .HasColumnType("binary(16)")
                .ValueGeneratedNever();

            builder.Property(e => e.CodigoTransacao)
                .HasColumnName("codigo_transacao")
                .HasColumnType("varchar(6)")
                .ValueGeneratedNever();

            builder.Property(e => e.Descricao)
                .HasColumnName("descricao")
                .HasColumnType("varchar(200)")
                .ValueGeneratedNever();

            builder.Property(e => e.TipoTransacao)
                .HasColumnName("tipo_transacao")
                .HasColumnType("int unsigned");

            builder.Property(e => e.DebitoCredito)
                .HasColumnName("debito_credito")
                .HasColumnType("int unsigned");

            builder.Property(e => e.Valor)
                .HasColumnName("valor")
                .HasColumnType("decimal(18,2)");

            builder.Property(e => e.ParcelaAtual)
                .HasColumnName("parcela_atual")
                .HasColumnType("int unsigned");

            builder.Property(e => e.TotalParcelas)
                .HasColumnName("total_parcelas")
                .HasColumnType("int unsigned");

            builder.Property(e => e.IdTerminal)
                .HasColumnName("id_terminal")
                .HasColumnType("varchar(8)")
                .ValueGeneratedNever();

            builder.Property(e => e.Bit11NumeroSequencialTransacaoTef)
                .HasColumnName("bit11_numero_sequencial_transacao_tef")
                .HasColumnType("int unsigned");

            builder.Property(e => e.Bit11TransacaoOriginal)
                .HasColumnName("bit11_transacao_original")
                .HasColumnType("int unsigned");

            builder.Property(e => e.Bit37NSUIntegradora)
                .HasColumnName("bit37_NSUIntegradora")
                .HasColumnType("int unsigned");

            builder.Property(e => e.Bit37TransacaoOriginal)
                .HasColumnName("bit37_transacao_original")
                .HasColumnType("int unsigned");

            builder.Property(e => e.Bit127NSUAutorizador)
                .HasColumnName("bit127_NSUAutorizador")
                .HasColumnType("int unsigned");
            
            builder.Property(e => e.Bit11TransacaoOriginal)
                .HasColumnName("bit11_transacao_original")
                .HasColumnType("int unsigned");
            
            builder.Property(e => e.Bit37TransacaoOriginal)
                .HasColumnName("bit37_transacao_original")
                .HasColumnType("int unsigned");

            builder.Property(e => e.DtEstorno)
                .HasColumnName("dt_estorno")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(e => e.DtConciliacao)
                .HasColumnName("dt_conciliacao")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(e => e.DtTransacao)
                .HasColumnName("dt_inclusao")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

        }
    }
}