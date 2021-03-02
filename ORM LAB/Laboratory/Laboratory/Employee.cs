namespace Laboratory
{
    public class Employee
    {
        public int Id { get; set; }
        
        public string FullName { get; set; }
        
        public Company MainOffice { get; set; }
        
        public int Salary { get; set; }

        public bool ByHours { get; set; }
        
        public int Stavka { get; set; }
        
        public int Hours { get; set; }
    }
}