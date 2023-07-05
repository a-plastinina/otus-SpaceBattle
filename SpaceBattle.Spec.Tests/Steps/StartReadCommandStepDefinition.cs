using System.Reflection;
using FluentAssertions;
using Moq;
using SpaceBattle.App.Interface;
using SpaceBattle.Interface;
using TechTalk.SpecFlow;

namespace SpaceBattle.Spec.Tests.Steps;

[Binding]
public class StartReadCommandStepDefinition
{
    private readonly ScenarioContext _scenarioContext;
    private Mock<IEventLoop> mockEL;
    private ICommandAsync _commandStartRead;
    private Task? _newTask;

    public StartReadCommandStepDefinition(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [BeforeScenario]
    void Init()
    {
        IoC.Resolve<ICommand>("IoC.Register"
            , "Command.StartRead"
            , (object[] args) => new StartTaskReadCommand((IEventLoop)args[0])
        ).Execute();
    }
    
    [Given(@"есть очередь команд")]
    public void GivenЕстьОчередьКоманд()
    {
        mockEL = new Mock<IEventLoop>();
        mockEL.Setup(x => x.StopSignal).Returns(() => true);
        ICommand cmd;
        mockEL.Setup(x => x.Take(out cmd)).Returns(true);
        Assert.NotNull(mockEL);
    }

    [Given(@"создать команду чтения")]
    public void GivenСоздатьКомандуЧтения()
    {
        _commandStartRead = IoC.Resolve<ICommandAsync>("Command.StartRead", mockEL.Object);
        Assert.NotNull(_commandStartRead);
    }

    [When(@"запущена команда чтения очереди")]
    public void WhenЗапущенаКомандаЧтенияОчереди()
    {
        _newTask = _commandStartRead.Execute();
    }

    [Then(@"запущен новый поток")]
    public void ThenЗапущенНовыйПоток()
    {
        Assert.Equal(TaskStatus.Running, _newTask?.Status);
    }
}