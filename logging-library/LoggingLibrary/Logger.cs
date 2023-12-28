namespace LoggingLibrary;

public class Logger
{
    private readonly LoggerConfiguration _config;

    public Logger(LoggerConfiguration loggerConfig)
    {
        _config = loggerConfig;
    }

    public void Log(LevelEnum level, string message)
    {
        Enum.TryParse(_config.LogLevel, out LevelEnum configLogLvlEnum);
        
        if(level > configLogLvlEnum)
        {
            //iterate foreach loglevel upto the level defined in enum.
            while((int)level < (int)configLogLvlEnum)
            {
                var sinkDetails = _config.GetSinkByLogLevel(level);
                //send message logic
                sinkDetails.WriteMessage(level, message); //log message level and message content when writing the message.
                level++;
            }
        }
    }
}
