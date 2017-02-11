using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration
{
    public class MyOptionsSetup : IConfigureOptions<MyOptions>
    {
        public MyOptionsSetup(IHostingEnvironment env)
        {
            HostingEnvironment = env;
        }

        public IHostingEnvironment HostingEnvironment { get; set; }

        public void Configure(MyOptions options)
        {
            options.Message = $"Using options from {HostingEnvironment.EnvironmentName}";
            options.ExcitementLevel = 3;
        }
    }
}
