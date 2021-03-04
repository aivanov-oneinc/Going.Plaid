using System;
using System.Text.Json.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// 
	/// </summary>
	public enum BankTransferType
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("debit")]
		Debit,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("credit")]
		Credit,
	}
}
