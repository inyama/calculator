using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BattleInfo : MonoBehaviour {
	public class PlayerInfo{
		public string name;
		public int playerId;
		public TeamType team;
		public List<ShipEntity> ships = new List<ShipEntity>();
	}
	public class ShipEntity{
		public int id;
		public int healPoints;
		public float radius;
		public float x;
		public float y;
		public int shieldCapacity;


	}

	public enum TeamType{
		RED,
		BLUE
	}
	public static int fightId;
	public static int playerId;
	public static int height;
	public static int width;

}
