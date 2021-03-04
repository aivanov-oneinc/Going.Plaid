using System;
using System.Text.Json.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// 
	/// </summary>
	public enum CountryCode
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("US")]
		Us,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("GB")]
		Gb,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("ES")]
		Es,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("NL")]
		Nl,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("FR")]
		Fr,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("IE")]
		Ie,

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName("CA")]
		Ca,
	}
}
