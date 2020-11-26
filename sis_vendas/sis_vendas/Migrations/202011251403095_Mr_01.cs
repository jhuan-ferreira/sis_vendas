namespace sis_vendas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mr_01 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.VendaDetalhes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.VendaDetalhes",
                c => new
                    {
                        VendasDetalhesId = c.Int(nullable: false, identity: true),
                        VendaId = c.Int(nullable: false),
                        ValorUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantidade = c.Int(nullable: false),
                        ProdutoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VendasDetalhesId);
            
        }
    }
}
