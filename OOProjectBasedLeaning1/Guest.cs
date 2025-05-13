using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProjectBasedLeaning1
{

    public interface Guest
    {

        Guest AddRoom(Room room);

        Guest RemoveRoom();

        Room StayAt();

        bool IsMember();

        bool IsVIP();

    }

    public abstract class GuestModel : Guest
    {

        private Room room = NullRoom.GetInstance();

        public GuestModel() { }

        public Guest AddRoom(Room room)
        {

            this.room = room;

            return this;

        }

        public Guest RemoveRoom()
        {

            room = NullRoom.GetInstance();

            return this;

        }

        public Room StayAt()
        {

            return room;

        }

        public abstract bool IsMember();

        public abstract bool IsVIP();

    }

}
