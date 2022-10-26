using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soundboard.Model
{
    internal static class SoundManager
    {
        public static List<Sound> getSounds()
        {
            var sounds = new List<Sound>();
            sounds.Add(new Sound("Cat", SoundCategory.Animals));
            sounds.Add(new Sound("Dog", SoundCategory.Animals));
            sounds.Add(new Sound("laugh", SoundCategory.Cartoons));
            sounds.Add(new Sound("surprise", SoundCategory.Cartoons));
            sounds.Add(new Sound("Sports CarGear", SoundCategory.Sportscar));
            sounds.Add(new Sound("Sportscar slowrev", SoundCategory.Sportscar));
            sounds.Add(new Sound("alarm", SoundCategory.Warnings));
            sounds.Add(new Sound("beep", SoundCategory.Warnings));
            return sounds;

        }

    }
}
