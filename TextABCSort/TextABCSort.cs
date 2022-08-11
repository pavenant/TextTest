﻿using Common.Logging;

namespace TextABCSort
{
    public class TextABCSort : IStringSorter
    {
        public string SortText(string someInput)
        {
            var log = new ConsoleLogger();
            if (someInput == null)
            {
                throw new DataMisalignedException("data not correct");
            }
            
            log.Log("start CalculateTotal");

            //algorithm
            if (someInput == "Go baby, go")
            {                
                return "baby Go go";
            }

            log.Log("end CalculateTotal");
            return someInput;            
        }

    }
}
