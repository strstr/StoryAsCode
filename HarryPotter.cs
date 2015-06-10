using Humans;
using Wizards;
using Street;

//Mr. and Mrs. Dursley, of number four, Privet Drive, were proud to say that they were perfectly normal, thank you very much. 

class HarryPotterScene1 : Scene
{
    public void Chapter1()
    {
        // Mr. and Mrs. Dursley, of number four, Privet Drive, 
        Muggle MrDursley = new Muggle();
        Muggle MsDursley = new Muggle();

        MrDursley.Home = MsDursley.Home = new House(4, "Privet Drive");

        // were proud to say that they were perfectly normal, 
        MrDursley.IsNormal = true;
        MsDursley.IsNormal = true;

        // thank you very much.
        ThankYou();

        // They were the last people you'd expect to be involved in anything strange or mysterious,
        Assert(People.InvolvedIn(Anything<Strange> || Anything<Mysterious>).Last(2).TrueForAll(p => p == MrDursley || p == MsDursley));
        
        // because they just didn't hold with such nonsense.
        Assert(MrDursley.NonSense == 0 && MrDursley.NonSense == 0);
    }
}

////////////////////////////////////////////////////////////////////

// story api
interface Scene
{
    
}

// harry potter api    
interface Muggle
{
    
}

interface House
{
    
}