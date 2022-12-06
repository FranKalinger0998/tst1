using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using tst1.Data;

namespace tst1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            
        

            services.AddDbContext<ContextToDo>(options =>
                        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }
    }
}
