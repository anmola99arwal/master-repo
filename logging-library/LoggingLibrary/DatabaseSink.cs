namespace LoggingLibrary;

//creating a concrete implementation of Sink as  DatabaseSink class.
public class DatabaseSink : ISink
{
    public DatabaseSink()
    {
        //constructor
    }

    void OpenDatabaseSink(string path)
    {
        //logic to open the Database connection object
    }

    public void WriteMessage(LevelEnum level, string message, string namespaceNm = "")
    {
        //logic to write to Database
    }
}