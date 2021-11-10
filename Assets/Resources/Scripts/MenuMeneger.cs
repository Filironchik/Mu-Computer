using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class MenuMeneger : MonoBehaviour
{
    [SerializeField] private NetworkManager networkManager;

    [SerializeField] private GameObject menuPanel;
    [SerializeField] private GameObject gamePanel;

    private void Start()
    {
        menuPanel.SetActive(true);
        gamePanel.SetActive(false);
    }

    public void Host()
    {
        networkManager.StartHost();
        menuPanel.SetActive(false);
        gamePanel.SetActive(true);
    }

    public void SetIP(string ip)
    {
        networkManager.networkAddress = ip;
    }

    public void Joind()
    {
        networkManager.StartClient();
        menuPanel.SetActive(false);
        gamePanel.SetActive(true);


    }

    public void Stop()
    {
        if (networkManager.mode == NetworkManagerMode.Host)
        {
            networkManager.StopHost();
        }
        if (networkManager.mode == NetworkManagerMode.ClientOnly)
        {
            networkManager.StopClient();
        }
    }

    void Update()
    {
        
    }
}
