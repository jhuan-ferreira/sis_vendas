namespace sis_vendas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Att_2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Produtoes", "Valor", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Produtoes", "Valor", c => c.Double(nullable: false));
        }
    }
}
