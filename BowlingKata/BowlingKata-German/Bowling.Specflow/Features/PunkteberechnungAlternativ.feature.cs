﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Bowling.Specflow.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Punkteberechnung (mit alternativen Definitionen)", Description="    Als Spieler\r\n    Will ich, dass das System meine Punktezahl berechnet\r\n    Da" +
        "mit ich weiss wie gut ich bin", SourceFile="Features\\PunkteberechnungAlternativ.feature", SourceLine=2)]
    public partial class PunkteberechnungMitAlternativenDefinitionenFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PunkteberechnungAlternativ.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("de"), "Punkteberechnung (mit alternativen Definitionen)", "    Als Spieler\r\n    Will ich, dass das System meine Punktezahl berechnet\r\n    Da" +
                    "mit ich weiss wie gut ich bin", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Ein einziger Spare", SourceLine=7)]
        public virtual void EinEinzigerSpare()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Ein einziger Spare", ((string[])(null)));
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
    testRunner.Given("eine neue Bowling-Partie", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Gegeben sei ");
#line 10
    testRunner.When("ich folgende Serie werfe: 3,7,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Wenn ");
#line 11
    testRunner.Then("soll meine Punktzahl 29 sein", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dann ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Nur Spares", SourceLine=12)]
        public virtual void NurSpares()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Nur Spares", ((string[])(null)));
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
    testRunner.Given("eine neue Bowling-Partie", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Gegeben sei ");
#line 15
    testRunner.When("ich 10 mal 1 und 9 werfe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Wenn ");
#line 16
    testRunner.And("ich 1 werfe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Und ");
#line 17
    testRunner.Then("soll meine Punktzahl 110 sein", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dann ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Noch ein weiteres Anfänger-Spiel", SourceLine=18)]
        public virtual void NochEinWeiteresAnfanger_Spiel()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Noch ein weiteres Anfänger-Spiel", ((string[])(null)));
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
    testRunner.Given("eine neue Bowling-Partie", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Gegeben sei ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Pins"});
            table1.AddRow(new string[] {
                        "2"});
            table1.AddRow(new string[] {
                        "7"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "5"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "3"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "4"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "8"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
#line 21
    testRunner.When("ich werfe", ((string)(null)), table1, "Wenn ");
#line 43
    testRunner.Then("soll meine Punktzahl 43 sein", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dann ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion