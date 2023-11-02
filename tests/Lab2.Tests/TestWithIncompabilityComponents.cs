using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.ComputerCase;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.CoolingSystem;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.CPU;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.PowerUnit;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.RAM;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.Builder;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.Motherboards;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.SSDs;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards;
using Itmo.ObjectOrientedProgramming.Lab2.DataBase;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapters;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab2.Tests;

public class TestWithIncompabilityComponents
{
    private const string _caseName = "Formula Crystal Z5";
    private const string _coolingName = "DEEPCOOL GAMMAXX 400K";
    private const string _cpuName = "Intel Core i9-10900x";
    private const string _motherboardName = "GIGABYTE B550M AORUS ELITE";
    private const string _powerUnitName = "ExeGate UN850";
    private const string _ramName = "DDR4-3200";
    private const string _ssdName = "Netac 1 ТБ M.2 NT01NV7000-1T0-E4X";
    private const string _videocardName = "NVIDIA GeForce GTX 1650";
    private const string _wifiAdapterName = "USB LTX-W04 3dBi";

    private readonly BuildComputer _buildComputer = new();

    public static IEnumerable<object[]> GetObjects
    {
        get
        {
            yield return new object[]
            {
                _caseName,
                _coolingName,
                _cpuName,
                _motherboardName,
                _powerUnitName,
                _ramName,
                _ssdName,
                _videocardName,
                _wifiAdapterName,
            };
        }
    }

    public static bool CompleteBuild(BuildComputer buildComputer)
    {
        IList<ComputerBuildResult> result = buildComputer.GetResultMessage();

        return result is [ComputerBuildResult.WrongSocket];
    }

    [Theory]
    [MemberData(nameof(GetObjects), MemberType = typeof(TestWithIncompabilityComponents))]
    public void AllObjectsAreOddWithMemberDataFromDataGenerator(
        string caseName,
        string coolingName,
        string cpuName,
        string motherboardName,
        string powerUnitName,
        string ramName,
        string ssdName,
        string videoCardName,
        string wifiAdapterName)
    {
        ComponentsDataBase.FillDataBase();

        _buildComputer.WithComputerCase((ComputerCasesBase?)ComponentsDataBase.GetByName(caseName)
                                        ?? throw new CreateBuilderNullException(caseName));
        _buildComputer.WithCoolingSystem((CoolingSystemsBase?)ComponentsDataBase.GetByName(coolingName)
                                         ?? throw new CreateBuilderNullException(coolingName));
        _buildComputer.WithCpu((CpuBase?)ComponentsDataBase.GetByName(cpuName)
                               ?? throw new CreateBuilderNullException(cpuName));
        _buildComputer.WithMotherboard((MotherBoardBase?)ComponentsDataBase.GetByName(motherboardName)
                                       ?? throw new CreateBuilderNullException(motherboardName));
        _buildComputer.WithPowerUnit((PowerUnitBase?)ComponentsDataBase.GetByName(powerUnitName)
                                     ?? throw new CreateBuilderNullException(powerUnitName));
        _buildComputer.WithRam((RamBase?)ComponentsDataBase.GetByName(ramName)
                               ?? throw new CreateBuilderNullException(ramName));
        _buildComputer.WithSsd((SSDBase?)ComponentsDataBase.GetByName(ssdName)
                               ?? throw new CreateBuilderNullException(ssdName));
        _buildComputer.WithVideoCard((VideoCardBase?)ComponentsDataBase.GetByName(videoCardName)
                                     ?? throw new CreateBuilderNullException(videoCardName));
        _buildComputer.WithWifiAdapter((WifiAdapterBase?)ComponentsDataBase.GetByName(wifiAdapterName)
                                       ?? throw new CreateBuilderNullException(wifiAdapterName));

        Assert.True(CompleteBuild(_buildComputer));
    }
}