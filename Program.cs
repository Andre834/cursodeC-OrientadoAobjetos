using System;

namespace _01Conceitos
{
    class Program
    {
        static void Main(string[] args) 
        {
            // Instanciando objeto

            Pessoa obj = new Pessoa();
            obj.nome = "Santiago";
            obj.idade = 32;
            obj.menssagem();
        }
    }
}
