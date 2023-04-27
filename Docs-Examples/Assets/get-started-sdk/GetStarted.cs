using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agora.Rtc;
using UnityEngine.UI;


public class GetStarted : AgoraManager
{
    public string appID = "0cc8ea75bf504ed08d3e8f5ef3c371bf";
    public string channelName = "hussain";
    public string token = "007eJxTYLg0Z1F2pRejv7l+1MnZSyTX9en3L9Z325j1ZnbZwYY3k+YrMBgkJ1ukJpqbJqWZGpikphhYpBinWqSZpqYZJxubGyallfN4pjQEMjKEp6YyMEIhiM/OkFFaXJyYmcfAAAC/XSC4";
    // Start is called before the first frame update
    public override void Start()
    {
        // Pass your app ID, channel name, and token to AgoraManager
        _appID = appID;
        _channelName = channelName;
        _token = token;

        // Setup UI
        canvas = SetupCanvas();
        joinBtn =  AddButton("Join", new Vector3(-350, -172, 0), "Join", new Vector2(160f, 30f));
        leaveBtn =  AddButton("Leave", new Vector3(350, -172, 0), "Leave", new Vector2(160f, 30f));
        LocalView = MakeView("LocalView", new Vector3(-250, 0, 0), new Vector2(250, 250));
        RemoteView = MakeView("RemoteView", new Vector3(250, 0, 0), new Vector2(250, 250));

        // Check if the required permissions are granted.
        CheckPermissions();

        // Add click-event functions to the join and leave buttons.
        leaveBtn.GetComponent<Button>().onClick.AddListener(Leave);
        joinBtn.GetComponent<Button>().onClick.AddListener(Join);
    }
    
}


