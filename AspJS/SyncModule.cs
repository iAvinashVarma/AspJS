using System;
using System.Web;

namespace AspJS
{
	public class SyncModule : IHttpModule
	{
		public delegate void CustomEventHandler(object sender, EventArgs e);

		private CustomEventHandler _eventHandler;

		public event CustomEventHandler EventHandler
		{
			add { _eventHandler += value; }
			remove { _eventHandler -= value; }
		}

		public void Init(HttpApplication context)
		{
			context.BeginRequest += new EventHandler(OnBeginRequest);
		}

		private void OnBeginRequest(object sender, EventArgs e)
		{
			var application = sender as HttpApplication;
			application.Context.Response.Write("Hello");
			_eventHandler?.Invoke(this, null);
		}

		public void Dispose()
		{
		}
	}
}