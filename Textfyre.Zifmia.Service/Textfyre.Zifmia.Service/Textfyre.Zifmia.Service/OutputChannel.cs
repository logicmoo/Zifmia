namespace Textfyre.VM
{
    using System;

    public enum OutputChannel : uint
    {
        _LAST = 11,
        Conversation = 11,
        Help = 6,
        Hints = 5,
        Location = 2,
        Main = 1,
        Map = 7,
        Progress = 8,
        Prompt = 10,
        Score = 3,
        Theme = 9,
        Time = 4
    }
}

