using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();


            var funcionarios = new Funcionarios[10];
            

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Id);

            }
        }

        public struct Funcionarios
        {
            public int Id { get; set; }
        }
    }
}
