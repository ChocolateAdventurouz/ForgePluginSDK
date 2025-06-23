using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForgePlugin.Enums;

namespace ForgePlugin.Models
{
    /// <summary>
    /// Provides the techinical information about a track (it doesn't provide audio metadata or the columns that are in the database)
    /// </summary>
    public class Track
    {
        /// <summary>
        /// The filepath of the track - Read-only
        /// </summary>
        public string Path { get; }

        /// <summary>
        /// The track's ID in database - Read-only
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// The BPM of the track - Read-only
        /// </summary>
        public int? Bpm { get; }

        /// <summary>
        /// The duration of the track - Read-only
        /// </summary>
        public TimeSpan Duration { get; }

        /// <summary>
        /// The start point of the track - Read-only
        /// </summary>
        public TimeSpan? StartPoint { get; }

        /// <summary>
        /// The mix point of the track - Read-only
        /// MixPoint can be zero or null if the user has removed it or the crossfade duration is zero.
        /// If the track is not crossfaded, MixPoint is equal to EndPoint. 
        /// Please handle that to avoid crashes
        /// </summary>
        public TimeSpan? MixPoint { get; }
        /// <summary>
        /// The end point of the track - Read-only
        /// </summary>
        public TimeSpan? EndPoint { get; }

        /// <summary>
        /// The intro point of the track that the time prior to it can be used for hooking FXs automatically - Read-only
        /// Nullable, handle it to avoid crashes
        /// </summary>
        public TimeSpan? Intro { get; }

        /// <summary>
        /// The outro point of the track - Read-only
        /// Nullable, handle it to avoid crashes
        /// </summary>
        public TimeSpan? Outro { get; }

        /// <summary>
        /// The hook in point of the track - Read-only
        /// Hooks are used to create dynamic station jingles or by manual control (will be active utilized in the future)
        /// Nullable, handle it to avoid crashes
        /// </summary>
        public TimeSpan? HookInPoint { get; }
        /// <summary>
        /// The hook out point of the track - Read-only
        /// Hooks are used to create dynamic station jingles or by manual control (will be active utilized in the future)
        /// Nullable, handle it to avoid crashes
        /// </summary>
        public TimeSpan? HookOutPoint { get; }
        /// <summary>
        /// The type of the track (Commerial, FX, etc.)
        /// Proivided to have the audio engine configure its settings accordingly (eg. no FX and crossfade on commercials)
        /// </summary>
        public TrackType Type { get; }

        /// <summary>
        /// This is intended for ForgeAir, not for plugins unless there has to be an Fx to Track conversion
        /// </summary>
        /// <param name="type">Use TrackType.FX if you are converting an Fx to a track</param>
        /// <exception cref="ArgumentNullException"></exception>

        public Track(
           string path,
           int id,
           int? bpm,
           TimeSpan duration,
           TimeSpan? startPoint,
           TimeSpan? mixPoint,
           TimeSpan? endPoint,
           TimeSpan? intro,
           TimeSpan? outro,
           TimeSpan? hookInPoint,
           TimeSpan? hookOutPoint,
           TrackType type)
        {
            Path = path ?? throw new ArgumentNullException(nameof(path));
            Id = id;
            Bpm = bpm;
            Duration = duration;
            StartPoint = startPoint;
            MixPoint = mixPoint;
            EndPoint = endPoint;
            Intro = intro;
            Outro = outro;
            HookInPoint = hookInPoint;
            HookOutPoint = hookOutPoint;
            Type = type;
        }
    }
}
