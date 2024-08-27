using Core.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extentions
{
    public static class UserTypeExtentions
    {
        public static string ToDescriptionString(UserType val)
        {
            switch (val)
            {
                case UserType.Customer:
                    return "Customer";
                case UserType.Admin:
                    return "Admin";
                default:
                    return "Unknown";
            }
        }
    }
}
