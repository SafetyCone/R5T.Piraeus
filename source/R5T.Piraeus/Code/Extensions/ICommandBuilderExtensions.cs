using System;


namespace R5T.Piraeus
{
    public static class ICommandBuilderExtensions
    {
        /// <summary>
        /// Properly quotes a path token.
        /// Surrounds the provided path with quotes in case of spaces in the path.
        /// </summary>
        public static void AppendPath(this ICommandBuilder commandBuilder, string path)
        {
            var appendix = $"\"{path}\"";

            commandBuilder.Append(appendix);
        }
    }
}
