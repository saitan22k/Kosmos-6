using UnityEngine;

public class Spaceship : MonoBehaviour
{
    public GameAgent ShipAgent;
    private void Awake()
    {
        if(ShipAgent == null)
        {
            ShipAgent = GetComponent<GameAgent>();
        }
    }

}
