using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AzureProject.Startup))]

namespace AzureProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
