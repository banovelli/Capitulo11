using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseball
{
    public class Pitcher
    {
        public Pitcher(Ball ball)
        {
            ball.BallInPlay += new EventHandler(ball_BallInPlay);
        }

        void ball_BallInPlay(object sender, EventArgs e)
        {
            if (e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if ((ballEventArgs.Distance < 95) && (ballEventArgs.Trajectory < 60))
                    CatchBall();
                else
                    CoverFirstBase();
            }
        }

        private void CoverFirstBase()
        {
            Console.WriteLine("Pitcher: vou cobrir a primeira base"); 
        }

        private void CatchBall()
        {
            Console.WriteLine("Pitcher: peguei a bola"); 
        }
    }
}
