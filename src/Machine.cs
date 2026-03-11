using Malus.Devices;
using Velutia.Processor;

namespace Malus;

public class Machine
{
    public static void Start()
    {
        var memory = InitializeMemory();
        var bus = new Bus(memory);
        var cpu = new Cpu(bus);

        EmulationLoop(cpu);
    }
    
    private static void EmulationLoop(Cpu cpu)
    {
        while (true)
        {
            cpu.RunInstruction();
        }
    }

    private static Memory InitializeMemory()
    {
        const ushort prodosHdcRomStart = 0xC700;
        const ushort apple2PlusRomStart = 0xD000;
        const ushort a2AuditStart = 0x6000;
        
        var memory = new Memory();
        
        var a2Rom = RomLoader.LoadRom("apple2p.rom");
        var a2Audit = RomLoader.LoadRom("audit107.bin");
        
        memory.Load(a2Rom, apple2PlusRomStart);
        memory.Load(a2Audit, a2AuditStart);
        memory.Load(ProDosHdcRom.ProDosHdcRomMap, prodosHdcRomStart);
        
        return memory;
    }
}