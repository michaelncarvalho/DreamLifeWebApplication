namespace DreamLifeWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoTabelasCidadeViagemHotel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cidades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Pais = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Preco = c.Double(nullable: false),
                        Classificacao = c.Int(nullable: false),
                        Descricao = c.String(),
                        Cidade_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cidades", t => t.Cidade_Id)
                .Index(t => t.Cidade_Id);
            
            CreateTable(
                "dbo.Viagems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        QuantidadePessoas = c.Int(nullable: false),
                        ModalidadeViagem = c.String(),
                        Hotel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hotels", t => t.Hotel_Id)
                .Index(t => t.Hotel_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Viagems", "Hotel_Id", "dbo.Hotels");
            DropForeignKey("dbo.Hotels", "Cidade_Id", "dbo.Cidades");
            DropIndex("dbo.Viagems", new[] { "Hotel_Id" });
            DropIndex("dbo.Hotels", new[] { "Cidade_Id" });
            DropTable("dbo.Viagems");
            DropTable("dbo.Hotels");
            DropTable("dbo.Cidades");
        }
    }
}
