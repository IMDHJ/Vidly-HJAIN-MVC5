namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGenere : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres (Id, GenereName) values (1, 'Comedy')");
            Sql("Insert into Genres (Id, GenereName) values (2, 'Action')");
            Sql("Insert into Genres (Id, GenereName) values (3, 'Romantic')");
            Sql("Insert into Genres (Id, GenereName) values (4, 'Horror')");
            Sql("Insert into Genres (Id, GenereName) values (5, 'Documentry')");
            Sql("Insert into Genres (Id, GenereName) values (6, 'Biopic')");
        }
        
        public override void Down()
        {
        }
    }
}
