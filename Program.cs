class Program
{
    const string WordsFileName = "words.txt";

    const char Underscore = '_';

    static string[] stateFrames =
    {
        @"
        ┌───────────────────────────┐
        │                           │
        │ WW       WW  **  NN   N   │
        │ WW       WW  ii  NNN  N   │
        │  WW  WW WW   ii  N NN N   │
        │   WWWWWWW    ii  N  NNN   │
        │    WW  W     ii  N   NN   │
        │                           │
        │         Good job!         │
        │   You guessed the word!   │
        └───────────────────────────┘
        ",

        @"
        ┌────────────────────────────────────┐
        │  LLL          OOOO    SSSS   SSSS  │
        │  LLL         OO  OO  SS  SS SS  SS │
        │  LLL        OO    OO SS     SS     │
        │  LLL        OO    OO  SSSS   SSSS  │
        │  LLL        OO    OO     SS     SS │
        │  LLLLLLLLLL  OO  OO  SS  SS SS  SS │
        │   LLLLLLLLL   OOOO    SSSS   SSSS  │
        │                                    |
        │        You were so close.          │
        │ Next time you will guess the word! │
        └────────────────────────────────────┘
        "
    };

    static string[] guessFrames =
    {
        @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"          ║   " + '\n' +
        @"          ║   " + '\n' +
        @"          ║   " + '\n' +
        @"     ███  ║   " + '\n' +
        @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      O   ║   " + '\n' +
        @"          ║   " + '\n' +
        @"          ║   " + '\n' +
        @"     ███  ║   " + '\n' +
        @"    ══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      O   ║   " + '\n' +
        @"      |   ║   " + '\n' +
        @"          ║   " + '\n' +
        @"     ███  ║   " + '\n' +
        @"    ══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      O   ║   " + '\n' +
        @"      |\  ║   " + '\n' +
        @"          ║   " + '\n' +
        @"     ███  ║   " + '\n' +
        @"    ══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      O   ║   " + '\n' +
        @"     /|\  ║   " + '\n' +
        @"          ║   " + '\n' +
        @"     ███  ║   " + '\n' +
        @"    ══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      O   ║   " + '\n' +
        @"     /|\  ║   " + '\n' +
        @"       \  ║   " + '\n' +
        @"     ███  ║   " + '\n' +
        @"    ══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      O   ║   " + '\n' +
        @"     /|\  ║   " + '\n' +
        @"     / \  ║   " + '\n' +
        @"     ███  ║   " + '\n' +
        @"    ══════╩═══"
    };

    static string[] deathFrames =
    {
        @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      O   ║   " + '\n' +
        @"     /|\  ║   " + '\n' +
        @"     / \  ║   " + '\n' +
        @"     ███  ║   " + '\n' +
        @"    ══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      O   ║   " + '\n' +
        @"     /|\  ║   " + '\n' +
        @"     / \  ║   " + '\n' +
        @"          ║   " + '\n' +
        @"    ══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      o>  ║   " + '\n' +
        @"     /|   ║   " + '\n' +
        @"      >\  ║   " + '\n' +
        @"          ║   " + '\n' +
        @"    ══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      O   ║   " + '\n' +
        @"     /|\  ║   " + '\n' +
        @"     / \  ║   " + '\n' +
        @"          ║   " + '\n' +
        @"    ══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"     <o   ║   " + '\n' +
        @"      |\  ║   " + '\n' +
        @"     /<   ║   " + '\n' +
        @"          ║   " + '\n' +
        @"    ══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      O   ║   " + '\n' +
        @"     /|\  ║   " + '\n' +
        @"     / \  ║   " + '\n' +
        @"          ║   " + '\n' +
        @"    ══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      o>  ║   " + '\n' +
        @"     /|   ║   " + '\n' +
        @"      >\  ║   " + '\n' +
        @"          ║   " + '\n' +
        @"    ══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      o>  ║   " + '\n' +
        @"     /|   ║   " + '\n' +
        @"      >\  ║   " + '\n' +
        @"          ║   " + '\n' +
        @"    ══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      O   ║   " + '\n' +
        @"     /|\  ║   " + '\n' +
        @"     / \  ║   " + '\n' +
        @"          ║   " + '\n' +
        @"    ══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"     <o   ║   " + '\n' +
        @"      |\  ║   " + '\n' +
        @"     /<   ║   " + '\n' +
        @"          ║   " + '\n' +
        @"    ══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"     <o   ║   " + '\n' +
        @"      |\  ║   " + '\n' +
        @"     /<   ║   " + '\n' +
        @"          ║   " + '\n' +
        @"    ══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"     <o   ║   " + '\n' +
        @"      |\  ║   " + '\n' +
        @"     /<   ║   " + '\n' +
        @"          ║   " + '\n' +
        @"    ══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      O   ║   " + '\n' +
        @"     /|\  ║   " + '\n' +
        @"     / \  ║   " + '\n' +
        @"          ║   " + '\n' +
        @"    ══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      o   ║   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      |   ║   " + '\n' +
        @"          ║   " + '\n' +
        @"    ══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      o   ║   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      |   ║   " + '\n' +
        @"          ║   " + '\n' +
        @"    ══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      o   ║   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      |   ║   " + '\n' +
        @"          ║   " + '\n' +
        @"    ══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      o   ║   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      |   ║   " + '\n' +
        @"          ║   " + '\n' +
        @"    ══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      o   ║   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      |   ║   " + '\n' +
        @"          ║   " + '\n' +
        @"    ══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      o   ║   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      |   ║   " + '\n' +
        @"          ║   " + '\n' +
        @"    ══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      O   ║   " + '\n' +
        @"          ║   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      |   ║   " + '\n' +
        @"    ══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      O   ║   " + '\n' +
        @"          ║   " + '\n' +
        @"      /   ║   " + '\n' +
        @"      \   ║   " + '\n' +
        @"    ══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      O   ║   " + '\n' +
        @"      '   ║   " + '\n' +
        @"          ║   " + '\n' +
        @"    |__   ║   " + '\n' +
        @"    ══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      O   ║   " + '\n' +
        @"      .   ║   " + '\n' +
        @"          ║   " + '\n' +
        @"    \__   ║   " + '\n' +
        @"    ══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      O   ║   " + '\n' +
        @"          ║   " + '\n' +
        @"      '   ║   " + '\n' +
        @"   ____   ║   " + '\n' +
        @"    ══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      O   ║   " + '\n' +
        @"      '   ║   " + '\n' +
        @"      .   ║   " + '\n' +
        @"    __    ║   " + '\n' +
        @"   /══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      O   ║   " + '\n' +
        @"      .   ║   " + '\n' +
        @"          ║   " + '\n' +
        @"    _ '   ║   " + '\n' +
        @"  _/══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      O   ║   " + '\n' +
        @"          ║   " + '\n' +
        @"      '   ║   " + '\n' +
        @"      _   ║   " + '\n' +
        @" __/══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      O   ║   " + '\n' +
        @"      '   ║   " + '\n' +
        @"      .   ║   " + '\n' +
        @"          ║   " + '\n' +
        @" __/══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      O   ║   " + '\n' +
        @"      .   ║   " + '\n' +
        @"          ║   " + '\n' +
        @"      '   ║   " + '\n' +
        @" __/══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      O   ║   " + '\n' +
        @"          ║   " + '\n' +
        @"      '   ║   " + '\n' +
        @"      _   ║   " + '\n' +
        @" __/══════╩═══",

            @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      O   ║   " + '\n' +
        @"      '   ║   " + '\n' +
        @"      .   ║   " + '\n' +
        @"          ║   " + '\n' +
        @" __/══════╩═══",

        @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      O   ║   " + '\n' +
        @"      .   ║   " + '\n' +
        @"          ║   " + '\n' +
        @"      '   ║   " + '\n' +
        @" __/══════╩═══",

        @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      O   ║   " + '\n' +
        @"          ║   " + '\n' +
        @"      '   ║   " + '\n' +
        @"      _   ║   " + '\n' +
        @" __/══════╩═══",

        @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      O   ║   " + '\n' +
        @"          ║   " + '\n' +
        @"      .   ║   " + '\n' +
        @"          ║   " + '\n' +
        @" __/══════╩═══",

        @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      O   ║   " + '\n' +
        @"          ║   " + '\n' +
        @"          ║   " + '\n' +
        @"      '   ║   " + '\n' +
        @" __/══════╩═══",

        @"      ╔═══╗   " + '\n' +
        @"      |   ║   " + '\n' +
        @"      O   ║   " + '\n' +
        @"          ║   " + '\n' +
        @"          ║   " + '\n' +
        @"      _   ║   " + '\n' +
        @" __/══════╩═══"
    };

    static void DeathAnim()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;

        for (int i = 0; i < deathFrames.Length; i++)
        {
            Console.WriteLine(deathFrames[i]);
            Thread.Sleep(100);

            Console.SetCursorPosition(0, 0);
        }

        Console.ForegroundColor = ConsoleColor.White;
    }

    static string[] ReadWordsFromFile()
    {
        string currDir = Directory.GetCurrentDirectory();
        string projectDir = Directory.GetParent(currDir).Parent.Parent.FullName;

        return File.ReadAllLines($@"{projectDir}\{WordsFileName}");
    }

    static string GetRandomWord(string[] words)
    {
        Random random = new Random();

        return words[random.Next(words.Length)].ToLower();
    }

    static int CountUnderscores(string guessWord)
    {
        int count = 0;

        for(int i = 0; i < guessWord.Length; i ++)
        {
            if (guessWord[i] == Underscore)
            {
                count++;
            }
        }

        return count;
    }

    static void DrawCurrentGameState(bool isInputValid, int incorrectGuesses, string guessWord, List<char> usedLetters)
    {
        Console.Clear();
        
        Console.WriteLine(guessFrames[incorrectGuesses]);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Guess: " + guessWord);
        Console.WriteLine($"You have to guess {CountUnderscores(guessWord)} symbols");
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("The following letters are used: " + string.Join(" ", usedLetters));

        Console.Write("Your symbol: ");
    }

    static bool CheckWin(string guessWord)
    {
        return !guessWord.Contains(Underscore);
    }

    static string AddLetterToGuessWord(string guessWord, string word, char letter)
    {
        string result = "";

        for(int i = 0; i < word.Length; i ++)
        {
            if (word[i] == letter)
            {
                result += word[i];
            }
            else
            {
                result += guessWord[i];
            }
        }

        return result;
    }

    static void PlayMelody()
    {
        int noteDuration = 150;
        int pauseDuration = 50;

        Console.Beep(523, noteDuration); // C4
        Thread.Sleep(pauseDuration);

        Console.Beep(587, noteDuration); // D4
        Thread.Sleep(pauseDuration);

        Console.Beep(659, noteDuration); // E4
        Thread.Sleep(pauseDuration);

        Console.Beep(880, noteDuration); // A4
        Thread.Sleep(pauseDuration);

        Console.Beep(988, noteDuration); // B4
        Thread.Sleep(pauseDuration);

        Console.Beep(698, noteDuration); // F4
        Thread.Sleep(pauseDuration);

        Console.Beep(783, noteDuration); // G4
        Thread.Sleep(pauseDuration);

        Console.Beep(1047, noteDuration); // C5
    }

    static void PlayGame(string word, string guessWord, int incorrectGuesses, List<char> usedLetters)
    {
        DrawCurrentGameState(false, incorrectGuesses, guessWord, usedLetters);

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string input = Console.ReadLine().ToLower();
            Console.ForegroundColor = ConsoleColor.White;

            Console.Beep(2000, 100);

            if (input.Length != 1)
            {
                DrawCurrentGameState(false, incorrectGuesses, guessWord, usedLetters);
                continue;
            }

            char letter = input[0];

            if(word.Contains(letter) && !usedLetters.Contains(letter))
            {
                guessWord = AddLetterToGuessWord(guessWord, word, letter);
            }
            else
            {
                incorrectGuesses++;
            }

            usedLetters.Add(letter);

            if (incorrectGuesses == guessFrames.Length - 1)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                DeathAnim();
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(stateFrames[1]);
                Console.ForegroundColor = ConsoleColor.White;

                PlayMelody();
                Console.ForegroundColor = ConsoleColor.White;

                return;
            }

            DrawCurrentGameState(true, incorrectGuesses, guessWord, usedLetters);

            if(CheckWin(guessWord))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(stateFrames[0]);
                Console.WriteLine($"The word you guessed is [{word}].");
                Console.ForegroundColor = ConsoleColor.White;

                PlayMelody();

                return;
            }
        }
    }

    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;

        Console.CursorVisible = false;

        string[] words = ReadWordsFromFile();

        while(true)
        {
            string word = GetRandomWord(words);

            string guessWord = new(Underscore, word.Length);

            int incorrectGuesses = 0;
            List<char> usedLetters = new List<char>();

            PlayGame(word, guessWord, incorrectGuesses, usedLetters);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Play again? Y / N");

            Console.ForegroundColor = ConsoleColor.White;

            if (Console.ReadLine() == "n")
            {
                Console.Beep(2000, 100);

                Console.Clear();
                Console.WriteLine("Thank you for playing!");
                PlayMelody();
                return;
            }

            Console.Beep(2000, 100);

            Console.Clear();
        }
    }
}