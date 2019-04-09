namespace pureba2register.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRemaksField : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "LugarDeNacimiento");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "LugarDeNacimiento", c => c.String(maxLength: 120));
        }
    }
}
