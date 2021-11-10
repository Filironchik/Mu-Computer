using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public enum Role { Observers, Program, Virus, MainVirus, Antivirus, Decompiler };
public enum Command { Peaceful, NotPeaceful, Observers };

public class PlayerManager : NetworkBehaviour
{
    [SerializeField] private Role role;
    [SerializeField] private Command command;
    [SerializeField] private bool Alive;

    void Start(){}
    void Update(){}
}
