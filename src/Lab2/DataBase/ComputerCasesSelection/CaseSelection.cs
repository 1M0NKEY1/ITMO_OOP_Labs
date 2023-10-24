using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Computer.ComputerCase;

namespace Itmo.ObjectOrientedProgramming.Lab2.DataBase.ComputerCasesSelection;

public class CaseSelection
{
    private const string NameFormula = "Formula CL-3303W RGB";
    private const int LengthFormula = 310;
    private const int WidthFormula = 192;
    private const int FormFactorFormula = 305 * 244;
    private const int DimensionsFormula = 192 * 455 * 360;

    private const string NameFormulaCr = "Formula Crystal Z5";
    private const int LengthFormulaCr = 365;
    private const int WidthFormulaCr = 270;
    private const int FormFactorFormulaCr = 244 * 244;
    private const int DimensionsFormulaCr = 270 * 368 * 388;

    private List<ComputerCases> caseList = new();

    public CaseSelection()
    {
        caseList.Add(new CurrentComputerCase(
            NameFormula,
            LengthFormula,
            WidthFormula,
            FormFactorFormula,
            DimensionsFormula));

        caseList.Add(new CurrentComputerCase(
            NameFormulaCr,
            LengthFormulaCr,
            WidthFormulaCr,
            FormFactorFormulaCr,
            DimensionsFormulaCr));
    }
}