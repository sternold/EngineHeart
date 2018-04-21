using EngineHeart.Database.Context;
using Microsoft.AspNetCore.Builder;

namespace EngineHeart.API.Extensions
{
    public static class DatabaseExtension
    {
        public static void UseDatabase(this IApplicationBuilder app)
        {
            if (!DatabaseContext.Exists)
            {
                DatabaseContext.Create();
            }
        }
    }
}