namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipNameInTable : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes set MembershipName = 'Pay as you go' where Id = 1 ");
            Sql("Update MembershipTypes set MembershipName = 'Monthly' where Id = 2 ");
            Sql("Update MembershipTypes set MembershipName = 'Quaterly' where Id = 3 ");
            Sql("Update MembershipTypes set MembershipName = 'Annually' where Id = 4 ");
        }
        
        public override void Down()
        {
        }
    }
}
