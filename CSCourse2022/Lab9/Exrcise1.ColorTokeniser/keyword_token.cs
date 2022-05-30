
namespace CSharp
{
    internal sealed class Keyword
    {
        internal static bool Match(Position begin, Position end)
        {
            int length = end - begin; 
            foreach (string keyword in keywords) {
                if (length == keyword.Length && Utility.Equal(begin, end, keyword)) {
                    return true;
                }
            }
            return false;
        }

        internal static 
        IKeywordToken MakeToken(Position begin, Position end) 
        { 
            return new KeywordToken(begin, end); 
        }
        
        private sealed class KeywordToken : Token, IKeywordToken
        {
            internal KeywordToken(Position begin, Position end)
              : base(begin, end)
            {
            }
        
            internal override void Accept(ITokenVisitor visitor)
            {
                visitor.Visit(this);
            }
        }
        
        private Keyword() {}
        
        private static readonly string[] keywords = new string[]
        {
            "abstract",
            "as",
            "base",
            "bool",
            "break",
            "byte",
            "case",
            "catch",
            "char",
            "checked",
            "class",
            "const",
            "continue",
            "decimal",
            "default",
            "delegate",
            "do",
            "double",
            "else",
            "enum",
            "event",
            "explicit",
            "extern",
            "false",
            "finally",
            "fixed",
            "float",
            "for",
            "foreach",
            "goto",
            "if",
            "implicit",
            "in",
            "int",
            "interface",
            "internal",
            "is",
            "lock",
            "long",
            "namespace",
            "new",
            "null",
            "object",
            "operator",
            "out",
            "override",
            "params",
            "private",
            "protected",
            "public",
            "readonly",
            "ref",
            "return",
            "sbyte",
            "sealed",
            "short",
            "sizeof",
            "stackalloc",
            "static",
            "string",
            "struct",
            "switch",
            "this",
            "throw",
            "true",
            "try",
            "typeof",
            "uint",
            "ulong",
            "unchecked",
            "unsafe",
            "ushort",
            "using",
            "virtual",
            "void",
            "while",
        };
    }
}
