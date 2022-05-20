using Contract.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Api.Http.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        [HttpPost("")]
        public ActionResult Create(ExpenseDto expense)
        {
            if (expense is null)
            {
                throw new ArgumentNullException(nameof(expense));
            }
            return Ok();
        }
    }
}
