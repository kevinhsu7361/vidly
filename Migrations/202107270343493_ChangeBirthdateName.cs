namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeBirthdateName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthdate", c => c.DateTime());
            DropColumn("dbo.Customers", "BitrhDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "BitrhDate", c => c.DateTime());
            DropColumn("dbo.Customers", "Birthdate");
        }
    }
}
