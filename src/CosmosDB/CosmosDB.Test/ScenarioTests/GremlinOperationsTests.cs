﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Xunit;

namespace Microsoft.Azure.Commands.CosmosDB.Test.ScenarioTests.ScenarioTest
{
    public class GremlinOperationsTests : CosmosDBTestRunner
    {
        public GremlinOperationsTests(Xunit.Abstractions.ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGremlinOperationsCmdlets()
        {
            TestRunner.RunTestScript("Test-GremlinOperationsCmdlets");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGremlinOperationsCmdletsUsingInputObject()
        {
            TestRunner.RunTestScript("Test-GremlinOperationsCmdletsUsingInputObject");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGremlinThroughputCmdlets()
        {
            TestRunner.RunTestScript("Test-GremlinThroughputCmdlets");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGremlinMigrateThroughputCmdlets()
        {
            TestRunner.RunTestScript("Test-GremlinMigrateThroughputCmdlets");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGremlinInAccountRestoreOperationsCmdlets()
        {
            TestRunner.RunTestScript("Test-GremlinInAccountRestoreOperationsCmdlets");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGremlinInAccountRestoreOperationsNoTimestampCmdlets()
        {
            TestRunner.RunTestScript("Test-GremlinInAccountRestoreOperationsNoTimestampCmdlets");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGremlinInAccountRestoreOperationsSharedRUResourcesCmdlets()
        {
            TestRunner.RunTestScript("Test-GremlinInAccountRestoreOperationsSharedRUResourcesCmdlets");
        }
    }
}