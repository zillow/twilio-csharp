﻿using System;
#if NET40
using System.Threading.Tasks;
#endif
using Twilio.Http;

namespace Twilio.Clients
{
	public interface ITwilioRestClient
	{
		#if NET40
		Task<Response> RequestAsync(Request request);
		#endif
		Response Request(Request request);
		string GetAccountSid();
		HttpClient GetHttpClient();
		void SetHttpClient(HttpClient httpClient);
	}
}

