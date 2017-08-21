using System.IO;
using Stone;
using Stone.AST;
using Stone.Parsers;
using Stone.Tokens;
using Xunit;

namespace Stone.Tests
{
    public class FunctionParserTest
    {
        [Fact]
        public void Parse()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "samples/lexer3.st");
            Lexer lexer = new Lexer(new FileStream(filePath, FileMode.Open, FileAccess.Read));
            FunctionParser functionParser = new FunctionParser();

            while (lexer.Peek(0) != Token.EOF)
            {
                ASTNode astNode = functionParser.Parse(lexer);

                System.Console.WriteLine(astNode.ToString());
            }
        }
    }
}