using DotNetByAjay._30DayChallenge;
using DotNetByAjay._30DayChallenge.Day_01;
using DotNetByAjay._30DayChallenge.Day_02;

Console.WriteLine("S.No.\t30 Day .Net Challenge\tTutorial\r\nDay 01\tBoolean Expressions\t\r\nDay 02\tVariable Scope & Logic Control\t");
int dayValue;
Console.WriteLine("Enter Day value in integer");
while (true)
{
    var input = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out dayValue) && dayValue >= 1 && dayValue <= 30)
        break;
    Console.WriteLine("Invalid input. Please enter a valid integer between 1 and 30:");
    Console.WriteLine("Invalid input. Please enter a valid integer for Day value:");
}

var result = ChooseFrom30DayChallenge(dayValue);
Console.WriteLine(result);

#region Switch Day to be executed
static string ChooseFrom30DayChallenge(int value)
{
    return value switch
    {
        (int)_30DayChallengeEnum.Day1 => ExecuteDay1(),
        (int)_30DayChallengeEnum.Day2 => ExecuteDay2(),
        _ => "invalid day"
    };
}
#endregion

#region Day 1 - Expressions
static string ExecuteDay1()
{
    Expressions.CheckEqualityOperator();
    Expressions.CheckEqualityBuiltInMethods();
    Expressions.CheckInequalityOperator();
    Expressions.CheckComparisonOperators();
    Expressions.CheckBooleanMethods();
    Expressions.CheckEqualsVsDoubleEquals();
    Expressions.CheckReferenceEquality();
    Expressions.CheckCaseInsensitiveComparison();
    Expressions.CheckNullComparison();
    Expressions.CheckNullSafeEquals();
    Expressions.CheckShortCircuitAnd();
    Expressions.CheckNonShortCircuitAnd();
    Expressions.CheckShortCircuitOr();
    Expressions.CheckNonShortCircuitOr();
    Expressions.CheckContainsIgnoreCase();
    Expressions.CheckFloatingPointComparison();
    Expressions.CheckObjectEquality();
    Expressions.CheckIsOperator();
    Expressions.CheckPatternMatching();
    Expressions.CheckNullCoalescing();
    Expressions.CheckNullCoalescingAssignment();
    Expressions.CheckTernaryOperator();
    Expressions.CheckLogicalNot();
    Expressions.CheckStringInterpolation();
    Expressions.CheckOperatorPrecedence();

    return "Executed Day 1 successfully..!!";
}
#endregion

#region Day 2 - Variable Scope & Logic Control with Code Blocks
static string ExecuteDay2()
{

    CodeBlocksAndScope.VariableInCodeBlock();

    return "Executed Day 2 successfully..!!";
}

#endregion