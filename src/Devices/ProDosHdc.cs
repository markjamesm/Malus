namespace Malus.Devices;

public class ProDosHdc
{
    private const byte ProDosHdcRcA = 0x00; // Return code register A
    private const byte ProDosHdcRcX = 0x01; // Return code register X
    private const byte ProDosHdcRcY = 0x02; // Return code Register Y
    private const byte ProDosHdcPara = 0x07; // Paravirtualization trigger

    private const byte ProdosHdcMagic = 0x65;
    private const int ProdosHdcMaxDrives = 2;
    
    // ProDOS disk driver parameters
    private const ushort ProDosDriveCommand = 0x0042;
    private const ushort ProDosDriveUnit = 0x0043;
    private const ushort ProDosDriveBuffer = 0x0044;
    private const ushort ProDosDriveBlock = 0x0046;
    
    // ProDOS disk driver commands
    private const byte ProDosCmdStatus = 0x00;
    private const byte ProDosCmdRead = 0x01;
    private const byte ProDosCmdWrite = 0x02;
    private const byte ProDosCmdFormat = 0x04;
    
    
}