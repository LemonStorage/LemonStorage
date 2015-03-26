namespace LemonStorage.Interfaces
{ 

    public interface IComputer
    {
        public string Processor { get; set; }
        public uint Ram { get; set; }
        public uint HDDSize { get; set; }
        public string VideoCardModel { get; set; }
        public uint VideocardMemory { get; set; }
        public string SoundCard { get; set; }

    }
}
