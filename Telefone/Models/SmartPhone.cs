using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefone.Models
{
    internal abstract class SmartPhone
    {
        public int numero;
        public string modelo;
        public int memoria;
        public int Imei;

        public SmartPhone(int numero, string modelo, int memoria, int imei)
        {
            this.numero = numero;
            this.modelo = modelo;
            this.memoria = memoria;
            this.Imei = imei;
        }

        public virtual void Ligar()
        {
            Console.WriteLine("Digite o número:");
            string number = Console.ReadLine();
            int num = int.Parse(number);

            Console.WriteLine($"Ligando para {num}");

        }
        public virtual void ReceberLigacao()
        {
            Console.WriteLine("Recebendo Ligação");
        }

        public abstract void InstalarApp();
    }
}
