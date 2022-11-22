using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace AzureWebApp
{
    public static class Function1
    {
        [FunctionName("HttpExample")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            Game game = new Game();
            
            int value = 5106;

            string result ="Is the number even? " + game.IsEven(value) + "\n" +
                           "Is the number odd? " + game.IsOdd(value) + "\n" +
                           "Is the number a perfect square? " + game.IsPerfectSquare(value) + "\n" +
                           "Is the number prime? " + game.IsPrime(value) + "\n";

            return new OkObjectResult(result);
            

        }
    }
}
