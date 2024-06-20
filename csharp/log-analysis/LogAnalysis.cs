using System;

public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delimitter) =>
        str.Split(delimitter)[1];
      
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string delimitter1, string delimitter2) =>
        str.Split(delimitter1)[1].Split(delimitter2)[0];
    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str) =>
        str.SubstringAfter(": ");

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str) =>
        str.SubstringBetween("[", "]");
}