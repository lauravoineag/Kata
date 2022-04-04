namespace TvRemote.TvRemote;

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

    public void Status()
    {
        Console.WriteLine($"Channel: {_channel}");
        Console.WriteLine($"Volume: {_volume}");
    }
}