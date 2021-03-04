using System;
using System.Text.Json.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// An identifier classifying the transaction type.
	/// </summary>
	public enum TransactionCode
	{
		/// <summary>
		/// Bank adjustment
		/// </summary>
		[JsonPropertyName("adjustment")]
		Adjustment,

		/// <summary>
		/// Cash deposit or withdrawal via an automated teller machine
		/// </summary>
		[JsonPropertyName("atm")]
		Atm,

		/// <summary>
		/// Charge or fee levied by the institution
		/// </summary>
		[JsonPropertyName("bank charge")]
		BankCharge,

		/// <summary>
		/// Payment of a bill
		/// </summary>
		[JsonPropertyName("bill payment")]
		BillPayment,

		/// <summary>
		/// Cash deposit or withdrawal
		/// </summary>
		[JsonPropertyName("cash")]
		Cash,

		/// <summary>
		/// Cash withdrawal while making a debit card purchase
		/// </summary>
		[JsonPropertyName("cashback")]
		Cashback,

		/// <summary>
		/// Document ordering the payment of money to another person or organization
		/// </summary>
		[JsonPropertyName("cheque")]
		Cheque,

		/// <summary>
		/// Automatic withdrawal of funds initiated by a third party at a regular interval
		/// </summary>
		[JsonPropertyName("direct debit")]
		DirectDebit,

		/// <summary>
		/// Interest earned or incurred
		/// </summary>
		[JsonPropertyName("interest")]
		Interest,

		/// <summary>
		/// Purchase made with a debit or credit card
		/// </summary>
		[JsonPropertyName("purchase")]
		Purchase,

		/// <summary>
		/// Payment instructed by the account holder to a third party at a regular interval
		/// </summary>
		[JsonPropertyName("standing order")]
		StandingOrder,

		/// <summary>
		/// Transfer of money between accounts
		/// </summary>
		[JsonPropertyName("transfer")]
		Transfer,
	}
}
