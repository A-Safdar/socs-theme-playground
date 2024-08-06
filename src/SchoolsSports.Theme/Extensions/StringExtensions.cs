using Ardalis.GuardClauses;

namespace SchoolsSports.Theme.Extensions;

public static class StringExtensions
{
    public static string FirstCharToUpper(this string input)
    {
        Guard.Against.NullOrEmpty(input, nameof(input));

        var inputParts = input.ToCharArray();
        inputParts[0] = char.ToUpper(inputParts[0]);
        return new string(inputParts);
    }
}