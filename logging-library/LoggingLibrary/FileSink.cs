namespace LoggingLibrary;

//creating a concrete implementation of Sink as  FileSink class.
public class FileSink : ISink
{
    public FileSink()
    {
        //constructor
    }

    void OpenFileSink(string path)
    {
        //logic to open the file 
    }

    public void WriteMessage(LevelEnum level, string message, string namespaceNm = "")
    {
        //logic to write to file
    }
}