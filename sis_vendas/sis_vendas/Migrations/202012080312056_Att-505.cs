namespace sis_vendas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Att505 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vendas", "Data", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vendas", "Data", c => c.DateTime(nullable: false));
        }
    }
}
