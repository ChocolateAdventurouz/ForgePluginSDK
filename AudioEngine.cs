using System;
using System.Security.Cryptography;

namespace ForgePlugin
{
    public interface IAudioEngine
    {
        // Database processing
        void GetPeakLevel(string filename);
        

        // Playback-scheduling
        void Decode(); // must return raw PCM streram
        void Enqueue();
        void Play(string device);
        void SetVolume(int volume);

        string title { get; set; }
        string artist { get; set; }
        TimeSpan totalTime { get; set; }
        TimeSpan remainingTime { get; set; }
        TimeSpan elapsedTime { get; set; }
    }


}
