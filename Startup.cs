namespace PharmApi.Docs
{
    using System;
    using System.IO;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.FileProviders;

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Nothing
        }

        public void Configure(IApplicationBuilder app)
        {
            var sharedOptions = new Microsoft.AspNetCore.StaticFiles.Infrastructure.SharedOptions
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "docs")),
            };

            app.UseDefaultFiles(new DefaultFilesOptions(sharedOptions));
            app.UseStaticFiles(new StaticFileOptions(sharedOptions));
        }
    }
}
