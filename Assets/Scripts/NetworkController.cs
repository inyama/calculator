using UnityEngine;
using System.Collections;
using ServerCommands;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

using ProtoBuf;

public class NetworkController : MonoBehaviour {

	public string ip = "127.0.0.1";
	public int Port = 8080;
	public static Queue<ServerCommand> queue = new Queue<ServerCommand>();
	public static Queue<ServerCommand> inputQueue = new Queue<ServerCommand>();
	
	
	public static Socket Socket;
	public static bool connected = false;
	public static NetworkStream socketStream;
	private float time =0;
	//private InputField _serverNameInput = null;
	//private Text _connectionStatusText = null;
	
/*	public InputField GetServerInputField()
	{
		if (_serverNameInput==null)
		{
			foreach (var varb in FindObjectsOfType<InputField>())
			{
				Debug.Log(varb.name);
				if (varb.name.Equals("InputField"))
				{
					_serverNameInput = varb;
					Debug.Log("set an instance");
				}
			} 
		}
		return _serverNameInput;
	}
*/	
	
/*	public Text GetConnectionStatusText()
	{
		if (_connectionStatusText == null)
		{
			foreach (var varb in FindObjectsOfType<Text>())
			{
				if (varb.name.Equals("ServerAddressStatus"))
				{
					_connectionStatusText = varb;
				}
			}
		}
		return _connectionStatusText;
	}
*/	
	public void WriteConsole()
	{
	//	ip = GetServerInputField().value;
	//	GetConnectionStatusText().text = TestConnect() ? "Status: connected" : "Status: not connected";
	}
	
	
	public void TestConnect()
	{
		
		IPAddress ipAddress = IPAddress.Parse(ip);
		Socket = new Socket(
			AddressFamily.InterNetwork,
			SocketType.Stream,
			ProtocolType.Tcp
			);

		try
		{
			Socket.Connect(new IPEndPoint(ipAddress, Port));
			socketStream = new NetworkStream(Socket);
			var aaa = new ServerCommand { type = CommandEnum.LOGIN };
			aaa.login = new Login();
			aaa.login.login="aaa";
			aaa.login.password="bbb";
			//}
			Serializer.SerializeWithLengthPrefix<ServerCommands.ServerCommand>(socketStream, aaa, PrefixStyle.Base128);
			if (Socket.Poll(1000000, SelectMode.SelectRead))
			{
				var command = Serializer.DeserializeWithLengthPrefix<ServerCommand>(socketStream, PrefixStyle.Base128);
				Debug.Log(command.type);
				Debug.Log("Connected");
			}
			connected = true;
		}
		catch
		{
			print("NewWorking NOT work!");
	//		return false;
		}
	//	return true;
	}

	public void PingServer(){
		var aaa = new ServerCommand { type = CommandEnum.UNKNOWN };
		queue.Enqueue(aaa);
	}



	
	public void GetGame()
	{
		Application.LoadLevel("game");
	}
	
	// Use this for initialization
	void Start () {

	}
	
	
	private void checkPing(){
		if (time==0){
			time = Time.time;
		}
		if (time+1<Time.time){
			time = Time.time;
			PingServer();
		}
	}
	
	
	// Update is called once per frame
	void Update () {
		if (!connected) return;

		
		if (Socket.Poll(1000, SelectMode.SelectRead))
		{
			try
			{
				var command = Serializer.DeserializeWithLengthPrefix<ServerCommand>(socketStream, PrefixStyle.Base128);
				inputQueue.Enqueue(command);
				
			}
			catch (Exception e)
			{
				print(e);
				connected = false;
				return;
			}
		}
		
		checkPing();
		while (queue.Count > 0)
		{
			try
			{
				Serializer.SerializeWithLengthPrefix<ServerCommands.ServerCommand>(socketStream, queue.Dequeue(),
				                                                                   PrefixStyle.Base128);
			}
			catch (Exception e)
			{
				print(e.ToString());
				connected = false;
			}
		}
		
	}
}
