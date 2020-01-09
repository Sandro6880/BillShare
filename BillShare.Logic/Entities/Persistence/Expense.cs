using BillShare.Contracts.Persistence;
using System;

namespace BillShare.Logic.Entities.Persistence
{
    internal class Expense : IdentityObject, IBill
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Friends { get; set; }
        public string Currency { get; set; }

        public void CopyProperties(IBill other)
        {
            //other.CheckArgument(nameof(other));
            Id = other.Id;
            Date = other.Date;
            Title = other.Title;
            Description = other.Description;
            Currency = other.Currency;
            Friends = other.Friends;
        }
        //Navigation property
        public Bill Bill { get; set; }
    }
}
