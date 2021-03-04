using System;
using System.Text.Json.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// 
	/// </summary>
	public enum BankTransferDirection
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("outbound")]
		Outbound,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("inbound")]
		Inbound,
	}
}
