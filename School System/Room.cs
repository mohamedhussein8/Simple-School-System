
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Room
{

    public Room()
    {
    }

    public int RoomNum { get; set; }
    public string RoomName { get; set; }

    public override string? ToString()
    {
        return $"the Room Type {this.GetType().Name} \nThe Room Number {RoomNum} \nThe Room Name {RoomName}";
    }
}