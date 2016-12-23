namespace BracketShow.CleanCode
{
    public class ConsolidateDuplicateConditionalFragment
    {
        #region Fields;

        private double _totalPrice = 0.0;
        private double _price = 0.0;

        #endregion

        public void UpdateTotalPrice()
        {
            if (IsSpecialDeal())
            {
                _totalPrice = _price * GetDealRate();
                Save();
            }
            else
            {
                _totalPrice = _price * GetRegularRate();
                Save();
            }
        }

        private void Save()
        {
            throw new System.NotImplementedException();
        }

        private double GetRegularRate()
        {
            throw new System.NotImplementedException();
        }

        private double GetDealRate()
        {
            throw new System.NotImplementedException();
        }

        private bool IsSpecialDeal()
        {
            throw new System.NotImplementedException();
        }
    }
}