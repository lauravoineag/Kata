//var tv = new TvRemoteControl();
//tv.SetChannel(104);
//tv.VolumeUp();

// IChangeChannel channels = new TvRemoteControl();
// channels.SetChannel(102);
//
// IChangeVolume volume = new TvRemoteControl();
// volume.VolumeUp();
// volume.VolumeUp();
// volume.VolumeUp();
// volume.VolumeUp();
// volume.VolumeUp();
// volume.VolumeDown();
//
// Console.WriteLine();

using TvRemote.TvRemote;

void ChangeChannel(IChangeChannel control)
{
    control.SetChannel(102);
}

void ChangeVolume(IChangeVolume control)
{
    control.VolumeDown();
}

var remote = new TvRemoteControl();
remote.Status();
remote.SetChannel(102);

ChangeChannel(remote);
ChangeVolume(remote);

remote.Status();