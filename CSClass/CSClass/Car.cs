using System;

namespace CSClass
{
    internal class Car
    {
        // carNumber : 자동차 번호
        int carNumber;
        DateTime inTime;
        DateTime outTime;

        /// <summary>
        /// 자동차가 들어온 시간 설정
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        internal void SetInTime()
        {
            this.inTime = DateTime.Now;
        }

        /// <summary>
        /// 자동차가 나간 시간 설정
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        internal void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }

        
    }
}