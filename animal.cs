namespace codecool.miskolc.zoltan.jarmy.wildlife_park.core
{
    abstract class Animal
    {
        abstract String ReqEnvironment { get; set; }
        abstract int ReqMinTemperature { get; set; }
        abstract int ReqMaxTemperature { get; set; }
        abstract int ReqWind { get; set; }
        abstract String Food { get; set; } 
        abstract String Living();
        abstract String Eating();
    }
}