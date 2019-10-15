using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alexa.NET;
using Alexa.NET.Request;
using Alexa.NET.Request.Type;
using Alexa.NET.Response;
using Amazon.Lambda.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace CornholeScoreboard
{
    public class Function
    {
        IConfiguration Configuration;
        IServiceProvider Services;
        public Function()
        {
            Configuration = Configure();
            Services = ConfigureServices();
        }
        private IServiceProvider ConfigureServices()
        {
            return new ServiceCollection()
                .AddMemoryCache()
                .BuildServiceProvider();
                
        }
        private IConfiguration Configure()
        {
            return new ConfigurationBuilder()
                .AddJsonFile("appsettings.json",true)
                .AddEnvironmentVariables()
                .Build();
        }

        public SkillResponse FunctionHandler(SkillRequest input, ILambdaContext context)
        {
            if(input.Request is LaunchRequest)
            {
                throw new NotImplementedException();
            }
            else if (input.Request is IntentRequest)
            {
                var intentRequest = input.Request as IntentRequest;
                if (intentRequest.Intent.Name.Equals(Constants.Intents.StartGameIntent))
                {
                    throw new NotImplementedException();
                }

            }

            return ResponseBuilder.Empty();

        }
    }
}
