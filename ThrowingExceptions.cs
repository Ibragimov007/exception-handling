using System;

namespace ExceptionHandling
{
    public static class ThrowingExceptions
    {
        public static void CheckParameterAndThrowException(object obj)
        {
            // TO DO #6. Replace the method code to throw an "ArgumentNullException" exception if the "obj" parameter is null; otherwise return from the method with no actions. Use "nameof" expression to get a parameter name for an exception constructor.
            if (obj is null)
            {
                throw new ArgumentNullException(nameof(obj), "obj is null.");
            }
        }

        public static void CheckBothParametersAndThrowException(object obj1, object obj2)
        {
            // TO DO #7. Replace the method code to throw an "ArgumentNullException" exception if the "obj1" or "obj2" parameter is null; otherwise return from the method with no actions. Use "nameof" expression to get a parameter name for an exception constructor.
            if (obj1 is null || obj2 is null)
            {
                throw new ArgumentNullException(nameof(obj1), "obj1 and obj2 are null");
            }
        }

        public static string CheckStringAndThrowException(string str)
        {
            // TO DO #8. Replace the method code to throw an "ArgumentNullException" exception if the "str" parameter is null or equals to ""; otherwise return "str" value. Use string.IsNullOrEmpty method. Use "nameof" expression to get a parameter name for an exception constructor.
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException(nameof(str), "str is null or empty.");
            }

            return str;
        }

        public static string CheckBothStringsAndThrowException(string str1, string str2)
        {
            // TO DO #9. Replace the method code to throw an "ArgumentNullException" exception if the "str1" or "str2" parameter is null or equals to ""; otherwise return a concatenation of "str1" and "str2" strings. Use string.Concat method to concatenate "str1" and "str2" strings. Use "nameof" expression to get a parameter name for an exception constructor.
            if (string.IsNullOrEmpty(str1))
            {
                throw new ArgumentNullException(nameof(str1), "str1 is null or empty.");
            }

            if (string.IsNullOrEmpty(str2))
            {
                throw new ArgumentNullException(nameof(str2), "str2 is null or empty.");
            }

            return string.Concat(str1, str2);
        }

        public static int CheckEvenNumberAndThrowException(int evenNumber)
        {
            // TO DO #10. Replace the method code to throw an "ArgumentException" exception if a value of the "evenNumber" parameter is not even; otherwise return a "evenNumber" value. Use "nameof" expression to get a parameter name for an exception constructor.
            if (evenNumber % 2 != 0)
            {
                throw new ArgumentException(nameof(evenNumber), "odd number");
            }

            return evenNumber;
        }

        public static int CheckCandidateAgeAndThrowException(int candidateAge, bool isCandidateWoman)
        {
            // TO DO #11. Replace the method code to throw an "ArgumentOutOfRange" exception if a value of the "candidateAge" parameter is less than 16 or greater then 63 (for a male candidate) or 58 (for a female candidate); otherwise return "candidateAge" value. Use "nameof" expression to get a parameter name for an exception constructor.
            int minAge = 16;
            int maxAge = isCandidateWoman ? 58 : 63;

            if (candidateAge < minAge || candidateAge > maxAge)
            {
                throw new ArgumentOutOfRangeException(nameof(candidateAge), $"candidateAge is outside the valid range for a {(isCandidateWoman ? "female" : "male")} candidate.");
            }

            return candidateAge;
        }

        public static string GenerateUserCode(int day, int month, string username)
        {
            // TO DO #12. Add new code to the method to validate method parameters and throw exceptions in case of validation errors:
            // * Throw "ArgumentOutOfRangeException" exception if "day" parameter is less then 1 or greater then 31.
            // * Throw "ArgumentOutOfRangeException" exception if "month" parameter is less then 1 or greater then 12.
            // * Throw "ArgumentNullException" exception if "username" parameter is null or equals to "".
            // Use "nameof" expression to get a parameter name for an exception constructor.
            if (day < 1 || day > 31)
            {
                throw new ArgumentOutOfRangeException(nameof(day), "day is outside the valid range.");
            }

            if (month < 1 || month > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(month), "month is outside the valid range.");
            }

            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException(nameof(username), "username is null or empty.");
            }

            return $"{username}-{day}{month}";
        }
    }
}
