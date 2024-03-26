using System.Text.Json.Serialization;

namespace ClientBlazor.Pages.Clientes;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class Meta
{
    public int currentPage { get; set; }
    public int itemsPerPage { get; set; }
    public int totalOfItems { get; set; }
    public int totalOfPages { get; set; }
}

public class Result
{
    public string street { get; set; }
    public string complement { get; set; }
    public string district { get; set; }
    public int districtId { get; set; }
    public string city { get; set; }
    public int cityId { get; set; }
    public int ibgeId { get; set; }
    public string state { get; set; }
    public string stateShortname { get; set; }
    public string zipcode { get; set; }
}

public class Root
{
    public Meta meta { get; set; }
    public Result result { get; set; }
}
