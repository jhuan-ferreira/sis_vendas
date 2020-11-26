namespace sis_vendas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mr_03 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VendaDetalhes", "ClienteId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.VendaDetalhes", "ClienteId");
        }
    }
}
