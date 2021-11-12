﻿using System;
using System.Linq.Expressions;

namespace DSG.IKAM.SHARED.Specification
{
    public class And<T> : SpecificationBase<T>
    {
        ISpecification<T> left;
        ISpecification<T> right;

        public And(
            ISpecification<T> left,
            ISpecification<T> right)
        {
            this.left = left;
            this.right = right;
        }

        // AndSpecification
        public override Expression<Func<T, bool>> SpecExpression
        {
            get
            {
                var objParam = Expression.Parameter(typeof(T), "obj");

                var newExpr = Expression.Lambda<Func<T, bool>>(
                    Expression.AndAlso(
                        Expression.Invoke(left.SpecExpression, objParam),
                        Expression.Invoke(right.SpecExpression, objParam)
                    ),
                    objParam
                );

                return newExpr;
            }
        }
    }
}
