﻿using SqlKata;

namespace QueryVortex.Core.Operators;

public class LikeOperator : ICondition
{
    private readonly string _column;
    private readonly string _value;
    public LikeOperator(string column, string value)
    {
        _column = column;
        _value = value;
    }
    public Query Apply(Query query)
    {
        return query.Where(_column, "LIKE", _value);
    }
}
