using System;
using System.Text.Json.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// The type of event that this bank transfer represents.
	/// </summary>
	public enum BankTransferEventType
	{
		/// <summary>
		/// A new transfer was created; it is in the pending state.
		/// </summary>
		[JsonPropertyName("pending")]
		Pending,

		/// <summary>
		/// The transfer was cancelled by the client.
		/// </summary>
		[JsonPropertyName("cancelled")]
		Cancelled,

		/// <summary>
		/// The transfer failed, no funds were moved.
		/// </summary>
		[JsonPropertyName("failed")]
		Failed,

		/// <summary>
		/// The transfer has been successfully submitted to the payment network.
		/// </summary>
		[JsonPropertyName("posted")]
		Posted,

		/// <summary>
		/// A posted transfer was reversed.
		/// </summary>
		[JsonPropertyName("reversed")]
		Reversed,

		/// <summary>
		/// The matching transfer was found as a pending transaction in the receiver's account
		/// </summary>
		[JsonPropertyName("receiver_pending")]
		ReceiverPending,

		/// <summary>
		/// The matching transfer was found as a posted transaction in the receiver's account
		/// </summary>
		[JsonPropertyName("receiver_posted")]
		ReceiverPosted,
	}
}
