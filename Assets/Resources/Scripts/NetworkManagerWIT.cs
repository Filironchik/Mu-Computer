using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Mirror;
using System.Linq;

public class NetworkManager : NetworkBehaviour
{
    [SerializeField] private int minPlayers = 2;
    [Scene] [SerializeField] private string menuScene = string.Empty;

    [Header("Room")]
    [SerializeField] private NetworkRoomPlayer roomPlayerPrefab = null;

    [Header("Game")]
    [SerializeField] private NetworkRoomPlayer gamePlayerPrefab = null;

}


public class SceneAttribute : PropertyAttribute { }