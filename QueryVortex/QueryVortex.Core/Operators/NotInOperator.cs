﻿using SqlKata;

namespace QueryVortex.Core.Operators;

public class NotInOperator : ICondition
{
    private readonly string _column;
    private readonly IEnumerable<object> _values;
    public NotInOperator(string column, IEnumerable<object> values)
    {
        _column = column;
        _values = values;
    }
    public void Apply(Query query)
    {
        if (_values == null)
        {
            query.WhereNull(_column);
        }
        else
        {
            query.WhereNotIn(_column, _values);
        }
    }
}
