using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    class Picture
    {
        private int Size { get; set; }
        private string Title { get; set; }
        private int HeightToGround { get; set; }
        private bool Status { get; set; }
        private int HP { get; set; }
        private int Energy { get; set; }
        private int Pos { get; set; }

        public void ToFall()
        {
            if(HeightToGround > 5)
            {
                HP -= Size * HeightToGround;
                Status = false;
            } 
            else
            {
                HP -= Size * HeightToGround;
            }
            HeightToGround = 0;
        }

        public void FlyStart()
        {
            if(Title == "Летающая картина" || Title == "Картина для полётов")
            {
                if(Energy > 5)
                {
                    Fly();
                }
                else
                {
                    FlyFail();
                }
            }
            else
            {
                FlyFail();
            }
        }

        private void Fly()
        {
            Pos += Energy / Size;
        }

        private void FlyFail()
        {
            Program.Message("Вы не можете лететь на этой картине");
        }
    }
}
