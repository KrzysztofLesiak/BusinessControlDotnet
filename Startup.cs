
using System.Text.Json;


public class Startup
    {

      public void ConfigureServices(IServiceCollection services)
      {
        services.AddControllers().AddJsonOptions(options => 
        {
          options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
        });
      }
}