[System.Serializable]
public partial struct Entity
{
    public static readonly Entity None = new Entity(0);
    public readonly int id; // readonly는 생성자에서만 값을 변경할 수 있음

    public Entity(int id)
    {
        this.id = id;
    }
    public static bool operator ==(Entity lhs, Entity rhs) => lhs.id == rhs.id;
    public static bool operator !=(Entity lhs, Entity rhs) => !(lhs == rhs);
    public override bool Equals(object obj) => this.Equals((Entity)obj);

    public override int GetHashCode() => id.GetHashCode();
    public bool Equals(Entity p) => this == p;

}