using System;
using System.Collections.Generic;

namespace FitNesseExamples.Fixtures
{
    public class ShouldIBuyMilk
    {
        private int _dollars;
        private int _pints;
        private bool _creditCard;

        public int CashInWallet
        {
            get
            {
                return _dollars;
            }
            set
            {
                _dollars = value;
            }
        }

        public int PintsOfMilkRemaining
        {
            get
            {
                return _pints;
            }
            set
            {
                _pints = value;
            }
        }

        public void setCreditCard(String valid)
        {
            _creditCard = "yes".Equals(valid);
        }

        public String GoToStore()
        {
            return (_pints == 0 && (_dollars > 2 || _creditCard)) ? "yes" : "no";
        }

        // The following functions are optional.  If they aren't declared they'll be ignored.
        public void execute()
        {
        }

        public void reset()
        {
        }

        public void table(List<List<string>> table)
        {
        }

        public void beginTable()
        {
        }

        public void endTable()
        {
        }
    }
}