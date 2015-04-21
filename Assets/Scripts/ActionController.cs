using UnityEngine;
using System.Collections;

using ServerCommands;

public class ActionController : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				while (NetworkController.inputQueue.Count>0) {
						ServerCommands.ServerCommand command = NetworkController.inputQueue.Dequeue ();
						if (command!=null){

						switch (command.type) {
						case ServerCommands.CommandEnum.BATTLE_COMMAND_CLIENT:
								{
			
										break;
								}
						case ServerCommands.CommandEnum.BATTLE_GET_CONFIG:
								{
										BattleInfo.playerId =command.battleGetConfig.playerId;
										ServerCommands.BattleGetConfig config =command.battleGetConfig;
					foreach(ServerCommands.BattleGetConfig.PlayerEntity player in config.items){
						BattleInfo.PlayerInfo addPlayer = new BattleInfo.PlayerInfo();
						addPlayer.name = player.name;
						addPlayer.playerId = player.playerId;
						addPlayer.team=player.teamType==ServerCommands.TeamType.RED?BattleInfo.TeamType.RED:BattleInfo.TeamType.BLUE;
						foreach (ShipEntity ship in player.positions){
							BattleInfo.ShipEntity shipEntity = new BattleInfo.ShipEntity();
							shipEntity.healPoints =
								ship.healPoints;
							shipEntity.id=ship.id;
							shipEntity.radius=ship.radius;
							shipEntity.x=ship.x;
							shipEntity.y=ship.y;
							shipEntity.shieldCapacity = ship.shieldCapacity;
						//	ship.armourType;
						//	ship.type;
						//	ship.weapon;
							addPlayer.ships.Add(shipEntity);
						}

					}
										
										break;
								}
						case ServerCommands.CommandEnum.BATTLE_SHIP_CONFIG:
								{
										break;
								}
						case ServerCommands.CommandEnum.START_GAME:
								{
									Debug.Log("fightId:"+command.startGame.fightId);
									int fightId = command.startGame.fightId;
									BattleInfo.fightId=fightId;

									var outerCommand = new ServerCommand { type = CommandEnum.BATTLE_GET_CONFIG };
				
									outerCommand.battleGetConfig =new ServerCommands.BattleGetConfig();
									outerCommand.battleGetConfig.fightId=fightId;
					
					
									NetworkController.queue.Enqueue(outerCommand);
									break;
								}
						}
			}

				}
		}
}
