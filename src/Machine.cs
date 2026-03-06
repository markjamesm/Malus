using Velutia.Processor;

namespace Malus;

public class Machine
{
    public Machine()
    {
        
    }

    public void Start()
    {
        var memory = new Memory();
        
        // Load Apple II+ ROM at $D000 - $FFFF
        var a2Rom = RomLoader.LoadRom("apple2p.rom");
        memory.Load(a2Rom, 0xD000);
        
        var bus = new Bus(memory);
        var cpu = new Cpu(bus);

        cpu.Run();
    }
}