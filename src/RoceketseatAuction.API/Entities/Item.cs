using System.ComponentModel.DataAnnotations.Schema;

namespace RoceketseatAuction.API.Entities;

[Table("Items")]
public class Item
{

    public int Id { get; set; }
    public string Name { get; set; }
    public string Brand { get; set; }
    public int Condition { get; set; }
    public int BasePrice { get; set; }
    public int AuctionId { get; set; }
}
