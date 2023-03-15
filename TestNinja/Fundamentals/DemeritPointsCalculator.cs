using System;

namespace TestNinja.Fundamentals
{
    public class DemeritPointsCalculator
    {
        private const int SpeedLimit = 65;
        private const int MaxSpeed = 300;
        
        public int CalculateDemeritPoints(int speed)
        {
            if (speed < 0 || speed > MaxSpeed) //  -1<0 || 301>300
                throw new ArgumentOutOfRangeException();
            
            if (speed <= SpeedLimit) return 0; // 1<=65 or 65<=65
            
            const int kmPerDemeritPoint = 5;
            var demeritPoints = (speed - SpeedLimit)/kmPerDemeritPoint;

            return demeritPoints;
        }        
    }
}