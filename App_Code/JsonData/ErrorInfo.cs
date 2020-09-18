using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

/// <summary>
/// Сводное описание для ErrorInfo
/// </summary>
public class ErrorInfo
{
    [JsonProperty(PropertyName = "code")]
    public int Code { get; set; }

    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

	public ErrorInfo()
	{
		
	}
}