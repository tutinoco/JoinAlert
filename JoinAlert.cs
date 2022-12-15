
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class JoinAlert : UdonSharpBehaviour
{
    [SerializeField] private AudioSource audioSource;

    public override void OnPlayerJoined(VRCPlayerApi player)
    {
        if ( Networking.LocalPlayer != player ) audioSource.Play();
    }
}
