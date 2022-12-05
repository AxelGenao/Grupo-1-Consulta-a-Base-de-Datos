//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Users\axelg\xRegistro\sql.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="sqlParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public interface IsqlVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="sqlParser.start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStart([NotNull] sqlParser.StartContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sqlParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInstruction([NotNull] sqlParser.InstructionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sqlParser.columns"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumns([NotNull] sqlParser.ColumnsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sqlParser.column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumn([NotNull] sqlParser.ColumnContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sqlParser.table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTable([NotNull] sqlParser.TableContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sqlParser.where_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhere_clause([NotNull] sqlParser.Where_clauseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sqlParser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCondition([NotNull] sqlParser.ConditionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sqlParser.comparison"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComparison([NotNull] sqlParser.ComparisonContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sqlParser.equality"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEquality([NotNull] sqlParser.EqualityContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sqlParser.less_eq_than"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLess_eq_than([NotNull] sqlParser.Less_eq_thanContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sqlParser.less_than"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLess_than([NotNull] sqlParser.Less_thanContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sqlParser.greater_eq_than"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGreater_eq_than([NotNull] sqlParser.Greater_eq_thanContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sqlParser.greater_than"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGreater_than([NotNull] sqlParser.Greater_thanContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sqlParser.string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitString([NotNull] sqlParser.StringContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sqlParser.join_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJoin_clause([NotNull] sqlParser.Join_clauseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="sqlParser.join_modifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJoin_modifier([NotNull] sqlParser.Join_modifierContext context);
}
