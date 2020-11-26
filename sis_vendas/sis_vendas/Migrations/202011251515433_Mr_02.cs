namespace sis_vendas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mr_02 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VendaDetalhes",
                c => new
                    {
                        VendaDetalheId = c.Int(nullable: false, identity: true),
                        VendaId = c.Int(nullable: false),
                        ProdutoId = c.Int(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        ValorUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.VendaDetalheId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.VendaDetalhes");
        }
    }
}
