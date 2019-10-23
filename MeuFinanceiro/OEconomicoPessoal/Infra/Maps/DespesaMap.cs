﻿using OEconomicoPessoal.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OEconomicoPessoal.Infra.Maps
{
    public class DespesaMap : EntityTypeConfiguration<Despesa>
    {
        public DespesaMap()
        {
            ToTable("Despesas");

            HasKey(c => c.Id);

            Property(col => col.Id)
                .HasColumnName("Id")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(col => col.DataCadastro)
                .HasColumnName("DataCadastro")
                .HasColumnType("datetime")
                .IsRequired();

            Property(col => col.Descricao)
                .HasColumnName("Descricao")
                .HasColumnType("nvarchar")
                .HasMaxLength(200)
                .IsRequired();

            Property(col => col.IsAtivo)
                .HasColumnName("IsAtivo")
                .HasColumnType("bit")
                .IsRequired();

            Property(col => col.IsParcelado)
               .HasColumnName("IsParcelado")
               .HasColumnType("bit")
               .IsRequired();

            Property(col => col.QtdeParcela)
             .HasColumnName("QtdeParcela")
             .HasColumnType("int");

            Property(col => col.ValorParcela)
             .HasColumnName("ValorParcela")
             .HasColumnType("decimal");

            Property(col => col.Arquivo)
               .HasColumnName("AnexoNotaFiscal")
               .HasColumnType("image")
               .IsRequired();

            Property(col => col.Valor)
               .HasColumnName("Valor")
               .HasColumnType("decimal")
               .HasPrecision(18, 2)
               .IsRequired();

            Property(col => col.AccountId)
                .HasColumnName("AccountId")
                .HasColumnType("int")
                .IsRequired();

            Property(col => col.TipoPagamentoId)
              .HasColumnName("TipoPagamentoId")
              .HasColumnType("int")
              .IsRequired();

            Property(col => col.TipoDespesaId)
              .HasColumnName("TipoDespesaId")
              .HasColumnType("int")
              .IsRequired();

            Property(col => col.ContaId)
              .HasColumnName("ContaId")
              .HasColumnType("int")
              .IsRequired();
        }
    }
}