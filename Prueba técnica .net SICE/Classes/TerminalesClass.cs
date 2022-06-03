using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_técnica_.net_SICE.Classes
{
    public class TerminalesClass
    {
        [Key]
        public int id_terminal { get; set; }
        public int id_fab { get; set; }
        public int id_estado { get; set; }
        public DateTime fecha_fabricacion { get; set; }
        public DateTime fecha_estado { get; set;}
        public string terminal_desc { get; set; }
        public string terminal_name { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMemoryCache();
        }
    }
}
