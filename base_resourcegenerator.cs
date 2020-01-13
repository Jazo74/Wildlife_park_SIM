namespace codecool.miskolc.zoltan.jarmy_wildlife.core
{
    abstract class ResourceGenerator
    {
        String ResourceType {get; set; }
        int Capacity { get; set; }
        int Load { get; set; }
        int GeneratePerCycle { get; set; }
        String State { get; set; } 
        int MaintenanceCycle { get; set; }
        abstract void Generate;
        abstract void Maintenance;
        abstract void Start;
        abstract void Shutdown;




    }
}