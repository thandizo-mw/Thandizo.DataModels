﻿namespace Thandizo.DataModels.Integrations.Responses
{
    public class DhisResponse
    {
        public string HttpStatus { get; set; }
        public int HttpStatusCode { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public ImportResponse Response { get; set; }        
    }
}
