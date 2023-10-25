using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.SocketType;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.SocketType.OnlyAmd;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.ChipSetDir;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.SataTypeDir;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.Motherboards.MotherBoardFactory;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards.PCIVersionDir;

namespace Itmo.ObjectOrientedProgramming.Lab2.DataBase.MotherBoardSelection;

public class MotherboardSelection
{
    private const string NameGigabyte = "GIGABYTE B550M AORUS ELITE";
    private const int DDRGigabyte = 4;
    private const int RamTableCountGigabyte = 4;
    private const int FormFactorGigabyte = 244 * 244;
    private const int BiosTypeGigabyte = 4;

    private const string NameEsonic = "Esonic H61FHL";
    private const int DDREsconic = 5;
    private const int RamTableCountEsonic = 4;
    private const int FormFactorEsonic = 244 * 244;
    private const int BiosTypeEsconic = 4;

    private List<MotherBoardFactory> motherboard = new();

    public MotherboardSelection()
    {
        motherboard.Add(new CurrentMotherBoardFactory(
            NameGigabyte,
            new AMFive(),
            new PCIE3(),
            new SataFour(),
            new AmdChip(),
            DDRGigabyte,
            RamTableCountGigabyte,
            FormFactorGigabyte,
            BiosTypeGigabyte));

        motherboard.Add(new CurrentMotherBoardFactory(
            NameEsonic,
            new LGAOneOneFiveOne(),
            new PCIE4(),
            new SataThree(),
            new IntelChip(),
            DDREsconic,
            RamTableCountEsonic,
            FormFactorEsonic,
            BiosTypeEsconic));
    }
}