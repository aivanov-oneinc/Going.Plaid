using System;
using System.Text.Json.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// 
	/// </summary>
	public enum PaymentScheduleInterval
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("WEEKLY")]
		Weekly,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("MONTHLY")]
		Monthly,
	}
}
