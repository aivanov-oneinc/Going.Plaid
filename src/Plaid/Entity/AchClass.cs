using System;
using System.Text.Json.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// Specifies the use case of the transfer.  Required for transfers on an ACH network.
	/// </summary>
	public enum AchClass
	{
		/// <summary>
		/// Accounts Receivable Entry
		/// </summary>
		[JsonPropertyName("arc")]
		Arc,

		/// <summary>
		/// " - Cross Border Entry
		/// </summary>
		[JsonPropertyName("cbr")]
		Cbr,

		/// <summary>
		/// Corporate Credit or Debit - fund transfer between two corporate bank accounts
		/// </summary>
		[JsonPropertyName("ccd")]
		Ccd,

		/// <summary>
		/// Customer Initiated Entry
		/// </summary>
		[JsonPropertyName("cie")]
		Cie,

		/// <summary>
		/// Automated Notification of Change
		/// </summary>
		[JsonPropertyName("cor")]
		Cor,

		/// <summary>
		/// Corporate Trade Exchange
		/// </summary>
		[JsonPropertyName("ctx")]
		Ctx,

		/// <summary>
		/// International
		/// </summary>
		[JsonPropertyName("iat")]
		Iat,

		/// <summary>
		/// Machine Transfer Entry
		/// </summary>
		[JsonPropertyName("mte")]
		Mte,

		/// <summary>
		/// Cross Border Entry
		/// </summary>
		[JsonPropertyName("pbr")]
		Pbr,

		/// <summary>
		/// Point-of-Purchase Entry
		/// </summary>
		[JsonPropertyName("pop")]
		Pop,

		/// <summary>
		/// Point-of-Sale Entry
		/// </summary>
		[JsonPropertyName("pos")]
		Pos,

		/// <summary>
		/// Prearranged Payment or Deposit - the transfer is part of a pre-existing relationship with a consumer, eg. bill payment
		/// </summary>
		[JsonPropertyName("ppd")]
		Ppd,

		/// <summary>
		/// Re-presented Check Entry
		/// </summary>
		[JsonPropertyName("rck")]
		Rck,

		/// <summary>
		/// Telephone-Initiated Entry
		/// </summary>
		[JsonPropertyName("tel")]
		Tel,

		/// <summary>
		/// Internet-Initiated Entry - debits from a consumer’s account where their authorization is obtained over the Internet
		/// </summary>
		[JsonPropertyName("web")]
		Web,
	}
}
