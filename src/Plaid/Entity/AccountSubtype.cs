using System;
using System.Text.Json.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// 
	/// </summary>
	public enum AccountSubtype
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("401a")]
		401a,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("401k")]
		401k,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("403B")]
		403b,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("457b")]
		457b,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("529")]
		529,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("brokerage")]
		Brokerage,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("cash isa")]
		CashIsa,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("education savings account")]
		EducationSavingsAccount,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("ebt")]
		Ebt,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("gic")]
		Gic,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("health reimbursement arrangement")]
		HealthReimbursementArrangement,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("hsa")]
		Hsa,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("isa")]
		Isa,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("ira")]
		Ira,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("lif")]
		Lif,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("life insurance")]
		LifeInsurance,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("lira")]
		Lira,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("lrif")]
		Lrif,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("lrsp")]
		Lrsp,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("non-taxable brokerage account")]
		NonTaxableBrokerageAccount,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("other")]
		Other,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("other insurance")]
		OtherInsurance,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("other annuity")]
		OtherAnnuity,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("prif")]
		Prif,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("rdsp")]
		Rdsp,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("resp")]
		Resp,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("rlif")]
		Rlif,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("rrif")]
		Rrif,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("pension")]
		Pension,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("profit sharing plan")]
		ProfitSharingPlan,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("retirement")]
		Retirement,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("roth")]
		Roth,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("roth 401k")]
		Roth401k,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("rrsp")]
		Rrsp,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("sep ira")]
		SepIra,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("simple ira")]
		SimpleIra,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("sipp")]
		Sipp,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("stock plan")]
		StockPlan,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("thrift savings plan")]
		ThriftSavingsPlan,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("tfsa")]
		Tfsa,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("trust")]
		Trust,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("ugma")]
		Ugma,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("utma")]
		Utma,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("variable annuity")]
		VariableAnnuity,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("credit card")]
		CreditCard,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("paypal")]
		Paypal,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("cd")]
		Cd,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("checking")]
		Checking,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("savings")]
		Savings,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("money market")]
		MoneyMarket,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("prepaid")]
		Prepaid,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("auto")]
		Auto,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("business")]
		Business,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("commercial")]
		Commercial,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("construction")]
		Construction,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("consumer")]
		Consumer,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("home")]
		Home,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("home equity")]
		HomeEquity,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("loan")]
		Loan,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("mortgage")]
		Mortgage,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("overdraft")]
		Overdraft,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("line of credit")]
		LineOfCredit,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("student")]
		Student,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("cash management")]
		CashManagement,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("keogh")]
		Keogh,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("mutual fund")]
		MutualFund,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("recurring")]
		Recurring,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("rewards")]
		Rewards,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("safe deposit")]
		SafeDeposit,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("sarsep")]
		Sarsep,
	}
}
