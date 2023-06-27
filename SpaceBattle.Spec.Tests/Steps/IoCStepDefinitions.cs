using Moq;
using FluentAssertions;
using TechTalk.SpecFlow;
using SpaceBattle.Interface;

namespace SpaceBattle.Spec.Tests.Steps
{
    [Binding]
    public class IoCStepDefinitions
    {
        Vector anyVector = new Vector(It.IsAny<int>(), It.IsAny<int>());
        Action actionRegister;
        private readonly ScenarioContext _scenarioContext;

        public IoCStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        
        [Then(@"регистрация ''")]
        public void FailedEmptyKey()
        {
            var action = () => IoC.Resolve<Vector>(string.Empty, It.IsAny<int>(), It.IsAny<int>());
            action.Should().Throw<ArgumentNullException>();
        }

        [Given(@"зарегистрован Vector")]
        public void RegisterVector()
        {
            IoC.Resolve<ICommand>("IoC.Register", "Vector", (object[] args) => { return new Vector((int)args[0], (int)args[1]); }).Execute();
        }

        [When(@"получить объект Vector")]
        public void GetVector()
        {
            actionRegister = () => IoC.Resolve<Vector>("Vector", It.IsAny<int>(), It.IsAny<int>());
        }
        
        [When(@"получить объект Vector2")]
        public void GetVector2()
        {
            actionRegister = () => IoC.Resolve<Vector>("Vector2", It.IsAny<int>(), It.IsAny<int>());
        }

        [Then(@"объект Vector не пустой")]
        public void SuccessVector()
        {
            actionRegister.Should().NotThrow();
            var vector = IoC.Resolve<Vector>("Vector", It.IsAny<int>(), It.IsAny<int>());
            vector.Should().BeOfType<Vector>();
        }

        [Then(@"не зарегистрован Vector2")]
        public void NotRegisterVector()
        {
            actionRegister.Should().Throw<NullReferenceException>();
        }

        [Given(@"не завершена регистрация Vector2")]
        public void NotCallExecute()
        {
            IoC.Resolve<ICommand>("IoC.Register", "Vector2", (object[] args) => new Vector((int)args[0], (int)args[1]));
        }

        [Given(@"зарегистрирован корабль")]
        public void RegisterShip()
        {
            IoC.Resolve<ICommand>("IoC.Register", "корабль",
                            (object[] args) => new Ship((Vector)args[0], (Vector)args[1], (int)args[2], (int)args[3]))
                .Execute();
        }

        [Then(@"создан объект корабль 1")]
        public void CreateChild()
        {
            var obj = IoC.Resolve<IUniversalObject>("корабль", anyVector, anyVector, 1, 7);
            obj.Should().NotBeNull();
            obj.Should().BeOfType<Ship>();
            obj["direction"].Should().Be(1);
        }

        [Then(@"создали команду MacroMoveCommand")]
        public void CreateCommand()
        {
            var obj = new Mock<IFuelObject>();
            obj.SetupGet<int>(x => x.Volume).Returns(200);
            obj.SetupGet<int>(x => x.FlowRate).Returns(1);

            obj.As<IMovable>().Setup(x => x.Velocity).Returns(anyVector);
            obj.As<IMovable>().Setup(x => x.Position).Returns(anyVector);

            IoC.Resolve<ICommand>("IoC.Register", "Command.Move", (object[] args) => new MacroMoveCommand((IFuelObject)args[0])).Execute();
            IoC.Resolve<ICommand>("Command.Move", obj.Object).Execute();
        }

        [Then(@"создали команду движение вперед")]
        public void CreateCommand2()
        {
            IoC.Resolve<ICommand>("IoC.Register", "MovableAdapter", (object[] args) => new MovableAdapter((IUniversalObject)args[0])).Execute();

            var obj = new Mock<IUniversalObject>();
            
            obj.Setup(x => x["velocity"]).Returns(anyVector);
            obj.Setup(x => x["position"]).Returns(anyVector);
            obj.Setup(x => x["direction"]).Returns(It.Is<int>(x => x > 0));
            obj.Setup(x => x["maxDirection"]).Returns(It.Is<int>(x => x > 0));

            IoC.Resolve<ICommand>(
                "IoC.Register", 
                "Command.Move", 
                (object[] args) => new MoveCommand(IoC.Resolve<IMovable>("MovableAdapter", obj.Object)))
            .Execute();
            IoC.Resolve<ICommand>("Command.Move", obj.Object).Execute();
        }
    }
}