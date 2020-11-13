namespace sis_vendas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Att_3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Endereco", c => c.String());
            AddColumn("dbo.Clientes", "Cpf", c => c.String());
            AlterColumn("dbo.Produtoes", "Nome", c => c.String(nullable: false, maxLength: 60));
            DropColumn("dbo.Clientes", "Endereço");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clientes", "Endereço", c => c.String());
            AlterColumn("dbo.Produtoes", "Nome", c => c.String());
            DropColumn("dbo.Clientes", "Cpf");
            DropColumn("dbo.Clientes", "Endereco");
        }
    }
}
