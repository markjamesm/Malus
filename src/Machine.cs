using Malus.Devices;
using Velutia.Processor;

namespace Malus;

public class Machine
{
    // ProDOS HDC paravirtualization hook
    private const ushort ProdosHdcRomStart = 0xC700;
    
    // Apple II+ with Integer ROM Language Card
    private const ushort Apple2PlusRomStart = 0xD000;
    
    public Machine()
    {
        
    }

    public void Start()
    {
        var memory = new Memory();
        var a2Rom = RomLoader.LoadRom("apple2p.rom");
        
        memory.Load(a2Rom, Apple2PlusRomStart);
        memory.Load(ProDosHdcRom.ProDosHdcRomMap, ProdosHdcRomStart);
        
        var bus = new Bus(memory);
        var cpu = new Cpu(bus);

        cpu.Run();
    }
}