using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MultiplayerManager : NetworkManager
{
    public void Start()
    {
        // Initialize multiplayer setup
        // This will be called at the start of the game
    }

    public override void OnStartServer()
    {
        // Handle server start
        base.OnStartServer();
        Debug.Log("Server Started");
    }

    public override void OnStartClient()
    {
        // Handle client start
        base.OnStartClient();
        Debug.Log("Client Started");
    }

    public void Update()
    {
        // Handle per-frame updates for multiplayer
    }
}