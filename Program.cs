using System;

namespace SeparadordeNumeros
{                                       
                                         
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] vet = new int[9];
            int[] par = new int[9];
            int[] impar = new int[9];
            int npar = 0, nimpar = 0;
            // { {1,2} {3,4 } };
           
            for (int n1 = 0; n1<vet.GetLength(0); n1++) //rodar 10x
                
            {
                Console.WriteLine("Digite o seu valor (!!-   VALOR > 0   -!!)");
                vet[n1]= int.Parse(Console.ReadLine());
                if (vet[n1] % 2 == 0)
                { // par
                    par[npar] = vet[n1];
                    npar++;
                    
                }
                else if (vet[n1] % 2 != 0) {
                    impar[nimpar] = vet[n1];
                    
                    nimpar++;
                }
                
            }
            foreach (int n in par) { 
                if(n != 0) {
                    Console.WriteLine("Pares =" + n);
                }
            
            }
            foreach (int n in impar)
            {
                if (n != 0)
                {

                    Console.WriteLine("Impares =" + n);
                }
            }
            Console.ReadLine();

        }
    }
}
