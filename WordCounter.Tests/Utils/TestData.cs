namespace WordCounter.Tests.Utils
{ 
    public class TestData
    { 
        public static IEnumerable<object[]> Separators => new List<object[]>
        { 
            new object[] { "~" },
            new object[] { "`" },
            new object[] { "!" },
            new object[] { "@" },
            new object[] { "#" },
            new object[] { "$" },
            new object[] { "%" },
            new object[] { "^" },
            new object[] { "&" },
            new object[] { "*" },
            new object[] { "(" },
            new object[] { ")" },
            new object[] { "-" },
            new object[] { "_" },
            new object[] { "=" },
            new object[] { "+" },
            new object[] { "[" },
            new object[] { "]" },
            new object[] { "\\" },
            new object[] { ";" },
            new object[] { "\'" },
            new object[] { "," },
            new object[] { "." },
            new object[] { "/" },
            new object[] { "{ " },
            new object[] { "}" },
            new object[] { "|" },
            new object[] { ":" },
            new object[] { "\"" },
            new object[] { "<" },
            new object[] { ">" },
            new object[] { "?" },
            new object[] { " " },
            new object[] { "         " },
            new object[] { "\n" },
            new object[] { "\t" },
            new object[] { "0" },
            new object[] { "1" },
            new object[] { "2" },
            new object[] { "3" },
            new object[] { "4" },
            new object[] { "5" },
            new object[] { "6" },
            new object[] { "7" },
            new object[] { "8" },
            new object[] { "9" }
        };
        
        public static IEnumerable<object[]> AnotherAlphabetAndSeparators => new List<object[]>
        { 
            new object[] { "ナルト", "~", "サスケ"},
            new object[] { "火影忍者", "~", "佐助"},
            new object[] { "Ναρούτο", "~", "Σασούκε"},
            new object[] { "Наруто", "~", "Саске"}
        };
    }
}
