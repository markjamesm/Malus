using Velutia.Bus;

namespace Malus;

public sealed class Bus: IBus
{
    private readonly Memory _memory;
    
    public Bus(Memory memory)
    {
        _memory = memory;
    }

    public byte Read(ushort address)
    {
        return _memory[address];
    }

    public void Write(ushort address, byte value)
    {
        _memory[address] = value;
    }
}