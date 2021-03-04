using System;
using System.Text.Json.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// 
	/// </summary>
	public enum BankTransferStatus
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("pending")]
		Pending,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("posted")]
		Posted,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("cancelled")]
		Cancelled,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("failed")]
		Failed,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("reversed")]
		Reversed,
	}
}
