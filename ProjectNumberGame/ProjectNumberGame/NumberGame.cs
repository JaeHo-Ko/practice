using System;

namespace ProjectNumberGame
{
    public class NumberGame
    {
        private int teamMember;

        public NumberGame(int numberofEmplyees)
        {
            if(numberofEmplyees < 0 || numberofEmplyees > 100000)
                throw new NotImplementedException();
            this.teamMember = numberofEmplyees;

        }

        public int[] TestArray()
        {
            int[] arrTeamMember = new int[teamMember / 2];
            return arrTeamMember;
        }
    }
}