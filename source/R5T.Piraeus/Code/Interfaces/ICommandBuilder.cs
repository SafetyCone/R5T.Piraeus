using System;


namespace R5T.Piraeus
{
    public interface ICommandBuilder
    {
        ICommandBuilder Append(string token);
        string BuildCommand();
    }
}
