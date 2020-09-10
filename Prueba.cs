using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//git cd C://ejemplo
//git status
//git add .
//git commit -m "agrege esto"
//git push
//git pull 

namespace A
{
    class Prueba
    {
        public void Imprime() {

            List<string> lista = new List<string>();
            lista.Add("holaa ");
            lista.Add("que ");
            lista.Add("tal como andas");

            for(int i=0; i<lista.Count;i++)
            {
                Console.WriteLine(lista[i]);
            }
        }


    }
}
