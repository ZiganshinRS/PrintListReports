using System;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using PrintListReports.Infrastructure;

namespace PrintListReports.Models
{
    public class SessionScript : Script
    {
        public static Script GetScript(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            SessionScript script = session?.GetJson<SessionScript>("Script") ?? new SessionScript();
            script.Session = session;
            return script;
        }
        [JsonIgnore]
        public ISession Session { get; set; }
    }
}
