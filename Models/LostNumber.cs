using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game.Models
{
    public class LostNumber
    {
        public int FirstNoOfSequence { get; set; }
        public int SecondNoOfSequence { get; set; }
        public int ThirdNumberOfSequence { get; set; }
        public int FourthNumberOfSequence { get; set; }
        public LostNumber()
        {

        }
        public LostNumber(int FirstNoOfSequence, int SecondNoOfSequence, int ThirdNumberOfSequence, int FourthNumberOfSequence)
        {

            this.FirstNoOfSequence = FirstNoOfSequence;
            this.SecondNoOfSequence = SecondNoOfSequence;
            this.ThirdNumberOfSequence = ThirdNumberOfSequence;
            this.FirstNoOfSequence = FirstNoOfSequence;
        }
        public List<int> FindLostNumbers(int thirdNo, int FourthNo)
        {
            int secondNo = FourthNo - thirdNo;
            int firstNo = thirdNo - secondNo;
            int[] arr = new int[2];
            arr[0] = firstNo;
            arr[1] = secondNo;
            List<int> NumberList = new List<int>(2);
            NumberList.Add(firstNo);
            NumberList.Add(secondNo);
            return NumberList;
        }
    }
}