namespace FutureValue.Models;

public class FutureValueModel
{
    public decimal MonthlyInvestment { get; set; }
    public int Years { get; set; }
    public decimal Apr { get; set; }
    public decimal CalculateFutureValue()
    {
        int months = Years * 12;
        decimal monthlyRate = Apr / 12 / 100;
        decimal futureValue = 0;
        for (int i = 0; i < Years; i++)
        {
            futureValue = (MonthlyInvestment + futureValue) * (1 + monthlyRate);
        }

        return futureValue;
    }
}