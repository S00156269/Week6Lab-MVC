namespace S00156269Rad2017MVC1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class namesAdded1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "dateJoined", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "Surname", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Surname");
            DropColumn("dbo.AspNetUsers", "FirstName");
            DropColumn("dbo.AspNetUsers", "dateJoined");
        }
    }
}
