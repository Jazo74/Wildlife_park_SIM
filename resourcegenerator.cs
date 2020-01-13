namespace codecool.miskolc.zoltan.jarmy.wildlife.core
{
    abstract class ResourceGenerator
    {
        String ResourceType {get; set; }
        int Capacity { get; set; }
        int Load { get; set; }
        int OneUnit { get; set; }
        abstract void generate;


    }
}