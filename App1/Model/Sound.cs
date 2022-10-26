﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soundboard.Model
{
    internal enum SoundCategory
    {
        Animals,
        Cartoons,
        Sportscar,
        Warnings
    }
    internal class Sound
    {
        public string Name { get; set; }

        public string AudioFile { get; set; }
        public string ImageFile { get; set; }
        public SoundCategory Category { get; set; }

        public Sound(String name,SoundCategory category)
        {
            Name = name;
            Category = category;
            AudioFile = $"/Assets/Audio/{category}/{name}.mp3";
            ImageFile = $"/Assets/Images/{category}/{name}.png";
        }

    }
}
