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

        public int ContarLetras()
        {
            char c;
            int CL = 0;

            while(!archivo.EndOfStream)
            {
                c = (char)archivo.Read();

                if (char.IsLetter(c))
                {
                    CL++;
                }
            }
            return CL;
        }

        public int ContarDigitos()
        {
            char c;
            int CN = 0;

            while(!archivo.EndOfStream)
            {
                c = (char)archivo.Read();

                if (char.IsDigit(c))
                {
                    CN++;
                }
            }
            return CN;
        }

        public int ContarEspacios()
        {
            char c;
            int CE = 0;

            while(!archivo.EndOfStream)
            {
                c = (char)archivo.Read();

                if (char.IsWhiteSpace(c))
                {
                    CE++;
                }
            }
            return CE;
        }

        public char primerCaracter()
        {
            char c = 'v';

            do
            {
                c = (char)archivo.Read();

                if (char.IsAsciiLetterOrDigit(c))
                {
                    return c;
                }
            }while(!archivo.EndOfStream);
            
            return c;
        }

        public char primerCaracterprofe()
        {
            char c;

            while(char.IsWhiteSpace(c = (char)archivo.Read()) && !archivo.EndOfStream) {}

            return c;
        }

        public dynamic PrimeraPalabra()
        {
            dynamic d = "Empty";
            string buffer = "";
            char c;

            while (char.IsWhiteSpace(c = (char)archivo.Read()) && !archivo.EndOfStream)
            {
                       
            }

            if(char.IsLetter(c))
            {
                buffer +=c;
                
                while (char.IsLetter(c = (char)archivo.Read()) && !archivo.EndOfStream)
                {
                    buffer +=c;
                }
            }
            log.WriteLine(buffer);
            return buffer.ToString();
        }
    }
}