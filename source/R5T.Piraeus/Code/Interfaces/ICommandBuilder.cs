using System;


namespace R5T.Piraeus
{
    public interface ICommandBuilder
    {
        void Append(string token);
        string BuildCommand();
    }
}
