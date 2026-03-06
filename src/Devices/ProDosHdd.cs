namespace Malus.Devices;

public sealed class ProDosHdd
{
    private const int ProdosHddBytesPerBlock = 512;
    
    // Hard disk error codes
    private const byte ProDosHddErrorOk = 0x00;
    private const byte ProDosHddErrorIo = 0x27;
    private const byte ProDosHddErrorNoDevice = 0x28;
    private const byte ProDosHddErrorWprot = 0x2B;

    private const byte ProDosHddImageTypeInternal = 0;
    private const byte ProDosHddImageTypeMsc = 1;
}