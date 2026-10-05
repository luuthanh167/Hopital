public class Prescription
{
    public string MedicationName { get; }
    public string Dosage { get; }
    public string Instructions { get; }

    public Prescription(
        string medicationName,
        string dosage,
        string instructions)
    {
        ValidationHelper.RequireNotEmpty(medicationName,"Medication name");
        ValidationHelper.RequireNotEmpty(dosage,"Dosage");
        ValidationHelper.RequireNotEmpty(instructions,"Instructions");

        MedicationName = medicationName;
        Dosage = dosage;
        Instructions = instructions;
    }

    public override string ToString()
    {
        return $"{MedicationName} - {Dosage} - {Instructions}";
    }
}