using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCards
{
    class RegularCard : Card
    {

        public RegularCard(String name, String address, String city, String credit)
        {

        }

        public override void Pay(int amount)
        {
            throw new NotImplementedException();
        }
    }
}
