﻿using SqlKata;

namespace QueryVortex.Core.Operators;

public class NotEqualOperator : ICondition
{
    private readonly string _column;
    private readonly object _value;
    public NotEqualOperator(string column, object value)
    {
        _column = column;
        _value = value;
    }
    public Query Apply(Query query)
    {
        return query.Where(_column, "<>", _value);
    }
}
