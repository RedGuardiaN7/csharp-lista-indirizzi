﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaIndirizzi
{
    public class Address
    {

        //Attributi

        public string? Street { get; set; }

        public string? City { get; set; }

        public string? Province { get; set; }

        public int? ZIP { get; set; }

        public static int Count { get; set; } = 0;          //Questo attributo statico permette di contare il numero delle persone presenti nel file CVS

        //------------ COSTRUTTORI ------------ //

        public Address() : base()
        {
            Count++;
        }

        //---------- Definizioni dei metodi ---------- //

        //Metodo che stampa a video tutte le informazioni
        public void Print()
        {
            Console.WriteLine("--------------------- Address " + Count + " ----------------------");
            Console.WriteLine();
            if (this.City == "") 
            {
                Console.WriteLine("City: not specified");
            } else { 
                Console.WriteLine("City: " + this.City); 
            }
            Console.WriteLine();
            if (this.Province == "")
            {
                Console.WriteLine("Province: not specified");
            }
            else
            {
                Console.WriteLine("Province" + this.Province);
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
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine();
        }
    }
}
