using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using SpaceBattle.App.Interface;
using SpaceBattle.Interface;
using TechTalk.SpecFlow;

namespace SpaceBattle.Spec.Tests.Features.EventLoop;

[Binding]
public sealed class HardStopCommandStepDefinition
{
    // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
    private AutoResetEvent waitHandler = new (true);  // объект-событие
    
    private readonly ScenarioContext _scenarioContext;
    private ICommandAsync? _reader;
    private IEventLoop _eventLoop;
    private Task? _task;

    [BeforeScenario]
    void Init()
    {
        IoC.Resolve<ICommand>("IoC.Register"
            , "EventLoop"
            , (object[] args) => new SpaceBattle.EventLoop()
        ).Execute();
        IoC.Resolve<ICommand>("IoC.Register"
            , "Command.StartRead"
            , (object[] args) => new StartTaskReadCommand((IEventLoop)args[0])
        ).Execute();
        IoC.Resolve<ICommand>("IoC.Register"
            , "Command.Stop.Hard"
            , (object[] args) => new HardStopCommand((IEventLoop)args[0])
        ).Execute();
        IoC.Resolve<ICommand>("IoC.Register"
            , "Command.Stop.Soft"
            , (object[] args) => new SoftStopCommand((IEventLoop)args[0])
        ).Execute();
    }
    
    public HardStopCommandStepDefinition(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [Given(@"создать очередь")]
    public void GivenСоздатьОчередь()
    {
        _eventLoop = IoC.Resolve<IEventLoop>("EventLoop");
        Assert.NotNull(_eventLoop);
    }

    [Given(@"добавить команду")]
    public void GivenДобавитьКоманду()
    {
        var before = _eventLoop.Count;
        _eventLoop.Add(new SomeCommand(0));
        Assert.Equal(++before, _eventLoop.Count);
    }

    [Given(@"добавить команду HardStop")]
    public void GivenДобавитьКомандуHardStop()
    {
        var before = _eventLoop.Count;
        _eventLoop.Add(IoC.Resolve<ICommand>("Command.Stop.Hard", _eventLoop));
        Assert.Equal(++before, _eventLoop.Count);
    }

    [Given(@"читается очередь")]
    public void GivenЧитаетсяОчередь()
    {
        _reader = IoC.Resolve<ICommandAsync>("Command.StartRead", _eventLoop);
        Assert.Equal(3, _eventLoop.Count);
        _task = _reader.Execute();
    }

    [When(@"поток останавливается")]
    public void ThenПотокОстанавливается()
    {
        Task.WaitAll(_task);
        Assert.True(_task.Status == TaskStatus.RanToCompletion);
    }

    [Then(@"в очереди осталась (.*) команда")]
    public void ThenВОчередиОсталасьКоманда(int count)
    {
        Assert.Equal(count, _eventLoop.Count);
        Assert.True(_task.IsCompletedSuccessfully);
    }

    [Given(@"добавить команду SoftStop")]
    public void GivenДобавитьКомандуSoftStop()
    {
        var before = _eventLoop.Count;
        _eventLoop.Add(IoC.Resolve<ICommand>("Command.Stop.Soft", _eventLoop));
        Assert.Equal(++before, _eventLoop.Count);
    }
}