﻿namespace TouristGuidAssistant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Users1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "DateOfBirth");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "DateOfBirth", c => c.DateTime(nullable: false));
        }
    }
}
