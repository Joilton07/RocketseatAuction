using Microsoft.AspNetCore.Mvc;
using RoceketseatAuction.API.Communication.Requests;
using RoceketseatAuction.API.Filters;

namespace RoceketseatAuction.API.Controllers;
public class OfferController : RocketseatAuctionBaseController
{
    [HttpPost]
    [Route("{itemId}")]
    [ServiceFilter(typeof(AutheticationUserAttribute))]
    public IActionResult CreateOffer([FromRoute]int itemId, [FromBody]RequestCreateOfferJson request)
    {
        return Created();
    }
}
