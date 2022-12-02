using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace Devantler.DataMesh.DataProduct.SourceGenerator.Extensions;

public static class StringExtensions
{
    public static string IndentBy(this string text, int spaces = 4) =>
        text.Replace(Environment.NewLine, Environment.NewLine + new string(' ', spaces));

    public static string ToPascalCase(this string text)
    {
        // Find word parts using the following rules:
        // 1. all lowercase starting at the beginning is a word
        // 2. all caps is a word.
        // 3. first letter caps, followed by all lowercase is a word
        // 4. the entire string must decompose into words according to 1,2,3.
        // Note that 2&3 together ensure MPSUser is parsed as "MPS" + "User".

        var matches = Regex.Match(text, "^(?<word>^[a-z]+|[A-Z]+|[A-Z][a-z]+)+$");
        var groupCollection = matches.Groups["word"];

        // Take each word and convert individually to TitleCase
        // to generate the final output.  Note the use of ToLower
        // before ToTitleCase because all caps is treated as an abbreviation.
        var textInfo = Thread.CurrentThread.CurrentCulture.TextInfo;
        var builder = new StringBuilder();
        foreach (var capture in groupCollection.Captures.Cast<Capture>())
            builder.Append(textInfo.ToTitleCase(capture.Value.ToLower()));
        return builder.ToString();
    }

    public static string ToPlural(this string text)
    {
        if (text.EndsWith("s", StringComparison.OrdinalIgnoreCase))
            return text + "es";
        return text + "s";
    }
}
