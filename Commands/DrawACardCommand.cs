using UnityEngine;
using System.Collections;

public class DrawACardCommand : Command {
    // first argument
    // "1" - fast
    // "0" - normal

    private Player p;
    private int handPos;
    private CardLogic cl;
    private bool fast;
    private int ID;
    private bool fromDeck;

    public DrawACardCommand(CardLogic cl, Player p, int positionInHand, bool fast, bool fromDeck)
    {        
        this.cl = cl;
        this.p = p;
        handPos = positionInHand;
        this.fast = fast;
        this.fromDeck = fromDeck;
    }

    public override void StartCommandExecution()
    {
        p.PArea.PDeck.CardsInDeck--;
        p.PArea.handVisual.GivePlayerACard(cl.ca, cl.UniqueCardID, handPos, fast, fromDeck);
    }
}
