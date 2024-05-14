using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class calculation
{
    [JsonProperty("excited")]
    public int excited { get; set; }

}

public class data
{
    [JsonProperty("comparative")]
    public double comparative { get; set; }

    [JsonProperty("calculation")]
    public calculation[] calculation { get; set; }

    [JsonProperty("sentimentText")]
    public string sentimentText { get; set; }

    [JsonProperty("sentiment")]
    public int sentiment { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
