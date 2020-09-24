//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly NoContextComponent noContextComponent = new NoContextComponent();

    public bool isNoContext {
        get { return HasComponent(GameComponentsLookup.NoContext); }
        set {
            if (value != isNoContext) {
                var index = GameComponentsLookup.NoContext;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : noContextComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<GameEntity> _matcherNoContext;

    public static Entitas.IMatcher<GameEntity> NoContext {
        get {
            if (_matcherNoContext == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.NoContext);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherNoContext = matcher;
            }

            return _matcherNoContext;
        }
    }
}
