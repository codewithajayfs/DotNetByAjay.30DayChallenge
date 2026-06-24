namespace DotNetByAjay._30DayChallenge.Day_02
{
    /// <summary>
    /// CodeBlocks and Scope for C# Interviews
    /// 
    /// Covers:
    /// 1. VariableInCodeBlock
    /// 2. VariableOutCodeBlock
    /// 3. VariableAboveCodeBlock
    /// 4. VariableAboveCodeBlockV1
    /// 5. NestedBlockAccess
    /// 6. NestedBlockVariable
    /// 7. MultipleBlocksSameVariableName
    /// 8. LoopVariableScope
    /// 9. VariableShadowing
    /// 10. ClassScope
    /// </summary>
    public static class CodeBlocksAndScope
    {
        /// <summary>
        /// Output
        /// Inside the code block: 10
        /// </summary>
        public static void VariableInCodeBlock()
        {
            bool flag = true;
            if (flag)
            {
                int number = 10;
                Console.WriteLine($"Inside the code block: {number}");
            }
        }
    }
}