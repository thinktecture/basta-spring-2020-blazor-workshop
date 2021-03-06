﻿using BlazorConfTool.Client;
using Microsoft.Extensions.DependencyInjection;
using WebWindows.Blazor;

namespace BlazorConfTool.Desktop
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            ClientStartup.PopulateServices(services);
        }

        public void Configure(DesktopApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
