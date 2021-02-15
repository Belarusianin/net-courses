using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public enum State
    {
        Cross,
        Zero,
        Unset
    }

    public enum Winner
    {
        Crosses,
        Zeros,
        Draw,
        Unfinished
    }


    class Game
    {
        readonly State[] chests = new State[9];
        int counter = 0;

        public Game()
        {
            for (int i = 0; i < 9; i++)
            {
                chests[i] = State.Unset;
            }
        }

        public void MakeMove(int index)
        {
            chests[index - 1] = counter % 2 == 0 ? State.Cross : State.Zero;

            counter++;
        }

        public State GetState(int index)
        {
            return chests[index - 1];
        }

        //public Winner GetWinner()
        //{
        //    if ((chests[0] == chests[4] && chests[0] == chests[8] && chests[0] != State.Unset) || (chests[2] == chests[4] && chests[2] == chests[6] && chests[2] != State.Unset))
        //    {
        //        if (chests[0] == State.Cross || chests[2] == State.Cross)
        //        {
        //            return Winner.Crosses;
        //        }
        //        else
        //        {
        //            return Winner.Zeros;
        //        }
        //    }
        //    else if ((chests[0] == chests[1] && chests[0] == chests[2] && chests[0] != State.Unset) || (chests[3] == chests[4] && chests[3] == chests[5] && chests[3] != State.Unset) || (chests[6] == chests[7] && chests[6] == chests[8] && chests[6] != State.Unset))
        //    {
        //        if (chests[0] == State.Cross || chests[3] == State.Cross || chests[6] == State.Cross)
        //        {
        //            return Winner.Crosses;
        //        }
        //        else
        //        {
        //            return Winner.Zeros;
        //        }
        //    }
        //    else if ((chests[0] == chests[3] && chests[0] == chests[6] && chests[0] != State.Unset) || (chests[1] == chests[4] && chests[1] == chests[7] && chests[1] != State.Unset) || (chests[2] == chests[5] && chests[2] == chests[8] && chests[2] != State.Unset))
        //    {
        //        if ((chests[0] == State.Cross || chests[1] == State.Cross || chests[2] == State.Cross))
        //        {
        //            return Winner.Crosses;
        //        }
        //        else
        //        {
        //            return Winner.Zeros;
        //        }
        //    }

        //    if (counter < 9)
        //    {
        //        return Winner.Unfinished;
        //    }

        //    return Winner.Draw;
        //}


        public Winner GetWinner()
        {
            return GetWinner(/*vertical triplets*/1, 4, 7, 2, 5, 8, 3, 6, 9,
                /*horizontal triplets*/1, 2, 3, 4, 5, 6, 7, 8, 9,
                /*diaganals triplets*/2, 5, 9, 3, 5, 7);
        }

        Winner GetWinner(params int[] indexes)
        {
            for (int i = 0; i < indexes.Length; i+=3)
            {
                if (AreSame(indexes[i], indexes[i+1], indexes[i+2]) && GetState(indexes[i]) != State.Unset)
                {
                    return GetState(i) == State.Cross ? Winner.Crosses : Winner.Zeros;
                }
            }
            if (counter<9)
            {
                return Winner.Unfinished;
            }
            return Winner.Draw;
        }

        bool AreSame(int a,int b,int c)
        {
            return GetState(a) == GetState(b) && GetState(b) == GetState(c);
        }
    }
}
