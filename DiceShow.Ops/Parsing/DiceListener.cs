//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.4-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Dice.g4 by ANTLR 4.5.4-SNAPSHOT

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace DiceShow.Ops.Parsing.Internal {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="DiceParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.4-SNAPSHOT")]
[System.CLSCompliant(false)]
public interface IDiceListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>Hit</c>
	/// labeled alternative in <see cref="DiceParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHit([NotNull] DiceParser.HitContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Hit</c>
	/// labeled alternative in <see cref="DiceParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHit([NotNull] DiceParser.HitContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Count</c>
	/// labeled alternative in <see cref="DiceParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCount([NotNull] DiceParser.CountContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Count</c>
	/// labeled alternative in <see cref="DiceParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCount([NotNull] DiceParser.CountContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Drop</c>
	/// labeled alternative in <see cref="DiceParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop([NotNull] DiceParser.DropContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Drop</c>
	/// labeled alternative in <see cref="DiceParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop([NotNull] DiceParser.DropContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Explode</c>
	/// labeled alternative in <see cref="DiceParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExplode([NotNull] DiceParser.ExplodeContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Explode</c>
	/// labeled alternative in <see cref="DiceParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExplode([NotNull] DiceParser.ExplodeContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AddScalar</c>
	/// labeled alternative in <see cref="DiceParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddScalar([NotNull] DiceParser.AddScalarContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AddScalar</c>
	/// labeled alternative in <see cref="DiceParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddScalar([NotNull] DiceParser.AddScalarContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Reroll</c>
	/// labeled alternative in <see cref="DiceParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReroll([NotNull] DiceParser.RerollContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Reroll</c>
	/// labeled alternative in <see cref="DiceParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReroll([NotNull] DiceParser.RerollContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AddDiceExp</c>
	/// labeled alternative in <see cref="DiceParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddDiceExp([NotNull] DiceParser.AddDiceExpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AddDiceExp</c>
	/// labeled alternative in <see cref="DiceParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddDiceExp([NotNull] DiceParser.AddDiceExpContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>SubScalar</c>
	/// labeled alternative in <see cref="DiceParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubScalar([NotNull] DiceParser.SubScalarContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SubScalar</c>
	/// labeled alternative in <see cref="DiceParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubScalar([NotNull] DiceParser.SubScalarContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Keep</c>
	/// labeled alternative in <see cref="DiceParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKeep([NotNull] DiceParser.KeepContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Keep</c>
	/// labeled alternative in <see cref="DiceParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKeep([NotNull] DiceParser.KeepContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>SubDiceExp</c>
	/// labeled alternative in <see cref="DiceParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubDiceExp([NotNull] DiceParser.SubDiceExpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SubDiceExp</c>
	/// labeled alternative in <see cref="DiceParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubDiceExp([NotNull] DiceParser.SubDiceExpContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Lowest</c>
	/// labeled alternative in <see cref="DiceParser.target"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLowest([NotNull] DiceParser.LowestContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Lowest</c>
	/// labeled alternative in <see cref="DiceParser.target"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLowest([NotNull] DiceParser.LowestContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>TargetInt</c>
	/// labeled alternative in <see cref="DiceParser.target"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTargetInt([NotNull] DiceParser.TargetIntContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>TargetInt</c>
	/// labeled alternative in <see cref="DiceParser.target"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTargetInt([NotNull] DiceParser.TargetIntContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Highest</c>
	/// labeled alternative in <see cref="DiceParser.target"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHighest([NotNull] DiceParser.HighestContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Highest</c>
	/// labeled alternative in <see cref="DiceParser.target"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHighest([NotNull] DiceParser.HighestContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DiceParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] DiceParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DiceParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] DiceParser.StatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DiceParser.dice"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDice([NotNull] DiceParser.DiceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DiceParser.dice"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDice([NotNull] DiceParser.DiceContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DiceParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] DiceParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DiceParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] DiceParser.ExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DiceParser.diceExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDiceExp([NotNull] DiceParser.DiceExpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DiceParser.diceExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDiceExp([NotNull] DiceParser.DiceExpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DiceParser.target"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTarget([NotNull] DiceParser.TargetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DiceParser.target"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTarget([NotNull] DiceParser.TargetContext context);
}
} // namespace DiceShow.Ops.Parsing.Internal
