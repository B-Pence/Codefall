int sleepDuration = 75;
int density = 0;
char fillerChar = ' ';
int charLang = -1;
int langAttempts = 0;
var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789.!@#$%^&*(){}[]?><+-%";
var jpChars = "アイウエオカキクケコガギグゲゴサシスセソザジズゼゾタチツテトダヂヅデドナニヌネノハヒフヘホバビブベボパピプペポマミムメモヤユtrラリルレロワヰヱヲン";
var workingString = " ";

int consoleWidth = Console.WindowWidth;
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;

string inputErrorNum = "Unexpected input type. Please enter a whole number greater than 0";
string inputErrorNumRange = "Unexpected input type. Please enter a whole number from 1 and 3";
string inputErrorChar = "Input unexpected or value to too long. Please enter a single character";

//123432
string labelLine1 = "     ░▒▓██████▓▒░ ░▒▓██████▓▒░░▒▓███████▓▒░░▒▓████████▓▒░▒▓████████▓▒░▒▓██████▓▒░░▒▓█▓▒░      ░▒▓█▓▒░        ";
string labelLine2 = "    ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░     ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░        ";
string labelLine3 = "    ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░     ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░        ";
string labelLine4 = "    ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓██████▓▒░ ░▒▓██████▓▒░░▒▓████████▓▒░▒▓█▓▒░      ░▒▓█▓▒░        ";
string labelLine5 = "     ░▒▓██████▓▒░ ░▒▓██████▓▒░░▒▓███████▓▒░░▒▓████████▓▒░▒▓█▓▒░     ░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░▒▓████████▓▒░ ";

string details = "    Rev. 1 - B-Pence";

Console.WriteLine(labelLine1);
Console.WriteLine(labelLine2);
Console.WriteLine(labelLine3);
Console.WriteLine(labelLine4);
Console.WriteLine(labelLine3);
Console.WriteLine(labelLine2);
Console.WriteLine(labelLine5);

Console.Write("\n");
Console.WriteLine(details);

while (true)
{
    try
    {
        while (charLang < 1 || charLang > 3)
        {
            if (langAttempts == 0){
                Console.Write("Select language options (1 for English, 2 for Katakana, 3 for both):");
                }
            else
            {
                Console.WriteLine(inputErrorNumRange);
                Console.Write("Select language options (1 for English, 2 for Katakana, 3 for both):");
            }
            
            langAttempts = 1;
            
            charLang = Convert.ToInt32(Console.ReadLine());
        }
        break;
    }
    catch(Exception)
    {
        Console.WriteLine(inputErrorNum);
    }
}

switch (charLang)
{
    case 1:
        workingString = chars;
        break;
    case 2:
        workingString = jpChars;
        break;
    case 3:
        workingString = chars += jpChars;
        break;
}

while (true)
{
    try
    {
        Console.Write("Enter output delay:");
        sleepDuration = Convert.ToInt32(Console.ReadLine());
        break;
    }
    catch(Exception)
    {
        Console.WriteLine(inputErrorNum);
    }
}

while (true)
{
    try
    {
        Console.Write("Enter output density (The greater the number the less dense the output):");
        density = Convert.ToInt32(Console.ReadLine());
        break;
    }
    catch(Exception)
    {
        Console.WriteLine(inputErrorNum);
    }
}

while (true)
{
    try
    {
        Console.Write("Enter filler character (Space is recommended though most characters will work):");
        fillerChar = Convert.ToChar(Console.ReadLine());
        break;
    }
    catch(Exception)
    {
        Console.WriteLine(inputErrorNum);
    }
}

for (int i = 0; i < density; i++)
{
    workingString += fillerChar;
}


while (true)
{
    var stringChars = new char[consoleWidth];
    var random = new Random();

    for (int i = 0; i < stringChars.Length; i++)
    {
        stringChars[i] = chars[random.Next(chars.Length)];
    }

    var finalString = new String(stringChars);

    Console.Write(finalString);
    
    Thread.Sleep(sleepDuration);
}