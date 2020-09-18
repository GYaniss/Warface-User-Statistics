using System;
using System.Collections.Generic;
using System.Web;
using Newtonsoft.Json;

/// <summary>
/// Сводное описание для UserInfo
/// </summary>
public class UserInfo
{
    [JsonProperty(PropertyName = "nickname")]
    public string nickname { get; set; }

    [JsonProperty(PropertyName = "experience")]
    public int experience { get; set; }

    [JsonProperty(PropertyName = "rank_id")]
    public int rank_id { get; set; }

    [JsonProperty(PropertyName = "kill")]
    public int kill { get; set; }

    [JsonProperty(PropertyName = "friendly_kills")]
    public int friendly_kills { get; set; }

    [JsonProperty(PropertyName = "death")]
    public int death { get; set; }

    [JsonProperty(PropertyName = "clan_name")]
    public string clan_name { get; set; }

    [JsonProperty(PropertyName = "kills")]
    public int kills { get; set; }

    [JsonProperty(PropertyName = "pvp")]
    public string pvp { get; set; }

    [JsonProperty(PropertyName = "playtime")]
    public int playtime { get; set; }

    [JsonProperty(PropertyName = "playtime_h")]
    public int playtime_h { get; set; }

    [JsonProperty(PropertyName = "playtime_m")]
    public int playtime_m { get; set; }

    [JsonProperty(PropertyName = "favoritPVP")]
    public string favoritPVP { get; set; }

    [JsonProperty(PropertyName = "favoritPVE")]
    public string favoritPVE { get; set; }

    [JsonProperty(PropertyName = "pve_wins")]
    public int pve_wins { get; set; }

    [JsonProperty(PropertyName = "pvp_wins")]
    public int pvp_wins { get; set; }

    [JsonProperty(PropertyName = "pvp_lost")]
    public int pvp_lost { get; set; }


    [JsonProperty(PropertyName = "pvpwl")]
    public string pvpwl { get; set; }

    [JsonProperty(PropertyName = "full_response")]
    public string full_response { get; set; }

	public UserInfo()
	{
		//
		// TODO: добавьте логику конструктора
		//
	}
}