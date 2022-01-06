﻿using DynamicTechMVC.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicTechMVC.Comparers
{
    public class CompareUsers : IEqualityComparer<UserModel>
    {
        public bool Equals(UserModel x, UserModel y)
        {
            if (y == null) return false;
            if (x.Id == y.Id)
                return true;
            return false;
        }

        public int GetHashCode([DisallowNull] UserModel obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}
