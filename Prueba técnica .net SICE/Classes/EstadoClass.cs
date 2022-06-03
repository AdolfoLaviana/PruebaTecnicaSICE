using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_técnica_.net_SICE.Classes
{
    public class EstadoClass
    {
        [Key]
        public int id_estado { get; set; }
        public string estado_name { get; set; }
        public string estado_desc { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMemoryCache();
        }
    }
}
