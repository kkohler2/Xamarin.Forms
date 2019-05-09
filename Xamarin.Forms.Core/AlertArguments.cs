using System.ComponentModel;
using System.Threading.Tasks;

namespace Xamarin.Forms.Internals
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class AlertArguments
	{
		public AlertArguments(string title, string message, string accept, string cancel, bool allowCancelEvent)
		{
			Title = title;
			Message = message;
			Accept = accept;
			Cancel = cancel;
			Result = new TaskCompletionSource<bool>();
			AllowCancelEvent = allowCancelEvent;
		}

		/// <summary>
		///     Gets the text for the accept button. Can be null.
		/// </summary>
		public string Accept { get; private set; }

		/// <summary>
		///		True to allow back button or tapping outside of alert to cancel. False to close dialog without returning result on tap outside or back button.  Only affects Android implementation.
		/// </summary>
		public bool AllowCancelEvent { get; private set; }

		/// <summary>
		///     Gets the text of the cancel button.
		/// </summary>
		public string Cancel { get; private set; }

		/// <summary>
		///     Gets the message for the alert. Can be null.
		/// </summary>
		public string Message { get; private set; }

		public TaskCompletionSource<bool> Result { get; }

		/// <summary>
		///     Gets the title for the alert. Can be null.
		/// </summary>
		public string Title { get; private set; }

		public void SetResult(bool result)
		{
			Result.TrySetResult(result);
		}
	}
}