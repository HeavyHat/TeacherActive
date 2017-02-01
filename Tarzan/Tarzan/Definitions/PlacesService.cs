using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using RestSharp;
using System.Web;

namespace Tarzan.Definitions
{
    public class Place
    {

    }

    public class RESTService
    {
        private const string apiKey = "AIzaSyAKp3OYYL_JOPAiLLW0bp6y4IlK8QFa4Tw";


        private readonly string endpointUrl;

        public RESTService(string endpoint)
        {
            VerifyValidEndpoint(endpoint);
            endpointUrl = endpoint;
        }

        public string GetRequest(IDictionary<string,string> parameters)
        {
            RestClient client = new RestClient();
            RestRequest request = new RestRequest(endpointUrl, Method.GET);
            foreach (var key in parameters.Keys)
                request.AddParameter(key, parameters[key]);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        private void VerifyValidEndpoint(string endPoint)
        {
            Uri actualUri;
            if (!Uri.TryCreate(endPoint, UriKind.RelativeOrAbsolute, out actualUri))
                throw new InvalidDataException("Not a valid endpoint: " + endPoint);
        }
    }

}
