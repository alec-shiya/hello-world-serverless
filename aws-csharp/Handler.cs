using Amazon.Lambda.Core;
using System;
using System.Collections.Generic;
using System.Net;
using Amazon.Lambda.APIGatewayEvents;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace AwsDotnetCsharp
{
    public class Handler
    {
        public APIGatewayProxyResponse Hello(APIGatewayProxyRequest request, ILambdaContext context)
        {
            // Log entries show up in CloudWatch
            context.Logger.LogLine("Example log entry\n");

            var response = new APIGatewayProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = $"{{\"Message\": \"{GetResponseMessage()}\"}}",
                Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } }
            };

            return response;
        }

	    public string GetResponseMessage()
	    {
		    return "Hello World updated";
	    }
    }

    public class Response
    {
        public string Message { get; set; }
        public Request Request { get; set; }

        public Response(string message, Request request)
        {
            Message = message;
            Request = request;
        }
    }

    public class Request
    {
        public string Key1 { get; set; }
        public string Key2 { get; set; }
        public string Key3 { get; set; }

        public Request(string key1, string key2, string key3)
        {
            Key1 = key1;
            Key2 = key2;
            Key3 = key3;
        }
    }
}
