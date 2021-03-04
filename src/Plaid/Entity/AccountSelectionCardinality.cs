using System;
using System.Text.Json.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// The application requires that accounts be limited to a specific cardinality.
	/// </summary>
	public enum AccountSelectionCardinality
	{
		/// <summary>
		/// indicates that the user should be allowed to pick only a single account.
		/// </summary>
		[JsonPropertyName("SINGLE_SELECT")]
		SingleSelect,

		/// <summary>
		/// indicates that the user should be allowed to pick multiple accounts.
		/// </summary>
		[JsonPropertyName("MULTI_SELECT")]
		MultiSelect,

		/// <summary>
		/// indicates that the user must share all of their accounts and should not be given the opportunity to de-select
		/// </summary>
		[JsonPropertyName("ALL")]
		All,
	}
}
