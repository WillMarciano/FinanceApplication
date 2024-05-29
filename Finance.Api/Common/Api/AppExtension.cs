using Microsoft.AspNetCore.Builder;

namespace Finance.Api.Common.Api
{
    public static class AppExtension
    {
        public static void ConfigureDevEnvironment(this WebApplication app)
        {
            app.UseSwagger();
            app.UseSwagger();
            // app.MapSwagger().RequireAuthorization();
        }
    }
}
