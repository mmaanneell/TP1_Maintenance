namespace SchoolManager
{
    public class Employee : SchoolMember, IPayroll
    {
        public int Income {get; set;}
        
        public int Balance { get; set; }

        public Employee(string name, string address, int phoneNum, int income)
        : base(name, address, phoneNum)
        {
            Income = income;
            Balance = 0;
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}, Phone: {Phone}");
        }

        public virtual void Pay()
        {
            Balance = Util.NetworkDelay.PayEntity("Employee", Name, Balance, Income);
        }
    }
}