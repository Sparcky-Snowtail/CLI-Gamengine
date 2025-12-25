using System.Security.Cryptography;

public class CLISaves
{
    public static void SaveGame(string fileLocation, string fileName){

    }

    public static void Save(string fileLocation){ // file location for game engine save
        bool debug = CLISettings.Debug;
        bool moddingIsOn =CLISettings.moddingIsOn;

    }

    public static void LoadGame(string fileLocation){ 
        
    }
    public static void Load(string fileLocation){ // file location for game engine load
        bool debug = CLISettings.Debug;
        bool moddingIsOn =CLISettings.moddingIsOn;

    }
    public static bool LoadWarningVersionIssue(string fileversion){
        // ceanter text
        bool proceed = false;
        Console.ForegroundColor = ConsoleColor.Yellow;
        CLIText.print("==============================================", 0, true);
        CLIText.print("| Warning: ", 0, false);
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        CLIText.print("Save file version issue detected!", 15, false);
        Console.ForegroundColor = ConsoleColor.Yellow;
        CLIText.print(" |", 0, true);
        CLIText.print("==============================================", 0, true);
        Console.ResetColor();
        CLIText.print("File version:" , 15, false);
        Console.ForegroundColor = ConsoleColor.Red;
        CLIText.print(fileversion, 15, false);
        Console.ResetColor();
        CLIText.print(" Game Verion:", 15, false);
        Console.ForegroundColor = ConsoleColor.Green;
        CLIText.print(CLIConfig.majorVersion + "." + CLIConfig.version + "." + CLIConfig.minorVersion, 15, true);
        Console.ResetColor();
        CLIText.print("Continue Loading", 30, false);
        Console.ForegroundColor = ConsoleColor.Green;
        CLIText.print(" Y", 15, false);
        Console.ResetColor();
        CLIText.print("/", 15, false);
        Console.ForegroundColor = ConsoleColor.Red;
        CLIText.print("N", 15, false);
        Console.ResetColor();
        CLIText.print(":", 15, false);
        switch (Console.ReadLine())
        {
            case "Y":
            case "y":
            case "Yes":
            case "yes":
            case "YEs":
            case "YES":
                proceed = true;
                break;
            case "N":
            case "n":
            case "No":
            case "no":
            case "NO":
                proceed = false;
                break;
            default:
                CLIText.print("Invalid input loding Cansled", 15, true);
                proceed = false;
                break;
        };
        return proceed;
    }
}