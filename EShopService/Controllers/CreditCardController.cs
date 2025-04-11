using Microsoft.AspNetCore.Mvc;
using EShop.Domain.Models;
using System.Net;
using EShop.Domain.Enums;
using EShop.Domain.Exceptions.CreditCard;
using EShop.Application.Services;
namespace EShopService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditCardController : ControllerBase
    {

        protected ICreditCardService _creditCardService;
        public CreditCardController(ICreditCardService creditCardService)
        {
            _creditCardService = creditCardService;
        }

        [HttpGet("ValidateCreditCard/{cardNumber}")]
        public IActionResult GetValidation(string cardNumber) 
        {
            try
            {
                _creditCardService.ValidateCardNumber(cardNumber);
                return Ok(new { provider = _creditCardService.GetCardType(cardNumber) });
            }
            catch(CardNumberInvalidException ex)
            {   
                    return BadRequest(new { error = ex.Message, code = HttpStatusCode.BadRequest});
            }
            catch (CardNumberTooShortException ex)
            {
                return BadRequest(new { error = ex.Message, code = HttpStatusCode.BadRequest});
            }
            catch (CardNumberTooLongException ex)
            {
                return StatusCode((int)HttpStatusCode.RequestUriTooLong, new { error = ex.Message, code = HttpStatusCode.RequestUriTooLong });
                
            }
        }

    }
}
