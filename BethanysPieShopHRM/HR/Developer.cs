using System;

namespace BethanysPieShopHRM.HR
{
    public sealed class Developer : Employee
    {
        public Developer(int id, string first, string last, string em, DateTime bd, double? rate) : base(id, first, last, em, bd, rate)
        {
        }

    }
}
