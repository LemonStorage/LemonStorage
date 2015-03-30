namespace LemonStorage.Interfaces
{ 

    public interface IComputer
    {
         string Processor { get; set; }
         uint Ram { get; set; }
         uint HDDSize { get; set; }
         string VideoCardModel { get; set; }
         uint VideocardMemory { get; set; }
         string SoundCard { get; set; }

    }
}
