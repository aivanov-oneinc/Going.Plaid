using System;
using System.Text.Json.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// 
	/// </summary>
	public enum Products
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("assets")]
		Assets,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("auth")]
		Auth,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("balance")]
		Balance,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("identity")]
		Identity,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("investments")]
		Investments,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("liabilities")]
		Liabilities,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("payment_initiation")]
		PaymentInitiation,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("transactions")]
		Transactions,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("credit_details")]
		CreditDetails,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("income_verification")]
		IncomeVerification,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("deposit_switch")]
		DepositSwitch,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("standing_orders")]
		StandingOrders,
	}
}
