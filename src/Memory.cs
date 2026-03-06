namespace Malus;

public sealed class Memory
{
    private const int MemorySize = 64 * 1024;
    private readonly byte[] _ram = new byte[MemorySize];

    public byte this[ushort address]
    {
        get => _ram[address];
        set => _ram[address] = value;
    }
}