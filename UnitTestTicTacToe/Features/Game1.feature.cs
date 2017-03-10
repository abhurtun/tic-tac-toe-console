﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18063
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UnitTestTicTacToe.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Tic Tac Toe")]
    public partial class TicTacToeFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Game.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Tic Tac Toe", "As a tic tac toe player\n  I want to see the results of the game\n  So that I can k" +
                    "now who won", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Three in a row")]
        public virtual void ThreeInARow()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Three in a row", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "1",
                        "2",
                        "3"});
            table1.AddRow(new string[] {
                        "4",
                        "5",
                        "6"});
            table1.AddRow(new string[] {
                        "7",
                        "8",
                        "9"});
#line 7
 testRunner.Given("a new game that looks like", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "X",
                        "O"});
            table2.AddRow(new string[] {
                        "1",
                        "7"});
            table2.AddRow(new string[] {
                        "2",
                        "8"});
            table2.AddRow(new string[] {
                        "3",
                        ""});
#line 11
    testRunner.When("we have the following sequence of moves", ((string)(null)), table2, "When ");
#line 16
    testRunner.Then("player X is declared the winner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Three in a column")]
        public virtual void ThreeInAColumn()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Three in a column", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "1",
                        "2",
                        "3"});
            table3.AddRow(new string[] {
                        "4",
                        "5",
                        "6"});
            table3.AddRow(new string[] {
                        "7",
                        "8",
                        "9"});
#line 19
 testRunner.Given("a new game that looks like", ((string)(null)), table3, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "X",
                        "O"});
            table4.AddRow(new string[] {
                        "1",
                        "3"});
            table4.AddRow(new string[] {
                        "2",
                        "6"});
            table4.AddRow(new string[] {
                        "4",
                        "9"});
#line 23
    testRunner.When("we have the following sequence of moves", ((string)(null)), table4, "When ");
#line 28
    testRunner.Then("player O is declared the winner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Three in a diagonal")]
        public virtual void ThreeInADiagonal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Three in a diagonal", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "1",
                        "2",
                        "3"});
            table5.AddRow(new string[] {
                        "4",
                        "5",
                        "6"});
            table5.AddRow(new string[] {
                        "7",
                        "8",
                        "9"});
#line 31
 testRunner.Given("a new game that looks like", ((string)(null)), table5, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "X",
                        "O"});
            table6.AddRow(new string[] {
                        "1",
                        "3"});
            table6.AddRow(new string[] {
                        "5",
                        "6"});
            table6.AddRow(new string[] {
                        "9",
                        ""});
#line 35
    testRunner.When("we have the following sequence of moves", ((string)(null)), table6, "When ");
#line 40
    testRunner.Then("player X is declared the winner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Draw")]
        public virtual void Draw()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Draw", ((string[])(null)));
#line 42
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "1",
                        "2",
                        "3"});
            table7.AddRow(new string[] {
                        "4",
                        "5",
                        "6"});
            table7.AddRow(new string[] {
                        "7",
                        "8",
                        "9"});
#line 43
    testRunner.Given("a new game that looks like", ((string)(null)), table7, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "X",
                        "O"});
            table8.AddRow(new string[] {
                        "1",
                        "2"});
            table8.AddRow(new string[] {
                        "3",
                        "4"});
            table8.AddRow(new string[] {
                        "5",
                        "7"});
            table8.AddRow(new string[] {
                        "6",
                        "9"});
            table8.AddRow(new string[] {
                        "8",
                        ""});
#line 47
    testRunner.When("we have the following sequence of moves", ((string)(null)), table8, "When ");
#line 54
    testRunner.Then("a draw is declared", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
