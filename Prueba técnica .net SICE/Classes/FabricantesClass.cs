using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_técnica_.net_SICE.Classes
{
    public class FabricantesClass
    {
        [Key]
        public int id_fab { get; set; }
        public string fab_name { get; set; }
        public string fab_desc { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMemoryCache();
        }
    }
}
