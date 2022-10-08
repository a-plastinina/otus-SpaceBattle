using System;
using TechTalk.SpecFlow;
using FluentAssertions;
using Xunit;
using Moq;
using SpaceBattle;
using SpaceBattle.Interface;

namespace SpeceBattle.Spec.Test.Steps
{
    [Binding]
    public class MoveStepDefinition
    {
        Mock<IMovable> mockAdapter = new Mock<IMovable>();

        private readonly ScenarioContext _scenarioContext;

        public MoveStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"объект имеет позицию (.*),(.*)")]
        public void GivenPostion(int x, int y)
        {
            mockAdapter.SetupGet<Vector>(o => o.Position).Returns(new Vector(x, y)).Verifiable();
        }

        [Given(@"скорость (.*),(.*)")]
        public void AndVelocity(int x, int y)
        {
            mockAdapter.SetupGet<Vector>(o => o.Velocity).Returns(new Vector(x, y)).Verifiable();
        }

        [When(@"выполнить команду движения")]
        public void WhenMove()
        {
            new MoveCommand(mockAdapter.Object).Execute();
        }

        [Then(@"свойство позиция будет равно (.*),(.*)")]
        public void ThenTestableOutcome(int x, int y)
        {
            mockAdapter.VerifySet(o => o.Position = new Vector(x, y));
            mockAdapter.Verify();
        }

        [Given(@"позиция объекта null")]
        public void GivenPositionNull()
        {
            Vector position = null;
            mockAdapter.SetupGet<Vector>(m => m.Position).Returns(position);
        }

        [When(@"движение не удалось")]
        public void WhenMoveFail()
        {
            Action act = () => new MoveCommand(mockAdapter.Object).Execute();
            act.Should().Throw<NullReferenceException>();
        }

        [Given(@"скорость объекта null")]
        public void AndVelocityNull()
        {
            Vector velocity = null;
            mockAdapter.SetupGet<Vector>(m => m.Position).Returns(velocity);
        }

        [Then(@"свойство позиция НЕ изменено")]
        public void ThenPositionNotChanged()
        {
            mockAdapter.VerifySet(o => o.Position = It.IsAny<Vector>(), Times.Once);
            mockAdapter.Verify();
        }
    }
}