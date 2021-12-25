namespace OnionArchitecture.DomainLayer.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public decimal AmountPaid { get; set; }
    }
}
