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

/// <summary>
/// Current Power = 650 but accessable Power = 650.
/// </summary>
public class TestBuildWithCriticalPower
{
    private const string _caseName = "Formula Crystal Z5";
    private const string _coolingName = "ID-Cooling SE-207-TRX BLACK";
    private const string _cpuName = "Ryzen 5 7600 OEM";
    private const string _motherboardName = "GIGABYTE B550M AORUS ELITE";
    private const string _powerUnitName = "Cougar VTE X2 750";
    private const string _ramName = "DDR4-3200";
    private const string _ssdName = "Netac 1 ТБ M.2 NT01NV7000-1T0-E4X";
    private const string _videocardName = "GIGABYTE GeForce RTX 4060 Ti EAGLE";
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

        return result is [ComputerBuildResult.Success, ComputerBuildResult.CriticalPower];
    }

    [Theory]
    [MemberData(nameof(GetObjects), MemberType = typeof(TestBuildWithCriticalPower))]
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

        _buildComputer.WithComputerCase((ComputerCases?)ComponentsDataBase.GetByName(caseName)
                                        ?? throw new CreateBuilderNullException(caseName));
        _buildComputer.WithCoolingSystem((CoolingSystems?)ComponentsDataBase.GetByName(coolingName)
                                         ?? throw new CreateBuilderNullException(coolingName));
        _buildComputer.WithCpu((Cpu?)ComponentsDataBase.GetByName(cpuName)
                               ?? throw new CreateBuilderNullException(cpuName));
        _buildComputer.WithMotherboard((MotherBoard?)ComponentsDataBase.GetByName(motherboardName)
                                       ?? throw new CreateBuilderNullException(motherboardName));
        _buildComputer.WithPowerUnit((PowerUnit?)ComponentsDataBase.GetByName(powerUnitName)
                                     ?? throw new CreateBuilderNullException(powerUnitName));
        _buildComputer.WithRam((Ram?)ComponentsDataBase.GetByName(ramName)
                               ?? throw new CreateBuilderNullException(ramName));
        _buildComputer.WithSsd((SSD?)ComponentsDataBase.GetByName(ssdName)
                               ?? throw new CreateBuilderNullException(ssdName));
        _buildComputer.WithVideoCard((VideoCard?)ComponentsDataBase.GetByName(videoCardName)
                                     ?? throw new CreateBuilderNullException(videoCardName));
        _buildComputer.WithWifiAdapter((WifiAdapter?)ComponentsDataBase.GetByName(wifiAdapterName)
                                       ?? throw new CreateBuilderNullException(wifiAdapterName));

        Assert.True(CompleteBuild(_buildComputer));
    }
}