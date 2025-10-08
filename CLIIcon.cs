public class CLIIcon
{
    

    public static string folder()
    {
        string x = "";
        if (CLISettings.Icons == 1)
        {
            x = " ";
        }
        else if (CLISettings.Icons == 2)
        {
            x = "📁";
        }
        return x;
    }
    public static void error()
    {

    }
    public static string Warn()
    {
        string x = "";
        if (CLISettings.Icons == 1)
        {
            x = "";
        }
        else if (CLISettings.Icons == 2)
        {
            x = "⚠️";
        }
        return x;
    }
}