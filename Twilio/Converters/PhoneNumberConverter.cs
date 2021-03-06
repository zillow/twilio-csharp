﻿using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Twilio.Converters
{
	public class PhoneNumberConverter : JsonConverter
	{
		public PhoneNumberConverter() {
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
			JToken t = JToken.FromObject(value.ToString());
			t.WriteTo(writer);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
			return new Twilio.Types.PhoneNumber(reader.Value as string);
		}

		public override bool CanConvert(Type objectType) {
			return objectType == typeof(Enum);
		}
	}
}
