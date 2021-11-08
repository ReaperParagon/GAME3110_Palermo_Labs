using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartySharingManager : MonoBehaviour
{
    public GameObject enterSharingRoomButton, sharingRoomNameText, sharingRoomInputField, sendPartyButton;

    public NetworkedClient networkClient;

    // Start is called before the first frame update
    void Start()
    {
        enterSharingRoomButton.GetComponent<Button>().onClick.AddListener(JoinSharingRoomButtonPressed);
        sendPartyButton.GetComponent<Button>().onClick.AddListener(SendPartyButtonPressed);

        networkClient = GetComponent<NetworkedClient>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void JoinSharingRoomButtonPressed()
    {
        string name = sharingRoomInputField.GetComponent<InputField>().text;
        networkClient.SendMessageToHost(ClientToServerSignifiers.JoingSharingRoom + "," + name);
    }


    private void SendPartyButtonPressed()
    {

    }

}
