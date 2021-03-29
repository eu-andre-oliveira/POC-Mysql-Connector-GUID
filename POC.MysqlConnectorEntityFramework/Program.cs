using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace POC.MysqlConnectorEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new Context();

            var trans = ctx.Transacao.ToList();

            foreach (var item in trans)
            {
                Console.WriteLine($"{UtilGuid.FromByteArrayToString(item.IdTransacao)} - valor: {item.Valor.ToString()}");
            }
        }
    }
}
