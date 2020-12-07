using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiDocusign.Services;

namespace WebApiDocusign.Controllers
{
    [Route("v1/Document")]
    public class DocumentControllers : Controller
    {

        [HttpGet]
        [Route("autorizacao")]
        public RedirectResult GetIndividualConsetiment()
        {
            return Redirect("https://account-d.docusign.com/oauth/auth?response_type=code&scope=signature%20impersonation&client_id=feb7e969-43d4-46dd-8447-b8f565986f2f&redirect_uri=https://localhost:5001/v1/Document/callback");

        }

        [HttpGet]
        [Route("callback")]

        public async Task<ActionResult<dynamic>> CallBack()
        {
            var settings = new Settings();
            var token = TokenService.GenerateToken(settings);
            return Ok(new { message = token });
        }



    }
}