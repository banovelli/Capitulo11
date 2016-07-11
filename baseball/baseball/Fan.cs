using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseball
{
    public class Fan
    {
        public Fan(Ball ball)
        {
            ball.BallInPlay += new EventHandler(ball_BallInPlay);
        }

        void ball_BallInPlay(object sender, EventArgs e)
        {
            if (e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if ((ballEventArgs.Distance < 120) && (ballEventArgs.Trajectory < 30))
                    Console.WriteLine("Torcedor: Home run! Vou tentar pegar a bola!");
                else
                    Console.WriteLine("Torcedor: AEEEEEEE!! Issso messssmo!");
            }
        }
    }
}
