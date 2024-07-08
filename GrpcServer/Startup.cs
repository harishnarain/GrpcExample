using GrpcServer.Services;

namespace GrpcServer
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddGrpc();
            services.AddScoped<IMessageProcessor, MessageProcessor>();
            services.AddScoped<IGrpcMessageService, GrpcMessageService>();
        }

        public void Configure(IApplicationBuilder app, IHostApplicationLifetime lifetime)
        {
            if (app.ApplicationServices.GetService<IHostEnvironment>().IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGrpcService<GrpcMessageService>();
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Communication with gRPC endpoints must be made through a gRPC client.");
                });
            });
        }
    }
}