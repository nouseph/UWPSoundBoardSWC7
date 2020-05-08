using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPSoundBoard.Model
{
   public enum SoundCategory
    {
        Animals,
        Cartoons,
        Taunts,
        Warnings
    }
  public class Sound
    {
        //Properties
        public string Name { get; set; }
        //For SoundCategory to be used as a datatype enum has to be defined first
        public SoundCategory Category { get; set; }
        public string AudioFile { get; set; }
        public string ImageFile { get; set; }

        //Constructor
        public Sound(string name,SoundCategory category)
        {
            Name = name;
            Category = category;
            ImageFile = $"/Assets/Images/{category}/{name}.png";
            AudioFile = $"/Assets/Audio/{category}/{name}.wav";

        }

    }
}
