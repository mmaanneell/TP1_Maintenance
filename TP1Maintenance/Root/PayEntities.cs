using SchoolManager;

public static class PayEntities
{
    
        private static readonly Dictionary<SchoolMemberType, IPayroll> Strategies = new()
        {
            [SchoolMemberType.typePrincipal] = new Principal(),
            [SchoolMemberType.typeTeacher] = new Teacher(),
            [SchoolMemberType.typeReceptionist] = new Receptionist()
        };


        public static void PayEntity(SchoolMemberType memberType)
        {
            if (Strategies.TryGetValue(memberType, out var strategy))
            {
                strategy.Pay();
            }

        }




}     
       
       
       
       
