using System.Collections.Generic;

namespace System
{
    using Linq.Expressions;
    public static class PredicateBuilder
    {
        public static Expression<Func<T, bool>> And<T>(this Expression<Func<T, bool>> left, Expression<Func<T, bool>> right)
        {
            var p = left.Parameters[0];
            var visitor =  new SubstExpressionVisitor(new() { [right.Parameters[0]] = p });

            Expression body = Expression.AndAlso(left.Body, visitor.Visit(right.Body));
            return Expression.Lambda<Func<T, bool>>(body, p);
        }

        public static Expression<Func<T, bool>> Or<T>(this Expression<Func<T, bool>> left, Expression<Func<T, bool>> right)
        {
            var p = left.Parameters[0];
            var visitor = new SubstExpressionVisitor(new() { [right.Parameters[0]] = p });

            Expression body = Expression.OrElse(left.Body, visitor.Visit(right.Body));
            return Expression.Lambda<Func<T, bool>>(body, p);
        }
    }

    internal class SubstExpressionVisitor : ExpressionVisitor
    {
        public Dictionary<Expression, Expression> Subst = new();

        public SubstExpressionVisitor(Dictionary<Expression, Expression> subst)
        {
            Subst = subst;
        }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            return Subst.TryGetValue(node, out var newValue) ? newValue : node;
        }
    }
}