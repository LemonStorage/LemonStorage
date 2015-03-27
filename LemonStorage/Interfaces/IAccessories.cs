namespace LemonStorage.Interfaces
{
    using System;

    public interface IAccessories
    {
        ConsoleColor Color { get; set; } // ???? Coupling with the console
        string Material { get; set; }
    }
}
