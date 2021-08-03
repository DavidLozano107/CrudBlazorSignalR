using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LenguageBlazorSignalR.Shared;

namespace LenguageBlazorSignalR.Server.Data
{
    public class LenguageBlazorSignalRServerContext : DbContext
    {
        public LenguageBlazorSignalRServerContext (DbContextOptions<LenguageBlazorSignalRServerContext> options)
            : base(options)
        {
        }

        public DbSet<LenguageBlazorSignalR.Shared.ProgrammingLanguage> ProgrammingLanguage { get; set; }
    }
}
