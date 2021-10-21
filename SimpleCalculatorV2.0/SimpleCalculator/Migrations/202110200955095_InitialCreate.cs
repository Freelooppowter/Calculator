namespace SimpleCalculator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Calculators",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstNumber = c.Double(nullable: false),
                        SecondNumber = c.Double(nullable: false),
                        Operator = c.String(),
                        Result = c.Double(nullable: false),
                        OperateDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Calculators");
        }
    }
}
