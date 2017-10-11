using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloCoreApi.Dtos;

namespace HelloCoreApi.Controllers
{
    [Route("api/[controller]")]
    public class SignUpController : Controller
    {
        // POST api/values
        [HttpPost]
        public SignUpResponse Post([FromBody]SignUpRequest signUpRequest)
        {
            return new SignUpResponse
            {
                message = "Thanks ! We will contact you shortly!",
                email = signUpRequest.email
            };
        }
    }
}
