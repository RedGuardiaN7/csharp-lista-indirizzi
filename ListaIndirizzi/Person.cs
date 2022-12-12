using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaIndirizzi
{
    public class Person : Address
    {

        //Attributi

        public string? Name { get; set; }

        public string? Surname { get; set; }


        //------------ COSTRUTTORI ------------ //
        public Person() : base(){}

        //---------- Definizioni dei metodi ---------- //

        //Metodo che stampa a video tutte le informazioni del prodotto (override del address.cs)
        public virtual void Print(int num)
        {
            Console.WriteLine("--------------------- Person " + num + " ----------------------");
            Console.WriteLine();
            if (this.Name == "")
            {
                Console.WriteLine("Name: not specified");
            }
            else
            {
                Console.WriteLine("Name: " + this.Name);
            }
            Console.WriteLine();
            if (this.Surname == "")
            {
                Console.WriteLine("Surname: not specified");
            }
            else
            {
                Console.WriteLine("Surname: " + this.Surname);
            }
            Console.WriteLine();
            if (this.City == "")
            {
                Console.WriteLine("City: not specified");
            }
            else
            {
                Console.WriteLine("City: " + this.City);
            }
            Console.WriteLine();
            if (this.Province == "")
            {
                Console.WriteLine("Province: not specified");
            }
            else
            {
                Console.WriteLine("Province: " + this.Province);
            }
            Console.WriteLine();
            if (this.Street == "")
            {
                Console.WriteLine("Street: not specified");
            }
            else
            {
                Console.WriteLine("Street: " + this.Street);
            }
            Console.WriteLine();
            if (this.ZIP == 0)
            {
                Console.WriteLine("ZIP: not specified");
            }
            else
            {
                Console.WriteLine("ZIP code: " + this.ZIP);
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();

        }

    }
}
