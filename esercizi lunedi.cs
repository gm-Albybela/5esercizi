namespace es_funzioni
{
    internal class Program
    {
        static double Media(int n1, int n2)
        {
            int cont = 0, cont_dis = 0;
            double media;

            for (int i = n1; i <= n2; i++)
            {
                if (i % 2 == 1)
                {
                    cont = cont + i;
                    cont_dis++;
                }

            }

            media = cont / cont_dis;

            return media;

        }

        static int Fattoriale(int n)
        {
            int m = 1;

            for (int i = 1; i <= n; i++)
            {

                m = m * i;

            }

            return m;
        }

        static double Conta_cifre(int c)
        {
            int cont = 0;

            while (c >= 1)
            {
                c = c / 10;
                cont++;

            }

            return cont;
        }

        static bool Verifica_int(int ci, int c1, int c2)
        {

            if (c1 > c2)
            {
                if (ci > c2 && ci < c1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {

                if (ci > c1 && ci < c2)
                {

                    return true;

                }
                else
                {
                    return false;
                }

            }
        }

        static bool Num_perfetto(int n)
        {
            int contatore = 0;

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    contatore = contatore + i;
                }
            }

            if (contatore == n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {   //media intervallo

            int num1, num2;

            Console.WriteLine("Dimmi il primo estremo dell' intervallo");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dimmi il secondo estremo dell' intervallo");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("media: " + Media(num1, num2));

            //fattoriale

            int num;

            Console.WriteLine("Dimmi un numero");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fattoriale: " + Fattoriale(num));

            //conta cifre

            int cifra;

            Console.WriteLine("Dimmi un numero");
            cifra = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("E composto da " + Conta_cifre(cifra) + " cifre");

            //verifica intervallo

            int n, n1, n2;

            Console.WriteLine("Dimmi un numero");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dimmi il primo estremo dell' intervallo");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dimmi il secondo estremo dell' intervallo");
            n2 = Convert.ToInt32(Console.ReadLine());

            bool r = Verifica_int(n, n1, n2);
            Console.WriteLine(r);

            //numero perfetto

            Console.WriteLine("Dimmi un numero");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Num_perfetto(n));
        }
    }
}
