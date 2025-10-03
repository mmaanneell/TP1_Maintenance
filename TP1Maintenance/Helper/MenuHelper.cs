using System;
using Members;
using Helper;

namespace Helper
{
    public static class MenuHelper
    {
        public static int AcceptChoices()
        {
            return ConsoleHelper.AskNumberInput("\n1. Add\n2. Display\n3. Pay\n4. Raise Complaint\n5. Student Performance\nPlease enter the member type: ");
        }

        public static int AcceptMemberType()
        {
            int x = ConsoleHelper.AskNumberInput("\n0. Principal\n1. Teacher\n2. Student\n3. Receptionist\nPlease enter the member type: ");
            return Enum.IsDefined(typeof(SchoolMemberType), x) ? x : -1;
        }
    }
}
