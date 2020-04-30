namespace Thandizo.DataModels.Ussd
{
    public enum SessionType
    {
        /// <summary>
        /// New request from mobile device 
        /// </summary>
        New = 1,
        /// <summary>
        /// Continuation of previous session
        /// </summary>
        Continious = 2,
        /// <summary>
        /// End of session
        /// </summary>
        End = 3
    }
}
