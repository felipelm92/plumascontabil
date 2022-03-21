﻿// <auto-generated />
using System;
using Demonstrativo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Demonstrativo.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220315191357_DropContas2")]
    partial class DropContas2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Demonstrativo.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Demonstrativo.Models.Competencia", b =>
                {
                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.HasKey("Data");

                    b.ToTable("Competencias");
                });

            modelBuilder.Entity("Demonstrativo.Models.ContaContabil", b =>
                {
                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<int>("Classificacao")
                        .HasColumnType("int");

                    b.Property<string>("Historico")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Codigo");

                    b.ToTable("ContasContabeis");
                });

            modelBuilder.Entity("Demonstrativo.Models.Descricao", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Observacao")
                        .HasColumnType("varchar(1000)");

                    b.Property<int?>("VendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VendaId");

                    b.ToTable("Descricao");
                });

            modelBuilder.Entity("Demonstrativo.Models.Empresa", b =>
                {
                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<string>("Apelido")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("varchar(18)");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Situacao")
                        .HasColumnType("varchar(2)");

                    b.HasKey("Codigo");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("Demonstrativo.Models.ItemVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(11,2)");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantidade")
                        .HasColumnType("decimal(9,2)");

                    b.Property<int>("VendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("VendaId");

                    b.ToTable("ItensVendas");
                });

            modelBuilder.Entity("Demonstrativo.Models.Lancamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCompetencia")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(100)");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(11,2)");

                    b.HasKey("Id");

                    b.HasIndex("ContaId");

                    b.HasIndex("DataCompetencia");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Lancamentos");
                });

            modelBuilder.Entity("Demonstrativo.Models.LancamentoPadrao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<int?>("Codigo")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(70)");

                    b.Property<int?>("LancamentoHistorico")
                        .HasColumnType("int");

                    b.Property<int?>("TipoContaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("TipoContaId");

                    b.ToTable("LancamentoPadrao");
                });

            modelBuilder.Entity("Demonstrativo.Models.OfxBanco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(70)");

                    b.HasKey("Id");

                    b.ToTable("OfxBancos");
                });

            modelBuilder.Entity("Demonstrativo.Models.OfxComplemento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescricaoComplemento")
                        .HasColumnType("varchar(70)");

                    b.Property<int>("HistoricoId")
                        .HasColumnType("int");

                    b.Property<int>("OfxId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HistoricoId");

                    b.HasIndex("OfxId");

                    b.ToTable("OfxComplementos");
                });

            modelBuilder.Entity("Demonstrativo.Models.OfxContaCorrente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BancoOfxId")
                        .HasColumnType("int");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<string>("NumeroConta")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BancoOfxId");

                    b.HasIndex("EmpresaId");

                    b.ToTable("ConstasCorrentes");
                });

            modelBuilder.Entity("Demonstrativo.Models.OfxDescricao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContaCreditoId")
                        .HasColumnType("int");

                    b.Property<int>("ContaDebitoId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("ContaCreditoId");

                    b.HasIndex("ContaDebitoId");

                    b.ToTable("OfxDescricoes");
                });

            modelBuilder.Entity("Demonstrativo.Models.OfxLancamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Complemento")
                        .HasColumnType("varchar(150)");

                    b.Property<int>("ContaCorrenteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .HasColumnType("varchar(20)");

                    b.Property<int?>("LancamentoPadraoId")
                        .HasColumnType("int");

                    b.Property<string>("TipoLancamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ValorOfx")
                        .HasColumnType("decimal(11,2)");

                    b.HasKey("Id");

                    b.HasIndex("ContaCorrenteId");

                    b.HasIndex("LancamentoPadraoId");

                    b.ToTable("OfxLancamentos");
                });

            modelBuilder.Entity("Demonstrativo.Models.OfxLoteLancamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(70)");

                    b.Property<int>("LancamentoOfxId")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("LancamentoOfxId");

                    b.ToTable("OfxLotes");
                });

            modelBuilder.Entity("Demonstrativo.Models.OfxSaldoConta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContaContabilId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<decimal>("Saldo")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ContaContabilId");

                    b.HasIndex("EmpresaId");

                    b.ToTable("OfxSaldoContas");
                });

            modelBuilder.Entity("Demonstrativo.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Demonstrativo.Models.ProvisoesDepreciacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Apurar")
                        .HasColumnType("bit");

                    b.Property<bool>("CalcularCompensacao")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataCompetencia")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("DecimoTerceiro")
                        .HasColumnType("decimal(11,2)");

                    b.Property<decimal?>("Depreciacao")
                        .HasColumnType("decimal(11,2)");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Ferias")
                        .HasColumnType("decimal(11,2)");

                    b.Property<decimal?>("SaldoPrejuizo")
                        .HasColumnType("decimal(11,2)");

                    b.HasKey("Id");

                    b.HasIndex("DataCompetencia");

                    b.HasIndex("EmpresaId");

                    b.ToTable("ProvisoesDepreciacoes");
                });

            modelBuilder.Entity("Demonstrativo.Models.TipoConta", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("TiposContas");
                });

            modelBuilder.Entity("Demonstrativo.Models.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCompetencia")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<string>("Observacao")
                        .HasColumnType("varchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DataCompetencia");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("Demonstrativo.Models.Descricao", b =>
                {
                    b.HasOne("Demonstrativo.Models.Venda", "Venda")
                        .WithMany()
                        .HasForeignKey("VendaId");

                    b.Navigation("Venda");
                });

            modelBuilder.Entity("Demonstrativo.Models.ItemVenda", b =>
                {
                    b.HasOne("Demonstrativo.Models.Produto", "Produto")
                        .WithMany("ItemVendas")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Demonstrativo.Models.Venda", "Venda")
                        .WithMany("ItemVendas")
                        .HasForeignKey("VendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");

                    b.Navigation("Venda");
                });

            modelBuilder.Entity("Demonstrativo.Models.Lancamento", b =>
                {
                    b.HasOne("Demonstrativo.Models.LancamentoPadrao", "Conta")
                        .WithMany("Lancamentos")
                        .HasForeignKey("ContaId");

                    b.HasOne("Demonstrativo.Models.Competencia", "Competencia")
                        .WithMany("Lancamentos")
                        .HasForeignKey("DataCompetencia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Demonstrativo.Models.Empresa", "Empresa")
                        .WithMany("Lancamentos")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Competencia");

                    b.Navigation("Conta");

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("Demonstrativo.Models.LancamentoPadrao", b =>
                {
                    b.HasOne("Demonstrativo.Models.Categoria", "Categoria")
                        .WithMany("Conta")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Demonstrativo.Models.TipoConta", "Tipo")
                        .WithMany("Contas")
                        .HasForeignKey("TipoContaId");

                    b.Navigation("Categoria");

                    b.Navigation("Tipo");
                });

            modelBuilder.Entity("Demonstrativo.Models.OfxComplemento", b =>
                {
                    b.HasOne("Demonstrativo.Models.OfxDescricao", "HistoricoOfx")
                        .WithMany("ComplementosOfxs")
                        .HasForeignKey("HistoricoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Demonstrativo.Models.OfxLancamento", "LancamentoOfx")
                        .WithMany("ComplementosOfxs")
                        .HasForeignKey("OfxId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HistoricoOfx");

                    b.Navigation("LancamentoOfx");
                });

            modelBuilder.Entity("Demonstrativo.Models.OfxContaCorrente", b =>
                {
                    b.HasOne("Demonstrativo.Models.OfxBanco", "BancoOfx")
                        .WithMany("ContasCorrentes")
                        .HasForeignKey("BancoOfxId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Demonstrativo.Models.Empresa", "Empresa")
                        .WithMany("ContasCorrentes")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BancoOfx");

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("Demonstrativo.Models.OfxDescricao", b =>
                {
                    b.HasOne("Demonstrativo.Models.ContaContabil", "ContaCredito")
                        .WithMany("HistoricosCreditosOfx")
                        .HasForeignKey("ContaCreditoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Demonstrativo.Models.ContaContabil", "ContaDebito")
                        .WithMany("HistoricosDebitosOfx")
                        .HasForeignKey("ContaDebitoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ContaCredito");

                    b.Navigation("ContaDebito");
                });

            modelBuilder.Entity("Demonstrativo.Models.OfxLancamento", b =>
                {
                    b.HasOne("Demonstrativo.Models.OfxContaCorrente", "ContaCorrente")
                        .WithMany()
                        .HasForeignKey("ContaCorrenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Demonstrativo.Models.LancamentoPadrao", null)
                        .WithMany("OfxLancamentos")
                        .HasForeignKey("LancamentoPadraoId");

                    b.Navigation("ContaCorrente");
                });

            modelBuilder.Entity("Demonstrativo.Models.OfxLoteLancamento", b =>
                {
                    b.HasOne("Demonstrativo.Models.OfxLancamento", "LancamentoOfx")
                        .WithMany("LoteLancamentos")
                        .HasForeignKey("LancamentoOfxId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LancamentoOfx");
                });

            modelBuilder.Entity("Demonstrativo.Models.OfxSaldoConta", b =>
                {
                    b.HasOne("Demonstrativo.Models.ContaContabil", "ContaContabil")
                        .WithMany("SaldosContas")
                        .HasForeignKey("ContaContabilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Demonstrativo.Models.Empresa", "Empresa")
                        .WithMany("SaldosContas")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ContaContabil");

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("Demonstrativo.Models.ProvisoesDepreciacao", b =>
                {
                    b.HasOne("Demonstrativo.Models.Competencia", "Competencia")
                        .WithMany("ProvisoesDepreciacoes")
                        .HasForeignKey("DataCompetencia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Demonstrativo.Models.Empresa", "Empresa")
                        .WithMany("ProvisoesDepreciacoes")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Competencia");

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("Demonstrativo.Models.Venda", b =>
                {
                    b.HasOne("Demonstrativo.Models.Competencia", "Competencia")
                        .WithMany("Vendas")
                        .HasForeignKey("DataCompetencia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Demonstrativo.Models.Empresa", "Empresa")
                        .WithMany("Vendas")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Competencia");

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("Demonstrativo.Models.Categoria", b =>
                {
                    b.Navigation("Conta");
                });

            modelBuilder.Entity("Demonstrativo.Models.Competencia", b =>
                {
                    b.Navigation("Lancamentos");

                    b.Navigation("ProvisoesDepreciacoes");

                    b.Navigation("Vendas");
                });

            modelBuilder.Entity("Demonstrativo.Models.ContaContabil", b =>
                {
                    b.Navigation("HistoricosCreditosOfx");

                    b.Navigation("HistoricosDebitosOfx");

                    b.Navigation("SaldosContas");
                });

            modelBuilder.Entity("Demonstrativo.Models.Empresa", b =>
                {
                    b.Navigation("ContasCorrentes");

                    b.Navigation("Lancamentos");

                    b.Navigation("ProvisoesDepreciacoes");

                    b.Navigation("SaldosContas");

                    b.Navigation("Vendas");
                });

            modelBuilder.Entity("Demonstrativo.Models.LancamentoPadrao", b =>
                {
                    b.Navigation("Lancamentos");

                    b.Navigation("OfxLancamentos");
                });

            modelBuilder.Entity("Demonstrativo.Models.OfxBanco", b =>
                {
                    b.Navigation("ContasCorrentes");
                });

            modelBuilder.Entity("Demonstrativo.Models.OfxDescricao", b =>
                {
                    b.Navigation("ComplementosOfxs");
                });

            modelBuilder.Entity("Demonstrativo.Models.OfxLancamento", b =>
                {
                    b.Navigation("ComplementosOfxs");

                    b.Navigation("LoteLancamentos");
                });

            modelBuilder.Entity("Demonstrativo.Models.Produto", b =>
                {
                    b.Navigation("ItemVendas");
                });

            modelBuilder.Entity("Demonstrativo.Models.TipoConta", b =>
                {
                    b.Navigation("Contas");
                });

            modelBuilder.Entity("Demonstrativo.Models.Venda", b =>
                {
                    b.Navigation("ItemVendas");
                });
#pragma warning restore 612, 618
        }
    }
}
