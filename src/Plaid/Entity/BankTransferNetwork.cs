using System;
using System.Text.Json.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// 
	/// </summary>
	public enum BankTransferNetwork
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("ach")]
		Ach,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("same-day-ach")]
		SameDayAch,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("wire")]
		Wire,
	}
}
