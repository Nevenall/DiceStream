
namespace DiceShow.Ops.Parsing
{
   using System;
   using System.Linq;
   using System.Collections.ObjectModel;
   using Antlr4.Runtime;
   using Antlr4.Runtime.Misc;
   using Antlr4.Runtime.Tree;
   using DiceShow.Ops.Parsing.Internal;
   using DiceShow.Model;
   using System.Collections.Generic;

   public class DiceListener : IDiceListener
   {

      public Parsed Parsed { get; set; } = new Parsed();
      public Collection<IErrorNode> Errors { get; set; } = new Collection<IErrorNode>();
      private Stack<Dice> _dice = new Stack<Dice>();

      public void EnterEveryRule(ParserRuleContext context)
      {

      }

      public void ExitEveryRule(ParserRuleContext context)
      {

      }

      public void VisitTerminal(ITerminalNode node)
      {

      }

      public void VisitErrorNode(IErrorNode node)
      {
         Errors.Add(node);
      }


      public void EnterStatement([NotNull] DiceParser.StatementContext context)
      {
         Parsed.Statement = new Statement();
         Parsed.ParseTree = context.ToStringTree();
      }

      public void ExitStatement([NotNull] DiceParser.StatementContext context)
      {
         Parsed.Errors = from e in Errors
                         select new ParseError
                         {
                            Symbol = e.Symbol.Text,
                            Line = e.Symbol.Line,
                            Column = e.Symbol.Column
                         };
         Parsed.Exception = context.exception;
      }


      public void EnterDice(DiceParser.DiceContext context)
      {
         var dice = new Dice
         {
            Id = context.ID()?.Symbol.Text,
            Number = Convert.ToInt32(context.INT(0).Symbol.Text),
            Sides = Convert.ToInt32(context.INT(1).Symbol.Text),
         };

         Parsed.Statement.Dice.Add(dice);
         _dice.Push(dice);
      }

      public void ExitDice(DiceParser.DiceContext context)
      {
         _dice.Pop();
      }


      public void EnterExpression(DiceParser.ExpressionContext context)
      {

      }
      public void ExitExpression(DiceParser.ExpressionContext context)
      {

      }


      public void EnterAddScalar([NotNull] DiceParser.AddScalarContext context)
      {
         var scalar = Convert.ToInt32(context.INT().Symbol.Text);
         _dice.Peek().Expression = new ScalarExpression(scalar);
      }

      public void ExitAddScalar([NotNull] DiceParser.AddScalarContext context)
      {

      }

      public void EnterSubScalar([NotNull] DiceParser.SubScalarContext context)
      {
         var scalar = Convert.ToInt32(context.INT().Symbol.Text);
         _dice.Peek().Expression = new ScalarExpression(-scalar);
      }

      public void ExitSubScalar([NotNull] DiceParser.SubScalarContext context)
      {

      }

      public void EnterAddDiceExp([NotNull] DiceParser.AddDiceExpContext context)
      {


      }

      public void ExitAddDiceExp([NotNull] DiceParser.AddDiceExpContext context)
      {

      }

      public void EnterSubDiceExp([NotNull] DiceParser.SubDiceExpContext context)
      {
      }

      public void ExitSubDiceExp([NotNull] DiceParser.SubDiceExpContext context)
      {
      }

      public void EnterDrop([NotNull] DiceParser.DropContext context)
      {
         var exp = new TargetedExpression();

         _dice.Peek().Expression = exp;
      }

      public void ExitDrop([NotNull] DiceParser.DropContext context)
      {

      }
      public void EnterKeep([NotNull] DiceParser.KeepContext context)
      {

      }

      public void ExitKeep([NotNull] DiceParser.KeepContext context)
      {
      }

      public void EnterCount([NotNull] DiceParser.CountContext context)
      {
      }

      public void ExitCount([NotNull] DiceParser.CountContext context)
      {
      }

      public void EnterReroll([NotNull] DiceParser.RerollContext context)
      {
      }

      public void ExitReroll([NotNull] DiceParser.RerollContext context)
      {
      }

      public void EnterExplode([NotNull] DiceParser.ExplodeContext context)
      {
      }

      public void ExitExplode([NotNull] DiceParser.ExplodeContext context)
      {
      }

      public void EnterHit([NotNull] DiceParser.HitContext context)
      {



         
         // var toHit = new ToHitExpression();
         // toHit.Number = Convert.ToInt32(context.INT().Symbol.Text);

         // var plus = context.PLUS();
         // var minus = context.MINUS();

         // toHit.GreaterThanOrEqual = plus != null;
         // toHit.LessThanOrEqual = minus != null;

         // _dice.Peek().Expression = toHit;
      }

      public void ExitHit([NotNull] DiceParser.HitContext context)
      {
      }

      public void EnterDiceExp(DiceParser.DiceExpContext context)
      {
         // maybe an op
      }
      public void ExitDiceExp(DiceParser.DiceExpContext context)
      {

      }


      public void EnterTarget(DiceParser.TargetContext context)
      {
         // noop
      }

      public void ExitTarget(DiceParser.TargetContext context)
      {

      }


      public void EnterTargetInt(DiceParser.TargetIntContext context)
      {
         var target = new Target();
         target.Number = Convert.ToInt32(context.INT().Symbol.Text);

         var plus = context.PLUS();
         var plusplus = context.PLUSPLUS();

         var minus = context.MINUS();
         var minusminus = context.MINUSMINUS();

         target.GreaterThanOrEqual = plus != null || plusplus != null;
         target.LessThanOrEqual = minus != null || minusminus != null;
         target.OpenEnded = plusplus != null || minusminus != null;

         _dice.Peek().Expression.Target = target;
      }

      public void ExitTargetInt(DiceParser.TargetIntContext context)
      {

      }


      public void EnterLowest(DiceParser.LowestContext context)
      {
         var target = new Target();
         target.Lowest = true;
         _dice.Peek().Expression.Target = target;
      }

      public void ExitLowest(DiceParser.LowestContext context)
      {

      }

      public void EnterHighest(DiceParser.HighestContext context)
      {
         var target = new Target();
         target.Highest = true;
         _dice.Peek().Expression.Target = target;
      }

      public void ExitHighest(DiceParser.HighestContext context)
      {

      }


   }
}