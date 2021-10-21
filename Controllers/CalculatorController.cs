using Microsoft.AspNetCore.Mvc;
using NetWorthCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetWorthCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(NetworthModel n)
        {
            // If all the values of the model are filled the networth will be calculated.
            if (ModelState.IsValid)
            {
                n.Total_cash = n.Checkings_accounts + n.Savings_accounts + n.Money_markets_accounts + n.Savings_bonds + n.Cd + n.Other;
                n.total_liabilities = n.Credit_card_balance + n.Estimated_income_taxowed + n.Other_outstanding_bills + n.Home_mortgage +
                    n.Home_equity_loans + n.Mortgage_on_renatal_properties + n.Car_loans + n.Student_loans + n.Life_insurance_policy_loans +
                    n.Other_longterm_debts;
                n.netWorth = n.Total_cash + n.total_liabilities;
                @ViewData["cash"] = n.Total_cash;
                ViewData["liabilities"] = n.total_liabilities;
                ViewData["net"] = n.netWorth;
                return View();
            }
            // If all the required fields are not entered user will be redirected to the calculator page
            else
            {
                return Redirect("/Calculator");
            }
        }

    }
}
