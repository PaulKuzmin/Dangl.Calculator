//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Calculator.g4 by ANTLR 4.7.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419


#pragma warning disable 0419
#pragma warning disable 3021
#pragma warning disable 1574
#pragma warning disable 1591
#pragma warning disable 1658
#pragma warning disable 1584
#pragma warning disable 0108

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="CalculatorParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public interface ICalculatorListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalculatorParser.calculator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCalculator([NotNull] CalculatorParser.CalculatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalculatorParser.calculator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCalculator([NotNull] CalculatorParser.CalculatorContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Tan</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTan([NotNull] CalculatorParser.TanContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Tan</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTan([NotNull] CalculatorParser.TanContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Cosh</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCosh([NotNull] CalculatorParser.CoshContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Cosh</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCosh([NotNull] CalculatorParser.CoshContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>SqRoot</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSqRoot([NotNull] CalculatorParser.SqRootContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SqRoot</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSqRoot([NotNull] CalculatorParser.SqRootContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NegExponent</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNegExponent([NotNull] CalculatorParser.NegExponentContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NegExponent</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNegExponent([NotNull] CalculatorParser.NegExponentContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Exponent</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExponent([NotNull] CalculatorParser.ExponentContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Exponent</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExponent([NotNull] CalculatorParser.ExponentContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Arctan2</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArctan2([NotNull] CalculatorParser.Arctan2Context context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Arctan2</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArctan2([NotNull] CalculatorParser.Arctan2Context context);
	/// <summary>
	/// Enter a parse tree produced by the <c>MulDiv</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMulDiv([NotNull] CalculatorParser.MulDivContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>MulDiv</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMulDiv([NotNull] CalculatorParser.MulDivContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Arcsin</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArcsin([NotNull] CalculatorParser.ArcsinContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Arcsin</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArcsin([NotNull] CalculatorParser.ArcsinContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>UnaryPlus</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnaryPlus([NotNull] CalculatorParser.UnaryPlusContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>UnaryPlus</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnaryPlus([NotNull] CalculatorParser.UnaryPlusContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Arccot</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArccot([NotNull] CalculatorParser.ArccotContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Arccot</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArccot([NotNull] CalculatorParser.ArccotContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Arccos</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArccos([NotNull] CalculatorParser.ArccosContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Arccos</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArccos([NotNull] CalculatorParser.ArccosContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Euler</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEuler([NotNull] CalculatorParser.EulerContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Euler</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEuler([NotNull] CalculatorParser.EulerContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Arctan</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArctan([NotNull] CalculatorParser.ArctanContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Arctan</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArctan([NotNull] CalculatorParser.ArctanContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Parenthesis</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenthesis([NotNull] CalculatorParser.ParenthesisContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Parenthesis</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenthesis([NotNull] CalculatorParser.ParenthesisContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Abs</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAbs([NotNull] CalculatorParser.AbsContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Abs</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAbs([NotNull] CalculatorParser.AbsContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Number</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumber([NotNull] CalculatorParser.NumberContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Number</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumber([NotNull] CalculatorParser.NumberContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Substitution</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubstitution([NotNull] CalculatorParser.SubstitutionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Substitution</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubstitution([NotNull] CalculatorParser.SubstitutionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Sinh</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSinh([NotNull] CalculatorParser.SinhContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Sinh</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSinh([NotNull] CalculatorParser.SinhContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Round</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRound([NotNull] CalculatorParser.RoundContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Round</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRound([NotNull] CalculatorParser.RoundContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Trunc</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTrunc([NotNull] CalculatorParser.TruncContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Trunc</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTrunc([NotNull] CalculatorParser.TruncContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Pi</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPi([NotNull] CalculatorParser.PiContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Pi</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPi([NotNull] CalculatorParser.PiContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Tanh</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTanh([NotNull] CalculatorParser.TanhContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Tanh</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTanh([NotNull] CalculatorParser.TanhContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Floor</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFloor([NotNull] CalculatorParser.FloorContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Floor</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFloor([NotNull] CalculatorParser.FloorContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Ln</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLn([NotNull] CalculatorParser.LnContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Ln</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLn([NotNull] CalculatorParser.LnContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Mod</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMod([NotNull] CalculatorParser.ModContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Mod</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMod([NotNull] CalculatorParser.ModContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Log</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLog([NotNull] CalculatorParser.LogContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Log</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLog([NotNull] CalculatorParser.LogContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>AddSub</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddSub([NotNull] CalculatorParser.AddSubContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AddSub</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddSub([NotNull] CalculatorParser.AddSubContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Cos</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCos([NotNull] CalculatorParser.CosContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Cos</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCos([NotNull] CalculatorParser.CosContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Deg</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeg([NotNull] CalculatorParser.DegContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Deg</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeg([NotNull] CalculatorParser.DegContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Sqrt</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSqrt([NotNull] CalculatorParser.SqrtContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Sqrt</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSqrt([NotNull] CalculatorParser.SqrtContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Cot</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCot([NotNull] CalculatorParser.CotContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Cot</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCot([NotNull] CalculatorParser.CotContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Whole</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhole([NotNull] CalculatorParser.WholeContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Whole</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhole([NotNull] CalculatorParser.WholeContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Unary</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnary([NotNull] CalculatorParser.UnaryContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Unary</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnary([NotNull] CalculatorParser.UnaryContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Rad</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRad([NotNull] CalculatorParser.RadContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Rad</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRad([NotNull] CalculatorParser.RadContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Mult</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMult([NotNull] CalculatorParser.MultContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Mult</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMult([NotNull] CalculatorParser.MultContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Sqr</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSqr([NotNull] CalculatorParser.SqrContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Sqr</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSqr([NotNull] CalculatorParser.SqrContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Sin</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSin([NotNull] CalculatorParser.SinContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Sin</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSin([NotNull] CalculatorParser.SinContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Eex</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEex([NotNull] CalculatorParser.EexContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Eex</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEex([NotNull] CalculatorParser.EexContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Pow</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPow([NotNull] CalculatorParser.PowContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Pow</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPow([NotNull] CalculatorParser.PowContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Ceil</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCeil([NotNull] CalculatorParser.CeilContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Ceil</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCeil([NotNull] CalculatorParser.CeilContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Exp</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExp([NotNull] CalculatorParser.ExpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Exp</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExp([NotNull] CalculatorParser.ExpContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Roundk</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRoundk([NotNull] CalculatorParser.RoundkContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Roundk</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRoundk([NotNull] CalculatorParser.RoundkContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalculatorParser.trailingComment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTrailingComment([NotNull] CalculatorParser.TrailingCommentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalculatorParser.trailingComment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTrailingComment([NotNull] CalculatorParser.TrailingCommentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalculatorParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompileUnit([NotNull] CalculatorParser.CompileUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalculatorParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompileUnit([NotNull] CalculatorParser.CompileUnitContext context);
}
