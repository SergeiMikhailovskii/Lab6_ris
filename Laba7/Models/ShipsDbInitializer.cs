using System.Data.Entity;

namespace Laba7.Models
{
    public class ShipsDbInitializer: CreateDatabaseIfNotExists<ShipsContext>
        {
            protected override void Seed(ShipsContext db)
            {
                base.Seed(db);
            }
        }
}