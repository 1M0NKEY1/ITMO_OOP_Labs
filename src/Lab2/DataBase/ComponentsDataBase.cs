using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.ComputerCase;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.CoolingSystem;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.Factory;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.SocketType;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU.SocketType.OnlyAmd;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.PowerUnit.Factory;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.RAM.Factory;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.ChipSetDir;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.AuxiliaryСomponents.SataTypeDir;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.Motherboards.MotherBoardFactory;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.SSDs.Factory;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.SSDs.InputTypeDir;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards.Factory;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards.PCIVersionDir;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapters;
using Itmo.ObjectOrientedProgramming.Lab2.XMPProfile;

namespace Itmo.ObjectOrientedProgramming.Lab2.DataBase;

public static class ComponentsDataBase
{
    private const string? NameFormula = "Formula CL-3303W RGB";
    private const int LengthFormula = 310;
    private const int WidthFormula = 192;
    private const int FormFactorFormula = 305 * 244;
    private const int DimensionsFormula = 192 * 455 * 360;

    private const string? NameFormulaCr = "Formula Crystal Z5";
    private const int LengthFormulaCr = 365;
    private const int WidthFormulaCr = 270;
    private const int FormFactorFormulaCr = 244 * 244;
    private const int DimensionsFormulaCr = 270 * 368 * 388;

    private const string? NameDeep = "DEEPCOOL GAMMAXX 400K";
    private const int CoolingDimensionsDeep = 155;
    private const int CoolingTdpDeep = 180;

    private const string? NameSe = "ID-Cooling SE-207-TRX BLACK";
    private const int CoolingDimensionsSe = 157;
    private const int CoolingTdpSe = 280;

    private const string? NameJons = "JONSBO CR-1400 EVO";
    private const int CoolingDimensionsJons = 130;
    private const int CoolingTdpJons = 180;

    private const string? NameNoctua = "Noctua NH-D15";
    private const int CoolingDimensionsNoctua = 165;
    private const int CoolingTdpNoctua = 220;

    private const string? NameRyzenth = "Ryzen Threadripper PRO 3955WX BOX";
    private const int CoreFrequencyRyzenth = 3700;
    private const int CoreRyzenth = 16;
    private const bool IntegratedGraphicsRyzenth = false;
    private const int SupportedMemoryRyzenth = 3200;
    private const int TdpRyzenth = 280;
    private const int PowerRyzenth = 200;

    private const string? NameRyzenNine = "Ryzen 9 7900 OEM";
    private const int CoreFrequencyRyzenNine = 3700;
    private const int CoreRyzenNine = 12;
    private const bool IntegratedGraphicsRyzenNine = true;
    private const int SupportedMemoryRyzenNine = 5200;
    private const int TdpRyzenNine = 65;
    private const int PowerRyzenNine = 100;

    private const string? NameRyzenSeven = "Ryzen 7 7700 OEM";
    private const int CoreFrequencyRyzenSeven = 3800;
    private const int CoreRyzenSeven = 6;
    private const bool IntegratedGraphicsRyzenSeven = true;
    private const int SupportedMemoryRyzenSeven = 5200;
    private const int TdpRyzenSeven = 65;
    private const int PowerRyzenSeven = 100;

    private const string? NameRyzenFive = "Ryzen 5 7600 OEM";
    private const int CoreFrequencyRyzenFive = 3800;
    private const int CoreRyzenFive = 6;
    private const bool IntegratedGraphicsRyzenFive = true;
    private const int SupportedMemoryRyzenFive = 5200;
    private const int TdpRyzenFive = 190;
    private const int PowerRyzenFive = 100;

    private const string? NameIntelNine = "Intel Core i9-10900x";
    private const int CoreFrequencyIntelNine = 3700;
    private const int CoreIntelNine = 10;
    private const bool IntegratedGraphicsIntelNine = false;
    private const int SupportedMemoryIntelNine = 2933;
    private const int TdpIntelNine = 165;
    private const int PowerIntelNine = 100;

    private const string? NameIntelSeven = "Inte Core i7-13700KF";
    private const int CoreFrequencyIntelSeven = 3400;
    private const int CoreIntelSeven = 16;
    private const bool IntegratedGraphicsIntelSeven = false;
    private const int SupportedMemoryIntelSeven = 5600;
    private const int TdpIntelSeven = 253;
    private const int PowerIntelSeven = 100;

    private const string? NameIntelFive = "Intel Core i5-6500";
    private const int CoreFrequencyIntelFive = 3200;
    private const int CoreIntelFive = 4;
    private const bool IntegratedGraphicsIntelFive = true;
    private const int SupportedMemoryIntelFive = 2133;
    private const int TdpIntelFive = 40;
    private const int PowerIntelFive = 100;

    private const string? NameGigabyte = "GIGABYTE B550M AORUS ELITE";
    private const int DDRGigabyte = 4;
    private const int RamTableCountGigabyte = 288;
    private const int FormFactorGigabyte = 244 * 244;
    private const int BiosTypeGigabyte = 4;

    private const string? NameEsonic = "Esonic H61FHL";
    private const int DDREsconic = 5;
    private const int RamTableCountEsonic = 288;
    private const int FormFactorEsonic = 244 * 244;
    private const int BiosTypeEsconic = 4;

    private const string? NameCouger = "Cougar VTE X2 750";
    private const int PowerLimitsCouger = 600;

    private const string? NameExeGate = "ExeGate UN850";
    private const int PowerLimitsExeGate = 850;

    private const string? NameFour = "DDR4-3200";
    private const int MemoryLimitsFour = 128;
    private const int RamFormFactorFour = 288;
    private const int VersionDDRFour = 4;
    private const int PowerFour = 10;

    private const string? NameFive = "DDR5-1500";
    private const int MemoryLimitsFive = 128;
    private const int RamFormFactorFive = 288;
    private const int VersionDDRFive = 5;
    private const int PowerFive = 15;

    private const string? NameKingston = "KINGSTON mSATA SSD SKC600";
    private const int MemoryKingston = 512;
    private const int SpeedKingston = 550;
    private const int PowerKingston = 10;

    private const string? NameNetac = "Netac 1 ТБ M.2 NT01NV7000-1T0-E4X";
    private const int MemoryNetac = 1024;
    private const int SpeedNetac = 7200;
    private const int PowerNetac = 25;

    private const string? NameGigabyteForce = "GIGABYTE GeForce RTX 4060 Ti EAGLE";
    private const int LebgthGigabyte = 272;
    private const int WidthGigabyte = 115;
    private const int FrequencyGigabyte = 2535;
    private const int PowerGigabyte = 500;

    private const string? NameNvideo = "NVIDIA GeForce GTX 1650";
    private const int LebgthNvideo = 174;
    private const int WidthNvideo = 126;
    private const int FrequencyNvideo = 1410;
    private const int PowerNvideo = 300;

    private const string? NameLtx = "USB LTX-W04 3dBi";
    private const int VersionLtx = 4;
    private const bool BluetoothLtx = false;
    private const int AdapterPowerLtx = 25;

    private const string? NameMercus = "Mercusys MW150US";
    private const int VersionMercus = 3;
    private const bool BluetoothMercus = true;
    private const int AdapterPowerMercus = 25;

    private static readonly IList<IComponent> _allComponents = new List<IComponent>();
    private static readonly CoolingSystemFactoryAmd _coolingSystemFactoryAmd = new();
    private static readonly CoolingSystemFactoryIntel _coolingSystemFactoryIntel = new();
    private static readonly AmdCPUFactory _amdCpuFactory = new();
    private static readonly IntelCPUFactory _intelCpuFactory = new();
    private static readonly CurrentMotherBoardFactory _currentMotherBoardFactory = new();
    private static readonly CurrentPowerUnitFactory _currentPowerUnitFactory = new();
    private static readonly CurrentRamFactory _currentRamFactory = new();
    private static readonly CurrentSSDFactory _currentSsdFactory = new();
    private static readonly CurrentVideoCardFactory _currentVideoCardFactory = new();

    public static void FillDataBase()
    {
        _allComponents.Add(new CurrentComputerCase(
            NameFormula,
            LengthFormula,
            WidthFormula,
            FormFactorFormula,
            DimensionsFormula));

        _allComponents.Add(new CurrentComputerCase(
            NameFormulaCr,
            LengthFormulaCr,
            WidthFormulaCr,
            FormFactorFormulaCr,
            DimensionsFormulaCr));

        _coolingSystemFactoryAmd.NewInstance(
            NameDeep,
            CoolingDimensionsDeep,
            CoolingTdpDeep,
            new AM5());
        _allComponents.Add(_coolingSystemFactoryAmd.Create());

        _coolingSystemFactoryAmd.NewInstance(
            NameSe,
            CoolingDimensionsSe,
            CoolingTdpSe,
            new WRX8());
        _allComponents.Add(_coolingSystemFactoryAmd.Create());

        _coolingSystemFactoryIntel.NewInstance(
            NameJons,
            CoolingDimensionsJons,
            CoolingTdpJons,
            new LGA1151());
        _allComponents.Add(_coolingSystemFactoryAmd.Create());

        _coolingSystemFactoryIntel.NewInstance(
            NameNoctua,
            CoolingDimensionsNoctua,
            CoolingTdpNoctua,
            new LGA2066());
        _allComponents.Add(_coolingSystemFactoryIntel.Create());

        _amdCpuFactory.NewInstance(
            NameRyzenth,
            CoreFrequencyRyzenth,
            CoreRyzenth,
            new WRX8(),
            IntegratedGraphicsRyzenth,
            SupportedMemoryRyzenth,
            TdpRyzenth,
            PowerRyzenth);
        _allComponents.Add(_amdCpuFactory.Create());

        _amdCpuFactory.NewInstance(
            NameRyzenNine,
            CoreFrequencyRyzenNine,
            CoreRyzenNine,
            new AM5(),
            IntegratedGraphicsRyzenNine,
            SupportedMemoryRyzenNine,
            TdpRyzenNine,
            PowerRyzenNine);
        _allComponents.Add(_amdCpuFactory.Create());

        _amdCpuFactory.NewInstance(
            NameRyzenSeven,
            CoreFrequencyRyzenSeven,
            CoreRyzenSeven,
            new AM5(),
            IntegratedGraphicsRyzenSeven,
            SupportedMemoryRyzenSeven,
            TdpRyzenSeven,
            PowerRyzenSeven);
        _allComponents.Add(_amdCpuFactory.Create());

        _amdCpuFactory.NewInstance(
            NameRyzenFive,
            CoreFrequencyRyzenFive,
            CoreRyzenFive,
            new AM5(),
            IntegratedGraphicsRyzenFive,
            SupportedMemoryRyzenFive,
            TdpRyzenFive,
            PowerRyzenFive);
        _allComponents.Add(_amdCpuFactory.Create());

        _intelCpuFactory.NewInstance(
            NameIntelNine,
            CoreFrequencyIntelNine,
            CoreIntelNine,
            new LGA2066(),
            IntegratedGraphicsIntelNine,
            SupportedMemoryIntelNine,
            TdpIntelNine,
            PowerIntelNine);
        _allComponents.Add(_intelCpuFactory.Create());

        _intelCpuFactory.NewInstance(
            NameIntelSeven,
            CoreFrequencyIntelSeven,
            CoreIntelSeven,
            new LGA1151(),
            IntegratedGraphicsIntelSeven,
            SupportedMemoryIntelSeven,
            TdpIntelSeven,
            PowerIntelSeven);
        _allComponents.Add(_intelCpuFactory.Create());

        _intelCpuFactory.NewInstance(
            NameIntelFive,
            CoreFrequencyIntelFive,
            CoreIntelFive,
            new LGA1151(),
            IntegratedGraphicsIntelFive,
            SupportedMemoryIntelFive,
            TdpIntelFive,
            PowerIntelFive);
        _allComponents.Add(_intelCpuFactory.Create());

        _currentMotherBoardFactory.NewInstance(
            NameGigabyte,
            new AM5(),
            new PCIE4(),
            new Sata4(),
            new AmdChip(),
            DDRGigabyte,
            RamTableCountGigabyte,
            FormFactorGigabyte,
            BiosTypeGigabyte);
        _allComponents.Add(_currentMotherBoardFactory.Create());

        _currentMotherBoardFactory.NewInstance(
            NameEsonic,
            new LGA1151(),
            new PCIE4(),
            new Sata3(),
            new IntelChip(),
            DDREsconic,
            RamTableCountEsonic,
            FormFactorEsonic,
            BiosTypeEsconic);
        _allComponents.Add(_currentMotherBoardFactory.Create());

        _currentPowerUnitFactory.NewInstance(NameCouger, PowerLimitsCouger);
        _allComponents.Add(_currentPowerUnitFactory.Create());

        _currentPowerUnitFactory.NewInstance(NameExeGate, PowerLimitsExeGate);
        _allComponents.Add(_currentPowerUnitFactory.Create());

        _currentRamFactory.NewInstance(
            NameFour,
            MemoryLimitsFour,
            new Xmp(20, 20, 20),
            RamFormFactorFour,
            VersionDDRFour,
            PowerFour);
        _allComponents.Add(_currentRamFactory.Create());

        _currentRamFactory.NewInstance(
            NameFive,
            MemoryLimitsFive,
            new Xmp(20, 12, 18),
            RamFormFactorFive,
            VersionDDRFive,
            PowerFive);
        _allComponents.Add(_currentRamFactory.Create());

        _currentSsdFactory.NewInstance(
            NameKingston,
            new TypeSata(),
            MemoryKingston,
            SpeedKingston,
            PowerKingston);
        _allComponents.Add(_currentSsdFactory.Create());

        _currentSsdFactory.NewInstance(
            NameNetac,
            new TypePCIE(),
            MemoryNetac,
            SpeedNetac,
            PowerNetac);
        _allComponents.Add(_currentSsdFactory.Create());

        _currentVideoCardFactory.NewInstance(
            NameGigabyteForce,
            LebgthGigabyte,
            WidthGigabyte,
            new PCIE4(),
            FrequencyGigabyte,
            PowerGigabyte);
        _allComponents.Add(_currentVideoCardFactory.Create());

        _currentVideoCardFactory.NewInstance(
            NameNvideo,
            LebgthNvideo,
            WidthNvideo,
            new PCIE3(),
            FrequencyNvideo,
            PowerNvideo);
        _allComponents.Add(_currentVideoCardFactory.Create());

        _allComponents.Add(new CurrentWifiAdapter(
            NameLtx,
            VersionLtx,
            BluetoothLtx,
            new PCIE4(),
            AdapterPowerLtx));

        _allComponents.Add(new CurrentWifiAdapter(
            NameMercus,
            VersionMercus,
            BluetoothMercus,
            new PCIE4(),
            AdapterPowerMercus));
    }

    public static IComponent? GetByName(string name)
    {
        return _allComponents.FirstOrDefault(comp =>
            name.Equals(comp.Name, System.StringComparison.Ordinal));
    }

    public static void AddNewComponent(IComponent component)
    {
        _allComponents.Add(component);
    }
}