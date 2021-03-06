﻿using System;

namespace Twilio.Http
{
	public class HttpMethod
	{
		public static readonly HttpMethod GET=new HttpMethod("GET");
		public static readonly HttpMethod POST=new HttpMethod("POST");
		public static readonly HttpMethod PUT=new HttpMethod("PUT");
		public static readonly HttpMethod DELETE=new HttpMethod("DELETE");

		private string value;

		public HttpMethod() {
		}

		public HttpMethod(string method) {
			value = method.ToUpper();
		}

        public static implicit operator HttpMethod(string value) {
            return new HttpMethod(value);
        }

		public override bool Equals(object obj)
		{
			if (obj == null)
				return false;
			if (ReferenceEquals (this, obj))
				return true;
			if (obj.GetType () != typeof(HttpMethod))
				return false;
			HttpMethod other = (HttpMethod)obj;
			return value == other.value;
		}
		

		public override int GetHashCode()
		{
			unchecked {
				return (value != null ? value.GetHashCode () : 0);
			}
		}
		

		public override string ToString() {
			return this.value;
		}
	}
}

