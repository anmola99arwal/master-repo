namespace LoggingLibrary;

//creating a concrete implementation of Sink as  ConsoleSink class.
public class ConsoleSink : ISink
{
    public ConsoleSink()
    {
        //constructor
    }

    void OpenConsoleSink(string path)
    {
        //logic to create new console object
    }

    public void WriteMessage(LevelEnum level, string message, string namespaceNm = "")
    {
        //logic to write to Console
    }
}