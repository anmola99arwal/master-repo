namespace LoggingLibrary;

public class LoggerConfiguration
{
    //use to store mapping of Sink with its Log Level.
    private Dictionary<LevelEnum, ISink> _mappingSinkLoglevel;

    //property to set a logging level for the type of sink.
    //Needs to be called from conrete Sink implementation like FileSink, etc.
    public string LogLevel {get;set;}



    public void MapLevelToSink(LevelEnum level, ISink sink)
    {
        //use mappingSinkLoglevel Dictionary 
        //logic to map a log level to the type of sink initialized.
    }

    public ISink GetSinkByLogLevel(LevelEnum level)
    {
        //use mappingSinkLoglevel Dictionary to retrieve the Sink type.
        return new FileSink(); // for example
    }
}
