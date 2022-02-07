namespace Minsk.CodeAnalysis.Syntax
{
  public enum SyntaxKind
  {
    // Tokens
    BadToken,
    EndOfFileToken,
    WhiteSpaceToken,
    NumberToken,
    PlusToken,
    MinusToken,
    StarToken,
    SlashToken,
    OpenParenthesisToken,
    CloseParenthesisToken,

    //Expressions
    LiteralExpression,
    BinaryExpression,
    ParenthesizedExpression,
    UnaryExpression
  }
}