//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public BoundsComponent bounds { get { return (BoundsComponent)GetComponent(GameComponentsLookup.Bounds); } }
    public bool hasBounds { get { return HasComponent(GameComponentsLookup.Bounds); } }

    public void AddBounds(UnityEngine.Bounds newBounds) {
        var index = GameComponentsLookup.Bounds;
        var component = (BoundsComponent)CreateComponent(index, typeof(BoundsComponent));
        component.bounds = newBounds;
        AddComponent(index, component);
    }

    public void ReplaceBounds(UnityEngine.Bounds newBounds) {
        var index = GameComponentsLookup.Bounds;
        var component = (BoundsComponent)CreateComponent(index, typeof(BoundsComponent));
        component.bounds = newBounds;
        ReplaceComponent(index, component);
    }

    public void RemoveBounds() {
        RemoveComponent(GameComponentsLookup.Bounds);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherBounds;

    public static Entitas.IMatcher<GameEntity> Bounds {
        get {
            if (_matcherBounds == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Bounds);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherBounds = matcher;
            }

            return _matcherBounds;
        }
    }
}
