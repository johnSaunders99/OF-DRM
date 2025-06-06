﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DynamicRules
    {
		[JsonProperty(PropertyName = "app-token")]
		public string? AppToken { get; set; }

		[JsonProperty(PropertyName = "app_token")]
		private string AppToken2 { set { AppToken = value; } }

		[JsonProperty(PropertyName = "static_param")]
		public string? StaticParam { get; set; }

		[JsonProperty(PropertyName = "prefix")]
		public string? Prefix { get; set; }

		[JsonProperty(PropertyName = "suffix")]
		public string? Suffix { get; set; }

		[JsonProperty(PropertyName = "checksum_constant")]
		public int? ChecksumConstant { get; set; }

		[JsonProperty(PropertyName = "checksum_indexes")]
		public List<int> ChecksumIndexes { get; set; }
	}
}
