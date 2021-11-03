using System.Data.Entity;

namespace SRIS.Models
{
    internal class SrisDbInitializer : CreateDatabaseIfNotExists<SrisContext>
    {
    }
}