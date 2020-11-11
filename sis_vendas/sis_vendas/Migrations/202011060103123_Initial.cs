namespace sis_vendas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        categoriaId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.categoriaId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Email = c.String(),
                        Tel = c.String(),
                        Endereço = c.String(),
                        vendasDetalheId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Valor = c.Double(nullable: false),
                        categoriaId = c.Int(nullable: false),
                        dataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categorias", t => t.categoriaId, cascadeDelete: true)
                .Index(t => t.categoriaId);
            
            CreateTable(
                "dbo.Vendas",
                c => new
                    {
                        vendaId = c.Int(nullable: false, identity: true),
                        clienteId = c.Int(nullable: false),
                        Data = c.DateTime(nullable: false),
                        valorTotal = c.Double(nullable: false),
                        Produto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.vendaId)
                .ForeignKey("dbo.Produtoes", t => t.Produto_Id)
                .Index(t => t.Produto_Id);
            
            CreateTable(
                "dbo.VendaDetalhes",
                c => new
                    {
                        vendaDetalheId = c.Int(nullable: false, identity: true),
                        produtoId = c.Int(nullable: false),
                        Valor = c.Double(nullable: false),
                        venda_vendaId = c.Int(),
                    })
                .PrimaryKey(t => t.vendaDetalheId)
                .ForeignKey("dbo.Vendas", t => t.venda_vendaId)
                .Index(t => t.venda_vendaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vendas", "Produto_Id", "dbo.Produtoes");
            DropForeignKey("dbo.VendaDetalhes", "venda_vendaId", "dbo.Vendas");
            DropForeignKey("dbo.Produtoes", "categoriaId", "dbo.Categorias");
            DropIndex("dbo.VendaDetalhes", new[] { "venda_vendaId" });
            DropIndex("dbo.Vendas", new[] { "Produto_Id" });
            DropIndex("dbo.Produtoes", new[] { "categoriaId" });
            DropTable("dbo.VendaDetalhes");
            DropTable("dbo.Vendas");
            DropTable("dbo.Produtoes");
            DropTable("dbo.Clientes");
            DropTable("dbo.Categorias");
        }
    }
}
