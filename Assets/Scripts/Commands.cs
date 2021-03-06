//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: CommandEnum.proto
namespace ServerCommands
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ServerCommandEnum")]
  public partial class ServerCommandEnum : global::ProtoBuf.IExtensible
  {
    public ServerCommandEnum() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"CommandEnum")]
    public enum CommandEnum
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"UNKNOWN", Value=0)]
      UNKNOWN = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN", Value=1)]
      LOGIN = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GET_PERSONAL_DATA", Value=2)]
      GET_PERSONAL_DATA = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SET_PERSONAL_DATA", Value=3)]
      SET_PERSONAL_DATA = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"START_GAME", Value=4)]
      START_GAME = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BATTLE_COMMAND", Value=5)]
      BATTLE_COMMAND = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BATTLE_GET_CONFIG", Value=6)]
      BATTLE_GET_CONFIG = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BATTLE_SHIP_CONFIG", Value=7)]
      BATTLE_SHIP_CONFIG = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BATTLE_START_CLIENT", Value=8)]
      BATTLE_START_CLIENT = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BATTLE_COMMAND_CLIENT", Value=9)]
      BATTLE_COMMAND_CLIENT = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BATTLE_SYNC", Value=10)]
      BATTLE_SYNC = 10
    }
  
}
// Generated from: CommandBodies.proto
namespace ServerCommands
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Login")]
  public partial class Login : global::ProtoBuf.IExtensible
  {
    public Login() {}
    
    private string _login;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"login", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string login
    {
      get { return _login; }
      set { _login = value; }
    }
    private string _password;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"password", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string password
    {
      get { return _password; }
      set { _password = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetPersonalData")]
  public partial class GetPersonalData : global::ProtoBuf.IExtensible
  {
    public GetPersonalData() {}
    
    private string _login;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"login", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string login
    {
      get { return _login; }
      set { _login = value; }
    }
    private string _password;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"password", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string password
    {
      get { return _password; }
      set { _password = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SetPersonalData")]
  public partial class SetPersonalData : global::ProtoBuf.IExtensible
  {
    public SetPersonalData() {}
    
    private string _name;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"StartGame")]
  public partial class StartGame : global::ProtoBuf.IExtensible
  {
    public StartGame() {}
    
    private StartGame.GameType _gameType;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"gameType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public StartGame.GameType gameType
    {
      get { return _gameType; }
      set { _gameType = value; }
    }
    private string _url;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"url", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string url
    {
      get { return _url; }
      set { _url = value; }
    }
    private int _fightId;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"fightId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int fightId
    {
      get { return _fightId; }
      set { _fightId = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"GameType")]
    public enum GameType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"PVP", Value=0)]
      PVP = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PVE", Value=1)]
      PVE = 1
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BattleCommand")]
  public partial class BattleCommand : global::ProtoBuf.IExtensible
  {
    public BattleCommand() {}
    
    private int _fightId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"fightId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int fightId
    {
      get { return _fightId; }
      set { _fightId = value; }
    }
    private int _slotNum;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"slotNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int slotNum
    {
      get { return _slotNum; }
      set { _slotNum = value; }
    }
    private int _shipId = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"shipId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int shipId
    {
      get { return _shipId; }
      set { _shipId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ShipEntity")]
  public partial class ShipEntity : global::ProtoBuf.IExtensible
  {
    public ShipEntity() {}
    
    private float _x;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float x
    {
      get { return _x; }
      set { _x = value; }
    }
    private float _y;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float y
    {
      get { return _y; }
      set { _y = value; }
    }
    private ShipType _type;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ShipType type
    {
      get { return _type; }
      set { _type = value; }
    }
    private Weapon _weapon;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"weapon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Weapon weapon
    {
      get { return _weapon; }
      set { _weapon = value; }
    }
    private int _healPoints;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"healPoints", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int healPoints
    {
      get { return _healPoints; }
      set { _healPoints = value; }
    }
    private ArmourType _armourType;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"armourType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ArmourType armourType
    {
      get { return _armourType; }
      set { _armourType = value; }
    }
    private int _shieldCapacity;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"shieldCapacity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int shieldCapacity
    {
      get { return _shieldCapacity; }
      set { _shieldCapacity = value; }
    }
    private float _radius;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"radius", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float radius
    {
      get { return _radius; }
      set { _radius = value; }
    }
    private int _id;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BattleGetConfig")]
  public partial class BattleGetConfig : global::ProtoBuf.IExtensible
  {
    public BattleGetConfig() {}
    
    private int _width = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"width", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int width
    {
      get { return _width; }
      set { _width = value; }
    }
    private int _height = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"height", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int height
    {
      get { return _height; }
      set { _height = value; }
    }
    private readonly global::System.Collections.Generic.List<BattleGetConfig.PlayerEntity> _items = new global::System.Collections.Generic.List<BattleGetConfig.PlayerEntity>();
    [global::ProtoBuf.ProtoMember(3, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<BattleGetConfig.PlayerEntity> items
    {
      get { return _items; }
    }
  
    private int _fightId;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"fightId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int fightId
    {
      get { return _fightId; }
      set { _fightId = value; }
    }
    private int _playerId = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"playerId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int playerId
    {
      get { return _playerId; }
      set { _playerId = value; }
    }
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerEntity")]
  public partial class PlayerEntity : global::ProtoBuf.IExtensible
  {
    public PlayerEntity() {}
    
    private string _name;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _playerId;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"playerId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int playerId
    {
      get { return _playerId; }
      set { _playerId = value; }
    }
    private readonly global::System.Collections.Generic.List<ShipEntity> _positions = new global::System.Collections.Generic.List<ShipEntity>();
    [global::ProtoBuf.ProtoMember(3, Name=@"positions", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ShipEntity> positions
    {
      get { return _positions; }
    }
  
    private TeamType _teamType;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"teamType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public TeamType teamType
    {
      get { return _teamType; }
      set { _teamType = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BattleShipConfig")]
  public partial class BattleShipConfig : global::ProtoBuf.IExtensible
  {
    public BattleShipConfig() {}
    
    private int _playerId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"playerId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int playerId
    {
      get { return _playerId; }
      set { _playerId = value; }
    }
    private int _fightId;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"fightId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int fightId
    {
      get { return _fightId; }
      set { _fightId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BattleStartClient")]
  public partial class BattleStartClient : global::ProtoBuf.IExtensible
  {
    public BattleStartClient() {}
    
    private int _fightId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"fightId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int fightId
    {
      get { return _fightId; }
      set { _fightId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TargetPoint")]
  public partial class TargetPoint : global::ProtoBuf.IExtensible
  {
    public TargetPoint() {}
    
    private float _x;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float x
    {
      get { return _x; }
      set { _x = value; }
    }
    private float _y;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float y
    {
      get { return _y; }
      set { _y = value; }
    }
    private int _id;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private float _vX;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"vX", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float vX
    {
      get { return _vX; }
      set { _vX = value; }
    }
    private float _vY;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"vY", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float vY
    {
      get { return _vY; }
      set { _vY = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FireEntity")]
  public partial class FireEntity : global::ProtoBuf.IExtensible
  {
    public FireEntity() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HitEntity")]
  public partial class HitEntity : global::ProtoBuf.IExtensible
  {
    public HitEntity() {}
    
    private int _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _shield;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"shield", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int shield
    {
      get { return _shield; }
      set { _shield = value; }
    }
    private int _healPoints;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"healPoints", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int healPoints
    {
      get { return _healPoints; }
      set { _healPoints = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BattleCommandClient")]
  public partial class BattleCommandClient : global::ProtoBuf.IExtensible
  {
    public BattleCommandClient() {}
    
    private int _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private BattleCommandClientType _type;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public BattleCommandClientType type
    {
      get { return _type; }
      set { _type = value; }
    }
    private readonly global::System.Collections.Generic.List<ShipEntity> _ship = new global::System.Collections.Generic.List<ShipEntity>();
    [global::ProtoBuf.ProtoMember(3, Name=@"ship", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ShipEntity> ship
    {
      get { return _ship; }
    }
  
    private readonly global::System.Collections.Generic.List<TargetPoint> _point = new global::System.Collections.Generic.List<TargetPoint>();
    [global::ProtoBuf.ProtoMember(4, Name=@"point", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<TargetPoint> point
    {
      get { return _point; }
    }
  
    private readonly global::System.Collections.Generic.List<FireEntity> _fire = new global::System.Collections.Generic.List<FireEntity>();
    [global::ProtoBuf.ProtoMember(5, Name=@"fire", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<FireEntity> fire
    {
      get { return _fire; }
    }
  
    private readonly global::System.Collections.Generic.List<HitEntity> _hit = new global::System.Collections.Generic.List<HitEntity>();
    [global::ProtoBuf.ProtoMember(6, Name=@"hit", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<HitEntity> hit
    {
      get { return _hit; }
    }
  
    private int _time;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int time
    {
      get { return _time; }
      set { _time = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BattleSync")]
  public partial class BattleSync : global::ProtoBuf.IExtensible
  {
    public BattleSync() {}
    
    private int _fightId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"fightId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int fightId
    {
      get { return _fightId; }
      set { _fightId = value; }
    }
    private long _startTime;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"startTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long startTime
    {
      get { return _startTime; }
      set { _startTime = value; }
    }
    private long _startTimeout;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"startTimeout", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long startTimeout
    {
      get { return _startTimeout; }
      set { _startTimeout = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"ShipType")]
    public enum ShipType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"BIG", Value=1)]
      BIG = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SMALL", Value=2)]
      SMALL = 2
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"Weapon")]
    public enum Weapon
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"BIG_WEAPON", Value=1)]
      BIG_WEAPON = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SMALL_WEAPON", Value=2)]
      SMALL_WEAPON = 2
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ArmourType")]
    public enum ArmourType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"BIG_SHIELD", Value=1)]
      BIG_SHIELD = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SMALL_SHIELD", Value=2)]
      SMALL_SHIELD = 2
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"TeamType")]
    public enum TeamType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"RED", Value=1)]
      RED = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BLUE", Value=2)]
      BLUE = 2
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"BattleCommandClientType")]
    public enum BattleCommandClientType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"SPAWN", Value=1)]
      SPAWN = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DEATH", Value=2)]
      DEATH = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MOVE", Value=3)]
      MOVE = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FIRE", Value=4)]
      FIRE = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TARGETING", Value=5)]
      TARGETING = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"HIT", Value=6)]
      HIT = 6
    }
  
}
// Generated from: Commands.proto
// Note: requires additional types generated from: CommandEnum.proto
// Note: requires additional types generated from: CommandBodies.proto
namespace ServerCommands
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ServerCommand")]
  public partial class ServerCommand : global::ProtoBuf.IExtensible
  {
    public ServerCommand() {}
    
    private CommandEnum _type;
    [global::ProtoBuf.ProtoMember(10001, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public CommandEnum type
    {
      get { return _type; }
      set { _type = value; }
    }
    private Login _login = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"login", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Login login
    {
      get { return _login; }
      set { _login = value; }
    }
    private GetPersonalData _getPersonalData = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"getPersonalData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public GetPersonalData getPersonalData
    {
      get { return _getPersonalData; }
      set { _getPersonalData = value; }
    }
    private SetPersonalData _setPersonalData = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"setPersonalData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public SetPersonalData setPersonalData
    {
      get { return _setPersonalData; }
      set { _setPersonalData = value; }
    }
    private StartGame _startGame = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"startGame", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public StartGame startGame
    {
      get { return _startGame; }
      set { _startGame = value; }
    }
    private BattleCommand _battleCommand = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"battleCommand", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public BattleCommand battleCommand
    {
      get { return _battleCommand; }
      set { _battleCommand = value; }
    }
    private BattleGetConfig _battleGetConfig = null;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"battleGetConfig", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public BattleGetConfig battleGetConfig
    {
      get { return _battleGetConfig; }
      set { _battleGetConfig = value; }
    }
    private BattleShipConfig _battleShipConfig = null;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"battleShipConfig", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public BattleShipConfig battleShipConfig
    {
      get { return _battleShipConfig; }
      set { _battleShipConfig = value; }
    }
    private BattleStartClient _battleStartClient = null;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"battleStartClient", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public BattleStartClient battleStartClient
    {
      get { return _battleStartClient; }
      set { _battleStartClient = value; }
    }
    private BattleCommandClient _battleCommandClient = null;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"battleCommandClient", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public BattleCommandClient battleCommandClient
    {
      get { return _battleCommandClient; }
      set { _battleCommandClient = value; }
    }
    private BattleSync _battleSync = null;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"battleSync", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public BattleSync battleSync
    {
      get { return _battleSync; }
      set { _battleSync = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}