using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Networking : NetworkManager {

	public GameObject defaultPlayer;
    public string whatToLoad;

	public override void OnServerConnect(NetworkConnection conn)
	{
		Debug.Log("OnPlayerConnected");
	}

	public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
	{
        Debug.Log("spawn");
            defaultPlayer = Instantiate(Resources.Load(whatToLoad), new Vector3(0, 0, 0), Quaternion.identity) as GameObject;

			NetworkServer.AddPlayerForConnection(conn, defaultPlayer, playerControllerId);

	}

}
