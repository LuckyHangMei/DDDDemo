using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christ3D.Infrastruct.Data.Context
{
    public class MyDesignTimeDbContextFactory : IDesignTimeDbContextFactory<StudyContext>
    {
        public StudyContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<StudyContext> builder = new();
            string connStr = "server=192.168.30.250;uid=root;pwd=12!@QWqw;Port=3306;Database=hangTest;";
            builder.UseMySql(connStr, ServerVersion.Create(8, 0, 22, ServerType.MySql));
            return new StudyContext(builder.Options);
        }
    }
}
