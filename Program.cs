using System.Net.Http.Headers;

namespace OE_PMP_GYAK_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // #1
            #region
            Console.WriteLine("1. feladat");

            Console.Write("N (Pozitív egész szám) = ");
            int N_1f = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < N_1f; i++)
            {
                if (i % 2 == 0) Console.Write($"{i} ");
            }

            Console.ReadLine();
            #endregion

            // #2
            #region
            Console.WriteLine("----------------");
            Console.WriteLine("2. feladat");

            string pwd = "jelszo";
            int numOfTries = 0;

            Console.Write("Kérem a jelszót: ");

            while (pwd != Console.ReadLine())
            {
                numOfTries++;

                if (numOfTries > 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Túl sok sikertelen próbálkozás!");

                    break;
                }

                Console.Write("Kérem a jelszót: ");
            }

            if (numOfTries < 3) Console.WriteLine("Sikeres.");

            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadLine();
            #endregion

            // #3
            #region
            Console.WriteLine("----------------");
            Console.WriteLine("3. feladat");

            int numOfRandTries = 0;
            Random rand = new Random();

            while (rand.Next(0, 1001) != N_1f) numOfRandTries++;

            Console.WriteLine($"Próbálkozások száma: {numOfRandTries}");

            Console.ReadLine();
            #endregion

            //#4
            #region
            Console.WriteLine("----------------");
            Console.WriteLine("4. feladat");

            int numOfPlayers = 4;
            int currPlayer = 1; //az egyes indexről kezdünk mert, nincs nulladik játékos

            while (currPlayer < 5)
            {
                Console.Write($"[#{currPlayer}] Dobj egyet az Enterrel: ");
                Console.ReadLine();

                int rolledNum = rand.Next(1, 7);

                Console.WriteLine($"\tDobott számod: {rolledNum}");

                if (rolledNum == 6)
                {
                    Console.WriteLine($"Hatost dobtál, ezért te kezded a játékot ( #{currPlayer} ).");
                    break;
                }

                if (currPlayer == numOfPlayers) currPlayer = 0;

                currPlayer++;
            }

            Console.ReadLine();
            #endregion

            // #5
            #region
            Console.WriteLine("----------------");
            Console.WriteLine("5. feladat");

            int guessNumber = 666;
            int numOfGuesses = 0;
            int currGuess = guessNumber + 1; // hozzáadunk egyet, így sosem lesz egyforma a két szám

            while (currGuess != guessNumber)
            {
                numOfGuesses++;

                Console.Write("Adj meg egy tippet: ");
                currGuess = int.Parse(Console.ReadLine()!);

                int eredmeny = guessNumber - currGuess;

                if (eredmeny == 0)
                {
                    Console.WriteLine("Eltaláltad a számot!");
                    break;
                }

                if (eredmeny < 0) Console.WriteLine("A tipped nagyobb, mint a gondolt szám.");
                if (eredmeny > 0) Console.WriteLine("A tipped kisebb, mint a gondolt szám.");
            }

            Console.WriteLine($"Próbálkozások száma: {numOfGuesses}");

            Console.ReadLine();
            #endregion

            // #6
            #region
            Console.WriteLine("----------------");
            Console.WriteLine("6. feladat");

            Console.Write("Kérek egy pozitív számot! N = ");

            int N_2f = int.Parse(Console.ReadLine()!);
            int numOfDivs = 0;

            for (int i = 2; i < N_2f; i++)
            {
                if (N_2f % i == 0) numOfDivs++;
            }

            Console.WriteLine($"A megadott szám: {((N_2f % 2 == 0) ? "páros" : "páratlan")}");
            Console.WriteLine($"Valódi pozitív osztók száma: {numOfDivs}");
            Console.WriteLine($"A megadott szám: {((numOfDivs > 0) ? "összetett" : "prímszám")}");

            Console.ReadLine();
            #endregion

            // #7
            #region
            Console.WriteLine("----------------");
            Console.WriteLine("7. feladat");

            Console.Write("N = ");
            int N_3f = int.Parse(Console.ReadLine()!);
            int factorial = 1;
            string factorialS = "";

            for (int i = N_3f; i > 1; i--)
            {
                factorial *= i;
                factorialS += i + "x";
            }

            factorialS += "1";

            Console.WriteLine($"{N_3f}! = {factorialS} = {factorial}");

            Console.ReadLine();
            #endregion

            // #8
            #region
            Console.WriteLine("----------------");
            Console.WriteLine("8. feladat");

            for (int i = 0; i < 10; i++)
            {
                int[] results = new int[9];

                for (int j = 1; j < 10; j++)
                {
                    results[j - 1] = (i == 0) ? j : i * j;
                }

                string table = String.Format("|{0,2}|{1,2}|{2,2}|{3,2}|{4,2}|{5,2}|{6,2}|{7,2}|{8,2}|{9,2}", (i == 0 ? "" : i), results[0], results[1], results[2], results[3], results[4], results[5], results[6], results[7], results[8]);
                Console.WriteLine(table);
                Console.WriteLine("------------------------------");

            }

            Console.ReadLine();
            #endregion

            // #9
            #region
            Console.WriteLine("----------------");
            Console.WriteLine("9. feladat");

            Console.Write("Kérek egy időtartamot (másodpercben): ");
            int s = int.Parse(Console.ReadLine()!);


            for (int i = s; i >= 0; i--)
            {
                int m = i / 60;
                int leftOverSecs = i % 60;

                if (i == 0) Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($"{m.ToString("00")}:{leftOverSecs.ToString("00")}");
                System.Threading.Thread.Sleep(1000);
            }

            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadLine();
            #endregion

            // #10
            #region
            Console.WriteLine("----------------");
            Console.WriteLine("10. feladat");

            uint N_10f = 420;
            string binary = "";

            while (N_10f != 0)
            {
                binary = (N_10f % 2 == 0) ? "0" + binary : "1" + binary;
                N_10f /= 2;
            }

            Console.WriteLine(binary);

            Console.ReadLine();
            #endregion

            // #11
            #region
            Console.WriteLine("----------------");
            Console.WriteLine("11. feladat");

            int credits = 100;
            int wage = 1;
            ConsoleKey key = ConsoleKey.None;
            ConsoleKey[] validKeys = { ConsoleKey.UpArrow, ConsoleKey.DownArrow, ConsoleKey.Spacebar };

            while (credits > 0 && key != ConsoleKey.Escape)
            {
                Console.WriteLine($"Kreditek: {credits}");
                Console.WriteLine($"Tét: {wage}");

                key = Console.ReadKey().Key;

                // ha a user érvénytelen billentyűt használ, újrakezdjük a kört
                if (!validKeys.Contains(key)) continue;

                if (key == validKeys[0])
                {
                    if (wage < credits) wage++;

                    Console.Clear();

                    continue;
                }

                if (key == validKeys[1])
                {
                    if (wage > 1) wage--;

                    Console.Clear();

                    continue;
                }

                // ide a user csak akkor jut el ha space-t nyomott

                int randNum1 = rand.Next(0, 10);
                int randNum2 = rand.Next(0, 10);
                int randNum3 = rand.Next(0, 10);

                Console.WriteLine($"Pörgetett számok: [ {randNum1} ] [ {randNum2} ] [ {randNum3} ]");

                if (randNum1 == randNum2 || randNum2 == randNum3 || randNum3 == randNum1)
                {
                    Console.WriteLine($"[ + ] Két egyforma pörgetés, nyertél: {wage * 10} kreditet!");
                    credits += wage * 10;
                    continue;
                }

                if (randNum1 == randNum2 && randNum1 == randNum3)
                {
                    Console.WriteLine($"[ + ] Három egyforma pörgetés, nyertél: {wage * 50} kreditet!");
                    credits += wage * 50;
                    continue;
                }

                Console.WriteLine($" [ - ] Sajnos vesztettél {wage} kreditet!");
                credits -= wage;
            }

            Console.WriteLine("Játék vége..");

            Console.ReadLine();
            #endregion

        }
    }
}
