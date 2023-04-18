using System;
using System.ComponentModel.DataAnnotations;

namespace FutureValue.Models;

public class FutureValueModel
{
    [Required(ErrorMessage = "Please enter a monthly investment.")]
    [Range(1, 500, ErrorMessage = "Monthly investment must be between 1 and 500")]
    public decimal MonthlyInvestment { get; set; }
    [Required(ErrorMessage = "Please enter a number of years.")]
    [Range(1,50, ErrorMessage = "Number of years must be between 1 and 50")]
    public int Years { get; set; }
    [Required(ErrorMessage = "Please enter a yearly interest rate.")]
    [Range(0.1, 10.0, ErrorMessage = "Yearly interest must be between 0.1 and 10.0")]
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