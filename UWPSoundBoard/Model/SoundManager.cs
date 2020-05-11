using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPSoundBoard.Model
{
    //Needs only one SoundManager hence defined static .does not need instances

  public static class SoundManager
    {
        //UI will call sound manager and give an empty collection and ask to fill it will all sounds .Thats wen GetAllSounds will be called
        //Sound Manager will not create this collection . It will be already given to it.
        //List is a type of collection
        //Creating a list of Sound
        public static void GetAllSounds(ObservableCollection <Sound> sounds)
        {
            //sounds = getSounds();
            //Every type has to match getSounds() returns a list and sounds is Observable collection ..hence squiggly
            var allSounds = getSounds();
            sounds.Clear();

            // foreach(var sound in allSounds)
            // {
            //    sounds.Add(sound);

            //}
            //Instead of the above code
            allSounds.ForEach(sound => sounds.Add(sound));//lambda expression



        }
        public static void GetSoundsByCategory(ObservableCollection<Sound> sounds,SoundCategory category)
        {
            var allSounds = getSounds();
           var filteredSounds= allSounds.Where(sound => sound.Category == category).ToList();

            sounds.Clear();
            filteredSounds.ForEach(sound => sounds.Add(sound));//lambda expression

        }
        //method to return a list of sound back
        private static List<Sound> getSounds()
        {
            var sounds = new List<Sound>();
            sounds.Add(new Sound("Cow", SoundCategory.Animals));
            sounds.Add(new Sound("Cat", SoundCategory.Animals));
            sounds.Add(new Sound("Gun", SoundCategory.Cartoons));
            sounds.Add(new Sound("Spring", SoundCategory.Cartoons));
            sounds.Add(new Sound("Clock", SoundCategory.Taunts));
            sounds.Add(new Sound("LOL", SoundCategory.Taunts));
            sounds.Add(new Sound("Ship", SoundCategory.Warnings));
            sounds.Add(new Sound("Siren", SoundCategory.Warnings));
            return sounds;



        }

    }
}
