﻿/*
 * Copyright 2007-2011 JetBrains s.r.o.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using JetBrains.TeamCity.ServiceMessages.Write.Special;
using JetBrains.TeamCity.ServiceMessages.Write.Special.Impl.Writer;
using NUnit.Framework;

namespace JetBrains.TeamCity.ServiceMessages.Tests.Write.Specials
{
  [TestFixture]
  public class TeamCityArtifactsWriterTest : TeamCityWriterBaseTest<ITeamCityArtifactsWriter>
  {
    protected override ITeamCityArtifactsWriter Create(IServiceMessageProcessor proc)
    {
      return new TeamCityArtifactsWriter(proc);
    }

    [Test]
    public void SendArtifact()
    {
      DoTest(x => x.PublishArtifact("this is artifact"), "##teamcity[publishArtifacts 'this is artifact']");
    }
  }
}