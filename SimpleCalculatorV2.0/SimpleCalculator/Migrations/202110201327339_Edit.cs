namespace SimpleCalculator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Calculators", newName: "CalculatorRecords");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.CalculatorRecords", newName: "Calculators");
        }
    }
}
