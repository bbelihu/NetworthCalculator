using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetWorthCalculator.Models
{
    public class NetworthModel
    {
        // properties for the assets col
        [Required]
        public double Checkings_accounts { get; set; }
        [Required]
        public double Savings_accounts { get; set; }
        [Required]
        public double Money_markets_accounts { get; set; }
        [Required]
        public double Savings_bonds { get; set; }
        [Required]
        public double Cd { get; set; }
        [Required]
        public double Other { get; set; }

        public double Total_cash { get; set; }



        //fields for the liabilities
        [Required]
        public double Credit_card_balance { get; set; }
        [Required]
        public double Estimated_income_taxowed { get; set; }
        [Required]
        public double Other_outstanding_bills { get; set; }
        [Required]
        public double Home_mortgage { get; set; }
        [Required]
        public double Home_equity_loans { get; set; }
        [Required]
        public double Mortgage_on_renatal_properties { get; set; }
        [Required]
        public double Car_loans { get; set; }
        [Required]
        public double Student_loans { get; set; }
        [Required]
        public double Life_insurance_policy_loans { get; set; }
        [Required]
        public double Other_longterm_debts { get; set; }
        
        public double total_liabilities { get; set; }
        
        public double netWorth { get; set; }
        public string calculate { get; set; }

    }
}
