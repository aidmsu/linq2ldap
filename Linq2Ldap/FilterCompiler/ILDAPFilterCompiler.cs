﻿using System;
using System.Linq.Expressions;

namespace Linq2Ldap
{
    public interface ILDAPFilterCompiler
    {
        /// <summary>
        /// Compiles an LDAP Filter string from a Linq Expression. Implements
        /// a subset of Expressions that includes boolean algebraic operators (||, &&, !),
        /// comparison operators (==, &lt;=, &gt;=, !=), as well as substring filters
        /// like .Contains(), .StartsWith(), and .EndsWith().
        /// For other methods and expressions, assign their results to a variable before
        /// using the variable inside a Linq-to-LDAP expression.
        /// </summary>
        /// <typeparam name="T">The LDAP model.</typeparam>
        /// <param name="expr">A Linq Expression over the LDAP model.</param>
        /// <returns>An LDAP filter string.</returns>
        string CompileFromLinq<T>(Expression<Func<T, bool>> expr);
    }
}