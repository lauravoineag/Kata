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

void ChangeChannel(IChangeChannel control)
{
    control.SetChannel(102);
}

void ChangeVolume(IChangeVolume control)
{
    control.VolumeDown();
}

var remote = new TvRemoteControl();
ChangeChannel(remote);
ChangeVolume(remote);


public class TvRemoteControl : IChangeChannel, IChangeVolume
{
    private int _channel = 101;
    private int _volume = 0;

    public void SetChannel(int channel)
    {
        _channel = channel;
        Console.WriteLine($"Channel set to {channel}");
    }

    public void VolumeUp()
    {
        _volume++;
        Console.WriteLine($"Volume up {_volume}");
    }

    public void VolumeDown()
    {
        _volume--;
        Console.WriteLine($"Volume down {_volume}");
    }
}

public interface IChangeChannel
{
    void SetChannel(int channel);
}

public interface IChangeVolume
{
    void VolumeUp();
    void VolumeDown();
}