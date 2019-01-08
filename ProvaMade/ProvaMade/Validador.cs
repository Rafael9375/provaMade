using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaMade
{
    public class Validador
    {
        public bool verificaFoo(char _letra)
        {
            String letra = _letra.ToString();
            
            if (letra == "b" ||
                    letra == "v" ||
                    letra == "s" ||
                    letra == "h" ||
                    letra == "z")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        
        public List<Palavras> separaPalavra(String texto)
        {
            
            List<Palavras> lista = new List<Palavras> ();
            String palavra = "";
            for (int i = 0; i <= texto.Length; i++)
            {
                if (i == texto.Length)
                {
                    lista.Add(new Palavras { palavra = palavra });
                    break;
                }
                if (texto[i].ToString() != " ")
                {
                    palavra += texto[i];
                }
                if (texto[i].ToString() == " ")
                {
                    lista.Add(new Palavras { palavra = palavra });
                    palavra = "";
                }
            }
            return lista;
        }

        public bool novaLista(List<Palavras> lista, String p)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].palavra == p)
                {
                    return false;
                    //break;
                }             
            }
            return true;
        }
        
        public IEnumerable<Palavras> substituiLetras(List<Palavras> listaAtual)
        {
            String abc = "jngmclqskrzfvbwpxdht";
            String novoAbc = "abcdefghijklmnopqrst";
            String parametro1, parametro2;
            Palavras p, np;
            IEnumerable<Palavras> novaLista = new List<Palavras>();
            List<Palavras> nlista = new List<Palavras>();

            for (int i = 0; i < 2; i++)
            {
                if (i == 1)
                {
                    novaLista = nlista.OrderBy(x => x.palavra);
                    nlista = new List<Palavras>();
                    listaAtual = new List<Palavras>();
                    listaAtual = novaLista.ToList();
                    parametro1 = novoAbc;
                    parametro2 = abc;
                }
                else
                {
                    parametro1 = abc;
                    parametro2 = novoAbc;
                }
                for (int i1 = 0; i1 < listaAtual.Count; i1++)
                {
                    p = new Palavras();
                    np = new Palavras();
                    p.palavra = listaAtual[i1].palavra;
                    for (int i2 = 0; i2 < p.palavra.Length; i2++)
                    {
                        for (int i3 = 0; i3 < abc.Length; i3++)
                        {
                            if (p.palavra[i2] == parametro1[i3])
                            {
                                np.palavra += parametro2[i3];
                                break;
                            }
                        }
                    }
                    nlista.Add(np);
                }
            }
            novaLista = new List<Palavras>();
            novaLista = nlista;
            return novaLista;
        }
        
    }
}
