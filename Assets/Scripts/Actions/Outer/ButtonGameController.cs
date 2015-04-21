using UnityEngine;
using System.Collections;
using ServerCommands;

public class ButtonGameController : MonoBehaviour {

	public void StartGameAction(){

		var command = new ServerCommand { type = CommandEnum.START_GAME };

	
		NetworkController.queue.Enqueue(command);


	}

	public void MoveAction(){
		
		var command = new ServerCommand { type = CommandEnum.BATTLE_COMMAND };
		//command.battleCommand = new BattleCommand(){
		//	slotNum =1;
		//}
		
		
		NetworkController.queue.Enqueue(command);

	
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
