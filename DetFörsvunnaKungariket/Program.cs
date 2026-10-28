/*
 * Ett enkelt textbaserat RPG-spel.
 * Det försvunna Kungariket är ett textbaserat RPG-spel
 * med fighter mot monster, skattkistor, butik och en Boss i slutet.
 * Skapad av: Lina Wiklund
 */

// Huvudmeny
using System.ComponentModel.Design;

Console.WriteLine("\n==================================================");
Console.WriteLine("\n    Välkommen till Det Försvunna Kungariket!      ");
Console.WriteLine("\n==================================================");

Console.WriteLine("\n");
Console.WriteLine("1. Starta spelet!");
Console.WriteLine("2. Avsluta");

Console.WriteLine();
Console.WriteLine("Välj ett alternativ (1-2): ");

// Läser in spelarens val och sparar det i variabeln 'choice'. Om användaren inte skriver något, sätts 'choice' till en tom sträng.
string choice = Console.ReadLine() ?? "";

// Starta spelet eller avsluta baserat på spelarens val.
if (choice == "1")
{
    // Rensa konsolfönstret för att ge en ren start på spelet.
    Console.Clear();
    // Starta spelet och visa en meny för att skapa karaktären.
    Console.WriteLine("\nVälkommen till äventyret!");


    Console.WriteLine("\n==================================================");
    Console.WriteLine("\n              SKAPA DIN KARAKTÄR                  ");
    Console.WriteLine("\n==================================================");

    Console.WriteLine("\nVad heter din karaktär? ");

    // Läser in spelarens namn och sparar det i variabeln 'playerName'.
    string playerName = Console.ReadLine() ?? "";
    // Sätt spelarens hälsa till 100.
    int health = 100;
    // Spelarens guld.
    int gold = 0;
    // Om spelaren har ett bättre svärd
    bool hasBetterSword = false;
    // Håller reda på om skogen är klar.
    bool forestCompleted = false;
    // Håller reda på om slottet är klar.
    bool castleCompleted = false;
    // Håller reda på om skatten är hittad i skogen.
    bool forestTreasureFound = false;
    // Håller reda på om skatten är hittad i slottet.
    bool castleTreasureFound = false;

    // Bekräfta spelarens namn och hälsa.
    Console.WriteLine($"\nVälkommen, {playerName}!");
    Console.WriteLine($"Du börjar ditt äventyr med {health} livspoäng.");
    Console.WriteLine("\nDitt äventyr börjar nu.....");

    Thread.Sleep(2000); // Vänta i 2 sekunder.

    Console.Clear(); // Rensa skärmen innan spelmenyn visas.

    // Håller reda på om spelet ska fortsätta eller avslutas.
    bool playing = true;

    // Fortsätt visa spelmenyn så länge spelet är igång.
    while (playing)
    {
        Console.Clear();
        // Visa spelets meny.
        Console.WriteLine("\n==================================================");
        Console.WriteLine("\n                    SPELMENY                      ");
        Console.WriteLine("\n==================================================");

        Console.WriteLine("\n1. Utforska kungariket");
        Console.WriteLine("2. Visa karaktärens information");
        Console.WriteLine("3. Besök butiken");
        Console.WriteLine("4. Avsluta spelet");

        Console.Write("\nVad vill du göra? (1-4): ");

        // Läser in spelarens val och sparar det i variabeln 'playerChoice'.
        string playerChoice = Console.ReadLine() ?? "";

        // Hantera spelarens val.
        if (playerChoice == "1")
        {
            Console.Clear();
            Console.WriteLine("\nDu börjar utforska det försvunna kungariket...");

            Thread.Sleep(2000);

            bool exploringKingdom = true;

            while (exploringKingdom)
            {
                Console.Clear();

                Console.WriteLine("\nVart vill du gå?");
                Console.WriteLine("1. Den mörka skogen");
                Console.WriteLine("2. Det övergivna slottet");
                Console.WriteLine("3. Slutbossen");
                Console.WriteLine("4. Tillbaka till spelmenyn");

                Console.Write("\nVälj en plats (1-3): ");

                string locationChoice = Console.ReadLine() ?? "";

                if (locationChoice == "1")
                {
                   
                    bool exploringForest = true;


                    while (exploringForest)
                    {
                        Console.Clear();
                        // Den mörka skogen.
                        Console.WriteLine("==================================================");
                        Console.WriteLine("                 DEN MÖRKA SKOGEN                 ");
                        Console.WriteLine("==================================================");
                        Console.WriteLine("\nDu går in i den mörka skogen...");

                        Console.WriteLine("\nVad vill du göra?");
                        Console.WriteLine("1. Utforska skogen.");
                        Console.WriteLine("2. Leta efter en skattkista.");
                        Console.WriteLine("3. Gå tillbaka");

                        Console.Write("\nVälj ett alternativ (1-3): ");

                        string forestChoice = Console.ReadLine() ?? "";

                        if (forestChoice == "1")
                        {
                            Console.Clear();

                            Console.WriteLine("\nDu går djupare in i skogen...");
                            Console.WriteLine("Plötsligt hör du något röra sig bakom ett träd!");
                            Thread.Sleep(1500);

                            Console.WriteLine("\nEtt vildsint monster hoppar fram!");
                            Console.WriteLine("\nETT MONSTER HAR DYKT UPP!");

                            Console.WriteLine("\nTryck på valfri tangent för att fortsätta.");
                            Console.ReadKey(true);

                            //Monstrets och spelarens skada.
                            int monsterHealth = 50;
                            int playerDamage = hasBetterSword ? 40 : 20;
                            int monsterDamage = 10;

                            bool fighting = true;

                            // Striden fortsätter så länge båda har hälsa kvar.
                            while (fighting && health > 0 && monsterHealth > 0)
                            {
                                Console.Clear();

                                Console.WriteLine("========================================");
                                Console.WriteLine("                 STRID!                 ");
                                Console.WriteLine("========================================");

                                Console.WriteLine($"\n{playerName}: {health} HP");
                                Console.WriteLine($"Monster: {monsterHealth} HP");

                                Console.WriteLine("\nVad vill du göra?");
                                Console.WriteLine("1. Attackera!");
                                Console.WriteLine("2. FLY");

                                Console.Write("\nVälj ett alternativ (1-2): ");

                                string fightChoice = Console.ReadLine() ?? "";

                                if (fightChoice == "1")
                                {
                                    // Spelaren attackerar monstret.
                                    monsterHealth -= playerDamage;

                                    Console.WriteLine($"\nDu attackerar monstret och gör {playerDamage} skada!");

                                    // Monstret attackerar om det fortfarande lever.
                                    if (monsterHealth > 0)
                                    {
                                        health -= monsterDamage;

                                        Console.WriteLine($"Monstret attackerar dig och gör {monsterDamage} skada!");
                                    }

                                    Console.WriteLine("\nTryck på valfri tangent för nästa runda...");
                                    Console.ReadKey(true);
                                }
                                else if (fightChoice == "2")
                                {
                                    Console.WriteLine("\nDu flyr från monstret!");
                                    fighting = false;

                                    Console.WriteLine("\nTryck på valfri tangent för att fortsätta.");
                                    Console.ReadKey(true);
                                }
                                else
                                {
                                    Console.WriteLine("\nOgiltigt val. Försök igen.");
                                    Thread.Sleep(1500);
                                }
                            }

                            // Kontrollera hur striden slutade.
                            if (monsterHealth <= 0)
                            {
                                Console.WriteLine("\nDu besegrade monstret!");
                                Console.WriteLine("Du har vunnit striden!");

                                forestCompleted = true;

                                gold += 10;

                                Console.WriteLine("\nDu fick 10 guldmynt som belöning!");
                                Console.WriteLine($"Du har nu {gold} guldmynt.");
                            }
                            // När spelarens hälsa tar slut.
                            else if (health <= 0)
                            {
                                Console.Clear();

                                Console.WriteLine("========================================");
                                Console.WriteLine("                GAME OVER               ");
                                Console.WriteLine("========================================");

                                Console.WriteLine("\nDin hälsa är slut!");
                                Console.WriteLine("Du kämpade tappert, men ditt äventyr har nått sitt slut...");

                                Console.WriteLine("\nTack för att du spelade");
                                Console.WriteLine("Det Försvunna Kungariket!");

                                Console.WriteLine("\nTryck på valfri tangent för att avsluta spelet...");
                                Console.ReadKey(true);

                                // Avsluta striden och spelet.
                                fighting = false;
                                playing = false;
                                exploringForest = false;
                                exploringKingdom = false;
                            }
                            if (health > 0)
                            {
                                Console.WriteLine("\nTryck på valfri tangent för att återvända till skogen...");
                                Console.ReadKey(true);
                            }
                        }
                        // Leta efter en skattkista.
                        else if (forestChoice == "2")
                        {
                            Console.Clear();

                            if (!forestTreasureFound)
                            {
                                Console.WriteLine("\nDu letar bland träden och buskarna...");
                                Thread.Sleep(1500);

                                Console.WriteLine("\nDu hittar en gammal skattkista!");
                                Console.WriteLine("Du öppnar kistan och hittar 20 guldmynt!");

                                gold += 20;
                                forestTreasureFound = true;

                                Console.WriteLine($"\nDu har nu {gold} guldmynt.");
                            }
                            else
                            {
                                Console.WriteLine("\nDu letar efter fler skatter...");
                                Console.WriteLine("Tyvärr har du redan hittat skattkistan.");
                            }

                            Console.WriteLine("\nTryck på valfri tangent för att fortsätta.");
                            Console.ReadKey(true);
                        }
                        else if (forestChoice == "3")
                        {
                            Console.WriteLine("\nDu lämnar skogen och går tillbaka.");
                            exploringForest = false;
                        }
                    }
                }
                else if (locationChoice == "2")
                {
                    bool exploringCastle = true;

                    while (exploringCastle)
                    {
                        Console.Clear();

                        Console.WriteLine("==================================================");
                        Console.WriteLine("               DET ÖVERGIVNA SLOTTET              ");
                        Console.WriteLine("==================================================");
                        Console.WriteLine("\nDu närmar dig det övergivna slottet...");

                        Console.WriteLine("\nVad vill du göra?");
                        Console.WriteLine("1. Utforska slottet");
                        Console.WriteLine("2. Leta efter en skattkista");
                        Console.WriteLine("3. Lämna slottet");

                        Console.Write("\nVälj ett alternativ (1-3): ");
                        string castleChoice = Console.ReadLine() ?? "";

                        // Val ett
                        if (castleChoice == "1")
                        {
                            if (castleCompleted)
                            {
                                Console.WriteLine("\nDu har redan besegrat den onda riddaren!");
                                Console.WriteLine("Det är lugnt i slottet nu.");

                                Console.WriteLine("\nTryck på valfri tangent för att fortsätta.");
                                Console.ReadKey(true);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\nDu går djupare in i slottet...");
                                Console.WriteLine("Plötsligt hör du tunga steg bakom dig!");

                                Thread.Sleep(1500);

                                Console.WriteLine("\nEn ond riddare dyker upp!");
                                Console.WriteLine("Du måste besegra honom för att fortsätta.");

                                Console.WriteLine("\nTryck på valfri tangent för att fortsätta.");
                                Console.ReadKey();

                                // Riddarens och spelarens skada.
                                int monsterHealth = 60;
                                bool fighting = true;
                                int playerDamage = hasBetterSword ? 40 : 20;
                                int monsterDamage = 15;

                                // Striden fortsätter så länge båda har hälsa kvar.
                                while (fighting && health > 0 && monsterHealth > 0)
                                {
                                    Console.Clear();

                                    Console.WriteLine("========================================");
                                    Console.WriteLine("                 STRID!                 ");
                                    Console.WriteLine("========================================");

                                    Console.WriteLine($"\n{playerName}: {health} HP");
                                    Console.WriteLine($"Ond riddare: {monsterHealth} HP");

                                    Console.WriteLine("\nVad vill du göra?");
                                    Console.WriteLine("\n1. Attackera");
                                    Console.WriteLine("2. FLY");

                                    Console.Write("\nVälj ett alternativ (1-2): ");

                                    string battleChoice = Console.ReadLine() ?? "";

                                    if (battleChoice == "1")
                                    {
                                        // Spelaren attackerar riddaren.
                                        monsterHealth -= playerDamage;

                                        Console.WriteLine($"\nDu attackerar riddaren och gör {playerDamage} skada!");

                                        // Riddaren attackerar om den fortfarande lever.
                                        if (monsterHealth > 0)
                                        {
                                            health -= monsterDamage;

                                            Console.WriteLine($"Riddaren attackerar dig och gör {monsterDamage} skada!");
                                        }

                                        Console.WriteLine("\nTryck på valfri tangent för nästa runda.");
                                        Console.ReadKey(true);
                                    }
                                    else if (battleChoice == "2")
                                    {
                                        Console.WriteLine("\nDu flyr från riddaren!");
                                        fighting = false;

                                        Console.WriteLine("\nTryck på valfri tangent för att fortsätta.");
                                        Console.ReadKey(true);
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nOgiltigt val. Försök igen.");
                                        Thread.Sleep(1500);
                                    }
                                }
                                // Kontrollera hur striden slutade.
                                if (monsterHealth <= 0)
                                {
                                    Console.WriteLine("\nDu har besegrat den onda riddaren!");
                                    Console.WriteLine("Du har vunnit striden!");

                                    castleCompleted = true;

                                    gold += 25;

                                    Console.WriteLine("\nDu fick 25 guldmynt i belöning!");
                                    Console.WriteLine($"Du har nu {gold} guldmynt.");

                                }
                                // När spelarens hälsa tar slut.
                                else if (health <= 0)
                                {
                                    health = 0;

                                    Console.Clear();

                                    Console.WriteLine("========================================");
                                    Console.WriteLine("                GAME OVER               ");
                                    Console.WriteLine("========================================");

                                    Console.WriteLine("\nDin hälsa är slut!");
                                    Console.WriteLine("Du kämpade tappert, men ditt äventyr har nått sitt slut...");

                                    Console.WriteLine("\nTack för att du spelade");
                                    Console.WriteLine("Det Försvunna Kungariket!");

                                    Console.WriteLine("\nTryck på valfri tangent för att avsluta spelet...");
                                    Console.ReadKey(true);

                                    // Avsluta striden och spelet.
                                    fighting = false;
                                    playing = false;
                                    exploringCastle = false;
                                    exploringKingdom = false;
                                }
                                if (health > 0)
                                {
                                    Console.WriteLine("\nTryck på valfri tangent för att återvända till slottet.");
                                    Console.ReadKey(true);
                                }
                            }
                        }
                        
                        else if (castleChoice == "2")
                        {
                            if (!castleTreasureFound)
                            {
                                Console.WriteLine("\nDu går och utforskar slottet.");
                                Thread.Sleep(1500);

                                Console.WriteLine("\nDu hittar en skattkista!");
                                Console.WriteLine("Du får 30 guld!");

                                gold += 30;
                                castleTreasureFound = true;
                            }
                            else
                            {
                                Console.WriteLine("\nDu har redan hittat skattkistan!");
                            }
                                Console.WriteLine($"\nDu har nu {gold} guldmynt.");
                                Console.WriteLine("\nTryck på valfri tangent för att fortsätta.");
                                Console.ReadKey();
                        }
                        else if (castleChoice == "3")
                        {
                            Console.WriteLine("\nDu lämnar nu slottet.");
                            exploringCastle = false;
                        }
                    }
                }
                else if (locationChoice == "3")
                {
                    Console.Clear();

                    // Koll om spelaren har gjort skogen och slottet först.
                    if (!forestCompleted || !castleCompleted)
                    {
                        Console.WriteLine("\nDu har hittat vägen till kungarikets mörkaste plats...");
                        Console.WriteLine("Men en mäktig kraft blockerar vägen!");

                        Console.WriteLine("\nDu måste besegra monstret i skogen");
                        Console.WriteLine("och den onda riddaren i slottet först.");

                        Console.WriteLine("\nTryck på valfri tangent för att fortsätta.");
                        Console.ReadKey(true);
                    }
                    else
                    {
                        Console.WriteLine("========================================");
                        Console.WriteLine("               SLUTBOSSEN               ");
                        Console.WriteLine("========================================");

                        Console.WriteLine("\nEn mäktig drake dyker upp!");
                        Console.WriteLine("Det här är den sista striden för kungariket!");

                        Console.WriteLine("\nTryck på valfri tangent för att börja striden.");
                        Console.ReadKey(true);

                        int bossHealth = 100;
                        int bossDamage = 20;
                        int playerDamage = hasBetterSword ? 40 : 20;
                        bool fightingBoss = true;

                        while (fightingBoss && health > 0 && bossHealth > 0)
                        {
                            Console.Clear();

                            Console.WriteLine("========================================");
                            Console.WriteLine("            STRID MOT DRAKEN            ");
                            Console.WriteLine("========================================");

                            Console.WriteLine($"\n{playerName}: {health} HP");
                            Console.WriteLine($"Draken: {bossHealth} HP");

                            Console.WriteLine("\nVad vill du göra?");
                            Console.WriteLine("1. Attackera");
                            Console.WriteLine("2. FLY");

                            Console.Write("\nVälj ett alternativ (1-2): ");

                            string bossChoice = Console.ReadLine() ?? "";

                            if (bossChoice == "1")
                            {
                                bossHealth -= playerDamage;

                                Console.WriteLine($"Du attackerar draken och gör {playerDamage} skada!");

                                if (bossHealth >0)
                                {
                                    health -= bossDamage;

                                    Console.WriteLine($"Draken attackerar dig och gör {bossDamage} skada!");
                                }

                                Console.WriteLine("\nTryck på valfri tangent för nästa runda.");
                                Console.ReadKey(true);
                            }
                            else if (bossChoice == "2")
                            {
                                Console.WriteLine("\nDu flyr från draken!");
                                fightingBoss = false;

                                Console.WriteLine("\nTryck på valfri tangent för att fortsätta.");
                                Console.ReadKey(true);
                            }
                            else
                            {
                                Console.WriteLine("\nOgiltigt val. Försök igen.");
                                Thread.Sleep(1500);
                            }
                        }

                        if (bossHealth <= 0)
                        {
                            Console.Clear();

                            Console.WriteLine("========================================");
                            Console.WriteLine("             DU HAR VUNNIT!             ");
                            Console.WriteLine("========================================");

                            Console.WriteLine("\nDu har besegrat draken!");
                            Console.WriteLine("Kungariket är äntligen räddat!");
                            Console.WriteLine($"Grattis {playerName}!");
                            Console.WriteLine("\nDu har klarat Det Försvunna Kungariket!");

                            Console.WriteLine("\nTryck på valfri tangent för att avsluta spelet.");
                            Console.ReadKey(true);

                            playing = false;
                            exploringKingdom = false;
                        }
                        else if (health <= 0)
                        {
                            health = 0;

                            Console.Clear();

                            Console.WriteLine("========================================");
                            Console.WriteLine("                GAME OVER               ");
                            Console.WriteLine("========================================");

                            Console.WriteLine("\nDraken besegrade dig...");
                            Console.WriteLine("Kungariket väntar fortfarande på sin hjälte.");

                            Console.WriteLine("\nTryck på valfri tangent för att avsluta spelet.");
                            Console.ReadKey(true);

                            playing = false;
                            exploringKingdom = false;
                        }
                            
                    }
                }
                  
                else if (locationChoice == "4")
                {
                    Console.WriteLine("\nDu återvänder till spelmenyn.");
                    exploringKingdom = false;
                }
                else
                {
                    Console.WriteLine("\nOgiltigt val. Du hittar inte den vägen.");
                }
            }
        }
        else if (playerChoice == "2")
        {
            Console.WriteLine("\n===== DIN KARAKTÄR =====");
            Console.WriteLine($"Namn: {playerName}");
            Console.WriteLine($"Hälsa: {health}");
            Console.WriteLine($"Guldmynt: {gold}");
        }
        else if( playerChoice == "3")
        {
            Console.Clear();

            Console.WriteLine("=======================================");
            Console.WriteLine("                BUTIKEN                ");
            Console.WriteLine("=======================================");

            Console.WriteLine($"\nDu har {gold} guldmynt");

            
            Console.WriteLine("\n1. Köp ett bättre svärd - 20 guldmynt");
            Console.WriteLine("      Skadan ökar från 20 till 40.");
            Console.WriteLine("2. Köp en hälsodryck - 15 guldmynt");
            Console.WriteLine("     Återställer 30 hälsopoäng.");
            Console.WriteLine("3. Gå tillbaka");

            Console.Write("\nVad vill du göra? ");
            string shopChoise = Console.ReadLine() ?? "";

                if (shopChoise == "1")
                {
                    if (hasBetterSword)
                    {
                        Console.WriteLine("\nDu har redan det bästa svärdet!");
                    }
                    else if (gold >= 20)
                    {
                        gold -= 20;
                        hasBetterSword = true;

                        Console.WriteLine("\nDu köpte ett bättre svärd!");
                        Console.WriteLine("Ditt nya svärd gör 40 skada.");

                        Console.WriteLine($"\nDu har {gold} guldmynt kvar.");
                    }
                    else
                    {
                        Console.WriteLine("\nDu har inte tillräcklig med gultmynt!");
                        Console.WriteLine("Du behöver 20 guldmynt för att köpa svärdet.");
                    }
                    Console.WriteLine("\nTryck på valfri tangent för att fortsätta.");
                    Console.ReadKey(true);
                }
                else if (shopChoise == "2")
                {
                    if (health >= 100)
                    {
                        Console.WriteLine("\nDu har redan full hälsa!");
                        Console.WriteLine("Du behöver ingen hälsodryck just nu.");
                    }
                    else if (gold >= 15)
                    {
                        gold -= 15;
                        health += 30;

                        if (health > 100)
                        {
                            health = 100;
                        }
                        Console.WriteLine("\nDu köpte en hälsodryck!");
                        Console.WriteLine("Din hälsa återställdes.");
                        Console.WriteLine($"Din hälsa är nu: {health}");
                        Console.WriteLine($"Du har {gold} guldmynt kvar.");                       
                    }
                    else
                    {
                        Console.WriteLine("\nDu har inte tillräckligt med guldmynt!");
                        Console.WriteLine("Du behöver 15 guldmynt för en hälsodryck.");
                    }
                    Console.WriteLine("\nTryck på valfri tangent för att fortsätta.");
                    Console.ReadKey(true);
                }
                else if (shopChoise == "3")
                {
                    // Återgå till spelmenyn.
                }
                else
                {
                    Console.WriteLine("\nOgiltigt val.");
                    Console.WriteLine("\nTryck på valfri tangent för att fortsätta.");
                    Console.ReadKey(true);
                }
            }
        else if (playerChoice == "4")
        {
            Console.WriteLine("Tack för att du spelade! Hejdå!");

            // Avsluta loopen.
            playing = false;
        }
        else
        {
            Console.WriteLine("Ogiltigt val. Vänligen välj ett alternativ mellan 1 och 4.");
        }
    }
}


