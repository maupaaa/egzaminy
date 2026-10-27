using System;
using System.Collections.Generic;
using System.Text;

namespace NF._04_01_26._01_SG
{

    public class Kosc
    {
        public static int InstanceCount = 0;

        public string[] ImageFiles = ["kosc0.png", "kosc1.png", "kosc2.png", "kosc3.png",
                                  "kosc4.png", "kosc5.png", "kosc6.png"];
        public int Pips;
        public int ImageId;
        public bool Available;

        public Kosc(int value)
        {
            if (value < 1 || value > 6)
            {
                value = 0;
            }
            Pips = value;
            ImageId = value;
            Available = true;
            InstanceCount++;
        }

        public Kosc()
        {
            int value = Random.Shared.Next(1, 7);
            Pips = value;
            ImageId = value;
            Available = true;
            InstanceCount++;
        }

        public void Roll()
        {
            if (Available)
            {
                int value = Random.Shared.Next(1, 7);
                Pips = value;
                ImageId = value;
            }
        }

        public void Block()
        {
            Available = false;
        }

        public string ToWords()
        {
            return Pips switch
            {
                1 => "jeden",
                2 => "dwa",
                3 => "trzy",
                4 => "cztery",
                5 => "pięć",
                6 => "sześć",
                _ => "zero"
            };
        }
    }
}
