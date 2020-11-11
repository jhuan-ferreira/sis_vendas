namespace sis_vendas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AttBancoDeDados : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Produtoes", "dataCadastro", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Produtoes", "dataCadastro", c => c.DateTime(nullable: false));
        }
    }
}
