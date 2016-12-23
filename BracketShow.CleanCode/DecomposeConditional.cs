using System;

namespace BracketShow.CleanCode
{
    public class DecomposeConditional
    {
        #region constants and fields
        private readonly double _normalRate = 10.0;
        private readonly double _winterRate = 15.0;
        #endregion
        
        public double CalculateCharge(DateTime date, double quantity)
        {
            double charge;
            if (date > GetWinterStart(date) && date < GetSpringStart(date))
            {
                charge = quantity * _winterRate;
            }
            else
            {
                charge = quantity * _normalRate;
            }
            return charge;
        }

        private DateTime GetSpringStart(DateTime date)
        {
            throw new NotImplementedException();
        }

        private DateTime GetWinterStart(DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}
