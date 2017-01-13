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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.4-SNAPSHOT")]
[System.CLSCompliant(false)]
public partial class DiceParser : Parser {
	public const int
		T__0=1, T__1=2, DROP=3, KEEP=4, COUNT=5, REROLL=6, EXPLODE=7, HIT=8, LOWEST=9, 
		HIGHEST=10, ID=11, INT=12, PLUS=13, PLUSPLUS=14, MINUS=15, MINUSMINUS=16, 
		WS=17;
	public const int
		RULE_statement = 0, RULE_dice = 1, RULE_expression = 2, RULE_diceExp = 3, 
		RULE_target = 4;
	public static readonly string[] ruleNames = {
		"statement", "dice", "expression", "diceExp", "target"
	};

	private static readonly string[] _LiteralNames = {
		null, "'d'", "'D'", null, null, null, null, null, null, null, null, null, 
		null, "'+'", "'++'", "'-'", "'--'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, "DROP", "KEEP", "COUNT", "REROLL", "EXPLODE", "HIT", 
		"LOWEST", "HIGHEST", "ID", "INT", "PLUS", "PLUSPLUS", "MINUS", "MINUSMINUS", 
		"WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Dice.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	  
		public const string GrammarVersion = "1.0.0";
		public const string VersionReleaseNotes = @"
			1.0.0 - Support for expression and result keywords
			0.1.2 - removed ; as a SEPARATOR option
			0.1.1 - Moved SEPARATOR
			0.1.0 - Multiple dice in groups with optional labels.
		";

	public DiceParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class StatementContext : ParserRuleContext {
		public DiceContext[] dice() {
			return GetRuleContexts<DiceContext>();
		}
		public DiceContext dice(int i) {
			return GetRuleContext<DiceContext>(i);
		}
		public StatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statement; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.EnterStatement(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.ExitStatement(this);
		}
	}

	[RuleVersion(0)]
	public StatementContext statement() {
		StatementContext _localctx = new StatementContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_statement);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 11;
			_errHandler.Sync(this);
			_la = _input.La(1);
			do {
				{
				{
				State = 10; dice();
				}
				}
				State = 13;
				_errHandler.Sync(this);
				_la = _input.La(1);
			} while ( _la==ID || _la==INT );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DiceContext : ParserRuleContext {
		public ITerminalNode[] INT() { return GetTokens(DiceParser.INT); }
		public ITerminalNode INT(int i) {
			return GetToken(DiceParser.INT, i);
		}
		public ITerminalNode ID() { return GetToken(DiceParser.ID, 0); }
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public DiceContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_dice; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.EnterDice(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.ExitDice(this);
		}
	}

	[RuleVersion(0)]
	public DiceContext dice() {
		DiceContext _localctx = new DiceContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_dice);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 16;
			_la = _input.La(1);
			if (_la==ID) {
				{
				State = 15; Match(ID);
				}
			}

			State = 18; Match(INT);
			State = 19;
			_la = _input.La(1);
			if ( !(_la==T__0 || _la==T__1) ) {
			_errHandler.RecoverInline(this);
			} else {
				Consume();
			}
			State = 20; Match(INT);
			State = 22;
			_la = _input.La(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << DROP) | (1L << KEEP) | (1L << COUNT) | (1L << REROLL) | (1L << EXPLODE) | (1L << HIT) | (1L << PLUS) | (1L << MINUS))) != 0)) {
				{
				State = 21; expression();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExpressionContext : ParserRuleContext {
		public ExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expression; } }
	 
		public ExpressionContext() { }
		public virtual void CopyFrom(ExpressionContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class HitContext : ExpressionContext {
		public ITerminalNode HIT() { return GetToken(DiceParser.HIT, 0); }
		public ITerminalNode INT() { return GetToken(DiceParser.INT, 0); }
		public ITerminalNode PLUS() { return GetToken(DiceParser.PLUS, 0); }
		public ITerminalNode MINUS() { return GetToken(DiceParser.MINUS, 0); }
		public HitContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.EnterHit(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.ExitHit(this);
		}
	}
	public partial class CountContext : ExpressionContext {
		public ITerminalNode COUNT() { return GetToken(DiceParser.COUNT, 0); }
		public TargetContext target() {
			return GetRuleContext<TargetContext>(0);
		}
		public CountContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.EnterCount(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.ExitCount(this);
		}
	}
	public partial class DropContext : ExpressionContext {
		public ITerminalNode DROP() { return GetToken(DiceParser.DROP, 0); }
		public TargetContext target() {
			return GetRuleContext<TargetContext>(0);
		}
		public DropContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.EnterDrop(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.ExitDrop(this);
		}
	}
	public partial class ExplodeContext : ExpressionContext {
		public ITerminalNode EXPLODE() { return GetToken(DiceParser.EXPLODE, 0); }
		public TargetContext target() {
			return GetRuleContext<TargetContext>(0);
		}
		public ExplodeContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.EnterExplode(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.ExitExplode(this);
		}
	}
	public partial class AddScalarContext : ExpressionContext {
		public ITerminalNode PLUS() { return GetToken(DiceParser.PLUS, 0); }
		public ITerminalNode INT() { return GetToken(DiceParser.INT, 0); }
		public AddScalarContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.EnterAddScalar(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.ExitAddScalar(this);
		}
	}
	public partial class RerollContext : ExpressionContext {
		public ITerminalNode REROLL() { return GetToken(DiceParser.REROLL, 0); }
		public TargetContext target() {
			return GetRuleContext<TargetContext>(0);
		}
		public RerollContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.EnterReroll(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.ExitReroll(this);
		}
	}
	public partial class AddDiceExpContext : ExpressionContext {
		public ITerminalNode PLUS() { return GetToken(DiceParser.PLUS, 0); }
		public DiceExpContext diceExp() {
			return GetRuleContext<DiceExpContext>(0);
		}
		public AddDiceExpContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.EnterAddDiceExp(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.ExitAddDiceExp(this);
		}
	}
	public partial class SubScalarContext : ExpressionContext {
		public ITerminalNode MINUS() { return GetToken(DiceParser.MINUS, 0); }
		public ITerminalNode INT() { return GetToken(DiceParser.INT, 0); }
		public SubScalarContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.EnterSubScalar(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.ExitSubScalar(this);
		}
	}
	public partial class KeepContext : ExpressionContext {
		public ITerminalNode KEEP() { return GetToken(DiceParser.KEEP, 0); }
		public TargetContext target() {
			return GetRuleContext<TargetContext>(0);
		}
		public KeepContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.EnterKeep(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.ExitKeep(this);
		}
	}
	public partial class SubDiceExpContext : ExpressionContext {
		public ITerminalNode MINUS() { return GetToken(DiceParser.MINUS, 0); }
		public DiceExpContext diceExp() {
			return GetRuleContext<DiceExpContext>(0);
		}
		public SubDiceExpContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.EnterSubDiceExp(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.ExitSubDiceExp(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionContext expression() {
		ExpressionContext _localctx = new ExpressionContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_expression);
		int _la;
		try {
			State = 45;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,3,_ctx) ) {
			case 1:
				_localctx = new AddScalarContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 24; Match(PLUS);
				State = 25; Match(INT);
				}
				break;

			case 2:
				_localctx = new SubScalarContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 26; Match(MINUS);
				State = 27; Match(INT);
				}
				break;

			case 3:
				_localctx = new AddDiceExpContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 28; Match(PLUS);
				State = 29; diceExp();
				}
				break;

			case 4:
				_localctx = new SubDiceExpContext(_localctx);
				EnterOuterAlt(_localctx, 4);
				{
				State = 30; Match(MINUS);
				State = 31; diceExp();
				}
				break;

			case 5:
				_localctx = new DropContext(_localctx);
				EnterOuterAlt(_localctx, 5);
				{
				State = 32; Match(DROP);
				State = 33; target();
				}
				break;

			case 6:
				_localctx = new KeepContext(_localctx);
				EnterOuterAlt(_localctx, 6);
				{
				State = 34; Match(KEEP);
				State = 35; target();
				}
				break;

			case 7:
				_localctx = new CountContext(_localctx);
				EnterOuterAlt(_localctx, 7);
				{
				State = 36; Match(COUNT);
				State = 37; target();
				}
				break;

			case 8:
				_localctx = new RerollContext(_localctx);
				EnterOuterAlt(_localctx, 8);
				{
				State = 38; Match(REROLL);
				State = 39; target();
				}
				break;

			case 9:
				_localctx = new ExplodeContext(_localctx);
				EnterOuterAlt(_localctx, 9);
				{
				State = 40; Match(EXPLODE);
				State = 41; target();
				}
				break;

			case 10:
				_localctx = new HitContext(_localctx);
				EnterOuterAlt(_localctx, 10);
				{
				State = 42; Match(HIT);
				State = 43; Match(INT);
				State = 44;
				_la = _input.La(1);
				if ( !(_la==PLUS || _la==MINUS) ) {
				_errHandler.RecoverInline(this);
				} else {
					Consume();
				}
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DiceExpContext : ParserRuleContext {
		public ITerminalNode[] INT() { return GetTokens(DiceParser.INT); }
		public ITerminalNode INT(int i) {
			return GetToken(DiceParser.INT, i);
		}
		public DiceExpContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_diceExp; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.EnterDiceExp(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.ExitDiceExp(this);
		}
	}

	[RuleVersion(0)]
	public DiceExpContext diceExp() {
		DiceExpContext _localctx = new DiceExpContext(_ctx, State);
		EnterRule(_localctx, 6, RULE_diceExp);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 47; Match(INT);
			State = 48;
			_la = _input.La(1);
			if ( !(_la==T__0 || _la==T__1) ) {
			_errHandler.RecoverInline(this);
			} else {
				Consume();
			}
			State = 49; Match(INT);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TargetContext : ParserRuleContext {
		public ITerminalNode INT() { return GetToken(DiceParser.INT, 0); }
		public ITerminalNode PLUS() { return GetToken(DiceParser.PLUS, 0); }
		public ITerminalNode MINUS() { return GetToken(DiceParser.MINUS, 0); }
		public ITerminalNode PLUSPLUS() { return GetToken(DiceParser.PLUSPLUS, 0); }
		public ITerminalNode MINUSMINUS() { return GetToken(DiceParser.MINUSMINUS, 0); }
		public ITerminalNode LOWEST() { return GetToken(DiceParser.LOWEST, 0); }
		public ITerminalNode HIGHEST() { return GetToken(DiceParser.HIGHEST, 0); }
		public TargetContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_target; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.EnterTarget(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.ExitTarget(this);
		}
	}

	[RuleVersion(0)]
	public TargetContext target() {
		TargetContext _localctx = new TargetContext(_ctx, State);
		EnterRule(_localctx, 8, RULE_target);
		int _la;
		try {
			State = 55;
			switch (_input.La(1)) {
			case INT:
				EnterOuterAlt(_localctx, 1);
				{
				State = 51; Match(INT);
				State = 52;
				_la = _input.La(1);
				if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << PLUS) | (1L << PLUSPLUS) | (1L << MINUS) | (1L << MINUSMINUS))) != 0)) ) {
				_errHandler.RecoverInline(this);
				} else {
					Consume();
				}
				}
				break;
			case LOWEST:
				EnterOuterAlt(_localctx, 2);
				{
				State = 53; Match(LOWEST);
				}
				break;
			case HIGHEST:
				EnterOuterAlt(_localctx, 3);
				{
				State = 54; Match(HIGHEST);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\x13<\x4\x2\t\x2"+
		"\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x3\x2\x6\x2\xE\n\x2\r\x2"+
		"\xE\x2\xF\x3\x3\x5\x3\x13\n\x3\x3\x3\x3\x3\x3\x3\x3\x3\x5\x3\x19\n\x3"+
		"\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3"+
		"\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x5\x4\x30\n"+
		"\x4\x3\x5\x3\x5\x3\x5\x3\x5\x3\x6\x3\x6\x3\x6\x3\x6\x5\x6:\n\x6\x3\x6"+
		"\x2\x2\x2\a\x2\x2\x4\x2\x6\x2\b\x2\n\x2\x2\x5\x3\x2\x3\x4\x4\x2\xF\xF"+
		"\x11\x11\x3\x2\xF\x12\x44\x2\r\x3\x2\x2\x2\x4\x12\x3\x2\x2\x2\x6/\x3\x2"+
		"\x2\x2\b\x31\x3\x2\x2\x2\n\x39\x3\x2\x2\x2\f\xE\x5\x4\x3\x2\r\f\x3\x2"+
		"\x2\x2\xE\xF\x3\x2\x2\x2\xF\r\x3\x2\x2\x2\xF\x10\x3\x2\x2\x2\x10\x3\x3"+
		"\x2\x2\x2\x11\x13\a\r\x2\x2\x12\x11\x3\x2\x2\x2\x12\x13\x3\x2\x2\x2\x13"+
		"\x14\x3\x2\x2\x2\x14\x15\a\xE\x2\x2\x15\x16\t\x2\x2\x2\x16\x18\a\xE\x2"+
		"\x2\x17\x19\x5\x6\x4\x2\x18\x17\x3\x2\x2\x2\x18\x19\x3\x2\x2\x2\x19\x5"+
		"\x3\x2\x2\x2\x1A\x1B\a\xF\x2\x2\x1B\x30\a\xE\x2\x2\x1C\x1D\a\x11\x2\x2"+
		"\x1D\x30\a\xE\x2\x2\x1E\x1F\a\xF\x2\x2\x1F\x30\x5\b\x5\x2 !\a\x11\x2\x2"+
		"!\x30\x5\b\x5\x2\"#\a\x5\x2\x2#\x30\x5\n\x6\x2$%\a\x6\x2\x2%\x30\x5\n"+
		"\x6\x2&\'\a\a\x2\x2\'\x30\x5\n\x6\x2()\a\b\x2\x2)\x30\x5\n\x6\x2*+\a\t"+
		"\x2\x2+\x30\x5\n\x6\x2,-\a\n\x2\x2-.\a\xE\x2\x2.\x30\t\x3\x2\x2/\x1A\x3"+
		"\x2\x2\x2/\x1C\x3\x2\x2\x2/\x1E\x3\x2\x2\x2/ \x3\x2\x2\x2/\"\x3\x2\x2"+
		"\x2/$\x3\x2\x2\x2/&\x3\x2\x2\x2/(\x3\x2\x2\x2/*\x3\x2\x2\x2/,\x3\x2\x2"+
		"\x2\x30\a\x3\x2\x2\x2\x31\x32\a\xE\x2\x2\x32\x33\t\x2\x2\x2\x33\x34\a"+
		"\xE\x2\x2\x34\t\x3\x2\x2\x2\x35\x36\a\xE\x2\x2\x36:\t\x4\x2\x2\x37:\a"+
		"\v\x2\x2\x38:\a\f\x2\x2\x39\x35\x3\x2\x2\x2\x39\x37\x3\x2\x2\x2\x39\x38"+
		"\x3\x2\x2\x2:\v\x3\x2\x2\x2\a\xF\x12\x18/\x39";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace DiceShow.Ops.Parsing.Internal
