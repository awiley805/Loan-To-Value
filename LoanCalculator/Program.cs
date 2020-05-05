using System;

namespace LoanCalculator{

    public class LTV
    {
        private double m_principal;
        private double m_appraisdedValue;
        private double m_salesPrice;


        // create constructors

        public LTV() { }

        public LTV(double p, double av, double sp) 
        {
            // populate memeber variables 
            m_principal = p;
            m_appraisdedValue = av;
            m_salesPrice = sp;

        }

        // build a method

        public double GetLTV()
        {
            double lowerOf = 0; // initialize at zero

            if (m_salesPrice != 0 && m_salesPrice < m_appraisdedValue) 
            {
                lowerOf = m_salesPrice;
            }
            else
            {
                lowerOf = m_appraisdedValue;
            }

            double loanToValue = 100 * (m_principal / lowerOf);

            return loanToValue;
        
        }


        // create properties

        public double Principal
        {
            get 
            { 
                return m_principal; 
            }
            set 
            { 
                m_principal = value; 
            }
        }
        
        public double AppraisedValue
        {
            get
            {
                return m_appraisdedValue;
            }
            set
            {
                m_appraisdedValue = value;
            }
        }
        public double SalesPrice
        {
            get 
            { 
                return m_salesPrice; 
            }
            set 
            { 
                m_salesPrice = value; 
            }
        }


    }


}
