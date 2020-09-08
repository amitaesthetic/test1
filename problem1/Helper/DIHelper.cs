using Microsoft.Extensions.DependencyInjection;
using problem1.Repo;

namespace problem1.Helper
{
    public static class DIHelper
    {
        public static void DIForConsoleProgram(out ServiceProvider serviceProvider, out IProductService service)
        {
            //No Switch case needed right now as only one Repo exists 

            var collection = new ServiceCollection();
            collection.AddScoped<IProductService, ProductService>();


            serviceProvider = collection.BuildServiceProvider();
            service = serviceProvider.GetService<IProductService>();
        }
    }
}
