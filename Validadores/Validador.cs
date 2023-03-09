using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Validadores
{
    public class Validador
    {

        Stack pilaParentesis = new Stack();
        Stack pilaIdentificadores = new Stack();
        Stack pilaOperadores = new Stack();

        public char [] operadores = {'+','-','*','/','%', '√'};

        
        

        public bool validarParentesis(string codigo)
        {
            int f;
            for (f = 0; f < codigo.Length; f++)
            {
                if (codigo[f] == '(' || codigo[f] == '[' || codigo[f] == '{')
                {
                    pilaParentesis.Push(codigo[f]);
                }
                else
                {
                    if (codigo[f] == ')')
                    {
                        if (pilaParentesis.Pop().ToString() != "(")
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (codigo[f] == ']')
                        {
                            if (pilaParentesis.Pop().ToString() != "[")
                            {
                                return false;
                            }
                        }
                        else
                        {
                            if (codigo[f] == '}')
                            {
                                if (pilaParentesis.Pop().ToString() != "{")
                                {
                                    return false;
                                }
                            }
                        }
                    }
                }
            }
            if (pilaParentesis.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool validarOperaciones(String codigo)
        {
            int i;
            for (i = 0; i < codigo.Length; i++)
            {
                if (esOperador(codigo[i]))
                {
                    if (pilaIdentificadores.Count != 0)
                    {
                        pilaOperadores.Push(codigo[i]);
                    } 
                    else
                    {
                        return false;
                    }
                    
                }
                else if (esIdentificador(codigo[i]))
                {
                    pilaIdentificadores.Push(codigo[i]);
                }
                else
                {
                    return false;
                }
            }

            if(pilaIdentificadores.Count == pilaOperadores.Count + 1)
            {
                return true;
            }
            return false;
        }


        public bool esIdentificador(char codigo)
        {
            string pattern = "([A-Za-z0-9])";
            try
            {
                foreach (Match match in Regex.Matches(codigo.ToString(), pattern, RegexOptions.None, TimeSpan.FromSeconds(1)))
                {
                    if (match.Success)
                    {
                        return true;
                    }
                }
  
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            return false;
        }

        public bool esOperador(char codigo)
        {
            for (int i = 0; i < operadores.Length; i++)
            {
                if (codigo == operadores[i])
                {
                    return true;
                }
            }
            return false;
        }

    }
}
