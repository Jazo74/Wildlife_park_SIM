namespace codecool.miskolc.zoltan.jarmy.wildlife_park.core
{
    abstract class Animal
    {
        abstract protected String ReqEnvironment { get; set; }
        abstract protected int ReqTemperature { get; set; }
        abstract protected int ReqWind { get; set; }
        abstract protected String Food { get; set; } 
        abstract String Living();
        abstract String Eating();
    }
}