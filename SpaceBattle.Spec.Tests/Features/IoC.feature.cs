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
    public partial class СозданиеОбъектовЧерезIoCFeature : object, Xunit.IClassFixture<СозданиеОбъектовЧерезIoCFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "IoC.feature"
#line hidden
        
        public СозданиеОбъектовЧерезIoCFeature(СозданиеОбъектовЧерезIoCFeature.FixtureData fixtureData, SpaceBattle_Spec_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Создание объектов через IoC", "    Feature Description: Создание объектов через IoC", ProgrammingLanguage.CSharp, featureTags);
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
        
        [Xunit.SkippableFactAttribute(DisplayName="регистрация \'\'")]
        [Xunit.TraitAttribute("FeatureTitle", "Создание объектов через IoC")]
        [Xunit.TraitAttribute("Description", "регистрация \'\'")]
        [Xunit.TraitAttribute("Category", "негативный")]
        public void Регистрация()
        {
            string[] tagsOfScenario = new string[] {
                    "негативный"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("регистрация \'\'", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
        testRunner.Then("регистрация \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Создать класс Vector")]
        [Xunit.TraitAttribute("FeatureTitle", "Создание объектов через IoC")]
        [Xunit.TraitAttribute("Description", "Создать класс Vector")]
        [Xunit.TraitAttribute("Category", "позитивный")]
        public void СоздатьКлассVector()
        {
            string[] tagsOfScenario = new string[] {
                    "позитивный"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Создать класс Vector", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 10
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 11
        testRunner.Given("зарегистрован Vector", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 12
        testRunner.When("получить объект Vector", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
        testRunner.Then("объект Vector не пустой", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Нет зависимости Vector2")]
        [Xunit.TraitAttribute("FeatureTitle", "Создание объектов через IoC")]
        [Xunit.TraitAttribute("Description", "Нет зависимости Vector2")]
        [Xunit.TraitAttribute("Category", "негативный")]
        public void НетЗависимостиVector2()
        {
            string[] tagsOfScenario = new string[] {
                    "негативный"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Нет зависимости Vector2", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 16
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 17
        testRunner.When("получить объект Vector2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 18
        testRunner.Then("не зарегистрован Vector2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="не завершена регистрация")]
        [Xunit.TraitAttribute("FeatureTitle", "Создание объектов через IoC")]
        [Xunit.TraitAttribute("Description", "не завершена регистрация")]
        [Xunit.TraitAttribute("Category", "негативный")]
        public void НеЗавершенаРегистрация()
        {
            string[] tagsOfScenario = new string[] {
                    "негативный"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("не завершена регистрация", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 21
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 22
        testRunner.Given("не завершена регистрация Vector2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 23
        testRunner.When("получить объект Vector2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 24
        testRunner.Then("не зарегистрован Vector2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Создать класс корабль 1")]
        [Xunit.TraitAttribute("FeatureTitle", "Создание объектов через IoC")]
        [Xunit.TraitAttribute("Description", "Создать класс корабль 1")]
        [Xunit.TraitAttribute("Category", "позитивный")]
        public void СоздатьКлассКорабль1()
        {
            string[] tagsOfScenario = new string[] {
                    "позитивный"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Создать класс корабль 1", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 27
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 28
        testRunner.Given("зарегистрирован корабль", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 29
        testRunner.Then("создан объект корабль 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Создать команду MacroMoveCommand")]
        [Xunit.TraitAttribute("FeatureTitle", "Создание объектов через IoC")]
        [Xunit.TraitAttribute("Description", "Создать команду MacroMoveCommand")]
        [Xunit.TraitAttribute("Category", "позитивный")]
        public void СоздатьКомандуMacroMoveCommand()
        {
            string[] tagsOfScenario = new string[] {
                    "позитивный"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Создать команду MacroMoveCommand", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 32
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 33
        testRunner.Then("создали команду MacroMoveCommand", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Создать команду движение вперед")]
        [Xunit.TraitAttribute("FeatureTitle", "Создание объектов через IoC")]
        [Xunit.TraitAttribute("Description", "Создать команду движение вперед")]
        [Xunit.TraitAttribute("Category", "позитивный")]
        public void СоздатьКомандуДвижениеВперед()
        {
            string[] tagsOfScenario = new string[] {
                    "позитивный"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Создать команду движение вперед", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 36
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 37
        testRunner.Then("создали команду движение вперед", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
                СозданиеОбъектовЧерезIoCFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                СозданиеОбъектовЧерезIoCFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
