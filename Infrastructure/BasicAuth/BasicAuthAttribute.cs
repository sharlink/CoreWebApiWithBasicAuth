using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDemo.Infrastructure.BasicAuth
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class BasicAuthAttribute : TypeFilterAttribute
    {
        public BasicAuthAttribute(string realm = @"My Realm") : base(typeof(BasicAuthFilter))
        {
            Arguments = new object[] { realm };
        }
    }
}
