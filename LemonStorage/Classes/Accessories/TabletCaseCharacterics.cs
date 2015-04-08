namespace LemonStorage.Classes.Accessories
{
    public struct TabletCaseCharacterics
    {
        public string Material { get; set; }
        public double Size { get; set; }

        public TabletCaseCharacterics(string material = "Leather", double size = 10)
            :this()
        {
            this.Material = material;
            this.Size = size;
        }
    }
}
