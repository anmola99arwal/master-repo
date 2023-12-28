namespace LoggingLibrary;

public interface ISink
{
    //A common write method to define basic logic to write the logs in a sink.
    void WriteMessage(LevelEnum level, string message, string namespaceNm = "");
}
