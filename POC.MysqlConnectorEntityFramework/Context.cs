using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.MysqlConnectorEntityFramework
{
    public class Context : DbContext
    {
        public Context()
        {

        }

        public virtual DbSet<Transacao> Transacao { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new TransacaoMap());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseMySQL("Server=148.72.155.115;Port=3310;Database=opah_autorizador_prd;Uid=autorizador;Pwd=Autorizador2020*");
                optionsBuilder.UseMySQL("Server=localhost;Port=3306;Database=opah_autorizador_prd;Uid=root;Pwd=admin");

                // DEV
                //optionsBuilder.UseMySql("Server=10.254.2.68;Port=3310;Database=autorizador_bd;Uid=autorizador;Pwd=a7p13d47f;"));
            }
        }
    }
}
