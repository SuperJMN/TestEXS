using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using ExtendedXmlSerializer.Configuration;
using ExtendedXmlSerializer.ExtensionModel.Xml;
using Installer.Core.Patching;
using Xunit;

namespace TestEXS
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var patches = new List<PatchMapping>()
            {
                new PatchMapping()
                {
                    Source = "File1.bin",
                    Destination = "EFI\\Microsoft\\Boot",
                    TargetPartition = TargetPartition.Boot,
                    Condition = new Always(),
                }
            };

            var serializer = new ConfigurationContainer()
                .EnableImplicitTypingFromNamespacePublic<PatchMapping>()
                .Create();

            using (var xmlTextWriter = new XmlTextWriter("file.xml", Encoding.UTF8) { Formatting = Formatting.Indented })
            {
                serializer.Serialize(xmlTextWriter, patches);
            }
        }
    }
}
