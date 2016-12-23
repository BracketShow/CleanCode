namespace BracketShow.CleanCode
{
    public class FlattenNestedConditional
    {
        #region Fields

        private bool _isDead = false;
        private bool _isSeparated = false;
        private bool _isretired = false;

        #endregion

        public double GetPayAmount()
        {
            double result;
            if (_isDead) result = DeadAmount();
            else
            {
                if (_isSeparated) result = SeparetedAmount();
                else
                {
                    if (_isretired) result = RetiredAmount();
                    else result = NormalPayAmount();
                }
            }
            return result;
        }

        private double DeadAmount()
        {
            throw new System.NotImplementedException();
        }

        private double SeparetedAmount()
        {
            throw new System.NotImplementedException();
        }

        private double RetiredAmount()
        {
            throw new System.NotImplementedException();
        }

        private double NormalPayAmount()
        {
            throw new System.NotImplementedException();
        }
    }
}