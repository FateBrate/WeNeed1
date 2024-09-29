using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeNeed1.Model.SearchObjects;

namespace WeNeed1.Model.SearchOBjects
{
    public class UserSearchObject: BaseSearchObject
    {
        public string? FirstName { get; set; }
        public int? Id { get; set; }
    }
}
