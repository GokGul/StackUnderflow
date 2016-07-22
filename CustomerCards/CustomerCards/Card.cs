using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCards
{
    abstract class Card
    {
        private int cardID;
        private String name;
        private String address;
        private String city;
        private String credit;

        public Card(String name, String address, String city, String credit)
        {
            this.name = name;
            this.address = address;
            this.city = city;
            this.credit = credit;
        }

        public abstract void Pay(int amount);

        public int getCardID()
        {
            return this.cardID;
        }

        public String getName()
        {
            return this.name;
        }

        public String getAddress()
        {
            return this.address;
        }

        public String getCity()
        {
            return this.city;
        }

        public String getCredit()
        {
            return this.credit;
        }
    }
}
