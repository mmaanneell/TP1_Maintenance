using Helper;
using Members;
using Managers;

public class ActionDisplay : IActions
{
    public void MakeChoice()
    {

        int memberTypeInput = MenuHelper.AcceptMemberType();
        var memberType = (SchoolMemberType)memberTypeInput;

        SchoolMemberManager.DisplayAll(memberType);
    }

}
