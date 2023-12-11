public partial class Data
{
    public CoreDictionary<Entity, AbilityScore> strength = new CoreDictionary<Entity, AbilityScore>();
    public CoreDictionary<Entity, AbilityScore> dexterity = new CoreDictionary<Entity, AbilityScore>();
    public CoreDictionary<Entity, AbilityScore> constitution = new CoreDictionary<Entity, AbilityScore>();
    public CoreDictionary<Entity, AbilityScore> intelligence = new CoreDictionary<Entity, AbilityScore>();
    public CoreDictionary<Entity, AbilityScore> wisdom = new CoreDictionary<Entity, AbilityScore>();
    public CoreDictionary<Entity, AbilityScore> charisma = new CoreDictionary<Entity, AbilityScore>();
    
}

public interface IStrengthSystem : IDependency<IStrengthSystem>, IEntityTableSystem<AbilityScore>
{

}
public interface IDexteritySystem : IDependency<IDexteritySystem>, IEntityTableSystem<AbilityScore>
{

}
public interface IConstitutionSystem : IDependency<IConstitutionSystem>, IEntityTableSystem<AbilityScore>
{

}
public interface IIntelligenceSystem : IDependency<IIntelligenceSystem>, IEntityTableSystem<AbilityScore>
{

}
public interface IWisdomSystem : IDependency<IWisdomSystem>, IEntityTableSystem<AbilityScore>
{

}
public interface ICharismaSystem : IDependency<ICharismaSystem>, IEntityTableSystem<AbilityScore>
{

}

public class StrengthSystem : EntityTableSystem<AbilityScore>, IStrengthSystem
{
    public override CoreDictionary<Entity, AbilityScore> Table => IDataSystem.Resolve().Data.strength;
}
public class DexteritySystem : EntityTableSystem<AbilityScore>, IDexteritySystem
{
    public override CoreDictionary<Entity, AbilityScore> Table => IDataSystem.Resolve().Data.dexterity;
}
public class ConstitutionSystem : EntityTableSystem<AbilityScore>, IConstitutionSystem
{
    public override CoreDictionary<Entity, AbilityScore> Table => IDataSystem.Resolve().Data.constitution;
}
public class IntelligenceSystem : EntityTableSystem<AbilityScore>, IIntelligenceSystem
{
    public override CoreDictionary<Entity, AbilityScore> Table => IDataSystem.Resolve().Data.intelligence;
}
public class WisdomSystem : EntityTableSystem<AbilityScore>, IWisdomSystem
{
    public override CoreDictionary<Entity, AbilityScore> Table => IDataSystem.Resolve().Data.wisdom;
}
public class CharismaSystem : EntityTableSystem<AbilityScore>, ICharismaSystem
{
    public override CoreDictionary<Entity, AbilityScore> Table => IDataSystem.Resolve().Data.charisma;
}

public partial struct Entity
{
    public AbilityScore Strength
    {
        get { return IStrengthSystem.Resolve().Get(this); }
        set { IStrengthSystem.Resolve().Set(this, value); }
    }
    public AbilityScore Dexterity
    {
        get { return IDexteritySystem.Resolve().Get(this); }
        set { IDexteritySystem.Resolve().Set(this, value); }
    }
    public AbilityScore Constitution
    {
        get { return IConstitutionSystem.Resolve().Get(this); }
        set { IConstitutionSystem.Resolve().Set(this, value); }
    }
    public AbilityScore Intelligence
    {
        get { return IIntelligenceSystem.Resolve().Get(this); }
        set { IIntelligenceSystem.Resolve().Set(this, value); }
    }
    public AbilityScore Wisdom
    {
        get { return IWisdomSystem.Resolve().Get(this); }
        set { IWisdomSystem.Resolve().Set(this, value); }
    }
    public AbilityScore Charisma
    {
        get { return ICharismaSystem.Resolve().Get(this); }
        set { ICharismaSystem.Resolve().Set(this, value); }
    }
}

