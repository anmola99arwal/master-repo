namespace LoggingLibrary;

//enum to define level of Log which can be used to define in a sink.
public enum LevelEnum
{
    INFO, //for logging some information
    WARN, //for logging a warning
    ERROR, //for logging an error
    FATAL //for logging a critical error or showstoppper exception.
}
