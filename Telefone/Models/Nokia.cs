using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefone.Models
{
    internal class Nokia : SmartPhone
    {
        public Nokia(int numero, string modelo, int memoria, int Imei) : base(numero, modelo, memoria, Imei)
        {
            this.numero = numero;
            this.modelo = modelo;
            this.memoria = memoria;
            this.Imei = Imei;
        }

        public override void InstalarApp()
        {
            Console.WriteLine("Digite o nome do App.");
            string app = Console.ReadLine();
            Console.WriteLine($"Instalando o App {app}");
        }
    }
}
