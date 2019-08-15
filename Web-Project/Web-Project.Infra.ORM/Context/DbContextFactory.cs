using System.Data.Entity.Infrastructure;
using System.Diagnostics.CodeAnalysis;

namespace Web_Project.Infra.ORM.Context
{
    [ExcludeFromCodeCoverage]
    public class DbContextFactory : IDbContextFactory<WebProjectContext>
    {
        public WebProjectContext Create()
        {
            return new WebProjectContext();
        }
    }
}
