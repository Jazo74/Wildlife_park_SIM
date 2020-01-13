namespace codecool.miskolc.zoltan_jarmy.wildlife_park.core
{
    abstract class Animal
    {

        int ReqHeatUnit {get; set;}
        int ReqLightUnit {get; set;}
        int ReqEnergyUnit {get; set;}
        int ReqFoodUnit {get; set;}
        int ReqOxigenUnit {get; set;}

        abstract String ReqEnvironment { get; set; }
        abstract int ReqMinTemperature { get; set; }
        abstract int ReqMaxTemperature { get; set; }
        abstract int ReqWind { get; set; }
        abstract String Food { get; set; } 
        abstract String Living();
        abstract String Eating();
    }
}