using System;
using System.Collections.Generic;
using System.Text;

namespace BillShare.Contracts
{
    public partial interface IIdentifiable
    {
        int Id { get; }
    }
}
