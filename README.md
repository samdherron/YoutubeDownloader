# YoutubeDownloader
Simple Youtube downloader application written using Winforms.
Uses libvideo and MediaToolkit libraries to download mp3 songs from Youtube

Writes download history to a local json file in the user's appdata folder and queries into a listview.
You can then open tracks via a double click.

TODO:
- Add progress bar for downloads
- Possibly experiment with other nuget packages to download entire playlists at once
- Implement search feature for download grid
- Implement automatic limit for download history... example: only log the last 20 downloads so the json file remains small
