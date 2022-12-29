﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpaceBattle.Spec.Tests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class ОбработкаИсключенийFeature : object, Xunit.IClassFixture<ОбработкаИсключенийFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "ErrorHandler.feature"
#line hidden
        
        public ОбработкаИсключенийFeature(ОбработкаИсключенийFeature.FixtureData fixtureData, SpaceBattle_Spec_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Обработка исключений", "    Feature Description: Обработка исключений при выполнении команд", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="При появлении исключения писать в лог")]
        [Xunit.TraitAttribute("FeatureTitle", "Обработка исключений")]
        [Xunit.TraitAttribute("Description", "При появлении исключения писать в лог")]
        [Xunit.TraitAttribute("Category", "позитивный")]
        public void ПриПоявленииИсключенияПисатьВЛог()
        {
            string[] tagsOfScenario = new string[] {
                    "позитивный"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("При появлении исключения писать в лог", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 6
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
        testRunner.Given("есть команда MoveCommand", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
        testRunner.And("стратегия логировать исключения во время MoveCommand", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 9
        testRunner.Then("поставить команду LogCommand в очередь", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="При появлении исключения повторить команду")]
        [Xunit.TraitAttribute("FeatureTitle", "Обработка исключений")]
        [Xunit.TraitAttribute("Description", "При появлении исключения повторить команду")]
        [Xunit.TraitAttribute("Category", "позитивный")]
        public void ПриПоявленииИсключенияПовторитьКоманду()
        {
            string[] tagsOfScenario = new string[] {
                    "позитивный"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("При появлении исключения повторить команду", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 12
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 13
        testRunner.Given("есть команда MoveCommand", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 14
        testRunner.And("стратегия повторять команду после исключения", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
        testRunner.Then("поставить команду OneCommand в очередь", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="При появлении исключения повторить команду и записать в лог")]
        [Xunit.TraitAttribute("FeatureTitle", "Обработка исключений")]
        [Xunit.TraitAttribute("Description", "При появлении исключения повторить команду и записать в лог")]
        [Xunit.TraitAttribute("Category", "позитивный")]
        public void ПриПоявленииИсключенияПовторитьКомандуИЗаписатьВЛог()
        {
            string[] tagsOfScenario = new string[] {
                    "позитивный"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("При появлении исключения повторить команду и записать в лог", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 18
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 19
        testRunner.Given("есть команда MoveCommand", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 20
        testRunner.And("стратегия повторять команду после исключения", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
        testRunner.And("стратегия логировать исключения после исключения", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
        testRunner.Then("поставить в очередь команду OneCommand и лог", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="При появлении повторного исключения писать в лог")]
        [Xunit.TraitAttribute("FeatureTitle", "Обработка исключений")]
        [Xunit.TraitAttribute("Description", "При появлении повторного исключения писать в лог")]
        [Xunit.TraitAttribute("Category", "позитивный")]
        public void ПриПоявленииПовторногоИсключенияПисатьВЛог()
        {
            string[] tagsOfScenario = new string[] {
                    "позитивный"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("При появлении повторного исключения писать в лог", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 25
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 26
        testRunner.Given("есть команда MoveCommand", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 27
        testRunner.And("стратегия повторять команду после исключения", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
        testRunner.And("стратегия повторять MoveCommand еще раз", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
        testRunner.And("стратегия логировать исключения после повторного исключения", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
        testRunner.Then("поставить команду TwoCommand в очередь", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                ОбработкаИсключенийFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ОбработкаИсключенийFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
