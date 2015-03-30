namespace LemonStorage.Classes.Accessories
{
    using LemonStorage.Interfaces;
    using System;

    public class InEarHeadset : Headphone, IProduct
    {      
         public InEarHeadset(int price, string brand, string model, string color, int weightInGrams, int minFrequencyInHz, int maxFrequencyInHz, int sensitivityINkHz, int inputPowerINmW, double lengthOfConnectionInMeters, string conectorType, double diametre)
            : base(price, brand, model, color, weightInGrams, minFrequencyInHz, maxFrequencyInHz, sensitivityINkHz, inputPowerINmW, lengthOfConnectionInMeters, conectorType)
        {

        }      

    }
}
