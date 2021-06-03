using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    public  class TimeA
    {
        private int hor;
        private int min;
        private int sec;
        private static TimeA result;
        #region Constructor
        public TimeA()
        {

        }
        public TimeA(int _hor, int _min, int _sec)
        {
            this.hor = _hor;
            this.min = _min;
            this.sec = _sec;
        }
        #endregion

        #region Public Method

        /// This function  performs the addition operatio. return  object
        public static TimeA operator +(TimeA object1, TimeA object2)
        {
            result = new TimeA();
            result.hor = object1.hor + object2.hor;
            result.min = object1.min + object2.min;
            result.sec = object1.sec + object2.sec;
            if(result.sec>60)
            {
                result.min += result.sec / 60;
                result.sec = result.sec % 60;
            }
            if (result.min > 60)
            {
                result.hor += result.min / 60;
                result.min += result.min % 60;
            }
            return result;

        }
        // This function  perform a separation operation. return object
        public static TimeA operator -(TimeA object1, TimeA object2)
        {
            result = new TimeA();
            result.hor = object1.hor - object2.hor;
            result.min = object1.min - object2.min;
            result.sec = object1.sec - object2.sec;
            if (result.sec <0)
            {
                result.min -= 1;
                result.sec += 60;
            }
            if (result.min <0)
            {
                result.hor -= 1;
                result.min += 60;
            }
            return result;
        }
       

        #endregion

        public string fResult()
        {
            return ("Natija: " + result.hor + " : " + result.min + " :" + result.sec).ToString();
        }
    }
}
