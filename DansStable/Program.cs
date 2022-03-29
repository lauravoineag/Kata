using System.Xml;
using Dan_s_Stable;

var donkey=new Donkey
{
    Age = 4,
    Colour = "White",
    Name = "Robert"
};

var pig = new Pig
{
    Age = 4,
    Weight = 3,
    Name = "Ted"
};

var horse = new Horse
{
    Age = 4,
    Speed = 10,
    Name = "Horsy"
};

var stable = new Stable();
stable.AddHorse(horse);
stable.AddDonkey(donkey);
stable.AddPig(pig);


Print.Stable(stable);




