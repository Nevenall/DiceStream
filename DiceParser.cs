//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.3.1-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Dice.g4 by ANTLR 4.5.3.1-SNAPSHOT

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3.1-SNAPSHOT")]
[System.CLSCompliant(false)]
public partial class DiceParser : Parser {
	public const int
		T__0=1, LABEL=2, NUMBER=3, SIDES=4, DEE=5, EHPH=6;
	public const int
		RULE_root = 0, RULE_dice = 1, RULE_die = 2;
	public static readonly string[] ruleNames = {
		"root", "dice", "die"
	};

	private static readonly string[] _LiteralNames = {
		null, "':'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, "LABEL", "NUMBER", "SIDES", "DEE", "EHPH"
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

	public DiceParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class RootContext : ParserRuleContext {
		public ITerminalNode LABEL() { return GetToken(DiceParser.LABEL, 0); }
		public DiceContext dice() {
			return GetRuleContext<DiceContext>(0);
		}
		public RootContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_root; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDiceVisitor<TResult> typedVisitor = visitor as IDiceVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitRoot(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public RootContext root() {
		RootContext _localctx = new RootContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_root);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 6; Match(LABEL);
			State = 7; Match(T__0);
			State = 8; dice();
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
		public ITerminalNode NUMBER() { return GetToken(DiceParser.NUMBER, 0); }
		public DieContext die() {
			return GetRuleContext<DieContext>(0);
		}
		public DiceContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_dice; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDiceVisitor<TResult> typedVisitor = visitor as IDiceVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDice(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DiceContext dice() {
		DiceContext _localctx = new DiceContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_dice);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 10; Match(NUMBER);
			State = 11; die();
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

	public partial class DieContext : ParserRuleContext {
		public ITerminalNode SIDES() { return GetToken(DiceParser.SIDES, 0); }
		public ITerminalNode DEE() { return GetToken(DiceParser.DEE, 0); }
		public ITerminalNode EHPH() { return GetToken(DiceParser.EHPH, 0); }
		public DieContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_die; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDiceVisitor<TResult> typedVisitor = visitor as IDiceVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDie(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DieContext die() {
		DieContext _localctx = new DieContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_die);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 13;
			_la = _input.La(1);
			if ( !(_la==DEE || _la==EHPH) ) {
			_errHandler.RecoverInline(this);
			} else {
				Consume();
			}
			State = 14; Match(SIDES);
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
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\b\x13\x4\x2\t\x2"+
		"\x4\x3\t\x3\x4\x4\t\x4\x3\x2\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x4"+
		"\x3\x4\x3\x4\x3\x4\x2\x2\x2\x5\x2\x2\x4\x2\x6\x2\x2\x3\x3\x2\a\b\xF\x2"+
		"\b\x3\x2\x2\x2\x4\f\x3\x2\x2\x2\x6\xF\x3\x2\x2\x2\b\t\a\x4\x2\x2\t\n\a"+
		"\x3\x2\x2\n\v\x5\x4\x3\x2\v\x3\x3\x2\x2\x2\f\r\a\x5\x2\x2\r\xE\x5\x6\x4"+
		"\x2\xE\x5\x3\x2\x2\x2\xF\x10\t\x2\x2\x2\x10\x11\a\x6\x2\x2\x11\a\x3\x2"+
		"\x2\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}