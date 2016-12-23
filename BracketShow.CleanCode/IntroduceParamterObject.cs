using System;
using System.Collections.Generic;
using System.Linq;

namespace BracketShow.CleanCode
{
    public class IntroduceParamterObject
    {
        private IEnumerable<Transaction> _transactions = new List<Transaction>();

        public IEnumerable<Transaction> GetTransactions(DateTime start, DateTime end)
        {
            var result = from t in _transactions
                where t.Date >= start
                      && t.Date <= end
                select t;
            return result;
        }
    }
    
    public class Range<T> where T : IComparable<T>
    {
        private readonly T _start;
        private readonly T _end;

        public Range(T start, T end)
        {
            _start = start;
            _end = end;
        }

        public bool Contains(T target)
        {
            return target.CompareTo(_start) >= 0
                   && target.CompareTo(_end) <= 0;
        }
    }
    
    public class Transaction
    {
        public DateTime Date { get; set; }
    }
}