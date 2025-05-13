using System.Diagnostics;

namespace OOProjectBasedLeaning1
{

    public class Room
    {

        private int number;
        private int price;
        private List<Guest> guests = new List<Guest>();

        public Room(int number, int price)
        {

            this.number = number;
            this.price = price;

        }

        public override int GetHashCode()
        {

            return number;

        }

        public override bool Equals(object? obj)
        {

            if (obj is Room)
            {

                return number == (obj as Room)?.Number;

            }

            return false;

        }

        public int Number { get { return number; } }

        public virtual int Price { get { return price; } }

        public virtual Room AddGuest(Guest guest)
        {

            guests.Add(guest.AddRoom(this));

            return this;

        }

        public virtual Room AddGuest(List<Guest> guests)
        {

            guests.ForEach(guest => AddGuest(guest));

            return this;

        }

        public Room RemoveGuest(Guest guest)
        {

            guests.Remove(guest.RemoveRoom());

            return this;

        }

        public Room RemoveGuest(List<Guest> guests)
        {

            guests.ForEach(guest => RemoveGuest(guest));

            return this;

        }

        public bool HasMember()
        {

            foreach (Guest guest in guests)
            {

                if (guest.IsMember())
                {

                    return true;

                }

            }

            return false;

        }

        public bool HasVIP()
        {

            foreach (Guest guest in guests)
            {

                if (guest.IsVIP())
                {

                    return true;

                }

            }

            return false;

        }

        public bool IsEmpty()
        {

            return guests.Count is 0;

        }

    }

    public class RegularRoom : Room
    {

        public RegularRoom(int number, int price) : base(number, price)
        {

        }

        public override int Price
        {

            get
            {

                if (HasMember())
                {

                    return base.Price;

                }

                return base.Price + base.Price / 10;
            
            }
        
        }

    }

    public class SuiteRoom : Room
    {

        public SuiteRoom(int number, int price) : base(number, price)
        {
        
        }

        public override int Price
        {

            get
            {

                if (HasVIP())
                {

                    return base.Price;

                }

                return base.Price + base.Price / 10;

            }

        }

        public override Room AddGuest(Guest guest)
        {

            if (!HasMember())
            {

                // TODO
                throw new NotImplementedException();

            }

            base.AddGuest(guest);

            return this;

        }

        public override Room AddGuest(List<Guest> guests)
        {

            if (!HasMember())
            {

                // TODO
                throw new NotImplementedException();

            }

            base.AddGuest(guests);

            return this;

        }

    }

    public class NullRoom : Room, NullObject
    {

        private static NullRoom nullRoom = new NullRoom();

        private NullRoom() : base(0, 0)
        {

        }

        public static Room GetInstance()
        {

            return nullRoom;

        }

        public override Room AddGuest(Guest guest)
        {

            return this;

        }

        public override Room AddGuest(List<Guest> guests)
        {

            return this;

        }

    }

}