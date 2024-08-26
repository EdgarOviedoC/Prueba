using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba
{
    public class Lecturas : IDisposable
    {
        StreamReader archivo;
        StreamWriter log;
        public Lecturas()
        {
            archivo = new StreamReader("prueba.cpp");
            log = new StreamWriter("prueba.log");
        }

        public Lecturas(string nombre)
        {
            archivo = new StreamReader(nombre);
            log = new StreamWriter("prueba.log");
        }

        public void Dispose()
        {
            archivo.Close();
            log.Close();
        }

        public void Display()
        {
            while (!archivo.EndOfStream)
            {
                Console.Write((char)archivo.Read());
            }
        }

        public void Copy()
        {
            while(!archivo.EndOfStream)
            {
                log.Write((char)archivo.Read());
            }
        }

        public void Encrypt()
        {
            char c;
            while(!archivo.EndOfStream)
            {
                c = (char)archivo.Read();
                if (char.IsLetter(c))
                {
                    log.Write((char)(c+2));
                }
                else
                {
                    log.Write((char)c);
                }
            }
        }

        public void DesEncrypt()
        {
            char c;
            while(!archivo.EndOfStream)
            {
                c = (char)archivo.Read();
                if (char.IsLetter(c))
                {
                    log.Write((char)(c-2));
                }
                else
                {
                    log.Write((char)c);
                }
            }
        }

        public void Encrypt2(char v)
        {
            char c;
            char [] vocal = {'A', 'E', 'I' ,'O', 'U', 'a', 'e', 'i', 'o', 'u'};

            String vocal2 ="AEIOUaeiou";
            while(!archivo.EndOfStream)
            {
                c = (char)archivo.Read();
                bool letra = vocal.Contains(c);

                if (letra)
                {
                    log.Write((char)(v));
                }
                else
                {
                    log.Write((char)c);
                }
            }
        }
    }
}