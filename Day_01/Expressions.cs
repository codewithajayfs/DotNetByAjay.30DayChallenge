using System;
using System.Collections.Generic;

namespace DotNetByAjay._30DayChallenge.Day_01
{
    /// <summary>
    /// Expression Examples for C# Interviews
    /// 
    /// Covers:
    /// 1. Equality Operators
    /// 2. Inequality Operators
    /// 3. Comparison Operators
    /// 4. Boolean/String Methods
    /// 5. == vs Equals()
    /// 6. ReferenceEquals()
    /// 7. Case-Insensitive Comparison
    /// 8. Null Comparison
    /// 9. Null-Safe Equals
    /// 10. Short-Circuit AND (&&)
    /// 11. Non-Short-Circuit AND (&)
    /// 12. Short-Circuit OR (||)
    /// 13. Non-Short-Circuit OR (|)
    /// 14. Contains() with Ignore Case
    /// 15. Floating Point Comparison
    /// 16. Object Equality
    /// 17. is Operator
    /// 18. Pattern Matching
    /// 19. Null-Coalescing (??)
    /// 20. Null-Coalescing Assignment (??=)
    /// 21. Ternary Operator
    /// 22. Logical NOT (!)
    /// 23. String Interpolation
    /// 24. Operator Precedence
    /// </summary>
    public static class Expressions
    {
        /// <summary>
        /// Demonstrates the use of the equality operator (==) in C# for comparing values and references.
        /// </summary>
        public static void CheckEqualityOperator()
        {
            Console.WriteLine("a" == "a");     // True
            Console.WriteLine("a" == "A");     // False
            Console.WriteLine(1 == 2);         // False

            string value = "a";
            Console.WriteLine(value == "a");   // True
        }

        /// <summary>
        /// Demonstrates the use of built-in methods for equality comparison in C#.
        /// </summary>
        public static void CheckEqualityBuiltInMethods()
        {
            string value1 = " a";
            string value2 = "A ";

            Console.WriteLine(
                value1.Trim().ToLower() ==
                value2.Trim().ToLower());      // True
        }

        /// <summary>
        /// Demonstrates the use of the inequality operator (!=) in C#.
        /// </summary>
        public static void CheckInequalityOperator()
        {
            Console.WriteLine("a" != "a");     // False
            Console.WriteLine("a" != "A");     // True
            Console.WriteLine(1 != 2);         // True

            string value = "a";
            Console.WriteLine(value != "a");   // False
        }

        /// <summary>
        /// Demonstrates the use of comparison operators in C#.
        /// </summary>
        public static void CheckComparisonOperators()
        {
            Console.WriteLine(1 > 2);      // False
            Console.WriteLine(1 < 2);      // True
            Console.WriteLine(1 >= 1);     // True
            Console.WriteLine(1 <= 1);     // True
        }

        /// <summary>
        /// Demonstrates the use of boolean methods in C# for checking string properties.
        /// </summary>
        public static void CheckBooleanMethods()
        {
            string text = "The quick brown fox jumps over the lazy dog";

            Console.WriteLine(text.Contains("fox")); // True
            Console.WriteLine(text.Contains("cow")); // False
        }

        /// <summary>
        /// Demonstrates the difference between the equality operator (==) and the Equals() method in C# for comparing string values.
        /// </summary>
        public static void CheckEqualsVsDoubleEquals()
        {
            string s1 = "hello";
            string s2 = "hello";

            Console.WriteLine(s1 == s2);        // True
            Console.WriteLine(s1.Equals(s2));   // True
        }

        /// <summary>
        /// Demonstrates reference equality in C#.
        /// </summary>
        public static void CheckReferenceEquality()
        {
            string s1 = "hello";
            string s2 = new string("hello".ToCharArray());

            Console.WriteLine(s1 == s2);                       // True
            Console.WriteLine(object.ReferenceEquals(s1, s2)); // False
        }

        /// <summary>
        /// Demonstrates case-insensitive comparison in C#.
        /// </summary>
        public static void CheckCaseInsensitiveComparison()
        {
            string input = "ADMIN";

            Console.WriteLine(
                input.Equals(
                    "admin",
                    StringComparison.OrdinalIgnoreCase)); // True
        }

        /// <summary>
        /// Demonstrates null comparison in C#.
        /// </summary>
        public static void CheckNullComparison()
        {
            string value = null;

            Console.WriteLine(value == null);  // True
            Console.WriteLine(value is null);  // True
        }

        /// <summary>
        /// Demonstrates null-safe equality comparison in C#.
        /// </summary>
        public static void CheckNullSafeEquals()
        {
            string value = null;

            Console.WriteLine(
                value?.Equals("abc") ?? false); // False
        }

        /// <summary>
        /// Demonstrates short-circuit evaluation with the && operator in C#.
        /// </summary>
        public static void CheckShortCircuitAnd()
        {
            int x = -5;

            if (x > 0 && IsLessThanTen(x))
            {
                Console.WriteLine("Valid");
            }
        }

        /// <summary>
        /// Demonstrates non-short-circuit evaluation with the & operator in C#.
        /// </summary>
        public static void CheckNonShortCircuitAnd()
        {
            Console.WriteLine(FalseMethod() & TrueMethod());
        }

        /// <summary>
        /// Demonstrates short-circuit evaluation with the || operator in C#.
        /// </summary>
        public static void CheckShortCircuitOr()
        {
            Console.WriteLine(TrueMethod() || ExpensiveMethod());
        }

        /// <summary>
        /// Demonstrates non-short-circuit evaluation with the | operator in C#.
        /// </summary>
        public static void CheckNonShortCircuitOr()
        {
            Console.WriteLine(TrueMethod() | ExpensiveMethod());
        }

        /// <summary>
        /// Demonstrates case-insensitive substring matching in C#.
        /// </summary>
        public static void CheckContainsIgnoreCase()
        {
            string text = "Hello World";

            Console.WriteLine(
                text.Contains(
                    "hello",
                    StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Demonstrates floating-point comparison in C#.
        /// </summary>
        public static void CheckFloatingPointComparison()
        {
            double value = 0.1 + 0.2;

            Console.WriteLine(value == 0.3); // False

            Console.WriteLine(
                Math.Abs(value - 0.3) < 0.000001); // True
        }

        /// <summary>
        /// Demonstrates object equality in C#.
        /// </summary>
        public static void CheckObjectEquality()
        {
            Employee e1 = new Employee { Id = 1 };
            Employee e2 = new Employee { Id = 1 };

            Console.WriteLine(e1 == e2);             // False
            Console.WriteLine(e1.Equals(e2));        // False
        }

        /// <summary>
        /// Demonstrates the use of the 'is' operator in C# for type checking.
        /// </summary>
        public static void CheckIsOperator()
        {
            object value = "Ajay";

            Console.WriteLine(value is string); // True
            Console.WriteLine(value is int);    // False
        }

        /// <summary>
        /// Demonstrates pattern matching in C#.
        /// </summary>
        public static void CheckPatternMatching()
        {
            object number = 10;

            if (number is int n && n > 5)
            {
                Console.WriteLine($"Number: {n}");
            }
        }

        /// <summary>
        /// Demonstrates null coalescing in C#.
        /// </summary>
        public static void CheckNullCoalescing()
        {
            string name = null;

            Console.WriteLine(name ?? "Guest");
        }

        /// <summary>
        /// Demonstrates null coalescing assignment in C#.
        /// </summary>
        public static void CheckNullCoalescingAssignment()
        {
            List<int> numbers = null;

            numbers ??= new List<int>();

            Console.WriteLine(numbers.Count); // 0
        }

        /// <summary>
        /// Demonstrates the ternary operator in C#.
        /// </summary>
        public static void CheckTernaryOperator()
        {
            int age = 20;

            string result = age >= 18
                ? "Adult"
                : "Minor";

            Console.WriteLine(result);
        }

        /// <summary>
        /// Demonstrates the logical NOT operator in C#.
        /// </summary>
        public static void CheckLogicalNot()
        {
            bool isActive = false;

            Console.WriteLine(!isActive); // True
        }

        /// <summary>
        /// Demonstrates string interpolation in C#.
        /// </summary>
        public static void CheckStringInterpolation()
        {
            string name = "Ajay";

            Console.WriteLine($"Hello {name}");
            Console.WriteLine("Hello " + name);
        }

        /// <summary>
        /// Demonstrates operator precedence in C#.
        /// </summary>
        public static void CheckOperatorPrecedence()
        {
            Console.WriteLine(true || false && false);
            // && evaluated first
            // Result: True
        }

        /// <summary>
        /// Represents a helper method for checking if a number is less than ten.
        /// </summary>
        /// <param name="x">The number to check.</param>
        /// <returns>True if the number is less than ten, otherwise false.</returns>
        private static bool IsLessThanTen(int x)
        {
            Console.WriteLine("Second condition executed");
            return x < 10;
        }

        /// <summary>
        /// Represents a helper method that always returns true.
        /// </summary>
        /// <returns>True.</returns>
        private static bool TrueMethod()
        {
            Console.WriteLine("TrueMethod()");
            return true;
        }

        /// <summary>
        /// Represents a helper method that always returns false.
        /// </summary>
        /// <returns>False.</returns>
        private static bool FalseMethod()
        {
            Console.WriteLine("FalseMethod()");
            return false;
        }

        /// <summary>
        /// Represents a helper method that simulates an expensive operation and always returns true.
        /// </summary>
        /// <returns>True</returns>
        private static bool ExpensiveMethod()
        {
            Console.WriteLine("ExpensiveMethod()");
            return true;
        }

        /// <summary>
        /// Represents an employee with an Id property.
        /// </summary>
        private class Employee
        {
            public int Id { get; set; }
        }
    }
}