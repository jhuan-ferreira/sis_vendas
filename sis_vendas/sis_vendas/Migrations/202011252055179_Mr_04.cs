namespace sis_vendas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mr_04 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.VendaDetalhes", "ClienteId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VendaDetalhes", "ClienteId", c => c.Int(nullable: false));
        }
    }
}
