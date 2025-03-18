/*
    ForgeAir Video Overlay Library -  Now Playing

   IMPORTANT: ForgeAir will call UpdateTrackMetadata() on track change. 


    UpdateTrackMetadata() => DisplayOverlay()
*/





/**
 * Updates the currently playing track with the given metadata.
 * @param {string} title - The title of the currently playing track.
 * @param {string} artist - The artist of the currently playing track.
 * @param {string} album - The album of the currently playing track.
 * @param {string} length - The length of the currently playing track in milliseconds.
 * @param {string} composer - The composer of the currently playing track.
 * @param {string} year - The year the currently playing track was released.
 * @param {string} genre - The genre of the currently playing track.
 * @param {string} category - The category of the currently playing track.
 */
export default function UpdateTrackMetadata(title, artist, album, length, composer, year, genre, category, holdinterval) {
    CurrenttrackInfo.title = title;
    CurrenttrackInfo.artist = artist;
    CurrenttrackInfo.album = album;
    CurrenttrackInfo.length = length;
    CurrenttrackInfo.composer = composer;
    CurrenttrackInfo.year = year;
    CurrenttrackInfo.genre = genre;
    CurrenttrackInfo.category = category;
    holdintervalOverlay = holdinterval;
    DisplayOverlay();
}

export function setDisplayFunction(invokeDisplayFn) {
    this.invokeDisplay = invokeDisplayFn;
}

export function DisplayOverlay() {
    if (this.invokeDisplay) {
        this.invokeDisplay(); 
    } else {
        console.error('DisplayOverlay is not defined in video overlay!');
    }
}


export let holdintervalOverlay = '';
export let nowPlayingString = '';

export let CurrenttrackInfo = {
    'title': '',
    'artist': '',
    'album': '',
    'length': '',
    'composer': '',
    'year': '',
    'genre': '',
    'category': '',
};
