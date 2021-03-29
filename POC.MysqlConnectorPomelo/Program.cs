using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace POC.MysqlConnectorPomelo
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new Context();

            Console.WriteLine(UtilGuid.FromByteArrayToString(UtilGuid.StringGuidToByte("008a0322-5d28-3848-831d-aec65f20ec14")));

            var trans = from t in ctx.Transacao
                        where t.IdTransacao == UtilGuid.StringGuidToByte("008a0322-5d28-3848-831d-aec65f20ec14")
                        select new { id_transacao = t.IdTransacao};

            foreach (var item in trans)
            {
                Console.WriteLine( $"{UtilGuid.FromByteArrayToString(item.id_transacao )} ");
            }

            //Console.WriteLine("Hello World!");
        }
    }
}
