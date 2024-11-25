using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Person.Routes
{
    public  static class PersonRoute
    {
        public static void PersonRoutes(WebApplication app)
        {
            app.MapGet("person", ()=> "Olá pessoa");
        }
    }
}