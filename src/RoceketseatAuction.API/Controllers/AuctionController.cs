using Microsoft.AspNetCore.Mvc;
using RoceketseatAuction.API.Controllers;
using RocektseatAuction.API.UseCases.Auctions.GetCurrent;
using RocketseatAuction.API.Entities;

namespace RockeetseatAuction.API.Controllers;

public class AuctionController : RocketseatAuctionBaseController
{
    [HttpGet]
    [ProducesResponseType(typeof(Auction) ,StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetCurrentAuction()
    {
        var useCase = new GetCurrentAuctionUseCase();

        var result = useCase.Execute();

        if(result is null)
        {
            return NoContent();
        }

        return Ok(result);
    }
}