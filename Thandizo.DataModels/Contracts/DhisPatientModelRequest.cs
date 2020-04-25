namespace Thandizo.DataModels.Contracts
{
    public class DhisPatientModelRequest : IDhisPatientModelRequest
    {
        public DhisPatientModelRequest(long patientId)
        {
            PatientId = patientId;
        }

        public long PatientId { get; }
    }
}
