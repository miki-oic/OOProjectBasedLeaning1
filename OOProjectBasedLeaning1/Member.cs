using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProjectBasedLeaning1
{

    public class NonMember : GuestModel
    {

        private string name;

        public NonMember(string name)
        {

            this.name = name;

        }

        public string Name { get { return name; } }

        public override bool IsMember()
        {

            return false;

        }

        public override bool IsVIP()
        {

            return false;

        }

    }

    public class Member : GuestModel
    {

        private string name;

        public Member(string name)
        {

            this.name = name;

        }

        public string Name { get { return name; } }

        public override bool IsMember()
        {

            return true;

        }

        public override bool IsVIP()
        {

            // TODO
            return false;

        }

    }

}
