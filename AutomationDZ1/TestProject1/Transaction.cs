namespace TestProject1
{
    public class Transaction
    {
        public double FullSumm(double remittance)
        {
            double commission;
            if(remittance>=10 && remittance<1000)
            {
                commission = 0.1;
            }
            else if(remittance>=1000 && remittance<10000)
            {
                commission = 0.05;
            }
            else if(remittance>=10000)
            {
                commission = 0.01;
            }
            else
            {
                throw new ArgumentException("Remittance should be from 10 to 10000");
            }
            return remittance+(remittance*commission);
        }
        
    }
}
