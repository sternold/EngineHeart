using System.IO;
using EngineHeart.Database.Repositories;
using Microsoft.AspNetCore.Builder;

namespace EngineHeart.API.Extensions
{
    public static class DatabaseExtension
    {
        public static void UseDatabase(this IApplicationBuilder app)
        {
            if (!BaseRepository.DbExists)
            {
                BaseRepository.TryCreateDatabase();
            }
        }
    }
}