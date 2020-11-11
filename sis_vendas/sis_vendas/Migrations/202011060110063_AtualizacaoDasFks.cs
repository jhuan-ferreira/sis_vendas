namespace sis_vendas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AtualizacaoDasFks : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.VendaDetalhes", new[] { "venda_vendaId" });
            AddColumn("dbo.VendaDetalhes", "Produto_Id", c => c.Int());
            CreateIndex("dbo.VendaDetalhes", "Produto_Id");
            CreateIndex("dbo.VendaDetalhes", "Venda_vendaId");
            AddForeignKey("dbo.VendaDetalhes", "Produto_Id", "dbo.Produtoes", "Id");
            DropColumn("dbo.VendaDetalhes", "produtoId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VendaDetalhes", "produtoId", c => c.Int(nullable: false));
            DropForeignKey("dbo.VendaDetalhes", "Produto_Id", "dbo.Produtoes");
            DropIndex("dbo.VendaDetalhes", new[] { "Venda_vendaId" });
            DropIndex("dbo.VendaDetalhes", new[] { "Produto_Id" });
            DropColumn("dbo.VendaDetalhes", "Produto_Id");
            CreateIndex("dbo.VendaDetalhes", "venda_vendaId");
        }
    }
}
