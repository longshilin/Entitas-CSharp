//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class TestAnyEventToGenerateEventSystem : Entitas.ReactiveSystem<TestEntity> {

    readonly Entitas.IGroup<TestEntity> _listeners;
    readonly System.Collections.Generic.List<TestEntity> _entityBuffer;
    readonly System.Collections.Generic.List<ITestAnyEventToGenerateListener> _listenerBuffer;

    public TestAnyEventToGenerateEventSystem(Contexts contexts) : base(contexts.test) {
        _listeners = contexts.test.GetGroup(TestMatcher.TestAnyEventToGenerateListener);
        _entityBuffer = new System.Collections.Generic.List<TestEntity>();
        _listenerBuffer = new System.Collections.Generic.List<ITestAnyEventToGenerateListener>();
    }

    protected override Entitas.ICollector<TestEntity> GetTrigger(Entitas.IContext<TestEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(TestMatcher.EventToGenerate)
        );
    }

    protected override bool Filter(TestEntity entity) {
        return entity.hasEventToGenerate;
    }

    protected override void Execute(System.Collections.Generic.List<TestEntity> entities) {
        foreach (var e in entities) {
            var component = e.eventToGenerate;
            foreach (var listenerEntity in _listeners.GetEntities(_entityBuffer)) {
                _listenerBuffer.Clear();
                _listenerBuffer.AddRange(listenerEntity.testAnyEventToGenerateListener.value);
                foreach (var listener in _listenerBuffer) {
                    listener.OnAnyEventToGenerate(e, component.value);
                }
            }
        }
    }
}
