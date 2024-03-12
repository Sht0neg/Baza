using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BazaDz2;

namespace BazaDz2_
{
    internal class AccessManager
    {
        private int ageLimit;

        public AccessManager(int ageLimit)
        {
            AgeLimit = ageLimit;
        }

        public int AgeLimit { get => ageLimit; set => ageLimit = (value >= 0 && value <= 130) ? value : ageLimit; }

        public bool Check(User user) {
            if (user.Age >= this.AgeLimit) {
                return true;
            }
            return false;
        }
    }
}
