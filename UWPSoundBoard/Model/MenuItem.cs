using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPSoundBoard.Model
{
    //To build Menu items when you click the hamburger button
    //Menu items should contain two things the image and the text

  public  class MenuItem
    {
        public string IconFile { get; set; }
        public SoundCategory Category { get; set; }

    }
}
