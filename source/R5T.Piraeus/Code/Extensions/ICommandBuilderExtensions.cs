using System;


namespace R5T.Piraeus.Extensions
{
    public static class ICommandBuilderExtensions
    {
        /// <summary>
        /// Properly quotes a path token.
        /// Surrounds the provided path with quotes in case of spaces in the path.
        /// </summary>
        public static ICommandBuilder AppendPath(this ICommandBuilder commandBuilder, string path)
        {
            commandBuilder.AppendQuotedValue(path);
            return commandBuilder;
        }

        public static ICommandBuilder AppendQuotedValue(this ICommandBuilder commandBuilder, string value)
        {
            var appendix = $"\"{value}\"";

            commandBuilder.Append(appendix);

            return commandBuilder;
        }

        public static ICommandBuilder AppendNameValuePair(this ICommandBuilder commandBuilder, string name, string value)
        {
            commandBuilder
                .Append(name)
                .Append(value)
                ;

            return commandBuilder;
        }

        public static ICommandBuilder AppendNamePathValuePair(this ICommandBuilder commandBuilder, string name, string path)
        {
            commandBuilder
                .Append(name)
                .AppendPath(path)
                ;

            return commandBuilder;
        }

        public static ICommandBuilder AppendNameQuotedValuePair(this ICommandBuilder commandBuilder, string name, string value)
        {
            commandBuilder
                .Append(name)
                .AppendQuotedValue(value)
                ;

            return commandBuilder;
        }
    }
}
