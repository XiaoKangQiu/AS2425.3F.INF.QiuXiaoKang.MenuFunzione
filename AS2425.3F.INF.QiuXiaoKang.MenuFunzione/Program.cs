namespace AS2425._3F.INF.QiuXiaoKang.MenuFunzione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int scelta, num1, num2; 
            double risultato = 0;

            //Intestazione
            Console.WriteLine("Qiu; 3F; 09/12/2024; Menù scelta funzione");
            do
            {
                scelta = Menu();
                switch (scelta)
                {
                    case 1:
                        Console.WriteLine("Inserire il primo numero");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Inserire il secondo numero");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        risultato = Maggiore(num1, num2);

                        Console.WriteLine($"Il massimo fra {num1} ed {num2} è: {risultato}\n");

                        break;
                    case 2:
                        Console.WriteLine("Inserire il numero di cui fare la radice quadrata");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        risultato = RadiceQuadrata(num1);

                        Console.WriteLine($"La radice quadrata di {num1} è: {risultato}\n");

                        break;

                    case 9:
                        Console.WriteLine("Sei uscito dal programma");

                        break;
                }
            } while (scelta != 9);
        }

        //Menù
        public static int Menu()
        {
            int scelta;
            do
            {
                Console.WriteLine("Sceglire quale operazione si vuole fare:");
                Console.WriteLine("Inserire 1 per il massimo tra due numeri");
                Console.WriteLine("Inserire 2 per fare la radice quadrata di un numero");
                Console.WriteLine("Inserire 9 per uscire dal ciclo");
                scelta = Convert.ToInt32(Console.ReadLine());

                if (scelta != 9 && scelta != 1 && scelta != 2)
                {
                    Console.WriteLine("Perfavore scegliere una delle opzioni");
                }
            } while (scelta != 9 && scelta != 1 && scelta != 2);
            
            return scelta;
        }
        
        //Maggiore fra due numeri
        public static int Maggiore(int n1, int n2) 
        {
            int max;

            if (n1 > n2)
            {
                max = n1;
            }
            else
            {
                max = n2;
            }

            return max;
        }

        //radice quadrata di un numero
        public static double RadiceQuadrata(double n)
        {
            return Math.Sqrt(n);
        }
    }
}
