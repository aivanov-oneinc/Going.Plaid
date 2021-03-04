using System;
using System.Text.Json.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// See the <a href="https://plaid.com/docs/api/accounts#account-type-schema">Account type schema</a> for a full listing of account types and corresponding subtypes.
	/// </summary>
	public enum OverrideAccountType
	{
		/// <summary>
		/// Investment account
		/// </summary>
		[JsonPropertyName("investment")]
		Investment,

		/// <summary>
		/// Credit card
		/// </summary>
		[JsonPropertyName("credit")]
		Credit,

		/// <summary>
		/// Depository account
		/// </summary>
		[JsonPropertyName("depository")]
		Depository,

		/// <summary>
		/// Loan account
		/// </summary>
		[JsonPropertyName("loan")]
		Loan,

		/// <summary>
		/// Non-specified account type
		/// </summary>
		[JsonPropertyName("other")]
		Other,
	}
}
