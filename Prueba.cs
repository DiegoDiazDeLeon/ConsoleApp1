﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    class Prueba
    {
        public void Imprime() {

            List<string> lista = new List<string>();
            lista.Add("hola ");
            lista.Add("que ");
            lista.Add("tal ");

            for(int i=0; i<lista.Count;i++)
            {
                Console.WriteLine(lista[i]);
            }
        }


    }
}
