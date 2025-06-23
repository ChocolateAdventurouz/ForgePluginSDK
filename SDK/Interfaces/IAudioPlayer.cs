using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForgePlugin.Models;

namespace ForgePlugin.Interfaces
{
    public interface IAudioPlayer
    {
        /// <summary>
        /// Plays either a list containing "Track" or a Track 
        /// if track is null and the list is null, then nothing will play
        /// </summary>
        /// <param name="track">The track to play</param>
        /// <returns>Nothing - passes into PlayNextInList() automatically</returns>
        Task Play(Track track);
        Task PlayNextTrack();
        void OnTrackChanged(Track newTrack);
        Task Stop();

        void Pause();

        void Resume();

        Task PlayFX(FX fx);

        /// <summary>
        /// Warning: Do not redirect it to Play(Track) as the hook needs to work like PlayFX()
        /// Hint: You can use PlayFX() but convert Track to Fx first
        /// You don't need to handle any waiting, the command will be fired by ForgeAir once the time to hook the sweeper is reached
        /// </summary>
        /// <param name="sweeper"></param>
        /// <returns></returns>
        Task HookSweeper(Track sweeper);

        void OnPlaybackStopped();

    }
}
