namespace Thandizo.DataModels.General
{
    public class OutputResponse
    {
        public bool IsErrorOccured { get; set; }
        public string Message { get; set; }
        public object Result { get; set; }
        public string ResponseCode { get; set; }
    }
}
