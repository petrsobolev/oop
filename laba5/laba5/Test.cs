﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba5
{
    class Test:Question

    {
        public List<Question> test { get; set; }
        public int trueCaunt { get; set; }
        public int falseCaunt { get; set; }
        public void checkTest()
        {
            
            
            foreach(Question i in test)
            {
                Console.WriteLine("введите ответ");
                string response = Console.Read().ToString();

                if (i.checkQuestion(response))
                    trueCaunt++;
                else
                    falseCaunt++;
            }
            
        }
    }
}
