using System;
using System.Text.Json.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// The verification status. One of the following:
	/// </summary>
	public enum VerificationStatus
	{
		/// <summary>
		/// The information was successfully verified.
		/// </summary>
		[JsonPropertyName("VERIFIED")]
		Verified,

		/// <summary>
		/// The verification has not yet been performed.
		/// </summary>
		[JsonPropertyName("UNVERIFIED")]
		Unverified,

		/// <summary>
		/// The verification was attempted but could not be completed due to missing information.
		/// </summary>
		[JsonPropertyName("NEEDS_INFO")]
		NeedsInfo,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("UNABLE_TO_VERIFY")]
		UnableToVerify,

		/// <summary>
		/// The verification status is unknown.
		/// </summary>
		[JsonPropertyName("UNKNOWN")]
		Unknown,
	}
}
