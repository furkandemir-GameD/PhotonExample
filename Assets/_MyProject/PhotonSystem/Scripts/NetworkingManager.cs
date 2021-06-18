using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;

public class NetworkingManager : MonoBehaviourPunCallbacks,INetworkingManager
{
    [SerializeField] private ServerProperties serverProperties;
    ///////////////////////////////// SERVER BAĞLANTILARIMIZ TAMAM İHTİYAÇ DURUMUNDA AÇILMAK İÇİN \\\\\\\\\\\\\\\\\\\

   /* void Awake() => PhotonNetwork.ConnectUsingSettings();

    public override void OnConnectedToMaster() => Debug.Log("Server Bağlantısı Sağlandı");
    public override void OnLeftLobby() => Debug.Log("Lobiden Çıkıldı");
    public override void OnLeftRoom() => Debug.Log("Odadan Çıkıldı");
    public override void OnJoinRoomFailed(short returnCode, string message) => Debug.Log("Hata: Odaya Girilemedi");
    public override void OnJoinRandomFailed(short returnCode, string message) => Debug.Log("Hata: Herhangi bir odaya girilemedi");
    public override void OnCreateRoomFailed(short returnCode, string message) => Debug.Log("Hata: Oda kurulamadı");*/

    public void ServerJoin()
    {
       /* PhotonNetwork.JoinOrCreateRoom("DefaultRoom", new RoomOptions
        {
            MaxPlayers = serverProperties.roomMaxPlayer,
            IsOpen = serverProperties.serverIsOpen,
            IsVisible = serverProperties.serverIsVisible
        },TypedLobby.Default);*/
        //GameManager.Instance.StartGame();
    }
}
