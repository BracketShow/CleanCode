namespace BracketShow.CleanCode
{
    public class ConsolidateConditionalExpression
    {
        #region constants and fields

        private readonly double _amount = 100.0;
        private readonly double _disabilityRate = 1.5;
        private readonly int _seniority = 0;
        private readonly int _monthDisabled = 0;
        private readonly bool _isPartTime = true;
        #endregion
        
        public double DisabilityAmount()
        {
            if (_seniority < 2) return 0;
            if (_monthDisabled > 12) return 0;
            if (_isPartTime) return 0;

            return _amount * _disabilityRate;
        }
    }
}