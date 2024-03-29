namespace Web_Project.Infra.ORM.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                {
                    Id = c.Long(nullable: false, identity: true),
                    Name = c.String(),
                    BirthDate = c.DateTime(nullable: false),
                    Teacher_Id = c.Long(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teachers", t => t.Teacher_Id)
                .Index(t => t.Teacher_Id);

            CreateTable(
                "dbo.Teachers",
                c => new
                {
                    Id = c.Long(nullable: false, identity: true),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Students", "Teacher_Id", "dbo.Teachers");
            DropIndex("dbo.Students", new[] { "Teacher_Id" });
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
        }
    }
}
